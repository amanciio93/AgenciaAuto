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
    public partial class FormularioBuscarVeiculo: Form
    {
        Parametro veiculo = new Parametro();
        public FormularioBuscarVeiculo(Parametro veiculo)
        {
            InitializeComponent();
            this.veiculo = veiculo;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            BuscarVeiculo(txtMarca.Text);
        }

        private void BuscarVeiculo(string marca)
        {
            dataGridView.DataSource = Veiculo.GetVeiculos(marca);
        }

        private void dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            veiculo.id = Convert.ToInt32(dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[0].Value);
        }

        private void selecionarToolStripButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
