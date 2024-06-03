using System;
using System.Data;
using System.Windows.Forms;

namespace DBLayer
{

    public class AsistenciaDestajoDB : BaseDB
    {
        private int id_asistencia;
        private int id_empleado;
        private int arbol;
        private int id_parque;
        private DateTime fecha;

        public AsistenciaDestajoDB()
        {
            id_asistencia = 0;
            id_empleado = 0;
            arbol = 0;
            id_parque = 0;
            fecha = DateTime.Today;
        }

        public AsistenciaDestajoDB(int id_asistencia, int id_empleado, int arbol, int id_parque, DateTime fecha)
        {
            Id_Asistencia = id_asistencia;
            Id_Empleado = id_empleado;
            Arbol = arbol;
            Id_Parque = id_parque;
            Fecha = fecha;
        }

        public override bool OncreateTable()
        {
            base.createTable = "Create Table if not Exists Asistencia_Destajo (Id_Asistencia INTEGER PRIMARY KEY AUTOINCREMENT, Id_Empleado Int, Arbol Int, Id_Parque Int, Fecha Text, Pago_Asistencia Int)";
            return base.OncreateTable();
        }

        public override bool Write()
        {
            base.sQuery = "INSERT INTO Asistencia_Destajo (Id_Empleado, Arbol, Id_Parque, Fecha) VALUES (" + id_empleado + "," + arbol + ", " + id_parque + ", '" + fecha.ToString("yyyy-MM-dd") + "')";
            return base.Write();
        }


        public override bool Update()
        {
            base.sQuery = "UPDATE Asistencia_Destajo SET Id_Empleado = " + id_empleado + ", Arbol = " + arbol + ", Id_Parque = " + id_parque + ", Fecha = '" + fecha.ToString("yyyy-MM-dd") + "' WHERE Id_Asistencia = " + id_asistencia;
            return base.Update();
        }


        public override bool Delete()
        {
            base.sQuery = "DELETE FROM Asistencia_Destajo WHERE Id_empleado = " + id_empleado + " and Fecha = '" + fecha.ToString("yyyy-MM-dd") + "' and id_parque = " + id_parque;

            MessageBox.Show(base.sQuery);
            return base.Delete();
        }

        public DataSet getArbolesTaladosPorEmpleado()
        {
            base.sQuery = "Select  Arbol, Parque.Nombre, Fecha " +
                          "From Asistencia_Destajo, Parque " +
                          "where Asistencia_destajo.id_parque = Parque.id_Parque and id_empleado = " + id_empleado + " and fecha = '" + fecha.ToString("yyyy-MM-dd") + "' and Asistencia_destajo.id_parque = " + id_parque;
                          
            
            return base.GetList();

        }


        public int Id_Asistencia
        {
            get { return this.id_asistencia; }
            set { this.id_asistencia = value; }
        }
        public int Id_Empleado
        {
            get { return this.id_empleado; }
            set { this.id_empleado = value; }
        }
        public int Arbol
        {
            get { return this.arbol; }
            set { this.arbol = value; }
        }
        public int Id_Parque
        {
            get { return this.id_parque; }
            set { this.id_parque = value; }
        }
        public DateTime Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }
    }
}
