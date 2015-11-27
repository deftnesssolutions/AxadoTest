<%@ Page Title="" Language="C#" MasterPageFile="~/Administrativa/Administrativa.Master" AutoEventWireup="true" CodeBehind="ConsultarClassificacao.aspx.cs" Inherits="AxadoWeb.Administrativa.ConsultarClassificacao" %>

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
                    <asp:TextBox ID="txtBusca" CssClass="unwatermarked"  runat="server"></asp:TextBox>
                    <asp:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1" WatermarkText="Digite o nome, cidade ou estado"
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
                <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" 
                    onitemdatabound="ListView1_ItemDataBound" DataKeyNames="id_classificacao"  >
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
                            Tipo
                        </td>
                        <td style="border: 1px solid white;">
                            Descrição
                        </td>
                        
                    </tr>
                    <tr id="itemPlaceholder" runat="server">
                    </tr>
                </table>
            </LayoutTemplate>
                    <ItemTemplate>
                  
                <tr style="background-color: #ffffff; padding-top: 15px;">
                     <td style="padding-left: 30px;">
                       <table>
                        <tr>
                            <td>
                                <asp:LinkButton ID="LinkButton1" PostBackUrl='<%# "~/Administrativa/EditarClassificacaoCarrier.aspx?ID=" + Eval("id_classificacao") %>'
                             runat="server">Editar</asp:LinkButton>    
                            </td>
                            <td>
                                <asp:LinkButton ID="LinkButton3" 
                             runat="server" CommandName="Delete">Eliminar</asp:LinkButton>   
                            </td>
                        </tr>
                      </table>
                    </td>
                    <td style="padding-left: 10px;">
                        <b>
                            <strong><%# Eval("id_classificacao")%></strong>
                        </b>
                    </td>
                    
                    <td style="padding-left: 10px;">
                        <b>
                            <strong><%# Eval("tipo")%></strong>
                        </b>
                    </td>
                   
                    <td  style="padding-left: 10px; ">
                        
                            <strong><%# Eval("descricao")%></strong>
                       
                    </td>
                    
                </tr>
            </ItemTemplate>
            <AlternatingItemTemplate>
                <tr style="background-color: #ededed; padding-top: 15px;">
                   <td style="padding-left: 30px;">
                      <table>
                        <tr>
                            <td>
                                <asp:LinkButton ID="LinkButton1" PostBackUrl='<%# "~/Administrativa/EditarClassificacaoCarrier.aspx?ID=" + Eval("id_classificacao") %>'
                             runat="server">Editar</asp:LinkButton>    
                            </td>
                            <td>
                                <asp:LinkButton ID="LinkButton3" 
                             runat="server" CommandName="Delete">Eliminar</asp:LinkButton>   
                            </td>
                        </tr>
                      </table>
                      
                    </td>
                   <td style="padding-left: 10px;">
                        <b>
                            <strong><%# Eval("id_classificacao")%></strong>
                        </b>
                    </td>
                    
                    <td style="padding-left: 10px;">
                        <b>
                            <strong><%# Eval("tipo")%></strong>
                        </b>
                    </td>
                   
                    <td style="padding-left: 10px;">
                        
                            <strong><%# Eval("descricao")%></strong>
                       
                    </td>
                </tr>
            </AlternatingItemTemplate>
                    <EmptyDataTemplate>
                        <p align="center">
                            <b>Classificação não encontrados.</b></p>
                    </EmptyDataTemplate>
                </asp:ListView>
                
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:connectionString %>" 
                    SelectCommand="BuscarClassificacaoCarrier" SelectCommandType="StoredProcedure" DeleteCommand="DELETE FROM classificacao_carriers WHERE id_classificacao=@id_classificacao">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="txtBusca" Name="texto" PropertyName="Text" 
                            Type="String" DefaultValue="T" />
                    </SelectParameters>
                </asp:SqlDataSource>
                
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>
