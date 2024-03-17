using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercicios
{
    internal class Exercicio5
    {
        static void main(string[] args)
        {
            //Passo 1: Receber a Distancia e Velocidade do Usuario.
            Console.WriteLine("Digite a distância percorrida em quilômetros:");
            double distanciaKm = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o tempo gasto em horas:");
            double tempoHoras = Convert.ToDouble(Console.ReadLine());

            //Passo 2: Definir a Distância para Metros e o tempo para Segundos.
            double distanciaMetros = distanciaKm * 1000;
            double tempoSegundos = tempoHoras * 3600;

            //Passo 3: Definir a Velocidade Média em Metros por Segundo.
            double velocidadeMedia = distanciaMetros / tempoSegundos;

            //Passo 4: Retornar a Velocidade Média.
            Console.WriteLine($"Velocidade média: {velocidadeMedia:F2} m/s");

            Console.ReadKey();
        }
    }
}
