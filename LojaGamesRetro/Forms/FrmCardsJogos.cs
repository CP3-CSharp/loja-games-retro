using LojaGamesRetro.Data;
using LojaGamesRetro.Models;

namespace LojaGamesRetro.Forms
{
    public partial class FrmCardsJogos : Form
    {
        private readonly List<ItemPedido> carrinho = new List<ItemPedido>();

        public FrmCardsJogos()
        {
            InitializeComponent();
        }

        private void FrmCardsJogos_Load(object sender, EventArgs e)
        {
            cmbPagamento.Items.AddRange(new object[] { "Dinheiro", "Pix", "Cartão de Débito", "Cartão de Crédito" });
            cmbPagamento.SelectedIndex = 1;

            CarregarCards();
            AtualizarCarrinho();
        }

        #region Cards

        private void CarregarCards()
        {
            flpCards.SuspendLayout();
            flpCards.Controls.Clear();

            foreach (var jogo in Repositorio.Jogos)
                flpCards.Controls.Add(CriarCard(jogo));

            flpCards.ResumeLayout();
        }

        private Panel CriarCard(Jogo jogo)
        {
            var card = new Panel
            {
                Size = new Size(210, 240),
                Margin = new Padding(10),
                BackColor = Color.FromArgb(38, 38, 58),
                BorderStyle = BorderStyle.FixedSingle
            };

            // topo colorido com o nome do console
            var topo = new Panel
            {
                Dock = DockStyle.Top,
                Height = 55,
                BackColor = ColorTranslator.FromHtml(jogo.CorHex)
            };
            var lblPlataforma = new Label
            {
                Text = jogo.Plataforma.ToUpper(),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font("Consolas", 11F, FontStyle.Bold)
            };
            topo.Controls.Add(lblPlataforma);

            var lblNome = new Label
            {
                Text = jogo.Nome,
                Location = new Point(8, 62),
                Size = new Size(192, 40),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold)
            };

            var lblAno = new Label
            {
                Text = $"Lançamento: {jogo.Ano}",
                Location = new Point(8, 104),
                AutoSize = true,
                ForeColor = Color.Silver
            };

            var lblPreco = new Label
            {
                Text = jogo.Preco.ToString("C2"),
                Location = new Point(8, 126),
                AutoSize = true,
                ForeColor = Color.Gold,
                Font = new Font("Segoe UI", 13F, FontStyle.Bold)
            };

            var lblEstoque = new Label
            {
                Text = jogo.Estoque > 0 ? $"Estoque: {jogo.Estoque}" : "ESGOTADO",
                Location = new Point(8, 158),
                AutoSize = true,
                ForeColor = jogo.Estoque > 0 ? Color.LightGreen : Color.IndianRed
            };

            var nudQtd = new NumericUpDown
            {
                Location = new Point(8, 192),
                Width = 55,
                Minimum = 1,
                Maximum = Math.Max(1, jogo.Estoque),
                Value = 1,
                Enabled = jogo.Estoque > 0
            };

            var btnAdicionar = new Button
            {
                Text = "Adicionar",
                Location = new Point(72, 189),
                Size = new Size(126, 30),
                BackColor = Color.FromArgb(255, 0, 110),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Enabled = jogo.Estoque > 0
            };
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.Click += (s, e) => AdicionarAoCarrinho(jogo, (int)nudQtd.Value);

            card.Controls.Add(btnAdicionar);
            card.Controls.Add(nudQtd);
            card.Controls.Add(lblEstoque);
            card.Controls.Add(lblPreco);
            card.Controls.Add(lblAno);
            card.Controls.Add(lblNome);
            card.Controls.Add(topo);

            return card;
        }

        #endregion

        #region Carrinho

        private void AdicionarAoCarrinho(Jogo jogo, int quantidade)
        {
            var item = carrinho.FirstOrDefault(i => i.JogoId == jogo.Id);
            int qtdNoCarrinho = item?.Quantidade ?? 0;

            if (qtdNoCarrinho + quantidade > jogo.Estoque)
            {
                MessageBox.Show($"Só temos {jogo.Estoque} unidade(s) de {jogo.Nome} em estoque.",
                    "Estoque insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (item == null)
            {
                carrinho.Add(new ItemPedido
                {
                    JogoId = jogo.Id,
                    NomeJogo = jogo.Nome,
                    Plataforma = jogo.Plataforma,
                    PrecoUnitario = jogo.Preco,
                    Quantidade = quantidade
                });
            }
            else
            {
                item.Quantidade += quantidade;
            }

            AtualizarCarrinho();
        }

        private void AtualizarCarrinho()
        {
            dgvCarrinho.DataSource = null;
            dgvCarrinho.DataSource = carrinho.Select(i => new
            {
                Jogo = i.NomeJogo,
                Qtd = i.Quantidade,
                Preco = i.PrecoUnitario.ToString("C2"),
                Subtotal = i.Subtotal.ToString("C2")
            }).ToList();

            if (dgvCarrinho.Columns.Count > 0)
            {
                dgvCarrinho.Columns["Jogo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvCarrinho.Columns["Qtd"].Width = 40;
            }

            lblTotal.Text = $"Total: {carrinho.Sum(i => i.Subtotal):C2}";
            btnFinalizar.Enabled = carrinho.Count > 0;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvCarrinho.CurrentRow == null)
            {
                MessageBox.Show("Selecione um item do carrinho pra remover.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            carrinho.RemoveAt(dgvCarrinho.CurrentRow.Index);
            AtualizarCarrinho();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (carrinho.Count == 0)
                return;

            carrinho.Clear();
            AtualizarCarrinho();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            string cliente = txtCliente.Text.Trim();

            if (carrinho.Count == 0)
            {
                MessageBox.Show("O carrinho está vazio.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cliente))
            {
                MessageBox.Show("Informe o nome do cliente.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus();
                return;
            }

            var total = carrinho.Sum(i => i.Subtotal);
            var confirma = MessageBox.Show(
                $"Finalizar pedido de {cliente}?\n\nItens: {carrinho.Sum(i => i.Quantidade)}\nTotal: {total:C2}\nPagamento: {cmbPagamento.Text}",
                "Confirmar pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirma != DialogResult.Yes)
                return;

            var venda = Repositorio.RegistrarVenda(cliente, cmbPagamento.Text, carrinho);

            MessageBox.Show($"Pedido #{venda.Id} registrado com sucesso!", "GAME SAVED",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            carrinho.Clear();
            txtCliente.Clear();
            AtualizarCarrinho();
            CarregarCards(); // recarrega pra atualizar o estoque nos cards
        }

        #endregion

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (carrinho.Count > 0)
            {
                var resp = MessageBox.Show("Tem itens no carrinho que não foram finalizados. Sair mesmo assim?",
                    "Voltar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp != DialogResult.Yes)
                    return;
            }

            Close();
        }
    }
}
