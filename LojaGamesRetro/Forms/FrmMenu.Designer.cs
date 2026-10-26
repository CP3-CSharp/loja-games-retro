namespace LojaGamesRetro.Forms
{
    partial class FrmMenu
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnLoja = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblRodape = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(255, 0, 110);
            this.lblTitulo.Location = new System.Drawing.Point(0, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(584, 50);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "RETRO GAMES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblSubtitulo
            //
            this.lblSubtitulo.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(0, 229, 255);
            this.lblSubtitulo.Location = new System.Drawing.Point(0, 80);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(584, 25);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "- MENU PRINCIPAL -";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // btnLoja
            //
            this.btnLoja.BackColor = System.Drawing.Color.FromArgb(255, 0, 110);
            this.btnLoja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoja.FlatAppearance.BorderSize = 0;
            this.btnLoja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoja.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.btnLoja.ForeColor = System.Drawing.Color.White;
            this.btnLoja.Location = new System.Drawing.Point(152, 140);
            this.btnLoja.Name = "btnLoja";
            this.btnLoja.Size = new System.Drawing.Size(280, 50);
            this.btnLoja.TabIndex = 2;
            this.btnLoja.Text = "LOJA / NOVO PEDIDO";
            this.btnLoja.UseVisualStyleBackColor = false;
            this.btnLoja.Click += new System.EventHandler(this.btnLoja_Click);
            //
            // btnRelatorio
            //
            this.btnRelatorio.BackColor = System.Drawing.Color.FromArgb(0, 150, 170);
            this.btnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.btnRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio.Location = new System.Drawing.Point(152, 205);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(280, 50);
            this.btnRelatorio.TabIndex = 3;
            this.btnRelatorio.Text = "RELATÓRIO DE VENDAS";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            //
            // btnSair
            //
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(60, 60, 80);
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(152, 270);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(280, 50);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            //
            // lblRodape
            //
            this.lblRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblRodape.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblRodape.ForeColor = System.Drawing.Color.Silver;
            this.lblRodape.Location = new System.Drawing.Point(0, 371);
            this.lblRodape.Name = "lblRodape";
            this.lblRodape.Size = new System.Drawing.Size(584, 30);
            this.lblRodape.TabIndex = 5;
            this.lblRodape.Text = "...";
            this.lblRodape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // FrmMenu
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(20, 20, 35);
            this.ClientSize = new System.Drawing.Size(584, 401);
            this.Controls.Add(this.lblRodape);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnLoja);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retro Games - Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnLoja;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblRodape;
    }
}
