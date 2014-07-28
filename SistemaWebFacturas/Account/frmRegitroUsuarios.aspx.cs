using CADLogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SistemaWebFacturas.Account
{
    public partial class frmRegitroUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtfecha.Text = Convert.ToString(DateTime.Now);
        }
        public void limpiar()
        {
            txtUsuario.Text = "";
            txtactivo.Text = "";

        }
        protected void Unnamed6_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();
            user.usuario = txtUsuario.Text;
            user.clave = Password.Text;
            user.fecha = Convert.ToDateTime(txtfecha.Text);
            user.activo = Convert.ToBoolean(txtactivo.Text);
            if (user.Insertar(user) > 0)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(),
                           "Registro", "<script>alert('Registro ingresado correctamente.!')</script>");
                limpiar();
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(),
                           "Registro", "<script>alert('Fallo el intento de registro!')</script>");
            }
        }

        protected void Unnamed10_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.usuario = txtUsuario.Text;
            usuario.getUsuario(usuario);
            if (usuario != null)
            {
                txtUsuario.Text = usuario.usuario;
                Password.Text = usuario.clave;
                txtfecha.Text = usuario.fecha.ToString();
                txtactivo.Text = usuario.activo.ToString();

                MessageBox.Show("Funciono");
            }
            else
            {

                MessageBox.Show("No se encontro un carajo");
            }

        }
    }
}