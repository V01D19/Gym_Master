namespace GymMaster.Views
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            panelSidebar = new Panel();
            btnLogout = new Button();
            btnSearch = new Button();
            btnAddTrainer = new Button();
            btnAddMember = new Button();
            panelMain = new Panel();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(45, 45, 45);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Controls.Add(btnSearch);
            panelSidebar.Controls.Add(btnAddTrainer);
            panelSidebar.Controls.Add(btnAddMember);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(200, 593);
            panelSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Maroon;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.Goldenrod;
            btnLogout.Location = new Point(0, 544);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(200, 49);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(30, 30, 30);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Goldenrod;
            btnSearch.Location = new Point(-2, 469);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(199, 71);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAddTrainer
            // 
            btnAddTrainer.BackColor = Color.FromArgb(30, 30, 30);
            btnAddTrainer.FlatStyle = FlatStyle.Flat;
            btnAddTrainer.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTrainer.ForeColor = Color.Goldenrod;
            btnAddTrainer.Location = new Point(-2, 86);
            btnAddTrainer.Name = "btnAddTrainer";
            btnAddTrainer.Size = new Size(199, 79);
            btnAddTrainer.TabIndex = 0;
            btnAddTrainer.Text = "Add Trainer";
            btnAddTrainer.UseVisualStyleBackColor = false;
            btnAddTrainer.Click += btnAddTrainer_Click;
            // 
            // btnAddMember
            // 
            btnAddMember.BackColor = Color.FromArgb(30, 30, 30);
            btnAddMember.FlatStyle = FlatStyle.Flat;
            btnAddMember.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddMember.ForeColor = Color.Goldenrod;
            btnAddMember.Location = new Point(-2, 5);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(199, 79);
            btnAddMember.TabIndex = 0;
            btnAddMember.Text = "Add Member";
            btnAddMember.UseVisualStyleBackColor = false;
            btnAddMember.Click += btnAddMember_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(30, 30, 30);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(200, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(858, 593);
            panelMain.TabIndex = 1;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 593);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashBoard";
            panelSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Button btnAddMember;
        private Panel panelMain;
        private Button btnSearch;
        private Button btnAddTrainer;
        private Button btnLogout;
    }
}