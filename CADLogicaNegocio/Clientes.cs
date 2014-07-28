using CADDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADLogicaNegocio
{
   public class Clientes
    {
        public string idcliente { get; set; }
        public string nombre { get; set; }
        public string  apellido { get; set; }
        public string direccion { get; set; }
        public string  telefono { get; set; }
        public string  correo { get; set; }
        public string  fechanacimiento { get; set; }
        public int cupo { get; set; }


       //método para crear un nuevo cliente

        public int nuevoCliente(Clientes cliente) {
            ManejoDatos datos = new ManejoDatos();
            string[] parametros = {"@operacion",
                                      "@idcliente",
                                      "@nombre",
                                      "@apellido",
                                      "@direccion",
                                      "@telefono",
                                      "@correo",
                                      "@fechanacimiento",
                                      "@cupo"};
           return datos.Ejecutar("spClienteIA", parametros, "I",
                cliente.idcliente,
                cliente.nombre,
                cliente.apellido,
                cliente.direccion,
                cliente.telefono,
                cliente.correo,
                cliente.fechanacimiento,
                cliente.cupo);
        
        }
       //actualizar cliente
        public int ActualizarCliente(Clientes cliente) {
            ManejoDatos datos = new ManejoDatos();
            string[] parametro = {"@operacion",
                                     "@idcliente",
                                     "@nombre",
                                     "@apellido",
                                     "@direccion",
                                     "@telefono",
                                     "@correo",
                                     "@fechanacimiento",
                                     "@cupo" };
          return  datos.Ejecutar("spClienteIA",parametro,"A",
                cliente.idcliente,
                cliente.nombre,
                cliente.apellido,
                cliente.direccion,
                cliente.telefono,
                cliente.correo,
                cliente.fechanacimiento,
                cliente.cupo);
        }

       //mostrar clientes
        public DataTable getClientes()
        {
            ManejoDatos datos = new ManejoDatos();
            string[] parametros = {"@operacion","idcliente"};
            return datos.getDatosTabla("spClienteSE", parametros, "Y", 0);
        }

       //eliminar
       public int Eliminar(string idcliente)
        {
            ManejoDatos datos = new ManejoDatos();
            string[] parametros = { "@operacion","@idcliente"};
            return datos.Ejecutar("spClienteSE", parametros, "E", idcliente);

        }
       //método consultar cliente
       public Clientes getCliente(Clientes cliente)
       {
           var dt =new DataTable();
           ManejoDatos datos = new ManejoDatos();
           Clientes ct = new Clientes();
           string[] parametros = {"@operacion","@idcliente" };
           dt = datos.getDatosTabla("spClienteSE",
               parametros,
               "S",
               cliente.idcliente);
           foreach(DataRow fila in dt.Rows){
           ct.idcliente=fila["IDCliente"].ToString();
           ct.nombre=fila["Nombres"].ToString();
           ct.apellido=fila["Apellidos"].ToString();
           ct.direccion = fila["Direccion"].ToString();
           ct.telefono = fila["Telefono"].ToString();
           ct.correo=fila["Correo"].ToString();
           ct.fechanacimiento=fila["FechaNacimiento"].ToString();
          ct.cupo=Convert.ToInt32(fila["Cupo"].ToString());

           }
           return ct;
       }

        

   }
}
