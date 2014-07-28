<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="SistemaWebFacturas.Formulario_web13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-8">
            <section id="loginForm">
                <div class="form-horizontal">
                    <h4>Formulario productos</h4>
              <hr />
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtidproducto" CssClass="col-md-2 control-label">Id Producto</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtidproducto" CssClass="form-control" TextMode="SingleLine" />
                         </div>
                    </div>

                      <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtdescripcion" CssClass="col-md-2 control-label">Descripción</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtdescripcion" CssClass="form-control" TextMode="MultiLine" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtdescripcion"
                                CssClass="text-danger" ErrorMessage="El campo descripción es obligatorio." Display="Dynamic" />
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
                        <asp:Label runat="server" AssociatedControlID="txtstock" CssClass="col-md-2 control-label">Stock</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtstock" CssClass="form-control" TextMode="SingleLine" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtstock"
                                CssClass="text-danger" ErrorMessage="El campo stock es obligatorio." Display="Dynamic" />
                        </div>
                    </div>

                      <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtnotas" CssClass="col-md-2 control-label">Notas</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtnotas" CssClass="form-control" TextMode="MultiLine" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtnotas"
                                CssClass="text-danger" ErrorMessage="El campo notas es obligatorio." Display="Dynamic" />
                        </div>
                    </div>

                      <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="ddliva" CssClass="col-md-2 control-label">Iva</asp:Label>
                        <div class="col-md-10">
                            <asp:DropDownList ID="ddliva" runat="server" Height="30px" Width="121px" ></asp:DropDownList>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="ddliva"
                                CssClass="text-danger" ErrorMessage="El campo iva es obligatorio." Display="Dynamic" />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="ddldepartamento" CssClass="col-md-2 control-label">Departamento</asp:Label>
                        <div class="col-md-10">
                            <asp:DropDownList ID="ddldepartamento" runat="server" Height="29px"></asp:DropDownList>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="ddldepartamento"
                                CssClass="text-danger" ErrorMessage="El campo departamento es obligatorio." Display="Dynamic" />
                        </div>
                    </div>

                      <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server"   Text="Registrar producto" CssClass="btn btn-default" OnClick="Unnamed15_Click"   />
                              <asp:Button runat="server"   Text="Actualizar producto" CssClass="btn btn-default" OnClick="Unnamed15_Click1"  />
                           <asp:Button runat="server"   Text="Eliminar producto" CssClass="btn btn-default" CausesValidation="False" OnClick="Unnamed16_Click"     />
                 
                              <asp:LinkButton ID="blcliente" runat="server" CausesValidation="False" PostBackUrl="~/Mantenimiento/listadoProductos.aspx">Ver productos</asp:LinkButton>
      
                 
                                   </div>
                    </div>



                  </div>
                </section>
            </div>
        </div>
</asp:Content>
