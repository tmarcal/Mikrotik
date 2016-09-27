<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Mikrotik._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Mikrotik</h1>
        <p class="lead">Nem sei o que dizer desse aparelho, mas é massa!</p>
        <p><a href="http://www.mikrotik.com/" target="_blank" class="btn btn-primary btn-lg">Conheça mais &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Como começar?</h2>
            <p>
                Sugiro que dê uma olhadinha no meu primeiro post sobre o assunto e prepare os dedos e cabeça (vai precisar).
            </p>
            <p>
                <a class="btn btn-default" href="http://thiagomarcal.blogspot.com.br/2011/09/adicionando-uma-pagina-de-cadastro-de.html" target="_blank">Estude aqui &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Tem material?</h2>
            <p>
                Sim! Eles tem uma documentação bem razoável e com vários exemplos para diversas linguagens.
            </p>
            <p>
                <a class="btn btn-default" href="http://wiki.mikrotik.com/wiki/API_in_C_Sharp" target="_blank">Dê um saque &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Cadê os exemplos?</h2>
            <p>
                Vamos nessa! Clique aí e veja o que tem para hoje.
            </p>
            <p>
                <a runat="server" class="btn btn-default" href="~/Exemplos/Inicio">Me ajude! &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
