using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercicios
{
    internal class Exercicio6
    {
        static void main(string[] args)
        {
            //Passo 1: Receber o Numero do Usuario.
            Console.WriteLine("Digite um número para calcular o fatorial:");
            int numero = Convert.ToInt32(Console.ReadLine());

            //Passo 2: Definindo Variavies.
            int resultado = 1;
            int contador = 1;

            //Passo 3: Criando um Looping para Encontrar o Valor Fatorial
            do
            {
                resultado *= contador;
                contador++;
            } while (contador <= numero);

            //Passo 5: Retornando o Valor Fatorial.
            Console.WriteLine($"O fatorial de {numero} é {resultado}");

            Console.ReadKey();
        }
    }
}
