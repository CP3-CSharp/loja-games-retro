namespace LojaGamesRetro.Forms
{
    partial class FrmRelatorioVendas
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.btnLimparFiltro = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.lblAte = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblDe = new System.Windows.Forms.Label();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.lblItens = new System.Windows.Forms.Label();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.pnlResumo = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblMaisVendido = new System.Windows.Forms.Label();
            this.lblTicketMedio = new System.Windows.Forms.Label();
            this.lblFaturamento = new System.Windows.Forms.Label();
            this.lblQtdPedidos = new System.Windows.Forms.Label();
            this.pnlTopo.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.pnlResumo.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlTopo
            //
            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(30, 30, 50);
            this.pnlTopo.Controls.Add(this.lblTitulo);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(984, 60);
            this.pnlTopo.TabIndex = 0;
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(0, 229, 255);
            this.lblTitulo.Location = new System.Drawing.Point(16, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(286, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "RELATÓRIO DE VENDAS";
            //
            // pnlFiltros
            //
            this.pnlFiltros.Controls.Add(this.btnLimparFiltro);
            this.pnlFiltros.Controls.Add(this.btnFiltrar);
            this.pnlFiltros.Controls.Add(this.dtpFim);
            this.pnlFiltros.Controls.Add(this.lblAte);
            this.pnlFiltros.Controls.Add(this.dtpInicio);
            this.pnlFiltros.Controls.Add(this.lblDe);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Location = new System.Drawing.Point(0, 60);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(984, 50);
            this.pnlFiltros.TabIndex = 1;
            //
            // lblDe
            //
            this.lblDe.AutoSize = true;
            this.lblDe.ForeColor = System.Drawing.Color.White;
            this.lblDe.Location = new System.Drawing.Point(16, 17);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(24, 15);
            this.lblDe.TabIndex = 0;
            this.lblDe.Text = "De:";
            //
            // dtpInicio
            //
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(46, 13);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(110, 23);
            this.dtpInicio.TabIndex = 1;
            //
            // lblAte
            //
            this.lblAte.AutoSize = true;
            this.lblAte.ForeColor = System.Drawing.Color.White;
            this.lblAte.Location = new System.Drawing.Point(170, 17);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(28, 15);
            this.lblAte.TabIndex = 2;
            this.lblAte.Text = "Até:";
            //
            // dtpFim
            //
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(204, 13);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(110, 23);
            this.dtpFim.TabIndex = 3;
            //
            // btnFiltrar
            //
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(0, 150, 170);
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(330, 11);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(90, 28);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            //
            // btnLimparFiltro
            //
            this.btnLimparFiltro.BackColor = System.Drawing.Color.FromArgb(60, 60, 80);
            this.btnLimparFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparFiltro.FlatAppearance.BorderSize = 0;
            this.btnLimparFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparFiltro.ForeColor = System.Drawing.Color.White;
            this.btnLimparFiltro.Location = new System.Drawing.Point(428, 11);
            this.btnLimparFiltro.Name = "btnLimparFiltro";
            this.btnLimparFiltro.Size = new System.Drawing.Size(110, 28);
            this.btnLimparFiltro.TabIndex = 5;
            this.btnLimparFiltro.Text = "Limpar filtro";
            this.btnLimparFiltro.UseVisualStyleBackColor = false;
            this.btnLimparFiltro.Click += new System.EventHandler(this.btnLimparFiltro_Click);
            //
            // dgvVendas
            //
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.AllowUserToResizeRows = false;
            this.dgvVendas.BackgroundColor = System.Drawing.Color.FromArgb(45, 45, 65);
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVendas.Location = new System.Drawing.Point(0, 110);
            this.dgvVendas.MultiSelect = false;
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.RowHeadersVisible = false;
            this.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendas.Size = new System.Drawing.Size(984, 231);
            this.dgvVendas.TabIndex = 2;
            this.dgvVendas.SelectionChanged += new System.EventHandler(this.dgvVendas_SelectionChanged);
            //
            // lblItens
            //
            this.lblItens.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblItens.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.lblItens.ForeColor = System.Drawing.Color.FromArgb(255, 0, 110);
            this.lblItens.Location = new System.Drawing.Point(0, 341);
            this.lblItens.Name = "lblItens";
            this.lblItens.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblItens.Size = new System.Drawing.Size(984, 30);
            this.lblItens.TabIndex = 3;
            this.lblItens.Text = "Itens do pedido selecionado";
            this.lblItens.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // dgvItens
            //
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AllowUserToResizeRows = false;
            this.dgvItens.BackgroundColor = System.Drawing.Color.FromArgb(45, 45, 65);
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvItens.Location = new System.Drawing.Point(0, 371);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(984, 150);
            this.dgvItens.TabIndex = 4;
            //
            // pnlResumo
            //
            this.pnlResumo.BackColor = System.Drawing.Color.FromArgb(30, 30, 50);
            this.pnlResumo.Controls.Add(this.btnFechar);
            this.pnlResumo.Controls.Add(this.lblMaisVendido);
            this.pnlResumo.Controls.Add(this.lblTicketMedio);
            this.pnlResumo.Controls.Add(this.lblFaturamento);
            this.pnlResumo.Controls.Add(this.lblQtdPedidos);
            this.pnlResumo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlResumo.Location = new System.Drawing.Point(0, 521);
            this.pnlResumo.Name = "pnlResumo";
            this.pnlResumo.Size = new System.Drawing.Size(984, 80);
            this.pnlResumo.TabIndex = 5;
            //
            // lblQtdPedidos
            //
            this.lblQtdPedidos.AutoSize = true;
            this.lblQtdPedidos.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.lblQtdPedidos.ForeColor = System.Drawing.Color.White;
            this.lblQtdPedidos.Location = new System.Drawing.Point(16, 14);
            this.lblQtdPedidos.Name = "lblQtdPedidos";
            this.lblQtdPedidos.Size = new System.Drawing.Size(80, 18);
            this.lblQtdPedidos.TabIndex = 0;
            this.lblQtdPedidos.Text = "Pedidos: 0";
            //
            // lblFaturamento
            //
            this.lblFaturamento.AutoSize = true;
            this.lblFaturamento.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.lblFaturamento.ForeColor = System.Drawing.Color.Gold;
            this.lblFaturamento.Location = new System.Drawing.Point(200, 14);
            this.lblFaturamento.Name = "lblFaturamento";
            this.lblFaturamento.Size = new System.Drawing.Size(150, 18);
            this.lblFaturamento.TabIndex = 1;
            this.lblFaturamento.Text = "Faturamento: R$ 0,00";
            //
            // lblTicketMedio
            //
            this.lblTicketMedio.AutoSize = true;
            this.lblTicketMedio.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.lblTicketMedio.ForeColor = System.Drawing.Color.White;
            this.lblTicketMedio.Location = new System.Drawing.Point(480, 14);
            this.lblTicketMedio.Name = "lblTicketMedio";
            this.lblTicketMedio.Size = new System.Drawing.Size(150, 18);
            this.lblTicketMedio.TabIndex = 2;
            this.lblTicketMedio.Text = "Ticket médio: R$ 0,00";
            //
            // lblMaisVendido
            //
            this.lblMaisVendido.AutoSize = true;
            this.lblMaisVendido.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.lblMaisVendido.ForeColor = System.Drawing.Color.FromArgb(0, 229, 255);
            this.lblMaisVendido.Location = new System.Drawing.Point(16, 46);
            this.lblMaisVendido.Name = "lblMaisVendido";
            this.lblMaisVendido.Size = new System.Drawing.Size(130, 18);
            this.lblMaisVendido.TabIndex = 3;
            this.lblMaisVendido.Text = "Mais vendido: -";
            //
            // btnFechar
            //
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(255, 0, 110);
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(852, 22);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(116, 36);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            //
            // FrmRelatorioVendas
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(20, 20, 35);
            this.ClientSize = new System.Drawing.Size(984, 601);
            this.Controls.Add(this.dgvVendas);
            this.Controls.Add(this.lblItens);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.pnlResumo);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.pnlTopo);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FrmRelatorioVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Retro Games - Relatório de Vendas";
            this.Load += new System.EventHandler(this.FrmRelatorioVendas_Load);
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.pnlResumo.ResumeLayout(false);
            this.pnlResumo.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnLimparFiltro;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.Label lblItens;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Panel pnlResumo;
        private System.Windows.Forms.Label lblQtdPedidos;
        private System.Windows.Forms.Label lblFaturamento;
        private System.Windows.Forms.Label lblTicketMedio;
        private System.Windows.Forms.Label lblMaisVendido;
        private System.Windows.Forms.Button btnFechar;
    }
}
