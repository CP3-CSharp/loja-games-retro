namespace LojaGamesRetro.Forms
{
    partial class FrmCardsJogos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCarrinho = new System.Windows.Forms.Panel();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.cmbPagamento = new System.Windows.Forms.ComboBox();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvCarrinho = new System.Windows.Forms.DataGridView();
            this.lblCarrinho = new System.Windows.Forms.Label();
            this.flpCards = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTopo.SuspendLayout();
            this.pnlCarrinho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).BeginInit();
            this.SuspendLayout();
            //
            // pnlTopo
            //
            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(30, 30, 50);
            this.pnlTopo.Controls.Add(this.btnVoltar);
            this.pnlTopo.Controls.Add(this.lblTitulo);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(1184, 60);
            this.pnlTopo.TabIndex = 0;
            //
            // btnVoltar
            //
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(60, 60, 80);
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(1062, 14);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(110, 32);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "< VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(255, 0, 110);
            this.lblTitulo.Location = new System.Drawing.Point(16, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(260, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CATÁLOGO DE JOGOS";
            //
            // pnlCarrinho
            //
            this.pnlCarrinho.BackColor = System.Drawing.Color.FromArgb(30, 30, 50);
            this.pnlCarrinho.Controls.Add(this.btnFinalizar);
            this.pnlCarrinho.Controls.Add(this.btnLimpar);
            this.pnlCarrinho.Controls.Add(this.btnRemover);
            this.pnlCarrinho.Controls.Add(this.cmbPagamento);
            this.pnlCarrinho.Controls.Add(this.lblPagamento);
            this.pnlCarrinho.Controls.Add(this.txtCliente);
            this.pnlCarrinho.Controls.Add(this.lblCliente);
            this.pnlCarrinho.Controls.Add(this.lblTotal);
            this.pnlCarrinho.Controls.Add(this.dgvCarrinho);
            this.pnlCarrinho.Controls.Add(this.lblCarrinho);
            this.pnlCarrinho.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCarrinho.Location = new System.Drawing.Point(834, 60);
            this.pnlCarrinho.Name = "pnlCarrinho";
            this.pnlCarrinho.Size = new System.Drawing.Size(350, 601);
            this.pnlCarrinho.TabIndex = 1;
            //
            // lblCarrinho
            //
            this.lblCarrinho.AutoSize = true;
            this.lblCarrinho.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.lblCarrinho.ForeColor = System.Drawing.Color.FromArgb(0, 229, 255);
            this.lblCarrinho.Location = new System.Drawing.Point(14, 12);
            this.lblCarrinho.Name = "lblCarrinho";
            this.lblCarrinho.Size = new System.Drawing.Size(80, 22);
            this.lblCarrinho.TabIndex = 0;
            this.lblCarrinho.Text = "CARRINHO";
            //
            // dgvCarrinho
            //
            this.dgvCarrinho.AllowUserToAddRows = false;
            this.dgvCarrinho.AllowUserToDeleteRows = false;
            this.dgvCarrinho.AllowUserToResizeRows = false;
            this.dgvCarrinho.BackgroundColor = System.Drawing.Color.FromArgb(45, 45, 65);
            this.dgvCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrinho.Location = new System.Drawing.Point(14, 42);
            this.dgvCarrinho.MultiSelect = false;
            this.dgvCarrinho.Name = "dgvCarrinho";
            this.dgvCarrinho.ReadOnly = true;
            this.dgvCarrinho.RowHeadersVisible = false;
            this.dgvCarrinho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarrinho.Size = new System.Drawing.Size(322, 250);
            this.dgvCarrinho.TabIndex = 1;
            //
            // lblTotal
            //
            this.lblTotal.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.Gold;
            this.lblTotal.Location = new System.Drawing.Point(14, 300);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(322, 30);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total: R$ 0,00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblCliente
            //
            this.lblCliente.AutoSize = true;
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(14, 345);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(47, 15);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente:";
            //
            // txtCliente
            //
            this.txtCliente.Location = new System.Drawing.Point(14, 365);
            this.txtCliente.MaxLength = 60;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(322, 23);
            this.txtCliente.TabIndex = 4;
            //
            // lblPagamento
            //
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.ForeColor = System.Drawing.Color.White;
            this.lblPagamento.Location = new System.Drawing.Point(14, 400);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(120, 15);
            this.lblPagamento.TabIndex = 5;
            this.lblPagamento.Text = "Forma de pagamento:";
            //
            // cmbPagamento
            //
            this.cmbPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPagamento.Location = new System.Drawing.Point(14, 420);
            this.cmbPagamento.Name = "cmbPagamento";
            this.cmbPagamento.Size = new System.Drawing.Size(322, 23);
            this.cmbPagamento.TabIndex = 6;
            //
            // btnRemover
            //
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(60, 60, 80);
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(14, 460);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(156, 34);
            this.btnRemover.TabIndex = 7;
            this.btnRemover.Text = "Remover item";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            //
            // btnLimpar
            //
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(60, 60, 80);
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(180, 460);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(156, 34);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar carrinho";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            //
            // btnFinalizar
            //
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(255, 0, 110);
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(14, 510);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(322, 50);
            this.btnFinalizar.TabIndex = 9;
            this.btnFinalizar.Text = "FINALIZAR PEDIDO";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            //
            // flpCards
            //
            this.flpCards.AutoScroll = true;
            this.flpCards.BackColor = System.Drawing.Color.FromArgb(20, 20, 35);
            this.flpCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCards.Location = new System.Drawing.Point(0, 60);
            this.flpCards.Name = "flpCards";
            this.flpCards.Padding = new System.Windows.Forms.Padding(8);
            this.flpCards.Size = new System.Drawing.Size(834, 601);
            this.flpCards.TabIndex = 2;
            //
            // FrmCardsJogos
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(20, 20, 35);
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.flpCards);
            this.Controls.Add(this.pnlCarrinho);
            this.Controls.Add(this.pnlTopo);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "FrmCardsJogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Retro Games - Lançamento de Pedidos";
            this.Load += new System.EventHandler(this.FrmCardsJogos_Load);
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.pnlCarrinho.ResumeLayout(false);
            this.pnlCarrinho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel pnlCarrinho;
        private System.Windows.Forms.Label lblCarrinho;
        private System.Windows.Forms.DataGridView dgvCarrinho;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.ComboBox cmbPagamento;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.FlowLayoutPanel flpCards;
    }
}
