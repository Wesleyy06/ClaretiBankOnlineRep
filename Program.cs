
using ClaretiBank.Modelos;
using ClaretiBank.Menus.MenuInicial;
using ClaretiBank.claretibank.Exceptions;
using ClaretiBank.Menus.AreaDoUsuario;

ContaCliente Teste = new("Usuario 1","", "adm", "adm@gmail.com", "1234", "1", "1234", "1234");

Dictionary<string, ContaCliente> ContaCorrente = new();
ContaCorrente.Add("1234", Teste);

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
                if (opcao > 0)
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

