using CarRental.Model;
using MySql.Data.MySqlClient;
using System;

namespace CarRental.DAO
{
    class ClienteDAO
    {
        public bool adicionaCliente(Cliente cliente)
        {
            try
            {
                //instrução de insert no banco:
                string query = "INSERT INTO cliente(nome, cpf, data_nasc) " +
                    "VALUES(@nome, @cpf, @data_nasc)";

                //cria a conexão:
                MySqlConnection conn = Conexao.GetConnection();

                //abre a conexão com o banco:
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }

                //Criar um objeto do tipo "MySQLCommand" com a instrução que definimos:
                MySqlCommand cmd = new MySqlCommand(query, conn);

                //define os parâmetros da query:
                cmd.Parameters.Add(new MySqlParameter("@nome", cliente.Nome));
                cmd.Parameters.Add(new MySqlParameter("@cpf", cliente.Cpf));
                cmd.Parameters.Add(new MySqlParameter("@data_nasc", cliente.Data_Nasc));

                //executa o comando:
                cmd.ExecuteNonQuery();

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
