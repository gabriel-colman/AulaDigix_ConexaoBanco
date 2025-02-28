using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Exemplo_Dapper_1;
public class Program
{
    public static void Main(string [] args)
    {
        CRUD crud = new CRUD();
        // crud.ListarUsuario();
        // crud.InserirUsuario(4, "Maria", "maria@gmail.com");
        // System.Console.WriteLine("----------------------");
        // crud.ListarUsuario();
        // System.Console.WriteLine("----------------------");
        // crud.AtualizarUsuario(4, "Maria Silva");
        // crud.ListarUsuario();
        // System.Console.WriteLine("----------------------");
        // crud.DeletarUsuario(4);

        Stopwatch stopwatch = new Stopwatch();
        TimeSpan tempoTotal;

        Console.WriteLine("=== Avaliação de Desempenho com Dapper ===");

        // 1. Medindo tempo de inserção
        Console.WriteLine("\nInserindo, listando, atualizando e deletando um usuário...");
        stopwatch.Start();
        crud.InserirUsuario(10, "João", "joao@gmail.com");
        stopwatch.Stop();
        Console.WriteLine($"Tempo para inserir usuário: {stopwatch.ElapsedMilliseconds} ms");
        TimeSpan tempoInsercao = stopwatch.Elapsed;

        // 2. Medindo tempo de listagem
        Console.WriteLine("\nListando usuários...");
        stopwatch.Restart();
        crud.ListarUsuario();
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
        Console.WriteLine($"\nTempo total do CRUD com Dapper: {tempoTotal.TotalMilliseconds} ms");

        Console.WriteLine("=== Avaliação Finalizada ===");

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}