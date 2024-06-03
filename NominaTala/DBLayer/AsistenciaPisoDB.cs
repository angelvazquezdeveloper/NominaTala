
using System;
using System.Data;
using System.Windows.Forms;

namespace DBLayer
{
    public class AsistenciaPisoDB : BaseDB
    {
        private int id_piso;
        private int id_empleado;
        private DateTime fecha;
        private bool asistencia;
        private int bonoextra;
        private int faltante;

        public AsistenciaPisoDB()
        {
            id_piso = 0;
            id_empleado = 0;
            fecha = DateTime.Today;
            asistencia = false;
            bonoextra = 0;
            faltante = 0;
        }

        public AsistenciaPisoDB(int id_piso, int id_empleado, DateTime fecha, bool asistencia, int bonoextra)
        {
            Id_Piso = id_piso;
            Id_Empleado = id_empleado;
            Fecha = fecha;
            Asistencia = asistencia;

        }
        public override bool OncreateTable()
        {
            base.createTable = "Create Table if not Exists Asistencia_Piso (Id_Piso INTEGER PRIMARY KEY AUTOINCREMENT, Id_Empleado Int, Fecha Text, Asistencia Boolean, Bono_Extra Int, Prestamo_Faltante Int)";
            
            return base.OncreateTable();
        }

        public override bool Write()
        {
            base.sQuery = "INSERT INTO Asistencia_Piso (Id_Empleado, Fecha, Asistencia) VALUES (" + id_empleado + ", '" + fecha.ToString("yyyy-MM-dd") + "', " + asistencia + ")";
            
            return base.Write();
        }


        public override bool Update()
        {
            base.sQuery = "UPDATE ASISTENCIA_PISO set Asistencia = " + asistencia + " WHERE Id_Piso = " + id_piso;
            return base.Update();
        }

        public bool UpdateBonoExtra()
        {
            base.sQuery = "UPDATE ASISTENCIA_PISO set BONO_EXTRA = " + bonoextra + " WHERE Id_Piso = " + id_piso;
            return base.Update();
        }

        public bool UpdateFaltante()
        {
            base.sQuery = "UPDATE ASISTENCIA_PISO set PRESTAMO_FALTANTE = " + faltante + " WHERE Id_Piso = " + id_piso;
            return base.Update();
        }


        public override bool Delete()
        {
            base.sQuery = "DELETE FROM Asistencia_Piso WHERE Fecha = '" + fecha.ToString("yyyy-MM-dd") + "'";
            return base.Delete();
        }

        public DataSet GetListJustEmployedFloor(DateTime fecha_Asistencia)
        {
            
            base.sQuery = "SELECT  Distinct(id_Piso)as id_Asistencia, id as Id_Empleado, Empleados.Nombre, Empleados.Apellidop, Empleados.Apellidom, Empleados.Tipo_Empleado, BONO_EXTRA, PRESTAMO_FALTANTE, Asistencia " +
                          "FROM Empleados, Asistencia_Piso " +
                          "WHERE Empleados.Id = Asistencia_piso.Id_Empleado and Fecha = '" + fecha_Asistencia.ToString("yyyy-MM-dd") + "' " +
                          "order By apellidop, apellidom, Nombre";

            return base.GetList();
        }

        public DataSet GetEmpleadosFecha()
        {
            base.sQuery = "Select * from Asistencia_piso where Fecha = '" + fecha.ToString("yyyy-MM-dd") + "'";
            return base.GetList();
        }

        public int Id_Piso
        {
            get { return this.id_piso; }
            set { this.id_piso = value; }
        }
        public int Id_Empleado
        {
            get { return this.id_empleado; }
            set { this.id_empleado = value; }
        }
        public DateTime Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }
        public bool Asistencia
        {
            get { return this.asistencia; }
            set { this.asistencia = value; }
        }

        public int Bono_Extra
        {
            get { return this.bonoextra; }
            set { this.bonoextra = value; }
        }
        public int Faltante
        {
            get { return this.faltante; }
            set { this.faltante = value; }
        }
    }
}
