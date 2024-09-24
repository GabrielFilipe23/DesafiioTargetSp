using System;

class Program
{
    static void Main()
    {
        
        int soma = 0;
        int[] numeros = new int[13];

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = i + 1;
        }

        for (int K = 0; K < numeros.Length; K++)
        {
            soma += numeros[K];
        }

        Console.WriteLine(soma);
    }
}
