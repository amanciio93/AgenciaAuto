using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaAutomotiva
{
    public partial class FormularioVeiculos: Form
    {
        public FormularioVeiculos()
        {
            InitializeComponent();
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtId.Text);
            BuscarVeiculoId(id);
        }

        private void BuscarVeiculoId(int id)
        {
            try
            {
                var veiculo = new Veiculo().GetVeiculo(id);

                if (veiculo != null)
                {
                    txtId.Text = veiculo.id.ToString();
                    txtMarca.Text = veiculo.marca.ToString();
                    txtModelo.Text = veiculo.modelo.ToString();
                    txtAno.Text = veiculo.ano.ToString();
                    txtCor.Text = veiculo.cor.ToString();
                    txtFabricacao.Text = veiculo.fabricacao.ToString().Replace("00:00:00", "");
                    txtValor.Text = veiculo.valor.ToString();
                }
                else
                    MessageBox.Show("Veiculo não encontrado!");
            }
            catch (Exception msg)
            {

                MessageBox.Show(msg.Message);
                
            }
        }

        private void buscarToolStripButton_Click(object sender, EventArgs e)
        {
            var veiculo = new Parametro();
            veiculo.id = 0;

            using (FormularioBuscarVeiculo fbv = new FormularioBuscarVeiculo(veiculo))
            {
                fbv.ShowDialog();
                if (veiculo.id > 0)
                    BuscarVeiculoId(veiculo.id);
            }
        }
    }
}
