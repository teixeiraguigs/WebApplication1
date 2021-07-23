<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="BuscaProdutos.aspx.cs" Inherits="WebApplication1.BuscaProdutos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="Content/Loading.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
    <script src="scripts/jquery-1.10.2.min.js"></script>
    <link href="Content/EventosCadastrados.css" rel="stylesheet" />


    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="True">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

            <h3>Buscar Produtos</h3>
            <hr />

            <div class="painelBusca">
                <span style="margin-left: 17px;">Nome</span>
                <span style="margin-left: 41px;">Ano</span>
                <span style="margin-left: 38px;">Categoria</span>
                <br />
                <asp:TextBox runat="server" ID="txtProduto" CssClass="form-control" Width="279px" />
                <asp:DropDownList runat="server" ID="ddlCategoria" CssClass="form-control" Style="width: 125px;" >
                </asp:DropDownList>
                <asp:Button Text="PESQUISAR" ID="btnPesquisar" runat="server" CssClass="btn btn-primary" Style="margin-left: 20px;" />
            </div>



            <div style="height: 400px;">
                <table class="TabHeader">
                    <tr>
                        <td style="width: 80px;"><a href="#">Descrição</a></td>
                        <td style="width: 205px;"><a href="#">Categoria</a></td>
                        <td style="width: 65px;"><a href="#">Valor</a></td>
                    </tr>
                </table>
                <div style="overflow: auto; overflow-x: hidden; height: 400px; float: left; margin-left: 1px; margin-top: 5px;">
                    <asp:GridView ID="gridProdutos" runat="server" CssClass="mGrid" AutoGenerateColumns="False" ShowHeader="False" Width="720px">
                        <Columns>
                            <asp:BoundField HeaderText="Descricao" DataField="Descricao">
                                <ItemStyle Width="60" Wrap="true" HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="Categoria" DataField="Categoria">
                                <ItemStyle Width="250px" Wrap="true" HorizontalAlign="Right" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="Valor" DataField="Valor">
                                <ItemStyle Width="75px" Wrap="true" HorizontalAlign="Right" />
                            </asp:BoundField>

                        </Columns>

                        <SelectedRowStyle CssClass="select" />
                    </asp:GridView>

                </div>
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
