using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace conexaobd
{
    class Banco : IDisposable
    {
        private readonly MySqlConnection conexao;


        public Banco ()

        {
            conexao = new MySqlConnection (ConfigurationManager);
            conexao.Open();

        }

        public void ExecutaComando(string StrQuery)
        {
            var vComando = new MySqlCommand
            {
                CommandText = StrQuery,
                CommandType = System.Data.CommandType.Text,
                Connection = conexao

            } 
                
        }

        public MySqlDataReader RetornaCommando (string StrQuery)
        {

            var comando = new MySqlCommand(StrQuery, conexao);
            return comando.ExecuteReader(); 

        }

        public void Dispose()
        {
            //throw new NotImplementedException(); 
            if (conexao.State == System.Data.ConnectionState.Open)
                conexao.Close();

        }
    }
}
