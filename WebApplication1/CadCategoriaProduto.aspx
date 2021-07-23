<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CadCategoriaProduto.aspx.cs" Inherits="WebApplication1.CadCategoriaProduto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="Content/Loading.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
    <script src="scripts/jquery-1.10.2.min.js"></script>
    <script src="scripts/principal.js"></script>
    <script src="scripts/jquery-1.10.2.min.js"></script>
    <link href="Content/EventosCadastrados.css" rel="stylesheet" />


    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="True">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

            <h3>Cadastrar Categoria De Produtos</h3>
            <hr />

            <div>
                <table>
                    <tr>
                        <td><span style="margin-left: 17px;">Descriçao</span></td>
                        <td>
                            <asp:TextBox ID="txtDescricao" runat="server" CssClass="form-control" Style="width: 285px;" />
                        </td>
                    </tr>
                </table>
                <br />
                <asp:Button Text="Cadastrar" ID="btnCadastrar" runat="server" CssClass="btn btn-primary" Style="margin-left: 20px;" OnClick="btnCadastrar_Click" />
            </div>

            <br />
            <br />
            <br />
            <br />
            <br />
            <br />

            <div style="height: 400px;">
                <div style="overflow: auto; overflow-x: hidden; height: 400px; float: left; margin-left: 1px; margin-top: 5px;">
                </div>
            </div>
            <div>
            </div>

        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:UpdateProgress ID="UpdateProgress1" runat="server"
        AssociatedUpdatePanelID="UpdatePanel1">
        <ProgressTemplate>
            <div id="ImageLoadCadAgend">
                <div class="sk-fading-circle">
                    <div class="sk-circle1 sk-circle"></div>
                    <div class="sk-circle2 sk-circle"></div>
                    <div class="sk-circle3 sk-circle"></div>
                    <div class="sk-circle4 sk-circle"></div>
                    <div class="sk-circle5 sk-circle"></div>
                    <div class="sk-circle6 sk-circle"></div>
                    <div class="sk-circle7 sk-circle"></div>
                    <div class="sk-circle8 sk-circle"></div>
                    <div class="sk-circle9 sk-circle"></div>
                    <div class="sk-circle10 sk-circle"></div>
                    <div class="sk-circle11 sk-circle"></div>
                    <div class="sk-circle12 sk-circle"></div>
                </div>
            </div>
        </ProgressTemplate>
    </asp:UpdateProgress>


</asp:Content>
