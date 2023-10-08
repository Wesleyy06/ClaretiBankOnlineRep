
using ClaretiBank.Modelos;
using ClaretiBank.Menus.MenuInicial;
using ClaretiBank.claretibank.Exceptions;
using ClaretiBank.Menus.AreaDoUsuario;
using Org.BouncyCastle.Asn1.IsisMtt.X509;

ContaCorrente Administrador = new("1111", "1111-A");
Administrador.Titular.Nome = "Adm"; Administrador.Titular.Sobrenome = "2";
Administrador.NomeUsuario = "Adm";
Administrador.Titular.Cpf = "1111";
Administrador.Saldo = 500000.00;
Administrador.Senha = "1234";

Dictionary<string, ContaCorrente> ContaCorrente = new();
ContaCorrente.Add("1111", Administrador);

Dictionary<int, Menu> _Menu1 = new();
_Menu1.Add(1, new Login());
_Menu1.Add(2, new RegistroDeUsuario());
_Menu1.Add(3, new MenuSair());

void MenuInicial()
{
    try
    {
        int opcao = 0;
        while (opcao != 3)
        {
            Console.Clear();
            Console.WriteLine("===========================");
            Console.WriteLine("Boas vindas ao ClaretiBank!");
            Console.WriteLine("===========================");
            Console.WriteLine();
            Console.WriteLine("Digite 1 para logar ou 2 para registrar uma nova conta e 3 para sair");
            Console.WriteLine("Opção escolhida: ");
            try
            {
            opcao = int.Parse(Console.ReadLine());
            }
            catch(Exception ex)  
            {
                throw new ClaretiBankException(ex.Message);
            }

            if (_Menu1.ContainsKey(opcao))
            {
                Menu Exibirmenu = _Menu1[opcao];
                Exibirmenu.Executar(ContaCorrente);
                if(opcao == 3)
                {
                    break;
                } 
                else if (opcao > 0)
                {
                    MenuInicial();
                }
            }

        } 
    }
    catch (ClaretiBankException erro)
    {
        Console.WriteLine(erro.Message);
    }
}

MenuInicial();

