using CADDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADLogicaNegocio
{
   public class Factura
    {
        public int idfactura { get; set; }
        public int idcliente { get; set; }
        public DateTime fecha { get; set; }
       //listado facturas
        public DataTable listadoFacturas()
        {
            ManejoDatos datos = new ManejoDatos();
            string[] paramentros = {"@operacion","@idfactura" };
            return datos.getDatosTabla("spFacturaSE",paramentros,"Y",0);
        
        }
       //método consultar factura
        public Factura getFactura(Factura fact)
        {
            string[] parametros = {"@operacion","@idfactura" };
            var dt = new DataTable();
            ManejoDatos datos = new ManejoDatos();
            Factura factura = new Factura();
            dt = datos.getDatosTabla("spFacturaSE",
                            parametros,"S",fact.idcliente);
        foreach(DataRow fila in dt.Rows){
        factura.idfactura=Convert.ToInt32(fila["IDFactura"].ToString());
        factura.idcliente = Convert.ToInt32(fila["IDCliente"].ToString());
        factura.fecha=Convert.ToDateTime(fila["Fecha"].ToString());
        
        }
        return factura;
        }

       //método par eliminar una factura
        public int EliminarFactura(int idFactura)
        {
            ManejoDatos datos = new ManejoDatos();
            string[] parametros = {"@operacion",
                                      "@idfactura" };
            return datos.Ejecutar("spFacturaSE",
                parametros,"E",idFactura);
        
        }
       //método para crear una nueva factura
        public int NuevaFactura(Factura factura)
        {
            ManejoDatos datos = new ManejoDatos();
            string[] parametros = {"@operacion",   
                                     "@idfactura",                                 
                                     "@idcliente",
                                     "@fecha" };
            return datos.Ejecutar("spFacturaIA",
                parametros,"I",
                factura.idcliente,
                factura.fecha);

        }
       //método para actualizar una factura
        public int ActualizarFactura(Factura factura)
        {
            ManejoDatos datos = new ManejoDatos();
            string[] parametros = {"@operacion",
                                      "@idfactura",
                                      "@idfactura",
                                      "@idcliente",
                                      "@fecha" };
            return datos.Ejecutar("spFacturaIA",
                parametros, "A",
                factura.idcliente,
                factura.fecha);

        }
   }
}
