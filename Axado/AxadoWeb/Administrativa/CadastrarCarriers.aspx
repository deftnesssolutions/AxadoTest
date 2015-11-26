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
                        Cadastro de Transportadora
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
                        <asp:DropDownList  ID="ddlCassificacao" runat="server" Width="255px">
                            
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="valCassificacao" ControlToValidate="ddlCassificacao"
                         runat="server" ErrorMessage="*Required" ForeColor="Red" ValidationGroup="Group1" />
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        Tipo Pessoa:
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlTipo" runat="server">
                            <asp:ListItem Value="F">Fisica</asp:ListItem>
                            <asp:ListItem Value="J">Juridica</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        Nome:
                    </td>
                    <td>
                        <asp:TextBox ID="txtDescricao" runat="server" Width="450px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="valDescricao" ControlToValidate="txtDescricao"
                         runat="server" ErrorMessage="*Required" ForeColor="Red" ValidationGroup="Group1" />
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        Endereço:
                    </td>
                    <td>
                        <asp:TextBox ID="txtEndereco" runat="server" Width="450px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="valEndereco" ControlToValidate="txtEndereco"
                         runat="server" ErrorMessage="*Required" ForeColor="Red" ValidationGroup="Group1" />
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        Cidade:
                    </td>
                    <td>
                        <asp:TextBox ID="txtCidade" runat="server" Width="450px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="valCidade" ControlToValidate="txtCidade"
                         runat="server" ErrorMessage="*Required" ForeColor="Red" ValidationGroup="Group1" />
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        Estado:
                    </td>
                    <td>
                        <asp:DropDownList ID="ddluf" runat="server" 
                                CssClass="select50">
                                <asp:ListItem></asp:ListItem>
                                <asp:ListItem>AC</asp:ListItem>
                                <asp:ListItem>AL</asp:ListItem>
                                <asp:ListItem>AM</asp:ListItem>
                                <asp:ListItem>AP</asp:ListItem>
                                <asp:ListItem>BA</asp:ListItem>
                                <asp:ListItem>CE</asp:ListItem>
                                <asp:ListItem>DF</asp:ListItem>
                                <asp:ListItem>ES</asp:ListItem>
                                <asp:ListItem>GO</asp:ListItem>
                                <asp:ListItem>MA</asp:ListItem>
                                <asp:ListItem>MG</asp:ListItem>
                                <asp:ListItem>MS</asp:ListItem>
                                <asp:ListItem>MT</asp:ListItem>
                                <asp:ListItem>PA</asp:ListItem>
                                <asp:ListItem>PB</asp:ListItem>
                                <asp:ListItem>PE</asp:ListItem>
                                <asp:ListItem>PI</asp:ListItem>
                                <asp:ListItem>PR</asp:ListItem>
                                <asp:ListItem>RJ</asp:ListItem>
                                <asp:ListItem>RN</asp:ListItem>
                                <asp:ListItem>RO</asp:ListItem>
                                <asp:ListItem>RR</asp:ListItem>
                                <asp:ListItem>RS</asp:ListItem>
                                <asp:ListItem>SC</asp:ListItem>
                                <asp:ListItem>SE</asp:ListItem>
                                <asp:ListItem>SP</asp:ListItem>
                                <asp:ListItem>TO</asp:ListItem>
                    </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="valddluf" ControlToValidate="ddluf"
                         runat="server" ErrorMessage="*Required" ForeColor="Red" ValidationGroup="Group1" />
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        CPF/CNPJ:

                    </td>
                    <td>
                        <asp:TextBox ID="txtcpfcnpj" runat="server" Width="200px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="valtxtcpfcnpj" ControlToValidate="txtcpfcnpj"
                         runat="server" ErrorMessage="*Required" ForeColor="Red" ValidationGroup="Group1" />
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        Inscrição Estadual:
                    </td>
                    <td>
                        <asp:TextBox ID="txtInscr_estadual" runat="server" Width="200px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="valtxtInscr_estadual" ControlToValidate="txtInscr_estadual"
                         runat="server" ErrorMessage="*Required" ForeColor="Red" ValidationGroup="Group1" />
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        Placa Vehiculo:
                    </td>
                    <td>
                        <asp:TextBox ID="txtPlaca" runat="server" Width="200px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="valtxtPlaca" ControlToValidate="txtPlaca"
                         runat="server" ErrorMessage="*Required" ForeColor="Red" ValidationGroup="Group1" />
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        Placa Estado:
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlEstadoPlaca" runat="server" 
                                CssClass="select50">
                                <asp:ListItem></asp:ListItem>
                                <asp:ListItem>AC</asp:ListItem>
                                <asp:ListItem>AL</asp:ListItem>
                                <asp:ListItem>AM</asp:ListItem>
                                <asp:ListItem>AP</asp:ListItem>
                                <asp:ListItem>BA</asp:ListItem>
                                <asp:ListItem>CE</asp:ListItem>
                                <asp:ListItem>DF</asp:ListItem>
                                <asp:ListItem>ES</asp:ListItem>
                                <asp:ListItem>GO</asp:ListItem>
                                <asp:ListItem>MA</asp:ListItem>
                                <asp:ListItem>MG</asp:ListItem>
                                <asp:ListItem>MS</asp:ListItem>
                                <asp:ListItem>MT</asp:ListItem>
                                <asp:ListItem>PA</asp:ListItem>
                                <asp:ListItem>PB</asp:ListItem>
                                <asp:ListItem>PE</asp:ListItem>
                                <asp:ListItem>PI</asp:ListItem>
                                <asp:ListItem>PR</asp:ListItem>
                                <asp:ListItem>RJ</asp:ListItem>
                                <asp:ListItem>RN</asp:ListItem>
                                <asp:ListItem>RO</asp:ListItem>
                                <asp:ListItem>RR</asp:ListItem>
                                <asp:ListItem>RS</asp:ListItem>
                                <asp:ListItem>SC</asp:ListItem>
                                <asp:ListItem>SE</asp:ListItem>
                                <asp:ListItem>SP</asp:ListItem>
                                <asp:ListItem>TO</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="valddlEstadoPlaca" ControlToValidate="ddlEstadoPlaca"
                         runat="server" ErrorMessage="*Required" ForeColor="Red" ValidationGroup="Group1" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnAdicionar" CssClass="buttonCSS"  runat="server" 
                            Text="Adicionar" ValidationGroup="Group1" onclick="btnAdicionar_Click"  />
                        <asp:Button ID="btnModificar" CssClass="buttonCSS"  runat="server" 
                            Text="Consultar/Editar Dados " onclick="btnModificar_Click" />
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
