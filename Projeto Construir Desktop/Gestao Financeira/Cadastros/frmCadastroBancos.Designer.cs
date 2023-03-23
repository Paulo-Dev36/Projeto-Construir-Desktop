namespace Projeto_Construir_Desktop.Gestao_Financeira.Cadastros
{
    partial class frmCadastroBancos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeInstituicao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContaCorrente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxBanco = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSaldoInicial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 45);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "CADASTRO BANCO";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Projeto_Construir_Desktop.Properties.Resources.cancel__1_;
            this.btnClose.Location = new System.Drawing.Point(572, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 40);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.label2.Location = new System.Drawing.Point(222, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome da Instiuição:";
            // 
            // txtNomeInstituicao
            // 
            this.txtNomeInstituicao.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.txtNomeInstituicao.Location = new System.Drawing.Point(246, 103);
            this.txtNomeInstituicao.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeInstituicao.MaxLength = 9;
            this.txtNomeInstituicao.Name = "txtNomeInstituicao";
            this.txtNomeInstituicao.ShortcutsEnabled = false;
            this.txtNomeInstituicao.Size = new System.Drawing.Size(141, 23);
            this.txtNomeInstituicao.TabIndex = 11;
            this.txtNomeInstituicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.label1.Location = new System.Drawing.Point(19, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Agência:";
            // 
            // txtAgencia
            // 
            this.txtAgencia.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.txtAgencia.Location = new System.Drawing.Point(35, 103);
            this.txtAgencia.Margin = new System.Windows.Forms.Padding(2);
            this.txtAgencia.MaxLength = 9;
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.ShortcutsEnabled = false;
            this.txtAgencia.Size = new System.Drawing.Size(141, 23);
            this.txtAgencia.TabIndex = 10;
            this.txtAgencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.label4.Location = new System.Drawing.Point(271, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Conta Corrente:";
            // 
            // txtContaCorrente
            // 
            this.txtContaCorrente.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.txtContaCorrente.Location = new System.Drawing.Point(295, 39);
            this.txtContaCorrente.Margin = new System.Windows.Forms.Padding(2);
            this.txtContaCorrente.MaxLength = 9;
            this.txtContaCorrente.Name = "txtContaCorrente";
            this.txtContaCorrente.ShortcutsEnabled = false;
            this.txtContaCorrente.Size = new System.Drawing.Size(141, 23);
            this.txtContaCorrente.TabIndex = 9;
            this.txtContaCorrente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.label5.Location = new System.Drawing.Point(40, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Instituição Bancária:";
            // 
            // comboBoxBanco
            // 
            this.comboBoxBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBanco.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBanco.FormattingEnabled = true;
            this.comboBoxBanco.Location = new System.Drawing.Point(53, 90);
            this.comboBoxBanco.Name = "comboBoxBanco";
            this.comboBoxBanco.Size = new System.Drawing.Size(208, 22);
            this.comboBoxBanco.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtSaldoInicial);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtContaCorrente);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtAgencia);
            this.panel2.Controls.Add(this.txtNomeInstituicao);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(18, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 150);
            this.panel2.TabIndex = 9;
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.txtSaldoInicial.Location = new System.Drawing.Point(437, 103);
            this.txtSaldoInicial.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaldoInicial.MaxLength = 9;
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.ShortcutsEnabled = false;
            this.txtSaldoInicial.Size = new System.Drawing.Size(141, 23);
            this.txtSaldoInicial.TabIndex = 12;
            this.txtSaldoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.label6.Location = new System.Drawing.Point(421, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Saldo Atual R$:";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(18, 286);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(593, 224);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.BackColor = System.Drawing.Color.White;
            this.buttonAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.buttonAdicionar.ForeColor = System.Drawing.Color.Black;
            this.buttonAdicionar.Location = new System.Drawing.Point(513, 206);
            this.buttonAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(98, 44);
            this.buttonAdicionar.TabIndex = 12;
            this.buttonAdicionar.Text = "ADICIONAR";
            this.buttonAdicionar.UseVisualStyleBackColor = false;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.White;
            this.buttonLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.buttonLimpar.ForeColor = System.Drawing.Color.Black;
            this.buttonLimpar.Location = new System.Drawing.Point(410, 206);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(98, 44);
            this.buttonLimpar.TabIndex = 13;
            this.buttonLimpar.Text = "LIMPAR";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // frmCadastroBancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(635, 522);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBoxBanco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastroBancos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroBancos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeInstituicao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContaCorrente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxBanco;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSaldoInicial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonLimpar;
    }
}