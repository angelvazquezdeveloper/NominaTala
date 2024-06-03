using System;
using System.Windows.Forms;
using TALA.BuildersXls;

namespace NominaTala
{
    public partial class FormGenerarNominas : Form
    {
        public FormGenerarNominas()
        {
            InitializeComponent();
        }

        private void positionWeek2()
        {
            DateTime today = DateTime.Today;

            // Obtener el sábado anterior (restando días hasta llegar al sábado)
            DateTime saturdayPrevious = today.AddDays(-((int)today.DayOfWeek + 1) % 7);

            // Obtener el sábado siguiente (sumando días desde el sábado anterior)
            DateTime saturdayNext = saturdayPrevious.AddDays(7);

            // Asignar los valores al DateTimePicker
            dateInicio.Value = saturdayPrevious;
            dateFin.Value = saturdayNext;

        }



        private void showListDate(string type)
        {
            ReporteSemanal reporte = new ReporteSemanal();
            ConsultasImprimiblesl attendance = new ConsultasImprimiblesl();
            reporte.printListAttendance(attendance.getListForAttendancel(type).Tables[0],
            attendance.getListDatel(dateInicio.Value, dateFin.Value).Tables[0],
            attendance.getListWeekRuldl(dateInicio.Value, dateFin.Value, type).Tables[0], type);
        }

        private void showListNomina(string type)
        {
            ReporteSemanal reporte = new ReporteSemanal();
            ConsultasImprimiblesl razonSocial = new ConsultasImprimiblesl();

            reporte.CreateNominas(type, razonSocial.RazonSocial(type, "DESTAJO").Tables[0], razonSocial.RazonSocial(type, "PISO").Tables[0],
            razonSocial.getListDatel(dateInicio.Value, dateFin.Value.AddDays(-1)).Tables[0], razonSocial.getListDatel(dateInicio.Value.AddDays(+2), dateFin.Value).Tables[0],
            razonSocial.getListWeekRuldl(dateInicio.Value, dateFin.Value, type).Tables[0],
            razonSocial.getTotalTreeByEmployedl(dateInicio.Value, dateFin.Value.AddDays(-1), type).Tables[0]);
        }

        private void FormGenerarNominas_Load(object sender, EventArgs e)
        {
            positionWeek2();
        }

        private void btnRudl_Click(object sender, EventArgs e)
        {
            showListNomina("RUDL");
        }

        private void btnNominaCte_Click(object sender, EventArgs e)
        {
            showListNomina("CTE");
        }

        private void btnCALI_Click(object sender, EventArgs e)
        {
            showListNomina("CALI");
        }

        private void btnListRudl_Click(object sender, EventArgs e)
        {
            showListDate("RUDL");
        }

        private void btnAsistenciaCTE_Click(object sender, EventArgs e)
        {
            showListDate("CTE");
        }

        private void btnAsistenciaCALI_Click(object sender, EventArgs e)
        {
            showListDate("CALI");
        }
    }
}
