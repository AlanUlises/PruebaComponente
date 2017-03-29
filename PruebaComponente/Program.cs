using System;
using ProyectoPruebas;

namespace PruebaComponente
{
    class Program
    {
        static void Main(string[] args)
        {
            Burbuja burbu = new Burbuja();
            int[] arr = new int[5];

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("Ingresa un numero: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());                
            }

            arr = burbu.ordenar(arr);

            for(int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);

            Console.Read();
        }
    }
}
