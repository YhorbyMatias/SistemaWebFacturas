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
    public partial class Formulario_web12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void limpiar()
        {
            txtidcliente.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtdireccion.Text = "";
            txttelefono.Text = "";
            txtemail.Text = "";
            txtfechanacimiento.Text = "";
            txtcupo.Text = "";
        
        
        }
        protected void Unnamed16_Click(object sender, EventArgs e)
        {
             
            Clientes cliente = new Clientes();
            cliente.idcliente = txtidcliente.Text;
            cliente.nombre = txtnombre.Text;
            cliente.apellido = txtapellido.Text;
            cliente.direccion = txtdireccion.Text;
            cliente.telefono = txttelefono.Text;
            cliente.correo = txtemail.Text;
            cliente.fechanacimiento = txtfechanacimiento.Text;
            cliente.cupo =Convert.ToInt32( txtcupo.Text);
            if (cliente.nuevoCliente(cliente) > 0)
            {
                MessageBox.Show("cliente creado correctamente");
                limpiar();
            }
            else { MessageBox.Show("el registro no se creo, revise sus datos porfavor.."); }
            
        }

        protected void Unnamed17_Click(object sender, EventArgs e)
        {
               
            Clientes cliente = new Clientes();
            cliente.idcliente = txtidcliente.Text;
            cliente.nombre = txtnombre.Text;
            cliente.apellido = txtapellido.Text;
            cliente.direccion = txtdireccion.Text;
            cliente.telefono = txttelefono.Text;
            cliente.correo = txtemail.Text;
            cliente.fechanacimiento = txtfechanacimiento.Text;
            cliente.cupo =Convert.ToInt16( txtcupo.Text);
            if (cliente.ActualizarCliente(cliente) > 0)
            {
                MessageBox.Show("cliente se actualizo correctamente");
                limpiar();
            }
            else { MessageBox.Show("el actualización no fue posible, revise sus datos porfavor.."); }
            
        }

        protected void Unnamed18_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
           if (cliente.Eliminar(txtidcliente.Text)>0)
	          {
                  MessageBox.Show("Cliente eliminado correctamente");
              }
           else { MessageBox.Show("No se pudo eliminar el cliente"); }
	}

        protected void Unnamed18_Click1(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            cliente.idcliente = txtidcliente.Text;
            cliente.getCliente(cliente);
            if (cliente != null)
            {
                txtidcliente.Text = cliente.idcliente;
                txtnombre.Text = cliente.nombre;
                txtapellido.Text = cliente.apellido;
                txtdireccion.Text = cliente.direccion;
                txttelefono.Text = cliente.telefono;
                txtemail.Text = cliente.correo;
                txtfechanacimiento.Text = cliente.fechanacimiento;
                txtcupo.Text = cliente.cupo.ToString();
            }
            else {
                MessageBox.Show("No se encontro el registro");
            }
        } 

        }
    }