namespace SistemaBiblioteca
{
    partial class FrmLivro
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
            dataGridViewLivro = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Editora = new DataGridViewTextBoxColumn();
            Ano = new DataGridViewTextBoxColumn();
            BtnAlterar = new DataGridViewButtonColumn();
            BtnExcluir = new DataGridViewButtonColumn();
            BtnFechar = new Button();
            BtnPesquisar = new Button();
            TxtAutor = new TextBox();
            lblAutor = new Label();
            TxtEditora = new TextBox();
            lblEditora = new Label();
            lblAno = new Label();
            TxtAno = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLivro).BeginInit();
            SuspendLayout();
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(646, 44);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(101, 49);
            BtnSalvar.TabIndex = 0;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // LblCodigo
            // 
            LblCodigo.AutoSize = true;
            LblCodigo.Location = new Point(21, 3);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(22, 20);
            LblCodigo.TabIndex = 1;
            LblCodigo.Text = "Id";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(150, 3);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 2;
            lblNome.Text = "Título";
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(21, 28);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(107, 27);
            TxtCodigo.TabIndex = 3;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(150, 28);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(286, 27);
            TxtNome.TabIndex = 4;
            // 
            // dataGridViewLivro
            // 
            dataGridViewLivro.AllowUserToAddRows = false;
            dataGridViewLivro.AllowUserToDeleteRows = false;
            dataGridViewLivro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewLivro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLivro.Columns.AddRange(new DataGridViewColumn[] { Id, Titulo, Autor, Editora, Ano, BtnAlterar, BtnExcluir });
            dataGridViewLivro.Location = new Point(22, 119);
            dataGridViewLivro.Name = "dataGridViewLivro";
            dataGridViewLivro.RowHeadersWidth = 51;
            dataGridViewLivro.Size = new Size(851, 327);
            dataGridViewLivro.TabIndex = 5;
            dataGridViewLivro.CellClick += dataGridViewLivro_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 75;
            // 
            // Titulo
            // 
            Titulo.DataPropertyName = "Titulo";
            Titulo.HeaderText = "Título";
            Titulo.MinimumWidth = 6;
            Titulo.Name = "Titulo";
            Titulo.Width = 300;
            // 
            // Autor
            // 
            Autor.DataPropertyName = "Autor";
            Autor.HeaderText = "Autor";
            Autor.MinimumWidth = 6;
            Autor.Name = "Autor";
            Autor.Width = 125;
            // 
            // Editora
            // 
            Editora.DataPropertyName = "Editora";
            Editora.HeaderText = "Editora";
            Editora.MinimumWidth = 6;
            Editora.Name = "Editora";
            Editora.Width = 125;
            // 
            // Ano
            // 
            Ano.DataPropertyName = "Ano";
            Ano.HeaderText = "Ano";
            Ano.MinimumWidth = 6;
            Ano.Name = "Ano";
            Ano.Width = 125;
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
            BtnFechar.Location = new Point(754, 44);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(101, 49);
            BtnFechar.TabIndex = 6;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.Location = new Point(539, 44);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(101, 49);
            BtnPesquisar.TabIndex = 8;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = true;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // TxtAutor
            // 
            TxtAutor.Location = new Point(21, 83);
            TxtAutor.Name = "TxtAutor";
            TxtAutor.Size = new Size(179, 27);
            TxtAutor.TabIndex = 10;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(21, 58);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(46, 20);
            lblAutor.TabIndex = 9;
            lblAutor.Text = "Autor";
            // 
            // TxtEditora
            // 
            TxtEditora.Location = new Point(206, 83);
            TxtEditora.Name = "TxtEditora";
            TxtEditora.Size = new Size(102, 27);
            TxtEditora.TabIndex = 12;
            // 
            // lblEditora
            // 
            lblEditora.AutoSize = true;
            lblEditora.Location = new Point(206, 58);
            lblEditora.Name = "lblEditora";
            lblEditora.Size = new Size(57, 20);
            lblEditora.TabIndex = 11;
            lblEditora.Text = "Editora";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Location = new Point(318, 58);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(37, 20);
            lblAno.TabIndex = 13;
            lblAno.Text = "Ano";
            // 
            // TxtAno
            // 
            TxtAno.Location = new Point(314, 83);
            TxtAno.Name = "TxtAno";
            TxtAno.Size = new Size(132, 27);
            TxtAno.TabIndex = 14;
            // 
            // FrmLivro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 455);
            Controls.Add(TxtAno);
            Controls.Add(lblAno);
            Controls.Add(TxtEditora);
            Controls.Add(lblEditora);
            Controls.Add(TxtAutor);
            Controls.Add(lblAutor);
            Controls.Add(BtnPesquisar);
            Controls.Add(BtnFechar);
            Controls.Add(dataGridViewLivro);
            Controls.Add(TxtNome);
            Controls.Add(TxtCodigo);
            Controls.Add(lblNome);
            Controls.Add(LblCodigo);
            Controls.Add(BtnSalvar);
            Name = "FrmLivro";
            Text = "Gerir Livro";
            Activated += FrmLivro_Activated;
            FormClosed += FrmLivro_FormClosed;
            Load += FrmLivro_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLivro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSalvar;
        private Label LblCodigo;
        private Label lblNome;
        private TextBox TxtCodigo;
        private TextBox TxtNome;
        private DataGridView dataGridViewLivro;
        private Button BtnFechar;
        private Button BtnPesquisar;
        private TextBox TxtAutor;
        private Label lblAutor;
        private TextBox TxtEditora;
        private Label lblEditora;
        private Label lblAno;
        private TextBox TxtAno;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Editora;
        private DataGridViewTextBoxColumn Ano;
        private DataGridViewButtonColumn BtnAlterar;
        private DataGridViewButtonColumn BtnExcluir;
    }
}
