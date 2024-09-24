using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        int a = 0;
        int b = 1;

        Console.Write("A sequência de Fibonacci do número fornecido é: ");
        Console.Write("{0}, {1}", a, b);

        bool pertence = (numero == a || numero == b);

        while (true)
        {
            int proximo = a + b;
            if (proximo > numero) break;

            Console.Write(", {0}", proximo);
            a = b;
            b = proximo;

            if (proximo == numero) pertence = true;
        }

        Console.WriteLine();

        if (pertence)
        {
            Console.WriteLine("{0} pertence à sequência de Fibonacci.", numero);
        }
        else
        {
            Console.WriteLine("{0} não pertence à sequência de Fibonacci.", numero);
        }
    }
}
