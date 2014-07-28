<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmClientes.aspx.cs" Inherits="SistemaWebFacturas.Formulario_web12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
    <div class="row">
        <div class="col-md-8">
            <section id="loginForm">
                <div class="form-horizontal">
                    <h4>Formulario para clientes</h4>
                    <hr />
                      <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
                   <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtidcliente" CssClass="col-md-2 control-label">Id Cliente</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtidcliente" CssClass="form-control" TextMode="SingleLine" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtidcliente"
                                CssClass="text-danger" ErrorMessage="El campo id cliente es obligatorio." Display="Dynamic" />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtnombre" CssClass="col-md-2 control-label">Nombre</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtnombre" TextMode="SingleLine" CssClass="form-control" />
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtnombre" CssClass="text-danger" 
                                        ErrorMessage="El campo nombre es obligatorio." Display="Dynamic" />
                  
                        </div>
                    </div>
                     <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtapellido" CssClass="col-md-2 control-label">Apellido</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtapellido" TextMode="SingleLine" CssClass="form-control" />
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtapellido" CssClass="text-danger" 
                                        ErrorMessage="El campo apellido es obligatorio." Display="Dynamic" />
                      </div>
                    </div>
                     <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtdireccion" CssClass="col-md-2 control-label">Direción</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtdireccion" TextMode="SingleLine" CssClass="form-control" />
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtdireccion" CssClass="text-danger" 
                                        ErrorMessage="El campo direccion es obligatorio." Display="Dynamic" />
                  
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txttelefono" CssClass="col-md-2 control-label">Telefono</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txttelefono" TextMode="SingleLine" CssClass="form-control" />
                                     
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtemail" CssClass="col-md-2 control-label">Email</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtemail" TextMode="Email" CssClass="form-control" />
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtemail" CssClass="text-danger" 
                                        ErrorMessage="El campo email es obligatorio." Display="Dynamic" />
                  
                        </div>
                    </div>
                     <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtfechanacimiento" CssClass="col-md-2 control-label">Fecha Nacimiento</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtfechanacimiento" CssClass="form-control" />
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtfechanacimiento" CssClass="text-danger" 
                                        ErrorMessage="El campo fecha nacimiento es obligatorio." Display="Dynamic" />
                  
                        </div>
                    </div>
                     <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtcupo" CssClass="col-md-2 control-label">Cupo</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtcupo" CssClass="form-control" />
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtcupo" CssClass="text-danger" 
                                        ErrorMessage="El campo cupo es obligatorio." Display="Dynamic" />
                  
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server"   Text="Registrar cliente" CssClass="btn btn-default" OnClick="Unnamed16_Click" />
                              <asp:Button runat="server"   Text="Actualizar cliente" CssClass="btn btn-default" OnClick="Unnamed17_Click" /> 
                                 <asp:Button runat="server"   Text="Consultar cliente" CssClass="btn btn-default" CausesValidation="False" OnClick="Unnamed18_Click1" />
                           <asp:Button runat="server"   Text="Eliminar cliente" CssClass="btn btn-default" CausesValidation="False" OnClick="Unnamed18_Click"   />
                 
                              <asp:LinkButton ID="blcliente" runat="server" CausesValidation="False" PostBackUrl="~/Mantenimiento/ListadoClientes.aspx">Ver clientes</asp:LinkButton>
      
                 
                                   </div>
                    </div>
                </div>
                <asp:Label ID="lbmensaje" runat="server" BackColor="#CC0000" Font-Size="Small"></asp:Label>
                <p>
                     Registrase como cliente y disfruta de nuestros productos 
                        
                </p>
            </section>
        </div>

         
    </div>
</asp:Content>
