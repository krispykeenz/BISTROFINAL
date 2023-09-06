namespace Group_Project_Bistro_Bus
{
    partial class MenuReportsFrm
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
            this.dgvSearchBookings = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rBPast = new System.Windows.Forms.RadioButton();
            this.rBWeek = new System.Windows.Forms.RadioButton();
            this.rBMonth = new System.Windows.Forms.RadioButton();
            this.bntItemSearch = new System.Windows.Forms.Button();
            this.tBItemSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchBookings)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSearchBookings
            // 
            this.dgvSearchBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchBookings.Location = new System.Drawing.Point(12, 135);
            this.dgvSearchBookings.Name = "dgvSearchBookings";
            this.dgvSearchBookings.Size = new System.Drawing.Size(776, 303);
            this.dgvSearchBookings.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rBPast);
            this.panel1.Controls.Add(this.rBWeek);
            this.panel1.Controls.Add(this.rBMonth);
            this.panel1.Controls.Add(this.bntItemSearch);
            this.panel1.Controls.Add(this.tBItemSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 100);
            this.panel1.TabIndex = 6;
            // 
            // rBPast
            // 
            this.rBPast.AutoSize = true;
            this.rBPast.Location = new System.Drawing.Point(474, 60);
            this.rBPast.Name = "rBPast";
            this.rBPast.Size = new System.Drawing.Size(100, 17);
            this.rBPast.TabIndex = 9;
            this.rBPast.TabStop = true;
            this.rBPast.Text = "All old Bookings";
            this.rBPast.UseVisualStyleBackColor = true;
            // 
            // rBWeek
            // 
            this.rBWeek.AutoSize = true;
            this.rBWeek.Location = new System.Drawing.Point(474, 37);
            this.rBWeek.Name = "rBWeek";
            this.rBWeek.Size = new System.Drawing.Size(125, 17);
            this.rBWeek.TabIndex = 10;
            this.rBWeek.TabStop = true;
            this.rBWeek.Text = "This weeks bookings";
            this.rBWeek.UseVisualStyleBackColor = true;
            // 
            // rBMonth
            // 
            this.rBMonth.AutoSize = true;
            this.rBMonth.Location = new System.Drawing.Point(474, 14);
            this.rBMonth.Name = "rBMonth";
            this.rBMonth.Size = new System.Drawing.Size(128, 17);
            this.rBMonth.TabIndex = 11;
            this.rBMonth.TabStop = true;
            this.rBMonth.Text = "This months bookings";
            this.rBMonth.UseVisualStyleBackColor = true;
            // 
            // bntItemSearch
            // 
            this.bntItemSearch.Location = new System.Drawing.Point(95, 74);
            this.bntItemSearch.Name = "bntItemSearch";
            this.bntItemSearch.Size = new System.Drawing.Size(75, 23);
            this.bntItemSearch.TabIndex = 3;
            this.bntItemSearch.Text = "Search";
            this.bntItemSearch.UseVisualStyleBackColor = true;
            this.bntItemSearch.Click += new System.EventHandler(this.bntItemSearch_Click);
            // 
            // tBItemSearch
            // 
            this.tBItemSearch.Location = new System.Drawing.Point(146, 24);
            this.tBItemSearch.Name = "tBItemSearch";
            this.tBItemSearch.Size = new System.Drawing.Size(100, 20);
            this.tBItemSearch.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Menu Item Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search all the times a menu item has been booked";
            // 
            // MenuReportsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSearchBookings);
            this.Controls.Add(this.panel1);
            this.Name = "MenuReportsFrm";
            this.Text = "MenuReportsFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchBookings)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSearchBookings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntItemSearch;
        private System.Windows.Forms.TextBox tBItemSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBPast;
        private System.Windows.Forms.RadioButton rBWeek;
        private System.Windows.Forms.RadioButton rBMonth;
    }
}