using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente c1 = new Cliente();
            c1.Nome = txtNome.Text;
            c1.Status = true;
            c1.Cpf = Convert.ToInt16(txtCpf.Text);
            c1.Fixo = Convert.ToInt16(txtFixo.Text);
            c1.Cel = Convert.ToInt16(txtCel.Text);
            c1.End = txtEnd.Text;
            c1.Cidade = txtCidade.Text;
            c1.Estado = txtEstado.Text;

         //   Cliente c1bd = new Cliente();
           // if (c1bd.InsertCliente(c1) == 1)
            //{

                MessageBox.Show("Cliente  Cadastro com SUcesso");
               // LimparCampos();
                //ClienteDao clicao = new ClienteDao();
                //txtcodigo.Text = clicao.RetriveClienteNextCodigo().ToString();
            //}


        }
    }
}
