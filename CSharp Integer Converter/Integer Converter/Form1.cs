using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integer_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && e.KeyChar != '0' && e.KeyChar != '1')
            {
                e.Handled = true;
            }
        }

        private void OctTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && e.KeyChar != '0' && e.KeyChar != '1'
                                           && e.KeyChar != '2' && e.KeyChar != '3'
                                           && e.KeyChar != '4' && e.KeyChar != '5'
                                           && e.KeyChar != '6' && e.KeyChar != '7')
            {
                e.Handled = true;
            }
        }

        private void DecTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void HexTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                                           && e.KeyChar.ToString().ToUpper().ToCharArray()[0] != 'A'
                                           && e.KeyChar.ToString().ToUpper().ToCharArray()[0] != 'B'
                                           && e.KeyChar.ToString().ToUpper().ToCharArray()[0] != 'C'
                                           && e.KeyChar.ToString().ToUpper().ToCharArray()[0] != 'D'
                                           && e.KeyChar.ToString().ToUpper().ToCharArray()[0] != 'E'
                                           && e.KeyChar.ToString().ToUpper().ToCharArray()[0] != 'F')
            {
                e.Handled = true;
            }
        }

        private void BiTextBox_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (!BiTextBox.Text.Equals("")) i = Convert.ToInt32(BiTextBox.Text, 2);
            DecTextBox.Text = i.ToString();
        }

        private void OctTextBox_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (!OctTextBox.Text.Equals("")) i = Convert.ToInt32(OctTextBox.Text, 8);
            DecTextBox.Text = i.ToString();
        }

        private void HexTextBox_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (!HexTextBox.Text.Equals("")) i = Convert.ToInt32(HexTextBox.Text, 16);
            DecTextBox.Text = i.ToString();
        }

        private void DecTextBox_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (!DecTextBox.Text.Equals("")) i = Convert.ToInt32(DecTextBox.Text);
            BiTextBox.Text = Convert.ToString(i, 2);
            OctTextBox.Text = Convert.ToString(i, 8);
            HexTextBox.Text = Convert.ToString(i, 16);
        }
    }
}
