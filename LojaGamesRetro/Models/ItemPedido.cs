namespace LojaGamesRetro.Models
{
    public class ItemPedido
    {
        public int JogoId { get; set; }
        public string NomeJogo { get; set; }
        public string Plataforma { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int Quantidade { get; set; }

        public decimal Subtotal => PrecoUnitario * Quantidade;
    }
}
