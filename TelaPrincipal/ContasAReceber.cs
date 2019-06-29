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
    public partial class ContasAReceber : Form
    {
        public ContasAReceber()
        {
            InitializeComponent();
        }

        private void ContasAReceber_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
        private void Inserir()
        {
            ContaReceber contaReceber = new ContaReceber();
            contaReceber.Nome = txtNome.Text;
            contaReceber.Valor = Convert.ToDecimal(mtbValor.Text);
            contaReceber.ValorRecebido = Convert.ToDecimal(mtbValorRecibido.Text);
            contaReceber.DataRecebimento = Convert.ToDateTime(mtbDataRecebimento.Text);
            contaReceber.Recebido = Convert.ToBoolean(ckbRecibido.Checked);
            ContaReceberRepositorio repositorio = new ContaReceberRepositorio();
            repositorio.Inserir(contaReceber);
        }
        private void Alterar()
        {
            ContaReceber contaReceber = new ContaReceber();
            contaReceber.Id = Convert.ToInt32(lblId.Text);
            contaReceber.Nome = txtNome.Text;
            contaReceber.Valor = Convert.ToDecimal(mtbValor.Text);
            contaReceber.ValorRecebido = Convert.ToDecimal(mtbValorRecibido.Text);
            contaReceber.DataRecebimento = Convert.ToDateTime(mtbDataRecebimento.Text);
            contaReceber.Recebido = Convert.ToBoolean(ckbRecibido.Checked);
            ContaReceberRepositorio repositorio = new ContaReceberRepositorio();
            repositorio.Inserir(contaReceber);
        }
        private void LimparCampos ()
        {
            lblId.Text = "";
            txtNome.Clear();
            mtbValor.Clear();
            mtbValorRecibido.Clear();
            mtbDataRecebimento.Clear();
            ckbRecibido.Checked = false;
        }
        private void AtualizarTabela()
        {
            ContaReceberRepositorio repositorio = new ContaReceberRepositorio();
            string busca = txtBusca.Text;
            List<ContaReceber> contasReceber = repositorio.ObterTodos(busca); dataGridView1.RowCount = 0;
            for (int i = 0; i < contasReceber.Count; i++)
            {
                ContaReceber contaReceber = contasReceber[i];
                dataGridView1.Rows.Add(new object[] { contaReceber.Id, contaReceber.Nome });
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
           ContaReceberRepositorio repositorio = new ContaReceberRepositorio();
            repositorio.Apagar(id);
            AtualizarTabela();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ContaReceberRepositorio repositorio = new ContaReceberRepositorio();
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ContaReceber contaReceber= repositorio.ObterPeloId(id);
            if (contaReceber != null)
            {
                txtNome.Text = contaReceber.Nome;
                mtbValor.Text = contaReceber.Valor.ToString();
                mtbValorRecibido.Text = contaReceber.ValorRecebido.ToString();
                mtbDataRecebimento.Text = contaReceber.DataRecebimento.ToString();
                ckbRecibido.Text=contaReceber.Recebido.ToString();
                lblId.Text = contaReceber.Id.ToString();


            }
        }
    }
}
