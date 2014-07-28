<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmDepartamento.aspx.cs" Inherits="SistemaWebFacturas.Formulario_web17" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-8">
            <section id="loginForm">
                <div class="form-horizontal">
                    <h4>Formulario Departamento</h4>
                    <hr />
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtiddepartamento" CssClass="col-md-2 control-label">Id Dpto</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtiddepartamento" CssClass="form-control" TextMode="SingleLine" />
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
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server" Text="Registrar Dpto" CssClass="btn btn-default" OnClick="Unnamed4_Click"  />
                            <asp:Button runat="server" Text="Actualizar Dpto" CssClass="btn btn-default" OnClick="Unnamed5_Click"  />
                            <asp:Button runat="server" Text="Eliminar Dpto" CssClass="btn btn-default" CausesValidation="False" OnClick="Unnamed6_Click" />

                            <asp:LinkButton ID="blcliente" runat="server" CausesValidation="False" PostBackUrl="~/Mantenimiento/listadoDpto.aspx">Ver Dpto</asp:LinkButton>


                        </div>
                    </div>

                </div>
            </section>
        </div>
    </div>

</asp:Content>
