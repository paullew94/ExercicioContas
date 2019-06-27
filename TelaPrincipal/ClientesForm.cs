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
            if(lblID.Text == "")
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
                 Cliente cliente= clientes[i];
                dataGridView1.Rows.Add
            }
    }



}
