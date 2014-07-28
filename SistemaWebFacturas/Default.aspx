<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SistemaWebFacturas._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Sistema  Facturación</h1>
        <p class="lead">Sistema de facturación web para el manejo de productos, clientes y facturas</p>
       
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Administración de clientes</h2>
            <p>
                 El mantenimiento de clientes desde  la plataforma, se podra acceder con solo tener una cuenta en el sitio web.
            </p>
            <p>
                <a class="btn btn-default" href="#">Seguir leyendo &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Administración de productos</h2>
            <p>
            La administración de productos permite ralizar un mantenimiento completo :Ingresar nuevos productos, realiazar
                actulizaciones así como también eliminar y ver cada uno de los datos de los productos.
                 <p>
                <a class="btn btn-default" href="#">Seguir leyendo &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Diseño y reporte de facturas</h2>
            <p>
          Podras  crear tus propias facturas y visualizarlas de una manera personalizada. Una factura se le es asginada a un cliente 
                con sus respectivos productos que adquirio.
                  <p>
                <a class="btn btn-default" href=#"">Seguir leyendo &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
