using System;
using System.Windows.Forms;

namespace GymMaster.Views
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
        {
            activeForm?.Close();
            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAddMember_Click(object sender, EventArgs e) => OpenChildForm(new Logic_Form());
        private void btnAddTrainer_Click(object sender, EventArgs e) => OpenChildForm(new Captins_Form());
        private void btnSearch_Click(object sender, EventArgs e) => OpenChildForm(new Search_Form());

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Login_Form().Show();
            this.Close();
        }
    }
}