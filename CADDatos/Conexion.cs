using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CADDatos
{
    public class Conexion
    {
        public SqlConnection  con { get; set; }

        private string cadenaconexion() {

            return @"data source=localhost;initial catalog=tallerFacturacion;user id=alvarez;password=alvarez123";
        }

        public Conexion() {
            this.con = null;
        }

        public SqlConnection getConexion() 
        {
            try
            {
                con = new SqlConnection(cadenaconexion());
                con.Open();
                return this.con;
            }
            catch (Exception)
            {
                return null;
            
            
            }
        }

        public void CerrarConexion() 
         {
             if (this.con != null)
                 con.Close();

        
        }
    }
}
