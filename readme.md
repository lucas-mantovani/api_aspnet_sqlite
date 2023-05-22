# API ASP.NET, EF e SqLite

Esse projeto foi construído utilizando Asp.net, Entity Framework, banco de dados relacional com o SqLite e a ferramenta Postman para testar a API.

## Modelagem:

A API possui a classe tarefa com os seguintes atributos:

###### -- Id (int)
###### -- Title (string)
###### -- Done (bool)
###### -- Date (DateTime)

## Funcionamento

A API se comporta como um sistema para gerenciar tarefas, sendo possível:

- Através do método **GET**, buscar por todas as tarefas presentes no banco de dados e buscar tarefas específicas passando o Id da tarefa através do caminho da URL.

- Através do método **POST**, inserir tarefas dentro do banco de dados passando um título para a tarefa através do corpo da requisição.

- Através do método **PUT**, atualizar tarefas existentes no banco de dados, passando o Id da tarefa através do caminho da URL e o título da tarefa através do corpo da requisição.

- Através do método **DELETE**, deletar tarefas existentes no banco de dados, passando o Id da tarefa através do caminho da URL.

### Instruções:

O banco de dados do projeto é gerado pelo comando "dotnet ef database update" utilizando a migration presente no projeto, caso o banco de dados seja excluído é necessário utilizar o comando para recriar o banco de dados e é necessário inserir novas tarefas.
A URL base utilizada no projeto é: http://localhost:5001/v1/tarefas (exibindo todas as tarefas).

### Execução:

1. **Método GET - Buscar todas as tarefas**:

<img width="900" src="https://firebasestorage.googleapis.com/v0/b/api-aspnet.appspot.com/o/get%20pegar%20todas%20tarefas.gif?alt=media&token=e3566f2a-ef47-4638-ba9a-40a22e4c9774">

2. **Método GET - Buscar uma tarefa pelo Id**:

<img width="900" src="https://firebasestorage.googleapis.com/v0/b/api-aspnet.appspot.com/o/get%20pegar%20uma%20tarefa.gif?alt=media&token=e650ea1a-2aad-405c-be8a-e42af6e9fa82">

3. **Método POST - Inserir uma tarefa**:

<img width="900" src="https://firebasestorage.googleapis.com/v0/b/api-aspnet.appspot.com/o/post.gif?alt=media&token=5db27fbf-434f-414e-809c-d3e440cb1864">

4. **Método PUT - Atualizar uma tarefa**:

<img width="900" src="https://firebasestorage.googleapis.com/v0/b/api-aspnet.appspot.com/o/put.gif?alt=media&token=f9c46d25-8927-4423-94ef-28a97a160aa8">

5. **Método DELETE - Deletar uma tarefa**:

<img width="900" src="https://firebasestorage.googleapis.com/v0/b/api-aspnet.appspot.com/o/delete.gif?alt=media&token=d6747a8f-f08c-4ff2-8615-b5b91c0cf608">

