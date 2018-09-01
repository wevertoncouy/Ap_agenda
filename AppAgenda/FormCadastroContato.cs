using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.operacao = "Inserir";
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
            contato.Cidade = txtCidade.Text;
            contato.Estado = txtEstado.Text;
            contato.Cep = txtCEP.Text;

            if (this.operacao == "inserir")
            {
                // insira registro banco de dados
            }
            else
            {
                contato.ContatoId = int.Parse(txtCodigo.Text);
                //Altera contato que esta na tela
            }



        }
    }
}
