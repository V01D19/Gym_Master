using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GymMaster.Logic
{
    public partial class Form1 : Form
    {
        private TextBox txtEndDate;
        private DateTimePicker dtStartDate;
        private Label lblMainTitle, lblStartTag, lblEndTag, lblSelectType;
        private Button btnMonth, btn3Months, btn6Months, btnYear;
        public Form1()
        {
            InitializeComponent();
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
            SuspendLayout();
            // 
            // txtEndDate
            // 
            txtEndDate.BackColor = Color.Black;
            txtEndDate.ForeColor = Color.Lime;
            txtEndDate.Location = new Point(313, 292);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.ReadOnly = true;
            txtEndDate.Size = new Size(200, 23);
            txtEndDate.TabIndex = 9;
            txtEndDate.TextAlign = HorizontalAlignment.Center;
            // 
            // dtStartDate
            // 
            dtStartDate.Location = new Point(313, 90);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(200, 23);
            dtStartDate.TabIndex = 2;
            // 
            // lblMainTitle
            // 
            lblMainTitle.AutoSize = true;
            lblMainTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMainTitle.ForeColor = Color.Goldenrod;
            lblMainTitle.Location = new Point(250, 20);
            lblMainTitle.Name = "lblMainTitle";
            lblMainTitle.Size = new Size(291, 32);
            lblMainTitle.TabIndex = 0;
            lblMainTitle.Text = "إدارة اشتراكات GymMaster";
            // 
            // lblStartTag
            // 
            lblStartTag.ForeColor = Color.White;
            lblStartTag.Location = new Point(207, 90);
            lblStartTag.Name = "lblStartTag";
            lblStartTag.Size = new Size(100, 23);
            lblStartTag.TabIndex = 1;
            lblStartTag.Text = "تاريخ البداية:";
            // 
            // lblEndTag
            // 
            lblEndTag.ForeColor = Color.White;
            lblEndTag.Location = new Point(207, 295);
            lblEndTag.Name = "lblEndTag";
            lblEndTag.Size = new Size(100, 23);
            lblEndTag.TabIndex = 8;
            lblEndTag.Text = "تاريخ الانتهاء:";
            // 
            // lblSelectType
            // 
            lblSelectType.ForeColor = Color.White;
            lblSelectType.Location = new Point(353, 153);
            lblSelectType.Name = "lblSelectType";
            lblSelectType.Size = new Size(100, 23);
            lblSelectType.TabIndex = 3;
            lblSelectType.Text = "اختار نوع الاشتراك:";
            // 
            // btnMonth
            // 
            btnMonth.ForeColor = Color.White;
            btnMonth.Location = new Point(218, 203);
            btnMonth.Name = "btnMonth";
            btnMonth.Size = new Size(75, 23);
            btnMonth.TabIndex = 4;
            btnMonth.Text = "شهر";
            btnMonth.Click += btnMonth_Click;
            // 
            // btn3Months
            // 
            btn3Months.ForeColor = Color.White;
            btn3Months.Location = new Point(313, 203);
            btn3Months.Name = "btn3Months";
            btn3Months.Size = new Size(75, 23);
            btn3Months.TabIndex = 5;
            btn3Months.Text = "3شهور";
            btn3Months.Click += btn3Month_Click;
            // 
            // btn6Months
            // 
            btn6Months.ForeColor = Color.White;
            btn6Months.Location = new Point(407, 203);
            btn6Months.Name = "btn6Months";
            btn6Months.Size = new Size(75, 23);
            btn6Months.TabIndex = 6;
            btn6Months.Text = "6شهور";
            btn6Months.Click += btn6Month_Click;
            // 
            // btnYear
            // 
            btnYear.ForeColor = Color.White;
            btnYear.Location = new Point(505, 203);
            btnYear.Name = "btnYear";
            btnYear.Size = new Size(75, 23);
            btnYear.TabIndex = 7;
            btnYear.Text = "سنة كاملة";
            btnYear.Click += btnYear_Click;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(800, 450);
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
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ResumeLayout(false);
            PerformLayout();
        }
        //
        // THE FUNCTIONS
        //

        //
        // MONTH
        //
        private void btnMonth_Click(object sender, EventArgs e)
        {
            txtEndDate.Text = dtStartDate.Value.AddMonths(1).ToShortDateString();
        }
        //
        // 3MONTHS
        //
        private void btn3Month_Click(object sender, EventArgs e) 
        {
            txtEndDate.Text = dtStartDate.Value.AddMonths(3).ToShortDateString();
        }
        //
        // 6MONTHS
        //
        private void btn6Month_Click(object sender, EventArgs e)
        {
            txtEndDate.Text = dtStartDate.Value.AddMonths(6).ToShortDateString();
        }
        //
        // YEAR
        //
        private void btnYear_Click(object sender, EventArgs e)
        {
            txtEndDate.Text = dtStartDate.Value.AddYears(1).ToShortDateString();
        }
    }
}