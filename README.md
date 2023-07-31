# Exercícios de Fixação

## 01

O que é o Entity Framework?

## 02

O que é "Code First" e "Database First"? Qual a diferença entre eles e quais as vantagens e desvantagens entre cada uma das abordagens?

## 03

O que é uma API? Dê exemplos de algumas reais.

## 04

Como você cria um novo projeto API no .NET Core usando o CLI (Interface de Linha de Comando)?

## 05

O que é o modelo de request/response e como ele se aplica ao funcionamento da web?

## 06

Quais são os principais métodos HTTP e quais são suas funções típicas em uma aplicação web?

## 07

O que é um código de status HTTP e como ele informa ao cliente sobre o resultado de sua request? Poderia citar e explicar três códigos de status HTTP comuns?

## 08

Qual a diferença fundamental entre status codes na faixa dos 4xx e os da faixa do 5xx?

## 09

Como você pode definir relações entre entidades (como relações um-para-muitos ou muitos-para-muitos) usando o EF Core?

## 10

Explique o propósito de um controller

## 11

Como você pode definir rotas personalizadas em um controller no .NET Core para mapear diferentes ações?

## 12

O que é, para que servem e como criamos e aplicamos migrations?

## 13

De que formas podemos gerenciar a autenticação de um usuário numa aplicação .NET core?

## 14

O que é um JWT?

# Mini-Desafio

Desenvolver uma API que servirá para um app de To-Do que estamos desenvolvendo. Nessa API o usuário poderá cadastrar, ler, atualizar e remover tarefas.

## Especificações:

A tarefa deve ter as seguintes propriedades:

- Id (int)
- Título (string)
- Descrição (string)
- Data de Criação (DateTime)
- Status (bool - para determinar se a tarefa foi concluída ou não)

**Endpoints**: Sua API deve ter os seguintes endpoints:

- `GET /tarefas`: Retorna todas as tarefas.
- `GET /tarefas/{id}`: Retorna uma tarefa específica com base no ID.
- `POST /tarefas`: Cria uma nova tarefa.
- `PUT /tarefas/{id}`: Atualiza uma tarefa existente com base no ID.
- `DELETE /tarefas/{id}`: Exclui uma tarefa com base no ID.

**Persistência**: Use uma abordagem de "in-memory database" (como o InMemoryDatabase do Entity Framework Core) para simplificar. Não é necessário um banco de dados real para este mini-desafio.
