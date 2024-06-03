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
    public partial class FormMain : Form
    {
        EmpleadosLogic empleados = new EmpleadosLogic();
        ParquesLogic parques = new ParquesLogic();
        AsistenciaDestajoLogic empleadosDestajo = new AsistenciaDestajoLogic();
        AsistenciaPisoLogic empleadosPiso = new AsistenciaPisoLogic();
        DataTable dtEmpleadosDestajo;
        private DateTime fechaActual;

        public FormMain()
        {
            InitializeComponent();
        }
        private void fillComboEmpleado()
        {
            comboEmpleado.DataSource = empleados.GetListlDestajo().Tables[0];
            comboEmpleado.DisplayMember = "Nombre";
            comboEmpleado.ValueMember = "Id";
        }
        private void fillComboParque()
        {
            comboParques.DataSource = parques.GetListl().Tables[0];
            comboParques.DisplayMember = "Nombre";
            comboParques.ValueMember = "Id_Parque";
        }
        private void addColumns()
        {

            for (int i = 0; i < 8; i++)
            {
                DataGridViewTextBoxColumn nuevaColumna = new DataGridViewTextBoxColumn();
                nuevaColumna.Name = "Columna" + i.ToString(); // Asignar un nombre único a la columna
                nuevaColumna.HeaderText = "Arbol"; // Asignar el encabezado de la columna
                                                   // Ajustar otras propiedades según sea necesario

                // Agregar la nueva columna al DataGridView
                gridDestajo.Columns.Add(nuevaColumna);


            }

            DataGridViewTextBoxColumn bonoColumna = new DataGridViewTextBoxColumn();
            bonoColumna.Name = "Bono Extra"; // Asignar un nombre único a la columna
            bonoColumna.HeaderText = "Bono Extra"; // Asignar el encabezado de la columna
                                                   // Ajustar otras propiedades según sea necesario

            // Agregar la nueva columna al DataGridView
            gridDestajo.Columns.Add(bonoColumna);


        }
        private void fillAllDataGrid(DataTable Destajo, int donde)
        {
            for (int i = 0; i < Destajo.Rows.Count; i++)
            {

                fillDataRow(i, Destajo.Rows[i][1].ToString(), findIdParque(Destajo.Rows[i][0].ToString()), donde);

            }

        }

        private void fillDataRow(int numeroFila, string id_empleado, string id_parques, int donde)
        {

            DataTable dataTable = empleadosDestajo.getTalaofEmployes(id_empleado, dateAsistencia.Value, id_parques).Tables[0];
            var numeroColumna = 0;
            if (donde == 0) numeroColumna = 6;
            if (donde == 1) numeroColumna = 0;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {

                // Obtener el valor de la celda en la fila actual y la columna actual del DataTable
                object valorCelda1 = dataTable.Rows[i][0];

                // Establecer el valor de la celda correspondiente en el DataGridView
                gridDestajo.Rows[numeroFila].Cells[numeroColumna].Value = valorCelda1;
                numeroColumna++;
            }
        }

        private string findIdParque(string nombre)
        {

            int indice = comboParques.FindStringExact(nombre);

            if (indice != -1) // Si se encontró el valor en el ComboBox
            {
                comboParques.SelectedIndex = indice; // Seleccionar el elemento en el ComboBox
            }
            return comboParques.SelectedValue.ToString();
        }
        private void desableSortDestajo()
        {
            // Recorrer cada columna en el DataGridView y deshabilitar la ordenación
            foreach (DataGridViewColumn columna in gridDestajo.Columns)
            {
                columna.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void enableColumnAsistencia()
        {
            // Primero, deshabilita la edición en todas las columnas
            foreach (DataGridViewColumn columna in gridPiso.Columns)
            {
                columna.ReadOnly = true;
            }

            // Luego, habilita la edición solo en la primera columna
            gridPiso.Columns["Asistencia"].ReadOnly = false;
        }
        private void loadPiso()
        {

            gridPiso.DataSource = empleadosPiso.GetListJustEmployedFloor(dateAsistencia.Value).Tables[0];
        }
        private void loadDestajo()
        {
            dtEmpleadosDestajo = empleados.GetListJustEmployed(dateAsistencia.Value).Tables[0];
            gridDestajo.DataSource = dtEmpleadosDestajo;
            fechaActual = dateAsistencia.Value;
            fillAllDataGrid(dtEmpleadosDestajo, 1);
        }
        private void RetrocederUnDia()
        {
            // Resta un día a la fecha actual
            fechaActual = fechaActual.AddDays(-1);
            // Actualiza el DateTimePicker con la nueva fecha
            dateAsistencia.Value = fechaActual;
        }
        private void AvanzarUnDia()
        {
            // Resta un día a la fecha actual
            fechaActual = fechaActual.AddDays(+1);

            if (fechaActual < DateTime.Now)
            {
                dateAsistencia.Value = fechaActual;
            }
        }



        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            FormEmpleados empleados = new FormEmpleados();
            empleados.FormClosed += empleados_FormClosed; // Suscribir al evento FormClosed
            empleados.Show();
        }
        private void empleados_FormClosed(object sender, FormClosedEventArgs e)
        {
            fillComboEmpleado();

        }
        private void fParque_FormClosed(object sender, FormClosedEventArgs e)
        {
            fillComboParque();
        }
        private void bono_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnGuardarPios_Click(null, null);
            loadPiso();
        }

        private void btnParques_Click(object sender, EventArgs e)
        {
            FormParques fParque = new FormParques();
            fParque.FormClosed += fParque_FormClosed;

            fParque.Show();
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            FormGenerarNominas asistencia = new FormGenerarNominas();
            asistencia.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                    

                fillComboEmpleado();

                fillComboParque();

                comboAsistencia.SelectedIndex = 1;

                fechaActual = DateTime.Now;

                dtEmpleadosDestajo = empleados.GetListJustEmployed(dateAsistencia.Value).Tables[0];

                gridDestajo.DataSource = dtEmpleadosDestajo;

                addColumns();

                fillAllDataGrid(dtEmpleadosDestajo, 0);

                desableSortDestajo();

                loadPiso();

                enableColumnAsistencia();
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
            }
        }

        private void comboAsistencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAsistencia.SelectedIndex == 0)
            {
                gridDestajo.Visible = true;
                gridPiso.Visible = false;
                groupDestajo.Visible = true;
                groupPiso.Visible = false;
            }
            if (comboAsistencia.SelectedIndex == 1)
            {
                gridDestajo.Visible = false;
                gridPiso.Visible = true;
                groupDestajo.Visible = true;
                groupPiso.Visible = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            AvanzarUnDia();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RetrocederUnDia();
        }

        private void dateAsistencia_ValueChanged(object sender, EventArgs e)
        {
            loadDestajo();




            loadPiso();
        }

        private void btnBorrarAsistencia_Click(object sender, EventArgs e)
        {
            empleadosPiso.Deletel(dateAsistencia.Value);
            loadPiso();
        }

        private void btnNadieAsistio_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridPiso.Rows.Count; i++)
            {

                gridPiso.Rows[i].Cells[8].Value = "False";
            }
        }

        private void btnTodosAsistieron_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridPiso.Rows.Count; i++)
            {

                gridPiso.Rows[i].Cells[8].Value = "True";
            }
        }

        private void btnCrearAsistencia_Click(object sender, EventArgs e)
        {
            DataTable employed = empleados.GetListl().Tables[0];

            if (gridPiso.Rows.Count == 0)
            {
                if (employed.Rows.Count > 0)
                {

                    for (int i = 0; i < employed.Rows.Count; i++)
                    {
                        string id_empleado = employed.Rows[i][0].ToString();
                        
                        empleadosPiso.Writel(id_empleado, dateAsistencia.Value, false);
                        //MessageBox.Show(empleadospiso.error);
                    }
                }
            }
            loadPiso();
        }

        private void btnGuardarPios_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridPiso.Rows.Count; i++)
            {

                empleadosPiso.Updatel(gridPiso.Rows[i].Cells[0].Value.ToString(), (bool)gridPiso.Rows[i].Cells[8].Value);
            }

            MessageBox.Show("Se registro la asistencia con exito");
        }

        private void btnAgregarArboles_Click(object sender, EventArgs e)
        {
            var talados = txtArboles.Text.Split(',');

            for (int i = 0; i < talados.Length; i++)
            {
                string valor = talados[i].Trim(); // Eliminar espacios en blanco alrededor del valor

                empleadosDestajo.Writel(comboEmpleado.SelectedValue.ToString(), talados[i], comboParques.SelectedValue.ToString(), dateAsistencia.Value);

            }
            loadDestajo();
            txtArboles.Clear();

            MessageBox.Show(empleadosDestajo.error);
        }

        private void bonoExtraToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int rowIndex = gridPiso.SelectedRows[0].Index;

            // Obtener el valor de la primera celda de la fila seleccionada (por ejemplo, un identificador único)
            string idPiso = gridPiso.Rows[rowIndex].Cells[0].Value.ToString();
            string cantidad = gridPiso.Rows[rowIndex].Cells[6].Value.ToString();
            if (string.IsNullOrEmpty(cantidad)) cantidad = "0";


            FormBono bono = new FormBono();
            bono.id_asistencia = idPiso;
            bono.FormClosed += bono_FormClosed;
            bono.bono_prestamo = "Bono Extra";
            bono.cantidad = cantidad;
            bono.ShowDialog();
        }

        private void bonoRestanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = gridPiso.SelectedRows[0].Index;


            string idPiso = gridPiso.Rows[rowIndex].Cells[0].Value.ToString();

            string cantidad = gridPiso.Rows[rowIndex].Cells[7].Value.ToString();

            if (string.IsNullOrEmpty(cantidad)) cantidad = "0";


            FormBono bono = new FormBono();
            bono.id_asistencia = idPiso;
            bono.FormClosed += bono_FormClosed;
            bono.bono_prestamo = "Prestamo o Faltante";
            bono.cantidad = cantidad;
            bono.ShowDialog();
        }

        private void pagarBonoDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = gridDestajo.SelectedRows[0].Index;

            string idEmpleado = gridPiso.Rows[rowIndex].Cells[1].Value.ToString();
            PagosLogic pago = new PagosLogic();
            pago.Writel(idEmpleado, "Dia", "1000");
            MessageBox.Show(pago.error);
        }

        private void eliminarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = gridDestajo.SelectedRows[0].Index;

            string idEmpleado = dtEmpleadosDestajo.Rows[rowIndex][1].ToString();
            string nombreParque = dtEmpleadosDestajo.Rows[rowIndex][0].ToString();

            if (MessageBox.Show("Seguro de continuar con la operación","Eliminar Destajo",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
            {
                empleadosDestajo.Deletel(dateAsistencia.Value, idEmpleado, findIdParque(nombreParque));
                loadDestajo();
                MessageBox.Show(empleadosDestajo.error);
            }

            
        }
    }
}
