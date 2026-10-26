using System.Text.Json;
using LojaGamesRetro.Models;

namespace LojaGamesRetro.Data
{
    // "banco" simples em memoria. As vendas ficam salvas num json do lado do .exe
    // pra nao perder o relatorio quando fecha o programa
    public static class Repositorio
    {
        private static readonly string arquivoVendas = Path.Combine(Application.StartupPath, "vendas.json");

        public static List<Jogo> Jogos { get; private set; } = new List<Jogo>();
        public static List<Venda> Vendas { get; private set; } = new List<Venda>();

        public static void Carregar()
        {
            Jogos = CriarCatalogo();
            Vendas = LerVendas();

            // desconta do estoque o que ja foi vendido antes
            foreach (var venda in Vendas)
            {
                foreach (var item in venda.Itens)
                {
                    var jogo = Jogos.FirstOrDefault(j => j.Id == item.JogoId);
                    if (jogo != null)
                        jogo.Estoque = Math.Max(0, jogo.Estoque - item.Quantidade);
                }
            }
        }

        public static Venda RegistrarVenda(string cliente, string pagamento, List<ItemPedido> itens)
        {
            var venda = new Venda
            {
                Id = Vendas.Count == 0 ? 1 : Vendas.Max(v => v.Id) + 1,
                Data = DateTime.Now,
                Cliente = cliente,
                FormaPagamento = pagamento,
                Itens = new List<ItemPedido>(itens)
            };

            foreach (var item in venda.Itens)
            {
                var jogo = Jogos.First(j => j.Id == item.JogoId);
                jogo.Estoque -= item.Quantidade;
            }

            Vendas.Add(venda);
            SalvarVendas();
            return venda;
        }

        private static List<Venda> LerVendas()
        {
            if (!File.Exists(arquivoVendas))
                return new List<Venda>();

            try
            {
                var json = File.ReadAllText(arquivoVendas);
                return JsonSerializer.Deserialize<List<Venda>>(json) ?? new List<Venda>();
            }
            catch
            {
                // se o arquivo estiver corrompido comeca do zero
                return new List<Venda>();
            }
        }

        private static void SalvarVendas()
        {
            var opcoes = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(arquivoVendas, JsonSerializer.Serialize(Vendas, opcoes));
        }

        private static List<Jogo> CriarCatalogo()
        {
            return new List<Jogo>
            {
                new Jogo { Id = 1,  Nome = "Super Mario World",            Plataforma = "Super Nintendo", Ano = 1990, Preco = 189.90m, Estoque = 5, CorHex = "#5B4B9E" },
                new Jogo { Id = 2,  Nome = "Donkey Kong Country",          Plataforma = "Super Nintendo", Ano = 1994, Preco = 159.90m, Estoque = 4, CorHex = "#5B4B9E" },
                new Jogo { Id = 3,  Nome = "Top Gear",                     Plataforma = "Super Nintendo", Ano = 1992, Preco = 99.90m,  Estoque = 8, CorHex = "#5B4B9E" },
                new Jogo { Id = 4,  Nome = "Sonic the Hedgehog 2",         Plataforma = "Mega Drive",     Ano = 1992, Preco = 129.90m, Estoque = 6, CorHex = "#1F2A44" },
                new Jogo { Id = 5,  Nome = "Mortal Kombat II",             Plataforma = "Mega Drive",     Ano = 1994, Preco = 149.90m, Estoque = 3, CorHex = "#1F2A44" },
                new Jogo { Id = 6,  Nome = "Zelda: Ocarina of Time",       Plataforma = "Nintendo 64",    Ano = 1998, Preco = 249.90m, Estoque = 2, CorHex = "#2E7D32" },
                new Jogo { Id = 7,  Nome = "GoldenEye 007",                Plataforma = "Nintendo 64",    Ano = 1997, Preco = 199.90m, Estoque = 3, CorHex = "#2E7D32" },
                new Jogo { Id = 8,  Nome = "Crash Bandicoot",              Plataforma = "PlayStation",    Ano = 1996, Preco = 119.90m, Estoque = 7, CorHex = "#5F6B7A" },
                new Jogo { Id = 9,  Nome = "Pac-Man",                      Plataforma = "Atari 2600",     Ano = 1982, Preco = 79.90m,  Estoque = 10, CorHex = "#8B4513" },
                new Jogo { Id = 10, Nome = "Metal Slug",                   Plataforma = "Neo Geo",        Ano = 1996, Preco = 299.90m, Estoque = 1, CorHex = "#B8860B" }
            };
        }
    }
}
