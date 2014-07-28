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
    public partial class Formulario_web16 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed6_Click(object sender, EventArgs e)
        {
            Iva iva = new Iva();
            iva.descripcion = txtdescripcion.Text;
            iva.tarifa =Convert.ToDecimal( txttarifa.Text);
            if (iva.nevoIva(iva) > 0)
            {
                MessageBox.Show("Registro creado correctamente", " Nuevo iva", MessageBoxButtons.OK);
            }
            else { MessageBox.Show("El registro de se logro","Error",MessageBoxButtons.OK); }
        }

        protected void Unnamed7_Click(object sender, EventArgs e)
        {
            Iva iva = new Iva();
            iva.idiva =Convert.ToInt32( txtidiva.Text);
            iva.descripcion = txtdescripcion.Text;
            iva.tarifa = Convert.ToDecimal(txttarifa.Text);
            if (iva.nevoIva(iva) > 0)
            {
                MessageBox.Show("Registro actualizado correctamente", " Nuevo iva", MessageBoxButtons.OK);
            }
            else { MessageBox.Show("El registro no se pudo actualizar", "Error", MessageBoxButtons.OK); }
     
        }

        protected void Unnamed8_Click(object sender, EventArgs e)
        {
            Iva i= new Iva();
            if (i.EliminarIva(Convert.ToInt32(txtidiva.Text)) > 0)
            {
                MessageBox.Show("Registro eliminado correctamente...", "Elimnado", MessageBoxButtons.OK);
            }
            else { MessageBox.Show("Fallo el intento de borrado","Error",MessageBoxButtons.OK); }
        }
    }
}