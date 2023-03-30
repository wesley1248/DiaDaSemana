using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondiçaoSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Apresentaçao
            Console.WriteLine("Ola, este e´um programa de leitura de dia da semana usando o SwithCase!");

            //Declararaçao da variavel
            int numero;

            //Interaçao
            Console.WriteLine("Digite um numero entre 1 e 7");
            numero = int.Parse(Console.ReadLine());

            //Tratamente dos dados
            switch(numero)
            {case  1 :
                Console.WriteLine("Segunda-Feira");
                    Console.ReadKey();
            break;
                case 2:
                    Console.WriteLine("Terça-Feira");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Quarta-Feira");
                        Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Quinta-Feira");
                        Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("Sexta-Feira");
                        Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Numero invalido");
                        Console.ReadKey();
                    break;

            }
        }
    }
}
