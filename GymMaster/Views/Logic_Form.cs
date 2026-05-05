using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using GymMaster.Models;

namespace GymMaster.Views
{
    public partial class Logic_Form : Form
    {
        //  enum 
        private SubscriptionPlan selectedSubscriptionType;

        public Logic_Form()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            InitializeComponent();

       
            txtName.KeyPress += new KeyPressEventHandler(txtName_KeyPress);
            txtPhone.MaxLength = 11;
            txtPhone.KeyPress += new KeyPressEventHandler(txtPhone_KeyPress);
            txtName.KeyDown += new KeyEventHandler(txtName_KeyDown);
        }


        private void SetSubscription(int months, SubscriptionPlan planType, string price)
        {
            DateTime endDate;

            if (months == 12)
            {
                endDate = dtStartDate.Value.AddYears(1);
            }
            else
            {
                endDate = dtStartDate.Value.AddMonths(months);
            }

            txtEndDate.Text = endDate.ToShortDateString();
            txtPrice.Text = price;
            selectedSubscriptionType = planType;
        }

      
        private void btnMonth_Click(object sender, EventArgs e)
        {
            SetSubscription(1, SubscriptionPlan.OneMonth, "500");
        }

        private void btn3Month_Click(object sender, EventArgs e)
        {
            SetSubscription(3, SubscriptionPlan.ThreeMonths, "1400");
        }

        private void btn6Month_Click(object sender, EventArgs e)
        {
            SetSubscription(6, SubscriptionPlan.SixMonths, "2500");
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            SetSubscription(12, SubscriptionPlan.FullYear, "5000");
        }

      
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

    
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtPhone.Focus();
            }
        }
    }
}