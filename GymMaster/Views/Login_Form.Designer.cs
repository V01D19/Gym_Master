namespace GymMaster.Views
{
    partial class Login_Form
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
            pictureBox1 = new PictureBox();
            Login = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btnLogin = new Button();
            btnClear = new Label();
            btnExit = new Label();
            txtUsername = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._11zon_cropped;
            pictureBox1.Location = new Point(95, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.ForeColor = Color.White;
            Login.Location = new Point(95, 166);
            Login.Name = "Login";
            Login.Size = new Size(114, 36);
            Login.TabIndex = 1;
            Login.Text = "LOG IN";
            Login.Click += UserName_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(34, 258);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 1);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(34, 329);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 1);
            panel2.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Black;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(34, 390);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(236, 39);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClear
            // 
            btnClear.AutoSize = true;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(226, 361);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(44, 16);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(140, 445);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(32, 16);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.Click += btnExit_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(0, 64, 64);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(67, 232);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(220, 24);
            txtUsername.TabIndex = 0;
            txtUsername.KeyDown += txtUsername_KeyDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.profile_icon_login_head_icon_vector_Photoroom;
            pictureBox2.Location = new Point(2, 223);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.computer_icons_password_login_user_privacy_Photoroom;
            pictureBox3.Location = new Point(2, 297);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(72, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(0, 64, 64);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(59, 303);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(228, 24);
            txtPassword.TabIndex = 6;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(308, 486);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnLogin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Login);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login_Form";
            Load += Login_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Login;
        private Panel panel1;
        private Panel panel2;
        private Button btnLogin;
        private Label btnClear;
        private Label btnExit;
        private TextBox txtUsername;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txtPassword;
    }
}