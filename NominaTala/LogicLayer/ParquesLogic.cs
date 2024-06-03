
using System.Data;
using DBLayer;

public class ParquesLogic
{
   public string error;
   ParquesDB parques = new ParquesDB();

    public ParquesLogic()
    {
       error = "";
    }

   public bool Writel(string nombre, string direccion)
    {
        if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(direccion))
        {
            error = "Especifique ambos campos para dar de alta el parque";

            return false;
        }
        
        parques.Nombre = nombre;
        parques.DIRECCION = direccion;
        error = "Se registro el parque con existo";
        return  parques.Write();
    }

   public bool Updatel(string id_parque, string nombre, string direccion)
    {
        if (string.IsNullOrEmpty(id_parque) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(direccion))
        {
            error = "Especifique ambos campos para Modificar el parque";

            return false;
        }


         parques.Id_Parque = int.Parse(id_parque);
         parques.Nombre = nombre;
         parques.DIRECCION = direccion;
         error = "Se realizaron correctamente los cambios para el parque ";
         return parques.Update();
    }

    

    public bool Deletel(string id_parque)
    {

        if (string.IsNullOrEmpty(id_parque))
        {
            error = "Especifique la clave del parque";

            return false;
        }

        
        parques.Id_Parque = int.Parse(id_parque);
        error = "Parque Eliminado Correctamentre";
        return parques.Delete();
    }

    public DataSet GetListl()
    {
        return parques.GetList();
    }
}
