namespace wfaCaminhão
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbOnibus = new System.Windows.Forms.RadioButton();
            this.rbCaminhao = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbPlaca = new System.Windows.Forms.MaskedTextBox();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.lv1 = new System.Windows.Forms.ListView();
            this.colPlaca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAssentos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEixos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbAssentos = new System.Windows.Forms.TextBox();
            this.tbEixos = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCaminhao = new System.Windows.Forms.Panel();
            this.pnlOnibus = new System.Windows.Forms.Panel();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pnlCaminhao.SuspendLayout();
            this.pnlOnibus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbOnibus
            // 
            this.rbOnibus.AutoSize = true;
            this.rbOnibus.Location = new System.Drawing.Point(20, 10);
            this.rbOnibus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbOnibus.Name = "rbOnibus";
            this.rbOnibus.Size = new System.Drawing.Size(58, 17);
            this.rbOnibus.TabIndex = 0;
            this.rbOnibus.TabStop = true;
            this.rbOnibus.Text = "Ônibus";
            this.rbOnibus.UseVisualStyleBackColor = true;
            this.rbOnibus.CheckedChanged += new System.EventHandler(this.rbOnibus_CheckedChanged);
            // 
            // rbCaminhao
            // 
            this.rbCaminhao.AutoSize = true;
            this.rbCaminhao.Location = new System.Drawing.Point(133, 10);
            this.rbCaminhao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCaminhao.Name = "rbCaminhao";
            this.rbCaminhao.Size = new System.Drawing.Size(72, 17);
            this.rbCaminhao.TabIndex = 1;
            this.rbCaminhao.TabStop = true;
            this.rbCaminhao.Text = "Caminhão";
            this.rbCaminhao.UseVisualStyleBackColor = true;
            this.rbCaminhao.CheckedChanged += new System.EventHandler(this.rbCaminhao_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Placa:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mtbPlaca
            // 
            this.mtbPlaca.Location = new System.Drawing.Point(138, 38);
            this.mtbPlaca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbPlaca.Mask = "LLL-0000";
            this.mtbPlaca.Name = "mtbPlaca";
            this.mtbPlaca.Size = new System.Drawing.Size(76, 20);
            this.mtbPlaca.TabIndex = 3;
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(138, 61);
            this.tbAno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(76, 20);
            this.tbAno.TabIndex = 4;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(52, 174);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(94, 32);
            this.btCadastrar.TabIndex = 5;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // lv1
            // 
            this.lv1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPlaca,
            this.colAno,
            this.colAssentos,
            this.colEixos,
            this.colDiaria});
            this.lv1.HideSelection = false;
            this.lv1.Location = new System.Drawing.Point(9, 210);
            this.lv1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(420, 134);
            this.lv1.TabIndex = 6;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.View = System.Windows.Forms.View.Details;
            this.lv1.SelectedIndexChanged += new System.EventHandler(this.lv1_SelectedIndexChanged);
            // 
            // colPlaca
            // 
            this.colPlaca.Text = "Placa";
            this.colPlaca.Width = 87;
            // 
            // colAno
            // 
            this.colAno.Text = "Ano";
            this.colAno.Width = 48;
            // 
            // colAssentos
            // 
            this.colAssentos.Text = "Assentos";
            this.colAssentos.Width = 72;
            // 
            // colEixos
            // 
            this.colEixos.Text = "Eixos";
            this.colEixos.Width = 51;
            // 
            // colDiaria
            // 
            this.colDiaria.Text = "Diaria";
            this.colDiaria.Width = 315;
            // 
            // tbAssentos
            // 
            this.tbAssentos.Location = new System.Drawing.Point(110, 2);
            this.tbAssentos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAssentos.Name = "tbAssentos";
            this.tbAssentos.Size = new System.Drawing.Size(76, 20);
            this.tbAssentos.TabIndex = 8;
            // 
            // tbEixos
            // 
            this.tbEixos.Location = new System.Drawing.Point(100, 5);
            this.tbEixos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEixos.Name = "tbEixos";
            this.tbEixos.Size = new System.Drawing.Size(76, 20);
            this.tbEixos.TabIndex = 9;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(281, 174);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(94, 32);
            this.btLimpar.TabIndex = 10;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Qtadade de Eixos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Qtdade de Assentos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ano:";
            // 
            // pnlCaminhao
            // 
            this.pnlCaminhao.Controls.Add(this.label2);
            this.pnlCaminhao.Controls.Add(this.tbEixos);
            this.pnlCaminhao.Location = new System.Drawing.Point(36, 84);
            this.pnlCaminhao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlCaminhao.Name = "pnlCaminhao";
            this.pnlCaminhao.Size = new System.Drawing.Size(204, 24);
            this.pnlCaminhao.TabIndex = 14;
            // 
            // pnlOnibus
            // 
            this.pnlOnibus.Controls.Add(this.tbAssentos);
            this.pnlOnibus.Controls.Add(this.label3);
            this.pnlOnibus.Location = new System.Drawing.Point(27, 84);
            this.pnlOnibus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlOnibus.Name = "pnlOnibus";
            this.pnlOnibus.Size = new System.Drawing.Size(204, 24);
            this.pnlOnibus.TabIndex = 15;
            // 
            // pb1
            // 
            this.pb1.Image = global::wfaCaminhão.Properties.Resources.Caminhao2;
            this.pb1.Location = new System.Drawing.Point(266, 41);
            this.pb1.Margin = new System.Windows.Forms.Padding(2);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(131, 111);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 7;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 353);
            this.Controls.Add(this.pnlOnibus);
            this.Controls.Add(this.pnlCaminhao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lv1);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.mtbPlaca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbCaminhao);
            this.Controls.Add(this.rbOnibus);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCaminhao.ResumeLayout(false);
            this.pnlCaminhao.PerformLayout();
            this.pnlOnibus.ResumeLayout(false);
            this.pnlOnibus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbOnibus;
        private System.Windows.Forms.RadioButton rbCaminhao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbPlaca;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.TextBox tbAssentos;
        private System.Windows.Forms.TextBox tbEixos;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlCaminhao;
        private System.Windows.Forms.Panel pnlOnibus;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ColumnHeader colPlaca;
        private System.Windows.Forms.ColumnHeader colAno;
        private System.Windows.Forms.ColumnHeader colAssentos;
        private System.Windows.Forms.ColumnHeader colEixos;
        private System.Windows.Forms.ColumnHeader colDiaria;
    }
}

