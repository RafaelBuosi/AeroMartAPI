#AeroMart - CRUD Fullstack

Tecnologias Utilizadas
Frontend: Angular com Bootstrap

Backend: ASP.NET Core Web API

Banco de Dados: MySQL

Estilização: CSS customizado (Dark Mode)

Como rodar o projeto
1. Banco de Dados
Certifique-se de ter o MySQL instalado e execute o script abaixo para criar a estrutura:

SQL
CREATE DATABASE AeroMartDb;
USE AeroMartDb;

CREATE TABLE Produtos (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(255) NOT NULL,
    Categoria VARCHAR(100) NOT NULL,
    Quantidade INT NOT NULL
);
2. Backend (API)
Navegue até a pasta da sua API.

Certifique-se de que a ConnectionString no seu appsettings.json aponta corretamente para o seu servidor MySQL.

Execute o comando:

Bash
dotnet run
3. Frontend (Angular)
Navegue até a pasta aero-mart-frontend.

Instale as dependências:

Bash
npm install
Inicie o servidor de desenvolvimento:

Bash
ng serve
Acesse http://localhost:4200 no seu navegador.

Funcionalidades
Listagem: Visualização de todos os produtos com interface responsiva.

Cadastro: Formulário para adicionar novos itens ao estoque.

Edição: Alteração de dados de produtos existentes.

Exclusão: Remoção segura de registros com confirmação via SweetAlert2.

Como salvar este arquivo no GitHub
No VS Code, abra o arquivo README.md (ou crie-o na raiz do projeto).

Cole o conteúdo acima.

No terminal do VS Code, execute os comandos:

Bash
git add README.md
git commit -m "Adicionando documentação ao projeto"
git push origin main
