<%@ Page Title="" Language="C#" MasterPageFile="~/Administrativa/Administrativa.Master" AutoEventWireup="true" CodeBehind="CadastrarCarriers.aspx.cs" Inherits="AxadoWeb.Administrativa.CadastrarCarriers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        var linkMenu = "carriers";
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
                        Classificação:
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlCassificacao" runat="server" Width="255px">
                            
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
                            Text="Adicionar"  />
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
