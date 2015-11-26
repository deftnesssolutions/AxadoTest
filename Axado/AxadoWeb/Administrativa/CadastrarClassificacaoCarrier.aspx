<%@ Page Title="" Language="C#" MasterPageFile="~/Administrativa/Administrativa.Master" AutoEventWireup="true" CodeBehind="CadastrarClassificacaoCarrier.aspx.cs" Inherits="AxadoWeb.Administrativa.CadastrarClassificacaoCarrier" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        var linkMenu = "classificacao";
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="conteudo">
        <table width="100%" style="background-color: #cfcfcf;" border="0">
            <tr height="80px">
                <td style="padding-left: 10px; color: #006cac;">
                    <h1>
                        Classificação de Transportadora
                    </h1>
                </td>
            </tr>
        </table>
        <br />
        <div style="padding-left: 210px; padding-right: 40px;">
            <table width="550px" cellspacing="20">
                <tr>
                    <td align="right">
                        Tipo:
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlTipo" runat="server">
                            <asp:ListItem Value="A">A</asp:ListItem>
                            <asp:ListItem Value="B">B</asp:ListItem>
                            <asp:ListItem Value="C">C</asp:ListItem>
                            <asp:ListItem Value="D">D</asp:ListItem>
                            <asp:ListItem Value="E">E</asp:ListItem>
                            <asp:ListItem Value="F">F</asp:ListItem>

                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        Descrição:
                    </td>
                    <td>
                    <asp:TextBox ID="txtDescricao" TextMode="MultiLine" runat="server" Width="450px"></asp:TextBox>
                    </td>
                </tr>
                
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnAdicionar" CssClass="buttonCSS"  runat="server" 
                            Text="Adicionar" onclick="btnAdicionar_Click"  />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Label ID="lblMsg" runat="server" ></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
