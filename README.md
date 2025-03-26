# Gestão de Contratos

## Visão Geral
O **Gestão de Contratos** é um sistema desenvolvido em **.NET** utilizando a abordagem **CQRS (Command Query Responsibility Segregation)** e um **Monolito Modular**. O objetivo do projeto é fornecer uma solução eficiente e escalável para o gerenciamento de contratos, permitindo uma separação clara entre operações de leitura e escrita, melhorando a manutenção e extensibilidade do sistema.

## Tecnologias Utilizadas
- **.NET** (C#)
- **CQRS**
- **Monolito Modular**
- **Entity Framework Core** (para persistência de dados)
- **MediatR** (para gerenciamento de comandos e queries)
- **FluentValidation** (para validação de entradas)

## Estrutura do Projeto
O projeto segue a arquitetura **Monolito Modular**, onde cada módulo é responsável por uma parte específica do sistema, permitindo uma melhor organização do código e facilitação de futuras migrações para microsserviços, se necessário.

A estrutura inicial do projeto é a seguinte:
```
GestaoContratos/Backend/Modulos/UsuarioModulo
├── Usuario.Application/ # Lógica de negócio (CQRS - Comandos e Queries)
├── Usuario.Domain/      # Entidades e interfaces do domínio
├── Usuario.Infrastructure/ # Persistência de dados e configuração
└── README.md                    # Documentação do projeto

GestaoContratos/Backend/
├── GestaoContratos.API/         # Projeto principal (API)
```

## Como Executar o Projeto
1. **Clone o repositório**
   ```sh
   git clone https://github.com/claytonoliver/GestaoContratos.git
   ```
2. **Acesse a pasta do projeto**
   ```sh
   cd GestaoContratos
   ```
3. **Restaure as dependências**
   ```sh
   dotnet restore
   ```
4. **Execute a aplicação**
   ```sh
   dotnet run --project GestaoContratos.API
   ```
5. **Acesse a API**
   - Por padrão, a API será iniciada em `https://localhost:7009`.
   - A documentação via Swagger pode ser acessada em `https://localhost:7009/swagger`.

## Próximos Passos
O projeto ainda está em fase inicial e novas funcionalidades serão adicionadas conforme avanço do desenvolvimento. Alguns dos itens planejados incluem:
- Implementação de autenticação e autorização.
- Criação de testes automatizados para comandos e queries.
- Integração com um banco de dados relacional.
- Melhorias na estrutura de logging e monitoramento.

## Contribuição
Se você deseja contribuir com o projeto, fique à vontade para abrir **issues** ou enviar **pull requests** no [repositório do GitHub](https://github.com/claytonoliver/GestaoContratos).

## Licença
Este projeto está sob a licença MIT - veja o arquivo [LICENSE](LICENSE) para mais detalhes.
