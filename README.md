# IntegracaoBrasilApi

## Descrição
Este projeto consiste em uma API desenvolvida para integrar e consumir serviços de diferentes APIs brasileiras, incluindo informações sobre bancos e CEPs.

## Tecnologias Utilizadas
- **ASP.NET Core**: Framework para construção de APIs web.
- **C#**: Linguagem de programação principal.
- **Swagger**: Ferramenta para documentação e teste de APIs.
- **Entity Framework Core**: ORM para mapeamento de dados e acesso ao banco de dados.
- **AutoMapper**: Biblioteca para mapeamento de objetos.
- **Newtonsoft.Json**: Biblioteca para manipulação de JSON.
- **HttpClient**: Classe para requisições HTTP.
- **SQLite**: Banco de dados local para armazenamento de dados.
- **Git**: Controle de versão e integração com repositório remoto no GitHub.

## Funcionalidades
- **Buscar Todos os Bancos**: Endpoint para buscar a lista de todos os bancos disponíveis na Brasil API.
- **Buscar Banco por Código**: Endpoint para buscar informações de um banco específico utilizando seu código.
- **CEP**: Consulta de endereços por CEP.

## Estrutura do Projeto

O projeto está estruturado da seguinte forma:

- **ApiCrud.csproj**: Projeto principal da API.
- **Data/**: Classes de acesso a dados e configurações do banco de dados.
- **Services/**: Implementações dos serviços para integração com as APIs.
- **Controllers/**: Controllers da API para cada recurso (bancos e CEPs).
- **Models/**: Modelos de dados utilizados na aplicação.
- **Program.cs**: Configuração inicial da aplicação.
- **appsettings.json**: Configurações da aplicação.

## Endpoints

### Buscar Todos os Bancos
- **URL**: `/bancos`
- **Método**: `GET`
- **Resposta**: Lista de bancos

### Buscar Banco por Código
- **URL**: `/bancos/{codigoBanco}`
- **Método**: `GET`
- **Parâmetros**:
  - `codigoBanco` (string): Código do banco a ser buscado.
- **Resposta**: Informações do banco correspondente

### Consultar Endereço por CEP
- **URL**: `/endereco/{cep}`
- **Método**: `GET`
- **Parâmetros**:
  - `cep` (string): CEP do endereço a ser consultado.
- **Resposta**: Informações detalhadas do endereço correspondente ao CEP fornecido.


## Configuração e Execução

### Pré-requisitos
- .NET 8.0 SDK
- SQLite

### Passos para Executar
1. Clone o repositório:
   ```bash
   git clone https://github.com/xxalm/CrudApis.git
   cd IntegracaoBrasilApi
   ```

2. Instale as dependências:
   ```bash
   dotnet restore
   ```

3. Configure o banco de dados e atualize as migrações:
   ```bash
   dotnet ef database update
   ```

4. Execute o projeto
   ```bash
   dotnet run
   ```

5. Acesse a documentação da API via Swagger em:
   ```bash
   http://localhost:5000/swagger/index.html
   ```

## Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests para melhorias e correções.
