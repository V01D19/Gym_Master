using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GymMaster.Logic
{
    public partial class Logic_Form : Form
    {
        private TextBox txtEndDate;
        private DateTimePicker dtStartDate;
        private Label lblMainTitle, lblStartTag, lblEndTag, lblSelectType;
        private Button btnMonth, btn3Months, btn6Months, btnYear;
        private Label UserName;
        private TextBox txtName;
        private Label Number;
        private TextBox txtPhone;
        private Button btnSubscribe;

        public Logic_Form()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

            InitializeComponent();
            btnSubscribe.Click += btnSubscribe_Click;
            txtName.KeyPress += (s, e) =>
            {
                if (char.IsDigit(e.KeyChar)) e.Handled = true;
            };

            txtPhone.MaxLength = 11;
            txtPhone.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            };


            this.FormClosed += (s, e) => Application.Exit();
        }

        private void InitializeComponent()
        {
            txtEndDate = new TextBox();
            dtStartDate = new DateTimePicker();
            lblMainTitle = new Label();
            lblStartTag = new Label();
            lblEndTag = new Label();
            lblSelectType = new Label();
            btnMonth = new Button();
            btn3Months = new Button();
            btn6Months = new Button();
            btnYear = new Button();
            btnSubscribe = new Button();
            UserName = new Label();
            txtName = new TextBox();
            Number = new Label();
            txtPhone = new TextBox();
            SuspendLayout();
            // 
            // txtEndDate
            // 
            txtEndDate.Anchor = AnchorStyles.None;
            txtEndDate.BackColor = Color.Black;
            txtEndDate.ForeColor = Color.Lime;
            txtEndDate.Location = new Point(621, 167);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.ReadOnly = true;
            txtEndDate.Size = new Size(139, 23);
            txtEndDate.TabIndex = 9;
            txtEndDate.TextAlign = HorizontalAlignment.Center;
            // 
            // dtStartDate
            // 
            dtStartDate.Anchor = AnchorStyles.None;
            dtStartDate.Location = new Point(621, 129);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(139, 23);
            dtStartDate.TabIndex = 2;
            // 
            // lblMainTitle
            // 
            lblMainTitle.Anchor = AnchorStyles.None;
            lblMainTitle.AutoSize = true;
            lblMainTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMainTitle.ForeColor = Color.Goldenrod;
            lblMainTitle.Location = new Point(245, 57);
            lblMainTitle.Name = "lblMainTitle";
            lblMainTitle.Size = new Size(454, 32);
            lblMainTitle.TabIndex = 0;
            lblMainTitle.Text = "GymMaster Subscription Management";
            // 
            // lblStartTag
            // 
            lblStartTag.Anchor = AnchorStyles.None;
            lblStartTag.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStartTag.ForeColor = Color.White;
            lblStartTag.Location = new Point(462, 130);
            lblStartTag.Name = "lblStartTag";
            lblStartTag.Size = new Size(100, 23);
            lblStartTag.TabIndex = 1;
            lblStartTag.Text = "Start Date:";
            // 
            // lblEndTag
            // 
            lblEndTag.Anchor = AnchorStyles.None;
            lblEndTag.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndTag.ForeColor = Color.White;
            lblEndTag.Location = new Point(462, 167);
            lblEndTag.Name = "lblEndTag";
            lblEndTag.Size = new Size(100, 23);
            lblEndTag.TabIndex = 8;
            lblEndTag.Text = "End Date:";
            // 
            // lblSelectType
            // 
            lblSelectType.Anchor = AnchorStyles.None;
            lblSelectType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectType.ForeColor = Color.White;
            lblSelectType.Location = new Point(334, 219);
            lblSelectType.Name = "lblSelectType";
            lblSelectType.Size = new Size(278, 37);
            lblSelectType.TabIndex = 3;
            lblSelectType.Text = "Select Subscription Type:";
            // 
            // btnMonth
            // 
            btnMonth.Anchor = AnchorStyles.None;
            btnMonth.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMonth.ForeColor = Color.White;
            btnMonth.Location = new Point(322, 259);
            btnMonth.Name = "btnMonth";
            btnMonth.Size = new Size(100, 32);
            btnMonth.TabIndex = 4;
            btnMonth.Text = "1 Month";
            btnMonth.Click += btnMonth_Click;
            // 
            // btn3Months
            // 
            btn3Months.Anchor = AnchorStyles.None;
            btn3Months.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3Months.ForeColor = Color.White;
            btn3Months.Location = new Point(462, 259);
            btn3Months.Name = "btn3Months";
            btn3Months.Size = new Size(100, 32);
            btn3Months.TabIndex = 5;
            btn3Months.Text = "3 Months";
            btn3Months.Click += btn3Month_Click;
            // 
            // btn6Months
            // 
            btn6Months.Anchor = AnchorStyles.None;
            btn6Months.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btn6Months.ForeColor = Color.White;
            btn6Months.Location = new Point(322, 338);
            btn6Months.Name = "btn6Months";
            btn6Months.Size = new Size(100, 32);
            btn6Months.TabIndex = 6;
            btn6Months.Text = "6 Months";
            btn6Months.Click += btn6Month_Click;
            // 
            // btnYear
            // 
            btnYear.Anchor = AnchorStyles.None;
            btnYear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnYear.ForeColor = Color.White;
            btnYear.Location = new Point(462, 338);
            btnYear.Name = "btnYear";
            btnYear.Size = new Size(100, 32);
            btnYear.TabIndex = 7;
            btnYear.Text = "Full Year";
            btnYear.Click += btnYear_Click;
            // 
            // btnSubscribe
            // 
            btnSubscribe.Anchor = AnchorStyles.None;
            btnSubscribe.BackColor = Color.Goldenrod;
            btnSubscribe.ForeColor = Color.Black;
            btnSubscribe.Location = new Point(363, 439);
            btnSubscribe.Name = "btnSubscribe";
            btnSubscribe.Size = new Size(150, 40);
            btnSubscribe.TabIndex = 10;
            btnSubscribe.Text = "Confirm Subscription";
            btnSubscribe.UseVisualStyleBackColor = false;
            // 
            // UserName
            // 
            UserName.Anchor = AnchorStyles.None;
            UserName.AutoSize = true;
            UserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserName.ForeColor = Color.White;
            UserName.Location = new Point(97, 129);
            UserName.Name = "UserName";
            UserName.Size = new Size(56, 21);
            UserName.TabIndex = 11;
            UserName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.BackColor = Color.FromArgb(30, 30, 30);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(245, 129);
            txtName.Name = "txtName";
            txtName.Size = new Size(142, 23);
            txtName.TabIndex = 12;
            // 
            // Number
            // 
            Number.Anchor = AnchorStyles.None;
            Number.AutoSize = true;
            Number.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Number.ForeColor = Color.White;
            Number.Location = new Point(97, 167);
            Number.Name = "Number";
            Number.Size = new Size(126, 21);
            Number.TabIndex = 11;
            Number.Text = "Phone Number";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.None;
            txtPhone.BackColor = Color.FromArgb(30, 30, 30);
            txtPhone.ForeColor = Color.White;
            txtPhone.Location = new Point(245, 163);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(142, 23);
            txtPhone.TabIndex = 12;
            // 
            // Logic_Form
            // 
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(931, 513);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(Number);
            Controls.Add(UserName);
            Controls.Add(btnSubscribe);
            Controls.Add(lblMainTitle);
            Controls.Add(lblStartTag);
            Controls.Add(dtStartDate);
            Controls.Add(btnMonth);
            Controls.Add(btn3Months);
            Controls.Add(btn6Months);
            Controls.Add(btnYear);
            Controls.Add(lblEndTag);
            Controls.Add(txtEndDate);
            Controls.Add(lblSelectType);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MinimumSize = new Size(816, 0);
            Name = "Logic_Form";
            RightToLeft = RightToLeft.No;
            ResumeLayout(false);
            PerformLayout();



        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            txtEndDate.Text = dtStartDate.Value.AddMonths(1).ToShortDateString();
        }

        private void btn3Month_Click(object sender, EventArgs e)
        {
            txtEndDate.Text = dtStartDate.Value.AddMonths(3).ToShortDateString();
        }

        private void btn6Month_Click(object sender, EventArgs e)
        {
            txtEndDate.Text = dtStartDate.Value.AddMonths(6).ToShortDateString();
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            txtEndDate.Text = dtStartDate.Value.AddYears(1).ToShortDateString();
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
        string.IsNullOrWhiteSpace(txtPhone.Text) ||
        string.IsNullOrWhiteSpace(txtEndDate.Text))
            {
                MessageBox.Show("Please fill all fields and select subscription type!", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPhone.Text.Length < 11)
            {
                MessageBox.Show("Phone number must be 11 digits!", "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {            
                string record = $"{txtName.Text}|{txtPhone.Text}|{dtStartDate.Value.ToShortDateString()}|{txtEndDate.Text}";
                string filePath = "Subscribers.txt";
                System.IO.File.AppendAllText(filePath, record + Environment.NewLine);
                MessageBox.Show("Member registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Clear();
                txtPhone.Clear();
                txtEndDate.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }
    }
}