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
        crud.ListarUsuario();
        crud.InserirUsuario(4, "Maria", "maria@gmail.com");
        System.Console.WriteLine("----------------------");
        crud.ListarUsuario();
        System.Console.WriteLine("----------------------");
        crud.AtualizarUsuario(4, "Maria Silva");
        crud.ListarUsuario();
        System.Console.WriteLine("----------------------");
        crud.DeletarUsuario(4);
    }
}