using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercicios
{
    internal class Exercicio8
    {
          static void main(string[] args)
          {
            //Passo 1: Recebendo Numero do Usuario.
            Console.WriteLine("Digite um número:");
            int numero = Convert.ToInt32(Console.ReadLine());

            //Passo 2: Retornando Mensagem deque vão ser Imprimidos Numeros Pares de 0 até o Numero Definido pelo Usuario.
            Console.WriteLine("Números pares de 0 até " + numero + ":");

            //Passo 3: Criando um Loop até o Numero Definido Pelo Usuario.
            for (int i = 0; i <= numero; i++)
            {
                //Passo 4: Defininfo quais Numeros são Pares.
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
          }

    }

}
