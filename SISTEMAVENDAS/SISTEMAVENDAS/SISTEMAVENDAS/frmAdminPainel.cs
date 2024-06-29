

using Microsoft.Data.SqlClient;

namespace SISTEMAVENDAS
{

    public partial class frmAdminPainel : Form
    {
        public frmAdminPainel()
        {
            InitializeComponent();
        }

        //string stringConexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SISTEMAVENDAS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        string stringConexao = "Data Source=DESKTOP-MPBBNFK\\MYSQLSERVER;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        private void abriConexao()
        {
            SqlConnection conn = new SqlConnection(stringConexao);

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }



        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirFormUsuario()
        {
            if (this.panelCentral.Controls.Count > 0)
                this.panelCentral.Controls.RemoveAt(0);
            frmFuncionarioPainel frm = new frmFuncionarioPainel();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.panelCentral.Controls.Add(frm);
            this.panelCentral.Tag = frm;
            frm.Show();



        }

        private void solicitacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormUsuario();
        }

        private void frmAdminPainel_Load(object sender, EventArgs e)
        {
            abriConexao();
        }

        private void panelCentral_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
