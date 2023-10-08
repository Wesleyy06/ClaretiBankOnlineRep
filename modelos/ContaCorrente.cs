using Org.BouncyCastle.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaretiBank.Modelos;

public class ContaCorrente
{
    private string _nomeUsuario { get ; set; }
    public ContaCliente Titular { get; set; }
    private string _numeroConta { get; set; }
    private string _senha { get; set; }
    public double Saldo { get; set; } 

    public string NomeUsuario
    {
        get { return _nomeUsuario; }
        set { _nomeUsuario = value; }
    }

    public string NumeroConta
    {
        get { return _numeroConta; }
        set { _numeroConta = value; }
    }

    public string Senha
    {
        get { return _senha; }
        set { _senha = value; }
    }

    public ContaCorrente(string cpf, string numeroConta)
    {
        NumeroConta = numeroConta;
        Titular = new ContaCliente();
    }

    public double ExibirSaldo
    {
        get { return Saldo; }
        set { Saldo = value; }
    }

    public void Depositar(double montante)
    {
        if(montante > 0)
        {
              Saldo += montante;
        }
    }

    public void Sacar(double montante)
    {
        if(montante <= Saldo)
        {
            Saldo -= montante;
        }
    }

}
