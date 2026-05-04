using System;
using System.Globalization;
using System.IO;
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
        private string selectedSubscriptionType;
        private Button btnSubscribe;

        public Logic_Form()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            InitializeComponent();

            btnSubscribe.Click += btnSubscribe_Click;

            txtName.KeyPress += (s, e) => { if (char.IsDigit(e.KeyChar)) e.Handled = true; };
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

            txtEndDate.BackColor = Color.Black;
            txtEndDate.BorderStyle = BorderStyle.FixedSingle;
            txtEndDate.ForeColor = Color.Lime;
            txtEndDate.Location = new Point(627, 194);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.ReadOnly = true;
            txtEndDate.Size = new Size(139, 23);
            txtEndDate.TabIndex = 9;
            txtEndDate.TextAlign = HorizontalAlignment.Center;

            dtStartDate.Location = new Point(627, 156);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(139, 23);
            dtStartDate.TabIndex = 14;

            lblMainTitle.AutoSize = true;
            lblMainTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMainTitle.ForeColor = Color.Goldenrod;
            lblMainTitle.Location = new Point(251, 84);
            lblMainTitle.Name = "lblMainTitle";
            lblMainTitle.Text = "GymMaster Subscription Management";

            lblStartTag.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblStartTag.ForeColor = Color.White;
            lblStartTag.Location = new Point(468, 157);
            lblStartTag.Text = "Start Date";

            lblEndTag.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEndTag.ForeColor = Color.White;
            lblEndTag.Location = new Point(468, 194);
            lblEndTag.Text = "End Date";

            lblSelectType.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSelectType.ForeColor = Color.White;
            lblSelectType.Location = new Point(345, 279);
            lblSelectType.Size = new Size(278, 37);
            lblSelectType.Text = "Select Subscription Type:";

            btnMonth.FlatStyle = FlatStyle.Flat;
            btnMonth.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnMonth.ForeColor = Color.White;
            btnMonth.Location = new Point(317, 332);
            btnMonth.Size = new Size(113, 33);
            btnMonth.Text = "1 Month";
            btnMonth.Click += btnMonth_Click;

            btn3Months.FlatStyle = FlatStyle.Flat;
            btn3Months.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btn3Months.ForeColor = Color.White;
            btn3Months.Location = new Point(468, 332);
            btn3Months.Size = new Size(113, 33);
            btn3Months.Text = "3 Months";
            btn3Months.Click += btn3Month_Click;

            btn6Months.FlatStyle = FlatStyle.Flat;
            btn6Months.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btn6Months.ForeColor = Color.White;
            btn6Months.Location = new Point(317, 393);
            btn6Months.Size = new Size(113, 33);
            btn6Months.Text = "6 Months";
            btn6Months.Click += btn6Month_Click;

            btnYear.FlatStyle = FlatStyle.Flat;
            btnYear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnYear.ForeColor = Color.White;
            btnYear.Location = new Point(468, 393);
            btnYear.Size = new Size(113, 33);
            btnYear.Text = "Full Year";
            btnYear.Click += btnYear_Click;

            btnSubscribe.BackColor = Color.Goldenrod;
            btnSubscribe.FlatStyle = FlatStyle.Flat;
            btnSubscribe.ForeColor = Color.Black;
            btnSubscribe.Location = new Point(369, 475);
            btnSubscribe.Size = new Size(150, 40);
            btnSubscribe.Text = "Confirm Subscription";

            UserName.AutoSize = true;
            UserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            UserName.ForeColor = Color.White;
            UserName.Location = new Point(103, 156);
            UserName.Text = "Name";

            txtName.BackColor = Color.FromArgb(30, 30, 30);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(251, 156);
            txtName.Size = new Size(142, 23);
            txtName.TabIndex = 0;

            Number.AutoSize = true;
            Number.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Number.ForeColor = Color.White;
            Number.Location = new Point(103, 199);
            Number.Text = "Phone Number";

            txtPhone.BackColor = Color.FromArgb(30, 30, 30);
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.ForeColor = Color.White;
            txtPhone.Location = new Point(251, 197);
            txtPhone.Size = new Size(142, 23);
            txtPhone.TabIndex = 1;

            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(103, 238);
            label1.Text = "Price";

            txtPrice.BackColor = Color.FromArgb(30, 30, 30);
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.ForeColor = Color.White;
            txtPrice.Location = new Point(251, 238);
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(142, 23);
            txtPrice.TabIndex = 3;

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
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            MaximizeBox = false;
            MaximumSize = new Size(900, 620);
            MinimumSize = new Size(900, 620);
            Name = "Logic_Form";
            Load += Logic_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void SetSubscription(int months, string planType, string price)
        {
            DateTime endDate = months == 12
                ? dtStartDate.Value.AddYears(1)
                : dtStartDate.Value.AddMonths(months);

            txtEndDate.Text = endDate.ToShortDateString();
            txtPrice.Text = price;
            selectedSubscriptionType = planType;
        }

        private void btnMonth_Click(object sender, EventArgs e) => SetSubscription(1, "1 Month", "500");
        private void btn3Month_Click(object sender, EventArgs e) => SetSubscription(3, "3 Months", "1400");
        private void btn6Month_Click(object sender, EventArgs e) => SetSubscription(6, "6 Months", "2500");
        private void btnYear_Click(object sender, EventArgs e) => SetSubscription(12, "Full Year", "5000");

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtEndDate.Text))
            {
                MessageBox.Show("Please fill all fields and select subscription type!", "Missing Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPhone.Text.Length < 11)
            {
                MessageBox.Show("Phone number must be 11 digits!", "Invalid Phone",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                newMember.Price = decimal.Parse(txtPrice.Text);


                File.AppendAllText("Subscribers.txt", newMember.GetRecordString() + Environment.NewLine);

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

        private void Logic_Form_Load(object sender, EventArgs e) { }

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