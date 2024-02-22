using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            // Verificar si el número es par o impar
            if (EsPar(numero))
            {
                Console.WriteLine($"{numero} es un número par.");
            }
            else
            {
                Console.WriteLine($"{numero} es un número impar.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese un valor numérico válido.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inesperado: {ex.Message}");
        }
    }

    static bool EsPar(int numero)
    {
        // Determinar si el número es par
        return numero % 2 == 0;
    }
}

