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
	
