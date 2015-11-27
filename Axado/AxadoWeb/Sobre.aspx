<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Sobre.aspx.cs" Inherits="AxadoWeb.Sobre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        var linkMenu = "sobre";
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="conteudo">
        <table width="100%" style="background-color: #cfcfcf;" border="0">
            <tr height="80px">
                <td style="padding-left: 10px;color:#006cac;">
                    <h1>
                        A Empresa
                    </h1>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <div style="padding-left: 40px; padding-right: px;">
            <h4>
                Aplicativo Web de Test da Axado Company</h4>
            <p>
                Este aplicativo fue desarrallodo por el Profesor Gustavo Ovelar</p>
            <h4>
                Como funciona?</h4>
            <p>
                A pedido da Axado Company solamente tiene fue desarrollado dos CRUD, uno para Carriers y otro para la Clasificacíon de Carrier
                El aplicativo es de lo simples en quanto a lo que hace, mas la estructura en lo que fue desarrollado mantiene um padron de projecto
                bien bien complejo y completo tatalmente orientado a objeto y preparado para alvergar varios projectos diferentes como DESKTOP, MOVIL, entre otros 
                permitiendo la optimisación recursos y la re-utilización de codigos
                
                </p>
            <h4>
                El uso es de lo mas simples tambien, basta con cadastrarse en el sistema y tendas acceso la parte admistrativa donde
                podras cadastrar transportadoras y sus respectivas clasificaciones
                
                ### PROJETO AXADO TEST  ####
O projeto foi desenvoldo em Visual Studio 2010 
Framework64\v4.0.30319

Asp Net C# com sistema de login utilizando memberShip nativo do asp net

PARA RODAR O PROJETO É NESCESARIO REALIZAR OS SIGUIENTES

instalar ou ter instalado pelo menos o Visual Studio express 2010

Instalar ou ter instalado SQL SERVER
	no meu caso SQL Server 2008 Express
	
Criar o Banaco de Dados com o nome "axadotest"

Para criar em forma automatica estructuras para o sistema de login usando MemberShip
é necessario siguir os sgtes:
- abrir o prompt de comando do windows
- acessar no siguiente endereco
	cd C:\Windows\Microsoft.NET\Framework64\v4.0.30319
 	e executar o executable "aspnet_regsql.exe"
Esto ir a adicionar em nosso banco tadas as tabelas o procedure referente ao controle de usuaro do proprio aspnet

Uma vez feito esso, no projeto tem um DATA MODEL llamado Model1 onde tem a duas tabelas adicionais 
apartir de ahi pode ser adicionado ao banco tanto em forma automatica ou manualmente

Cumpliendo com esos requisitos o projeto pode rodar traquilamente, 
basta se loguear no sistema para explorar o aplicativo
Varias funcionalidades não esta funcionando ao 100% salvo os os dos puntos como o CRUD de Carriers e Classificação de Carriers
                </h4>
            <p>
                Duda y aclaracios com mil gusto al 67 93081363 o al e-mail gusove@gmail.com</p>
        </div>
    </div>
</asp:Content>
