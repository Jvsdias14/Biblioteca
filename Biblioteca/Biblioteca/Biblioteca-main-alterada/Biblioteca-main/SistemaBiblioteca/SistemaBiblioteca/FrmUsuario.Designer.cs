namespace SistemaBiblioteca
{
    partial class FrmUsuario
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
            dataGridViewUsuario = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Senha = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            BtnAlterar = new DataGridViewButtonColumn();
            BtnExcluir = new DataGridViewButtonColumn();
            BtnFechar = new Button();
            BtnPesquisar = new Button();
            TxtEmail = new TextBox();
            lblEmail = new Label();
            TxtSenha = new TextBox();
            lblSenha = new Label();
            lblTipo = new Label();
            UsuariocomboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuario).BeginInit();
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
            lblNome.Text = "Nome";
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
            // dataGridViewUsuario
            // 
            dataGridViewUsuario.AllowUserToAddRows = false;
            dataGridViewUsuario.AllowUserToDeleteRows = false;
            dataGridViewUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuario.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Email, Senha, Tipo, BtnAlterar, BtnExcluir });
            dataGridViewUsuario.Location = new Point(22, 119);
            dataGridViewUsuario.Name = "dataGridViewUsuario";
            dataGridViewUsuario.RowHeadersWidth = 51;
            dataGridViewUsuario.Size = new Size(851, 327);
            dataGridViewUsuario.TabIndex = 5;
            dataGridViewUsuario.CellClick += dataGridViewUsuario_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 75;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.Width = 300;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // Senha
            // 
            Senha.DataPropertyName = "Senha";
            Senha.HeaderText = "Senha";
            Senha.MinimumWidth = 6;
            Senha.Name = "Senha";
            Senha.Width = 125;
            // 
            // Tipo
            // 
            Tipo.DataPropertyName = "Tipo";
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            Tipo.Width = 125;
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
            // TxtEmail
            // 
            TxtEmail.Location = new Point(21, 83);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(179, 27);
            TxtEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(21, 58);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(206, 83);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(102, 27);
            TxtSenha.TabIndex = 12;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(206, 58);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(49, 20);
            lblSenha.TabIndex = 11;
            lblSenha.Text = "Senha";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(318, 58);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(39, 20);
            lblTipo.TabIndex = 13;
            lblTipo.Text = "Tipo";
            // 
            // UsuariocomboBox
            // 
            UsuariocomboBox.FormattingEnabled = true;
            UsuariocomboBox.Items.AddRange(new object[] { "Administrador", "Atendente", "Bibliotecario" });
            UsuariocomboBox.Location = new Point(314, 83);
            UsuariocomboBox.Name = "UsuariocomboBox";
            UsuariocomboBox.Size = new Size(132, 28);
            UsuariocomboBox.TabIndex = 14;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 455);
            Controls.Add(UsuariocomboBox);
            Controls.Add(lblTipo);
            Controls.Add(TxtSenha);
            Controls.Add(lblSenha);
            Controls.Add(TxtEmail);
            Controls.Add(lblEmail);
            Controls.Add(BtnPesquisar);
            Controls.Add(BtnFechar);
            Controls.Add(dataGridViewUsuario);
            Controls.Add(TxtNome);
            Controls.Add(TxtCodigo);
            Controls.Add(lblNome);
            Controls.Add(LblCodigo);
            Controls.Add(BtnSalvar);
            Name = "FrmUsuario";
            Text = "Gerir Usuario";
            Activated += FrmUsuario_Activated;
            FormClosed += FrmUsuario_FormClosed;
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSalvar;
        private Label LblCodigo;
        private Label lblNome;
        private TextBox TxtCodigo;
        private TextBox TxtNome;
        private DataGridView dataGridViewUsuario;
        private Button BtnFechar;
        private Button BtnPesquisar;
        private TextBox TxtEmail;
        private Label lblEmail;
        private TextBox TxtSenha;
        private Label lblSenha;
        private Label lblTipo;
        private ComboBox UsuariocomboBox;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Senha;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewButtonColumn BtnAlterar;
        private DataGridViewButtonColumn BtnExcluir;
    }
}
