# Loja de Games Retrô 🕹️

Checkpoint 3 - C# Development (3ESPS)
Aluno: Luis Filipe Crivellaro - RM 560877

Sistema desktop em **C# Windows Forms (.NET 8)** para uma loja de jogos retrô.

## Telas

| Tela | Descrição |
|------|-----------|
| **Splash** | Tela de abertura com barra de progresso. Enquanto carrega, o catálogo e as vendas salvas são lidos. |
| **Menu** | Navegação principal: Loja, Relatório de Vendas e Sair. Mostra um resumo no rodapé. |
| **Cards de Jogos** | Catálogo em cards (console, nome, ano, preço e estoque). Adiciona ao carrinho, informa cliente e forma de pagamento e finaliza o pedido. |
| **Relatório de Vendas** | Lista os pedidos com filtro por período, mostra os itens do pedido selecionado e o resumo (pedidos, faturamento, ticket médio e jogo mais vendido). |

## Estrutura

```
LojaGamesRetro/
├── Data/
│   └── Repositorio.cs        -> catálogo + vendas (salvas em vendas.json)
├── Forms/
│   ├── FrmSplash
│   ├── FrmMenu
│   ├── FrmCardsJogos
│   └── FrmRelatorioVendas
├── Models/
│   ├── Jogo.cs
│   ├── ItemPedido.cs
│   └── Venda.cs
└── Program.cs
```

## Como rodar

1. Abrir `LojaGamesRetro.sln` no Visual Studio 2022
2. Precisa do .NET 8 SDK
3. F5

As vendas ficam gravadas em `vendas.json` na pasta do executável (`bin/Debug/net8.0-windows`).

## Fluxo de Git

- `main` → versão final
- `dev` → integração
- `feature/*` → uma branch por tarefa, com PR para `dev`
- Commits semânticos (`feat`, `fix`, `chore`, `docs`, `style`, `refactor`)
