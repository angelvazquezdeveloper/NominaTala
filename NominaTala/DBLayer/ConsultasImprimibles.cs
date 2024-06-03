using System;
using System.Data;
using System.Windows.Forms;

namespace DBLayer
{
    class ConsultasImprimibles:BaseDB
    {
        public DataSet RazonSocial(string type, string typeEmployed)
        {
            base.sQuery = "SELECT id, Tipo_Empleado, Nombre || ' ' || Apellidop || ' ' || Apellidom AS Nombre_Completo, Pago, Bono " +
                          "FROM Empleados "+
                          "where RAZON_SOCIAL = '"+type+"' and TIpo_Empleado = '"+typeEmployed+"' " +
                          "order by id";            
            return base.GetList();
        }

        public DataSet GetListForAttendance(string type)
        {
            base.sQuery = "SELECT id, Nombre || ' ' || Apellidop || ' ' || Apellidom AS Nombre_Completo " +
                          "FROM Empleados " +
                          "where RAZON_SOCIAL = '"+type+"' " +
                          "order by id";
            return base.GetList();
        }

        public DataSet getListWeekRuld(DateTime begin, DateTime end, string type)
        {
            base.sQuery = "SELECT id, Asistencia, fecha " +
                          "from Asistencia_Piso, Empleados " +
                          "where id = Asistencia_Piso.id_empleado and Fecha between '"+begin.ToString("yyyy-MM-dd") + "'  and '" + end.ToString("yyyy-MM-dd") + "' and Razon_Social = '"+type+"' " +
                          "order by fecha, id";
            return base.GetList();
        }

        public DataSet getListEmployes(string type)
        {
            base.sQuery = "SELECT id, Nombre, Apellidop, Apellidom "+
                          "From Empleados " +
                          "where Razon_Social = '" + type + "' and TIpo_Empleado = 'Destajo' " +
                          "order by Id";
            return base.GetList();

        }

        public DataSet getListDate(DateTime begin, DateTime end)
        {
            base.sQuery = "SELECT Distinct fecha " +
                          "from Asistencia_piso " +
                          "where Fecha between '" + begin.ToString("yyyy-MM-dd") + "'  and '" + end.ToString("yyyy-MM-dd") + "'" +
                          "Order by Fecha ";
            
            return base.GetList();
        }

        public DataSet getTotalTreeByEmployed(DateTime begin, DateTime end, string type)
        {
            base.sQuery = "SELECT Count (Arbol) as Total, Id " +
                          "from Empleados, Asistencia_Destajo " +
                          "where Empleados.Id = Asistencia_destajo.id_empleado and fecha between  '" + begin.ToString("yyyy-MM-dd") + "'  and '" + end.ToString("yyyy-MM-dd") + "' and  RAZON_SOCIAL = '"+type+"' " +
                          "Group by Id, Nombre "+
                          "order by Id";
            Clipboard.SetText(base.sQuery);
            return base.GetList();
        }

    }

}
