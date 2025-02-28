using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Diagnostics;
// Para usar o entity Framework, a gente vai executar esses comandos no terminal
// dotnet add package Microsoft.EntityFrameworkCore 
// dotnet add package Microsoft.EntityFrameworkCore.Design
// dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL


// dotnet add package Npgsql.EntityFrameworkCore.MySql  

namespace Exemplo1_Entity
{
    public class Executar
    {
        static void Main(string[] args)
        {

            Crud crud = new Crud();
            // crud.ListarUsuarios();
            // System.Console.WriteLine("-------------------");

            // System.Console.WriteLine("Inserindo um novo usuário");
            // crud.InserirUsuario(7, "Fulnao", "fulano@gmail.com");
            // crud.ListarUsuarios();
            // System.Console.WriteLine("-------------------");

            // System.Console.WriteLine("Atualizando um usuário");
            // crud.AtualizarUsuario(7, "Fulano da Silva");
            // crud.ListarUsuarios();
            // System.Console.WriteLine("-------------------");

            // System.Console.WriteLine("Deletando um usuário");
            // crud.DeletarUsuario(7);
            // crud.ListarUsuarios();
            // System.Console.WriteLine("-------------------");

            Stopwatch stopwatch = new Stopwatch(); // Cronômetro
            TimeSpan tempoTotal; // Tempo total do CRUD

            Console.WriteLine("=== Avaliação de Desempenho com Entity Framework Core ===");

            // 1. Medindo tempo de inserção
            stopwatch.Start();
            crud.InserirUsuario(10, "João", "joao@gmail.com");
            stopwatch.Stop();
            Console.WriteLine($"Tempo para inserir usuário: {stopwatch.ElapsedMilliseconds} ms");
            TimeSpan tempoInsercao = stopwatch.Elapsed;

            // 2. Medindo tempo de listagem
            Console.WriteLine("\nListando usuários...");
            stopwatch.Restart();
            crud.ListarUsuarios();
            stopwatch.Stop();
            Console.WriteLine($"Tempo para listar usuários: {stopwatch.ElapsedMilliseconds} ms");
            TimeSpan tempoListagem = stopwatch.Elapsed;

            // 3. Medindo tempo de atualização
            Console.WriteLine("\nAtualizando usuário...");
            stopwatch.Restart();
            crud.AtualizarUsuario(10, "José Atualizado");
            stopwatch.Stop();
            Console.WriteLine($"Tempo para atualizar usuário: {stopwatch.ElapsedMilliseconds} ms");
            TimeSpan tempoAtualizacao = stopwatch.Elapsed;

            // 4. Medindo tempo de deleção
            Console.WriteLine("\nDeletando usuário...");
            stopwatch.Restart();
            crud.DeletarUsuario(10);
            stopwatch.Stop();
            Console.WriteLine($"Tempo para deletar usuário: {stopwatch.ElapsedMilliseconds} ms");
            TimeSpan tempoExclusao = stopwatch.Elapsed;

            // Calculando o tempo total
            tempoTotal = tempoInsercao + tempoListagem + tempoAtualizacao + tempoExclusao;
            Console.WriteLine($"\nTempo total do CRUD com Entity Framework: {tempoTotal.TotalMilliseconds} ms");

            Console.WriteLine("=== Avaliação Finalizada ===");

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();

        }
    }
}