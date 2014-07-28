using CADDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADLogicaNegocio
{
   public class Iva
   {
       #region atributos
       public int idiva { get; set; }
       public string descripcion { get; set; }
       public decimal tarifa { get; set; }
       #endregion
       //listado iva
       public DataTable listIva()
       {
           ManejoDatos datos = new ManejoDatos();
           string[] parametros = {"@operacion","@idiva" };
           return datos.getDatosTabla("spIvasSE",parametros,"Y",0);

       }
       //método consultar iva
       public Iva getIva(Iva iva)
       {
           string[] parametro = { "@operacion","@idiva"};
           ManejoDatos datos = new ManejoDatos();
           Iva i = new Iva();
           var dt = new DataTable();
           dt = datos.getDatosTabla("spIvasSE",parametro,"S",iva.idiva);
           foreach (DataRow fila in dt.Rows)
           {
               i.idiva = Convert.ToInt32(fila["IDIVA"].ToString());
               i.descripcion=fila["Descripcion"].ToString();
               i.tarifa = Convert.ToDecimal(fila["Tarifa"].ToString());
           }
           return i;
       }

       //método para crear un iva
       public int nevoIva(Iva iva)
       {
           ManejoDatos datos = new ManejoDatos();
           string[] parametros = { "@operacion","idiva","@descripcion","@tafifa"};
           return datos.Ejecutar("spIvasIA",parametros,"I",iva.descripcion,iva.tarifa);
       
       }

       //actualizar iva
       public int ActualizarIva(Iva iva)
       {
           ManejoDatos datos = new ManejoDatos();
           string[] parametros = {"@operacion","@idiva","@descripcion","@tarifa" };
           return datos.Ejecutar("spIvasSA",parametros,"A",
               iva.idiva,
               iva.descripcion,
               iva.tarifa); 
             
       }

       //eliminar iva
       public int EliminarIva(int idiva) {
           ManejoDatos datos = new ManejoDatos();
           string[] parametros = {"@operacion","@idiva" };
           return datos.Ejecutar("spIvasSE",parametros,"E",idiva);
       }
    }
}
