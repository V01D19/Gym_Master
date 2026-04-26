namespace GymMaster.Views
{
    partial class captainForm1
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
            label3 = new Label();
            txtName = new TextBox();
            txtSalary = new TextBox();
            cmbSpecialty = new ComboBox();
            btnSave = new Button();
            btnDelete = new Button();
            listCaptains = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 31);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Captain Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 31);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 1;
            label2.Text = "Specialization";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(516, 31);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Salary";
            // 
            // txtName
            // 
            txtName.Location = new Point(47, 71);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 3;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(504, 70);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(125, 27);
            txtSalary.TabIndex = 4;
            // 
            // cmbSpecialty
            // 
            cmbSpecialty.FormattingEnabled = true;
            cmbSpecialty.Location = new Point(265, 71);
            cmbSpecialty.Name = "cmbSpecialty";
            cmbSpecialty.Size = new Size(151, 28);
            cmbSpecialty.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(680, 350);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(680, 385);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // listCaptains
            // 
            listCaptains.FormattingEnabled = true;
            listCaptains.Location = new Point(638, 12);
            listCaptains.Name = "listCaptains";
            listCaptains.Size = new Size(150, 104);
            listCaptains.TabIndex = 8;
            // 
            // captainForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listCaptains);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(cmbSpecialty);
            Controls.Add(txtSalary);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "captainForm1";
            Text = "captainForm1";
            Load += captainForm1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtSalary;
        private ComboBox cmbSpecialty;
        private Button btnSave;
        private Button btnDelete;
        private ListBox listCaptains;
    }
}