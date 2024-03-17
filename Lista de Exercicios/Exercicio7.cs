using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercicios
{
    internal class Exercicio7
    {
        static void main(string[] args)
        {
            //Passo 1: Recebendo Numero do Usuario.
            Console.WriteLine("Digite um número:");
            int numero = Convert.ToInt32(Console.ReadLine());

            //Passo 2: Verificando 1 Numero apos o Outro.
            int resultado = numero + 1; 

            //Passo 3: Definindo se o Resultado è divisivel por 7.
            while (resultado % 7 != 0)
            {
                resultado++;
            }

            //Passo 4: Retornando Qual o Primeiro Numero Divisivel por 7.
            Console.WriteLine($"O primeiro número inteiro positivo divisível por 7 após {numero} é {resultado}");

            Console.ReadKey();
        }
    }
}
