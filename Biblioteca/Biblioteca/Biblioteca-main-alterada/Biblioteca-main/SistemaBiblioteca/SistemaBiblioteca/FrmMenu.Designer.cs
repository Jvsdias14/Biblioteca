namespace SistemaBiblioteca
{
    partial class FrmMenu
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
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            gêneroToolStripMenuItem = new ToolStripMenuItem();
            autorToolStripMenuItem = new ToolStripMenuItem();
            editoraToolStripMenuItem = new ToolStripMenuItem();
            idiomaToolStripMenuItem = new ToolStripMenuItem();
            usuariotoolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            MenuSuspenso = new ContextMenuStrip(components);
            sairMenuSuspenso = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            menuStrip.SuspendLayout();
            MenuSuspenso.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(6, 3, 0, 3);
            menuStrip.Size = new Size(800, 30);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            menuStrip.ItemClicked += menuStrip1_ItemClicked;
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gêneroToolStripMenuItem, autorToolStripMenuItem, editoraToolStripMenuItem, idiomaToolStripMenuItem, usuariotoolStripMenuItem, sairToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(88, 24);
            cadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // gêneroToolStripMenuItem
            // 
            gêneroToolStripMenuItem.Name = "gêneroToolStripMenuItem";
            gêneroToolStripMenuItem.Size = new Size(142, 26);
            gêneroToolStripMenuItem.Text = "Gênero";
            gêneroToolStripMenuItem.Click += gêneroToolStripMenuItem_Click;
            // 
            // autorToolStripMenuItem
            // 
            autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            autorToolStripMenuItem.Size = new Size(142, 26);
            autorToolStripMenuItem.Text = "Autor";
            autorToolStripMenuItem.Click += autorToolStripMenuItem_Click;
            // 
            // editoraToolStripMenuItem
            // 
            editoraToolStripMenuItem.Name = "editoraToolStripMenuItem";
            editoraToolStripMenuItem.Size = new Size(142, 26);
            editoraToolStripMenuItem.Text = "Editora";
            editoraToolStripMenuItem.Click += editoraToolStripMenuItem_Click;
            // 
            // idiomaToolStripMenuItem
            // 
            idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            idiomaToolStripMenuItem.Size = new Size(142, 26);
            idiomaToolStripMenuItem.Text = "Idioma";
            idiomaToolStripMenuItem.Click += idiomaToolStripMenuItem_Click;
            // 
            // usuariotoolStripMenuItem
            // 
            usuariotoolStripMenuItem.Name = "usuariotoolStripMenuItem";
            usuariotoolStripMenuItem.Size = new Size(142, 26);
            usuariotoolStripMenuItem.Text = "Usuário";
            usuariotoolStripMenuItem.Click += usuarioToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(142, 26);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // MenuSuspenso
            // 
            MenuSuspenso.ImageScalingSize = new Size(20, 20);
            MenuSuspenso.Items.AddRange(new ToolStripItem[] { sairMenuSuspenso });
            MenuSuspenso.Name = "contextMenuStrip1";
            MenuSuspenso.Size = new Size(104, 28);
            // 
            // sairMenuSuspenso
            // 
            sairMenuSuspenso.Name = "sairMenuSuspenso";
            sairMenuSuspenso.Size = new Size(103, 24);
            sairMenuSuspenso.Text = "Sair";
            sairMenuSuspenso.Click += sairMenuSuspenso_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip.Location = new Point(0, 429);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 22);
            statusStrip.TabIndex = 3;
            statusStrip.ItemClicked += statusStrip_ItemClicked;
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 16);
            lblStatus.Click += toolStripStatusLabel1_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            ContextMenuStrip = MenuSuspenso;
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "FrmMenu";
            Text = "Sistema de Biblioteca";
            WindowState = FormWindowState.Maximized;
            Load += FrmMenu_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            MenuSuspenso.ResumeLayout(false);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem gêneroToolStripMenuItem;
        private ToolStripMenuItem autorToolStripMenuItem;
        public ToolStripMenuItem sairToolStripMenuItem;
        public ToolStripMenuItem sairMenuSuspenso;
        public MenuStrip menuStrip;
        public ContextMenuStrip MenuSuspenso;
        public StatusStrip statusStrip;
        public ToolStripStatusLabel lblStatus;
        private ToolStripMenuItem editoraToolStripMenuItem;
        private ToolStripMenuItem idiomaToolStripMenuItem;
        private ToolStripMenuItem usuariotoolStripMenuItem;
    }
}