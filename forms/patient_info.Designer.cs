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
            this.components = new System.ComponentModel.Container();
            this.patient_list = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.search_tb = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.examinations = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.analyses = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label12 = new System.Windows.Forms.Label();
            this.miscarryeg = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.caysary = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.normal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.female = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.syrgerys = new System.Windows.Forms.ListView();
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.medical_med = new System.Windows.Forms.ListView();
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.illneses = new System.Windows.Forms.ListView();
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // patient_list
            // 
            this.patient_list.BackgroundImageTiled = true;
            this.patient_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7,
            this.columnHeader8});
            this.patient_list.Dock = System.Windows.Forms.DockStyle.Left;
            this.patient_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_list.FullRowSelect = true;
            this.patient_list.GridLines = true;
            this.patient_list.HideSelection = false;
            this.patient_list.Location = new System.Drawing.Point(0, 0);
            this.patient_list.Name = "patient_list";
            this.patient_list.Size = new System.Drawing.Size(560, 796);
            this.patient_list.TabIndex = 0;
            this.patient_list.UseCompatibleStateImageBehavior = false;
            this.patient_list.View = System.Windows.Forms.View.Details;
            this.patient_list.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.patient_list_ColumnClick);
            this.patient_list.SelectedIndexChanged += new System.EventHandler(this.patient_list_SelectedIndexChanged);
            this.patient_list.Click += new System.EventHandler(this.patient_list_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "full_name";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "address";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "bloodtype";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "age";
            // 
            // search_tb
            // 
            this.search_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_tb.Location = new System.Drawing.Point(12, 59);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(190, 30);
            this.search_tb.TabIndex = 1;
            this.search_tb.TextChanged += new System.EventHandler(this.search_tb_TextChanged);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(208, 46);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(127, 49);
            this.search.TabIndex = 2;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.button1_Click);
            // 
            // examinations
            // 
            this.examinations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.examinations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examinations.FullRowSelect = true;
            this.examinations.HideSelection = false;
            this.examinations.Location = new System.Drawing.Point(24, 1480);
            this.examinations.Name = "examinations";
            this.examinations.Size = new System.Drawing.Size(670, 290);
            this.examinations.TabIndex = 3;
            this.examinations.UseCompatibleStateImageBehavior = false;
            this.examinations.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "condition";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "date";
            this.columnHeader6.Width = 100;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.analyses);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.miscarryeg);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.caysary);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.normal);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.female);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.male);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.number);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.syrgerys);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.medical_med);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.illneses);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.examinations);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(953, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 796);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // analyses
            // 
            this.analyses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.analyses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analyses.FullRowSelect = true;
            this.analyses.HideSelection = false;
            this.analyses.Location = new System.Drawing.Point(30, 280);
            this.analyses.Name = "analyses";
            this.analyses.Size = new System.Drawing.Size(661, 166);
            this.analyses.TabIndex = 28;
            this.analyses.UseCompatibleStateImageBehavior = false;
            this.analyses.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "name ";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "date";
            this.columnHeader10.Width = 80;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arabic Typesetting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(250, 91);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(51, 26);
            this.label12.TabIndex = 27;
            this.label12.Text = "غرارس";
            // 
            // miscarryeg
            // 
            this.miscarryeg.Location = new System.Drawing.Point(92, 95);
            this.miscarryeg.Multiline = true;
            this.miscarryeg.Name = "miscarryeg";
            this.miscarryeg.Size = new System.Drawing.Size(152, 22);
            this.miscarryeg.TabIndex = 26;
            this.miscarryeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arabic Typesetting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(250, 52);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(51, 26);
            this.label11.TabIndex = 25;
            this.label11.Text = "غرارس";
            // 
            // caysary
            // 
            this.caysary.Location = new System.Drawing.Point(92, 56);
            this.caysary.Multiline = true;
            this.caysary.Name = "caysary";
            this.caysary.Size = new System.Drawing.Size(152, 22);
            this.caysary.TabIndex = 24;
            this.caysary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arabic Typesetting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(612, 170);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(51, 26);
            this.label10.TabIndex = 23;
            this.label10.Text = "غرارس";
            // 
            // normal
            // 
            this.normal.Location = new System.Drawing.Point(454, 174);
            this.normal.Multiline = true;
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(152, 22);
            this.normal.TabIndex = 22;
            this.normal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arabic Typesetting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(612, 131);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(51, 26);
            this.label9.TabIndex = 21;
            this.label9.Text = "غرارس";
            // 
            // female
            // 
            this.female.Location = new System.Drawing.Point(454, 135);
            this.female.Multiline = true;
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(152, 22);
            this.female.TabIndex = 20;
            this.female.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arabic Typesetting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(612, 91);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(51, 26);
            this.label8.TabIndex = 19;
            this.label8.Text = "غرارس";
            // 
            // male
            // 
            this.male.Location = new System.Drawing.Point(454, 95);
            this.male.Multiline = true;
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(152, 22);
            this.male.TabIndex = 18;
            this.male.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arabic Typesetting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(612, 52);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(51, 26);
            this.label7.TabIndex = 17;
            this.label7.Text = "غرارس";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(454, 56);
            this.number.Multiline = true;
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(152, 22);
            this.number.TabIndex = 16;
            this.number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(278, 1119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "syrgerys info";
            // 
            // syrgerys
            // 
            this.syrgerys.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader26,
            this.columnHeader27});
            this.syrgerys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syrgerys.FullRowSelect = true;
            this.syrgerys.HideSelection = false;
            this.syrgerys.Location = new System.Drawing.Point(24, 1147);
            this.syrgerys.Name = "syrgerys";
            this.syrgerys.Size = new System.Drawing.Size(670, 290);
            this.syrgerys.TabIndex = 14;
            this.syrgerys.UseCompatibleStateImageBehavior = false;
            this.syrgerys.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "date";
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "condition";
            this.columnHeader27.Width = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(278, 766);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "medical info";
            // 
            // medical_med
            // 
            this.medical_med.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader22,
            this.columnHeader24});
            this.medical_med.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medical_med.FullRowSelect = true;
            this.medical_med.GridLines = true;
            this.medical_med.HideSelection = false;
            this.medical_med.Location = new System.Drawing.Point(24, 794);
            this.medical_med.Name = "medical_med";
            this.medical_med.Size = new System.Drawing.Size(670, 290);
            this.medical_med.TabIndex = 12;
            this.medical_med.UseCompatibleStateImageBehavior = false;
            this.medical_med.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "name";
            this.columnHeader22.Width = 100;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "info";
            this.columnHeader24.Width = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 1452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "examination info";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "illneses info";
            // 
            // illneses
            // 
            this.illneses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader19});
            this.illneses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.illneses.FullRowSelect = true;
            this.illneses.GridLines = true;
            this.illneses.HideSelection = false;
            this.illneses.Location = new System.Drawing.Point(23, 513);
            this.illneses.Name = "illneses";
            this.illneses.Size = new System.Drawing.Size(661, 183);
            this.illneses.TabIndex = 9;
            this.illneses.UseCompatibleStateImageBehavior = false;
            this.illneses.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "name";
            this.columnHeader19.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "analesis info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "birth info";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.patient_list);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 796);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.search);
            this.panel3.Controls.Add(this.search_tb);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(560, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 100);
            this.panel3.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // patient_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1645, 796);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "patient_info";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " patient info";
            this.Load += new System.EventHandler(this.patient_info_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView patient_list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ListView examinations;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView illneses;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView medical_med;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView syrgerys;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox normal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox female;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox male;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox miscarryeg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox caysary;
        private System.Windows.Forms.ListView analyses;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}