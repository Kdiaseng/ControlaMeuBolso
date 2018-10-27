namespace ControlaMeuBolso.View.ControleUsuario
{
    partial class UCRelatorios
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRelatorios));
            this.pnBaixoRelatorio = new System.Windows.Forms.Panel();
            this.cpDespesasRelatorio = new CircularProgressBar.CircularProgressBar();
            this.dataGridRelatorios = new System.Windows.Forms.DataGridView();
            this.pnRelarioCima = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.cbMesesRelatorio = new System.Windows.Forms.ComboBox();
            this.cbCategoriaRelatorio = new System.Windows.Forms.ComboBox();
            this.rbDespesasPendentes = new System.Windows.Forms.RadioButton();
            this.rbRedimentos = new System.Windows.Forms.RadioButton();
            this.btnPesquisarRelario = new System.Windows.Forms.Button();
            this.rbDespesasPagas = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbValorPdespesas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbValorTotalDespesas = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.pnBaixoRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelatorios)).BeginInit();
            this.pnRelarioCima.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBaixoRelatorio
            // 
            this.pnBaixoRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.pnBaixoRelatorio.Controls.Add(this.panel1);
            this.pnBaixoRelatorio.Controls.Add(this.dataGridRelatorios);
            this.pnBaixoRelatorio.Location = new System.Drawing.Point(19, 126);
            this.pnBaixoRelatorio.Name = "pnBaixoRelatorio";
            this.pnBaixoRelatorio.Size = new System.Drawing.Size(757, 345);
            this.pnBaixoRelatorio.TabIndex = 4;
            // 
            // cpDespesasRelatorio
            // 
            this.cpDespesasRelatorio.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpDespesasRelatorio.AnimationSpeed = 500;
            this.cpDespesasRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.cpDespesasRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.cpDespesasRelatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpDespesasRelatorio.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.cpDespesasRelatorio.InnerMargin = 2;
            this.cpDespesasRelatorio.InnerWidth = -1;
            this.cpDespesasRelatorio.Location = new System.Drawing.Point(23, 44);
            this.cpDespesasRelatorio.MarqueeAnimationSpeed = 2000;
            this.cpDespesasRelatorio.Name = "cpDespesasRelatorio";
            this.cpDespesasRelatorio.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.cpDespesasRelatorio.OuterMargin = -25;
            this.cpDespesasRelatorio.OuterWidth = 26;
            this.cpDespesasRelatorio.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(187)))), ((int)(((byte)(225)))));
            this.cpDespesasRelatorio.ProgressWidth = 20;
            this.cpDespesasRelatorio.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpDespesasRelatorio.Size = new System.Drawing.Size(156, 150);
            this.cpDespesasRelatorio.StartAngle = 0;
            this.cpDespesasRelatorio.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(187)))), ((int)(((byte)(225)))));
            this.cpDespesasRelatorio.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpDespesasRelatorio.SubscriptText = ".23";
            this.cpDespesasRelatorio.SuperscriptColor = System.Drawing.Color.Gray;
            this.cpDespesasRelatorio.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpDespesasRelatorio.SuperscriptText = "°C";
            this.cpDespesasRelatorio.TabIndex = 13;
            this.cpDespesasRelatorio.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpDespesasRelatorio.Value = 10;
            // 
            // dataGridRelatorios
            // 
            this.dataGridRelatorios.AllowUserToAddRows = false;
            this.dataGridRelatorios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRelatorios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRelatorios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRelatorios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.dataGridRelatorios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridRelatorios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRelatorios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridRelatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridRelatorios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridRelatorios.EnableHeadersVisualStyles = false;
            this.dataGridRelatorios.GridColor = System.Drawing.Color.White;
            this.dataGridRelatorios.Location = new System.Drawing.Point(223, 22);
            this.dataGridRelatorios.Name = "dataGridRelatorios";
            this.dataGridRelatorios.ReadOnly = true;
            this.dataGridRelatorios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRelatorios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridRelatorios.RowHeadersVisible = false;
            this.dataGridRelatorios.RowHeadersWidth = 15;
            this.dataGridRelatorios.RowTemplate.DividerHeight = 1;
            this.dataGridRelatorios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridRelatorios.Size = new System.Drawing.Size(516, 284);
            this.dataGridRelatorios.TabIndex = 0;
            // 
            // pnRelarioCima
            // 
            this.pnRelarioCima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.pnRelarioCima.Controls.Add(this.groupBox1);
            this.pnRelarioCima.Controls.Add(this.rbDespesasPendentes);
            this.pnRelarioCima.Controls.Add(this.rbRedimentos);
            this.pnRelarioCima.Controls.Add(this.btnPesquisarRelario);
            this.pnRelarioCima.Controls.Add(this.rbDespesasPagas);
            this.pnRelarioCima.ForeColor = System.Drawing.Color.Red;
            this.pnRelarioCima.Location = new System.Drawing.Point(19, 12);
            this.pnRelarioCima.Name = "pnRelarioCima";
            this.pnRelarioCima.Size = new System.Drawing.Size(755, 103);
            this.pnRelarioCima.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lb);
            this.groupBox1.Controls.Add(this.cbMesesRelatorio);
            this.groupBox1.Controls.Add(this.cbCategoriaRelatorio);
            this.groupBox1.Location = new System.Drawing.Point(218, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 83);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mês";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.White;
            this.lb.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lb.Location = new System.Drawing.Point(224, 15);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(87, 19);
            this.lb.TabIndex = 13;
            this.lb.Text = "Categoria";
            this.lb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbMesesRelatorio
            // 
            this.cbMesesRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.cbMesesRelatorio.DisplayMember = "Teste";
            this.cbMesesRelatorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMesesRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMesesRelatorio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMesesRelatorio.ForeColor = System.Drawing.Color.White;
            this.cbMesesRelatorio.FormattingEnabled = true;
            this.cbMesesRelatorio.Location = new System.Drawing.Point(19, 41);
            this.cbMesesRelatorio.Name = "cbMesesRelatorio";
            this.cbMesesRelatorio.Size = new System.Drawing.Size(155, 24);
            this.cbMesesRelatorio.TabIndex = 6;
            // 
            // cbCategoriaRelatorio
            // 
            this.cbCategoriaRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.cbCategoriaRelatorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriaRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCategoriaRelatorio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoriaRelatorio.ForeColor = System.Drawing.Color.White;
            this.cbCategoriaRelatorio.FormattingEnabled = true;
            this.cbCategoriaRelatorio.Location = new System.Drawing.Point(228, 41);
            this.cbCategoriaRelatorio.Name = "cbCategoriaRelatorio";
            this.cbCategoriaRelatorio.Size = new System.Drawing.Size(155, 24);
            this.cbCategoriaRelatorio.TabIndex = 5;
            // 
            // rbDespesasPendentes
            // 
            this.rbDespesasPendentes.AutoSize = true;
            this.rbDespesasPendentes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDespesasPendentes.ForeColor = System.Drawing.Color.White;
            this.rbDespesasPendentes.Location = new System.Drawing.Point(27, 39);
            this.rbDespesasPendentes.Name = "rbDespesasPendentes";
            this.rbDespesasPendentes.Size = new System.Drawing.Size(176, 23);
            this.rbDespesasPendentes.TabIndex = 12;
            this.rbDespesasPendentes.TabStop = true;
            this.rbDespesasPendentes.Text = "Despesas Pendente";
            this.rbDespesasPendentes.UseVisualStyleBackColor = true;
            this.rbDespesasPendentes.CheckedChanged += new System.EventHandler(this.rbDespesasPendentes_CheckedChanged);
            // 
            // rbRedimentos
            // 
            this.rbRedimentos.AutoSize = true;
            this.rbRedimentos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRedimentos.ForeColor = System.Drawing.Color.White;
            this.rbRedimentos.Location = new System.Drawing.Point(27, 70);
            this.rbRedimentos.Name = "rbRedimentos";
            this.rbRedimentos.Size = new System.Drawing.Size(117, 23);
            this.rbRedimentos.TabIndex = 11;
            this.rbRedimentos.TabStop = true;
            this.rbRedimentos.Text = "Redimentos";
            this.rbRedimentos.UseVisualStyleBackColor = true;
            this.rbRedimentos.CheckedChanged += new System.EventHandler(this.rbRedimentos_CheckedChanged);
            // 
            // btnPesquisarRelario
            // 
            this.btnPesquisarRelario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.btnPesquisarRelario.FlatAppearance.BorderSize = 0;
            this.btnPesquisarRelario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarRelario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarRelario.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarRelario.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarRelario.Image")));
            this.btnPesquisarRelario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarRelario.Location = new System.Drawing.Point(665, 23);
            this.btnPesquisarRelario.Name = "btnPesquisarRelario";
            this.btnPesquisarRelario.Size = new System.Drawing.Size(74, 69);
            this.btnPesquisarRelario.TabIndex = 10;
            this.btnPesquisarRelario.UseVisualStyleBackColor = false;
            this.btnPesquisarRelario.Click += new System.EventHandler(this.btnPesquisarRelario_Click);
            // 
            // rbDespesasPagas
            // 
            this.rbDespesasPagas.AutoSize = true;
            this.rbDespesasPagas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDespesasPagas.ForeColor = System.Drawing.Color.White;
            this.rbDespesasPagas.Location = new System.Drawing.Point(27, 8);
            this.rbDespesasPagas.Name = "rbDespesasPagas";
            this.rbDespesasPagas.Size = new System.Drawing.Size(150, 23);
            this.rbDespesasPagas.TabIndex = 7;
            this.rbDespesasPagas.TabStop = true;
            this.rbDespesasPagas.Text = "Despesas Pagas";
            this.rbDespesasPagas.UseVisualStyleBackColor = true;
            this.rbDespesasPagas.CheckedChanged += new System.EventHandler(this.rbDespesasPagas_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(52, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Despesas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbValorPdespesas
            // 
            this.lbValorPdespesas.AutoSize = true;
            this.lbValorPdespesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbValorPdespesas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorPdespesas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.lbValorPdespesas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbValorPdespesas.Location = new System.Drawing.Point(68, 105);
            this.lbValorPdespesas.Name = "lbValorPdespesas";
            this.lbValorPdespesas.Size = new System.Drawing.Size(66, 25);
            this.lbValorPdespesas.TabIndex = 18;
            this.lbValorPdespesas.Text = "100%";
            this.lbValorPdespesas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.lbTotal);
            this.panel1.Controls.Add(this.lbValorTotalDespesas);
            this.panel1.Controls.Add(this.lbValorPdespesas);
            this.panel1.Controls.Add(this.cpDespesasRelatorio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 284);
            this.panel1.TabIndex = 16;
            // 
            // lbValorTotalDespesas
            // 
            this.lbValorTotalDespesas.AutoSize = true;
            this.lbValorTotalDespesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbValorTotalDespesas.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTotalDespesas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.lbValorTotalDespesas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbValorTotalDespesas.Location = new System.Drawing.Point(30, 220);
            this.lbValorTotalDespesas.Name = "lbValorTotalDespesas";
            this.lbValorTotalDespesas.Size = new System.Drawing.Size(161, 42);
            this.lbValorTotalDespesas.TabIndex = 20;
            this.lbValorTotalDespesas.Text = "2500,00";
            this.lbValorTotalDespesas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTotal.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.lbTotal.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbTotal.Location = new System.Drawing.Point(19, 197);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(57, 23);
            this.lbTotal.TabIndex = 21;
            this.lbTotal.Text = "Total ";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UCRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.pnRelarioCima);
            this.Controls.Add(this.pnBaixoRelatorio);
            this.Name = "UCRelatorios";
            this.Size = new System.Drawing.Size(780, 505);
            this.Load += new System.EventHandler(this.UCRelatorios_Load);
            this.pnBaixoRelatorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelatorios)).EndInit();
            this.pnRelarioCima.ResumeLayout(false);
            this.pnRelarioCima.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBaixoRelatorio;
        private System.Windows.Forms.DataGridView dataGridRelatorios;
        private System.Windows.Forms.Panel pnRelarioCima;
        private System.Windows.Forms.RadioButton rbDespesasPagas;
        private System.Windows.Forms.ComboBox cbMesesRelatorio;
        private System.Windows.Forms.ComboBox cbCategoriaRelatorio;
        private System.Windows.Forms.Button btnPesquisarRelario;
        private System.Windows.Forms.RadioButton rbDespesasPendentes;
        private System.Windows.Forms.RadioButton rbRedimentos;
        private CircularProgressBar.CircularProgressBar cpDespesasRelatorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbValorTotalDespesas;
        private System.Windows.Forms.Label lbValorPdespesas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotal;
    }
}
