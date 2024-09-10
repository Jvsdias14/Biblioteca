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
            BtnSalvar.Location = new Point(620, 40);
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
            LblCodigo.Location = new Point(25, 36);
            LblCodigo.Name = "LblCodigo";
            LblCodigo.Size = new Size(22, 20);
            LblCodigo.TabIndex = 1;
            LblCodigo.Text = "Id";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(154, 36);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // TxtCodigo
            // 
            TxtCodigo.Location = new Point(25, 62);
            TxtCodigo.Name = "TxtCodigo";
            TxtCodigo.Size = new Size(107, 27);
            TxtCodigo.TabIndex = 3;
            TxtCodigo.TextChanged += TxtCodigo_TextChanged;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(154, 62);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(286, 27);
            TxtNome.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Código, Nome, BtnAlterar, BtnExcluir });
            dataGridView1.Location = new Point(22, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(755, 327);
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
            BtnFechar.Location = new Point(753, 40);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(101, 49);
            BtnFechar.TabIndex = 6;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.Location = new Point(482, 40);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(101, 49);
            BtnPesquisar.TabIndex = 7;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = true;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // FrmGenero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 450);
            Controls.Add(BtnPesquisar);
            Controls.Add(BtnFechar);
            Controls.Add(dataGridView1);
            Controls.Add(TxtNome);
            Controls.Add(TxtCodigo);
            Controls.Add(lblNome);
            Controls.Add(LblCodigo);
            Controls.Add(BtnSalvar);
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