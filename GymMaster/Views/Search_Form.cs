using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GymMaster;

namespace GymMaster.Views
{
    public partial class Search_Form : Form
    {
        public Search_Form()
        {
            InitializeComponent();
        }

        private void LoadTrainersData()
        {
            dgvTrainers.Rows.Clear();

            if (File.Exists("Captains.txt"))
            {
                string[] lines = File.ReadAllLines("Captains.txt");

                foreach (string line in lines)
                {
                    string[] data = line.Split('|');

                    if (data.Length == 4)
                    {
                        dgvTrainers.Rows.Add(data[0], data[1], data[2], data[3]);
                    }
                }
            }
        }

        private void LoadSubscribersData()
        {
            dgvSubscribers.Rows.Clear();

            if (File.Exists("Subscribers.txt"))
            {
                string[] lines = File.ReadAllLines("Subscribers.txt");

                foreach (string line in lines)
                {
                    string[] data = line.Split('|');

                    if (data.Length == 6)
                    {
                        dgvSubscribers.Rows.Add(data[0], data[1], data[2], data[3], data[4], data[5]);
                    }
                }
            }
        }

        private void Search_Form_Load(object sender, EventArgs e)
        {
            LoadTrainersData();
            LoadSubscribersData();

            dgvSubscribers.ClearSelection();
            dgvTrainers.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSubscribers.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this subscriber?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvSubscribers.SelectedRows)
                    {
                        if (!row.IsNewRow) dgvSubscribers.Rows.Remove(row);
                    }

                    UpdateSubscribersFile();

                    MessageBox.Show("Subscriber deleted successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a full row to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateSubscribersFile()
        {
            try
            {
                List<string> lines = new List<string>();

                foreach (DataGridViewRow row in dgvSubscribers.Rows)
                {
                    if (!row.IsNewRow && row.Cells[0].Value != null)
                    {
                        string line = $"{row.Cells[0].Value}|{row.Cells[1].Value}|{row.Cells[2].Value}|{row.Cells[3].Value}|{row.Cells[4].Value}|{row.Cells[5].Value}";
                        lines.Add(line);
                    }
                }
                File.WriteAllLines("Subscribers.txt", lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating file: " + ex.Message);
            }
        }

        private void txtSearchSub_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchSub.Text.ToLower();
            dgvSubscribers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                foreach (DataGridViewRow row in dgvSubscribers.Rows)
                {
                    if (!row.IsNewRow && row.Cells[0].Value != null)
                    {
                        if (row.Cells[0].Value.ToString().ToLower().Contains(searchValue))
                        {
                            row.Visible = true;
                        }
                        else
                        {
                            dgvSubscribers.CurrentCell = null;
                            row.Visible = false;
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnDeleteTrainer_Click(object sender, EventArgs e)
        {
            if (dgvTrainers.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this trainer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvTrainers.SelectedRows)
                    {
                        if (!row.IsNewRow) dgvTrainers.Rows.Remove(row);
                    }

                    UpdateTrainersFile();

                    MessageBox.Show("Trainer deleted successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a trainer row to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTrainersFile()
        {
            try
            {
                List<string> lines = new List<string>();

                foreach (DataGridViewRow row in dgvTrainers.Rows)
                {
                    if (!row.IsNewRow && row.Cells[0].Value != null)
                    {
                        string line = $"{row.Cells[0].Value}|{row.Cells[1].Value}|{row.Cells[2].Value}|{row.Cells[3].Value}";
                        lines.Add(line);
                    }
                }

                File.WriteAllLines("Captains.txt", lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating file: " + ex.Message);
            }
        }

        private void txtSearchTrainers_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchTrainers.Text.ToLower();

            try
            {
                foreach (DataGridViewRow row in dgvTrainers.Rows)
                {
                    if (!row.IsNewRow && row.Cells[0].Value != null)
                    {
                        string trainerName = row.Cells[0].Value.ToString().ToLower();

                        if (trainerName.Contains(searchValue))
                        {
                            row.Visible = true; 
                        }
                        else
                        {
                            dgvTrainers.CurrentCell = null;
                            row.Visible = false;
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }

}
