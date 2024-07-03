using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Utils
    {
        public static int FSuma(int a, int b)
        {
            int resultado = a + b;
            Console.WriteLine($"La suma de {a} y {b} es: {resultado}");
            return resultado;
        }
        public static int FResta(int a, int b)
        {
            int Resta = a - b;
            Console.WriteLine($"La resta de {a} y {b} es: {Resta}");
            return Resta;
        }
        public static int FMultiplicacion(int a, int b)
        {
            int Multiplicacion = a * b;
            Console.WriteLine($"La multiplicacion de {a} y {b} es: {Multiplicacion}");
            return Multiplicacion;
        }

        public static int FDivision(int a, int b)
        {
            int Division = a / b;
            Console.WriteLine($"La division de {a} y {b} es: {Division}");
            return Division;
        }
        public static void FTabla(int a, int b)
        {
            for (int F = 1; F <= a; F++)
            {
                for (int I = 1; I <= b; I++)
                {
                    int Z = I;
                    Console.Write(F + " x " + Z + " = " + (F * Z) + "   ");
                }
                Console.WriteLine();
            }
        }
        public static void FPiramide(int vA)
        {
            for (int a = 1; a <= vA; a++)
            {

                for (int b = 1; b <= a; b++)
                {
                    Console.Write(0);
                }
                Console.WriteLine();
            }
        }
        public static int EncontrarMenor(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("El arreglo no puede ser nulo o vacío.");
            }

            int menor = array[0]; // Suponemos que el primer número es el menor

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < menor)
                {
                    menor = array[i]; // Si encontramos un número menor, lo actualizamos
                }
            }

            return menor;
        }
    }
}
