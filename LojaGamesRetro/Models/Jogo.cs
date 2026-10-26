namespace LojaGamesRetro.Models
{
    public class Jogo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Plataforma { get; set; }
        public int Ano { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }

        // cor do topo do card (cada console tem a sua)
        public string CorHex { get; set; }
    }
}
