using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Venda_SEm_Base_de_Dados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

         
        }
        double preco, total, quant,descontos;
        private void Form1_Load(object sender, EventArgs e)
        {
            btn_OK.Enabled = false;
            btn_update.Enabled = false;
            DesaHabilitarCampos();
            RSim.Checked = true;
           
            

        }

        void HabilitarCampos()
        {

            txtCliente.Enabled = true;
            txtId.Enabled = true;
          //txtDesconto.Enabled = true;
            NUm_Quant.Enabled = true;
            CbProdu.Enabled = true;
        }
        void DesaHabilitarCampos()
        {

            txtId.Enabled = false;
            txtCliente.Enabled = false;
           txtDesconto.Enabled = false;
            NUm_Quant.Enabled = false;
            CbProdu.Enabled = false;
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            limpar();
            btn_update.Enabled=false;
            btn_OK.Enabled = true;
            btn_Novo.Enabled = false;
        }

        void ValidarCampos()
        {
            if (txtId.Text=="")
            {
                MessageBox.Show("Por favor Preecha O Campo  Id do Cliente!", "Informação");
                txtId.Focus();
            }

            else if(txtCliente.Text=="")
            {
                MessageBox.Show("Por favor Preecha O Campo  Cliente!", "Informação");
                txtCliente.Focus();
            }

            else if (CbProdu.Text == "")
            {
                MessageBox.Show("Por favor Preecha O Campo  Designação!", "Informação");
                CbProdu.Focus();
            }

            else if (NUm_Quant.Value == 0)
            {
                MessageBox.Show("Por favor Preecha O Campo  Quantidade!", "Informação");
                NUm_Quant.Focus();

            }
            else if (txtDesconto.Text == "")
            {
                MessageBox.Show("Por favor Preecha o Campo Desconto!", "Alerta");
                txtDesconto.Focus();
            }
            else
            {
                Cadastrar();
             

            }
           
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            ValidarCampos();
            // DesaHabilitarCampos();

           
           
        }

        void Pagar()
        {
            quant =double.Parse( NUm_Quant.Value.ToString() );
            descontos = double.Parse(txtDesconto.Text);
         

            if (CbProdu.Text== "Speed Bidon")
            {
                preco = 350;
                lbl_preco.Text = preco.ToString() + " Kz";
                total = quant * preco - descontos; 

                lbl_total.Text = total.ToString() +" Kz";
            }

            else if (CbProdu.Text == "Speed Lata")
                {
                    preco = 700;
                    lbl_preco.Text = preco.ToString() + " Kz";
                    total = quant * preco - descontos;

                    lbl_total.Text = total.ToString() + " Kz";
                }

            else if (CbProdu.Text == "Bolacha Girabola")
            {
                preco = 100;
                lbl_preco.Text = preco.ToString() + " Kz";
                total = quant * preco - descontos;

                lbl_total.Text = total.ToString() + " Kz";
            }

            else if (CbProdu.Text == "Bolacha Maria")
            {
                preco = 250;
                lbl_preco.Text = preco.ToString() + " Kz";
                total = quant * preco - descontos;

                lbl_total.Text = total.ToString() + " Kz";
            }
            else if (CbProdu.Text == "Bolacha Hipopó")
            {
                preco = 300;
                lbl_preco.Text = preco.ToString() + " Kz";
                total = quant * preco - descontos;

                lbl_total.Text = total.ToString() + " Kz";
            }
            else if (CbProdu.Text == "Bolacha Água e Sal")
            {
                preco = 250;
                lbl_preco.Text = preco.ToString() + " Kz";
                total = quant * preco - descontos;

                lbl_total.Text = total.ToString() + " Kz";
            }
        }

        void Cadastrar()
        {
            MessageBox.Show("Venda feita com Sucesso!!", "Informação");
            lbl_Id.Text = txtId.Text;
            lbl_Cliente.Text = txtCliente.Text;
            lbl_Desconto.Text = txtDesconto.Text +" Kz";
            lbl_desig.Text = CbProdu.Text ;

            lbl_quant.Text = NUm_Quant.Value.ToString();           
            btn_OK.Enabled = false;
            DesaHabilitarCampos();
            btn_Novo.Enabled = true;
            Pagar(); 
            btn_update.Enabled = true;
           // limpar();

                 }

        void limpar()
        {

            txtCliente.Text = "";
            txtDesconto.Text = "";
            NUm_Quant.Text = "";
            CbProdu.Text = "";
            txtId.Text = "";
        }

       
        private void RSim_CheckedChanged(object sender, EventArgs e)
        {
            DescontosSIM();
        }

        void DescontosSIM()
        {
            if(RSim.Enabled==true)
            {
                txtDesconto.Text = "";
                txtDesconto.Enabled = true;
                txtDesconto.Focus();
                lblDes.Text = "Desconto Aplicado!";
              
            }
        }
        void DescontosNAO()
        {
            if (RNao.Enabled == true)
            {                
                txtDesconto.Enabled = false; txtDesconto.Text = "0";
                lblDes.Text = "Desconto Não Aplicado!"; //HabilitarCampos();
            }
        }

        private void RNao_CheckedChanged(object sender, EventArgs e)
        {
            DescontosNAO();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            btn_OK.Enabled = true;
            btn_Novo.Enabled = false;
            btn_update.Enabled = false; 
            HabilitarCampos();
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
           // DesaHabilitarCampos();
        }

        private void NUm_Quant_ValueChanged(object sender, EventArgs e)
        {
           



        }
    }
}
