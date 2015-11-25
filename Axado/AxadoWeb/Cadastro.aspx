<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="AxadoWeb.Cadastro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="conteudo">
        <table width="100%" style="background-color: #cfcfcf;" border="0">
            <tr height="80px">
                <td style="padding-left: 10px; color: #006cac;">
                    <h1>
                        Cadastro
                    </h1>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <div style="padding-left: 220px; padding-right: 40px;">
            <asp:CreateUserWizard ID="RegisterUser" runat="server" EnableViewState="false" OnCreatedUser="RegisterUser_CreatedUser" >
                <LayoutTemplate>
                    <asp:PlaceHolder ID="wizardStepPlaceholder" runat="server"></asp:PlaceHolder>
                    <asp:PlaceHolder ID="navigationPlaceholder" runat="server"></asp:PlaceHolder>
                </LayoutTemplate>
                <WizardSteps>
                    <asp:CreateUserWizardStep ID="RegisterUserWizardStep" runat="server">
                        <ContentTemplate>
                            <p>
                                Por favor, preencha o formulário abaixo.
                            </p>
                            <br />
                            <span class="failureNotification">
                                <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
                            </span>
                            <asp:ValidationSummary ID="RegisterUserValidationSummary" runat="server" CssClass="failureNotification"
                                ValidationGroup="RegisterUserValidationGroup" />
                            <div class="accountInfo" style="width: 500px;">
                                <fieldset class="register">
                                    <legend>Informações da Conta</legend>
                                    <p align="right">
                                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName"><b>Nome:</b></asp:Label>
                                        <asp:TextBox ID="UserName" runat="server" Width="300px" CssClass="textEntry"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName"
                                            CssClass="failureNotification" ErrorMessage="User Name is required." ToolTip="User Name is required."
                                            ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                                    </p>
                                    <p align="right">
                                        <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="Email"><b>E-mail:</b></asp:Label>
                                        <asp:TextBox ID="Email" runat="server" Width="300px" CssClass="textEntry"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="Email"
                                            CssClass="failureNotification" ErrorMessage="E-mail is required." ToolTip="E-mail is required."
                                            ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                                    </p>
                                    <p align="right">
                                        <asp:Label ID="Label1" runat="server"><b>Telefone:</b></asp:Label>
                                        <asp:TextBox ID="txtTelefone" runat="server" Width="300px" CssClass="textEntry"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTelefone"
                                            CssClass="failureNotification" ErrorMessage="Telefone é obrigatório." ToolTip="E-mail is required."
                                            ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                                    </p>
                                    <p align="right">
                                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password"><b>Senha:</b></asp:Label>
                                        <asp:TextBox ID="Password" runat="server" Width="300px" CssClass="passwordEntry"
                                            TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password"
                                            CssClass="failureNotification" ErrorMessage="Password is required." ToolTip="Password is required."
                                            ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                                    </p>
                                    <p align="right">
                                        <asp:Label ID="ConfirmPasswordLabel" runat="server" AssociatedControlID="ConfirmPassword"><b>Confirme sua senha:</b></asp:Label>
                                        <asp:TextBox ID="ConfirmPassword" runat="server" Width="300px" CssClass="passwordEntry"
                                            TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator ControlToValidate="ConfirmPassword" CssClass="failureNotification"
                                            Display="Dynamic" ErrorMessage="Confirm Password is required." ID="ConfirmPasswordRequired"
                                            runat="server" ToolTip="Confirm Password is required." ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                                        <asp:CompareValidator ID="PasswordCompare" runat="server" ControlToCompare="Password"
                                            ControlToValidate="ConfirmPassword" CssClass="failureNotification" Display="Dynamic"
                                            ErrorMessage="The Password and Confirmation Password must match." ValidationGroup="RegisterUserValidationGroup">*</asp:CompareValidator>
                                    </p>
                                </fieldset>
                                <br />
                                <p class="submitButton" align="center">
                                    <asp:Button ID="CreateUserButton" runat="server" CommandName="MoveNext" CssClass="buttonCSS"
                                        Text="Cadastrar-se" ValidationGroup="RegisterUserValidationGroup" />
                                </p>
                            </div>
                        </ContentTemplate>
                        <CustomNavigationTemplate>
                        </CustomNavigationTemplate>
                    </asp:CreateUserWizardStep>
                </WizardSteps>
            </asp:CreateUserWizard>
        </div>
    </div>
</asp:Content>
