using ClaretiBank.Modelos;
using System;
using System.Collections.Generic;
using System.Configuration;
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

    public void ExibirFicha(Dictionary<string, ContaCorrente> ContaCorrente)
    {
        string Consulta = Cpf;
        var Resposta = ContaCorrente[Consulta];
        Console.WriteLine($"Nome completo: {Resposta.Titular.Nome} {Resposta.Titular.Sobrenome}");
        Console.WriteLine($"Email: {Resposta.Titular.Email}");
        Console.WriteLine($"CPF: {Resposta.Titular.Cpf}");
        Console.WriteLine($"Profissão: {Resposta.Titular.Profissão}");
        Console.WriteLine("Aperte qualquer tecla para voltar");
        Console.ReadKey();
        Console.Clear();
    }
}
