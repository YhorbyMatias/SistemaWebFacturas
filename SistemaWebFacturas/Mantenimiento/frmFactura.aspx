<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmFactura.aspx.cs" Inherits="SistemaWebFacturas.Formulario_web112" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-8">
            <section id="loginForm">
                <div class="form-horizontal">
                    <h4>Formulario para clientes</h4>
                    <hr />
                    <asp:LinkButton ID="lbdetafact" runat="server" PostBackUrl="~/Mantenimiento/frmDetalleFacturo.aspx">Detalle factura</asp:LinkButton>
                    <asp:LinkButton ID="lbfactemp" runat="server" PostBackUrl="~/Mantenimiento/frmDetalleFacturaTmp.aspx">Factura temporal</asp:LinkButton>
                    <hr />
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtidfactura" CssClass="col-md-2 control-label">Id Factura</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtidfactura" CssClass="form-control" TextMode="SingleLine" />
                            </div>
                    </div>


                     <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="ddlcliente" CssClass="col-md-2 control-label">Id Cliente</asp:Label>
                        <div class="col-md-10">
                            <asp:DropDownList ID="ddlcliente" runat="server" Height="31px"></asp:DropDownList>
                                  <asp:RequiredFieldValidator runat="server" ControlToValidate="ddlcliente"
                                CssClass="text-danger" ErrorMessage="El campo id cliente es obligatorio." Display="Dynamic" />
                        </div>
                    </div>
                     <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtfeccha" CssClass="col-md-2 control-label">Fecha</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtfeccha" CssClass="form-control" TextMode="SingleLine" Enabled="False" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtfeccha"
                                CssClass="text-danger" ErrorMessage="El fecha es obligatorio." Display="Dynamic" />
                        </div>
                    </div>

                     <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server"   Text="Nueva factura" CssClass="btn btn-default" OnClick="Unnamed6_Click1"  />
                             <asp:Button runat="server"   Text="Actualizar factura" CssClass="btn btn-default" OnClick="Unnamed7_Click"    />
                                  <asp:Button runat="server"   Text="Eliminar factura" CssClass="btn btn-default" OnClick="Unnamed8_Click"    />
                         
                              <asp:LinkButton ID="blcliente" runat="server" CausesValidation="False" PostBackUrl="~/Mantenimiento/ListadoFacturas.aspx">Ver facturas</asp:LinkButton>
      
                 
                                   </div>
                    </div>
                </div>
            </section>
        </div>
    </div>
</asp:Content>
