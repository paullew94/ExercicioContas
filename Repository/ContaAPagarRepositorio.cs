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
    public class ContaAPagarRepositorio
    {
        public string CadeiaConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Usuario\Documents\teste.mdf;Integrated Security=True;Connect Timeout=30";

        public void Inserir(ContaAPagar contaAPagar)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO contas_pagar(nome,valor,tipo,data_vencimento) VALUES (@NOME,@VALOR,@TIPO,@DATA_VENCIMENTO)";
            comando.Parameters.AddWithValue("@NOME", contaAPagar.Nome);
            comando.Parameters.AddWithValue("@VALOR", contaAPagar.Valor);
            comando.Parameters.AddWithValue("@TIPO", contaAPagar.Tipo);
            comando.Parameters.AddWithValue("@DATA_VENCIMENTO", contaAPagar.DataVencimento);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public List<ContaAPagar> ObterTodos(string busca)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM contas_pagar WHERE nome LIKE @NOME";
            busca = "%" + busca + "%";
            comando.Parameters.AddWithValue("@NOME", busca);

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            conexao.Close();

            List<ContaAPagar> contasAPagar = new List<ContaAPagar>();
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                DataRow linha = tabela.Rows[i];
                ContaAPagar contaAPagar = new ContaAPagar();
                contaAPagar.Id = Convert.ToInt32(linha["id"]);
                contaAPagar.Nome = linha["nome"].ToString();
                contaAPagar.Valor = Convert.ToDecimal(linha["valor"]);
                contaAPagar.Tipo = linha["tipo"].ToString();
                contaAPagar.DataVencimento = Convert.ToDateTime(linha["data_vencimento"]);
                contasAPagar.Add(contaAPagar);
            }
            return contasAPagar;
        }

        public void Apagar(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "DELETE FROM cliente WHERE ID =@ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public ContaAPagar ObterPeloId(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT *FROM contas_pagar WHERE id=@ID";
            comando.Parameters.AddWithValue("@ID", id);
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            if (tabela.Rows.Count == 0)
            {
                return null;
            }

            DataRow linha = tabela.Rows[0];
             ContaAPagar contaAPagar= new ContaAPagar();
            contaAPagar.Id = id;
            contaAPagar.Nome = linha["nome"].ToString();
            contaAPagar.Valor = Convert.ToDecimal(linha["valor"]);
            contaAPagar.Tipo = linha["tipo"].ToString();
            contaAPagar.DataVencimento = Convert.ToDateTime(linha["data_vencimento"]);
            return contaAPagar;
        }
        public void Alterar(ContaAPagar contaAPagar)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaConexao;
            conexao.Open();

        
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "UPDATE clientes SET nome=@NOME,valor=@VALOR,tipo=@TIPO,data_vencimento@DATA_VENCIMENTO";
            comando.Parameters.AddWithValue("@NOME", contaAPagar.Nome);
            comando.Parameters.AddWithValue("@VALOR", contaAPagar.Valor);
            comando.Parameters.AddWithValue("@TIPO", contaAPagar.Tipo);
            comando.Parameters.AddWithValue("@DATA_VENCIMENTO", contaAPagar.DataVencimento);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}
