# 5_Integracao_Entre_APIs-Azure_SQL
Projeto usado na aula 5 da disciplina ARQUITETURA DE BANCO DE DADOS E PERSISTÊNCIA da turma 2NETR - FIAP

# Serviço de Endereço

O Serviço de Endereço é uma API ASP.NET Core que fornece endpoints para manipulação de informações de endereço. Este serviço permite que os clientes recuperem informações detalhadas sobre endereços e é construído usando .NET 8 e Entity Framework Core.

## Funcionalidades Principais

- Fornecer endpoints para CRUD (Create, Read, Update, Delete) de endereços.
- Integração com banco de dados Azure SQL para armazenamento de dados.
- Utilização de tecnologias modernas como ASP.NET Core e Entity Framework Core.

## Endpoints Disponíveis

- `GET /api/addresses`: Retorna todos os endereços.
- `GET /api/addresses/{id}`: Retorna um endereço específico pelo ID.

## Configuração do Projeto

1. Clone o repositório para o seu ambiente local:

git clone [https://github.com/seu-usuario/AddressService.git](https://github.com/LucasSebrian/5_Integracao_Entre_APIs-Azure_SQL.git)

2. Navegue até o diretório do projeto:

cd AddressService

3. Instale as dependências do projeto:

dotnet restore

4. Configuração do Banco de Dados:

   - Abra o arquivo `appsettings.json`.
   - Atualize a string de conexão `AdventureFiap` com os detalhes do seu banco de dados SQL Server no Azure.

## Compilação e Execução

1. Execute o comando abaixo para compilar o projeto:

dotnet build

2. Após a compilação bem-sucedida, inicie o aplicativo com o seguinte comando:

dotnet run

O serviço estará disponível em http://localhost:5196/swagger/index.html por padrão.

## Tecnologias Utilizadas

- Entity Framework Core
- .NET 8


## SwaggerGen

![image](https://github.com/LucasSebrian/5_Integracao_Entre_APIs-Azure_SQL/assets/40295405/219576ba-9b72-4be2-b917-7009761073f1)

![image](https://github.com/LucasSebrian/5_Integracao_Entre_APIs-Azure_SQL/assets/40295405/f611d1ed-4e55-4416-9f6a-e7727bdd5fe5)

## Conexão com o Banco 

![image](https://github.com/LucasSebrian/5_Integracao_Entre_APIs-Azure_SQL/assets/40295405/bf7765fe-02c4-4907-aca1-5e8ed7bd0268)
