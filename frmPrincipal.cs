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
        #region Variáveis

        private double primeiraUnidade = 0;
        private double segundaUnidade = 0;
        private double valorMS = 0;

        private eOperação Operação;

        #endregion

        public frmPrincipal()
        {
            InitializeComponent();

            Definir_ValoresPadrões();

            Operação = eOperação.SemOperação;
        }        

        #region Eventos Númericos

        private void btn_CE_Click(object sender, EventArgs e)
        {
            Definir_ValoresPadrões();
        }

        private void btn_Virgula_Click(object sender, EventArgs e)
        {
            if (!Limitar_Virgulas())
            {
                rb_PainelExibição.Text += ",";
            }
        }

        private void btn_Númerico_Click(object sender, EventArgs e)
        {            
            string valor = ((Button)sender).Text;            
            rb_PainelExibição.Text += valor;
        }

        #endregion

        #region Eventos Operações

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
                rb_PainelExibição.Text = "0";
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
                rb_PainelExibição.Text = "0";
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
                Operação = eOperação.Somar;
                rb_PainelExibição.Text = "0";
            }
        }

        private void btn_Operação_Resultado_Click(object sender, EventArgs e)
        {
            try
            {
                segundaUnidade = Convert.ToDouble(rb_PainelExibição.Text);

                Executar_Calculo();

                Operação = eOperação.SemOperação;
            }
            catch (Exception erro)
            {
                Definir_ValoresPadrões();

                MessageBox.Show("Comportamento inesperado da aplicação.\n" +
                                "Contate o Administrador", "Calculadora",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);                
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
                rb_PainelExibição.Text = "0";
            }
        }

        private void btn_Operação_Raiz_Click(object sender, EventArgs e)
        {
            try
            {
                segundaUnidade = Convert.ToDouble(rb_PainelExibição.Text);
                Operação = eOperação.RaizQuadrada;
                Executar_Calculo();
            }
            catch (Exception erro)
            {
                segundaUnidade = 0;
                rb_PainelExibição.Text = "0";
            }
        }

        private void btn_Operação_MS_Click(object sender, EventArgs e)
        {
            Executar_MemoryValue(sender);
        }

        private void btn_Operação_MC_Click(object sender, EventArgs e)
        {
            Executar_MemoryValue(sender);
        }

        private void btn_Operação_MR_Click(object sender, EventArgs e)
        {
            Executar_MemoryValue(sender);
        }

        private void btn_Operação_M_Subtrair_Click(object sender, EventArgs e)
        {
            Executar_MemoryValue(sender);
        }

        private void btn_Operação_M_Adicionar_Click(object sender, EventArgs e)
        {
            Executar_MemoryValue(sender);
        }

        #endregion

        #region Demais Eventos

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

        private void rb_PainelExibição_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rb_PainelExibição.Text == string.Empty)
                {
                    rb_PainelExibição.Text = "0";
                }
                else if (rb_PainelExibição.Text.EndsWith(",") || rb_PainelExibição.Text.EndsWith("0"))
                {
                    //Valores Aceitos como exceção durante o input dos valores
                }
                else
                {
                    double valor = Convert.ToDouble(rb_PainelExibição.Text);
                    rb_PainelExibição.Text = valor.ToString();
                }

                TextBox RichBox = (TextBox)sender;
                RichBox.Focus();
                RichBox.Select(RichBox.Text.Length, 0);
                RichBox.ScrollToCaret();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message, "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Definir_ValoresPadrões();
            }            
        }

        private void lbl_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
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
                            rb_PainelExibição.Text = "0";

                        break;
                }
            }
            catch (Exception _erro)
            {
            }
        }

        private bool Limitar_Virgulas()
        {
            return rb_PainelExibição.Text.Count(c => c == ',') > 0;
        }

        private void Definir_ValoresPadrões()
        {
            rb_PainelExibição.Text = "0";
            primeiraUnidade = 0;
            segundaUnidade = 0;
            valorMS = 0;

            Operação = eOperação.SemOperação;
        }

        private string Carregar_Mensagem_EasterEgg()
        {
            string mensagem = string.Empty;

            List<string> lista = new List<string>() { "\"O sucesso é a soma de pequenos esforços repetidos dia após dia.\" \n- Robert Collier",
                                                      "\"Acredite em si mesmo e todo o resto se encaixará. \nTenha fé em seus próprios talentos, habilidades e capacidades.\"\n - Norman Vincent Peale",
                                                      "\"Não espere por circunstâncias ideais. Crie-as.\"\n - George Bernard Shaw",
                                                      "\"O fracasso é apenas a oportunidade de começar de novo, de forma mais inteligente.\"\n - Henry Ford",
                                                      "\"O maior prazer na vida é fazer o que as pessoas dizem que você não pode fazer.\"\n - Walter Bagehot",
                                                      "\"Não deixe que o medo de falhar o impeça de alcançar o sucesso.\"\n - H. Jackson Brown Jr.\r\n\r\n",
                                                      "\"Acredite que você pode e você está no meio do caminho.\"\n - Theodore Roosevelt",
                                                      "\"Se você traçar metas absurdamente altas e falhar, seu fracasso será muito melhor que o sucesso de todos.\"\n - James Cameron",
                                                      "\"O sucesso é a capacidade de ir de um fracasso a outro sem perder entusiasmo.\"\n - Winston Churchill",
                                                      "\"A vida é 10% do que acontece comigo e 90% de como eu reajo a isso.\"\n - Charles R. Swindoll"};

            Random random = new Random();
            return lista[random.Next(0, 9)];
        }

        private void Exibir_Resultado(double Resultado)
        {
            rb_PainelExibição.Text = Resultado.ToString();
        }

        private void Executar_MemoryValue(object sender)
        {
            try
            {
                string Ação = ((Button)sender).Text;

                switch (Ação)
                {
                    case "MS":
                        {
                            valorMS = Convert.ToDouble(rb_PainelExibição.Text);
                        }
                        break;
                    case "MC":
                        {
                            valorMS = 0;
                        }
                        break;
                    case "MR":
                        {
                            rb_PainelExibição.Text = valorMS.ToString();
                        }
                        break;
                    case "M+":
                        {
                            double valor = Convert.ToDouble(rb_PainelExibição.Text);
                            valorMS += valor;
                        }
                        break;
                    case "M-":
                        {
                            double valor = Convert.ToDouble(rb_PainelExibição.Text);
                            valorMS -= valor;
                        }
                        break;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Definir_ValoresPadrões();
            }
        }

        private void Filtrar_TeclaPressionada(ref KeyPressEventArgs args)
        {
            #region Númerico

            if (char.IsDigit(args.KeyChar))
            {
                return;
            }

            #endregion Númerico

            #region Alfanúmericos

            switch (args.KeyChar)
            {
                case '+':

                    args.Handled = true;
                    btn_Operação_Adicionar_Click(null, null);
                    return;
                case '-':

                    args.Handled = true;
                    btn_Operação_Subtrair_Click(null, null);
                    return;
                case '*':

                    args.Handled = true;
                    btn_Operação_Multiplicar_Click(null, null);
                    return;
                case '/':

                    args.Handled = true;
                    btn_Operação_Dividir_Click(null, null);
                    return;
                case '=':
                case (char)Keys.Enter:

                    args.Handled = true;
                    btn_Operação_Resultado_Click(null, null);
                    return;
                case ',':

                    if (Limitar_Virgulas())
                        args.Handled = true;
                    return;                
                case (char)Keys.Escape:

                    btn_CE_Click(null, null);
                    return;
                case (char)Keys.Back:
                    return;

                default:
                    args.Handled = true;
                    break;

            }

            #endregion Permitido
        }

        #endregion Funções Privadas   

        #region Easter Egg

        private void lbl_Título_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(Carregar_Mensagem_EasterEgg(), "Easter Egg", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion        
    }
}
