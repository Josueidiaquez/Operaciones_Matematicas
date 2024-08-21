// See https://aka.ms/new-console-template for more information

using System;

class Calculadora
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al sistema de calculo de los numeros");

        Console.WriteLine("Favor ingresa el primer Numero");
        int Numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Favor Ingrese el Segundo Numero");
        int Numero2 = Convert.ToInt32(Console.ReadLine());

        int Suma = (Numero1 + Numero2);
        int Resta = (Numero1 - Numero2);
        int Multiplicacion = (Numero1 * Numero2);
        int Division = (Numero1 / Numero2);

        Console.WriteLine("El resultado de la suma es: ", Suma);
        Console.WriteLine("El resultado de la resta es:", Resta);
        Console.WriteLine("El resultado de la Multiplicacion es: ", Multiplicacion);
        Console.WriteLine("El resultado de la Division es: ", Division);

    }
}

