using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace conexaobd
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Digite o nome do usuario");
            string vNomeUsu = Console.ReadLine();

            Console.WriteLine("Digite o cargo do usuario");
            string vCargo = Console.ReadLine();

            Console.WriteLine("Digite a data de nascimento do usuario");
            string vDataNasc = Console.ReadLine();

            string strinsereUsu = string.Format("INSERT INTO tbUsuario(NomeUsu, Cargo, Datanasc) " +
                "VALUES('{0}', '{1}', '{2}');", vNomeUsu, vCargo, vDataNasc);

        


            //MySqlConnection connection = new MySqlConnection(@"Server= localhost; Database= dbExemplo; User ID= root; Password = 12345678 ");
            //connection.Open();
            //Console.WriteLine("Conectado!");
            //Console.ReadLine();

            //string AtualizaUsu = "Update tbUsuario set NomeUsu = 'MeAchoEsperta' where (IDusu= 2)";
            //MySqlCommand comandoAtualiza = new MySqlCommand(AtualizaUsu, connection);
            //comandoAtualiza.ExecuteNonQuery();

            //MySqlCommand comandoApagar = new MySqlCommand(strinsereUsu, connection);
            //comandoApagar.ExecuteNonQuery();

            //string strinsereUsu = "INSERT INTO tbUsuario(NomeUsu, Cargo, DataNasc) VALUES('Emma', 'cerimonialista', '2020/04/07')";
            //MySqlCommand comandoApagar = new MySqlCommand(strinsereUsu, connection);
            //comandoApagar.ExecuteNonQuery();

            //string selectUsu = "Select * from tbUsuario";
            //MySqlCommand comando = new MySqlCommand(selectUsu, connection);
            //MySqlDataReader leitor = comando.ExecuteReader();
            
            //while (leitor.Read()) 
            //{
                //Console.WriteLine("Id: {0}, Nome: {1}, Cargo: {2}, Data: {3}", leitor["IDusu"], leitor["NomeUsu"], leitor["Cargo"], leitor["DataNasc"]);
            //};
            //Console.ReadLine();

            //SerializableAttribute; 

      
                
 
        }
    }
}
