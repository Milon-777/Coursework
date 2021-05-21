
namespace Kursova
{
    partial class SignIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.eyePicture = new System.Windows.Forms.PictureBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.lockPicture = new System.Windows.Forms.PictureBox();
            this.loginPicture = new System.Windows.Forms.PictureBox();
            this.cap = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("closeButton.InitialImage")));
            this.closeButton.Location = new System.Drawing.Point(347, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(50, 50);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 12;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Checked = true;
            this.showPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showPassword.Location = new System.Drawing.Point(331, 233);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(15, 14);
            this.showPassword.TabIndex = 19;
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // eyePicture
            // 
            this.eyePicture.Image = ((System.Drawing.Image)(resources.GetObject("eyePicture.Image")));
            this.eyePicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("eyePicture.InitialImage")));
            this.eyePicture.Location = new System.Drawing.Point(313, 194);
            this.eyePicture.Name = "eyePicture";
            this.eyePicture.Size = new System.Drawing.Size(50, 30);
            this.eyePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eyePicture.TabIndex = 18;
            this.eyePicture.TabStop = false;
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordField.ForeColor = System.Drawing.Color.Gray;
            this.passwordField.Location = new System.Drawing.Point(107, 196);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(200, 48);
            this.passwordField.TabIndex = 16;
            this.passwordField.TabStop = false;
            this.passwordField.Text = "Пароль";
            this.passwordField.Click += new System.EventHandler(this.passwordField_Click);
            this.passwordField.Leave += new System.EventHandler(this.passwordField_Leave);
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.ForeColor = System.Drawing.Color.Gray;
            this.loginField.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginField.Location = new System.Drawing.Point(107, 107);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(200, 48);
            this.loginField.TabIndex = 15;
            this.loginField.TabStop = false;
            this.loginField.Text = "Логін";
            this.loginField.Click += new System.EventHandler(this.loginField_Click);
            this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
            // 
            // lockPicture
            // 
            this.lockPicture.Image = ((System.Drawing.Image)(resources.GetObject("lockPicture.Image")));
            this.lockPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("lockPicture.InitialImage")));
            this.lockPicture.Location = new System.Drawing.Point(41, 194);
            this.lockPicture.Name = "lockPicture";
            this.lockPicture.Size = new System.Drawing.Size(50, 50);
            this.lockPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lockPicture.TabIndex = 14;
            this.lockPicture.TabStop = false;
            // 
            // loginPicture
            // 
            this.loginPicture.Image = ((System.Drawing.Image)(resources.GetObject("loginPicture.Image")));
            this.loginPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("loginPicture.InitialImage")));
            this.loginPicture.Location = new System.Drawing.Point(41, 105);
            this.loginPicture.Name = "loginPicture";
            this.loginPicture.Size = new System.Drawing.Size(50, 50);
            this.loginPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginPicture.TabIndex = 13;
            this.loginPicture.TabStop = false;
            // 
            // cap
            // 
            this.cap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.cap.Dock = System.Windows.Forms.DockStyle.Top;
            this.cap.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cap.ForeColor = System.Drawing.Color.Black;
            this.cap.Location = new System.Drawing.Point(0, 0);
            this.cap.Name = "cap";
            this.cap.Size = new System.Drawing.Size(400, 60);
            this.cap.TabIndex = 2;
            this.cap.Text = "Авторизація";
            this.cap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cap_MouseDown);
            this.cap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cap_MouseMove);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(167)))), ((int)(((byte)(234)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.ForeColor = System.Drawing.Color.Black;
            this.loginButton.Location = new System.Drawing.Point(83, 270);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(234, 56);
            this.loginButton.TabIndex = 20;
            this.loginButton.Text = "Авторизуватися";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registrationButton.AutoSize = true;
            this.registrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationButton.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.Location = new System.Drawing.Point(142, 329);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(116, 19);
            this.registrationButton.TabIndex = 21;
            this.registrationButton.Text = "Немає акаунту";
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 370);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.eyePicture);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.lockPicture);
            this.Controls.Add(this.loginPicture);
            this.Controls.Add(this.cap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.PictureBox eyePicture;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.PictureBox lockPicture;
        private System.Windows.Forms.PictureBox loginPicture;
        private System.Windows.Forms.Label cap;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label registrationButton;
    }
}