namespace SistemaBiblioteca
{
    partial class FrmGenero
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
            dataGridView1 = new DataGridView();
            Código = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            BtnAlterar = new DataGridViewButtonColumn();
            BtnExcluir = new DataGridViewButtonColumn();
            BtnFechar = new Button();
            BtnPesquisar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            TxtCodigo.TextChanged += TxtCodigo_TextChanged;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(135, 46);
            TxtNome.Margin = new Padding(3, 2, 3, 2);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(251, 23);
            TxtNome.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Código, Nome, BtnAlterar, BtnExcluir });
            dataGridView1.Location = new Point(19, 83);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(730, 245);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Código
            // 
            Código.DataPropertyName = "Id";
            Código.HeaderText = "Id";
            Código.MinimumWidth = 6;
            Código.Name = "Código";
            Código.Width = 125;
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
            BtnPesquisar.TabIndex = 7;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = true;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // FrmGenero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 341);
            Controls.Add(BtnPesquisar);
            Controls.Add(BtnFechar);
            Controls.Add(dataGridView1);
            Controls.Add(TxtNome);
            Controls.Add(TxtCodigo);
            Controls.Add(lblNome);
            Controls.Add(LblCodigo);
            Controls.Add(BtnSalvar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmGenero";
            Text = "Cadastrar Gênero";
            Activated += FrmGenero_Activated;
            FormClosed += FrmGenero_FormClosed;
            Load += FrmGenero_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSalvar;
        private Label LblCodigo;
        private Label lblNome;
        private TextBox TxtCodigo;
        private TextBox TxtNome;
        private DataGridView dataGridView1;
        private Button BtnFechar;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewButtonColumn BtnAlterar;
        private DataGridViewButtonColumn BtnExcluir;
        private Button BtnPesquisar;
    }
}