using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int positivos = 0;
            int negativo = 0;
            int conta = 0; 
            int numero;
            Console.WriteLine("Introduce número ");
            numero = Int32.Parse(Console.ReadLine());
            //El Bucle while o bucle mientras o Instrucción
            while (numero !=5)
            {
                conta = conta + 1;
                if (numero > 0) 
                {
                    positivos = positivos + 1;
                    Console.WriteLine("Introduce número ");
                    numero = Int32.Parse(Console.ReadLine());
                }
                else
                {
                    negativo = negativo - 1;
                     Console.WriteLine("Introduce número ");
                     numero = Int32.Parse(Console.ReadLine());
                }
                
            }
           

            
               Console.WriteLine("Has introducido un total de {0}", conta);
               Console.WriteLine("y son positivos {0}", positivos);
               Console.WriteLine("y son negativo {0}", negativo);
               Console.Read();
           } //fin Main
        }
    }

