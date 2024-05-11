using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace ProjetoLojaABC
{
    public partial class frmCadFunc : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmCadFunc()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        public frmCadFunc(string nome)
        {
            InitializeComponent();
            desabilitarCampos();
            txtNome.Text = nome;
            carregaUsuario(txtNome.Text);
        }

        private void frmCadFunc_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtSenha.Enabled = false;
            txtRepetirSenha.Enabled = false;
            txtNome.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnCadastrar.Enabled = false;
        }
        public void habilitarCampos()
        {
            txtCodigo.Enabled = true;
            txtRepetirSenha.Enabled = true;
            txtSenha.Enabled = true;
            txtNome.Enabled = true;


            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnCadastrar.Enabled = true;
            btnNovo.Enabled = false;
            txtNome.Focus();
        }
        public void limparCampos()
        {
            txtCodigo.Clear();
            txtSenha.Clear();
            txtRepetirSenha.Clear();
            txtNome.Clear();

        }

        //método cadastrar funcionarios
        public void cadastrarUsuarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbUsuarios (nome,senha)values(@nome, @senha);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 30).Value = txtNome.Text;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 10).Value = txtSenha.Text;

            comm.Connection = Conexao.obterConexao();
            int res = comm.ExecuteNonQuery();

            MessageBox.Show("Cadastrado com sucesso");
            limparCampos();
            Conexao.fecharConexao();
        }

        public void buscarCodigoUsu()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codUsu+1 from tbUsuarios order by codUsu desc;";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = DR.GetInt32(0).ToString();

            Conexao.fecharConexao();

        }

        public void carregaUsuario(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbUsuarios where nome = @nome";
            comm.CommandType = CommandType.Text;


            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();

            txtCodigo.Text = DR.GetInt32(0).ToString();
            txtNome.Text = DR.GetString(1);
            

            Conexao.fecharConexao();
            funcaoCarregaUsuario();

        }

        public void alterarUsuario(int codUsu)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbUsuarios set nome=@nome,senha=@senha where codUsu=@codUsu";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 30).Value = txtNome.Text;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 10).Value = txtSenha.Text;

            comm.Parameters.Add("@codUsu", MySqlDbType.Int32, 11).Value = codUsu;

            comm.Connection = Conexao.obterConexao();
            int res = comm.ExecuteNonQuery();

            MessageBox.Show("Alterado com sucesso");
            limparCampos();
            Conexao.fecharConexao();
        }

        public void excluirUsuario(int codUsu)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbusuarios where codUsu=@codUsu";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codUsu", MySqlDbType.Int32, 11).Value = codUsu;

            comm.Connection = Conexao.obterConexao();
            int res = comm.ExecuteNonQuery();

            MessageBox.Show("Excluído com sucesso");
            limparCampos();
            Conexao.fecharConexao();
        }

        public void funcaoCarregaUsuario()
        {
            habilitarCampos();
            txtCodigo.Enabled = false;
            btnCadastrar.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarUsuarios();
            desabilitarCampos();
            btnNovo.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            txtCodigo.Enabled = false;
            buscarCodigoUsu();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarUsuario(Convert.ToInt32(txtCodigo.Text));
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluirUsuario(Convert.ToInt32(txtCodigo.Text));
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarUsuarios abrir = new frmPesquisarUsuarios();
            abrir.Show();
            this.Hide();

        }
    }
}
