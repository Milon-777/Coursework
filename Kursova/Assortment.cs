using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova
{
    public partial class Assortment : Form
    {
        private string loginUser = null;
        private string passwordUser = null;
        private string phoneNumber = null;
        private string mailUser = null;
        private List<Car> cars;
        private List<Car> searchCars;
        public String _id, _name, _type, _price, _fuelConsumption, _power;

        public Assortment()
        {
            InitializeComponent();
        }

        public Assortment(string login, string password, string phone, string mail)
        {
            InitializeComponent();
            loginUser = login;
            passwordUser = password;
            phoneNumber = phone;
            mailUser = mail;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Main menu = new Main(loginUser, passwordUser, phoneNumber, mailUser);
            menu.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void cap_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void cap_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }        

        private void getAssortment()
        {
            ConnectionDB database = new ConnectionDB();
            MySqlDataReader reader = null;

            MySqlCommand command = new MySqlCommand("SELECT * FROM `cars`", database.GetConnection());

            try
            {
                database.openConnection();
                reader = command.ExecuteReader();
                cars = new List<Car>();
                Car c;
                while (reader.Read())
                {
                    string id = reader["id"].ToString();
                    string name = reader["name"].ToString();
                    string type = reader["type"].ToString();
                    string price = reader["price"].ToString();
                    string fuelConsumption = reader["fuelConsumption"].ToString();
                    string power = reader["power"].ToString();
                    c = new Car( id, name, type, price, fuelConsumption, power);
                    cars.Add(c);

                    string[] row = { c.Id, c.Name, c.Type, c.Power, c.FuelConsumption, c.Price };
                    carsGrid.Rows.Add(row);
                }
                reader.Close();
                database.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Assortment_Load(object sender, EventArgs e)
        {
            getAssortment();
        }

        private void searchCar()
        {
            String query = $"SELECT * FROM `cars` WHERE ";
            String parametr = "";
            if (searchText.Text != "")
            {
                parametr = $"`name` LIKE '%{searchText.Text}%'";
            }
            if (min.Text != "" || max.Text != "")
            {
                if (min.Text != "" && max.Text == "")
                {
                    if (parametr.Length == 0)
                    {
                        parametr = $"`price` >= {Convert.ToInt32(min.Text)}";
                    }
                    else
                    {
                        parametr += $" AND `price` >= {Convert.ToInt32(min.Text)}";
                    }
                }
                else if (min.Text == "" && max.Text != "")
                {
                    if (parametr.Length == 0)
                    {
                        parametr = $"`price` <= {Convert.ToInt32(max.Text)}";
                    }
                    else
                    {
                        parametr += $" AND `price` <= {Convert.ToInt32(max.Text)}";
                    }
                }
                else if (min.Text != "" && max.Text != "")
                {
                    if (parametr.Length == 0)
                    {
                        parametr = $"`price` BETWEEN {Convert.ToInt32(min.Text)} AND {Convert.ToInt32(max.Text)}";
                    }
                    else
                    {
                        parametr += $" AND `price` BETWEEN {Convert.ToInt32(min.Text)} AND {Convert.ToInt32(max.Text)}";
                    }
                }
            }

            String Types = $"";
            String and = $" AND ";

            if (checkedListType.CheckedItems.Count != 0)
            {

                for (int i = 0; i < checkedListType.CheckedItems.Count; i++)
                {
                    if (i == 0)
                    {
                        Types += $"(`type`=N'{checkedListType.CheckedItems[i]}'";
                    }
                    else
                    {
                        Types += $" OR `type`=N'{checkedListType.CheckedItems[i]}'";
                    }
                }
            }
            if (parametr.Length != 0)
            {
                and += Types;

                if (Types.Length != 0)
                {
                    query += parametr + and + ")";
                }
                else
                {
                    query += parametr;
                }
            }
            else
            {
                query += Types+ ")";
            }

            ConnectionDB database = new ConnectionDB();
            MySqlDataReader reader = null;

            MySqlCommand command = new MySqlCommand(query, database.GetConnection());

            try
            {
                database.openConnection();
                reader = command.ExecuteReader();
                searchCars = new List<Car>();
                Car c;
                while (reader.Read())
                {
                    string id = reader["id"].ToString();
                    string name = reader["name"].ToString();
                    string type = reader["type"].ToString();
                    string price = reader["price"].ToString();
                    string fuelConsumption = reader["fuelConsumption"].ToString();
                    string power = reader["power"].ToString();
                    c = new Car(id, name, type, price, fuelConsumption, power);
                    cars.Add(c);

                    string[] row = { c.Id, c.Name, c.Type, c.Power, c.FuelConsumption, c.Price };
                    carsGrid.Rows.Add(row);
                }
                reader.Close();
                database.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void searchButton_Click(object sender, EventArgs e)
        {            
            carsGrid.Rows.Clear();
            searchCar();            
        }

        private void clearCheckedList()
        {
            IEnumerator myEnumerator;
            myEnumerator = checkedListType.CheckedIndices.GetEnumerator();
            int y;
            while (myEnumerator.MoveNext() != false)
            {
                y = (int)myEnumerator.Current;
                checkedListType.SetItemChecked(y, false);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            searchText.Clear();
            carsGrid.Rows.Clear();
            min.Clear();
            max.Clear();
            clearCheckedList();
            foreach (Car c in cars)
            {
                string[] row = {c.Id, c.Name, c.Type, c.Power, c.FuelConsumption, c.Price };
                carsGrid.Rows.Add(row);
            }
        }

        public void getInfo()
        {
            int row = carsGrid.SelectedCells[0].RowIndex;
            _id = carsGrid.Rows[row].Cells["id"].Value.ToString();
            _name = carsGrid.Rows[row].Cells["carName"].Value.ToString();
            _type = carsGrid.Rows[row].Cells["Type"].Value.ToString();
            _price = carsGrid.Rows[row].Cells["price"].Value.ToString();
            _fuelConsumption = carsGrid.Rows[row].Cells["fuelConsumption"].Value.ToString();
            _power = carsGrid.Rows[row].Cells["Power"].Value.ToString();

        }
        private void buyButton_Click(object sender, EventArgs e)
        {
            getInfo();
            ConnectionDB database = new ConnectionDB();
            MySqlDataReader reader = null;

            MySqlCommand command = new MySqlCommand("INSERT INTO `orders` (`loginUser`, `carName`, `dateOrder`) VALUES(@login, @car, @date)", database.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@car", MySqlDbType.VarChar).Value = _name;
            command.Parameters.Add("@date", MySqlDbType.DateTime).Value = DateTime.Now;
            try
            {
                database.openConnection();
                reader = command.ExecuteReader();
                MessageBox.Show("Авто успішно придбано!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);

                reader.Close();
                database.closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
