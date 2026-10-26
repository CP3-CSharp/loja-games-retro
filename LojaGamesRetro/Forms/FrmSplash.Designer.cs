namespace LojaGamesRetro.Forms
{
    partial class FrmSplash
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
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pbCarregando = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(255, 0, 110);
            this.lblTitulo.Location = new System.Drawing.Point(0, 70);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(600, 55);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "RETRO GAMES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblSubtitulo
            //
            this.lblSubtitulo.Font = new System.Drawing.Font("Consolas", 14F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(0, 229, 255);
            this.lblSubtitulo.Location = new System.Drawing.Point(0, 125);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(600, 30);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Loja de Games Retrô";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pbCarregando
            //
            this.pbCarregando.Location = new System.Drawing.Point(100, 220);
            this.pbCarregando.Maximum = 100;
            this.pbCarregando.Name = "pbCarregando";
            this.pbCarregando.Size = new System.Drawing.Size(400, 20);
            this.pbCarregando.TabIndex = 2;
            //
            // lblStatus
            //
            this.lblStatus.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblStatus.ForeColor = System.Drawing.Color.Silver;
            this.lblStatus.Location = new System.Drawing.Point(100, 245);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(400, 22);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Iniciando...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblVersao
            //
            this.lblVersao.AutoSize = true;
            this.lblVersao.Font = new System.Drawing.Font("Consolas", 8F);
            this.lblVersao.ForeColor = System.Drawing.Color.DimGray;
            this.lblVersao.Location = new System.Drawing.Point(12, 320);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(150, 13);
            this.lblVersao.TabIndex = 4;
            this.lblVersao.Text = "v1.0 - CP3 C# Development";
            //
            // tmrSplash
            //
            this.tmrSplash.Interval = 40;
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
            //
            // FrmSplash
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(20, 20, 35);
            this.ClientSize = new System.Drawing.Size(600, 345);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pbCarregando);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSplash";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carregando...";
            this.Load += new System.EventHandler(this.FrmSplash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.ProgressBar pbCarregando;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Timer tmrSplash;
    }
}
