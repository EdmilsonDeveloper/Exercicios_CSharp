using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercicios
{
    internal class Exercicio1
    {
        static void Main(string[] args)
        {
            //Passo 1: Receber a Idade do Usuario.
            Console.WriteLine("Digite sua Idade:");
            int idade = Convert.ToInt32(Console.ReadLine());

            //Passo 2: Definir a Maioridade em 18 Anos.
            if (idade >= 18)
            {
                Console.WriteLine("Você é Maior de Idade");

            }
            //Passo 3: Definir que Abaixo de 18 é Menor de Idade.
            else
            {
                Console.WriteLine("Você é Menor de Idade");
            }

            Console.ReadKey();
        }
    }
}
