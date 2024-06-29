using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SISTEMAVENDAS
{
    public partial class frmFuncionarioPainel : Form
    {
        public frmFuncionarioPainel()
        {
            InitializeComponent();
        }
        string stringConexao = "Data Source=DESKTOP-MPBBNFK\\MYSQLSERVER;Initial Catalog=SISTEMADEVENDAS;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        private void CarregarGrid()
        {
            string sql = "select nome_cliente as 'Cliente', cnpj_cliente as 'CNPJ', telefone1_cliente as 'Contato', dtdecadatro_cliente as 'Data de Cadastro' from CLIENTE";
            SqlConnection conn = new SqlConnection(stringConexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            conn.Open();
            try
            {
                adapter.Fill(dt);
                gridPesquisarCliente.DataSource = dt;
                gridPesquisarCliente.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                gridPesquisarCliente.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void frmUsuarioPainel_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void gridPesquisarCliente_DoubleClick(object sender, EventArgs e)
        {
            frmAterarFuncionario frm = new frmAterarFuncionario();
            frm.Show();
            
        }
    }
}
