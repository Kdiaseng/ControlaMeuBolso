namespace ControlaMeuBolso.View
{
    partial class FrmCadastroRenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroRenda));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFecharCadatroRenda = new System.Windows.Forms.Button();
            this.dtDataCadastroRenda = new System.Windows.Forms.DateTimePicker();
            this.cbCategoriaRenda = new System.Windows.Forms.ComboBox();
            this.pnRenda = new System.Windows.Forms.Panel();
            this.txCustorenda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelarCadastroRenda = new System.Windows.Forms.Button();
            this.btnSalvarCadastroRenda = new System.Windows.Forms.Button();
            this.pnBotaoRenda = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnRenda.SuspendLayout();
            this.pnBotaoRenda.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(271, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cadastrar Rendimento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnFecharCadatroRenda
            // 
            this.BtnFecharCadatroRenda.FlatAppearance.BorderSize = 0;
            this.BtnFecharCadatroRenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFecharCadatroRenda.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFecharCadatroRenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.BtnFecharCadatroRenda.Image = ((System.Drawing.Image)(resources.GetObject("BtnFecharCadatroRenda.Image")));
            this.BtnFecharCadatroRenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFecharCadatroRenda.Location = new System.Drawing.Point(756, 2);
            this.BtnFecharCadatroRenda.Name = "BtnFecharCadatroRenda";
            this.BtnFecharCadatroRenda.Size = new System.Drawing.Size(43, 33);
            this.BtnFecharCadatroRenda.TabIndex = 9;
            this.BtnFecharCadatroRenda.UseVisualStyleBackColor = true;
            this.BtnFecharCadatroRenda.Click += new System.EventHandler(this.BtnFecharCadatroRenda_Click);
            // 
            // dtDataCadastroRenda
            // 
            this.dtDataCadastroRenda.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dtDataCadastroRenda.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dtDataCadastroRenda.Location = new System.Drawing.Point(519, 68);
            this.dtDataCadastroRenda.Name = "dtDataCadastroRenda";
            this.dtDataCadastroRenda.Size = new System.Drawing.Size(241, 20);
            this.dtDataCadastroRenda.TabIndex = 1;
            // 
            // cbCategoriaRenda
            // 
            this.cbCategoriaRenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.cbCategoriaRenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriaRenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCategoriaRenda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoriaRenda.ForeColor = System.Drawing.Color.White;
            this.cbCategoriaRenda.FormattingEnabled = true;
            this.cbCategoriaRenda.Location = new System.Drawing.Point(149, 62);
            this.cbCategoriaRenda.Name = "cbCategoriaRenda";
            this.cbCategoriaRenda.Size = new System.Drawing.Size(155, 27);
            this.cbCategoriaRenda.TabIndex = 4;
            // 
            // pnRenda
            // 
            this.pnRenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.pnRenda.Controls.Add(this.txCustorenda);
            this.pnRenda.Controls.Add(this.label2);
            this.pnRenda.Controls.Add(this.label4);
            this.pnRenda.Controls.Add(this.cbCategoriaRenda);
            this.pnRenda.ForeColor = System.Drawing.Color.White;
            this.pnRenda.Location = new System.Drawing.Point(33, 144);
            this.pnRenda.Name = "pnRenda";
            this.pnRenda.Size = new System.Drawing.Size(727, 122);
            this.pnRenda.TabIndex = 16;
            // 
            // txCustorenda
            // 
            this.txCustorenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.txCustorenda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCustorenda.ForeColor = System.Drawing.Color.White;
            this.txCustorenda.Location = new System.Drawing.Point(378, 62);
            this.txCustorenda.Name = "txCustorenda";
            this.txCustorenda.Size = new System.Drawing.Size(155, 27);
            this.txCustorenda.TabIndex = 7;
            this.txCustorenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txCustorenda_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(373, 21);
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
            this.label4.Location = new System.Drawing.Point(144, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Categoria:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancelarCadastroRenda
            // 
            this.btnCancelarCadastroRenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.btnCancelarCadastroRenda.FlatAppearance.BorderSize = 0;
            this.btnCancelarCadastroRenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCadastroRenda.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCadastroRenda.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCadastroRenda.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarCadastroRenda.Image")));
            this.btnCancelarCadastroRenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCadastroRenda.Location = new System.Drawing.Point(149, 23);
            this.btnCancelarCadastroRenda.Name = "btnCancelarCadastroRenda";
            this.btnCancelarCadastroRenda.Size = new System.Drawing.Size(155, 41);
            this.btnCancelarCadastroRenda.TabIndex = 9;
            this.btnCancelarCadastroRenda.Text = "         Cancelar";
            this.btnCancelarCadastroRenda.UseVisualStyleBackColor = false;
            this.btnCancelarCadastroRenda.Click += new System.EventHandler(this.btnCancelarCadastroRenda_Click);
            // 
            // btnSalvarCadastroRenda
            // 
            this.btnSalvarCadastroRenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.btnSalvarCadastroRenda.FlatAppearance.BorderSize = 0;
            this.btnSalvarCadastroRenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarCadastroRenda.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCadastroRenda.ForeColor = System.Drawing.Color.White;
            this.btnSalvarCadastroRenda.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarCadastroRenda.Image")));
            this.btnSalvarCadastroRenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarCadastroRenda.Location = new System.Drawing.Point(378, 23);
            this.btnSalvarCadastroRenda.Name = "btnSalvarCadastroRenda";
            this.btnSalvarCadastroRenda.Size = new System.Drawing.Size(155, 41);
            this.btnSalvarCadastroRenda.TabIndex = 13;
            this.btnSalvarCadastroRenda.Text = "         Salvar";
            this.btnSalvarCadastroRenda.UseVisualStyleBackColor = false;
            this.btnSalvarCadastroRenda.Click += new System.EventHandler(this.btnSalvarCadastroRenda_Click);
            // 
            // pnBotaoRenda
            // 
            this.pnBotaoRenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(51)))), ((int)(((byte)(77)))));
            this.pnBotaoRenda.Controls.Add(this.btnCancelarCadastroRenda);
            this.pnBotaoRenda.Controls.Add(this.btnSalvarCadastroRenda);
            this.pnBotaoRenda.Location = new System.Drawing.Point(33, 293);
            this.pnBotaoRenda.Name = "pnBotaoRenda";
            this.pnBotaoRenda.Size = new System.Drawing.Size(727, 90);
            this.pnBotaoRenda.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(169)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnFecharCadatroRenda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 39);
            this.panel1.TabIndex = 15;
            // 
            // FrmCadastroRenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.pnRenda);
            this.Controls.Add(this.pnBotaoRenda);
            this.Controls.Add(this.dtDataCadastroRenda);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastroRenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCadastroRenda_Load);
            this.pnRenda.ResumeLayout(false);
            this.pnRenda.PerformLayout();
            this.pnBotaoRenda.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFecharCadatroRenda;
        private System.Windows.Forms.DateTimePicker dtDataCadastroRenda;
        private System.Windows.Forms.ComboBox cbCategoriaRenda;
        private System.Windows.Forms.Panel pnRenda;
        private System.Windows.Forms.TextBox txCustorenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelarCadastroRenda;
        private System.Windows.Forms.Button btnSalvarCadastroRenda;
        private System.Windows.Forms.Panel pnBotaoRenda;
        private System.Windows.Forms.Panel panel1;
    }
}