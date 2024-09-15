using System.Windows.Forms;

namespace SistemaBiblioteca
{
    partial class FrmAutor
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
            BtnSalvar = new Button();
            LblCodigo = new Label();
            lblNome = new Label();
            TxtCodigo = new TextBox();
            TxtNome = new TextBox();
            dataGridViewAutor = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            BtnAlterar = new DataGridViewButtonColumn();
            BtnExcluir = new DataGridViewButtonColumn();
            BtnFechar = new Button();
            BtnPesquisar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAutor).BeginInit();
            SuspendLayout();
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(498, 30);
            BtnSalvar.Margin = new Padding(3, 2, 3, 2);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(88, 37);
            BtnSalvar.TabIndex = 0;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // LblCodigo
            // 
            LblCodigo.AutoSize = true;
            LblCodigo.Location = new Point(22, 27);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(17, 15);
            LblCodigo.TabIndex = 1;
            LblCodigo.Text = "Id";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(135, 27);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(22, 46);
            TxtCodigo.Margin = new Padding(3, 2, 3, 2);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(94, 23);
            TxtCodigo.TabIndex = 3;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(135, 46);
            TxtNome.Margin = new Padding(3, 2, 3, 2);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(251, 23);
            TxtNome.TabIndex = 4;
            // 
            // dataGridViewAutor
            // 
            dataGridViewAutor.AllowUserToAddRows = false;
            dataGridViewAutor.AllowUserToDeleteRows = false;
            dataGridViewAutor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAutor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAutor.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, BtnAlterar, BtnExcluir });
            dataGridViewAutor.Location = new Point(19, 83);
            dataGridViewAutor.Margin = new Padding(3, 2, 3, 2);
            dataGridViewAutor.Name = "dataGridViewAutor";
            dataGridViewAutor.RowHeadersWidth = 51;
            dataGridViewAutor.Size = new Size(730, 245);
            dataGridViewAutor.TabIndex = 5;
            dataGridViewAutor.CellClick += dataGridViewAutor_CellClick;

            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.Width = 300;
            // 
            // BtnAlterar
            // 
            BtnAlterar.DataPropertyName = "BtnAlterar";
            BtnAlterar.HeaderText = "Alterar";
            BtnAlterar.MinimumWidth = 6;
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Width = 125;
            // 
            // BtnExcluir
            // 
            BtnExcluir.DataPropertyName = "BtnExcluir";
            BtnExcluir.HeaderText = "Excluir";
            BtnExcluir.MinimumWidth = 6;
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Text = "X";
            BtnExcluir.Width = 125;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(592, 30);
            BtnFechar.Margin = new Padding(3, 2, 3, 2);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(88, 37);
            BtnFechar.TabIndex = 6;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.Location = new Point(404, 30);
            BtnPesquisar.Margin = new Padding(3, 2, 3, 2);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(88, 37);
            BtnPesquisar.TabIndex = 8;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // FrmAutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 341);
            Controls.Add(BtnPesquisar);
            Controls.Add(BtnFechar);
            Controls.Add(dataGridViewAutor);
            Controls.Add(TxtNome);
            Controls.Add(TxtCodigo);
            Controls.Add(lblNome);
            Controls.Add(LblCodigo);
            Controls.Add(BtnSalvar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmAutor";
            Text = "Cadastrar Autor";
            Activated += FrmAutor_Activated;
            FormClosed += FrmAutor_FormClosed;
            Load += FrmAutor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAutor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSalvar;
        private Label LblCodigo;
        private Label lblNome;
        private TextBox TxtCodigo;
        private TextBox TxtNome;
        private DataGridView dataGridViewAutor;
        private Button BtnFechar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewButtonColumn BtnAlterar;
        private DataGridViewButtonColumn BtnExcluir;
        private Button BtnPesquisar;
    }
}