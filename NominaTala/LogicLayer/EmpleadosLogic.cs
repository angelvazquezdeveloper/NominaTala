using System;
using System.Data;
using TALA.Extras;
using DBLayer;

public class EmpleadosLogic
{
   public string error;
   EmpleadosDB empleados = new EmpleadosDB();

    public EmpleadosLogic()
    {
       error = "";
    }

   public bool Writel(string nombre, string apellidop, string apellidom, string direccion, string telefono, string telefono_emergencia, string pago, string bono, string tipo_empleado, string expecificaciones, string nss, string rfc, string rSocial)    {

        if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellidop) || string.IsNullOrEmpty(apellidom) || string.IsNullOrEmpty(tipo_empleado) || string.IsNullOrEmpty(rSocial))
        {
            error = "Especifique por lo menos el nombre y apellido paterno y tipo de pago";
            
            return false;
        }
        if (!Formats.IsNumeric(pago))
        {
            error = "Especifique la cantidad a pagar para este empleado";
            return false;
        }
        if (!Formats.IsNumeric(bono))
        {
            error = "Especifique la cantidad de el bono a pagar para este empleado";
            return false;
        }


         empleados.NOMBRE = nombre;
         empleados.APELLIDOP = apellidop;
         empleados.APELLIDOM = apellidom;
         empleados.DIRECCION = direccion;
         empleados.TELEFONO = telefono;
         empleados.TELEFONO_EMERGENCIA = telefono_emergencia;
         empleados.PAGO = int.Parse(pago);
         empleados.BONO = int.Parse(bono);
         empleados.TIPO_EMPLEADO = tipo_empleado;
         empleados.EXPECIFICACIONES = expecificaciones;
         empleados.NSS = nss;
         empleados.RFC = rfc;
         empleados.RAZONSOCIAL = rSocial;
         error = "Empleado registrado correctamente ";
         return  empleados.Write();
    }

   public bool Updatel(string id_empleado, string nombre, string apellidop, string apellidom, string direccion, string telefono, string telefono_emergencia, string pago, string bono, string tipo_empleado, string expecificaciones, string nss, string rfc, string rSocial)
    {
        if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellidop) || string.IsNullOrEmpty(apellidom) || string.IsNullOrEmpty(tipo_empleado) || string.IsNullOrEmpty(id_empleado) || string.IsNullOrEmpty(rSocial))
        {
            error = "Especifique por lo menos el nombre y apellido paterno y tipo empleado y Razon Social";

            return false;
        }
        if (!Formats.IsNumeric(pago))
        {
            error = "Especifique la cantidad a pagar para este empleado";
            return false;
        }
        if (!Formats.IsNumeric(bono))
        {
            error = "Especifique la cantidad de el bono a pagar para este empleado";
            return false;
        }
        if (!Formats.IsNumeric(id_empleado))
        {
            error = "Especifique el id del empleado";
            return false;
        }

         empleados.Id_Empleado = int.Parse(id_empleado);
         empleados.NOMBRE = nombre;
         empleados.APELLIDOP = apellidop;
         empleados.APELLIDOM = apellidom;
         empleados.DIRECCION = direccion;
         empleados.TELEFONO = telefono;
         empleados.TELEFONO_EMERGENCIA = telefono_emergencia;
         empleados.PAGO = int.Parse(pago);
         empleados.BONO = int.Parse(bono);
         empleados.TIPO_EMPLEADO = tipo_empleado;
         empleados.EXPECIFICACIONES = expecificaciones;
         empleados.NSS = nss;
         empleados.RFC = rfc;
         empleados.RAZONSOCIAL = rSocial;   
         error = "Se actualizaron correctamente los datos del empleado";
         return empleados.Update();
    }

   public bool Deletel(string id_empleado)
    {
        if (!Formats.IsNumeric(id_empleado))
        {
            error = "Especifique el Id del empleado";
            return false;
        }

        empleados.Id_Empleado = int.Parse(id_empleado);
        return empleados.Delete();
    }

    public DataSet GetListl()
    {
        
        return empleados.GetList();
    }
    public DataSet GetListlDestajo()
    {

        return empleados.GetListDestajo();
    }

    public DataSet GetListJustEmployed(DateTime fecha)
    {

        return empleados.GetListJustEmployed(fecha);
    }

    



}
