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
                using (var dbContext = new AgenciaAutomotivaBDEntities())
                {
                    var veiculo = dbContext.Veiculos.Find(id);

                    if (txtId != null) 
                    {
                        txtId.Text = veiculo.id.ToString();
                    }

                    txtMarca.Text = veiculo.marca.ToString();
                }

            }
            catch (Exception msg)
            {

                MessageBox.Show(msg.Message);
                
            }
        }
    }
}
