using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCientifica
{
    public partial class Form1 : Form
    {
        private const string caracteresNãoPermitidos= "abcdefghijklmnopqrstuvwxyz";

        public Form1()
        {
            InitializeComponent();
        }

        private void rbPainelExibição_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        #region BotõesNúmericos

        private void btn1_Click(object sender, EventArgs e)
        {
            rbPainelExibição.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            rbPainelExibição.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            rbPainelExibição.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            rbPainelExibição.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            rbPainelExibição.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            rbPainelExibição.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            rbPainelExibição.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            rbPainelExibição.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            rbPainelExibição.Text += "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            rbPainelExibição.Text += "0";
        }

        private void btnZeroZero_Click(object sender, EventArgs e)
        {
            rbPainelExibição.Text += "00";
        }

        #endregion BotõesNúmericos
    }
}
