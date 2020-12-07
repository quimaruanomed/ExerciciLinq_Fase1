using System;
using System.Collections.Generic;
using System.Linq;


namespace ExerciciLinq_Fase1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numFaseI = { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4};
            
            IEnumerable<int> numP= from num in numFaseI where num % 2 == 0 select num; // Consulta para seleccionar los numeros pares
            Console.WriteLine("Numeros pares:\n");
            foreach (int n in numP) // Mostramos los resultados de los numeros pares que contiene el Array
            {
                Console.WriteLine(n);
            }
            
        }
    }
}
