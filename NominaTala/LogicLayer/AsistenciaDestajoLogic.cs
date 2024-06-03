using System;
using System.Data;
using TALA.Extras;
using DBLayer;

public class AsistenciaDestajoLogic
{
   public string error;
   AsistenciaDestajoDB asistencia_destajo = new AsistenciaDestajoDB();
   

    public AsistenciaDestajoLogic()
    {
       error = "";
    }

   public bool Writel(string id_empleado, string arbol, string id_parque, DateTime fecha)
    {

        if (string.IsNullOrEmpty(id_empleado) || string.IsNullOrEmpty(arbol) || string.IsNullOrEmpty(id_parque) || string.IsNullOrEmpty(fecha.ToString()))
        {
            error = "Especifique todos los datos para ingresar los arboles talados por el empleado seleccionado";

            return false;
        }
        if (!Formats.IsNumeric(id_empleado))
        {
            error = "Especifique la clave del empleado";
            return false;
        }
        if (!Formats.IsNumeric(arbol))
        {
            error = "Especifique la clave del arbol talado";
            return false;
        }

        
         asistencia_destajo.Id_Empleado = int.Parse(id_empleado);
         asistencia_destajo.Arbol = int.Parse(arbol);
         asistencia_destajo.Id_Parque = int.Parse(id_parque);
         asistencia_destajo.Fecha = fecha;
         error = "Se registro correctamente la tala del arbol " +arbol;
         return  asistencia_destajo.Write();
    }

   public bool Updatel(string id_asistencia, string id_empleado, string arbol, string id_parque, DateTime fecha)
    {
         
         asistencia_destajo.Id_Asistencia = int.Parse(id_asistencia);
         asistencia_destajo.Id_Empleado = int.Parse(id_empleado);
         asistencia_destajo.Arbol = int.Parse(arbol);
         asistencia_destajo.Id_Parque = int.Parse(id_parque);
         asistencia_destajo.Fecha = fecha;
         return asistencia_destajo.Update();
    }

   public bool Deletel(DateTime date, string idEmpleado, string idParque)
    {
        bool done = false;
        if (string.IsNullOrEmpty(idEmpleado))
        {
            error = "Especifique el id del empleado";
            return false;
        }
        if (string.IsNullOrEmpty(idParque))
        {
            error = "Especifique el id del parque";
            return false;
        }

        asistencia_destajo.Id_Empleado = int.Parse(idEmpleado);
        asistencia_destajo.Fecha = date;
        asistencia_destajo.Id_Parque = int.Parse(idParque);
        if (asistencia_destajo.Delete())
        {
            error = "Se elimino correctamente el registro de destajo";
            done = true;
        }
        else
        {
            error = "No elimino el registro de destajo";
            done = false;
        }

        return done;
    }

    public DataSet getTalaofEmployes(string id_empleado, DateTime fecha, string id_Parque)
    {

        asistencia_destajo.Id_Parque = int.Parse(id_Parque);
        asistencia_destajo.Id_Empleado = int.Parse(id_empleado);
        asistencia_destajo.Fecha = fecha;
        return asistencia_destajo.getArbolesTaladosPorEmpleado();
    }


}
