using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using GymMaster.Models;
using GymMaster;

namespace GymMaster.Views
{
    public partial class Captins_Form : Form
    {
        public Captins_Form()
        {
            InitializeComponent();
        }

        private void Captins_Form_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtSalary.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                cmbSpecialization.SelectedIndex == -1) 
            {
                MessageBox.Show("Please fill all the fields before saving!", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            if (txtPhone.Text.Length != 11)
            {
                MessageBox.Show("Phone number must be exactly 11 digits!", "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Error: Please enter letters only!");
                return;
            }

            if (!decimal.TryParse(txtSalary.Text, out decimal salary))
            {
                MessageBox.Show("Error: Please enter a valid number for the salary!");
                return;
            }

            if (salary < 5000 || salary > 20000)
            {
                MessageBox.Show("Error: Salary must be between 5,000 and 20,000 EGP!");
                return;
            }

            if (cmbSpecialization.SelectedItem == null)
            {
                MessageBox.Show("Error: Please select a specialization!");
                return;
            }

            try
            {
            
                Trainer newTrainer = new Trainer();

               
                newTrainer.Name = txtName.Text;
                newTrainer.Specialization = cmbSpecialization.SelectedItem.ToString();
                newTrainer.Salary = salary; 
                newTrainer.Phone = txtPhone.Text;
        
                string captainData = $"{newTrainer.Name}|{newTrainer.Specialization}|{newTrainer.Salary}|{newTrainer.Phone}";

                File.AppendAllLines("Captains.txt", new[] { captainData });

                MessageBox.Show("Captain data saved successfully");

       
                txtName.Clear();
                txtSalary.Clear();
                txtPhone.Clear();
                cmbSpecialization.SelectedIndex = -1; 
                txtName.Focus(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving: " + ex.Message);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSalary.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtSalary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPhone.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbSpecialization.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void cmbSpecialization_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

   
    }
}
