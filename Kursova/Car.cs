using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova
{
    class Car
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Price { get; set; }
        public string FuelConsumption { get; set; }
        public string Power { get; set; }

        public Car(string id, string name, string type, string price, string fuelConsumption, string power)
        {
            Id = id;
            Name = name;
            Type = type;
            Price = price;
            FuelConsumption = fuelConsumption;
            Power = power;
        }
        
    }
}
