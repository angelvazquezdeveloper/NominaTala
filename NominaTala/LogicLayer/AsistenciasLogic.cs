using System;
using System.Data;
using DBLayer;

public class AsistenciasLogic: AsistenciasDB
{
   public string error;
    AsistenciasDB asistencia = new AsistenciasDB();

    public AsistenciasLogic()
    {
       error = "";
    }

   public bool Writel(int id_asistencia, int id_empelado, int arbol, int id_parque)
    {
         
         asistencia.Id_Asistencia = id_asistencia;
         asistencia.Id_Empelado = id_empelado;
         asistencia.Arbol = arbol;
         asistencia.Id_Parque = id_parque;
       return  asistencia.Write();
    }

   public bool Updatel(int id_asistencia, int id_empelado, int arbol, int id_parque)
    {
          
         asistencia.Id_Asistencia = id_asistencia;
         asistencia.Id_Empelado = id_empelado;
         asistencia.Arbol = arbol;
         asistencia.Id_Parque = id_parque;
         return asistencia.Update();
    }

   public bool Deletel(int id_asistencia)
    {
          
          asistencia.Id_Asistencia = id_asistencia;
          return asistencia.Delete();
    }
}
