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
    public partial class FormBono : Form
    {

        public string id_asistencia = "0";
        public string bono_prestamo = "";
        public string cantidad = "0";
        public FormBono()
        {
            InitializeComponent();
        }

        private void FormBono_Load(object sender, EventArgs e)
        {
            groupBono.Text = bono_prestamo;
            textBono.Text = cantidad;
        }

        private void btnBono_Click(object sender, EventArgs e)
        {
            AsistenciaPisoLogic piso = new AsistenciaPisoLogic();

            if (bono_prestamo == "Prestamo o Faltante") piso.UpdateFaltante(id_asistencia, textBono.Text);
            else piso.UpdateBono(id_asistencia, textBono.Text);


            this.Close();
        }
    }
}
