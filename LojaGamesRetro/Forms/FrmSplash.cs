using LojaGamesRetro.Data;

namespace LojaGamesRetro.Forms
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            // carrega catalogo e vendas enquanto a barra anda
            Repositorio.Carregar();
            tmrSplash.Start();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            if (pbCarregando.Value < pbCarregando.Maximum)
            {
                pbCarregando.Value = Math.Min(pbCarregando.Maximum, pbCarregando.Value + 2);
                AtualizarStatus(pbCarregando.Value);
                return;
            }

            tmrSplash.Stop();
            Close();
        }

        private void AtualizarStatus(int progresso)
        {
            if (progresso < 30)
                lblStatus.Text = "Ligando o console...";
            else if (progresso < 60)
                lblStatus.Text = "Soprando o cartucho...";
            else if (progresso < 90)
                lblStatus.Text = "Carregando catálogo de jogos...";
            else
                lblStatus.Text = "Pronto! PRESS START";
        }
    }
}
