using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ContaReceberRepositorio
    {
        public string CadeiaConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Usuario\Documents\teste.mdf;Integrated Security=True;Connect Timeout=30";

        public void Inserir(ContaReceber contaReceber)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO contas_receber(nome,valor,valor_recebido,data_recebimento,recebido) VALUES (@NOME,@VALOR,@VALOR_RECEBIDO,@DATA_RECEBIMENTO,@RECEBIDO)";
            comando.Parameters.AddWithValue("@NOME", contaReceber.Nome);
            comando.Parameters.AddWithValue("@VALOR", contaReceber.Valor);
            comando.Parameters.AddWithValue("@VALOR_RECEBIDO", contaReceber.ValorRecebido);
            comando.Parameters.AddWithValue("@DATA_RECEBIMENTO", contaReceber.DataRecebimento);
            comando.Parameters.AddWithValue("@RECEBIDO", contaReceber.Recebido);
            comando.ExecuteNonQuery();
            conexao.Close();


        }

        public List<ContaReceber> ObterTodos(string busca)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM contas_receber WHERE nome LIKE @NOME";
            busca = "%" + busca + "%";
            comando.Parameters.AddWithValue("@NOME", busca);

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            conexao.Close();
            List<ContaReceber> contaReceber = new List<ContaReceber>();
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                ContaReceber conta = new ContaReceber();
                conta.Id = Convert.ToInt32(linha["id"]);
                conta.Nome = linha["nome"].ToString();
                conta.Valor = Convert.ToDecimal(linha["valor"]);
                conta.ValorRecebido = Convert.ToDecimal(linha["valor_recebido"]);
                conta.DataRecebimento = Convert.ToDateTime(linha["data_recebimento"]);
                conta.Recebido = Convert.ToBoolean(linha["recebido"]);
                contaReceber.Add(conta);

            }
                return contaReceber;

        }

        public void Apagar(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "DELETE FROM contas_receber WHERE ID =@ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public ContaReceber ObterPeloId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText= "SELECT* FROM contas_receber WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            if (tabela.Rows.Count == 0)
            {
                return null;
            }
            DataRow linha = tabela.Rows[0];
            ContaReceber contaReceber = new ContaReceber();
            contaReceber.Id = id;
            contaReceber.Nome = linha["nome"].ToString();
            contaReceber.Valor = Convert.ToDecimal(linha["valor"]);
            contaReceber.ValorRecebido =Convert.ToDecimal (linha["valor_recebido"]);
            contaReceber.DataRecebimento = Convert.ToDateTime(linha["data_recebimento"]);
            return contaReceber;
        }
        public void Alterar(ContaReceber contaReceber)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();


            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "UPDATE contas_receber SET nome= @NOME,valor=@VALOR,valor_recebido=@VALOR_RECEBIDO,data_recebimento=@DATA_RECEBIMENTO,recebido=@RECEBIDO";
            comando.Parameters.AddWithValue("@NOME", contaReceber.Nome);
            comando.Parameters.AddWithValue("@VALOR", contaReceber.Valor);
            comando.Parameters.AddWithValue("@VALOR_RECEBIDO", contaReceber.ValorRecebido);
            comando.Parameters.AddWithValue("@DATA_RECIBIMENTO", contaReceber.DataRecebimento);
            comando.Parameters.AddWithValue("@RECEBIDO", contaReceber.Recebido);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}
