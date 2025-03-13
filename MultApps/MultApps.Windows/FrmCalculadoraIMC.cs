using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class FrmCalculadoraIMC : Form
    {
        public FrmCalculadoraIMC()
        {
            InitializeComponent();
        }

        private void chkCrianca_CheckedChanged(object sender, EventArgs e)
        {
            chkCrianca.ForeColor = Color.DarkOrange;
            chkAdulto.ForeColor = Color.Gray;
            chkAdulto.Checked = false;
            lblIdade.Text = "Abaixo de 19 anos";
            cmbIdade.Visible = true;
            label5.Visible = true;
        }

        private void chkAdulto_CheckedChanged(object sender, EventArgs e)
        {
            chkAdulto.ForeColor = Color.DarkOrange;
            chkCrianca.ForeColor = Color.Gray;
            chkCrianca.Checked = false;
            lblIdade.Text = "Acima de 19 anos";
            cmbIdade.Visible = false;
            label5.Visible = false;
        }

        private void chkAdulto_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void chkCrianca_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
         {
            var peso = double.Parse(txtPeso.Text);
            var altura = double.Parse(txtAltura.Text);

            var imc = peso / (altura * altura);
            var TextoBase = $@"Meu IMC: {imc:N2} é";

            lblResultadoImc.Text = imc.ToString("N2");
            if (chkAdulto.Checked && chkMasculino.Checked)
            {

                #region Adulto Masculino

                if (chkMasculino.Checked)
                {

                    if (imc < 18.5)
                    {
                        lblResultadoImc.Text = $@"{TextoBase} é abaixo do normal";
                        picBoxImc.Load(ImcImagem.MasculinoAbaixoDoNormal);
                    }

                    else if (imc < 24.9)
                    {
                        lblResultadoImc.Text = $@"{TextoBase} é normal";
                        picBoxImc.Load(ImcImagem.MasculinoNormal);
                    }
                    else if (imc < 29.9)
                    {
                        lblResultadoImc.Text = $@"{TextoBase} é sobrepeso";
                        picBoxImc.Load(ImcImagem.MasculinoSobrePeso);
                    }
                    else if (imc < 34.9)
                    {
                        lblResultadoImc.Text = $@"{TextoBase} é obesidade grau 1";
                        picBoxImc.Load(ImcImagem.MasculinoObesidadeGrau1);
                    }
                    else if (imc < 39.9)
                    {
                        lblResultadoImc.Text = $@"{TextoBase} é obesidade grau 2";
                        picBoxImc.Load(ImcImagem.MasculinoObesidadeGrau2);
                    }
                    else
                    {
                        lblResultadoImc.Text = $@"{TextoBase} é obesidade grau 3";
                        picBoxImc.Load(ImcImagem.MasculinoObesidadeGrau3);
                    }
                }


                else if (chkFeminino.Checked)
                {
                    if (imc < 18.5)
                    {
                        lblResultadoImc.Text = $@"{TextoBase} é abaixo do normal";
                        picBoxImc.Load(ImcImagem.FemininoAbaixoDoNormal);
                    }

                    else if (imc < 24.9)
                    {
                        lblResultadoImc.Text = $@"{TextoBase} é normal";
                        picBoxImc.Load(ImcImagem.FemininoNormal);
                    }
                    else if (imc < 29.9)
                    {
                        lblResultadoImc.Text = $@"{TextoBase} é sobrepeso";
                        picBoxImc.Load(ImcImagem.FemininoSobrePeso);

                    }
                    else if (imc < 34.9)
                    {
                        lblResultadoImc.Text = $@"{TextoBase} é obesidade grau 1";
                        picBoxImc.Load(ImcImagem.FemininoObesidadeGrau1);

                    }
                    else if (imc < 39.9)
                    {
                        lblResultadoImc.Text = $@"{TextoBase} é obesidade grau 2";
                        picBoxImc.Load(ImcImagem.FemininoObesidadeGrau2);
                    }
                    else
                    {
                        lblResultadoImc.Text = $@"{TextoBase} é obesidade grau 3";
                        picBoxImc.Load(ImcImagem.FemininoObesidadeGrau3);
                    }
                    #endregion
                }
                  if (chkCrianca.Checked == true)
                  {
                    if (imc < 18.5)
                    {
                        lblResultadoImc.Text = $@"{TextoBase} é abaixo do normal";
                        picBoxImc.Load(ImcImagem.CriancaAbaixoDoNormal);
                    }

                    else if (imc < 24.9)
                    {
                        lblResultadoImc.Text = $@"{TextoBase} é normal";
                        picBoxImc.Load(ImcImagem.CriancaNormal);
                    }
                    else if (imc < 29.9)
                    {
                        lblResultadoImc.Text = $@"{TextoBase} é sobrepeso";
                        picBoxImc.Load(ImcImagem.CriancaSobrePeso);
                    }
                    else if (imc < 34.9)
                    {
                        lblResultadoImc.Text = $@"{TextoBase} é obesidade";
                        picBoxImc.Load(ImcImagem.CriancaObesidade);
                    }
                  }
            }

            else if (chkCrianca.Checked == true)
            {
                if (imc < 18.5)
                {
                    lblResultadoImc.Text = $@"{TextoBase} é abaixo do normal";
                    picBoxImc.Load(ImcImagem.CriancaAbaixoDoNormal);
                }

                else if (imc < 24.9)
                {
                    lblResultadoImc.Text = $@"{TextoBase} é normal";
                    picBoxImc.Load(ImcImagem.CriancaNormal);
                }
                else if (imc < 29.9)
                {
                    lblResultadoImc.Text = $@"{TextoBase} é sobrepeso";
                    picBoxImc.Load(ImcImagem.CriancaSobrePeso);
                }
                else if (imc < 34.9)
                {
                    lblResultadoImc.Text = $@"{TextoBase} é obesidade";
                    picBoxImc.Load(ImcImagem.CriancaObesidade);
                }
            }


        }
        private void chkMasculino_CheckedChanged(object sender, EventArgs e)
        {
            chkMasculino.ForeColor = Color.DarkOrange;
            chkFeminino.ForeColor = Color.Gray;
            chkFeminino.Checked = false;
        }

        private void chkFeminino_CheckedChanged(object sender, EventArgs e)
        {
            chkFeminino.ForeColor = Color.DarkOrange;
            chkMasculino.ForeColor = Color.Gray;
            chkMasculino.Checked = false;
        }

        private void chkMasculino_Click(object sender, EventArgs e)
        {
            chkMasculino.ForeColor = Color.DarkOrange;
            chkFeminino.ForeColor = Color.Gray;
            chkFeminino.Checked = false;
        }

            
       
    }
}
