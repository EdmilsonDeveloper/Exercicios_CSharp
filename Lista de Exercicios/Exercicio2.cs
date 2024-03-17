using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercicios
{
    internal class Exercicio2
    {
        static void main(string[] args)
        {
            //Passo 1: Receber Valores do Usuario.
            Console.WriteLine("Digite o primeiro valor:");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            //Passo 2: Definir se o Valor 1 é Maior que o Valor 2.
            if (valor1 > valor2)
            {
                Console.WriteLine($"{valor1} é maior que {valor2}.");
            }

            //Passo 3: Definir se o Valor 2 é Maior que o Valor 1.
            else if (valor2 > valor1)
            {
                Console.WriteLine($"{valor2} é maior que {valor1}.");
            }

            //Passo 4: Definir se os Valores são Iguais.
            else
            {
                Console.WriteLine("Os valores são iguais.");

            }

            Console.ReadKey();
        }
    }
}
