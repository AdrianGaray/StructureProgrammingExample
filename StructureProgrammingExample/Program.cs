using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureProgrammingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            double operation;
            double firstdata;
            double seconddata;

            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine("Operacion Calculadora:");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Salir del Programa");
                operation = GetDoubleDataFromUser("Seleccionar operacion a ejecutar");

                switch (operation)
                {
                    case 1:
                        // Suma
                        firstdata = GetDoubleDataFromUser("Ingrese el primer parametro, debe ser entero:");
                        seconddata = GetDoubleDataFromUser("Ingrese el segundo parametro, debe ser entero:");
                        // string con Interpolacion
                        Console.WriteLine($"El resultado de la Suma {firstdata} + {seconddata} = {firstdata + seconddata}");
                        break;
                    case 2:
                        // Resta
                        firstdata = GetDoubleDataFromUser("Ingrese el primer parametro, debe ser entero:");
                        seconddata = GetDoubleDataFromUser("Ingrese el segundo parametro, debe ser entero:");
                        // string con Interpolacion
                        Console.WriteLine($"El resultado de la Resta {firstdata} + {seconddata} = {firstdata - seconddata}");
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("La opcion seleccionada no existe.");
                        break;
                }
                Console.WriteLine("Presione cualquier tecla para seguir operando");
                Console.ReadKey();
                Console.Clear();                
            }
        }

        private static int GetIntegerDataFromUser(string message)
        {
            string userData;
            int data = 0;
            bool isDataValid = false;

            while (!isDataValid)
            {
                Console.WriteLine(message);
                userData = Console.ReadLine();

                if (!int.TryParse(userData, out data))
                {
                    Console.WriteLine("El dato que no es valido. Vuelva a intentar de nuevo");
                }
                else
                {
                    isDataValid = true;
                }
            }

            return data;
        }

        public static double GetDoubleDataFromUser(string message) 
        {
            string userData;
            double data = 0;
            bool isDataValid = false;

            while (!isDataValid)
            {
                Console.WriteLine(message);
                userData = Console.ReadLine();

                if (!double.TryParse(userData, out data))
                {
                    Console.WriteLine("El dato que no es valido. Vuelva a intentar de nuevo");
                }
                else
                {
                    isDataValid = true;
                }
            }

            return data;
        }
    }
}
