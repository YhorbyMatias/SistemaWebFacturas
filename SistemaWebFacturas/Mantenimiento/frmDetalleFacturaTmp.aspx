<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmDetalleFacturaTmp.aspx.cs" Inherits="SistemaWebFacturas.Formulario_web114" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="row">
        <div class="col-md-8">
            <section id="loginForm">
                <div class="form-horizontal">
                    <h4>Formulario productos</h4>
              <hr />
           
    
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtlinea" CssClass="col-md-2 control-label">Id linea</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtlinea" CssClass="form-control" TextMode="SingleLine" />
                        </div>
                    </div>

                    
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="ddlproducto" CssClass="col-md-2 control-label">Id Producto</asp:Label>
                        <div class="col-md-10">
                            <asp:DropDownList ID="ddlproducto" runat="server" Height="30px"></asp:DropDownList>
                        </div>
                    </div>

                      <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtdescripcion" CssClass="col-md-2 control-label">Descripción</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtdescripcion" CssClass="form-control" TextMode="SingleLine" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtdescripcion"
                                CssClass="text-danger" ErrorMessage="El campo descripcion es obligatorio." Display="Dynamic" />
                        </div>
                    </div>


                      <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtprecio" CssClass="col-md-2 control-label">Precio</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtprecio" CssClass="form-control" TextMode="SingleLine" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtprecio"
                                CssClass="text-danger" ErrorMessage="El campo precio es obligatorio." Display="Dynamic" />
                        </div>
                    </div>

                      <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtcantidad" CssClass="col-md-2 control-label">Cantidad</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtcantidad" CssClass="form-control" TextMode="SingleLine" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtcantidad"
                                CssClass="text-danger" ErrorMessage="El campo cantidad es obligatorio." Display="Dynamic" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server" Text="Registrar factura tmp" CssClass="btn btn-default" OnClick="Unnamed9_Click"   />
                            <asp:Button runat="server" Text="Actualizar factura tmp" CssClass="btn btn-default" OnClick="Unnamed10_Click"   />
                            <asp:Button runat="server" Text="Eliminar factura tmp" CssClass="btn btn-default" CausesValidation="False" OnClick="Unnamed11_Click"  />

                            <asp:LinkButton ID="blcliente" runat="server" CausesValidation="False" PostBackUrl="~/Mantenimiento/ListadoDetalleFacturaTmp.aspx">Ver productos</asp:LinkButton>


                        </div>
                    </div>

                    </div>
               </section>
            </div>
        </div>

</asp:Content>
