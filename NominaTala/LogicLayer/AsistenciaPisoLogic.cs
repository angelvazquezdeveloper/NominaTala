using System;
using System.Data;
using DBLayer;

public class AsistenciaPisoLogic
{
   public string error;
    AsistenciaPisoDB asistencia_piso = new AsistenciaPisoDB();

    public AsistenciaPisoLogic()
    {
       error = "";
    }

   public bool Writel(string id_empleado, DateTime fecha, Boolean asistencia)
    {
                  
         asistencia_piso.Id_Empleado = int.Parse(id_empleado);
         asistencia_piso.Fecha = fecha;
         asistencia_piso.Asistencia = asistencia;         
         return  asistencia_piso.Write();
    }

   public bool Updatel(string id_piso, bool asistencia)
    {
        
         asistencia_piso.Id_Piso = int.Parse(id_piso);         
         asistencia_piso.Asistencia = asistencia;
         return asistencia_piso.Update();
    }
    public bool UpdateBono(string id_piso, string bono)
    {

        if (string.IsNullOrEmpty(bono) || string.IsNullOrEmpty(id_piso))
        {
            error = "Especifique la cantidad del bono";
            return false;
        }
        
        asistencia_piso.Id_Piso = int.Parse(id_piso);
        asistencia_piso.Bono_Extra = int.Parse(bono);
        return asistencia_piso.UpdateBonoExtra();
    }

    public bool UpdateFaltante(string id_piso, string faltante)
    {

        if (string.IsNullOrEmpty(faltante) || string.IsNullOrEmpty(id_piso))
        {
            error = "Especifique la cantidad del bono";
            return false;
        }

        asistencia_piso.Id_Piso = int.Parse(id_piso);
        asistencia_piso.Faltante = int.Parse(faltante);
        return asistencia_piso.UpdateFaltante();
    }

    public bool Deletel(DateTime fecha)
    {            
                    
          asistencia_piso.Fecha = fecha;
          return asistencia_piso.Delete();
    }

    public DataSet GetListJustEmployedFloor(DateTime fecha)
    {
        return asistencia_piso.GetListJustEmployedFloor(fecha);
    }

    
}
