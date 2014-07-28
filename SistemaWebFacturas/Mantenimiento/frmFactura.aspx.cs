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
    public partial class Formulario_web112 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtfeccha.Text = DateTime.Now.ToString();
            if (!IsPostBack)
            {
                var cliente = new Clientes();
                ddlcliente.DataTextField = "Nombres";
                ddlcliente.DataValueField = "IDCliente";
                ddlcliente.DataSource = cliente.getClientes();
                ddlcliente.DataBind();

            }
        }

       

        protected void Unnamed6_Click1(object sender, EventArgs e)
        {

            Factura fact = new Factura();
            fact.idcliente = Convert.ToInt32(ddlcliente.SelectedValue);
            fact.fecha =Convert.ToDateTime( txtfeccha.Text);
            if (fact.NuevaFactura(fact) > 0)
            {
                MessageBox.Show("Factura creada correctamente..", "Registro", MessageBoxButtons.OK);
            }
            else { MessageBox.Show("No se pudo guardar el registro..", "Error", MessageBoxButtons.OK); }
      
        }

        protected void Unnamed7_Click(object sender, EventArgs e)
        {

            Factura fact = new Factura();
            fact.idcliente = Convert.ToInt32(ddlcliente.SelectedValue);
            fact.fecha = Convert.ToDateTime(txtfeccha.Text);
            if (fact.ActualizarFactura(fact) > 0)
            {
                MessageBox.Show("Factura actualizada correctamente..", "Registro", MessageBoxButtons.OK);
            }
            else { MessageBox.Show("No se pudo actualizar el registro..", "Error", MessageBoxButtons.OK); }
        }

        protected void Unnamed8_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            if (factura.EliminarFactura(Convert.ToInt32(txtidfactura.Text)) > 0)
            {
                MessageBox.Show("Registro eliminado correctamente", "Eliminado");
            }
            else
            { MessageBox.Show("No se pudo eliminar el registro..","Error"); }
        }
    }
}