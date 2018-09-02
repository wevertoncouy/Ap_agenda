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


namespace AppAgenda
{
    public partial class FormCadastroContato : Form
    {
        public string operacao = "";

        public FormCadastroContato()
        {
            InitializeComponent();
        }
        public void AlteraBotoes(int op)
        {
            pDados.Enabled = false;
            btnInserir.Enabled = false;
            btnLocalizar.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnCancelar.Enabled = false;

            if (op == 1)
            {
                btnInserir.Enabled = true;
                btnLocalizar.Enabled = true;

            }
            if (op == 2)
            {
                pDados.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btnExcluir.Enabled = true;
                btnAlterar.Enabled = true;
            }
        }

        public void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtRua.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtCEP.Clear();
        }

        private void pDados_Layout(object sender, LayoutEventArgs e)
        {
            this.AlteraBotoes(1);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlteraBotoes(2);
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
            this.LimparCampos();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato();
            contato.Nome = txtNome.Text;
            contato.Email = txtEmail.Text;
            contato.Telefone = txtTelefone.Text;
            contato.Rua = txtRua.Text;
            contato.Bairro = txtBairro.Text;
            contato.Cidade = txtCidade.Text;     
            contato.Estado = txtEstado.Text;
            contato.Cep = txtCEP.Text;

            // insira registro banco de dados
            String strConexao = @"Data Source=DESKTOP-GM0RQAV\SQLEXPRESS;Initial Catalog=AgendaDB;Integrated Security=True";
            Conexao conexao = new Conexao(strConexao);
            DALContato dal = new DALContato(conexao);

            if (this.operacao == "inserir")
            {

                dal.Incluir(contato);
                MessageBox.Show("O codigo gerado foi:" + contato.ContatoId.ToString());
            }
            else
            {
                contato.ContatoId = Convert.ToInt32(txtCodigoId.Text);
                dal.Alterar(contato);
                
            }



        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            FormConsultaContatos consulta = new FormConsultaContatos();
            consulta.ShowDialog();
        }
    }
}
