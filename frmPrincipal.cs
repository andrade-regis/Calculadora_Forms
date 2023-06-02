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
    public partial class frmPrincipal : Form
    {
        private double primeiraUnidade = 0;
        private double segundaUnidade = 0;
        private double valorMS = 0;

        private eOperação Operação;

        public frmPrincipal()
        {
            Operação = eOperação.SemOperação;

            InitializeComponent();
        }

        private void rb_PainelExibição_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Filtrar_TeclaPressionada(ref e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Calculadora", ex.Message.ToString(), MessageBoxButtons.OK);
            }
        }

        private void lbl_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Eventos Númericos

        private void btn_Númerico_Click(object sender, EventArgs e)
        {            
            string valor = ((Button)sender).Text;            
            rb_PainelExibição.Text += valor;
        }

        #endregion

        #region Botões Operações

        private void btn_Operação_Dividir_Click(object sender, EventArgs e)
        {
            try
            {
                primeiraUnidade = Convert.ToDouble(rb_PainelExibição.Text);                
            }
            catch(Exception erro)
            {
                primeiraUnidade = 0;
            }
            finally
            {
                Operação = eOperação.Dividir;
                rb_PainelExibição.Text = string.Empty;
            }
        }

        private void btn_Operação_Multiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                primeiraUnidade = Convert.ToDouble(rb_PainelExibição.Text);
            }
            catch (Exception erro)
            {
                primeiraUnidade = 0;
            }
            finally
            {
                Operação = eOperação.Multiplicar;
                rb_PainelExibição.Text = string.Empty;
            }
        }

        private void btn_Operação_Subtrair_Click(object sender, EventArgs e)
        {
            try
            {
                primeiraUnidade = Convert.ToDouble(rb_PainelExibição.Text);
            }
            catch (Exception erro)
            {
                primeiraUnidade = 0;
            }
            finally
            {
                Operação = eOperação.Subtrair;
                rb_PainelExibição.Text = string.Empty;
            }
        }

        private void btn_Operação_Adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                primeiraUnidade = Convert.ToDouble(rb_PainelExibição.Text);
            }
            catch (Exception erro)
            {
                primeiraUnidade = 0;
            }
            finally
            {
                Operação = eOperação.Subtrair;
                rb_PainelExibição.Text = string.Empty;
            }
        }

        private void btn_Operação_Resultado_Click(object sender, EventArgs e)
        {
            try
            {
                segundaUnidade = Convert.ToDouble(rb_PainelExibição.Text);

                Executar_Calculo();
            }
            catch (Exception erro)
            {
                Definir_ValoresPadrões();

                MessageBox.Show("Comportamento inesperado da aplicação.\n" +
                                "Contate o Administrador", "Calculadora",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        #endregion


        #region Funções Privadas

        private void Executar_Calculo()
        {
            double resultado = 0;

            try
            {
                switch (Operação)
                {
                    case eOperação.Somar:

                        resultado = primeiraUnidade + segundaUnidade;
                        Exibir_Resultado(resultado);

                        break;
                    case eOperação.Subtrair:

                        resultado = primeiraUnidade - segundaUnidade;
                        Exibir_Resultado(resultado);

                        break;
                    case eOperação.Dividir:

                        resultado = primeiraUnidade / segundaUnidade;
                        Exibir_Resultado(resultado);

                        break;
                    case eOperação.Multiplicar:

                        resultado = primeiraUnidade * segundaUnidade;
                        Exibir_Resultado(resultado);

                        break;
                    case eOperação.RaizQuadrada:

                        resultado = Convert.ToInt32(Math.Sqrt(segundaUnidade));
                        Exibir_Resultado(resultado);

                        break;
                    default:

                        if (rb_PainelExibição.Text != string.Empty)
                            rb_PainelExibição.Text = string.Empty;

                        break;
                }
            }
            catch (Exception _erro)
            {
            }
        }

        private void Definir_ValoresPadrões()
        {
            rb_PainelExibição.Text = string.Empty;
            primeiraUnidade = 0;
            segundaUnidade = 0;
            valorMS = 0;
        }

        private void Exibir_Resultado(double Resultado)
        {
            rb_PainelExibição.Text = Resultado.ToString();
        }

        private void Filtrar_TeclaPressionada(ref KeyPressEventArgs args)
        {
            #region Númerico

            if (char.IsDigit(args.KeyChar))
            {
                return;
            }

            #endregion Númerico

            #region Permitido

            switch (args.KeyChar)
            {
                case (char)Keys.Add:

                    btn_Operação_Adicionar_Click(null, null);
                    return;
                case (char)Keys.Subtract:

                    btn_Operação_Subtrair_Click(null, null);
                    return;
                case (char)Keys.Multiply:

                    btn_Operação_Multiplicar_Click(null, null);
                    return;
                case (char)Keys.Divide:

                    btn_Operação_Dividir_Click(null, null);
                    return;
                case (char)Keys.Oemplus:

                    btn_Operação_Resultado_Click(null, null);
                    return;
                case (char)Keys.Oemcomma:

                    if (rb_PainelExibição.Text.Count(c => c == ',') > 0)
                        args.Handled = true;
                    return;                
                case (char)Keys.Escape:


                    return;
                case (char)Keys.Back:
                    return;

            }

            #endregion Permitido


        }




        #endregion Funções Privadas

        
    }
}
