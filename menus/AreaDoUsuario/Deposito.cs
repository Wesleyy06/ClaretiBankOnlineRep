using ClaretiBank.claretibank.Exceptions;
using ClaretiBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaretiBank.Menus.AreaDoUsuario
{
    internal class Deposito
    {
        string Cpf { get; set; }

        public Deposito(string cpf)
        {
            Cpf = cpf;
        }
        public void _Deposito(Dictionary<string, ContaCorrente> ContaCorrente)
        {
            string consulta = Cpf;
            var Resposta = ContaCorrente[consulta];

            Console.Clear();
            try
            {
                new FormataTitulo().TituloDaOpcao("=== Deposito ===");
                Console.Write("Digite o valor de deposito\nR$ ");
                double ValorDeDeposito = double.Parse(Console.ReadLine()!);
                Resposta.Depositar(ValorDeDeposito);
                Console.Clear();
                Console.WriteLine($"Deposito no valor de R$ {ValorDeDeposito}, realizado com sucesso!");
                Thread.Sleep(1500);
                Console.Clear();
            }
            catch (Exception ex)
            {
                throw new ClaretiBankException(ex.Message);
            }
           
        }
    }
}
