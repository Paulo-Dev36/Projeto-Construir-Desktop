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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
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
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.dgvBanco = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 34);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "CADASTRO BANCO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição Banco:";
            // 
            // txtNomeInstituicao
            // 
            this.txtNomeInstituicao.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.txtNomeInstituicao.Location = new System.Drawing.Point(34, 103);
            this.txtNomeInstituicao.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeInstituicao.MaxLength = 9;
            this.txtNomeInstituicao.Name = "txtNomeInstituicao";
            this.txtNomeInstituicao.ShortcutsEnabled = false;
            this.txtNomeInstituicao.Size = new System.Drawing.Size(208, 23);
            this.txtNomeInstituicao.TabIndex = 11;
            this.txtNomeInstituicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.label1.Location = new System.Drawing.Point(325, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Agência:";
            // 
            // txtAgencia
            // 
            this.txtAgencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgencia.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.txtAgencia.Location = new System.Drawing.Point(341, 37);
            this.txtAgencia.Margin = new System.Windows.Forms.Padding(2);
            this.txtAgencia.MaxLength = 9;
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.ShortcutsEnabled = false;
            this.txtAgencia.Size = new System.Drawing.Size(141, 23);
            this.txtAgencia.TabIndex = 10;
            this.txtAgencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAgencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgencia_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.label4.Location = new System.Drawing.Point(544, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Conta Corrente:";
            // 
            // txtContaCorrente
            // 
            this.txtContaCorrente.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.txtContaCorrente.Location = new System.Drawing.Point(568, 37);
            this.txtContaCorrente.Margin = new System.Windows.Forms.Padding(2);
            this.txtContaCorrente.MaxLength = 9;
            this.txtContaCorrente.Name = "txtContaCorrente";
            this.txtContaCorrente.ShortcutsEnabled = false;
            this.txtContaCorrente.Size = new System.Drawing.Size(141, 23);
            this.txtContaCorrente.TabIndex = 9;
            this.txtContaCorrente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtContaCorrente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContaCorrente_KeyPress);
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
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.panel2.Size = new System.Drawing.Size(750, 150);
            this.panel2.TabIndex = 9;
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.txtSaldoInicial.Location = new System.Drawing.Point(341, 103);
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
            this.label6.Location = new System.Drawing.Point(317, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Saldo Atual R$:";
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.buttonAdicionar.ForeColor = System.Drawing.Color.Black;
            this.buttonAdicionar.Location = new System.Drawing.Point(774, 155);
            this.buttonAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(98, 44);
            this.buttonAdicionar.TabIndex = 12;
            this.buttonAdicionar.Text = "ADICIONAR";
            this.buttonAdicionar.UseVisualStyleBackColor = false;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.White;
            this.buttonLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.buttonLimpar.ForeColor = System.Drawing.Color.Black;
            this.buttonLimpar.Location = new System.Drawing.Point(774, 106);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(98, 44);
            this.buttonLimpar.TabIndex = 13;
            this.buttonLimpar.Text = "LIMPAR";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // dgvBanco
            // 
            this.dgvBanco.AllowUserToAddRows = false;
            this.dgvBanco.AllowUserToDeleteRows = false;
            this.dgvBanco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBanco.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBanco.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBanco.DefaultCellStyle = dataGridViewCellStyle38;
            this.dgvBanco.Location = new System.Drawing.Point(18, 232);
            this.dgvBanco.MultiSelect = false;
            this.dgvBanco.Name = "dgvBanco";
            this.dgvBanco.ReadOnly = true;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBanco.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.dgvBanco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBanco.Size = new System.Drawing.Size(854, 162);
            this.dgvBanco.TabIndex = 14;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Location = new System.Drawing.Point(774, 409);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(98, 30);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "EXCLUIR";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.buttonEdit.ForeColor = System.Drawing.Color.Black;
            this.buttonEdit.Location = new System.Drawing.Point(672, 409);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(98, 30);
            this.buttonEdit.TabIndex = 17;
            this.buttonEdit.Text = "EDITAR";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(DomainClass.Banco);
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.White;
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.buttonCancelar.ForeColor = System.Drawing.Color.Black;
            this.buttonCancelar.Location = new System.Drawing.Point(774, 106);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(98, 44);
            this.buttonCancelar.TabIndex = 14;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Visible = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.buttonModificar.ForeColor = System.Drawing.Color.Black;
            this.buttonModificar.Location = new System.Drawing.Point(774, 155);
            this.buttonModificar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(98, 44);
            this.buttonModificar.TabIndex = 15;
            this.buttonModificar.Text = "MODIFICAR";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Visible = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // frmCadastroBancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dgvBanco);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.comboBoxBanco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCadastroBancos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroBancos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dgvBanco;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonModificar;
    }
}