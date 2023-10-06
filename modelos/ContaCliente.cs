using Org.BouncyCastle.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaretiBank.Modelos;

public class ContaCliente
{
    private string _nome { get; set; }
    public string Sobrenome { get; set; }
    private string _nomeUsuario { get; set; }
    public string Email { get; set; }
    private string _cpf { get; set; }
    private string _agencia { get; set; }
    private string _numeroConta { get; set; }
    private string _senha { get; set; }
    public double Saldo { get; set; } 

    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public string NomeUsuario
    {
        get { return _nomeUsuario; }
        set { _nomeUsuario = value; }
    }

    public string Cpf
    {
        get { return _cpf; }
        set { _cpf = value; }
    }

    public string Agencia
    {
        get { return _agencia; }
        set { _agencia = value; }
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

    public ContaCliente(string nome,string sobrenome, string nomeUsuario, string email, string cpf, string agencia, string numeroConta, string senha)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        NomeUsuario = nomeUsuario;
        Email = email;
        Cpf = cpf;
        Agencia = agencia;
        NumeroConta = numeroConta;
        NumeroConta = numeroConta;
        Senha = senha;
    }

    public double ExibirSaldo()
    {
        return Saldo;
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
