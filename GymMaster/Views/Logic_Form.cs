using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GymMaster.Models;

namespace GymMaster.Views
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
        private Label label1;
        private TextBox txtPrice;
        private string selectedSubscriptionType ;
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

            txtName.KeyDown += MoveToNextControl;
           
         

        
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
            label1 = new Label();
            txtPrice = new TextBox();
            SuspendLayout();
            // 
            // txtEndDate
            // 
            txtEndDate.BackColor = Color.Black;
            txtEndDate.BorderStyle = BorderStyle.FixedSingle;
            txtEndDate.ForeColor = Color.Lime;
            txtEndDate.Location = new Point(627, 194);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.ReadOnly = true;
            txtEndDate.Size = new Size(139, 23);
            txtEndDate.TabIndex = 9;
            txtEndDate.TextAlign = HorizontalAlignment.Center;
            // 
            // dtStartDate
            // 
            dtStartDate.Location = new Point(627, 156);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(139, 23);
            dtStartDate.TabIndex = 14;
            // 
            // lblMainTitle
            // 
            lblMainTitle.AutoSize = true;
            lblMainTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMainTitle.ForeColor = Color.Goldenrod;
            lblMainTitle.Location = new Point(251, 84);
            lblMainTitle.Name = "lblMainTitle";
            lblMainTitle.Size = new Size(454, 32);
            lblMainTitle.TabIndex = 0;
            lblMainTitle.Text = "GymMaster Subscription Management";
            // 
            // lblStartTag
            // 
            lblStartTag.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStartTag.ForeColor = Color.White;
            lblStartTag.Location = new Point(468, 157);
            lblStartTag.Name = "lblStartTag";
            lblStartTag.Size = new Size(100, 23);
            lblStartTag.TabIndex = 1;
            lblStartTag.Text = "Start Date";
            // 
            // lblEndTag
            // 
            lblEndTag.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndTag.ForeColor = Color.White;
            lblEndTag.Location = new Point(468, 194);
            lblEndTag.Name = "lblEndTag";
            lblEndTag.Size = new Size(100, 23);
            lblEndTag.TabIndex = 8;
            lblEndTag.Text = "End Date";
            // 
            // lblSelectType
            // 
            lblSelectType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectType.ForeColor = Color.White;
            lblSelectType.Location = new Point(345, 279);
            lblSelectType.Name = "lblSelectType";
            lblSelectType.Size = new Size(278, 37);
            lblSelectType.TabIndex = 3;
            lblSelectType.Text = "Select Subscription Type:";
            // 
            // btnMonth
            // 
            btnMonth.FlatStyle = FlatStyle.Flat;
            btnMonth.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMonth.ForeColor = Color.White;
            btnMonth.Location = new Point(317, 332);
            btnMonth.Name = "btnMonth";
            btnMonth.Size = new Size(113, 33);
            btnMonth.TabIndex = 4;
            btnMonth.Text = "1 Month";
            btnMonth.Click += btnMonth_Click;
            // 
            // btn3Months
            // 
            btn3Months.FlatStyle = FlatStyle.Flat;
            btn3Months.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3Months.ForeColor = Color.White;
            btn3Months.Location = new Point(468, 332);
            btn3Months.Name = "btn3Months";
            btn3Months.Size = new Size(113, 33);
            btn3Months.TabIndex = 5;
            btn3Months.Text = "3 Months";
            btn3Months.Click += btn3Month_Click;
            // 
            // btn6Months
            // 
            btn6Months.FlatStyle = FlatStyle.Flat;
            btn6Months.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btn6Months.ForeColor = Color.White;
            btn6Months.Location = new Point(317, 393);
            btn6Months.Name = "btn6Months";
            btn6Months.Size = new Size(113, 33);
            btn6Months.TabIndex = 6;
            btn6Months.Text = "6 Months";
            btn6Months.Click += btn6Month_Click;
            // 
            // btnYear
            // 
            btnYear.FlatStyle = FlatStyle.Flat;
            btnYear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnYear.ForeColor = Color.White;
            btnYear.Location = new Point(468, 393);
            btnYear.Name = "btnYear";
            btnYear.Size = new Size(113, 33);
            btnYear.TabIndex = 7;
            btnYear.Text = "Full Year";
            btnYear.Click += btnYear_Click;
            // 
            // btnSubscribe
            // 
            btnSubscribe.BackColor = Color.Goldenrod;
            btnSubscribe.FlatStyle = FlatStyle.Flat;
            btnSubscribe.ForeColor = Color.Black;
            btnSubscribe.Location = new Point(369, 475);
            btnSubscribe.Name = "btnSubscribe";
            btnSubscribe.Size = new Size(150, 40);
            btnSubscribe.TabIndex = 10;
            btnSubscribe.Text = "Confirm Subscription";
            btnSubscribe.UseVisualStyleBackColor = false;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserName.ForeColor = Color.White;
            UserName.Location = new Point(103, 156);
            UserName.Name = "UserName";
            UserName.Size = new Size(56, 21);
            UserName.TabIndex = 11;
            UserName.Text = "Name";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(30, 30, 30);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(251, 156);
            txtName.Name = "txtName";
            txtName.Size = new Size(142, 23);
            txtName.TabIndex = 0;
            // 
            // Number
            // 
            Number.AutoSize = true;
            Number.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Number.ForeColor = Color.White;
            Number.Location = new Point(103, 199);
            Number.Name = "Number";
            Number.Size = new Size(126, 21);
            Number.TabIndex = 11;
            Number.Text = "Phone Number";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(30, 30, 30);
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.ForeColor = Color.White;
            txtPhone.Location = new Point(251, 197);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(142, 23);
            txtPhone.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(103, 238);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 13;
            label1.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.FromArgb(30, 30, 30);
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.ForeColor = Color.White;
            txtPrice.Location = new Point(251, 238);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(142, 23);
            txtPrice.TabIndex = 3;
            // 
            // Logic_Form
            // 
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(884, 581);
            Controls.Add(label1);
            Controls.Add(txtPrice);
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
            MaximumSize = new Size(900, 620);
            MinimumSize = new Size(900, 620);
            Name = "Logic_Form";
            RightToLeft = RightToLeft.No;
            Load += Logic_Form_Load;
            ResumeLayout(false);
            PerformLayout();



        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            txtEndDate.Text = dtStartDate.Value.AddMonths(1).ToShortDateString();
            txtPrice.Text = "500"; 
            selectedSubscriptionType = "1 Month";
        }

        private void btn3Month_Click(object sender, EventArgs e)
        {
            txtEndDate.Text = dtStartDate.Value.AddMonths(3).ToShortDateString();
            txtPrice.Text = "1400";
            selectedSubscriptionType = "3 Months";
        }

        private void btn6Month_Click(object sender, EventArgs e)
        {
            txtEndDate.Text = dtStartDate.Value.AddMonths(6).ToShortDateString();
            txtPrice.Text = "2500";
            selectedSubscriptionType = "6 Months";
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            txtEndDate.Text = dtStartDate.Value.AddYears(1).ToShortDateString();
            txtPrice.Text = "5000";
            selectedSubscriptionType = "Full Year";
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
                Member newMember = new Member();

                newMember.Name = txtName.Text;
                newMember.Phone = txtPhone.Text;
                newMember.PlanType = selectedSubscriptionType;
                newMember.StartDate = dtStartDate.Value;
                newMember.EndDate = DateTime.Parse(txtEndDate.Text);

                string record = $"{newMember.Name}|{newMember.Phone}|{newMember.PlanType}|{newMember.StartDate.ToShortDateString()}|{newMember.EndDate.ToShortDateString()}|{txtPrice.Text}";

                System.IO.File.AppendAllText("Subscribers.txt", record + Environment.NewLine);
                MessageBox.Show("Member added successfully");

                txtName.Clear();
                txtPhone.Clear();
                txtEndDate.Clear();
                txtPrice.Clear();
                selectedSubscriptionType = null;
                dtStartDate.Value = DateTime.Now;
            }



            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Logic_Form_Load(object sender, EventArgs e)
        {

        }

        private void MoveToNextControl(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; 
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

    }
}