using System;
using System.Collections.Generic;
//using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        #region resolucion del problema
        static int acumulador;
        static int contador;
        static int maximo;
        static int minimo;
        #endregion

        #region metodos de pantalla
        static void inicializarVariables()
        {
            acumulador = 0;
            contador = 0;
            maximo = 0;
            minimo = 0;
            Console.Clear();
            Console.WriteLine("\t\t Reiniciar variables. \n\n");
            Console.WriteLine("se reiniciaron las variables correctamente\n\n");
            Console.WriteLine("presione enter para seguir");
            Console.ReadKey();
        }

        static void registrarValor(int valor)
        {
            acumulador += valor;


            if (valor > maximo || contador == 0)
            {
                maximo = valor;
            }

            if (valor < minimo || contador == 0)
            {
                minimo = valor;
            }
            contador += 1;
        }
        static double CalcularPromedio()
        {
            double prom = 0;
            if (contador != 0)
            {
                prom = 1.0 * acumulador / contador;
            }
            return prom;
        }
        static void MostrarMaximoyMinimo()
        {
            Console.Clear();
            Console.WriteLine("\t\t mostrar maximo y minimo. \n\n");
            if (contador != 0)
            {
                Console.WriteLine($"Maximo: {maximo}");
                Console.WriteLine($"Minimo: {minimo}\n\n\n");
            }
            else
            {
                Console.WriteLine("no hubo ingresos todavia\n\n");
            }
            Console.WriteLine("presione enter para seguir");
            Console.ReadKey();
        }
        static void MostrarPromedio()
        {
            Console.Clear();
            Console.WriteLine("\t\t Mostrar promedio \n\n");
            double prom = CalcularPromedio();
            if (prom != 0)
            {
                Console.WriteLine($"el promedio es: {prom}\n\n\n");
            }
            else
            {
                Console.WriteLine("no hubo ingresos todavia\n\n");
            }
            Console.WriteLine("presione enter para seguir");
            Console.ReadKey();
        }
        static void MostrarPantallaCantidad()
        {
            Console.Clear();
            Console.WriteLine("\t\t Mostrar cantidad de numeros \n\n\n");

            Console.WriteLine($"la cantidad de numeros ingresados es: {contador}\n\n\n");

            Console.WriteLine("presione enter para seguir");
            Console.ReadKey();
        }
        #endregion

        #region metodos de pantalla
        static int MostrarPantallaSolicitarOpcionesMenu()
        {
            Console.Clear();
            Console.WriteLine("\t\tEjercicio1\n\n");
            Console.WriteLine("1. - procesar un solo numero.");
            Console.WriteLine("2. - procesar varios numeros.");
            Console.WriteLine("3. - mostrar maximo y minimo.");
            Console.WriteLine("4. - Mostrar promedio.");
            Console.WriteLine("5. - mostrar cantidad de numeros ingresados.");
            Console.WriteLine("6. - reiniciar variables.");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static void SolicitarPantallaIngresarNumero()
        {
            Console.Clear();
            Console.WriteLine("\t\t solicitud de valor a el usuario\n\n");
            Console.WriteLine("ingrese un numero");
            int valor = Convert.ToInt32(Console.ReadLine());
            registrarValor(valor);
        }
        static void SolicitarPantallaIngresarVariosNumero()
        {
                Console.Clear();
                Console.WriteLine("\t\t Procesar varios valores a el usuario\n\n");
                Console.WriteLine("ingrese numeros o escriba -1 para salir");
                int valor = Convert.ToInt32(Console.ReadLine());
                while (valor != -1) {
                if (valor != -1)
                {
                    registrarValor(valor);
                }
                Console.Clear();
                Console.WriteLine("\t\t Procesar varios valores a el usuario\n\n");
                Console.WriteLine("ingrese numeros o escriba -1 para salir");
                valor = Convert.ToInt32(Console.ReadLine());
            }
        }
        #endregion

        static void Main(string[] args)
        {
            int op = MostrarPantallaSolicitarOpcionesMenu();
            while (op != -1)
            {
                switch (op)
                {
                    case 1:
                        SolicitarPantallaIngresarNumero();
                        break;

                    case 2:
                        SolicitarPantallaIngresarVariosNumero();
                        break;

                    case 3:
                        MostrarMaximoyMinimo();
                        break;

                    case 4:
                        MostrarPromedio();
                        break;
                    case 5:
                        MostrarPantallaCantidad();
                        break;
                    case 6:
                        inicializarVariables();
                        break;

                    default:
                        op = -1;
                        break;
                }
                if (op != -1)
                {
                    op = MostrarPantallaSolicitarOpcionesMenu();
                }
            }
        }

    }
}