namespace clinic_2
{
    partial class Form1
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
            this.patient_info = new System.Windows.Forms.ListView();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.examinations = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // patient_info
            // 
            this.patient_info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.patient_info.Dock = System.Windows.Forms.DockStyle.Right;
            this.patient_info.FullRowSelect = true;
            this.patient_info.GridLines = true;
            this.patient_info.HideSelection = false;
            this.patient_info.Location = new System.Drawing.Point(846, 0);
            this.patient_info.MultiSelect = false;
            this.patient_info.Name = "patient_info";
            this.patient_info.Size = new System.Drawing.Size(571, 540);
            this.patient_info.TabIndex = 0;
            this.patient_info.UseCompatibleStateImageBehavior = false;
            this.patient_info.View = System.Windows.Forms.View.Details;
            this.patient_info.Click += new System.EventHandler(this.patient_info_Click);
            // 
            // search_tb
            // 
            this.search_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_tb.Location = new System.Drawing.Point(12, 35);
            this.search_tb.Multiline = true;
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(287, 50);
            this.search_tb.TabIndex = 1;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(363, 33);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(119, 40);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // examinations
            // 
            this.examinations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.examinations.FullRowSelect = true;
            this.examinations.GridLines = true;
            this.examinations.HideSelection = false;
            this.examinations.Location = new System.Drawing.Point(56, 316);
            this.examinations.Name = "examinations";
            this.examinations.Size = new System.Drawing.Size(368, 224);
            this.examinations.TabIndex = 3;
            this.examinations.UseCompatibleStateImageBehavior = false;
            this.examinations.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "examination_id";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "date";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "id";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "full_name";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "address";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "blood_type";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "age";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 540);
            this.Controls.Add(this.examinations);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_tb);
            this.Controls.Add(this.patient_info);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView patient_info;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.ListView examinations;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}

