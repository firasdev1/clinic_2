namespace clinic_2.forms
{
    partial class Form_MainScreen
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tab_PatientList = new System.Windows.Forms.TabPage();
            this.tab_Personal = new System.Windows.Forms.TabPage();
            this.tab_Exam = new System.Windows.Forms.TabPage();
            this.tab_Lab = new System.Windows.Forms.TabPage();
            this.tab_Graphs = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.labeledInputText1 = new clinic_2.Widgets.LabeledInputText();
            this.labeledInputText3 = new clinic_2.Widgets.LabeledInputText();
            this.DGV_PatientsTable = new System.Windows.Forms.DataGridView();
            this.tabs.SuspendLayout();
            this.tab_PatientList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PatientsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tab_PatientList);
            this.tabs.Controls.Add(this.tab_Personal);
            this.tabs.Controls.Add(this.tab_Exam);
            this.tabs.Controls.Add(this.tab_Lab);
            this.tabs.Controls.Add(this.tab_Graphs);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1378, 673);
            this.tabs.TabIndex = 0;
            // 
            // tab_PatientList
            // 
            this.tab_PatientList.Controls.Add(this.DGV_PatientsTable);
            this.tab_PatientList.Controls.Add(this.flowLayoutPanel3);
            this.tab_PatientList.Location = new System.Drawing.Point(4, 25);
            this.tab_PatientList.Name = "tab_PatientList";
            this.tab_PatientList.Padding = new System.Windows.Forms.Padding(3);
            this.tab_PatientList.Size = new System.Drawing.Size(1370, 644);
            this.tab_PatientList.TabIndex = 0;
            this.tab_PatientList.Text = "Patients List";
            this.tab_PatientList.UseVisualStyleBackColor = true;
            // 
            // tab_Personal
            // 
            this.tab_Personal.Location = new System.Drawing.Point(4, 25);
            this.tab_Personal.Name = "tab_Personal";
            this.tab_Personal.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Personal.Size = new System.Drawing.Size(1370, 644);
            this.tab_Personal.TabIndex = 1;
            this.tab_Personal.Text = "Personal";
            this.tab_Personal.UseVisualStyleBackColor = true;
            // 
            // tab_Exam
            // 
            this.tab_Exam.Location = new System.Drawing.Point(4, 25);
            this.tab_Exam.Name = "tab_Exam";
            this.tab_Exam.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Exam.Size = new System.Drawing.Size(1370, 644);
            this.tab_Exam.TabIndex = 2;
            this.tab_Exam.Text = "Examinations";
            this.tab_Exam.UseVisualStyleBackColor = true;
            // 
            // tab_Lab
            // 
            this.tab_Lab.Location = new System.Drawing.Point(4, 25);
            this.tab_Lab.Name = "tab_Lab";
            this.tab_Lab.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Lab.Size = new System.Drawing.Size(1370, 644);
            this.tab_Lab.TabIndex = 3;
            this.tab_Lab.Text = "Lab";
            this.tab_Lab.UseVisualStyleBackColor = true;
            // 
            // tab_Graphs
            // 
            this.tab_Graphs.Location = new System.Drawing.Point(4, 25);
            this.tab_Graphs.Name = "tab_Graphs";
            this.tab_Graphs.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Graphs.Size = new System.Drawing.Size(1370, 644);
            this.tab_Graphs.TabIndex = 4;
            this.tab_Graphs.Text = "Graphs";
            this.tab_Graphs.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabs);
            this.splitContainer1.Size = new System.Drawing.Size(1378, 777);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1378, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Info";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.labeledInputText1);
            this.flowLayoutPanel2.Controls.Add(this.labeledInputText3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(295, 79);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.txt_Search);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1358, 31);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // txt_Search
            // 
            this.txt_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Search.Location = new System.Drawing.Point(59, 3);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(1283, 22);
            this.txt_Search.TabIndex = 1;
            // 
            // labeledInputText1
            // 
            this.labeledInputText1.Location = new System.Drawing.Point(3, 3);
            this.labeledInputText1.Multiline = false;
            this.labeledInputText1.Name = "labeledInputText1";
            this.labeledInputText1.ReadOnly = true;
            this.labeledInputText1.Size = new System.Drawing.Size(281, 27);
            this.labeledInputText1.TabIndex = 0;
            this.labeledInputText1.Title = "ID";
            // 
            // labeledInputText3
            // 
            this.labeledInputText3.Location = new System.Drawing.Point(3, 36);
            this.labeledInputText3.Multiline = false;
            this.labeledInputText3.Name = "labeledInputText3";
            this.labeledInputText3.ReadOnly = true;
            this.labeledInputText3.Size = new System.Drawing.Size(281, 27);
            this.labeledInputText3.TabIndex = 2;
            this.labeledInputText3.Title = "Full Name";
            // 
            // DGV_PatientsTable
            // 
            this.DGV_PatientsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_PatientsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PatientsTable.Location = new System.Drawing.Point(6, 43);
            this.DGV_PatientsTable.Name = "DGV_PatientsTable";
            this.DGV_PatientsTable.RowHeadersWidth = 51;
            this.DGV_PatientsTable.RowTemplate.Height = 24;
            this.DGV_PatientsTable.Size = new System.Drawing.Size(1356, 593);
            this.DGV_PatientsTable.TabIndex = 1;
            // 
            // Form_MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 777);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form_MainScreen";
            this.Text = "Form_MainScreen";
            this.tabs.ResumeLayout(false);
            this.tab_PatientList.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PatientsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tab_PatientList;
        private System.Windows.Forms.TabPage tab_Personal;
        private System.Windows.Forms.TabPage tab_Exam;
        private System.Windows.Forms.TabPage tab_Lab;
        private System.Windows.Forms.TabPage tab_Graphs;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Widgets.LabeledInputText labeledInputText1;
        private Widgets.LabeledInputText labeledInputText3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.DataGridView DGV_PatientsTable;
    }
}