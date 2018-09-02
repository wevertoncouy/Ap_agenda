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
    public partial class FormConsultaContatos : Form
    {
        public FormConsultaContatos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcutar_Click(object sender, EventArgs e)
        {
            Conexao cx = new Conexao(@"Data Source=DESKTOP-GM0RQAV\SQLEXPRESS;Initial Catalog=AgendaDB;Integrated Security=True");
            DALContato dal = new DALContato(cx);
            dgDados.DataSource = dal.Localizar(txtValor.Text);
        }
    }
}
