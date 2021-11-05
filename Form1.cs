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
        private double valorInicial = 0;
        private double valorFinal = 0;
        private double valorMS = 0;

        private eOperação Operação;

        public Form1()
        {
            Operação = new eOperação();

            InitializeComponent();
        }

        private void rbPainelExibição_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsDigit(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Calculadora", ex.Message.ToString(), MessageBoxButtons.OK);
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

        #region Funções
        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbPainelExibição.Text.Trim() != null || rbPainelExibição.Text.Trim() != "0")
                {
                    valorInicial = Convert.ToDouble(rbPainelExibição.Text.Trim());

                    Operação = eOperação.Dividir;

                    rbPainelExibição.Text = string.Empty;
                }
            }
            catch (Exception _erro)
            {
                MessageBox.Show("Calculadora", _erro.Message.ToString(), MessageBoxButtons.OK);
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbPainelExibição.Text.Trim() != null || rbPainelExibição.Text.Trim() != "0")
                {
                    valorInicial = Convert.ToDouble(rbPainelExibição.Text.Trim());

                    Operação = eOperação.Multiplicar;

                    rbPainelExibição.Text = string.Empty;
                }
            }
            catch (Exception _erro)
            {
                MessageBox.Show("Calculadora", _erro.Message.ToString(), MessageBoxButtons.OK);
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbPainelExibição.Text.Trim() != null || rbPainelExibição.Text.Trim() != "0")
                {
                    valorInicial = Convert.ToDouble(rbPainelExibição.Text.Trim());

                    Operação = eOperação.Subtrair;
                }

                rbPainelExibição.Text = string.Empty;
            }
            catch (Exception _erro)
            {
                MessageBox.Show("Calculadora", _erro.Message.ToString(), MessageBoxButtons.OK);
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbPainelExibição.Text.Trim() != null || rbPainelExibição.Text.Trim() != "0")
                {
                    valorInicial = Convert.ToDouble(rbPainelExibição.Text.Trim());

                    Operação = eOperação.Somar;

                    rbPainelExibição.Text = string.Empty;
                }
            }
            catch (Exception _erro)
            {
                MessageBox.Show("Calculadora", _erro.Message.ToString(), MessageBoxButtons.OK);
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbPainelExibição.Text.Trim() != null)
                {
                    rbPainelExibição.Text = (ExecutarCalculo(Operação, valorInicial, double.Parse(rbPainelExibição.Text.Trim()))).ToString();
                }
            }
            catch (Exception _erro)
            {
                MessageBox.Show("Calculadora", _erro.Message.ToString(), MessageBoxButtons.OK);
            }
        }

        #endregion Funções

        private double ExecutarCalculo(eOperação Operação, double valorInicial, double valorSecundário)
        {
            double Resultado;

            try
            {
                switch (Operação)
                {
                    case eOperação.Somar:

                        Resultado = valorInicial + valorSecundário;
                        break;
                    case eOperação.Subtrair:

                        Resultado = valorInicial - valorSecundário;
                        break;
                    case eOperação.Dividir:

                        Resultado = valorInicial / valorSecundário;
                        break;
                    case eOperação.Multiplicar:

                        Resultado = valorInicial * valorSecundário;
                        break;
                    case eOperação.RaizQuadrada:

                        Resultado = Convert.ToInt32(Math.Sqrt(valorSecundário));
                        break;
                    default:
                        Resultado = 0;
                        break;
                }

                return Resultado;
            }
            catch (Exception _erro)
            {
                MessageBox.Show("Calculadora", _erro.Message.ToString(), MessageBoxButtons.OK);

                return 0.0;
            }
        }

        private void btnCa_Click(object sender, EventArgs e)
        {
            try
            {
                valorInicial = 0.0;
                valorFinal = 0.0;
                rbPainelExibição.Text = string.Empty;
            }
            catch (Exception _erro)
            {
                MessageBox.Show("Calculadora", _erro.Message.ToString(), MessageBoxButtons.OK);
            }
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnM_mais_Click(object sender, EventArgs e)
        {
            try
            {

                if (rbPainelExibição.Text.Trim() != null || rbPainelExibição.Text.Trim() != "0" && valorMS != 0.0)
                {
                    double valor = Convert.ToDouble(rbPainelExibição.Text.Trim());

                    valorMS = valorMS + valor;
                }
            }
            catch (Exception _erro)
            {
                MessageBox.Show("Calculadora", _erro.Message.ToString(), MessageBoxButtons.OK);
            }
        }

        private void btnM_menos_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbPainelExibição.Text.Trim() != null || rbPainelExibição.Text.Trim() != "0" && valorMS != 0.0)
                {
                    double valor = Convert.ToDouble(rbPainelExibição.Text.Trim());

                    valorMS = valorMS - valor;
                }
            }
            catch (Exception _erro)
            {
                MessageBox.Show("Calculadora", _erro.Message.ToString(), MessageBoxButtons.OK);
            }
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            try
            {
                if (valorMS != 0.0)
                {
                    rbPainelExibição.Text = valorMS.ToString();
                }
            }
            catch (Exception _erro)
            {
                MessageBox.Show("Calculadora", _erro.Message.ToString(), MessageBoxButtons.OK);
            }
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbPainelExibição.Text.Trim() != null || rbPainelExibição.Text.Trim() != "0")
                {
                    valorMS = Convert.ToDouble(rbPainelExibição.Text.Trim());

                    MessageBox.Show("Calculadora", "Valor Armazenado em memória", MessageBoxButtons.OK);
                }
            }
            catch (Exception _erro)
            {
                MessageBox.Show("Calculadora", _erro.Message.ToString(), MessageBoxButtons.OK);
            }
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            try
            {
                valorMS = 0.0;

                MessageBox.Show("Calculadora", "Valor Armazenado em memória apagado", MessageBoxButtons.OK);
            }
            catch (Exception _erro)
            {
                MessageBox.Show("Calculadora", _erro.Message.ToString(), MessageBoxButtons.OK);
            }
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            rbPainelExibição.Text += ",";
        }
    }
}
