using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedeserviceFinal
{
    public partial class UCEx6 : UserControl
    {
        public UCEx6()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCepConsulta.Text))
            {
                using (var ws = new WsCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(txtCepConsulta.Text.Trim());

                        txtBairro.Text = endereco.bairro;
                        txtCep.Text = endereco.cep;
                        txtCidade.Text = endereco.cidade;
                        txtComplemento.Text = endereco.complemento2;
                        txtUf.Text = endereco.uf;
                        txtEndereco.Text = endereco.end;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Informe um CEP válido!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
