# 🔥 Avatar API

API REST desenvolvida em **.NET** para gerenciamento de personagens do universo Avatar, com persistência em banco de dados PostgreSQL.

---

## 🚀 Tecnologias utilizadas

* .NET (ASP.NET Core Web API)
* Entity Framework Core
* PostgreSQL
* Swagger (documentação da API)

---

## 📌 Funcionalidades

* ✅ Criar personagem
* ✅ Listar todos os personagens
* ✅ Buscar personagem por ID
* ✅ Atualizar personagem
* ✅ Deletar personagem
* ✅ Filtro por elemento

---

## 🧱 Estrutura do projeto

```
/Controllers
/Models
/Data
/Migrations
```

---

## ⚙️ Configuração do projeto

### 🔹 1. Clonar o repositório

```
git clone https://github.com/seu-usuario/avatar-api.git
cd avatar-api
```

---

### 🔹 2. Configurar banco de dados

Crie um banco PostgreSQL chamado:

```
avatar_db
```

---

### 🔹 3. Configurar connection string

No arquivo `appsettings.Development.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=avatar_db;Username=postgres;Password=SUA_SENHA"
  }
}
```

---

### 🔹 4. Rodar migrations

```
dotnet ef database update
```

---

### 🔹 5. Rodar a aplicação

```
dotnet run
```

---

## 📚 Documentação da API

Após rodar o projeto, acesse:

```
http://localhost:xxxx/swagger
```

---

## 🔗 Endpoints principais

| Método | Endpoint             | Descrição       |
| ------ | -------------------- | --------------- |
| GET    | /api/characters      | Lista todos     |
| GET    | /api/characters/{id} | Busca por ID    |
| POST   | /api/characters      | Cria personagem |
| PUT    | /api/characters/{id} | Atualiza        |
| DELETE | /api/characters/{id} | Remove          |

---

## 💡 Melhorias futuras

* 🔗 Relacionamento com habilidades (Abilities)
* 🔐 Autenticação com JWT
* 🌐 Deploy em nuvem
* 🎨 Integração com frontend em React
* 🧪 Testes api e e2e

---

## 👨‍💻 Autor

Desenvolvido por Matheus de Oliveira 🚀

---

## ⭐ Objetivo

Projeto criado com foco em estudo e portfólio, demonstrando conhecimentos em desenvolvimento backend, APIs REST e integração com banco de dados.
