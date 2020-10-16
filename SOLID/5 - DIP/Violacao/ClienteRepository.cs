using System.Data;
using System.Data.SqlClient;

namespace SOLID.DIP.Violacao
{
    public class ClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
            using var conn = new SqlConnection();

            var cmd = new SqlCommand();

            conn.ConnectionString = "ConnectionStringTeste";
            cmd.Connection = conn;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL, CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @datacadastro)";

            cmd.Parameters.AddWithValue("nome", cliente.Nome);
            cmd.Parameters.AddWithValue("email", cliente.Email.Endereco);
            cmd.Parameters.AddWithValue("cpf", cliente.Cpf.Numero);
            cmd.Parameters.AddWithValue("datacadastro", cliente.DataCadastro);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
