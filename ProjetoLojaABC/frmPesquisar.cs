using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoLojaABC
{
    public partial class frmPesquisar : Form
    {
        public frmPesquisar()
        {
            InitializeComponent();
            desabilitaCampos();
        }
        public void desabilitaCampos()
        {
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            txtDescricao.Enabled = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked)
            {
                lstPesquisar.Items.Clear();
                buscaPorCodigo(Convert.ToInt32(txtDescricao.Text));
                txtDescricao.Focus();
                txtDescricao.Clear();

            }
            if (rdbNome.Checked)
            {
                lstPesquisar.Items.Clear();
                buscaPorNome(txtDescricao.Text);
                txtDescricao.Focus();
                txtDescricao.Clear();

            }
        }

        public void buscaPorCodigo(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbFuncionarios where codFunc = @codFunc";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            comm.Parameters.Clear();
            comm.Parameters.Add("@codFunc", MySqlDbType.Int32, 11).Value = codigo;

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            lstPesquisar.Items.Add(DR.GetString(1));

            Conexao.fecharConexao();
        }
        public void buscaPorNome(string nomeFunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbFuncionarios where nome like '%"+nomeFunc+"%'";
            comm.CommandType = CommandType.Text;
           
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            while (DR.Read())
            {
               lstPesquisar.Items.Add(DR.GetString(0));
                
            }

            Conexao.fecharConexao();
        }


        private void btnTeste_Click(object sender, EventArgs e)
        {
            //lstPesquisar.Items.Clear();
            lstPesquisar.Items.Add(txtDescricao.Text);


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstPesquisar.Items.Clear();
        }

        private void lstPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int i = lstPesquisar.SelectedIndex;
            string nome = lstPesquisar.SelectedItem.ToString();
            //MessageBox.Show("o número da linha "+ i + "- "+ nome);
            frmFuncionarios abrir = new frmFuncionarios(nome);
            abrir.Show();
            this.Hide();
        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                //lstPesquisar.Items.Add(txtDescricao.Text);
                //txtDescricao.Clear();
                //txtDescricao.Focus();
            }

        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtDescricao.Enabled = true;
            txtDescricao.Focus();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtDescricao.Enabled = true;
            txtDescricao.Focus();
        }
    }
}
