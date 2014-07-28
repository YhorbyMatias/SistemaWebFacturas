using CADLogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaWebFacturas
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed6_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();
            user.usuario = txtUsuario.Text;
            user.clave = Password.Text;
            if (user.Validarusuario(user))
            {
                 ClientScript.RegisterClientScriptBlock(GetType(), "mensaje", "<script>alert('Bienvenid@');</script>");
       
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "mensaje", "<script>alert('Usuario o contraseña invalida');</script>");
       
            }
        }
    }
}