using System;
using System.Globalization;
using System.Collections.Generic;

namespace Financias.Entidades

{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contrato> list = new List<Contrato>();

            Console.WriteLine("Todo contrato tem prazo de 2 meses");
            Console.Write("Quantos contratos deseja fazer? ");
            int n = int.Parse(Console.ReadLine());
                     
            for (int i = n; i <= n; i++)
            {
                Console.WriteLine("Contrato #" + i + " Dados: ");
                Console.WriteLine("Você é uma pessoa fisica (f), ou uma pessoa juridica(j)?");
                
                char c = char.Parse(Console.ReadLine());

                if (c == 'f' || c == 'F')
                {
                    Console.WriteLine("ID ");
                    int ID = int.Parse(Console.ReadLine());
                    
                    Console.Write("CPF: ");
                    string CPF = Console.ReadLine();

                    Console.Write("Idade: ");
                    int Idade = int.Parse(Console.ReadLine());                    

                    Console.WriteLine("Numero: ");
                    int Numero = int.Parse(Console.ReadLine());

                    Console.Write("Nome do contratante: ");
                    string Contratante = Console.ReadLine();

                    Console.WriteLine("Valor: ");
                    double Valor = double.Parse(Console.ReadLine());

                    Console.Write("Prazo: ");
                    int Prazo = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    list.Add(new PessoaFisica(ID, CPF, Idade, Numero, Contratante, Valor, Prazo));

                }

                else
                {
                    Console.Write("CNPJ do contratante: ");
                    double CNPJ = double.Parse(Console.ReadLine());

                    Console.Write("Inscrição estadual: ");
                    string Inscricao = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Numero: ");
                    int Numero = int.Parse(Console.ReadLine());

                    Console.Write("Nome do contratante: ");
                    string Contratante = Console.ReadLine();

                    Console.WriteLine("Valor: ");
                    double Valor = double.Parse(Console.ReadLine());

                    Console.Write("Prazo: ");
                    int Prazo = int.Parse(Console.ReadLine());

                    list.Add(new PessoaJuridica(CNPJ, Inscricao, Numero, Contratante, Valor, Prazo));
                }               
            }

            Console.WriteLine();
            Console.WriteLine();

            foreach (Contrato cont in list)
            {
                Console.WriteLine();
                Console.WriteLine(cont.ExibirInfo());
            }
        }
    }
}
