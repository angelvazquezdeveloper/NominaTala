using DBLayer;
using TALA.Extras;

public class PagosLogic
{
    public string error;
    PagosDB pagos = new PagosDB();

    public PagosLogic()
    {
       error = "";
    }

   public bool Writel(string id_empleado, string tipo_pago, string pago)
    {
        
        if (string.IsNullOrEmpty(tipo_pago) || string.IsNullOrEmpty(pago))
        {
            error = "Especifique el tipo de pago y tipo de empleado";
            tipo_pago = "PISO";

            return false;
        }
        if (!Formats.IsNumeric(pago))
        {
            error = "Especifique el pago del empleado";
            pago = "0";
            return false;
        }

        
         pagos.Id_Empleado = int.Parse(id_empleado);
         pagos.Tipo_Pago = tipo_pago;
         pagos.Pago = int.Parse(pago);
         error = "Se registro correctamenete la forma de pago para el empleado";
         return  pagos.Write();
    }

   public bool Updatel(int id_pagos, int id_empleado, string tipo_pago, int pago)
    {
          
         pagos.Id_Pagos = id_pagos;
         pagos.Id_Empleado = id_empleado;
         pagos.Tipo_Pago = tipo_pago;
         pagos.Pago = pago;
         return pagos.Update();
    }

   public bool Deletel(int id_pagos)
    {
          
          pagos.Id_Pagos = id_pagos;
          return pagos.Delete();
    }
}
