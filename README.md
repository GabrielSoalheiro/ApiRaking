# RankingApi - API ASP.NET para Gerenciamento de Dados e Ranking

A RankingApi é uma API ASP.NET que permite o gerenciamento de dados e a criação de rankings baseados em informações provenientes do próprio controle.

## Funcionalidades

- **Listagem de Dados**: Permite acessar uma lista de informações do próprio controle.
- **Criação de Rankings**: Gera rankings com base nas informações coletadas, possibilitando ordenar os dados de maneira significativa.

## Tecnologias Utilizadas

- **ASP.NET Web API**: Framework para construção de APIs em ASP.NET.
- **C#**: Linguagem de programação utilizada para desenvolver a lógica da aplicação.

## Uso

1. Clone este repositório em sua máquina.
2. Abra a solução no Visual Studio ou em uma IDE compatível.
3. Execute a aplicação.

## Endpoints da API

A API oferece os seguintes endpoints:

- `GET /api/dados`: Retorna a lista de informações do próprio controle.
- `POST /api/rankings`: Cria um ranking com base nos dados coletados.
- `GET /api/rankings`: Retorna a lista de rankings criados.

## Exemplo de Uso

1. Acesse `GET /api/dados` para coletar as informações.
2. Utilize `POST /api/rankings` para criar um novo ranking.
3. Verifique a lista de rankings através de `GET /api/rankings`.

