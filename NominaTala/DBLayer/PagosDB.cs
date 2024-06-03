
namespace DBLayer
{
    public class PagosDB : BaseDB
    {
        private int id_pagos;
        private int id_empleado;
        private string tipo_pago;
        private int pago;

        public PagosDB()
        {
            id_pagos = 0;
            id_empleado = 0;
            tipo_pago = "";
            pago = 0;
        }

        public PagosDB(int id_pagos, int id_empleado, string tipo_pago, int pago)
        {
            Id_Pagos = id_pagos;
            Id_Empleado = id_empleado;
            Tipo_Pago = tipo_pago;
            Pago = pago;
        }

        public override bool OncreateTable()
        {
            base.createTable = "Create table if not Exists Pagos (Id_pago INTEGER PRIMARY KEY AUTOINCREMENT, Id_empleado Int, Tipo_Pago Text, Pago Int)";
            return base.OncreateTable();
        }


        public override bool Write()
        {
            base.sQuery = "INSERT INTO PAGOS (Id_Empleado, Tipo_Pago, Pago) VALUES (" + id_empleado + ", '" + tipo_pago + "', " + pago + ")";
            return base.Write();
        }


        public override bool Update()
        {
            base.sQuery = "UPDATE PAGOS SET Id_Empleado = " + id_empleado + ", Tipo_Pago = '" + tipo_pago + "', Pago = " + pago + " WHERE Id_Pagos = " + id_pagos;
            return base.Update();
        }


        public override bool Delete()
        {
            base.sQuery = "DELETE FROM PAGOS WHERE Id_Pagos = " + id_pagos + "";
            return base.Delete();
        }




        public int Id_Pagos
        {
            get { return this.id_pagos; }
            set { this.id_pagos = value; }
        }
        public int Id_Empleado
        {
            get
            { return this.id_empleado; }
            set { this.id_empleado = value; }
        }
        public string Tipo_Pago
        {
            get { return this.tipo_pago; }
            set { this.tipo_pago = value; }
        }
        public int Pago
        {
            get { return this.pago; }
            set { this.pago = value; }
        }
    }
}
