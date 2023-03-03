using System;
using System.Collections.Generic;

namespace ExercicioEntrevista2
{
    internal class Program
    {
        //fibonaci é: o próximo termo é a soma dos anteriores
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de termos na sequência");
            int tam = Convert.ToInt32(Console.ReadLine());
            Fibonacci(tam,num);

        }

        public static bool Fibonacci(int tam,int num)
        {
            List<int> fibonacci = new List<int>();
            int a = 0; int b = 1;

            for (int i = 0; i < tam; i++)
            {
                fibonacci.Add(a);
                int c = a + b;
                a = b;
                b = c;
                Console.WriteLine(" i: {0}", fibonacci[i]);
                if (num == fibonacci[i])
                {
                    Console.WriteLine("O número {0} pertence à sequência de Fibonacci!", num);
                    return true;
                }
            }
            Console.WriteLine("O número {0} não pertence à sequência de Fibonacci!",num);
            return false;
        }
    }
}
