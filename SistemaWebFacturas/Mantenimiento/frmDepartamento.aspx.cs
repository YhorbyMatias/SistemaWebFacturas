using CADLogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
namespace SistemaWebFacturas
{
    public partial class Formulario_web17 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed4_Click(object sender, EventArgs e)
        {
            Departamento dpto = new Departamento();
            dpto.descripcion = txtdescripcion.Text;
            if (dpto.nuevoDepartamento(dpto) > 0)
            {
                MessageBox.Show("Dpto creado correctamente..", "Registro", MessageBoxButtons.OK);
            }
            else { MessageBox.Show("Fallo el intento de registro","Error",MessageBoxButtons.OK); }
        }

        protected void Unnamed5_Click(object sender, EventArgs e)
        {

            Departamento dpto = new Departamento();
            dpto.descripcion = txtdescripcion.Text;
            if (dpto.ActualizarDepartamento(dpto) > 0)
            {
                MessageBox.Show("Dpto actualizo correctamente..",
                    "update", MessageBoxButtons.OK);
            }
            else { MessageBox.Show("Fallo el intento actualización del registro", "Error", MessageBoxButtons.OK); }
     
        }

        protected void Unnamed6_Click(object sender, EventArgs e)
        {
            Departamento dpto = new Departamento();
            if (dpto.eliminarDepartamento(Convert.ToInt32(txtiddepartamento.Text)) > 0)
            {
                MessageBox.Show("registro eliminado correctamente.", "Eliminado", MessageBoxButtons.OK);
            }
            else { MessageBox.Show("Fallo el inteto de borrado","Error al eliminar",MessageBoxButtons.OK); }
        }
    }
}