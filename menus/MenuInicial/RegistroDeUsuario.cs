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
        Console.Write("Informe seu Nome: ");
        string Nome = Console.ReadLine()!;
        Console.Write("Sobrenome: ");
        string SobreNome = Console.ReadLine()!;
        Console.Clear();
        Console.WriteLine($"Boas Vindas {Nome} ao ClaretiBank");
        Console.WriteLine("Nos infome seu Email para começarmos a registrar sua conta");
        Console.Write("Email: ");
        string Email = Console.ReadLine()!;
        Console.Clear();
        Console.Write("Como Voce deseja ser chamado?\nEu desejo ser chamado de: ");
        string NomeUsuario = Console.ReadLine()!;
        Console.Clear();
        Console.Write("CPF: ");
        string CPF = Console.ReadLine()!;
        Console.Clear();
        Console.Write("Agencia: ");
        string Agencia = Console.ReadLine()!;
        Console.Clear();
        Console.Write("Numero da conta: ");
        string NumeroConta = Console.ReadLine()!;
        Console.Clear();
        Console.Write("Defina uma senha: ");
        string Senha = Console.ReadLine()!;
        Console.Clear();
        Console.WriteLine("Meus parabéns usuario registrado com sucesso!");
        ContaCorrente Usuario = new(Nome,SobreNome, NomeUsuario, Email, CPF, Agencia, NumeroConta, Senha);
        ContaCorrente.Add(CPF, Usuario);
        Thread.Sleep(1500);
        Console.Clear();
    }
}
