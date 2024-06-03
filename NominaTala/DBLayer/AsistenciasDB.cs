
namespace DBLayer
{
    public class AsistenciasDB : BaseDB
    {
        private int id_asistencia;
        private int id_empelado;
        private int arbol;
        private int id_parque;

        public AsistenciasDB()
        {
            id_asistencia = 0;
            id_empelado = 0;
            arbol = 0;
            id_parque = 0;
        }

        public AsistenciasDB(int id_asistencia, int id_empelado, int arbol, int id_parque)
        {
            Id_Asistencia = id_asistencia;
            Id_Empelado = id_empelado;
            Arbol = arbol;
            Id_Parque = id_parque;
        }

        public override bool OncreateTable()
        {
            base.createTable = "Create Table if not Exists Empleados (Id INTEGER PRIMARY KEY AUTOINCREMENT, Id_Empleado Int, Arbol Int, Id_Parque Int, Fecha Text, Pago_Asistencia Int)";
            return base.OncreateTable();
        }

        public override bool Write()
        {
            base.sQuery = "INSERT INTO Materia (Id_Asistencia, Id_Empelado, Arbol, Id_Parque) VALUES (" + id_asistencia + ", " + id_empelado + ", " + arbol + ", " + id_parque + ")";
            return base.Write();
        }


        public override bool Update()
        {
            base.sQuery = "UPDATE Materia SET Id_Empelado = " + id_empelado + ", Arbol = " + arbol + ", Id_Parque = " + id_parque + " WHERE Id_Asistencia = " + id_asistencia;
            return base.Update();
        }


        public override bool Delete()
        {
            base.sQuery = "DELETE FROM Materia WHERE Id_Asistencia = " + id_asistencia + "";
            return base.Delete();
        }

        public int Id_Asistencia
        {
            get { return this.id_asistencia; }
            set { this.id_asistencia = value; }
        }
        public int Id_Empelado
        {
            get { return this.id_empelado; }
            set { this.id_empelado = value; }
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
    }
}
