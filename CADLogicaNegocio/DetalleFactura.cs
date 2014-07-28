using CADDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADLogicaNegocio
{
    public class DetalleFactura
    {
        #region atributos
        public int idfactura { get; set; }
        public int idlinea { get; set; }
        public int idproducto { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }
        #endregion
        //listado detalle facturas
        public DataTable listasdoDetalleFactura()
        {
            ManejoDatos datos = new ManejoDatos();
            string[] paramentro = { "@operacion", "@idlinea" };
            return datos.getDatosTabla("spDetalleFacturaSE",
                paramentro, "Y", 0);
        }
        //método eliminar
        public int EliminarDetalleFactura(int idlinea)
        {
            ManejoDatos datos = new ManejoDatos();
            string[] parametros = { "@operacion", "@idlinea" };
            return datos.Ejecutar("spDetalleFacturaSE",
                parametros, "E", idlinea);
        }
        //método consultar detalles facturas
        public DetalleFactura getDetalleFactura(DetalleFactura dfactura)
        {
            string[] parametros = { "@operacion","@idlinea"};
            var dt = new DataTable();
            DetalleFactura detallefactura = new DetalleFactura();
            ManejoDatos datos = new ManejoDatos();
            dt = datos.getDatosTabla("spDetalleFacturaSE",parametros,"S",
                dfactura.idlinea);
            foreach (DataRow fila in dt.Rows)
            { 
            detallefactura.idfactura=Convert.ToInt32(fila["IDFactura"].ToString());
            detallefactura.idlinea = Convert.ToInt32(fila["IDLinea"].ToString());
            detallefactura.idproducto = Convert.ToInt32(fila["IDProducto"].ToString());
            detallefactura.descripcion  =fila["Descripcion"].ToString();
            detallefactura.precio = Convert.ToDecimal(fila["Precio"].ToString());
            detallefactura.cantidad = Convert.ToInt32(fila["Cantidad"].ToString());
            }
            return detallefactura;
        }

        //método para crear nueva factura
        public int NuevoDetalleFactura(DetalleFactura factura)
        {
            ManejoDatos datos = new ManejoDatos();
            string[] parametros ={"@operacion",
                                     "@idfactura",
                                     "@idlinea",
                                     "@idproducto",
                                     "@descripcion",
                                     "@precio",
                                     "@cantidad"};
            return datos.Ejecutar("spDetalleFacturaIA"
                , parametros, "I",
                factura.idfactura,
                factura.idlinea,
                factura.idproducto,
                factura.descripcion,
                factura.precio,
                factura.cantidad);

        }

        //método para actualizar un detalle factura
        public int ActualizarDetalleFactura(DetalleFactura factura)
        {
            ManejoDatos datos = new ManejoDatos();
            string[] parametros ={"@operacion",
                                     "@idfactura",
                                     "@idlinea",
                                     "@idproducto",
                                      "@descripcion",
                                     "@precio",
                                 "@cantidad"};
            return datos.Ejecutar("spDetalleFacturaIA"
                , parametros, "A",
                factura.idfactura,
                factura.idlinea,
                factura.idproducto,
                factura.descripcion,
                factura.precio,
                factura.cantidad);

        }
    }
}
