namespace clinic_2.forms
{
    partial class Form_AddNewPatient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cb_Gender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtp_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_BloodType = new System.Windows.Forms.ComboBox();
            this.lbl_BloodType = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.labeledInputText5 = new clinic_2.Widgets.LabeledInputText();
            this.labeledInputText6 = new clinic_2.Widgets.LabeledInputText();
            this.labeledInputText12 = new clinic_2.Widgets.LabeledInputText();
            this.labeledInputText13 = new clinic_2.Widgets.LabeledInputText();
            this.labeledInputText7 = new clinic_2.Widgets.LabeledInputText();
            this.labeledInputText1 = new clinic_2.Widgets.LabeledInputText();
            this.labeledInputText2 = new clinic_2.Widgets.LabeledInputText();
            this.labeledInputText3 = new clinic_2.Widgets.LabeledInputText();
            this.labeledInputText8 = new clinic_2.Widgets.LabeledInputText();
            this.labeledInputText9 = new clinic_2.Widgets.LabeledInputText();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1387, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Info";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 18);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(1381, 260);
            this.splitContainer1.SplitterDistance = 524;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labeledInputText1);
            this.flowLayoutPanel1.Controls.Add(this.labeledInputText2);
            this.flowLayoutPanel1.Controls.Add(this.labeledInputText3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(524, 260);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cb_Gender);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(3, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(454, 27);
            this.panel4.TabIndex = 4;
            // 
            // cb_Gender
            // 
            this.cb_Gender.FormattingEnabled = true;
            this.cb_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_Gender.Location = new System.Drawing.Point(89, 3);
            this.cb_Gender.Name = "cb_Gender";
            this.cb_Gender.Size = new System.Drawing.Size(362, 24);
            this.cb_Gender.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gender";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.labeledInputText8);
            this.flowLayoutPanel2.Controls.Add(this.labeledInputText9);
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(853, 260);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtp_BirthDate);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(454, 27);
            this.panel3.TabIndex = 4;
            // 
            // dtp_BirthDate
            // 
            this.dtp_BirthDate.Location = new System.Drawing.Point(89, 4);
            this.dtp_BirthDate.Name = "dtp_BirthDate";
            this.dtp_BirthDate.Size = new System.Drawing.Size(362, 22);
            this.dtp_BirthDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bith Date";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cb_BloodType);
            this.panel2.Controls.Add(this.lbl_BloodType);
            this.panel2.Location = new System.Drawing.Point(3, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 27);
            this.panel2.TabIndex = 3;
            // 
            // cb_BloodType
            // 
            this.cb_BloodType.FormattingEnabled = true;
            this.cb_BloodType.Items.AddRange(new object[] {
            "O RH+",
            "O RH-",
            "A RH+",
            "A RH-",
            "B RH+",
            "B RH-",
            "AB RH+",
            "AB RH-"});
            this.cb_BloodType.Location = new System.Drawing.Point(89, 3);
            this.cb_BloodType.Name = "cb_BloodType";
            this.cb_BloodType.Size = new System.Drawing.Size(362, 24);
            this.cb_BloodType.TabIndex = 1;
            // 
            // lbl_BloodType
            // 
            this.lbl_BloodType.AutoSize = true;
            this.lbl_BloodType.Location = new System.Drawing.Point(-1, 6);
            this.lbl_BloodType.Name = "lbl_BloodType";
            this.lbl_BloodType.Size = new System.Drawing.Size(78, 16);
            this.lbl_BloodType.TabIndex = 0;
            this.lbl_BloodType.Text = "Blood Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.splitContainer2);
            this.groupBox2.Location = new System.Drawing.Point(12, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1387, 285);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Info";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 18);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutPanel3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel4);
            this.splitContainer2.Size = new System.Drawing.Size(1381, 264);
            this.splitContainer2.SplitterDistance = 524;
            this.splitContainer2.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.labeledInputText5);
            this.flowLayoutPanel3.Controls.Add(this.labeledInputText6);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(524, 264);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.labeledInputText12);
            this.flowLayoutPanel4.Controls.Add(this.labeledInputText13);
            this.flowLayoutPanel4.Controls.Add(this.labeledInputText7);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(853, 264);
            this.flowLayoutPanel4.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_Cancel);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Location = new System.Drawing.Point(12, 590);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 29);
            this.panel1.TabIndex = 2;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cancel.Location = new System.Drawing.Point(1228, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Cancel_MouseClick);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Save.Location = new System.Drawing.Point(1309, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // labeledInputText5
            // 
            this.labeledInputText5.BackColor = System.Drawing.SystemColors.Window;
            this.labeledInputText5.Location = new System.Drawing.Point(3, 3);
            this.labeledInputText5.Multiline = false;
            this.labeledInputText5.Name = "labeledInputText5";
            this.labeledInputText5.Size = new System.Drawing.Size(454, 27);
            this.labeledInputText5.TabIndex = 0;
            this.labeledInputText5.Title = "Mobile";
            // 
            // labeledInputText6
            // 
            this.labeledInputText6.BackColor = System.Drawing.SystemColors.Window;
            this.labeledInputText6.Location = new System.Drawing.Point(3, 36);
            this.labeledInputText6.Multiline = false;
            this.labeledInputText6.Name = "labeledInputText6";
            this.labeledInputText6.Size = new System.Drawing.Size(454, 27);
            this.labeledInputText6.TabIndex = 1;
            this.labeledInputText6.Title = "Tel";
            // 
            // labeledInputText12
            // 
            this.labeledInputText12.BackColor = System.Drawing.SystemColors.Window;
            this.labeledInputText12.Location = new System.Drawing.Point(3, 3);
            this.labeledInputText12.Multiline = false;
            this.labeledInputText12.Name = "labeledInputText12";
            this.labeledInputText12.Size = new System.Drawing.Size(454, 27);
            this.labeledInputText12.TabIndex = 2;
            this.labeledInputText12.Title = "State";
            // 
            // labeledInputText13
            // 
            this.labeledInputText13.BackColor = System.Drawing.SystemColors.Window;
            this.labeledInputText13.Location = new System.Drawing.Point(3, 36);
            this.labeledInputText13.Multiline = false;
            this.labeledInputText13.Name = "labeledInputText13";
            this.labeledInputText13.Size = new System.Drawing.Size(454, 27);
            this.labeledInputText13.TabIndex = 3;
            this.labeledInputText13.Title = "City";
            // 
            // labeledInputText7
            // 
            this.labeledInputText7.BackColor = System.Drawing.SystemColors.Window;
            this.labeledInputText7.Location = new System.Drawing.Point(3, 69);
            this.labeledInputText7.Multiline = true;
            this.labeledInputText7.Name = "labeledInputText7";
            this.labeledInputText7.Size = new System.Drawing.Size(454, 60);
            this.labeledInputText7.TabIndex = 1;
            this.labeledInputText7.Title = "Address";
            // 
            // labeledInputText1
            // 
            this.labeledInputText1.BackColor = System.Drawing.SystemColors.Window;
            this.labeledInputText1.Location = new System.Drawing.Point(3, 3);
            this.labeledInputText1.Multiline = false;
            this.labeledInputText1.Name = "labeledInputText1";
            this.labeledInputText1.Size = new System.Drawing.Size(454, 27);
            this.labeledInputText1.TabIndex = 0;
            this.labeledInputText1.Title = "Name";
            // 
            // labeledInputText2
            // 
            this.labeledInputText2.BackColor = System.Drawing.SystemColors.Window;
            this.labeledInputText2.Location = new System.Drawing.Point(3, 36);
            this.labeledInputText2.Multiline = false;
            this.labeledInputText2.Name = "labeledInputText2";
            this.labeledInputText2.Size = new System.Drawing.Size(454, 27);
            this.labeledInputText2.TabIndex = 1;
            this.labeledInputText2.Title = "Surname";
            // 
            // labeledInputText3
            // 
            this.labeledInputText3.BackColor = System.Drawing.SystemColors.Window;
            this.labeledInputText3.Location = new System.Drawing.Point(3, 69);
            this.labeledInputText3.Multiline = false;
            this.labeledInputText3.Name = "labeledInputText3";
            this.labeledInputText3.Size = new System.Drawing.Size(454, 27);
            this.labeledInputText3.TabIndex = 2;
            this.labeledInputText3.Title = "birth place";
            // 
            // labeledInputText8
            // 
            this.labeledInputText8.BackColor = System.Drawing.SystemColors.Window;
            this.labeledInputText8.Location = new System.Drawing.Point(3, 3);
            this.labeledInputText8.Multiline = false;
            this.labeledInputText8.Name = "labeledInputText8";
            this.labeledInputText8.Size = new System.Drawing.Size(454, 27);
            this.labeledInputText8.TabIndex = 0;
            this.labeledInputText8.Title = "Father";
            // 
            // labeledInputText9
            // 
            this.labeledInputText9.BackColor = System.Drawing.SystemColors.Window;
            this.labeledInputText9.Location = new System.Drawing.Point(3, 36);
            this.labeledInputText9.Multiline = false;
            this.labeledInputText9.Name = "labeledInputText9";
            this.labeledInputText9.Size = new System.Drawing.Size(454, 27);
            this.labeledInputText9.TabIndex = 1;
            this.labeledInputText9.Title = "Mother";
            // 
            // Form_AddNewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1411, 630);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_AddNewPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Patient";
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Widgets.LabeledInputText labeledInputText1;
        private Widgets.LabeledInputText labeledInputText2;
        private Widgets.LabeledInputText labeledInputText3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Widgets.LabeledInputText labeledInputText8;
        private Widgets.LabeledInputText labeledInputText9;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private Widgets.LabeledInputText labeledInputText5;
        private Widgets.LabeledInputText labeledInputText6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private Widgets.LabeledInputText labeledInputText12;
        private Widgets.LabeledInputText labeledInputText13;
        private Widgets.LabeledInputText labeledInputText7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_BloodType;
        private System.Windows.Forms.ComboBox cb_BloodType;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtp_BirthDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cb_Gender;
        private System.Windows.Forms.Label label2;
    }
}