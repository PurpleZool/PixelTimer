using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public class NumericTextBox : System.Windows.Forms.TextBox
    {
        public NumericTextBox()
        {
            this.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            this.TextChanged += new EventHandler(NumericTextBox_TextChanged);
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NumericTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Text))
            {
                return;
            }

            if (!double.TryParse(this.Text, out double num))
            {
                // Si el texto no puede ser convertido a un número, establecerlo en cero
                this.Text = "0";
            }
        }


    }
}
