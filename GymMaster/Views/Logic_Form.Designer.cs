namespace GymMaster.Views
{
    partial class Logic_Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblStartTag = new System.Windows.Forms.Label();
            this.lblEndTag = new System.Windows.Forms.Label();
            this.lblSelectType = new System.Windows.Forms.Label();
            this.btnMonth = new System.Windows.Forms.Button();
            this.btn3Months = new System.Windows.Forms.Button();
            this.btn6Months = new System.Windows.Forms.Button();
            this.btnYear = new System.Windows.Forms.Button();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // txtEndDate
            this.txtEndDate.BackColor = System.Drawing.Color.Black;
            this.txtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndDate.ForeColor = System.Drawing.Color.Lime;
            this.txtEndDate.Location = new System.Drawing.Point(627, 194);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(139, 23);
            this.txtEndDate.TabIndex = 9;
            this.txtEndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // dtStartDate
            this.dtStartDate.Location = new System.Drawing.Point(627, 156);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(139, 23);
            this.dtStartDate.TabIndex = 14;

            // lblMainTitle
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblMainTitle.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblMainTitle.Location = new System.Drawing.Point(251, 84);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Text = "GymMaster Subscription Management";

            // lblStartTag
            this.lblStartTag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStartTag.ForeColor = System.Drawing.Color.White;
            this.lblStartTag.Location = new System.Drawing.Point(468, 157);
            this.lblStartTag.Text = "Start Date";

            // lblEndTag
            this.lblEndTag.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEndTag.ForeColor = System.Drawing.Color.White;
            this.lblEndTag.Location = new System.Drawing.Point(468, 194);
            this.lblEndTag.Text = "End Date";

            // lblSelectType
            this.lblSelectType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSelectType.ForeColor = System.Drawing.Color.White;
            this.lblSelectType.Location = new System.Drawing.Point(345, 279);
            this.lblSelectType.Size = new System.Drawing.Size(278, 37);
            this.lblSelectType.Text = "Select Subscription Type:";

            // btnMonth
            this.btnMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMonth.ForeColor = System.Drawing.Color.White;
            this.btnMonth.Location = new System.Drawing.Point(317, 332);
            this.btnMonth.Size = new System.Drawing.Size(113, 33);
            this.btnMonth.Text = "1 Month";
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);

            // btn3Months
            this.btn3Months.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3Months.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn3Months.ForeColor = System.Drawing.Color.White;
            this.btn3Months.Location = new System.Drawing.Point(468, 332);
            this.btn3Months.Size = new System.Drawing.Size(113, 33);
            this.btn3Months.Text = "3 Months";
            this.btn3Months.Click += new System.EventHandler(this.btn3Month_Click);

            // btn6Months
            this.btn6Months.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6Months.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn6Months.ForeColor = System.Drawing.Color.White;
            this.btn6Months.Location = new System.Drawing.Point(317, 393);
            this.btn6Months.Size = new System.Drawing.Size(113, 33);
            this.btn6Months.Text = "6 Months";
            this.btn6Months.Click += new System.EventHandler(this.btn6Month_Click);

            // btnYear
            this.btnYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnYear.ForeColor = System.Drawing.Color.White;
            this.btnYear.Location = new System.Drawing.Point(468, 393);
            this.btnYear.Size = new System.Drawing.Size(113, 33);
            this.btnYear.Text = "Full Year";
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);

            // btnSubscribe
            this.btnSubscribe.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSubscribe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubscribe.ForeColor = System.Drawing.Color.Black;
            this.btnSubscribe.Location = new System.Drawing.Point(369, 475);
            this.btnSubscribe.Size = new System.Drawing.Size(150, 40);
            this.btnSubscribe.Text = "Confirm Subscription";

            // UserName
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.UserName.ForeColor = System.Drawing.Color.White;
            this.UserName.Location = new System.Drawing.Point(103, 156);
            this.UserName.Text = "Name";

            // txtName
            this.txtName.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(251, 156);
            this.txtName.Size = new System.Drawing.Size(142, 23);
            this.txtName.TabIndex = 0;

            // Number
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Number.ForeColor = System.Drawing.Color.White;
            this.Number.Location = new System.Drawing.Point(103, 199);
            this.Number.Text = "Phone Number";

            // txtPhone
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(251, 197);
            this.txtPhone.Size = new System.Drawing.Size(142, 23);
            this.txtPhone.TabIndex = 1;

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 238);
            this.label1.Text = "Price";

            // txtPrice
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(251, 238);
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(142, 23);
            this.txtPrice.TabIndex = 3;

            // Logic_Form
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.ClientSize = new System.Drawing.Size(884, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.lblStartTag);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.btnMonth);
            this.Controls.Add(this.btn3Months);
            this.Controls.Add(this.btn6Months);
            this.Controls.Add(this.btnYear);
            this.Controls.Add(this.lblEndTag);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.lblSelectType);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 620);
            this.MinimumSize = new System.Drawing.Size(900, 620);
            this.Name = "Logic_Form";
            this.Load += new System.EventHandler(this.Logic_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblStartTag;
        private System.Windows.Forms.Label lblEndTag;
        private System.Windows.Forms.Label lblSelectType;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btn3Months;
        private System.Windows.Forms.Button btn6Months;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSubscribe;
    }
}