using CADDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADLogicaNegocio
{
   public class Productos
   {
       #region atributos
       public int idproducto { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public int stock { get; set; }
        public string notas { get; set; }
        public int idiva { get; set; }
        public int iddepartamento { get; set; }
       #endregion
       //crear productos----métodos
        public int nuevoProducto(Productos producto)
        {
            ManejoDatos datos = new ManejoDatos();
            string[] parametros = {"@operacion",
                                  "@idproducto",
                                  "@descripcion",
                                  "@precio",
                                  "@stock",
                                  "@notas",
                                  "@idiva",
                                  "@iddepartamento"};
            return datos.Ejecutar("spProductosIA",parametros,"I",
                producto.idproducto,
                producto.descripcion,
                producto.precio,
                producto.stock,
                producto.notas,
                producto.idiva,
                producto.iddepartamento);
        }

       //método actualizar productos
        public int actualizarProducto(Productos producto)
        {
            ManejoDatos datos = new ManejoDatos();
            string[] parametros = {"@operacion",
                                  "@idproducto",
                                  "@descripcion",
                                  "@precio",
                                  "@stock",
                                  "@notas",
                                  "@idiva",
                                  "@iddepartamento"};
            return datos.Ejecutar("spProductosIA", parametros, "A",
                producto.idproducto,
                producto.descripcion,
                producto.precio,
                producto.stock,
                producto.notas,
                producto.idiva,
                producto.iddepartamento);
        }

       //mostrar productos
        public DataTable getProductos()
        {
            ManejoDatos datos = new ManejoDatos();
            string[] parametros = {"@operacion","@idproducto" };
           return datos.getDatosTabla("spProductosSE",parametros,"Y",0);
        
        }
       //eliminar productos

        public int EliminarProducto(string idproducto)
        {
            ManejoDatos datos = new ManejoDatos();
            string[] paramentros = {"@operacion","@idproducto" };
            return
                datos.Ejecutar("spProductosSE", paramentros, "E", idproducto);
        }

       //consultar productos con condición

        public Productos getProducto(Productos produc)
        {
            ManejoDatos datos = new ManejoDatos();
            var dt = new DataTable();
            Productos producto = new Productos();
            string[] parametros = {"@operacion","@idproducto" };
            dt = datos.getDatosTabla("spProductosSE", parametros, "S", produc.idproducto);
            foreach(DataRow fila in dt.Rows){
            producto.idproducto=Convert.ToInt32(fila["IDProducto"].ToString());
            producto.descripcion=fila["Descripcion"].ToString();
            producto.precio = Convert.ToDecimal(fila["Precio"].ToString());
            producto.stock = Convert.ToInt32(fila["Stock"].ToString());
            producto.notas=fila["Notas"].ToString();
            producto.idiva = Convert.ToInt32(fila["IDIVA"].ToString());
            producto.iddepartamento = Convert.ToInt32(fila["IDDepartamento"].ToString());
            
            }
            return producto;
        
        }


   }
}
