<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AxadoWeb.Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title> Control de Transportadoras - Axado Test </title>
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
