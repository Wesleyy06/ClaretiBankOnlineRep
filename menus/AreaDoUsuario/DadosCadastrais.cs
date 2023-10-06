using ClaretiBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClaretiBank.Menus.AreaDoUsuario;

internal class DadosCadastrais
{
    private string Cpf { get; set; }

    public DadosCadastrais(string cpf)
    {
        Cpf = cpf;
    }

    public void ExibirFicha(Dictionary<string, ContaCliente> ContaCorrente)
    {
        string Consulta = Cpf;
        var Resposta = ContaCorrente[Consulta];

        Console.Clear();
        Console.WriteLine($"Nome: {Resposta.Nome} {Resposta.Sobrenome}");
        Console.WriteLine($"Nome de usuario: {Resposta.NomeUsuario}");
        Console.WriteLine($"Email: {Resposta.Email}");
        Console.WriteLine($"CPF: {Resposta.Cpf}");
        Console.WriteLine($"Digito: {Resposta.Agencia}");
        Console.WriteLine($"Numero da conta: {Resposta.NumeroConta}");
        Console.WriteLine();
        Console.WriteLine("Aperte qualquer tecla para voltar");
        Console.ReadKey();
        Console.Clear();
    }
}
