using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 20; // Define el número de términos a sumar
        int resultado = SumaNaturalesRecursiva(n); // Calcula la suma de los primeros n números naturales
        Console.WriteLine("La suma de los primeros " + n + " números naturales es: " + resultado); // Imprime el resultado
    }

    // Función recursiva para calcular la suma de los primeros N números naturales
    static int SumaNaturalesRecursiva(int n)
    {
        // Caso base: cuando n es 0, la suma es 0
        if (n == 0)
        {
            return 0;
        }
        else
        {
            // Caso recursivo: suma de n con la suma de los primeros n-1 números naturales
            return n + SumaNaturalesRecursiva(n - 1);
        }
    }
}
