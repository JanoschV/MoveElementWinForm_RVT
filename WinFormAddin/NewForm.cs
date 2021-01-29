using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAddin
{
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool isHorizontal()
        {
            if (RdoHorizontal.Checked)
                return true;
            else
                return false;
        }

        public double getDistance()
        {
            double d;
            Double.TryParse(txtDistance.Text, out d);
            return  d;    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
