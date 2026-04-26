using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GymMaster.Views
{
    public partial class captainForm1 : Form
    {
        public captainForm1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string specialty = cmbSpecialty.Text;
            string salary = txtSalary.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter the name");
                return;
            }

            string entry = name + " - " + specialty + " - " + salary;
            listCaptains.Items.Add(entry);

            string filePath = "captains.txt";
            System.IO.File.AppendAllLines(filePath, new[] { entry });

            MessageBox.Show("Saved Successfully: " + name);

            txtName.Clear();
            txtSalary.Clear();
            cmbSpecialty.SelectedIndex = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listCaptains.SelectedIndex != -1)
            {
                listCaptains.Items.RemoveAt(listCaptains.SelectedIndex);
                string filePath = "captains.txt";
                var currentItems = listCaptains.Items.Cast<string>().ToArray();
                System.IO.File.WriteAllLines(filePath, currentItems);
                MessageBox.Show("Deleted Successfully!");
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

        private void captainForm1_Load(object sender, EventArgs e)
        {
            try
            {
                string filePath = "captains.txt";
                if (System.IO.File.Exists(filePath))
                {
                    string[] lines = System.IO.File.ReadAllLines(filePath);
                    listCaptains.Items.Clear();
                    foreach (string line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            listCaptains.Items.Add(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
    }
}
