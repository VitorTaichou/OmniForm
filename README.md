# Bemol Registo
Sistema de Cadastro feito em ASP.NET Core e Entity Framework + Identity.
Desafio Etapa 2 Software Engineer.

## Requisitos:
* Plataforma Windows 64x ou 86x.
* .NET Core 3.1 - [Downloads Oficiais do .NET](https://dotnet.microsoft.com/download) - Apenas .Net Core Runtime necessário.
* SQL Server 2019 - [Downloads Oficiais do SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) - Pode ser utilizada versão SQL Express.

## Guia de Instalação:
1. Faça o download do arquivo compactado compatível com sua versão do Windows (64x ou 86x) na página de [Releases](https://github.com/VitorTaichou/OmniForm/releases).
2. Extraia os arquivos na pasta que desejar.
3. Execute o arquivo **BemolRegistro.exe** e aguarde o projeto iniciar completamente, uma série de mensagens indicam que o sistema já está pronto para acesso:
    ```
    info: Microsoft.Hosting.Lifetime[0]
          Now listening on: http://localhost:5000
    info: Microsoft.Hosting.Lifetime[0]
          Now listening on: https://localhost:5001
    info: Microsoft.Hosting.Lifetime[0]
          Application started. Press Ctrl+C to shut down.
    ```
4. Após estas mensagens, basta acessar pelo navegador de preferência o endereço http://localhost:5000, lembrando de não encerrar a janela do Prompt de Comando que foi aberta.

## Realizando um Cadastro:
1. Com o sistema aberto no navegador através do link http://localhost:5000, clique em **Cadastro** na barra de navegação.
2. Preencha as informações solicitadas no formulário. Informações de endereço serão preenchidas conforme CEP.
3. Após concluir o preenchimento do formulário, clique no botão **Cadastrar**. Caso algum erro ocorra, será apresentado na tela, basta corrigir e clicar novamente em **Cadastrar**.
4. Com o cadastro concluído com sucesso, a página será redirecionada para a a página principal, onde serão mostradas as informações que foram preenchidas no momento do cadastro.

## Observações:
* O sistema utiliza a autenticação do usuário do Windows conectado no momento para acessar o banco de dados. Caso queira modificar a string de conexão para algum usuário específico, pode acessar o arquivo **appsettings.json** localizado na pasta onde foi extraído o sistema e alterar a string de conexão. Pode ser seguido o seguinte modelo:

    ```Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;``` 

* Caso queira desconectar sua conta, basta clicar em **Sair** na barra de navegação.
* Quando nenhum usuário está conectado, a opção **Login** aparece no topo da página, permitindo fazer login com uma conta já cadastrada, utilizando e-mail e senha.
* O nome inicial do sistema era OmniForm, mas para se encaixar melhor nos produtos da Bemol, o nome da aplicação foi mudado para **Bemol Registro**.
