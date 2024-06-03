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
    public partial class FormEmpleados : Form
    {

        EmpleadosLogic empleado = new EmpleadosLogic();
        PagosLogic pago = new PagosLogic();
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void cleanFields()
        {
            txtNombre.Clear();
            txtApellidop.Clear();
            txtDireccion.Clear();
            txtEmergencia.Clear();
            txtNss.Clear();
            txtPago.Text = "0";
            txtBono.Text = "0";
            txtApelldiom.Clear();
            txtTelefono.Clear();
            comboTipoEmpleado.SelectedIndex = -1;
            comboRazonSocial.SelectedIndex = -1;
        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            int rowIndex = gridEmpleados.SelectedRows[0].Index;

            // Obtener el valor de la primera celda de la fila seleccionada (por ejemplo, un identificador único)
            var id_empleado = gridEmpleados.Rows[rowIndex].Cells[0].Value.ToString();
            if (empleado.Updatel(id_empleado, txtNombre.Text, txtApellidop.Text, txtApelldiom.Text, txtDireccion.Text, txtTelefono.Text, txtEmergencia.Text, txtPago.Text, txtBono.Text, comboTipoEmpleado.Text, "", txtNss.Text, "", comboRazonSocial.Text))
            {
                gridEmpleados.DataSource = empleado.GetListl().Tables[0];

                cleanFields();
                btnModificarEmpleado.Visible = false;
                btnAgregarEmpleado.Visible = true;

            }

            MessageBox.Show(empleado.error);
        }

        private void btnCancelarEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {

            try
            {
                
                if (empleado.Writel(txtNombre.Text, txtApellidop.Text, txtApelldiom.Text, txtDireccion.Text, txtTelefono.Text, txtEmergencia.Text, txtPago.Text, txtBono.Text, comboTipoEmpleado.Text, "", txtNss.Text, "", comboRazonSocial.Text))
                {
                    gridEmpleados.DataSource = empleado.GetListl().Tables[0];

                    cleanFields();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            MessageBox.Show(empleado.error);
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            gridEmpleados.DataSource = empleado.GetListl().Tables[0];
            txtNombre.Focus();
        }

        private void eliminarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Obtener el índice de la fila seleccionada en el DataGridView
            int rowIndex = gridEmpleados.SelectedRows[0].Index;

            // Obtener el valor de la primera celda de la fila seleccionada (por ejemplo, un identificador único)
            string idEmpleado = gridEmpleados.Rows[rowIndex].Cells[0].Value.ToString();

            // Llamar al método para eliminar el empleado basado en su identificador único
            empleado.Deletel(idEmpleado);

            gridEmpleados.DataSource = empleado.GetListl().Tables[0];
        }

        private void modificarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = gridEmpleados.SelectedRows[0].Index;

            // Obtener el valor de la primera celda de la fila seleccionada (por ejemplo, un identificador único)
            txtNombre.Text = gridEmpleados.Rows[rowIndex].Cells[1].Value.ToString();
            txtApellidop.Text = gridEmpleados.Rows[rowIndex].Cells[2].Value.ToString();
            txtApelldiom.Text = gridEmpleados.Rows[rowIndex].Cells[3].Value.ToString();
            txtPago.Text = gridEmpleados.Rows[rowIndex].Cells[4].Value.ToString();
            txtBono.Text = gridEmpleados.Rows[rowIndex].Cells[5].Value.ToString();

            string valor = gridEmpleados.Rows[rowIndex].Cells[6].Value.ToString();
            int indice = comboTipoEmpleado.FindStringExact(valor);

            if (indice != -1) // Si se encontró el valor en el ComboBox
            {
                comboTipoEmpleado.SelectedIndex = indice; // Seleccionar el elemento en el ComboBox
            }
            else comboTipoEmpleado.SelectedIndex = -1;

            string valor2 = gridEmpleados.Rows[rowIndex].Cells[11].Value.ToString();
            int indice2 = comboRazonSocial.FindStringExact(valor2);

            if (indice2 != -1) // Si se encontró el valor en el ComboBox
            {
                comboRazonSocial.SelectedIndex = indice2; // Seleccionar el elemento en el ComboBox
            }
            else comboRazonSocial.SelectedIndex = -1;

            txtNss.Text = gridEmpleados.Rows[rowIndex].Cells[7].Value.ToString();
            txtDireccion.Text = gridEmpleados.Rows[rowIndex].Cells[8].Value.ToString();
            txtTelefono.Text = gridEmpleados.Rows[rowIndex].Cells[9].Value.ToString();
            txtEmergencia.Text = gridEmpleados.Rows[rowIndex].Cells[10].Value.ToString();

            btnModificarEmpleado.Visible = true;
            btnAgregarEmpleado.Visible = false;
        }
    }
}
