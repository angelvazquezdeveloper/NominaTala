using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NominaTala
{
    public partial class FormParques : Form
    {
        ParquesLogic parque = new ParquesLogic();
        public FormParques()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int rowIndex = gridParques.SelectedRows[0].Index;

            // Obtener el valor de la primera celda de la fila seleccionada (por ejemplo, un identificador único)
            var id_parque = gridParques.Rows[rowIndex].Cells[0].Value.ToString();

            if (parque.Updatel(id_parque, txtParque.Text, txtDomicilio.Text))
            {
                gridParques.DataSource = parque.GetListl().Tables[0];


            }
            MessageBox.Show(parque.error);
        }

        private void btnAddParque_Click(object sender, EventArgs e)
        {
            if (parque.Writel(txtParque.Text, txtDomicilio.Text))
            {
                gridParques.DataSource = parque.GetListl().Tables[0];


            }
            MessageBox.Show(parque.error);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Obtener el índice de la fila seleccionada en el DataGridView
            int rowIndex = gridParques.SelectedRows[0].Index;

            // Obtener el valor de la primera celda de la fila seleccionada (por ejemplo, un identificador único)
            string idParque = gridParques.Rows[rowIndex].Cells[0].Value.ToString();

            if (MessageBox.Show("Desea continuar con la operacón", "Eliminar Parque",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
            {
                parque.Deletel(idParque);

                gridParques.DataSource = parque.GetListl().Tables[0];
                MessageBox.Show(parque.error);
            }

            // Llamar al método para eliminar el empleado basado en su identificador único
            

            
        }

        private void mdificarParqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = gridParques.SelectedRows[0].Index;

            // Obtener el valor de la primera celda de la fila seleccionada (por ejemplo, un identificador único)
            txtParque.Text = gridParques.Rows[rowIndex].Cells[1].Value.ToString();

            txtDomicilio.Text = gridParques.Rows[rowIndex].Cells[2].Value.ToString();

            btnModificar.Visible = true;
            btnAddParque.Visible = false;
        }

        private void FormParques_Load(object sender, EventArgs e)
        {
            gridParques.DataSource = parque.GetListl().Tables[0];
            txtParque.Focus();
        }
    }
}
