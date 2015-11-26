﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="RecuperarSenha.aspx.cs" Inherits="AxadoWeb.RecuperarSenha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="conteudo">
        <table width="100%" style="background-color: #cfcfcf;" border="0">
            <tr height="80px">
                <td style="padding-left: 10px; color: #006cac;">
                    <h1>
                        Recuperação de Senha
                    </h1>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <div style="padding-left: 180px; padding-right: 40px;">
            <table width="650px" cellspacing="20" border="0">
                <tr>
                    <td colspan="2">
                        Uma nova senha será enviada para o seu email. Por favor, digite seu email abaixo:
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        Email:
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnEnviar" runat="server" Text="Enviar" 
                            onclick="btnEnviar_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Label ID="lblResposta" ForeColor="Red" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
