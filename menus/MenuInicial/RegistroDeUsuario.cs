using ClaretiBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaretiBank.Menus.MenuInicial;

internal class RegistroDeUsuario : Menu
{
    public override void Executar(Dictionary<string, ContaCorrente> ContaCorrente)
    {
        base.Executar(ContaCorrente);
        Console.WriteLine("================================");
        Console.WriteLine("=== Registro de novo usuario ===");
        Console.WriteLine("================================");
        Console.WriteLine();
        Console.Write("Numero CPF: ");
        string cpf = Console.ReadLine();
        Console.Write("Numero da conta: ");
        string numeroConta = Console.ReadLine();
        ContaCorrente usuario = new(cpf, numeroConta);
        usuario.Titular.Cpf = cpf;
        usuario.NumeroConta = numeroConta;
        Console.Write("Me informe seu nome: ");
        usuario.Titular.Nome = Console.ReadLine();
        Console.Write("Sobrenome: ");
        usuario.Titular.Sobrenome = Console.ReadLine();
        Console.Write("Nome de usuario: ");
        usuario.NomeUsuario = Console.ReadLine();
        Console.Write("Email: ");
        usuario.Titular.Email = Console.ReadLine();
        Console.Write("Profissão: ");
        usuario.Titular.Profissão = Console.ReadLine();
        Console.Write("Saldo inicial: R$");
        usuario.Saldo = double.Parse(Console.ReadLine());
        Console.Write("Digite uma senha: ");
        usuario.Senha = Console.ReadLine();
        ContaCorrente.Add(cpf, usuario);
        Console.Clear();
        Console.WriteLine("=========================================");
        Console.WriteLine("===  usuario registrado com sucesso!  ===");
        Console.WriteLine("=========================================");
        Thread.Sleep(1000);
    }
}
