using ClaretiBank.Menus.MenuInicial;
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
        Console.Clear();
        new FormataTitulo().TituloDaOpcao("=== Ficha do usuario ===");
        Console.WriteLine(Resposta.ToString());
        Console.WriteLine("\nPressione qualquer tecla para voltar...");
        Console.ReadKey();
        Console.Clear();
    }
}
