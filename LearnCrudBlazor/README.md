# LearnCrudBlazor

Este projeto foi desenvolvido com o objetivo de ter um primeiro contato com o **Blazor**, para além das **APIs .NET** conhecendo um pouco a criação de interfaces web na mesma stack.

O foco principal foi entender o ciclo de vida dos componentes Blazor, a manipulação de estados em formulários (SSR) e a integração direta com o Entity Framework Core dentro de um contexto de componentes.

## 🚀 Tecnologias Utilizadas

- **.NET 10**: Versão mais recente do ecossistema .NET.
- **Blazor (Static Server-Side Rendering - SSR)**: Para renderização rápida e eficiente no servidor.
- **Entity Framework Core**: Gerenciamento de dados com `IDbContextFactory`.
- **In-Memory Database**: Para facilitar o desenvolvimento e testes rápidos sem a necessidade de um banco de dados externo.
- **Bootstrap 5**: Para estilização e layout responsivo.

## 🛠️ O que foi aprendido/implementado

- **Estrutura de Componentes**: Organização de páginas de CRUD dentro de subpastas específicas (`PessoaPages`).
- **Padrão Single-File**: Uso do bloco `@code` para manter lógica e marcação no mesmo arquivo `.razor`.
- **SupplyParameterFromForm**: Utilização de atributos modernos para captura de dados de formulários em SSR.
- **Segurança e Boas Práticas**:
    - Proteção contra ataques de *overposting*.
    - Uso de campos ocultos (`hidden inputs`) para preservação de IDs durante postbacks.
    - Implementação do parâmetro `FormName` para identificação única de formulários.
- **Customização de Layout**: Ajustes no menu de navegação lateral (`NavMenu`) e inclusão de ícones SVG customizados.

## 📋 Funcionalidades (CRUD de Pessoas)

- **Listagem**: Visualização de todos os registros em uma tabela.
- **Criação**: Formulário validado para adicionar novas pessoas.
- **Edição**: Atualização de registros existentes preservando a integridade dos dados.
- **Detalhes**: Visualização detalhada de um registro específico.
- **Exclusão**: Remoção segura de registros com confirmação.

## ⚙️ Como executar o projeto

1. Certifique-se de ter o **SDK do .NET 10** instalado.
2. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/LearnCrudBlazor.git
   ```
3. Navegue até a pasta do projeto:
   ```bash
   cd LearnCrudBlazor/LearnCrudBlazor
   ```
4. Execute o projeto:
   ```bash
   dotnet run
   ```
5. Acesse no seu navegador: `http://localhost:5041` (ou a porta indicada no console).

---
*Projeto desenvolvido para fins de estudo e experimentação do ecossistema Blazor.*

---
## Autor
Desenvolvido por [David Tavares](https://github.com/davidtav) - [LinkedIn](https://www.linkedin.com/in/david-mclaurel/)
