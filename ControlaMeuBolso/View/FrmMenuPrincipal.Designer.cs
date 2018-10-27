namespace ControlaMeuBolso.View
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.pnTopDespesas = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.btnDespesas = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnPoupanca = new System.Windows.Forms.Button();
            this.btnMetas = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.ucRelatorios = new ControlaMeuBolso.View.ControleUsuario.UCRelatorios();
            this.ucDespesas = new ControlaMeuBolso.View.ControleUsuario.UCDespesas();
            this.ucPrincipal = new ControlaMeuBolso.View.ControleUsuario.UCPrincipal();
            this.pnTopDespesas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTopDespesas
            // 
            this.pnTopDespesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.pnTopDespesas.Controls.Add(this.panelSlide);
            this.pnTopDespesas.Controls.Add(this.button5);
            this.pnTopDespesas.Controls.Add(this.btnMetas);
            this.pnTopDespesas.Controls.Add(this.btnPoupanca);
            this.pnTopDespesas.Controls.Add(this.btnRelatorio);
            this.pnTopDespesas.Controls.Add(this.btnDespesas);
            this.pnTopDespesas.Controls.Add(this.btnPrincipal);
            this.pnTopDespesas.Controls.Add(this.pictureBox1);
            this.pnTopDespesas.ForeColor = System.Drawing.Color.Red;
            this.pnTopDespesas.Location = new System.Drawing.Point(1, 0);
            this.pnTopDespesas.Name = "pnTopDespesas";
            this.pnTopDespesas.Size = new System.Drawing.Size(219, 584);
            this.pnTopDespesas.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(221, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 42);
            this.panel1.TabIndex = 6;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(772, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(39, 39);
            this.btnFechar.TabIndex = 11;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbTitulo.Location = new System.Drawing.Point(300, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(211, 25);
            this.lbTitulo.TabIndex = 7;
            this.lbTitulo.Text = "Controla meu bolso";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.btnPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("btnPrincipal.Image")));
            this.btnPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrincipal.Location = new System.Drawing.Point(19, 131);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(197, 62);
            this.btnPrincipal.TabIndex = 7;
            this.btnPrincipal.Text = "         Principal";
            this.btnPrincipal.UseVisualStyleBackColor = false;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // btnDespesas
            // 
            this.btnDespesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnDespesas.FlatAppearance.BorderSize = 0;
            this.btnDespesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDespesas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDespesas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.btnDespesas.Image = ((System.Drawing.Image)(resources.GetObject("btnDespesas.Image")));
            this.btnDespesas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDespesas.Location = new System.Drawing.Point(19, 199);
            this.btnDespesas.Name = "btnDespesas";
            this.btnDespesas.Size = new System.Drawing.Size(197, 62);
            this.btnDespesas.TabIndex = 8;
            this.btnDespesas.Text = "         Despesas";
            this.btnDespesas.UseVisualStyleBackColor = false;
            this.btnDespesas.Click += new System.EventHandler(this.btnDespesas_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.btnRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.Image")));
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.Location = new System.Drawing.Point(21, 267);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(197, 62);
            this.btnRelatorio.TabIndex = 9;
            this.btnRelatorio.Text = "         Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnPoupanca
            // 
            this.btnPoupanca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnPoupanca.FlatAppearance.BorderSize = 0;
            this.btnPoupanca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoupanca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoupanca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.btnPoupanca.Image = ((System.Drawing.Image)(resources.GetObject("btnPoupanca.Image")));
            this.btnPoupanca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPoupanca.Location = new System.Drawing.Point(19, 335);
            this.btnPoupanca.Name = "btnPoupanca";
            this.btnPoupanca.Size = new System.Drawing.Size(197, 62);
            this.btnPoupanca.TabIndex = 10;
            this.btnPoupanca.Text = "         Poupança";
            this.btnPoupanca.UseVisualStyleBackColor = false;
            this.btnPoupanca.Click += new System.EventHandler(this.btnPoupanca_Click);
            // 
            // btnMetas
            // 
            this.btnMetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.btnMetas.FlatAppearance.BorderSize = 0;
            this.btnMetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMetas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.btnMetas.Image = ((System.Drawing.Image)(resources.GetObject("btnMetas.Image")));
            this.btnMetas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMetas.Location = new System.Drawing.Point(19, 403);
            this.btnMetas.Name = "btnMetas";
            this.btnMetas.Size = new System.Drawing.Size(197, 62);
            this.btnMetas.TabIndex = 11;
            this.btnMetas.Text = "         Metas";
            this.btnMetas.UseVisualStyleBackColor = false;
            this.btnMetas.Click += new System.EventHandler(this.btnMetas_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(20, 517);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 62);
            this.button5.TabIndex = 12;
            this.button5.Text = "         Configurações";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.panelSlide.Location = new System.Drawing.Point(1, 131);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(13, 62);
            this.panelSlide.TabIndex = 14;
            // 
            // ucRelatorios
            // 
            this.ucRelatorios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ucRelatorios.Location = new System.Drawing.Point(228, 48);
            this.ucRelatorios.Name = "ucRelatorios";
            this.ucRelatorios.Size = new System.Drawing.Size(789, 505);
            this.ucRelatorios.TabIndex = 9;
            // 
            // ucDespesas
            // 
            this.ucDespesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ucDespesas.Location = new System.Drawing.Point(228, 48);
            this.ucDespesas.Name = "ucDespesas";
            this.ucDespesas.Size = new System.Drawing.Size(780, 500);
            this.ucDespesas.TabIndex = 8;
            // 
            // ucPrincipal
            // 
            this.ucPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ucPrincipal.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ucPrincipal.Location = new System.Drawing.Point(228, 48);
            this.ucPrincipal.Name = "ucPrincipal";
            this.ucPrincipal.Size = new System.Drawing.Size(803, 500);
            this.ucPrincipal.TabIndex = 7;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1037, 585);
            this.Controls.Add(this.ucRelatorios);
            this.Controls.Add(this.ucDespesas);
            this.Controls.Add(this.ucPrincipal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnTopDespesas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuPrincipal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.pnTopDespesas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTopDespesas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnMetas;
        private System.Windows.Forms.Button btnPoupanca;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnDespesas;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.Panel panelSlide;
        private ControleUsuario.UCPrincipal ucPrincipal;
        private ControleUsuario.UCDespesas ucDespesas;
        private ControleUsuario.UCRelatorios ucRelatorios;
    }
}