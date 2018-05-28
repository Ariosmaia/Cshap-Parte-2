using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();
            //gabriela.nome = "Gabriela";
            //gabriela.profissao = "Desenvolvedora C#";
            //gabriela.cpf = "356.567.234-23";

            ContaCorrente conta = new ContaCorrente();
            //conta.titular = gabriela;

            //conta.titular = new Cliente();
            //conta.titular.nome = "Gabriela Costa";
            //conta.titular.cpf = "356.567.234-23";
            //conta.titular.profissao = "Desenvolvedora C#";


            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 3456789;

            if (conta.titular == null)
            {
                Console.WriteLine("ops, a referência em conta.titular é nula");
            }


            Console.WriteLine(conta.titular);
            //Console.WriteLine(gabriela.nome);
            ///Console.WriteLine(conta.titular.nome);
            //Console.WriteLine(conta.titular.cpf);
            //Console.WriteLine(conta.titular.profissao);

            Console.ReadLine();
        }
    }
}
