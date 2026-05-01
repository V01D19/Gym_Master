namespace GymMaster.Views
{
    partial class Search_Form
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvSubscribers = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colPlan = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colStart = new DataGridViewTextBoxColumn();
            colEnd = new DataGridViewTextBoxColumn();
            dgvTrainers = new DataGridView();
            colTName = new DataGridViewTextBoxColumn();
            colSpec = new DataGridViewTextBoxColumn();
            colSalary = new DataGridViewTextBoxColumn();
            colTPhone = new DataGridViewTextBoxColumn();
            txtSearchSub = new TextBox();
            txtSearchTrainers = new TextBox();
            button1 = new Button();
            btnDeleteTrainer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSubscribers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTrainers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(127, 115);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 0;
            label1.Text = "Subscribers";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(127, 322);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 0;
            label2.Text = "Trainers";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Goldenrod;
            label3.Location = new Point(328, 55);
            label3.Name = "label3";
            label3.Size = new Size(89, 32);
            label3.TabIndex = 1;
            label3.Text = "Search";
            // 
            // dgvSubscribers
            // 
            dgvSubscribers.AllowUserToAddRows = false;
            dgvSubscribers.AllowUserToDeleteRows = false;
            dgvSubscribers.AllowUserToResizeColumns = false;
            dgvSubscribers.AllowUserToResizeRows = false;
            dgvSubscribers.Anchor = AnchorStyles.None;
            dgvSubscribers.BackgroundColor = Color.FromArgb(45, 45, 45);
            dgvSubscribers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 45, 45);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Goldenrod;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSubscribers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSubscribers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubscribers.Columns.AddRange(new DataGridViewColumn[] { colName, colPhone, colPlan, colPrice, colStart, colEnd });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSubscribers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSubscribers.EnableHeadersVisualStyles = false;
            dgvSubscribers.GridColor = Color.Gray;
            dgvSubscribers.Location = new Point(127, 145);
            dgvSubscribers.MultiSelect = false;
            dgvSubscribers.Name = "dgvSubscribers";
            dgvSubscribers.ReadOnly = true;
            dgvSubscribers.RowHeadersVisible = false;
            dgvSubscribers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSubscribers.Size = new Size(599, 150);
            dgvSubscribers.TabIndex = 2;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colPhone
            // 
            colPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPhone.HeaderText = "Phone Number";
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // colPlan
            // 
            colPlan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPlan.HeaderText = "Plan Type";
            colPlan.Name = "colPlan";
            colPlan.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colStart
            // 
            colStart.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colStart.HeaderText = "Start Date";
            colStart.Name = "colStart";
            colStart.ReadOnly = true;
            // 
            // colEnd
            // 
            colEnd.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEnd.HeaderText = "End Date";
            colEnd.Name = "colEnd";
            colEnd.ReadOnly = true;
            // 
            // dgvTrainers
            // 
            dgvTrainers.AllowUserToAddRows = false;
            dgvTrainers.AllowUserToDeleteRows = false;
            dgvTrainers.AllowUserToResizeColumns = false;
            dgvTrainers.AllowUserToResizeRows = false;
            dgvTrainers.Anchor = AnchorStyles.None;
            dgvTrainers.BackgroundColor = Color.FromArgb(45, 45, 45);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 45, 45);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Goldenrod;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTrainers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTrainers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrainers.Columns.AddRange(new DataGridViewColumn[] { colTName, colSpec, colSalary, colTPhone });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvTrainers.DefaultCellStyle = dataGridViewCellStyle4;
            dgvTrainers.EnableHeadersVisualStyles = false;
            dgvTrainers.Location = new Point(127, 358);
            dgvTrainers.MultiSelect = false;
            dgvTrainers.Name = "dgvTrainers";
            dgvTrainers.ReadOnly = true;
            dgvTrainers.RowHeadersVisible = false;
            dgvTrainers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrainers.Size = new Size(599, 163);
            dgvTrainers.TabIndex = 2;
            // 
            // colTName
            // 
            colTName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTName.HeaderText = "Trainer Name";
            colTName.Name = "colTName";
            colTName.ReadOnly = true;
            // 
            // colSpec
            // 
            colSpec.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSpec.HeaderText = "Specialization";
            colSpec.Name = "colSpec";
            colSpec.ReadOnly = true;
            // 
            // colSalary
            // 
            colSalary.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSalary.HeaderText = "Salary";
            colSalary.Name = "colSalary";
            colSalary.ReadOnly = true;
            // 
            // colTPhone
            // 
            colTPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTPhone.HeaderText = "Phone Number";
            colTPhone.Name = "colTPhone";
            colTPhone.ReadOnly = true;
            // 
            // txtSearchSub
            // 
            txtSearchSub.Anchor = AnchorStyles.None;
            txtSearchSub.BackColor = Color.FromArgb(30, 30, 30);
            txtSearchSub.BorderStyle = BorderStyle.FixedSingle;
            txtSearchSub.ForeColor = Color.White;
            txtSearchSub.Location = new Point(230, 113);
            txtSearchSub.Name = "txtSearchSub";
            txtSearchSub.Size = new Size(268, 23);
            txtSearchSub.TabIndex = 3;
            txtSearchSub.TextChanged += txtSearchSub_TextChanged;
            // 
            // txtSearchTrainers
            // 
            txtSearchTrainers.Anchor = AnchorStyles.None;
            txtSearchTrainers.BackColor = Color.FromArgb(30, 30, 30);
            txtSearchTrainers.BorderStyle = BorderStyle.FixedSingle;
            txtSearchTrainers.ForeColor = Color.White;
            txtSearchTrainers.Location = new Point(230, 320);
            txtSearchTrainers.Name = "txtSearchTrainers";
            txtSearchTrainers.Size = new Size(268, 23);
            txtSearchTrainers.TabIndex = 3;
            txtSearchTrainers.TextChanged += txtSearchTrainers_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Maroon;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(651, 116);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnDelete_Click;
            // 
            // btnDeleteTrainer
            // 
            btnDeleteTrainer.Anchor = AnchorStyles.None;
            btnDeleteTrainer.BackColor = Color.Maroon;
            btnDeleteTrainer.FlatStyle = FlatStyle.Flat;
            btnDeleteTrainer.ForeColor = Color.White;
            btnDeleteTrainer.Location = new Point(651, 329);
            btnDeleteTrainer.Name = "btnDeleteTrainer";
            btnDeleteTrainer.Size = new Size(75, 23);
            btnDeleteTrainer.TabIndex = 4;
            btnDeleteTrainer.Text = "Delete";
            btnDeleteTrainer.UseVisualStyleBackColor = false;
            btnDeleteTrainer.Click += btnDeleteTrainer_Click;
            // 
            // Search_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(883, 550);
            Controls.Add(btnDeleteTrainer);
            Controls.Add(button1);
            Controls.Add(txtSearchTrainers);
            Controls.Add(txtSearchSub);
            Controls.Add(dgvTrainers);
            Controls.Add(dgvSubscribers);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Search_Form";
            Text = "Search_Form";
            Load += Search_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSubscribers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTrainers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgvSubscribers;
        private DataGridView dgvTrainers;
        private TextBox txtSearchSub;
        private TextBox txtSearchTrainers;
        private Button button1;
        private Button btnDeleteTrainer;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colPlan;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colStart;
        private DataGridViewTextBoxColumn colEnd;
        private DataGridViewTextBoxColumn colTName;
        private DataGridViewTextBoxColumn colSpec;
        private DataGridViewTextBoxColumn colSalary;
        private DataGridViewTextBoxColumn colTPhone;
    }
}