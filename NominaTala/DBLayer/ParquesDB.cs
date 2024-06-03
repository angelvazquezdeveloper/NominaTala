
using System.Data;
using System.Windows.Forms;

namespace DBLayer
{
    public class ParquesDB : BaseDB
    {
        private int id_parque;
        private string nombre;
        private string direccion;

        public ParquesDB()
        {
            id_parque = 0;
            nombre = "";
            direccion = "";
        }

        public ParquesDB(int id_parque, string nombre, string direccion)
        {
            Id_Parque = id_parque;
            Nombre = nombre;
            DIRECCION = direccion;
        }

        public override bool OncreateTable()
        {
            base.createTable = "Create table if not Exists Parque (Id_Parque INTEGER PRIMARY KEY AUTOINCREMENT, Nombre Text, Direccion Text)";
            
            return base.OncreateTable();
        }
        public override bool Write()
        {
            base.sQuery = "INSERT INTO PARQUE (Nombre, DIRECCION) VALUES ('" + nombre + "', '" + direccion + "')";
            return base.Write();
        }


        public override bool Update()
        {
            base.sQuery = "UPDATE PARQUE SET Nombre = '" + nombre + "', DIRECCION = '" + direccion + "' WHERE Id_Parque = " + id_parque;
            return base.Update();
        }


        public override bool Delete()
        {
            base.sQuery = "DELETE FROM PARQUE WHERE Id_Parque = " + id_parque + "";
            return base.Delete();
        }

        public override DataSet GetList()
        {
            base.sQuery = "Select * from Parque";
            return base.GetList();
        }

        public int Id_Parque
        {
            get { return this.id_parque; }
            set { this.id_parque = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string DIRECCION
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }
    }
}
