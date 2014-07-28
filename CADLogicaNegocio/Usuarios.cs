using CADDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADLogicaNegocio
{
    public class Usuarios
    {
        public string usuario { get; set; }
        public string clave { get; set; }
        public DateTime fecha { get; set; }
        public bool activo { get; set; }


        #region validar usuario
        public bool Validarusuario(Usuarios user)
        {
            ManejoDatos datos = new ManejoDatos();
            string[] parametros = {"@operacion",
                                  "@usuario",
                                  "@clave",
                                  "@fecha",
                                  "@activo"};
            DataTable dt = datos.getDatosTabla("spUsuariosS",
                parametros,"S",
                user.usuario,
                user.clave,
                DateTime.Now,
                1
               );
            foreach (DataRow fila in dt.Rows)
                return true;
            return false;
        
        }
        
        #endregion

        #region mostrar usuarios
        public DataTable getUsuarios()
        {

            var datos = new ManejoDatos();
            string[] parametros = {"@operacion","@usuario" };
            return datos.getDatosTabla("spUsuarioSE",parametros,"P",0);
        }
        
        #endregion
        #region crear usuarios
        public int Insertar(Usuarios usu) 
        {
            var datos = new ManejoDatos();
            string[] parametros = { "@usuario","@clave","@fecha","@activo"};
            return datos.Ejecutar("spUsuarioIA",
                  parametros, 
                  usu.usuario,
                  usu.clave,
                  usu.fecha,
                  usu.activo);
        }
        
        #endregion




        #region listado usuarios
        public Usuarios getUsuario(Usuarios usuario)
        {
            ManejoDatos datos = new ManejoDatos();
            string[] parametros = { "@operacion","@usuario" };
            var dt = new DataTable();
               dt=datos.getDatosTabla("spUsuarioSE", parametros, "S", usuario.usuario);
            Usuarios usu = new Usuarios();
            foreach (DataRow fila in dt.Rows) {
                usu.usuario = fila["usuario"].ToString();
                usu.clave=fila["clave"].ToString();
                usu.fecha=Convert.ToDateTime(fila["fecha"].ToString());
                usu.activo=Convert.ToBoolean(fila["activo"].ToString());

            }
            return usu;
        
        }



        #endregion
    }
}
