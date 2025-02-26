using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Diagnostics;

using Npgsql;

namespace Exemplo1
{
    public class Crud
    {
        // Aqui esta as configurações de conexão com o banco de dados
        string conexao = "Host=localhost;Database=Aula1;Username=postgres;Password=1234";

        void InserirUsuario(int id, string nome, string email)
        {
            string query = $"Insert into public.usuario (id, nome, email) values ({id}, '{nome}', '{email}')";

            using (NpgsqlConnection con = new NpgsqlConnection(conexao))
            {
                con.Open(); // abre a conexão com o banco de dados
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("id", id); // Parametros para a query, que são os valores que serão inseridos
                    cmd.Parameters.AddWithValue("nome", nome);
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.ExecuteNonQuery(); // ExecuteNonQuery ele executa um comando que não retorna dados, como um insert, update, delete
                }
            }
        }

        void LerUsuario()
        {

            string query = "Select * from public.usuario";

            using (NpgsqlConnection con = new NpgsqlConnection(conexao))
            // Mysql (MySqlConnection)
            {
                con.Open(); // abre a conexão com o banco de dados
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                {
                    using (NpgsqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            System.Console.WriteLine($"Id: {dr["id"]}, Nome: {dr["nome"]}, Email: {dr["email"]}");
                        }
                    }
                }
            }
        }

        void AtualizarUsuario(int id, string nome)
        {
            string query = $"Update public.usuario set nome = '{nome}' where id = {id}";

            using (NpgsqlConnection con = new NpgsqlConnection(conexao))
            {
                con.Open(); // abre a conexão com o banco de dados
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("id", id); // Parametros para a query, que são os valores que serão inseridos
                    cmd.Parameters.AddWithValue("nome", nome);
                    cmd.ExecuteNonQuery(); // ExecuteNonQuery ele executa um comando que não retorna dados, como um insert, update, delete
                }
            }
        }

        void DeletarUsuario(int id)
        {
            string query = $"Delete from public.usuario where id = {id}";

            using (NpgsqlConnection con = new NpgsqlConnection(conexao))
            {
                con.Open(); // abre a conexão com o banco de dados
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("id", id); // Parametros para a query, que são os valores que serão inseridos
                    cmd.ExecuteNonQuery(); // ExecuteNonQuery ele executa um comando que não retorna dados, como um insert, update, delete
                }
            }
        }

        static void Main(string[] args)
        {
            Crud crud = new Crud();
            // crud.InserirUsuario(7, "Fulano", "fulano@gmail.com");
            // crud.LerUsuario();
            // crud.AtualizarUsuario(7, "Ciclano");
            // crud.DeletarUsuario(7);

            Stopwatch sw = new Stopwatch(); // Classe que representa o cronometro para medir o tempo de execução durante a execução do código
            TimeSpan tempoTotal; // Variavel que vai armazenar o tempo total de execução

            // 1. Medindo o tempo de inserção de um registro
            sw.Start(); // Inicia o cronometro
            crud.InserirUsuario(7, "Fulano", "fulano@gmail.com");
            sw.Stop(); // Para o cronometro
            Console.WriteLine($"Tempo de inserção: {sw.ElapsedMilliseconds}ms"); // ElapsedMilliseconds é o tempo total em milisegundos que foi decorrido durante a execução do código
            TimeSpan tempoInsercao = sw.Elapsed; // Armazena o tempo de inserção

            // 2. Medindo o tempo de leitura de um registro
            sw.Restart(); // Reinicia o cronometro
            Console.WriteLine("Leitura de registros:");
            crud.LerUsuario();
            sw.Stop(); // Para o cronometro
            Console.WriteLine($"Tempo de leitura: {sw.ElapsedMilliseconds}ms");
            TimeSpan tempoLeitura = sw.Elapsed; // Armazena o tempo de leitura
            
            // 3. Medindo o tempo de atualização de um registro
            sw.Restart(); // Reinicia o cronometro
            Console.WriteLine("Atualização de registros:");
            crud.AtualizarUsuario(7, "Ciclano");
            sw.Stop(); // Para o cronometro
            Console.WriteLine($"Tempo de atualização: {sw.ElapsedMilliseconds}ms");
            TimeSpan tempoAtualizacao = sw.Elapsed; // Armazena o tempo de atualização

            // 4. Medindo o tempo de deleção de um registro
            sw.Restart(); // Reinicia o cronometro
            Console.WriteLine("Deleção de registros:");
            crud.DeletarUsuario(7);
            sw.Stop(); // Para o cronometro
            Console.WriteLine($"Tempo de deleção: {sw.ElapsedMilliseconds}ms");
            TimeSpan tempoDelecao = sw.Elapsed; // Armazena o tempo de deleção

            // Calculando o tempo total de execução
            tempoTotal = tempoInsercao + tempoLeitura + tempoAtualizacao + tempoDelecao;
            Console.WriteLine($"Tempo total de execução: {tempoTotal}");
            
        }

    }
}