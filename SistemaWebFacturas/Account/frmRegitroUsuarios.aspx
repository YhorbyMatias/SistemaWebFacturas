<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRegitroUsuarios.aspx.cs" Inherits="SistemaWebFacturas.Account.frmRegitroUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registrarse como usuario</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
     
           <div class="row">
        <div class="col-md-8">
            <section id="loginForm">
                <div class="form-horizontal">
                    <h4>Registrase como usuario del sistema</h4>
                    <hr />
                      <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
                   <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtUsuario" CssClass="col-md-2 control-label">Usuario *</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtUsuario" CssClass="form-control" TextMode="SingleLine" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtUsuario"
                                CssClass="text-danger" ErrorMessage="El campo de usuario es obligatorio." Display="Dynamic" />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-2 control-label">Contraseña *</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="text-danger" ErrorMessage="El campo clave obligatorio." Display="Dynamic" />
                  
                        </div>
                    </div>
                     <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtfecha" CssClass="col-md-2 control-label">Fecha *</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtfecha" CssClass="form-control" Enabled="False" />
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtfecha" CssClass="text-danger" ErrorMessage="El campo fecha obligatorio." Display="Dynamic" />
                  
                        </div>
                    </div>
                     <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtactivo" CssClass="col-md-2 control-label">Activo *</asp:Label>
                        <div class="col-md-10">

                            <asp:TextBox runat="server" ID="txtactivo" TextMode="SingleLine" CssClass="form-control" />
                                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtactivo" CssClass="text-danger" ErrorMessage="El campo activo obligatorio." Display="Dynamic" />
                  
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server"   Text="Registrarse" CssClass="btn btn-default" OnClick="Unnamed6_Click" />
                            <asp:Button runat="server"   Text="Consultar" CssClass="btn btn-default" OnClick="Unnamed10_Click" CausesValidation="False"   />
                 
                        </div>
                    </div>
                </div>
                
                
            </section>
        </div>

         
    </div>
    
    </form>
</body>
</html>
