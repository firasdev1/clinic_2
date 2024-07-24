namespace clinic_2.forms
{
    partial class patient_info
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
            this.patient_list = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.search_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.examinations = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // patient_list
            // 
            this.patient_list.BackgroundImageTiled = true;
            this.patient_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.patient_list.Dock = System.Windows.Forms.DockStyle.Right;
            this.patient_list.FullRowSelect = true;
            this.patient_list.GridLines = true;
            this.patient_list.HideSelection = false;
            this.patient_list.Location = new System.Drawing.Point(810, 0);
            this.patient_list.Name = "patient_list";
            this.patient_list.Size = new System.Drawing.Size(361, 560);
            this.patient_list.TabIndex = 0;
            this.patient_list.UseCompatibleStateImageBehavior = false;
            this.patient_list.View = System.Windows.Forms.View.Details;
            this.patient_list.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.patient_list_ColumnClick);
            this.patient_list.Click += new System.EventHandler(this.patient_list_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "full_name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "address";
            // 
            // search_tb
            // 
            this.search_tb.Location = new System.Drawing.Point(230, 37);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(190, 22);
            this.search_tb.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // examinations
            // 
            this.examinations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.examinations.FullRowSelect = true;
            this.examinations.GridLines = true;
            this.examinations.HideSelection = false;
            this.examinations.Location = new System.Drawing.Point(79, 366);
            this.examinations.Name = "examinations";
            this.examinations.Size = new System.Drawing.Size(226, 194);
            this.examinations.TabIndex = 3;
            this.examinations.UseCompatibleStateImageBehavior = false;
            this.examinations.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "id";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "date";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "condition";
            // 
            // patient_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 560);
            this.Controls.Add(this.examinations);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.search_tb);
            this.Controls.Add(this.patient_list);
            this.Name = "patient_info";
            this.Text = "patient_info";
            this.Load += new System.EventHandler(this.patient_info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView patient_list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView examinations;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}