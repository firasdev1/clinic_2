namespace clinic_2.forms
{
    partial class addnewpatient
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
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bloodtype_tb = new System.Windows.Forms.TextBox();
            this.address_tb = new System.Windows.Forms.TextBox();
            this.age_tb = new System.Windows.Forms.TextBox();
            this.fullname_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(189, 227);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "blood type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "age :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "full name :";
            // 
            // bloodtype_tb
            // 
            this.bloodtype_tb.Location = new System.Drawing.Point(189, 169);
            this.bloodtype_tb.Name = "bloodtype_tb";
            this.bloodtype_tb.Size = new System.Drawing.Size(183, 22);
            this.bloodtype_tb.TabIndex = 4;
            // 
            // address_tb
            // 
            this.address_tb.Location = new System.Drawing.Point(189, 141);
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(183, 22);
            this.address_tb.TabIndex = 5;
            // 
            // age_tb
            // 
            this.age_tb.Location = new System.Drawing.Point(189, 112);
            this.age_tb.Name = "age_tb";
            this.age_tb.Size = new System.Drawing.Size(183, 22);
            this.age_tb.TabIndex = 6;
            // 
            // fullname_tb
            // 
            this.fullname_tb.Location = new System.Drawing.Point(189, 82);
            this.fullname_tb.Name = "fullname_tb";
            this.fullname_tb.Size = new System.Drawing.Size(183, 22);
            this.fullname_tb.TabIndex = 7;
            // 
            // addnewpatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bloodtype_tb);
            this.Controls.Add(this.address_tb);
            this.Controls.Add(this.age_tb);
            this.Controls.Add(this.fullname_tb);
            this.Name = "addnewpatient";
            this.Text = "addnewpatient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bloodtype_tb;
        private System.Windows.Forms.TextBox address_tb;
        private System.Windows.Forms.TextBox age_tb;
        private System.Windows.Forms.TextBox fullname_tb;
    }
}