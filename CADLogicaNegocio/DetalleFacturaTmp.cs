using CADDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADLogicaNegocio
{
   public class DetalleFacturaTmp
   {
       #region atributos
       public int idlinea { get; set; }
        public int idproducto { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }
       #endregion
       //mostrar datos detalles facturas 
        public DataTable listadoDetalleFactutasTmp()
        {
            ManejoDatos datos = new ManejoDatos();
            string[] parametros = { "@operacion","@idlinea"};
            return datos.getDatosTabla("spDetalleFacturaSE",
                parametros,"Y",0);

        }
       //método para elliminar un registro

        public int EliminarDetalleFacturaTmp(int idlinea)
        {
            ManejoDatos datos = new ManejoDatos();
            string[] parametros = {"@operacion","@idlinea" };
            return datos.Ejecutar("spDetalleFacturaSE",
                parametros,"E",idlinea);

        }
       //método para consultar un detallefacturatmp
        public DetalleFacturaTmp getdetalleFacturaTmp(DetalleFacturaTmp dfTmp)
        {
            string[] parametro = { "@operacion","@idlinea"};
            ManejoDatos datos = new ManejoDatos();
            DetalleFacturaTmp detFactTmp = new DetalleFacturaTmp();
            var dt = new DataTable();
            dt = datos.getDatosTabla("spDetalleFacturaSE",parametro,"S",
                 dfTmp.idlinea);
            foreach (DataRow fila in dt.Rows)
            {
                dfTmp.idlinea = Convert.ToInt32(fila["IDLinea"].ToString());
                dfTmp.idproducto = Convert.ToInt32(fila["IDProducto"].ToString());
                dfTmp.descripcion=fila["Descripcion"].ToString();
                dfTmp.precio = Convert.ToDecimal(fila["Precio"].ToString());
                dfTmp.cantidad = Convert.ToInt32(fila["Cantidad"].ToString());
            }
            return detFactTmp;

        
        }
       //método para crear un nuevo detalle factura
        public int NuevoDetalleFactura(DetalleFacturaTmp factura)
        {
            ManejoDatos datos = new ManejoDatos();
            string[] parametros = {"@operacion",
                                  "@idlinea",
                                  "@idproducto",
                                  "@descripcion",
                                  "@precion",
                                  "@cantidad"};
            return datos.Ejecutar("spDetalleFacturaIA",
                parametros,
                "I",
                factura.idlinea,
                factura.idproducto,
                factura.descripcion,
                factura.precio,
                factura.cantidad);

        
        } 

       //método para actualizar un detalle fatura temp
        public int ActualizarDetalleFactura(DetalleFacturaTmp factura)
        {
            ManejoDatos datos = new ManejoDatos();
            string[] parametros = {"@operacion",
                                  "@idlinea",
                                  "@idproducto",
                                  "@descripcion",
                                  "@precion",
                                  "@cantidad"};
            return datos.Ejecutar("spDetalleFacturaIA",
                parametros,
                "A",
                factura.idlinea,
                factura.idproducto,
                factura.descripcion,
                factura.precio,
                factura.cantidad);


        } 

   }
}
