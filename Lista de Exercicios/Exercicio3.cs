using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercicios
{
    internal class Exercicio3
    {
        static void main(string[] args)
        {
            //Passo 1: Receber Numero do Usuario.
            Console.WriteLine("Digite um número inteiro:");
            int numero = Convert.ToInt32(Console.ReadLine());

            //Passo 2: Definir se O Numero é Par.
            if (numero % 2 == 0)
            {
                Console.WriteLine($"{numero} é um número par.");
            }

            //Passo 3: Caso não seja Par é Impar.
            else
            {
                Console.WriteLine($"{numero} é um número ímpar.");
            }

            Console.ReadKey();
        }

    }
}
