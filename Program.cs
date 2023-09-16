using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMaiorIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Pessoa p3 = new Pessoa();

            Console.WriteLine("Determina qual é a pessoa mais velha");
            
            Console.Write("Nome da 1º Pessoa: ");
            p1.Nome = Console.ReadLine();

            Console.Write("Idade da 1º pessoa: ");
            p1.Idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nome da 2º pessoa: ");
            p2.Nome = Console.ReadLine();

            Console.Write("Idade da 2º Pessoa: ");
            p2.Idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nome da 3° pessoa: ");
            p3.Nome = Console.ReadLine();

            Console.Write("Idade da 3° pessoa: ");
            p3.Idade = Convert.ToInt32(Console.ReadLine());

            if ((p1.Idade > p2.Idade) && (p1.Idade > p3.Idade))
            {
                Console.WriteLine("A pessoa mais velha é: ");

                p1.ExibirDados();
            }
            else 
            {
                if ((p2.Idade > p1.Idade) && (p2.Idade > p3.Idade))
                {

                    Console.WriteLine("A pessoa mais velha é: ");

                    p2.ExibirDados();


                }
                else 
                {
                    if ((p3.Idade > p1.Idade) && (p3.Idade > p2.Idade))
                    {

                        Console.WriteLine("A pessoa mais velha é: ");

                        p3.ExibirDados();
                    }

                    else 
                    {
                        Console.WriteLine("Todas as pessoas possuem a mesma idade");
                    
                    }
                
                }
            
            
            }
            Console.ReadKey();
        }
    }
}
