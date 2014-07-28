using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CADLogicaNegocio;
using System.Windows.Forms;
namespace SistemaWebFacturas
{
    public partial class Formulario_web13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var iva = new Iva();
                ddliva.DataTextField = "Descripcion";
                ddliva.DataValueField = "IDIVA";
                ddliva.DataSource = iva.listIva();
                ddliva.DataBind();
                //departamento
                var dpto = new Departamento();
                ddldepartamento.DataTextField = "Descripcion";
                ddldepartamento.DataValueField = "IDDepartamento";
                ddldepartamento.DataSource = dpto.listDepartemento();
                ddldepartamento.DataBind();
            }
        }
        public void limpiar() 
        {
            txtnotas.Text = "";
            txtdescripcion.Text = "";
            txtprecio.Text = "";
            txtstock.Text = "";
            txtidproducto.Text = "";
        
        }
        protected void Unnamed15_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos();
            producto.descripcion = txtdescripcion.Text;
            producto.precio = Convert.ToDecimal(txtprecio.Text);
            producto.stock = Convert.ToInt32(txtstock.Text);
            producto.notas = txtnotas.Text;
            producto.idiva = Convert.ToInt32(ddliva.SelectedValue);
            producto.iddepartamento = Convert.ToInt32(ddldepartamento.SelectedValue);
            if (producto.nuevoProducto(producto)>0)
	        {
             MessageBox.Show("Producto creado correctamente.","nuevo producto",MessageBoxButtons.OK);
             limpiar();
            }else{MessageBox.Show("El producto no se pudo crear","Error",MessageBoxButtons.OK);}
        }

        protected void Unnamed15_Click1(object sender, EventArgs e)
        {
            Productos producto = new Productos();
            producto.descripcion = txtdescripcion.Text;
            producto.precio = Convert.ToDecimal(txtprecio.Text);
            producto.stock = Convert.ToInt32(txtstock.Text);
            producto.notas = txtnotas.Text;
            producto.idiva = Convert.ToInt32(ddliva.SelectedValue);
            producto.iddepartamento = Convert.ToInt32(ddldepartamento.SelectedValue);
            if (producto.actualizarProducto(producto) > 0)
            {
                MessageBox.Show("Producto modificado correctamente.", "nuevo producto", MessageBoxButtons.OK);
                limpiar();
            }
            else { MessageBox.Show("El producto no se pudo modificar", "Error", MessageBoxButtons.OK); }
        
        }

        protected void Unnamed16_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos();
            if (producto.EliminarProducto(txtidproducto.Text) > 0)
            {
                MessageBox.Show("Producto eliminado correctamente..","Eliminado",MessageBoxButtons.OK);
            }
            else { MessageBox.Show("El producto no se pudo eliminar..","error",MessageBoxButtons.OK); }
        }
    }
}