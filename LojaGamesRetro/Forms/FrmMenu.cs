using LojaGamesRetro.Data;

namespace LojaGamesRetro.Forms
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            AtualizarRodape();
        }

        private void btnLoja_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmCardsJogos())
            {
                frm.ShowDialog(this);
            }
            AtualizarRodape();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmRelatorioVendas())
            {
                frm.ShowDialog(this);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var resp = MessageBox.Show("Deseja realmente sair?", "Sair",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
                Application.Exit();
        }

        private void AtualizarRodape()
        {
            var total = Repositorio.Vendas.Sum(v => v.Total);
            lblRodape.Text = $"Jogos no catálogo: {Repositorio.Jogos.Count}   |   " +
                             $"Pedidos: {Repositorio.Vendas.Count}   |   Faturado: {total:C2}";
        }
    }
}
