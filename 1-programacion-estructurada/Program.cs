using System;
using System.Diagnostics.Metrics;
using System.Numerics;



namespace ConsoleApp2
{


    public class Program

    {

        static void Main()
        {
            bool continuar = true;
            int a;
            int b;
            Console.Clear();
            do
            {
                Console.WriteLine("Menu de proyecto");
                Console.WriteLine("1. Calculadora");
                Console.WriteLine("2. Tabla de multiplicar");
                Console.WriteLine("3. Seleccionar numero mas pequeno");
                Console.WriteLine("4. piramide");
                Console.WriteLine("5. cerrar");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        bool continuar2 = true;

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Menu de la calculadora");
                            Console.WriteLine("1. sumar");
                            Console.WriteLine("2. restar");
                            Console.WriteLine("3. multiplicar");
                            Console.WriteLine("4. dividir");
                            Console.WriteLine("5. salir de la calculadora");

                            string option2 = Console.ReadLine();

                            switch (option2)
                            {

                                case "1":
                                    Console.WriteLine("Ingrese 2 numeros a sumar");
                                    a = int.Parse(Console.ReadLine());
                                    b = int.Parse(Console.ReadLine());
                                    Utils.FSuma(a, b);
                                    break;

                                case "2":
                                    Console.WriteLine("Ingrese 2 numeros a restar");
                                    a = int.Parse(Console.ReadLine());
                                    b = int.Parse(Console.ReadLine());
                                    Utils.FResta(a, b);
                                    break;

                                case "3":
                                    Console.WriteLine("Ingrese 2 numeros a multiplicar");
                                    a = int.Parse(Console.ReadLine());
                                    b = int.Parse(Console.ReadLine());
                                    Utils.FMultiplicacion(a, b);
                                    break;

                                case "4":
                                    Console.WriteLine("Ingrese 2 numeros a dividir");
                                    a = int.Parse(Console.ReadLine());
                                    b = int.Parse(Console.ReadLine());
                                    Utils.FDivision(a, b);
                                    break;

                                case "5":
                                    Console.WriteLine("Saliendo de la calculadora");
                                    continuar2 = false;
                                    break;
                                default:
                                    Console.WriteLine("Opción no válida");
                                    break;
                            }
                            if (continuar2)
                            {
                            Console.WriteLine("Presione enter para continuar");
                            Console.ReadKey();
                            Console.Clear();
                                
                            }
                        } while (continuar2);
                        break;

                    case "2":
                        Console.WriteLine("app que reciba 2 numeros y haga la tabla desde el 1 hasta el primer numero hasta el 2do numero");
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        Utils.FTabla(a, b);
                        break;

                    case "3":
                        Console.WriteLine("Escriba la cantidad de numeros");
                        int M = Math.Abs(int.Parse(Console.ReadLine()));
                        int[] datos = new int[M];

                        for (int i = 0; i < M; i++)
                        {
                            Console.WriteLine($"Ingrese el dato {i + 1}:");
                            datos[i] = int.Parse(Console.ReadLine());
                        }

                        int menor = Utils.EncontrarMenor(datos);
                        Console.WriteLine($"El menor es: {menor}");
                        break;

                    case "4":
                        Console.WriteLine("Escriba el numero de lineas del arbol");
                        a = int.Parse(Console.ReadLine());
                        Utils.FPiramide(a);
                        break;

                    case "5":
                        Console.WriteLine("Gracias, vuelva prontos");
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("opcioon no valida");
                        break;


                }
                Console.WriteLine("Presione enter para continuar");
                Console.ReadKey();
                Console.Clear();
            } while (continuar);
        }

    }
}