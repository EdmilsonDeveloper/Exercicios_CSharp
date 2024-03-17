using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Passo 1: Definir a altura da árvore.
            int altura = 10; 

            for (int i = 0; i < altura; i++)
            {
                //Passo 2: Definir os Espaços para alinhar os asteriscos.
                for (int j = 0; j < altura - i - 1; j++)
                {
                    Console.Write(" "); 
                }

                //Passo 3: Imprimir os asteriscos.
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*"); 
                }

                Console.WriteLine();

                //Console.ReadKey();

            }
        }
    }
}
