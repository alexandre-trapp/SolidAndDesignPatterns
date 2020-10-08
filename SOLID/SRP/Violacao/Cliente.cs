using System;
using System.Data;
using System.Net.Mail;
using System.Data.SqlClient;

namespace SOLID.SRP.Violacao
{
    /// <summary>
    /// Violação do SRP (Single responsability principle - Princípio da responsabilidade única)
    /// </summary>
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome{ get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        public string AdicionarCliente()
        {
            if (!Email.Contains("@"))
                return "email inválido!";

            if (CPF.Length != 11)
                return "CPF deve conter 11 caracteres!";

            using var conn = new SqlConnection();

            var cmd = new SqlCommand();

            conn.ConnectionString = "ConnectionStringTeste";
            cmd.Connection = conn;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL, CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @datacadastro)";

            cmd.Parameters.AddWithValue("nome", Nome);
            cmd.Parameters.AddWithValue("email", Email);
            cmd.Parameters.AddWithValue("cpf", CPF);
            cmd.Parameters.AddWithValue("datacadastro", DataCadastro);

            conn.Open();
            cmd.ExecuteNonQuery();

            var mail = new MailMessage("trapp@trapp.com", Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Bem vindo";
            mail.Body = "Você está no treinamento de Solid do trapp!";
            client.Send(mail);

            return "Cliente cadastrado com sucesso";
        }
    }
}
