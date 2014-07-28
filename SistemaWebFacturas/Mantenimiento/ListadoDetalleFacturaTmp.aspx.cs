using CADLogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaWebFacturas
{
    public partial class Formulario_web111 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var factTmp = new DetalleFacturaTmp();
            dgvDetalleFacturaTmp.DataSource = factTmp.listadoDetalleFactutasTmp();
            dgvDetalleFacturaTmp.DataBind();

        }
    }
}