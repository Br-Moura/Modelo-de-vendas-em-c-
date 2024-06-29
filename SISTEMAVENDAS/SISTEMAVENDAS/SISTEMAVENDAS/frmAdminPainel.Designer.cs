namespace SISTEMAVENDAS
{
    partial class frmAdminPainel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlFoolter = new Panel();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            menuStripTopo = new MenuStrip();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            funcionariosToolStripMenuItem = new ToolStripMenuItem();
            solicitacaoToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            visualizarToolStripMenuItem = new ToolStripMenuItem();
            panelCentral = new Panel();
            pnlFoolter.SuspendLayout();
            menuStripTopo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFoolter
            // 
            pnlFoolter.BackColor = SystemColors.ActiveCaption;
            pnlFoolter.Controls.Add(label2);
            pnlFoolter.Controls.Add(label3);
            pnlFoolter.Controls.Add(label1);
            pnlFoolter.Dock = DockStyle.Bottom;
            pnlFoolter.Location = new Point(0, 410);
            pnlFoolter.Name = "pnlFoolter";
            pnlFoolter.Size = new Size(995, 56);
            pnlFoolter.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 128);
            label2.Location = new Point(71, 18);
            label2.Name = "label2";
            label2.Size = new Size(154, 19);
            label2.TabIndex = 3;
            label2.Text = "Ja Lin Cain Chotha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(755, 20);
            label3.Name = "label3";
            label3.Size = new Size(231, 27);
            label3.TabIndex = 4;
            label3.Text = "Sistemas de Vendas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(66, 18);
            label1.TabIndex = 2;
            label1.Text = "Usuario:";
            // 
            // menuStripTopo
            // 
            menuStripTopo.BackColor = SystemColors.ScrollBar;
            menuStripTopo.Items.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, solicitacaoToolStripMenuItem, produtosToolStripMenuItem });
            menuStripTopo.Location = new Point(0, 0);
            menuStripTopo.Name = "menuStripTopo";
            menuStripTopo.Size = new Size(995, 24);
            menuStripTopo.TabIndex = 1;
            menuStripTopo.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, funcionariosToolStripMenuItem });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(64, 20);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(142, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // funcionariosToolStripMenuItem
            // 
            funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            funcionariosToolStripMenuItem.Size = new Size(142, 22);
            funcionariosToolStripMenuItem.Text = "Funcionarios";
            // 
            // solicitacaoToolStripMenuItem
            // 
            solicitacaoToolStripMenuItem.Name = "solicitacaoToolStripMenuItem";
            solicitacaoToolStripMenuItem.Size = new Size(81, 20);
            solicitacaoToolStripMenuItem.Text = "Solicitações";
            solicitacaoToolStripMenuItem.Click += solicitacaoToolStripMenuItem_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem, visualizarToolStripMenuItem });
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(67, 20);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.Size = new Size(125, 22);
            adicionarToolStripMenuItem.Text = "Adicionar";
            // 
            // visualizarToolStripMenuItem
            // 
            visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            visualizarToolStripMenuItem.Size = new Size(125, 22);
            visualizarToolStripMenuItem.Text = "Visualizar";
            // 
            // panelCentral
            // 
            panelCentral.Location = new Point(12, 27);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(974, 377);
            panelCentral.TabIndex = 2;
            panelCentral.Paint += panelCentral_Paint;
            // 
            // frmAdminPainel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 466);
            Controls.Add(panelCentral);
            Controls.Add(pnlFoolter);
            Controls.Add(menuStripTopo);
            MainMenuStrip = menuStripTopo;
            Name = "frmAdminPainel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Painel Administrativo";
            Load += frmAdminPainel_Load;
            pnlFoolter.ResumeLayout(false);
            pnlFoolter.PerformLayout();
            menuStripTopo.ResumeLayout(false);
            menuStripTopo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlFoolter;
        private MenuStrip menuStripTopo;
        private Label label1;
        private Label label2;
        private Label label3;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem funcionariosToolStripMenuItem;
        private ToolStripMenuItem solicitacaoToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem visualizarToolStripMenuItem;
        private Panel panelCentral;
    }
}
