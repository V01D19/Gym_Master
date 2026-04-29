namespace GymMaster.Views
{
    partial class Captins_Form
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
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtSalary = new TextBox();
            label4 = new Label();
            cmbSpecialization = new ComboBox();
            btnSave = new Button();
            label5 = new Label();
            txtPhone = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(300, 95);
            label1.Name = "label1";
            label1.Size = new Size(270, 32);
            label1.TabIndex = 0;
            label1.Text = "Management Captains";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(89, 194);
            label2.Name = "label2";
            label2.Size = new Size(110, 21);
            label2.TabIndex = 1;
            label2.Text = "Captin Name";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(30, 30, 30);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(217, 192);
            txtName.Name = "txtName";
            txtName.Size = new Size(155, 23);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            txtName.KeyDown += txtName_KeyDown;
            txtName.KeyPress += txtName_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(89, 252);
            label3.Name = "label3";
            label3.Size = new Size(118, 21);
            label3.TabIndex = 3;
            label3.Text = "Specialization";
            // 
            // txtSalary
            // 
            txtSalary.BackColor = Color.FromArgb(30, 30, 30);
            txtSalary.BorderStyle = BorderStyle.FixedSingle;
            txtSalary.ForeColor = Color.White;
            txtSalary.Location = new Point(626, 189);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(168, 23);
            txtSalary.TabIndex = 2;
            txtSalary.KeyDown += txtSalary_KeyDown;
            txtSalary.KeyPress += txtSalary_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(479, 189);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 4;
            label4.Text = "Salary";
            // 
            // cmbSpecialization
            // 
            cmbSpecialization.BackColor = Color.FromArgb(30, 30, 30);
            cmbSpecialization.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpecialization.FlatStyle = FlatStyle.Flat;
            cmbSpecialization.ForeColor = Color.White;
            cmbSpecialization.FormattingEnabled = true;
            cmbSpecialization.Items.AddRange(new object[] { "Bodybuilding", "Fitness & Cardio", "MMA / Kickboxing", "Boxing", "Crossfit", "Powerlifting", "Yoga & Stretching", "Calisthenics" });
            cmbSpecialization.Location = new Point(217, 254);
            cmbSpecialization.Name = "cmbSpecialization";
            cmbSpecialization.Size = new Size(155, 23);
            cmbSpecialization.TabIndex = 5;
            cmbSpecialization.KeyDown += cmbSpecialization_KeyDown;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Goldenrod;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(376, 435);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 47);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(479, 256);
            label5.Name = "label5";
            label5.Size = new Size(126, 21);
            label5.TabIndex = 9;
            label5.Text = "Phone Number";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(30, 30, 30);
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.ForeColor = Color.White;
            txtPhone.Location = new Point(626, 256);
            txtPhone.MaxLength = 11;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(170, 23);
            txtPhone.TabIndex = 10;
            txtPhone.KeyDown += txtPhone_KeyDown;
            txtPhone.KeyPress += textBox3_KeyPress;
            // 
            // Captins_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(884, 581);
            Controls.Add(txtPhone);
            Controls.Add(label5);
            Controls.Add(btnSave);
            Controls.Add(cmbSpecialization);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSalary);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Captins_Form";
            Text = "Captins_Form";
            Load += Captins_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtSalary;
        private Label label4;
        private ComboBox cmbSpecialization;
        private Button btnSave;
        private Label label5;
        private TextBox txtPhone;
    }
}