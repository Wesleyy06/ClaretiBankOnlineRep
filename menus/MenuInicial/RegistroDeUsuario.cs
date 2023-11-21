using ClaretiBank.claretibank.Exceptions;
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
        new FormataTitulo().TituloDaOpcao("=== Registro de conta ===");
        Console.Write("Numero CPF: ");
        string cpf = Console.ReadLine();
        ContaCorrente usuario = new(cpf);
       
        try
        {
            Console.Write($"Digito: ");
            usuario.Digito = int.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
            throw new ClaretiBankException(ex.Message);
        }

        usuario.Titular.Cpf = cpf;

        Console.Clear();
        Console.WriteLine($"Conta digito [{usuario.Digito}], numero da conta [{usuario.NumeroConta}]\n");

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

        try
        {
            Console.Write("Saldo inicial: R$");
            usuario.Saldo = double.Parse(Console.ReadLine());
        } 
        catch (Exception ex) 
        { 
            throw new ClaretiBankException(ex.Message); 
        }
        
        Console.Write("Digite uma senha: ");
        usuario.Senha = Console.ReadLine();

        ContaCorrente.Add(cpf, usuario);
        Console.Clear();
        new FormataTitulo().TituloDaOpcao(" === Usuario registrado com sucesso! ===");
        Thread.Sleep(1000);
    }
}
