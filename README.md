# 📌 API REST em ASP.NET Core com SQL Server

## 📖 Descrição
API REST desenvolvida com o framework **ASP.NET Core**, utilizando a linguagem **C#** na plataforma **.NET** e o **Microsoft SQL Server** como SGBD.  
O projeto foi implementado na IDE **Visual Studio Code (VS Code)**.  

A API possui duas controllers principais:

- **ContatoController** → realiza o gerenciamento da tabela **Contatos**, implementando operações **CRUD** (Create, Read, Update, Delete) sobre os registros da tabela, que possui as colunas:  
  - **Id** (chave primária)  
  - **Nome** (texto)  
  - **Telefone** (texto)  
  - **Ativo** (booleano)  

- **UsuarioController** → fornece endpoints de demonstração e utilidade, sem acesso a banco de dados (não possui tabela associada).  

---

## 🛠️ Stack Tecnológico
- ASP.NET Core  
- C# / .NET  
- Entity Framework Core  
- Microsoft SQL Server  
- Swagger (Swashbuckle)  
- Visual Studio Code (VS Code)  

---

## ⚙️ Configuração
1. Clone este repositório:
   ```bash
   git clone https://github.com/JandersonArantes/2026-01-28-csharp-api-crud-tabela-contatos.git

# 🚀 Endpoints Disponíveis

## ContatoController
- **POST** → cria um novo contato  
- **GET** → lista todos os contatos  
- **GET** → obtém um contato específico pelo Id  
- **GET** → obtém contatos filtrando pelo Nome  
- **PUT** → atualiza um contato existente  
- **DELETE** → remove um contato  

## UsuarioController
- **GET** → retorna a data e hora atuais  
- **GET** → retorna uma mensagem de apresentação personalizada

## 🔎 Diferença entre as Controllers

### ContatoController
A **ContatoController** está diretamente ligada ao banco de dados **SQL Server** através do **Entity Framework Core**.  
Ela implementa operações **CRUD** (Create, Read, Update, Delete) sobre a tabela **Contatos**, manipulando registros que possuem os campos:
- Id  
- Nome  
- Telefone  
- Ativo  

Ou seja, cada requisição feita a esta controller resulta em operações de **persistência** (inserção, consulta, atualização ou exclusão) no banco de dados.

### UsuarioController
A **UsuarioController** não possui ligação com banco de dados e não tem tabela associada.  
Seus endpoints são **utilitários**, retornando informações calculadas em tempo de execução, como:
- Data e hora atuais (`ObterDataHoraAtual`)  
- Mensagem de apresentação personalizada (`Apresentar/{nome}`)  

Portanto, a `UsuarioController` **não possui persistência**, pois não realiza operações de leitura ou escrita em banco de dados.  
Ela serve como exemplo de endpoints que fornecem lógica de negócio simples sem necessidade de armazenamento.

## ✅ Objetivo
Este projeto foi desenvolvido para demonstrar conhecimentos em **ASP.NET Core**, **C#**, **Entity Framework Core** e **SQL Server**, além de boas práticas de documentação com **Swagger**.  

Serve como **portfólio** para oportunidades profissionais na área de desenvolvimento **.NET**, mostrando tanto:  
- Integração com banco de dados (**ContatoController**)  
- Endpoints utilitários sem persistência (**UsuarioController**)  
