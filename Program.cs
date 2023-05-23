﻿namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que deseja fazer?");

        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("5 - Sair");

        Console.WriteLine("-----------------");
        Console.WriteLine("Selecione uma opção: ");

        short res = 0;   

        if(Console.ReadLine() == null)
        {
            Menu();
        }
        switch (res)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: System.Environment.Exit(0); break;
            default: Menu(); break;
        }
    }

    static void Soma()
    {
        Console.Clear();
        Console.WriteLine("Operação: Soma");
        Console.WriteLine("Primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        float result = v1 + v2;

        Console.WriteLine("");
        Console.WriteLine($"O Resultado da soma é {result}");
        Console.ReadKey();
        Menu();
    }

    static void Subtracao()
    {
        Console.Clear();
        Console.WriteLine("Operação: Subtração");
        Console.WriteLine("Primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        float result = v1 - v2;

        Console.WriteLine("");
        Console.WriteLine($"O Resultado da subtração é {result}");

        Console.ReadKey();
        Menu();
    }

    static void Divisao()
    {
        Console.Clear();
        Console.WriteLine("Operação: Divisão");
        Console.WriteLine("Primeiro Valor:");

        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float result = v1 / v2;

        Console.WriteLine($"O Resultado da divisão é {result}");

        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao()
    {
        Console.Clear();
        Console.WriteLine("Operação: Multiplicação");
        Console.WriteLine("Primeiro valor:");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");
        float result = v1 * v2;

        Console.WriteLine($"O Resultado da multiplicação é: {result}");
        Console.ReadKey();
        Menu();
    }
}
