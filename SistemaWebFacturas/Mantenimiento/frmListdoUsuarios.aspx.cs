using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CADLogicaNegocio;
namespace SistemaWebFacturas
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var user = new Usuarios();
                dvusuarios.DataSource = user.getUsuarios();
                dvusuarios.DataBind();
            }
        }
    }
}