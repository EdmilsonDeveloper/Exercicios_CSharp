using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercicios
{
    internal class Exercicio4
    {
       static void main(string[] args)
        {
            //Passo 1: Receber as Notas do Usuario.
            Console.WriteLine("Digite a primeira nota:");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            //Passo 2: Definir Qual a Media.
            double media = (nota1 + nota2) / 2;

            //Passo 3: Definir se é Igual ou Maior que 7.
            if (media >= 7)
            {
                Console.WriteLine($"Média: {media:F1}. Aluno aprovado.");
            }

            //Passo 4: Definir se é Igual ou Maior que 3.
            else if (media >= 3)
            {
                Console.WriteLine($"Média: {media:F1}. Aluno em recuperação.");
            }

            //Passo 5: Caso Seja Menor que 3 = Foi Reprovado.
            else
            {
                Console.WriteLine($"Média: {media:F1}. Aluno reprovado.");
            }

            Console.ReadKey();
        }
    }
}
