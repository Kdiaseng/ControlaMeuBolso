namespace ControlaMeuBolso.View
{
    partial class FrmCadastroDespesas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroDespesas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFecharCadatro = new System.Windows.Forms.Button();
            this.dtDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.rbDesepesasPendentes = new System.Windows.Forms.RadioButton();
            this.rbDespesasPagas = new System.Windows.Forms.RadioButton();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.pnDespesasP = new System.Windows.Forms.Panel();
            this.txCusto = new System.Windows.Forms.TextBox();
            this.pnCategoriaCusto = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelarCadastro = new System.Windows.Forms.Button();
            this.btnSalvarCadastro = new System.Windows.Forms.Button();
            this.pnBotao = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnDespesasP.SuspendLayout();
            this.pnCategoriaCusto.SuspendLayout();
            this.pnBotao.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnFecharCadatro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 39);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(319, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nova despesa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnFecharCadatro
            // 
            this.BtnFecharCadatro.FlatAppearance.BorderSize = 0;
            this.BtnFecharCadatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFecharCadatro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFecharCadatro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.BtnFecharCadatro.Image = ((System.Drawing.Image)(resources.GetObject("BtnFecharCadatro.Image")));
            this.BtnFecharCadatro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFecharCadatro.Location = new System.Drawing.Point(756, 2);
            this.BtnFecharCadatro.Name = "BtnFecharCadatro";
            this.BtnFecharCadatro.Size = new System.Drawing.Size(43, 33);
            this.BtnFecharCadatro.TabIndex = 9;
            this.BtnFecharCadatro.UseVisualStyleBackColor = true;
            this.BtnFecharCadatro.Click += new System.EventHandler(this.BtnFecharCadatro_Click);
            // 
            // dtDataCadastro
            // 
            this.dtDataCadastro.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataCadastro.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dtDataCadastro.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dtDataCadastro.Location = new System.Drawing.Point(477, 18);
            this.dtDataCadastro.Name = "dtDataCadastro";
            this.dtDataCadastro.Size = new System.Drawing.Size(241, 20);
            this.dtDataCadastro.TabIndex = 1;
            // 
            // rbDesepesasPendentes
            // 
            this.rbDesepesasPendentes.AutoSize = true;
            this.rbDesepesasPendentes.Checked = true;
            this.rbDesepesasPendentes.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.rbDesepesasPendentes.ForeColor = System.Drawing.Color.White;
            this.rbDesepesasPendentes.Location = new System.Drawing.Point(157, 10);
            this.rbDesepesasPendentes.Name = "rbDesepesasPendentes";
            this.rbDesepesasPendentes.Size = new System.Drawing.Size(233, 34);
            this.rbDesepesasPendentes.TabIndex = 2;
            this.rbDesepesasPendentes.TabStop = true;
            this.rbDesepesasPendentes.Text = "Despesas Pendentes";
            this.rbDesepesasPendentes.UseVisualStyleBackColor = true;
            this.rbDesepesasPendentes.CheckedChanged += new System.EventHandler(this.rbDesepesasPendentes_CheckedChanged);
            // 
            // rbDespesasPagas
            // 
            this.rbDespesasPagas.AutoSize = true;
            this.rbDespesasPagas.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.rbDespesasPagas.Location = new System.Drawing.Point(157, 50);
            this.rbDespesasPagas.Name = "rbDespesasPagas";
            this.rbDespesasPagas.Size = new System.Drawing.Size(188, 34);
            this.rbDespesasPagas.TabIndex = 3;
            this.rbDespesasPagas.Text = "Despesas Pagas";
            this.rbDespesasPagas.UseVisualStyleBackColor = true;
            this.rbDespesasPagas.CheckedChanged += new System.EventHandler(this.rbDespesasPagas_CheckedChanged);
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.ForeColor = System.Drawing.Color.White;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(149, 48);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(155, 27);
            this.cbCategoria.TabIndex = 4;
            // 
            // pnDespesasP
            // 
            this.pnDespesasP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.pnDespesasP.Controls.Add(this.rbDespesasPagas);
            this.pnDespesasP.Controls.Add(this.rbDesepesasPendentes);
            this.pnDespesasP.Controls.Add(this.dtDataCadastro);
            this.pnDespesasP.ForeColor = System.Drawing.Color.White;
            this.pnDespesasP.Location = new System.Drawing.Point(34, 61);
            this.pnDespesasP.Name = "pnDespesasP";
            this.pnDespesasP.Size = new System.Drawing.Size(756, 87);
            this.pnDespesasP.TabIndex = 5;
            // 
            // txCusto
            // 
            this.txCusto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.txCusto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCusto.ForeColor = System.Drawing.Color.White;
            this.txCusto.Location = new System.Drawing.Point(378, 49);
            this.txCusto.Name = "txCusto";
            this.txCusto.Size = new System.Drawing.Size(155, 27);
            this.txCusto.TabIndex = 7;
            this.txCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txCusto_KeyPress);
            // 
            // pnCategoriaCusto
            // 
            this.pnCategoriaCusto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.pnCategoriaCusto.Controls.Add(this.label2);
            this.pnCategoriaCusto.Controls.Add(this.label4);
            this.pnCategoriaCusto.Controls.Add(this.txCusto);
            this.pnCategoriaCusto.Controls.Add(this.cbCategoria);
            this.pnCategoriaCusto.Location = new System.Drawing.Point(34, 172);
            this.pnCategoriaCusto.Name = "pnCategoriaCusto";
            this.pnCategoriaCusto.Size = new System.Drawing.Size(756, 94);
            this.pnCategoriaCusto.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(373, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Custo R$:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(152, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Categoria:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancelarCadastro
            // 
            this.btnCancelarCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.btnCancelarCadastro.FlatAppearance.BorderSize = 0;
            this.btnCancelarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCadastro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarCadastro.Image")));
            this.btnCancelarCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCadastro.Location = new System.Drawing.Point(149, 23);
            this.btnCancelarCadastro.Name = "btnCancelarCadastro";
            this.btnCancelarCadastro.Size = new System.Drawing.Size(155, 41);
            this.btnCancelarCadastro.TabIndex = 9;
            this.btnCancelarCadastro.Text = "         Cancelar";
            this.btnCancelarCadastro.UseVisualStyleBackColor = false;
            this.btnCancelarCadastro.Click += new System.EventHandler(this.btnCancelarCadastro_Click);
            // 
            // btnSalvarCadastro
            // 
            this.btnSalvarCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.btnSalvarCadastro.FlatAppearance.BorderSize = 0;
            this.btnSalvarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarCadastro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCadastro.ForeColor = System.Drawing.Color.White;
            this.btnSalvarCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarCadastro.Image")));
            this.btnSalvarCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarCadastro.Location = new System.Drawing.Point(378, 23);
            this.btnSalvarCadastro.Name = "btnSalvarCadastro";
            this.btnSalvarCadastro.Size = new System.Drawing.Size(155, 41);
            this.btnSalvarCadastro.TabIndex = 13;
            this.btnSalvarCadastro.Text = "         Salvar";
            this.btnSalvarCadastro.UseVisualStyleBackColor = false;
            this.btnSalvarCadastro.Click += new System.EventHandler(this.btnSalvarCadastro_Click_1);
            // 
            // pnBotao
            // 
            this.pnBotao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.pnBotao.Controls.Add(this.btnCancelarCadastro);
            this.pnBotao.Controls.Add(this.btnSalvarCadastro);
            this.pnBotao.Location = new System.Drawing.Point(34, 300);
            this.pnBotao.Name = "pnBotao";
            this.pnBotao.Size = new System.Drawing.Size(756, 90);
            this.pnBotao.TabIndex = 14;
            // 
            // FrmCadastroDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.pnBotao);
            this.Controls.Add(this.pnCategoriaCusto);
            this.Controls.Add(this.pnDespesasP);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastroDespesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastroDespesas";
            this.Load += new System.EventHandler(this.FrmCadastroDespesas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnDespesasP.ResumeLayout(false);
            this.pnDespesasP.PerformLayout();
            this.pnCategoriaCusto.ResumeLayout(false);
            this.pnCategoriaCusto.PerformLayout();
            this.pnBotao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnFecharCadatro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDataCadastro;
        private System.Windows.Forms.RadioButton rbDesepesasPendentes;
        private System.Windows.Forms.RadioButton rbDespesasPagas;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Panel pnDespesasP;
        private System.Windows.Forms.TextBox txCusto;
        private System.Windows.Forms.Panel pnCategoriaCusto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelarCadastro;
        private System.Windows.Forms.Button btnSalvarCadastro;
        private System.Windows.Forms.Panel pnBotao;
    }
}