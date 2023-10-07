using ClaretiBank.Menus.MenuInicial;
using ClaretiBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaretiBank.Menus.AreaDoUsuario
{
    internal class MenuSair : Menu
    {
        public override void Executar(Dictionary<string, ContaCorrente> ContaCorrente)
        {
            Console.Clear();
            Console.WriteLine("Bye bye");
            Thread.Sleep(1000);
        }
    }
}
