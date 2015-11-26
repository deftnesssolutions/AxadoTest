<%@ Page Title="" Language="C#" MasterPageFile="~/Administrativa/Administrativa.Master" AutoEventWireup="true" CodeBehind="ConsultarCarriers.aspx.cs" Inherits="AxadoWeb.Administrativa.ConsultarCarriers" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
    <div class="conteudo">
        <table width="100%" style="background-color: #cfcfcf;" border="0">
            <tr height="80px">
                <td width="450px" style="padding-left: 10px">
                    <asp:TextBox ID="txtBusca" CssClass="unwatermarked" onkeyup="buscar()" runat="server"></asp:TextBox>
                    <asp:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1" WatermarkText="Digite o produto, marca ou modelo"
                        WatermarkCssClass="watermarked" TargetControlID="txtBusca" runat="server">
                    </asp:TextBoxWatermarkExtender>
                </td>
                <td width="100px">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:Button ID="btnPesquisa" CssClass="buttonCSS" runat="server" Text="Pesquisar"
                                OnClick="btnPesquisa_Click" />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
                
            </tr>
        </table>
        <br />
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <asp:Label ID="lblContador" CssClass="text8" runat="server"></asp:Label>
                <div align="right">
                    <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1" PageSize="7">
                        <Fields>
                            <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False"
                                ShowPreviousPageButton="False" />
                            <asp:NumericPagerField />
                            <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False"
                                ShowPreviousPageButton="False" />
                        </Fields>
                    </asp:DataPager>
                </div>
                <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" >
                    <LayoutTemplate>
                <table width="100%" id="tableListView" runat="server" style="padding: 0px; margin: 0px"
                    border="0" cellpadding="0" cellspacing="0">
                    <tr id="Tr1" runat="server" style="background-color: #0fb7d1; color: White; font-weight: bold;"
                        align="center">
                        <td style="border: 1px solid white;">
                        </td>
                        <td width="25px" style="padding-top: 7px; padding-bottom: 7px; border: 1px solid white;">
                            ID
                        </td>
                        <td style="border: 1px solid white;">
                            Class.                        
                        </td>
                        <td style="border: 1px solid white;">
                            Tipo
                        </td>
                        <td style="border: 1px solid white;">
                            Nome
                        </td>
                        <td style="border: 1px solid white;">
                            Endereço
                        </td>
                        <td style="border: 1px solid white;">
                            Cidade
                        </td>
                        <td style="border: 1px solid white;">
                            UF
                        </td>
                        <td style="border: 1px solid white;">
                            CPF /CNPJ
                        </td>
                        <td style="border: 1px solid white;">
                            Inscr. Estadual
                        </td>
                        <td style="border: 1px solid white;">
                           Placa Nro
                        </td>
                        <td style="border: 1px solid white;">
                            UF /Placa
                        </td>
                    </tr>
                    <tr id="itemPlaceholder" runat="server">
                    </tr>
                </table>
            </LayoutTemplate>
                    <ItemTemplate>
                <tr style="background-color: #ffffff; padding-top: 15px;">
                    <td style="padding-left: 10px;">
                        <asp:LinkButton ID="LinkButton1" PostBackUrl='<%# "~/Administrativa/EditarCarriers.aspx?ID=" + Eval("id_carrier") %>'
                            CssClass="smallButtonCSS" runat="server">Editar</asp:LinkButton>
                    </td>
                    <td style="padding-left: 10px;">
                        <b>
                            <strong><%# Eval("id_carrier")%></strong>
                        </b>
                    </td>
                    
                    <td style="padding-left: 10px;">
                        <b>
                            <strong><%# Eval("tipo")%></strong>
                        </b>
                    </td>
                    <td style="padding-left: 10px;">
                        <strong><%# Eval("tipo_pessoa")%></strong>
                    </td>
                    <td style="padding-left: 60px;">
                        
                            <strong><%# Eval("nome")%></strong>
                       
                    </td>
                    <td style="padding-left: 60px;">
                       
                            <strong><%# Eval("endereco")%></strong>
                       
                    </td>
                    <td style="padding-left: 60px;">
                        
                            <strong><%# Eval("cidade")%></strong>
                        
                    </td>
                    <td style="padding-left: 10px;">
                        <b>
                            <strong><%# Eval("estado")%></strong>
                        </b>
                    </td>
                    <td style="padding-left: 30px;">
                        
                            <strong><%# Eval("cpf")%></strong>
                        
                    </td>
                    <td style="padding-left: 20px;">
                       
                            <strong><%# Eval("inscr_estadual")%></strong>
                        
                    </td>
                    <td style="padding-left: 25px;">
                        
                            <strong><%# Eval("nro_placa")%></strong>
                        
                    </td>
                    <td style="padding-left: 10px;">
                        <b>
                            <strong><%# Eval("estado_placa")%></strong>
                        </b>
                    </td>

                </tr>
            </ItemTemplate>
            <AlternatingItemTemplate>
                <tr style="background-color: #ededed; padding-top: 15px;">
                   <td style="padding-left: 10px;">
                        <asp:LinkButton ID="LinkButton1" PostBackUrl='<%# "~/Administrativa/EditarCarriers.aspx?ID=" + Eval("id_carrier") %>'
                            CssClass="smallButtonCSS" runat="server">Editar</asp:LinkButton>
                    </td>
                   <td style="padding-left: 10px;">
                        <b>
                            <strong><%# Eval("id_carrier")%></strong>
                        </b>
                    </td>
                    
                    <td style="padding-left: 10px;">
                        <b>
                            <strong><%# Eval("tipo")%></strong>
                        </b>
                    </td>
                    <td style="padding-left: 10px;">
                        <strong><%# Eval("tipo_pessoa")%></strong>
                    </td>
                    <td style="padding-left: 60px;">
                        
                            <strong><%# Eval("nome")%></strong>
                       
                    </td>
                    <td style="padding-left: 60px;">
                       
                            <strong><%# Eval("endereco")%></strong>
                       
                    </td>
                    <td style="padding-left: 60px;">
                        
                            <strong><%# Eval("cidade")%></strong>
                        
                    </td>
                    <td style="padding-left: 10px;">
                        <b>
                            <strong><%# Eval("estado")%></strong>
                        </b>
                    </td>
                    <td style="padding-left: 30px;">
                        
                            <strong><%# Eval("cpf")%></strong>
                        
                    </td>
                    <td style="padding-left: 20px;">
                       
                            <strong><%# Eval("inscr_estadual")%></strong>
                        
                    </td>
                    <td style="padding-left: 25px;">
                        
                            <strong><%# Eval("nro_placa")%></strong>
                        
                    </td>
                    <td style="padding-left: 10px;">
                        <b>
                            <strong><%# Eval("estado_placa")%></strong>
                        </b>
                    </td>
                </tr>
            </AlternatingItemTemplate>
                    <EmptyDataTemplate>
                        <p align="center">
                            <b>Transportadoras não encontrados.</b></p>
                    </EmptyDataTemplate>
                </asp:ListView>
                
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:connectionString %>" 
                    SelectCommand="BuscarCarrier" SelectCommandType="StoredProcedure">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="txtBusca" Name="texto" PropertyName="Text" 
                            Type="String" DefaultValue="T" />
                    </SelectParameters>
                </asp:SqlDataSource>
                
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>
