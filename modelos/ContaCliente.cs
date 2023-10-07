using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaretiBank.Modelos;

public class ContaCliente
{
    private string _nome { get; set; }
    public string _sobrenome { get; set; }
    public string _email { get; set; }
    private string _cpf { get; set; }
    private string _profissao { get; set; }

    public string Nome
    {
        get
        {
            return _nome;
        }
        set
        {
            _nome = value;
        }
    }

    public string Sobrenome
    {
        get
        {
            return _sobrenome;
        }
        set{ _sobrenome = value; }
    }

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    public string Cpf
    {
        get { return _cpf; }
        set { _cpf = value; }
    }

    public string Profissão
    {
        get { return _profissao; }
        set { _profissao = value; }
    }
}
