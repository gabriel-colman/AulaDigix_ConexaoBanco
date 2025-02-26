// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// // Para a gente utilizar a conexão com banco Postgres, precisamos instalar o pacote Npgsql
// // dotnet add package Npgsql
// Mysql (MySqlConnection): dotnet add package MySql.Data
// using Npgsql;

// namespace Exemplo1
// {
//     public class Executar
//     {
//         static void Main(string[] args)
//         {
//             // Aqui esta as configurações de conexão com o banco de dados
//             string conexao = "Host=localhost;Database=Aula1;Username=postgres;Password=1234";

//             using (NpgsqlConnection con = new NpgsqlConnection(conexao))
//             {
//                 try
//                 {
//                     con.Open(); // abre a conexão com o banco de dados
//                     System.Console.WriteLine("Conexão aberta  com Postgres!");

//                     // Aqui estamos criando um comando SQL para ser executado no banco de dados, quero imprimir o que esta la dentro do banco
//                     // string query = "Select table_name from information_schema.tables where table_schema = 'public'";
//                     string query = "Select * from public.usuario";

//                     // Vamos criar o comando que vai inserir um novo registro na tabela usuario
//                     string insertQuery = "Insert into public.usuario (id, nome, email) values (8, 'João', 'joao@gmail.com')";
//                     using (NpgsqlCommand cmd = new NpgsqlCommand(insertQuery, con))
//                     {
//                         // int row = cmd.ExecuteNonQuery(); // ExecuteNonQuery ele executa um comando que não retorna dados, como um insert, update, delete
//                         // System.Console.WriteLine("Linhas afetadas: " + row); // imprime a quantidade de linhas afetadas
//                         cmd.ExecuteNonQuery();
//                         System.Console.WriteLine("Registro inserido com sucesso!");
//                     }

//                     // Vamos criar o comando que vai atualizar um registro na tabela usuario
//                     string updateQuery = "Update public.usuario set nome = 'Maria' where id = 8"; // atualiza o nome do usuario com id 8
//                     using (NpgsqlCommand cmd = new NpgsqlCommand(updateQuery, con))
//                     {
//                         cmd.ExecuteNonQuery();
//                         System.Console.WriteLine("Registro atualizado com sucesso!");
//                     }

//                     // Vamos criar o comando que vai deletar um registro na tabela usuario
//                     string deleteQuery = "Delete from public.usuario where id = 8"; // deleta o usuario com id 8
//                     using (NpgsqlCommand cmd = new NpgsqlCommand(deleteQuery, con))
//                     {
//                         cmd.ExecuteNonQuery();
//                         System.Console.WriteLine("Registro deletado com sucesso!");
//                     }


//                     // Aqui estamos criando um comando SQL para ser executado no banco de dados, quero imprimir o que esta la dentro do banco
//                     using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
//                     { // NpgsqlCommand ele representa um comando SQL que será executado no banco de dados
//                         using (NpgsqlDataReader dr = cmd.ExecuteReader())
//                         { // NpgsqlDataReader ele representa um leitor de dados que irá ler os dados do banco de dados
//                             System.Console.WriteLine("Tabelas do banco de dados:");
//                             while (dr.Read()) // enquanto tiver dados para serem lidos
//                             {
//                                 //    System.Console.WriteLine(dr.GetString(0)); // imprime o nome da tabela, ou valor da coluna 0
//                                 Console.WriteLine($"Id: {dr.GetInt32(0)} Nome: {dr.GetString(1)} Email: {dr.GetString(2)}");
//                             }

//                         }
//                     }
//                 }
//                 catch (NpgsqlException ex)
//                 {
//                     Console.WriteLine("Erro: " + ex.Message);
//                 }
//             }

//         }
//     }
// }