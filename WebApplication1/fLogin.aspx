<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fLogin.aspx.cs" Inherits="WebApplication1.fLogin" %>
<!DOCTYPE html>
<link href="Content/Loading.css" rel="stylesheet" />
<link href="Content/bootstrap.min.css" rel="stylesheet" />
<script src="scripts/jquery-1.10.2.min.js"></script>
<script src="scripts/principal.js"></script>
<link href="Content/Login.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" autocomplete="off">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="True">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
            <div class="formConteudo">
                <h3 style="margin-left:10px;">Cadastro de Produtos </h3>
                <hr />
    
                <div>
                    <span style="margin-left:30%;">Email</span>
                    <br />
                    <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" style="width:180px; margin-left:30%;" AutoComplete="off" AutoCompleteType="Disabled"/>
                </div>
                <div>
                    <span style="margin-left:30%;">Senha</span>
                    <br />
                    <asp:TextBox runat="server" ID="txtSenha" TextMode="Password" CssClass="form-control" style="width:180px; margin-left:30%;" AutoComplete="off" AutoCompleteType="Disabled"/>
                </div>
                        
                <br />
                
                <div style="margin-left:70px; margin-top:20px;">
                    <asp:Button Text="ENTRAR" ID="btnEntrar" runat="server" CssClass="btn btn-success" style="margin-left:30px;" OnClick="btnEntrar_Click"/>
                </div>                
           
            </div>            
            
            
            </ContentTemplate>
    </asp:UpdatePanel>
    <asp:UpdateProgress ID="UpdateProgress1" runat="server"
        AssociatedUpdatePanelID="UpdatePanel1">
        <ProgressTemplate>
           
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
           
        </ProgressTemplate>
    </asp:UpdateProgress>
    </form>
</body>
</html>
