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
            menuStrip.Size = new Size(800, 28);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            menuStrip.ItemClicked += menuStrip1_ItemClicked;
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gêneroToolStripMenuItem, autorToolStripMenuItem, sairToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(88, 24);
            cadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // gêneroToolStripMenuItem
            // 
            gêneroToolStripMenuItem.Name = "gêneroToolStripMenuItem";
            gêneroToolStripMenuItem.Size = new Size(224, 26);
            gêneroToolStripMenuItem.Text = "Gênero";
            gêneroToolStripMenuItem.Click += gêneroToolStripMenuItem_Click;
            // 
            // autorToolStripMenuItem
            // 
            autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            autorToolStripMenuItem.Size = new Size(224, 26);
            autorToolStripMenuItem.Text = "Autor";
            autorToolStripMenuItem.Click += autorToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(224, 26);
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
            statusStrip.Location = new Point(0, 424);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 26);
            statusStrip.TabIndex = 3;
            statusStrip.ItemClicked += statusStrip_ItemClicked;
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(151, 20);
            lblStatus.Text = "toolStripStatusLabel1";
            lblStatus.Click += toolStripStatusLabel1_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}