<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AxadoWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="conteudo">
        <table width="100%" style="background-color: #cfcfcf;" border="0">
            <tr height="80px">
                <td style="padding-left: 10px; color: #006cac;">
                    <h1>
                       Axado Test - Transportadoras
                    </h1>
                    <br/>
                    <h1>
                        Login
                    </h1>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <div style="padding-left: 160px; padding-right: 40px;">
            <p>
                Por favor, digite seu email e senha.
                <asp:HyperLink ID="RegisterHyperLink" runat="server" NavigateUrl="~/cadastro"
                    EnableViewState="false">Cadastre-se</asp:HyperLink>
                se você ainda não possui uma conta.
            </p>
            <br />
             <asp:Login ID="LoginUser" runat="server" EnableViewState="false" RenderOuterTable="false"
                OnLoggedIn="LoginUser_LoggedIn" OnAuthenticate="LoginUser_Authenticate">
                <LayoutTemplate>
                    <span class="failureNotification">
                        <asp:Literal ID="FailureText" runat="server"></asp:Literal>
                    </span>
                    <asp:ValidationSummary ID="LoginUserValidationSummary" runat="server" CssClass="failureNotification"
                        ValidationGroup="LoginUserValidationGroup" />
                    <div class="accountInfo" style="width: 600px;">
                        <fieldset class="login">
                            <legend>Informações da Conta</legend>
                            <p>
                                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName"><b>Email:&nbsp;&nbsp;</b></asp:Label>
                                <asp:TextBox ID="UserName" runat="server" Width="300px" CssClass="textEntry"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName"
                                    CssClass="failureNotification" ErrorMessage="User Name is required." ToolTip="User Name is required."
                                    ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                            </p>
                            <p>
                                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password"><b>Senha:</b></asp:Label>
                                <asp:TextBox ID="Password" Width="300px" runat="server" CssClass="passwordEntry"
                                    TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password"
                                    CssClass="failureNotification" ErrorMessage="Password is required." ToolTip="Password is required."
                                    ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                            </p>
                            <p>
                                <asp:CheckBox ID="RememberMe" runat="server" />
                                <asp:Label ID="RememberMeLabel" runat="server" AssociatedControlID="RememberMe" CssClass="inline">Mantenha-me logado</asp:Label>
                            </p>
                            <p align="center">
                                <asp:HyperLink ID="HyperLink1" NavigateUrl="~/RecuperarSenha.aspx" runat="server">Esqueci minha senha</asp:HyperLink>
                            </p>
                        </fieldset>
                        <br />
                        <p class="submitButton" align="center">
                            <asp:Button ID="LoginButton" runat="server" CssClass="buttonCSS" CommandName="Login"
                                Text="Login" ValidationGroup="LoginUserValidationGroup" />
                        </p>
                    </div>
                </LayoutTemplate>
            </asp:Login>
        </div>
    </div>
    
</asp:Content>
