using System;

class Program
{
    static void Main()
    {
        string frase = "Olá mundo!"; 
        Console.WriteLine("String original: " + frase);

        char[] caracteres = new char[frase.Length];

        for (int i = 0; i < frase.Length; i++)
        {
            caracteres[i] = frase[frase.Length - 1 - i];
        }

        string stringInvertida = new string(caracteres);
        Console.WriteLine("String invertida: " + stringInvertida);
    }
}
