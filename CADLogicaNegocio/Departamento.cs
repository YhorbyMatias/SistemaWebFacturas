using CADDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADLogicaNegocio
{
  public  class Departamento
    {

        public int iddepartamento{ get; set; }
        public string  descripcion { get; set; }
      //crear nuevo depatamento 
        public int nuevoDepartamento(Departamento dpto)
        {
            ManejoDatos datos = new ManejoDatos();
            string[] parametros = { "@operacion" ,"@descripcion"};
            return datos.Ejecutar("spDepartamentoIA", parametros, "I",
                dpto.descripcion); 
         }

      //actualizar departamento
        public int ActualizarDepartamento(Departamento dpto)
        {
            ManejoDatos datos = new ManejoDatos();
            string[] parametros = { "@operacion","@iddepartamento","@descripcion"};
            return datos.Ejecutar("spDepartamentoIA", parametros, "A",
                dpto.iddepartamento,
                dpto.descripcion);
        
        }
      //listado departamento
      public DataTable listDepartemento()
      {
          ManejoDatos datos = new ManejoDatos();
          string[] parametros = { "@operacion", "@iddepartamento" };
          return datos.getDatosTabla("spDepartamentoSE", parametros, "Y", 0);
      
      }
      //eliminar iva

      public int eliminarDepartamento(int dpto)
      {
          ManejoDatos datos = new ManejoDatos();
          string[] parametros = {"@operacion","@iddepartamento" };
          return datos.Ejecutar("spDepartamentoSE",parametros,"E",dpto);

      }
      //méotodo consultar un departamento
      public Departamento getDepartamento(Departamento dpto)
      {
          string[] paramentro = {"@operacion","@iddepartamento" };
          Departamento departamento = new Departamento();
          ManejoDatos datos = new ManejoDatos();
          var dt = new DataTable();
          dt = datos.getDatosTabla("spDepartamentoSE",
                paramentro,"S",dpto.iddepartamento);
          foreach (DataRow fila in dt.Rows)
          {
              departamento.iddepartamento = Convert.ToInt32(fila["IDDepartamento"].ToString());
              departamento.descripcion=fila["Descripcion"].ToString();

          } 
          return departamento;
      
      }
    }
}
