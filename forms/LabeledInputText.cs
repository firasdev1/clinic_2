using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinic_2.Widgets
{
    public partial class LabeledInputText : UserControl
    {
        public LabeledInputText()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        public new string Text
        {
            get => txt_Value.Text;
            set => txt_Value.Text = value;
        }
        public bool Multiline
        {
            get => txt_Value.Multiline;
            set => txt_Value.Multiline = value;
        }

        public bool ReadOnly
        {
            get => txt_Value.ReadOnly;
            set => txt_Value.ReadOnly = value;
        }
        [Browsable(true)]
        public string Title
        {
            get => lbl_Title.Text;
            set => lbl_Title.Text = value;
        }

        private void txt_Value_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
