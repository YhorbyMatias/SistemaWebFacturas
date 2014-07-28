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
    public partial class Formulario_web113 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var fact = new DetalleFactura();
            ddlfactura.DataTextField = "IDFactura";
            ddlfactura.DataValueField = "IDFactura";
            ddlfactura.DataSource = fact.listasdoDetalleFactura();
            ddlfactura.DataBind();
            //productos
            var prod = new Productos();
            ddlproducto.DataTextField = "Descripcion";
            ddlproducto.DataValueField = "IDProducto";
            ddlproducto.DataSource = prod.getProductos();
            ddlproducto.DataBind();

        }

        public void limpiar()
        {
            ddlfactura.SelectedIndex = -1;
            ddlproducto.SelectedIndex = -1;
            txtlinea.Text = "";
            txtdescripcion.Text = "";
            txtprecio.Text = "";
        
        }
        protected void Unnamed10_Click(object sender, EventArgs e)
        {
            DetalleFactura dfact = new DetalleFactura();
            dfact.idfactura =Convert.ToInt32( ddlfactura.SelectedValue);
            dfact.idproducto =Convert.ToInt32( ddlproducto.SelectedValue);
            dfact.descripcion = txtdescripcion.Text;
            dfact.precio = Convert.ToDecimal(txtprecio.Text);
            dfact.cantidad = Convert.ToInt32(txtcantidad.Text);
            if (dfact.NuevoDetalleFactura(dfact) > 0)
            {
                MessageBox.Show("Regitro ingresado correctamente", "Guardado");
                limpiar();
            }
            else {
                MessageBox.Show("El intento de registro fallo","Error");
            }
        }

        protected void Unnamed11_Click(object sender, EventArgs e)
        {
            DetalleFactura dfact = new DetalleFactura();
            dfact.idfactura = Convert.ToInt32(ddlfactura.SelectedValue);
            dfact.idproducto = Convert.ToInt32(ddlproducto.SelectedValue);
            dfact.descripcion = txtdescripcion.Text;
            dfact.precio = Convert.ToDecimal(txtprecio.Text);
            dfact.cantidad = Convert.ToInt32(txtcantidad.Text);
            if (dfact.ActualizarDetalleFactura(dfact) > 0)
            {
                MessageBox.Show("Regitro actualizado correctamente", "Actualizado");
                limpiar();
            }
            else
            {
                MessageBox.Show("El intento de actualización fallo", "Error");
            }
        }

        protected void Unnamed12_Click(object sender, EventArgs e)
        {
            DetalleFactura dfact = new DetalleFactura();
            if (dfact.EliminarDetalleFactura(Convert.ToInt32(txtlinea.Text)) > 0)
            {
                MessageBox.Show("Registro eliminado correctamente", "Eliminado");
            }
            else
            { MessageBox.Show("No se pudo eliminar el registro","Error"); }
        }
    }
}