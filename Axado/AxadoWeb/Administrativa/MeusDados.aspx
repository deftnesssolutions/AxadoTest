<%@ Page Title="" Language="C#" MasterPageFile="~/Administrativa/Administrativa.Master" AutoEventWireup="true" CodeBehind="MeusDados.aspx.cs" Inherits="AxadoWeb.Administrativa.MeusDados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        var linkMenu = "meusDados";
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="conteudo">
        <table width="100%" style="background-color: #cfcfcf;" border="0">
            <tr height="80px">
                <td style="padding-left: 10px; color: #006cac;">
                    <h1>
                        Meus Dados
                    </h1>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <div style="padding-left: 40px; padding-right: 40px;">
            <h2>
                Alterar Senha</h2>
            <br />
            <br />
            <br />
            <asp:ChangePassword ID="ChangeUserPassword" runat="server" CancelDestinationPageUrl="~/"
                EnableViewState="false" RenderOuterTable="false">
                <ChangePasswordTemplate>
                    <%--<asp:ValidationSummary ID="ChangeUserPasswordValidationSummary" runat="server" CssClass="failureNotification" 
                 ValidationGroup="ChangeUserPasswordValidationGroup"/>--%>
                    <div class="accountInfo">
                        <fieldset class="changePassword">
                            <legend>Informações da Conta</legend>
                            <p>
                                <asp:Label ID="CurrentPasswordLabel" runat="server" AssociatedControlID="CurrentPassword">Senha Atual:</asp:Label>
                                <asp:TextBox ID="CurrentPassword" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="CurrentPasswordRequired" runat="server" ControlToValidate="CurrentPassword"
                                    CssClass="failureNotification" ErrorMessage="Password is required." ToolTip="Old Password is required."
                                    ValidationGroup="ChangeUserPasswordValidationGroup">*</asp:RequiredFieldValidator>
                            </p>
                            <p>
                                <asp:Label ID="NewPasswordLabel" runat="server" AssociatedControlID="NewPassword">Nova Senha:</asp:Label>
                                <asp:TextBox ID="NewPassword" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="NewPasswordRequired" runat="server" ControlToValidate="NewPassword"
                                    CssClass="failureNotification" ErrorMessage="New Password is required." ToolTip="New Password is required."
                                    ValidationGroup="ChangeUserPasswordValidationGroup">*</asp:RequiredFieldValidator>
                            </p>
                            <p>
                                <asp:Label ID="ConfirmNewPasswordLabel" runat="server" AssociatedControlID="ConfirmNewPassword">Confirme a Nova Senha:</asp:Label>
                                <asp:TextBox ID="ConfirmNewPassword" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="ConfirmNewPasswordRequired" runat="server" ControlToValidate="ConfirmNewPassword"
                                    CssClass="failureNotification" Display="Dynamic" ErrorMessage="Confirm New Password is required."
                                    ToolTip="Confirm New Password is required." ValidationGroup="ChangeUserPasswordValidationGroup">*</asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="NewPasswordCompare" runat="server" ControlToCompare="NewPassword"
                                    ControlToValidate="ConfirmNewPassword" CssClass="failureNotification" Display="Dynamic"
                                    ErrorMessage="The Confirm New Password must match the New Password entry." ValidationGroup="ChangeUserPasswordValidationGroup">Senha não confirmada.</asp:CompareValidator>
                            </p>
                        </fieldset>
                        <p class="submitButton" align="center">
                            <%--<asp:Button ID="CancelPushButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel"/>--%>
                            <asp:Button ID="ChangePasswordPushButton" runat="server" CommandName="ChangePassword"
                                Text="Alterar" CssClass="buttonCSS" ValidationGroup="ChangeUserPasswordValidationGroup" />
                        </p>
                        <span class="failureNotification">
                            <asp:Literal ID="FailureText" runat="server"></asp:Literal>
                        </span>
                    </div>
                </ChangePasswordTemplate>
                <SuccessTemplate>
                    <p>Sua senha foi alterada com sucesso!</p>
                </SuccessTemplate>
            </asp:ChangePassword>
        </div>
    </div>
</asp:Content>
