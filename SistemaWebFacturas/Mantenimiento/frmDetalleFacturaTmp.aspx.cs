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
    public partial class Formulario_web114 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed9_Click(object sender, EventArgs e)
        {
            DetalleFacturaTmp dftmp = new DetalleFacturaTmp();
            dftmp.idproducto =Convert.ToInt32( ddlproducto.SelectedValue);
            dftmp.descripcion = txtdescripcion.Text;
            dftmp.precio =Convert.ToDecimal( txtprecio.Text);
            dftmp.cantidad =Convert.ToInt32( txtcantidad.Text);
            if (dftmp.NuevoDetalleFactura(dftmp) > 0)
            {
                MessageBox.Show("Regitro guardado correctamente", "Guardado");
            }
            else { MessageBox.Show("No se pudo guardar el registro","Error"
                ); }
        }

        protected void Unnamed10_Click(object sender, EventArgs e)
        {
            DetalleFacturaTmp dftmp = new DetalleFacturaTmp();
            dftmp.idproducto = Convert.ToInt32(ddlproducto.SelectedValue);
            dftmp.descripcion = txtdescripcion.Text;
            dftmp.precio = Convert.ToDecimal(txtprecio.Text);
            dftmp.cantidad = Convert.ToInt32(txtcantidad.Text);
            if (dftmp.ActualizarDetalleFactura(dftmp) > 0)
            {
                MessageBox.Show("Regitro actualizado correctamente", "Guardado");
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el registro", "Error"
                    );
            }
        }

        protected void Unnamed11_Click(object sender, EventArgs e)
        {
            DetalleFacturaTmp df = new DetalleFacturaTmp();
            if (df.EliminarDetalleFacturaTmp(Convert.ToInt32(txtlinea.Text)) > 0)
            {
                MessageBox.Show("El registro fue eliminado correctamente", "Eliminado");
            }
            else { MessageBox.Show("El registro no se pudo eliminar"); }
        }
    }
}