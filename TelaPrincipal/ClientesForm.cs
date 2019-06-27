using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaPrincipal
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (lblID.Text == "")
            {
                Inserir();

            }
            else
            {
                Alterar();
            }
            LimparCampos();
            AtualizarTabela();
        }

        private void Inserir()
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Cpf = mtbCpf.Text;
            cliente.DataNascimento = Convert.ToDateTime(mtbDataNascimento.Text);
            cliente.Rg = mtbRG.Text;
            ClienteRepositorio repositorio = new ClienteRepositorio();
            repositorio.Inserir(cliente);
        }

        private void Alterar()
        {
            Cliente cliente = new Cliente();
            cliente.Id = Convert.ToInt32(lblID.Text);
            cliente.Nome = txtNome.Text;
            cliente.Cpf = mtbCpf.Text;
            cliente.DataNascimento = Convert.ToDateTime(mtbDataNascimento.Text);
            cliente.Rg = mtbRG.Text;
            ClienteRepositorio repositorio = new ClienteRepositorio();
            repositorio.Inserir(cliente);

        }

        private void LimparCampos()
        {
            lblID.Text = "";
            txtNome.Clear();
            mtbCpf.Clear();
            mtbDataNascimento.Clear();
            mtbRG.Clear();


        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void AtualizarTabela()
        {
            ClienteRepositorio repositorio = new ClienteRepositorio();
            string busca = txtBusca.Text;
            List<Cliente> clientes = repositorio.ObterTodos(busca); dataGridView1.RowCount = 0;
            for (int i = 0; i < clientes.Count; i++)
            {
                Cliente cliente = clientes[i];
                dataGridView1.Rows.Add(new object[] { cliente.Id, cliente.Nome });
            }
        }

        private void txtBusca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarTabela();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ClienteRepositorio repositorio = new ClienteRepositorio();
            repositorio.Apagar(id);
            AtualizarTabela();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ClienteRepositorio repositorio = new ClienteRepositorio();

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Cliente cliente = repositorio.ObterPeloId(id);
            if (cliente != null)
            {
                txtNome.Text = cliente.Nome;
                mtbCpf.Text = cliente.Cpf.ToString();
                mtbDataNascimento.Text = cliente.DataNascimento.ToString();
                mtbRG.Text = cliente.Rg.ToString();
                lblID.Text = cliente.Id.ToString();
            }
        }
    }
}
