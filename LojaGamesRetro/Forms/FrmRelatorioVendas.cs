using LojaGamesRetro.Data;
using LojaGamesRetro.Models;

namespace LojaGamesRetro.Forms
{
    public partial class FrmRelatorioVendas : Form
    {
        private List<Venda> vendasFiltradas = new List<Venda>();

        public FrmRelatorioVendas()
        {
            InitializeComponent();
        }

        private void FrmRelatorioVendas_Load(object sender, EventArgs e)
        {
            DefinirPeriodoPadrao();
            CarregarVendas();
        }

        private void DefinirPeriodoPadrao()
        {
            // se ja tem venda pega desde a primeira, senao ultimos 30 dias
            dtpInicio.Value = Repositorio.Vendas.Count > 0
                ? Repositorio.Vendas.Min(v => v.Data).Date
                : DateTime.Today.AddDays(-30);
            dtpFim.Value = DateTime.Today;
        }

        private void CarregarVendas()
        {
            var inicio = dtpInicio.Value.Date;
            var fim = dtpFim.Value.Date.AddDays(1); // inclui o dia inteiro

            vendasFiltradas = Repositorio.Vendas
                .Where(v => v.Data >= inicio && v.Data < fim)
                .OrderByDescending(v => v.Data)
                .ToList();

            dgvVendas.DataSource = vendasFiltradas.Select(v => new
            {
                Pedido = v.Id,
                Data = v.Data.ToString("dd/MM/yyyy HH:mm"),
                v.Cliente,
                Pagamento = v.FormaPagamento,
                Itens = v.QuantidadeItens,
                Total = v.Total.ToString("C2")
            }).ToList();

            if (dgvVendas.Columns.Count > 0)
                dgvVendas.Columns["Cliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            AtualizarResumo();
            MostrarItensDaVendaSelecionada();
        }

        private void AtualizarResumo()
        {
            decimal faturamento = vendasFiltradas.Sum(v => v.Total);
            decimal ticketMedio = vendasFiltradas.Count > 0 ? faturamento / vendasFiltradas.Count : 0;

            var maisVendido = vendasFiltradas
                .SelectMany(v => v.Itens)
                .GroupBy(i => i.NomeJogo)
                .Select(g => new { Nome = g.Key, Qtd = g.Sum(i => i.Quantidade) })
                .OrderByDescending(x => x.Qtd)
                .FirstOrDefault();

            lblQtdPedidos.Text = $"Pedidos: {vendasFiltradas.Count}";
            lblFaturamento.Text = $"Faturamento: {faturamento:C2}";
            lblTicketMedio.Text = $"Ticket médio: {ticketMedio:C2}";
            lblMaisVendido.Text = maisVendido == null
                ? "Mais vendido: -"
                : $"Mais vendido: {maisVendido.Nome} ({maisVendido.Qtd} un.)";
        }

        private void MostrarItensDaVendaSelecionada()
        {
            if (dgvVendas.CurrentRow == null)
            {
                dgvItens.DataSource = null;
                return;
            }

            int id = Convert.ToInt32(dgvVendas.CurrentRow.Cells["Pedido"].Value);
            var venda = vendasFiltradas.FirstOrDefault(v => v.Id == id);

            if (venda == null)
            {
                dgvItens.DataSource = null;
                return;
            }

            dgvItens.DataSource = venda.Itens.Select(i => new
            {
                Jogo = i.NomeJogo,
                i.Plataforma,
                Qtd = i.Quantidade,
                Unitario = i.PrecoUnitario.ToString("C2"),
                Subtotal = i.Subtotal.ToString("C2")
            }).ToList();

            if (dgvItens.Columns.Count > 0)
                dgvItens.Columns["Jogo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgvVendas_SelectionChanged(object sender, EventArgs e)
        {
            MostrarItensDaVendaSelecionada();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (dtpInicio.Value.Date > dtpFim.Value.Date)
            {
                MessageBox.Show("A data inicial não pode ser maior que a final.", "Filtro inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CarregarVendas();
        }

        private void btnLimparFiltro_Click(object sender, EventArgs e)
        {
            DefinirPeriodoPadrao();
            CarregarVendas();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
