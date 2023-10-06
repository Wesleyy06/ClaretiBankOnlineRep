using ClaretiBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaretiBank.Menus.MenuInicial;

public class Menu
{
    public virtual void Executar(Dictionary<string, ContaCliente> ContaCorrente)
    {
        Console.Clear();
    }
}
