
namespace Kursova
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.profileButton = new System.Windows.Forms.PictureBox();
            this.assortmentButton = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.feedBack = new System.Windows.Forms.LinkLabel();
            this.panel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.cap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profileButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assortmentButton)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(514, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Профіль";
            // 
            // profileButton
            // 
            this.profileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileButton.Image = ((System.Drawing.Image)(resources.GetObject("profileButton.Image")));
            this.profileButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("profileButton.InitialImage")));
            this.profileButton.Location = new System.Drawing.Point(456, 118);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(214, 201);
            this.profileButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileButton.TabIndex = 4;
            this.profileButton.TabStop = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // assortmentButton
            // 
            this.assortmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.assortmentButton.Image = ((System.Drawing.Image)(resources.GetObject("assortmentButton.Image")));
            this.assortmentButton.Location = new System.Drawing.Point(115, 104);
            this.assortmentButton.Name = "assortmentButton";
            this.assortmentButton.Size = new System.Drawing.Size(238, 228);
            this.assortmentButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.assortmentButton.TabIndex = 5;
            this.assortmentButton.TabStop = false;
            this.assortmentButton.Click += new System.EventHandler(this.assortmentButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(172, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Асортимент";
            // 
            // feedBack
            // 
            this.feedBack.AutoSize = true;
            this.feedBack.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feedBack.LinkColor = System.Drawing.Color.Black;
            this.feedBack.Location = new System.Drawing.Point(298, 359);
            this.feedBack.Name = "feedBack";
            this.feedBack.Size = new System.Drawing.Size(175, 24);
            this.feedBack.TabIndex = 7;
            this.feedBack.TabStop = true;
            this.feedBack.Text = "Зворотній зв\'язок";
            this.feedBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.feedBack_LinkClicked);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.panel.Controls.Add(this.closeButton);
            this.panel.Controls.Add(this.cap);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(800, 60);
            this.panel.TabIndex = 9;
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("closeButton.InitialImage")));
            this.closeButton.Location = new System.Drawing.Point(747, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(50, 50);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 10;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // cap
            // 
            this.cap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cap.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cap.Location = new System.Drawing.Point(0, 0);
            this.cap.Name = "cap";
            this.cap.Size = new System.Drawing.Size(800, 60);
            this.cap.TabIndex = 1;
            this.cap.Text = "Автосалон";
            this.cap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cap_MouseDown);
            this.cap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cap_MouseMove);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.feedBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.assortmentButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автосалон";
            ((System.ComponentModel.ISupportInitialize)(this.profileButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assortmentButton)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox profileButton;
        private System.Windows.Forms.PictureBox assortmentButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel feedBack;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label cap;
        private System.Windows.Forms.PictureBox closeButton;
    }
}

