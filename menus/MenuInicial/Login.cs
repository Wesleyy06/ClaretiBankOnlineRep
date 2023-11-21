using ClaretiBank.Menus.AreaDoUsuario;
using ClaretiBank.Modelos;
using ZstdSharp.Unsafe;

namespace ClaretiBank.Menus.MenuInicial;


internal class Login : Menu
{
    public override void Executar(Dictionary<string, ContaCorrente> ContaCorrente)
    {
        base.Executar(ContaCorrente);

        int limitador = 4;
        int contador = 1;

        while (contador < limitador)
        {
            new FormataTitulo().TituloDaOpcao("=== Login usuario ===");
            Console.Write("Numero CPF: ");

            string _Consulta = Console.ReadLine()!;

            if (ContaCorrente.ContainsKey(_Consulta))
            {
                var Resposta = ContaCorrente[_Consulta];
                Console.Clear();
                Console.WriteLine($"Bem Vindo {Resposta.NomeUsuario}, me informe sua senha");
                Console.Write("Senha: ");
                string Senha = Console.ReadLine()!;
                if (Senha == Resposta.Senha)
                {
                    contador = 4;
                    Console.Clear();
                    Console.WriteLine("Usuario logado com sucesso!");
                    MenuPrincipal menu2 = new MenuPrincipal(_Consulta);
                    menu2.ExibirMenu(ContaCorrente);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Senha incorreta!");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Usuario não encontrado em nossa base de dados, tente novamente!");
                Console.WriteLine($"Chances {contador} de {3}");
                Thread.Sleep(1000);

                if (contador == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Tente novamente mais tarde");
                    Thread.Sleep(1500);
                }
            }
            contador++;
        }
    }
}

