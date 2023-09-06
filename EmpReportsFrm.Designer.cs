namespace Group_Project_Bistro_Bus
{
    partial class EmpReportsFrm
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
            this.bntEmpSearch = new System.Windows.Forms.Button();
            this.tBEmpSearch = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.bntEmpSearch);
            this.panel1.Controls.Add(this.tBEmpSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 100);
            this.panel1.TabIndex = 6;
            // 
            // bntEmpSearch
            // 
            this.bntEmpSearch.Location = new System.Drawing.Point(95, 74);
            this.bntEmpSearch.Name = "bntEmpSearch";
            this.bntEmpSearch.Size = new System.Drawing.Size(75, 23);
            this.bntEmpSearch.TabIndex = 3;
            this.bntEmpSearch.Text = "Search";
            this.bntEmpSearch.UseVisualStyleBackColor = true;
            this.bntEmpSearch.Click += new System.EventHandler(this.bntEmpSearch_Click);
            // 
            // tBEmpSearch
            // 
            this.tBEmpSearch.Location = new System.Drawing.Point(146, 24);
            this.tBEmpSearch.Name = "tBEmpSearch";
            this.tBEmpSearch.Size = new System.Drawing.Size(100, 20);
            this.tBEmpSearch.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Employee Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for Employee Info";
            // 
            // EmpReportsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSearchBookings);
            this.Controls.Add(this.panel1);
            this.Name = "EmpReportsFrm";
            this.Text = "EmpReportsFrm";
            this.Load += new System.EventHandler(this.EmpReportsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchBookings)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSearchBookings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntEmpSearch;
        private System.Windows.Forms.TextBox tBEmpSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}