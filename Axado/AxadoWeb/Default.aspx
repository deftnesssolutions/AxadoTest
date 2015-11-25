<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AxadoWeb.Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Control de Transportadora - Axado Test </title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
    <div class="conteudo">
        <table width="100%" cellpadding="0px" cellspacing="0px">
            <tr>
                <td>
                    <asp:Image ID="Image1" ImageUrl="~/images/bannerbase.jpg" runat="server" />
                </td>
            </tr>
        </table>
        <table width="100%" style="background-color: #cfcfcf;" border="0">
            <tr height="80px">
               
            </tr>
        </table>
        <%--<h1>Anuncie gratuitamente na Tudo Anúncios!</h1>
        <p>Na <strong>Tudo Anúncios</strong> você pode comprar ou vender tudo o que desejar. Aqui você <strong>anuncia de graça</strong> o seu imóvel, carro ou até mesmo o seu cachorro!</p>--%>
        <br />
        <div align="center">
            <table width="100%" border="0" cellpadding="0" cellspacing="0">
                <tr valign="top">
                    <td>
                       
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
