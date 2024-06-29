namespace SISTEMAVENDAS
{
    partial class frmFuncionarioPainel
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
            gridPesquisarCliente = new DataGridView();
            panelAlterar = new Panel();
            btnGrid = new Button();
            ((System.ComponentModel.ISupportInitialize)gridPesquisarCliente).BeginInit();
            panelAlterar.SuspendLayout();
            SuspendLayout();
            // 
            // gridPesquisarCliente
            // 
            gridPesquisarCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPesquisarCliente.Location = new Point(-3, -3);
            gridPesquisarCliente.Name = "gridPesquisarCliente";
            gridPesquisarCliente.Size = new Size(760, 353);
            gridPesquisarCliente.TabIndex = 11;
            gridPesquisarCliente.DoubleClick += gridPesquisarCliente_DoubleClick;
            // 
            // panelAlterar
            // 
            panelAlterar.Controls.Add(gridPesquisarCliente);
            panelAlterar.Location = new Point(12, 12);
            panelAlterar.Name = "panelAlterar";
            panelAlterar.Size = new Size(760, 353);
            panelAlterar.TabIndex = 13;
            // 
            // btnGrid
            // 
            btnGrid.Location = new Point(811, 302);
            btnGrid.Name = "btnGrid";
            btnGrid.Size = new Size(125, 50);
            btnGrid.TabIndex = 14;
            btnGrid.Text = "Abrir GRiD";
            btnGrid.UseVisualStyleBackColor = true;
            // 
            // frmFuncionarioPainel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 377);
            Controls.Add(btnGrid);
            Controls.Add(panelAlterar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFuncionarioPainel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Painel do Usuario";
            Load += frmUsuarioPainel_Load;
            ((System.ComponentModel.ISupportInitialize)gridPesquisarCliente).EndInit();
            panelAlterar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView gridPesquisarCliente;
        private Panel panelAlterar;
        private Button btnGrid;
    }
}