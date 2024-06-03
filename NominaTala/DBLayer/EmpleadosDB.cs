using System.Data;

using System;
using System.Windows.Forms;

namespace DBLayer
{
    public class EmpleadosDB : BaseDB
    {
        private int id_empleado;
        private string nombre;
        private string apellidop;
        private string apellidom;
        private string direccion;
        private string telefono;
        private string telefono_emergencia;
        private int pago;
        private int bono;
        private string tipo_empleado;
        private string expecificaciones;
        private string nss;
        private string rfc;
        private string rSocial;


        public EmpleadosDB()
        {
            id_empleado = 0;
            nombre = "";
            apellidop = "";
            apellidom = "";
            direccion = "";
            telefono = "";
            telefono_emergencia = "";
            pago = 0;
            bono = 0;
            tipo_empleado = "PISO";
            expecificaciones = "";
            nss = "";
            rfc = "";
            rSocial = "";
        }

        public EmpleadosDB(int id_empleado, string nombre, string apellidop, string apellidom, string direccion, string telefono, string telefono_emergencia, int pago, int bono, string fecha_nacimiento, string expecificaciones, string nss, string rfc, string rsocial)
        {
            Id_Empleado = id_empleado;
            NOMBRE = nombre;
            APELLIDOP = apellidop;
            APELLIDOM = apellidom;
            DIRECCION = direccion;
            TELEFONO = telefono;
            TELEFONO_EMERGENCIA = telefono_emergencia;
            PAGO = pago;
            BONO = bono;
            TIPO_EMPLEADO = fecha_nacimiento;
            EXPECIFICACIONES = expecificaciones;
            NSS = nss;
            RFC = rfc;
            rSocial = rsocial;
        }

        public override bool OncreateTable()
        {
            base.createTable = "Create Table if not Exists Empleados (Id  INTEGER PRIMARY KEY AUTOINCREMENT, Nombre Text, Apellidop Text, Apellidom Text, Direccion Text, Telefono Text, Telefono_Emergencia Text, Pago Int, Tipo_Empleado Text, Expecificaciones TExt, Nss TExt, RFC Text, Bono Int, Razon_Social Text)";
            
            return base.OncreateTable();
        }

        public override bool Write()
        {
            base.sQuery = "INSERT INTO EMPLEADOS (NOMBRE, APELLIDOP, APELLIDOM, DIRECCION, TELEFONO, TELEFONO_EMERGENCIA, PAGO, BONO, TIPO_EMPLEADO, EXPECIFICACIONES, NSS, RFC, RAZON_SOCIAL) VALUES ('" + nombre + "', '" + apellidop + "', '" + apellidom + "', '" + direccion + "', '" + telefono + "', '" + telefono_emergencia + "', " + pago + ", " + bono + ", '" + tipo_empleado + "', '" + expecificaciones + "', '" + nss + "', '" + rfc + "', '" + rSocial + "')";
            
            return base.Write();
        }


        public override bool Update()
        {
            base.sQuery = "UPDATE EMPLEADOS SET NOMBRE = '" + nombre + "', APELLIDOP = '" + apellidop + "', APELLIDOM = '" + apellidom + "', DIRECCION = '" + direccion + "', TELEFONO = '" + telefono + "', TELEFONO_EMERGENCIA = '" + telefono_emergencia + "', PAGO = " + pago + ", BONO = " + bono + ", TIPO_EMPLEADO = '" + tipo_empleado + "', EXPECIFICACIONES = '" + expecificaciones + "', NSS = '" + nss + "', RFC = '" + rfc + "', RAZON_SOCIAL = '" + rSocial + "' WHERE Id = " + id_empleado;
            return base.Update();
        }


        public override bool Delete()
        {
            base.sQuery = "DELETE FROM EMPLEADOS WHERE Id = " + id_empleado + "";
            return base.Delete();
        }

        public DataSet GetListDestajo()
        {
            base.sQuery = "Select Id, Nombre, Apellidop, Apellidom, Pago, Bono, Tipo_Empleado, Nss, Direccion, Telefono, Telefono_Emergencia From EMPLEADOS where TIPO_EMPLEADO = 'DESTAJO'";
            return base.GetList();
        }
        public override DataSet GetList()
        {
            base.sQuery = "Select Id, Nombre, Apellidop, Apellidom, Pago, Bono, Tipo_Empleado, Nss, Direccion, Telefono, Telefono_Emergencia, Razon_Social From EMPLEADOS " +
                          "order by apellidop, apellidom, Nombre";
            return base.GetList();
        }


        public DataSet GetListJustEmployed(DateTime fecha_Asistencia)
        {
            //base.sQuery = "Select Id, Nombre, Apellidop, Apellidom, Tipo_Empleado from EMPLEADOS where Tipo_Empleado = 'DESTAJO'";

            base.sQuery = "SELECT DISTINCT (Parque.Nombre), Id, Empleados.Nombre, Apellidop, Apellidom, Tipo_Empleado " +
                          "From Asistencia_Destajo, Empleados, Parque " +
                          "where Empleados.id = Asistencia_Destajo.id_empleado and Fecha = '" + fecha_Asistencia.ToString("yyyy-MM-dd") + "' and Asistencia_Destajo.id_parque = Parque.id_parque " +
                          "order By Apellidop, apellidom, Empleados.Nombre ";



            return base.GetList();
        }




        public int Id_Empleado
        {
            get { return this.id_empleado; }
            set { this.id_empleado = value; }
        }
        public string NOMBRE
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string APELLIDOP
        {
            get { return this.apellidop; }
            set { this.apellidop = value; }
        }
        public string APELLIDOM
        {
            get { return this.apellidom; }
            set { this.apellidom = value; }
        }
        public string DIRECCION
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }
        public string TELEFONO
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }
        public string TELEFONO_EMERGENCIA
        {
            get { return this.telefono_emergencia; }
            set { this.telefono_emergencia = value; }
        }
        public int PAGO
        {
            get { return this.pago; }
            set { this.pago = value; }
        }
        public int BONO
        {
            get { return this.bono; }
            set { this.bono = value; }
        }
        public string TIPO_EMPLEADO
        {
            get { return this.tipo_empleado; }
            set { this.tipo_empleado = value; }
        }
        public string EXPECIFICACIONES
        {
            get { return this.expecificaciones; }
            set { this.expecificaciones = value; }
        }
        public string NSS
        {
            get { return this.nss; }
            set { this.nss = value; }
        }
        public string RFC
        {
            get { return this.rfc; }
            set { this.rfc = value; }
        }
        public string RAZONSOCIAL
        {
            get { return this.rSocial; }
            set { this.rSocial = value; }
        }
    }
}
