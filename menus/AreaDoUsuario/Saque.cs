using ClaretiBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaretiBank.Menus.AreaDoUsuario;

internal class Saque
{
    private string Cpf { get; set; }
    public Saque(string cpf)
    {
        Cpf = cpf;
    }
    public void MenuSaque(Dictionary<string, ContaCorrente> ContaCorrente)
    {
        var Consulta = ContaCorrente[Cpf];

        Console.Clear();
        Console.Write("Digite o valor de saque\nR$ ");
        double ValorDeSaque = double.Parse(Console.ReadLine()!);
        if (ValorDeSaque <= Consulta.Saldo) 
        {
            Consulta.Sacar(ValorDeSaque);
            Console.Clear();
            Console.WriteLine("Saque realizado com sucesso!");
            Thread.Sleep(1500);
            Console.Clear();
        } 
        else
        {
            Console.Clear() ;
            Console.WriteLine("Saldo insuficiente!");
            Thread.Sleep(1500);
            Console.Clear();
        }
        
    }
}
