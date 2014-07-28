<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmIvas.aspx.cs" Inherits="SistemaWebFacturas.Formulario_web16" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-8">
            <section id="loginForm">
                <div class="form-horizontal">
                    <h4>Formulario Ivas</h4>
                    <hr />
                     <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtidiva" CssClass="col-md-2 control-label">Id Iva</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtidiva" CssClass="form-control" TextMode="SingleLine" />
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
                        <asp:Label runat="server" AssociatedControlID="txttarifa" CssClass="col-md-2 control-label">Tarifa</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txttarifa" CssClass="form-control" TextMode="MultiLine" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txttarifa"
                                CssClass="text-danger" ErrorMessage="El campo tarifa es obligatorio." Display="Dynamic" />
                        </div>
                    </div>



                       <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server"   Text="Registrar Iva" CssClass="btn btn-default" OnClick="Unnamed6_Click"     />
                              <asp:Button runat="server"   Text="Actualizar Iva" CssClass="btn btn-default" OnClick="Unnamed7_Click"   />
                           <asp:Button runat="server"   Text="Eliminar Iva" CssClass="btn btn-default" CausesValidation="False" OnClick="Unnamed8_Click"    />
                 
                              <asp:LinkButton ID="blcliente" runat="server" CausesValidation="False" PostBackUrl="~/Mantenimiento/listadoIvas.aspx">Ver ivas</asp:LinkButton>
      
                 
                                   </div>
                    </div>

                </div>
            </section>
        </div>
    </div>
</asp:Content>
