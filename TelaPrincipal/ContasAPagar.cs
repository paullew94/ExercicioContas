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
    public partial class ContasAPagar : Form
    {
        public ContasAPagar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (lblId.Text == "")
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
            ContaPagar contaPagar = new ContaPagar();
            contaPagar.Nome = txtNome.Text;
            contaPagar.Valor = Convert.ToDecimal(mtbValor.Text);
            contaPagar.Tipo = txtTipo.Text;
            contaPagar.DataVencimento = Convert.ToDateTime(mtbDataVencimento.Text);
            ContaPagarRepositorio repositorio = new ContaPagarRepositorio();
            repositorio.Inserir(contaPagar);

        }

        private void Alterar()
        {
            ContaPagar contaPagar = new ContaPagar();
            contaPagar.Id = Convert.ToInt32(lblId.Text);
            contaPagar.Nome = txtNome.Text;
            contaPagar.Valor = Convert.ToDecimal(mtbValor.Text);
            contaPagar.Tipo = txtTipo.Text;
            contaPagar.DataVencimento = Convert.ToDateTime(mtbDataVencimento.Text);
            ContaPagarRepositorio repositorio = new ContaPagarRepositorio();
            repositorio.Inserir(contaPagar);


        }

        private void LimparCampos()
        {
            lblId.Text = "";
            txtNome.Clear();
            mtbValor.Clear();
            txtTipo.Clear();
            mtbDataVencimento.Clear();

        }

        private void ContasAPagar_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void AtualizarTabela()
        {
            ContaPagarRepositorio repositorio = new ContaPagarRepositorio();
            string busca = txtBusca.Text;
            List<ContaPagar> contasPagar = repositorio.ObterTodos(busca); dataGridView1.RowCount = 0;
            for (int i = 0; i < contasPagar.Count; i++)
            {
                ContaPagar contaPagar = contasPagar[i];
                dataGridView1.Rows.Add(new object[] { contaPagar.Id, contaPagar.Nome });

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
            ContaPagarRepositorio repositorio = new ContaPagarRepositorio();
            repositorio.Apagar(id);
            AtualizarTabela();


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ContaPagarRepositorio repositorio = new ContaPagarRepositorio();
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ContaPagar contaPagar = repositorio.ObterPeloId(id);
            if (contaPagar != null)
            {
                txtNome.Text = contaPagar.Nome;
                mtbValor.Text = contaPagar.Valor.ToString();
                txtTipo.Text = contaPagar.Tipo;
                mtbDataVencimento.Text = contaPagar.DataVencimento.ToString();
                lblId.Text = contaPagar.Id.ToString();

            }
        }
    }

}
