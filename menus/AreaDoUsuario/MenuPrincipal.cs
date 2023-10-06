using ClaretiBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaretiBank.Menus.AreaDoUsuario;

internal class MenuPrincipal
{
    public string Cpf { get; set; }

    string Legendas = "Digite 1 para saque, 2 para deposito, 3 para visualizar suas informações de cadastro e -1 deslogar.";

    public MenuPrincipal(string cpf)
    {
        Cpf = cpf;
    }

    public void ExibirMenu(Dictionary<string, ContaCliente> ContaCorrente)
    {
        string localizarUsuario = Cpf;
        var usuarioLocalizado = ContaCorrente[Cpf];

        Console.WriteLine($"Usuario: {usuarioLocalizado.NomeUsuario}\nAgencia: {usuarioLocalizado.Agencia} Conta: {usuarioLocalizado.NumeroConta}\nSaldo: R$ {usuarioLocalizado.ExibirSaldo}");
        Console.WriteLine();
        Console.WriteLine(Legendas);
        int OpcaoDesejada = int.Parse(Console.ReadLine()!);

        switch (OpcaoDesejada)
        {
            case 1: Saque sacar = new(localizarUsuario); sacar.MenuSaque(ContaCorrente); ExibirMenu(ContaCorrente); break;
            case 2: Deposito depositar = new(localizarUsuario); depositar._Deposito(ContaCorrente); ExibirMenu(ContaCorrente); break;
            case 3: DadosCadastrais exibirDados = new(localizarUsuario); exibirDados.ExibirFicha(ContaCorrente); ExibirMenu(ContaCorrente); break;
            case -1: Console.WriteLine("Bye"); break;
        }
    }

}
