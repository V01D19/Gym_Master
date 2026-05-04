using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

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
                        dgvTrainers.Rows.Add(data[0], data[1], data[2], data[3]);
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
                        dgvSubscribers.Rows.Add(data[0], data[1], data[2], data[3], data[4], data[5]);
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
            if (dgvSubscribers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a full row to delete.", "Selection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this subscriber?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvSubscribers.SelectedRows)
                    if (!row.IsNewRow) dgvSubscribers.Rows.Remove(row);

                UpdateSubscribersFile();
                MessageBox.Show("Subscriber deleted successfully!", "Done",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        lines.Add($"{row.Cells[0].Value}|{row.Cells[1].Value}|{row.Cells[2].Value}|" +
                                  $"{row.Cells[3].Value}|{row.Cells[4].Value}|{row.Cells[5].Value}");
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
                        row.Visible = row.Cells[0].Value.ToString().ToLower().Contains(searchValue);
                        if (!row.Visible) dgvSubscribers.CurrentCell = null;
                    }
                }
            }
            catch { }
        }

        private void btnDeleteTrainer_Click(object sender, EventArgs e)
        {
            if (dgvTrainers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a trainer row to delete.", "Selection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this trainer?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvTrainers.SelectedRows)
                    if (!row.IsNewRow) dgvTrainers.Rows.Remove(row);

                UpdateTrainersFile();
                MessageBox.Show("Trainer deleted successfully!", "Done",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        lines.Add($"{row.Cells[0].Value}|{row.Cells[1].Value}|" +
                                  $"{row.Cells[2].Value}|{row.Cells[3].Value}");
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
                        bool visible = row.Cells[0].Value.ToString().ToLower().Contains(searchValue);
                        row.Visible = visible;
                        if (!visible) dgvTrainers.CurrentCell = null;
                    }
                }
            }
            catch { }
        }
    }
}