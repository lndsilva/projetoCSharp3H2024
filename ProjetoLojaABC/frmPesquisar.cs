using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            txtDescricao.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked == false || rdbNome.Checked == false)
            {
                MessageBox.Show("selecionar pesquisa");
            }
            else
            {


                if (rdbCodigo.Checked)
                {
                    if (txtDescricao.Text.Equals(""))
                    {
                        MessageBox.Show("Não posso pesquisar");
                    }
                    else
                    {
                        //busca por codigo

                    }
                }
                else
                {
                    MessageBox.Show("selecionar pesquisa");
                }

                if (rdbNome.Checked)
                {
                    if (txtDescricao.Text.Equals(""))
                    {
                        MessageBox.Show("Não posso pesquisar");
                    }
                    else
                    {
                        //busca por codigo

                    }
                }
                else
                {

                }
            }
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            lstPesquisar.Items.Clear();
            lstPesquisar.Items.Add("1 - Maria Antonieta - 25 anos");

            
        }
    }
}
