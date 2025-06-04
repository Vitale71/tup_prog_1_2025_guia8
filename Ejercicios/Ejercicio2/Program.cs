namespace Ejercicio2
{
    internal class Program
    {
        #region resolucion del problema
        static int edad1;
        static int edad2;
        static int edad3;
        static int edad4;
        static double monto;
        static double porcentaje1;
        static double porcentaje2;
        static double porcentaje3;
        static double porcentaje4;
        static double monto1;
        static double monto2;
        static double monto3;
        static double monto4;
        #endregion

        #region metodos de calculos
        static double RegistrarMontoArepartir(double montoRegistrado)
        { 
            monto = montoRegistrado;
            return monto;
        }

        static int RegistrarEdad(int edadNiña, int nroNiña)
        {
            if (nroNiña == 1)
            {
                edad1 = edadNiña;
            }
            if (nroNiña == 2)
            {
                edad2 = edadNiña;
            }
            if (nroNiña == 3)
            {
                edad3 = edadNiña;
            }
            if (nroNiña == 4)
            {
                edad4 = edadNiña;
            }
            return edadNiña;
        }
        static void CalcularMontosYporcentajesARepartir()
        {
            
            int edadTotal = edad1 + edad2 + edad3 + edad4;
            porcentaje1 = (edad1 * 100) / edadTotal;
            porcentaje2 = (edad2 * 100) / edadTotal;
            porcentaje3 = (edad3 * 100) / edadTotal;
            porcentaje4 = (edad4 * 100) / edadTotal;
            monto1 = (porcentaje1 * monto) / 100;
            monto2 = (porcentaje2 * monto) / 100;
            monto3 = (porcentaje3 * monto) / 100;
            monto4 = (porcentaje4 * monto) / 100;
        }
        #endregion

        #region metodos de pantalla
        static int MostrarPantallaSolicitarOpcionesMenu()
        {
            Console.Clear();
            Console.WriteLine("\t\tEjercicio2\n\n");
            Console.WriteLine("1 - Iniciar Monto a repartir.");
            Console.WriteLine("2 - Solicitar Edad Por niña.");
            Console.WriteLine("3 - Mostrar monto y porcentajes que corresponde a cada niña.");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static void MostrarPantallaSolicitarMontoARepartir()
        {
            Console.Clear();
            Console.WriteLine("\t\t Registrar monto a repartir. \n\n");
            Console.WriteLine("ingrese el monto a repartir\n\n");
            int valor = Convert.ToInt32(Console.ReadLine());
            RegistrarMontoArepartir(valor);
        }
        static void MostrarPantallaSolicitarEdadesNiñas()
        {
            Console.Clear();
            Console.WriteLine("\t\t Solicitar edad por niña.\n\n");
            Console.WriteLine("ingrese la niña numero (1-4)");
            int niña = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("\t\t Solicitar edad por niña.\n\n");
            Console.WriteLine("ingrese la edad de la niña numero {0}" , niña);
            int edad = Convert.ToInt32(Console.ReadLine());
            if (niña >= 1 && niña <= 4 && edad >= 1)
            {
                RegistrarEdad(edad, niña);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\t\t Solicitar edad por niña.\n\n");
                Console.WriteLine("edad de la niña no registrada numeros no validos. \n\n");
                Console.WriteLine("presione enter para seguir");
                Console.ReadKey();
            }
        }

        static void MostrarPantallaCalcularMostrarMontoARepartir()
        {
            Console.Clear();
            Console.WriteLine("\t\t Mostrar monto y porcentajes que corresponde a cada niña. \n\n");
            if (monto != 0)
            {
                if (edad1 != 0 && edad2 != 0 && edad3 != 0 && edad4 != 0)
                {
                    CalcularMontosYporcentajesARepartir();
                    Console.WriteLine("niña edad: {0} el porcentaje es {1} el monto correspondiente: {2}", edad1, porcentaje1, monto1);
                    Console.WriteLine("niña edad: {0} el porcentaje es {1} el monto correspondiente: {2}", edad2, porcentaje2, monto2);
                    Console.WriteLine("niña edad: {0} el porcentaje es {1} el monto correspondiente: {2}", edad3, porcentaje3, monto3);
                    Console.WriteLine("niña edad: {0} el porcentaje es {1} el monto correspondiente: {2}\n\n", edad4, porcentaje4, monto4);
                    Console.WriteLine("presione enter para seguir");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("faltan edades que ingresar para mostrar los datos\n\n");
                    Console.WriteLine("presione enter para seguir");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("falta el monto a repartir para mostrar los datos\n\n");
                Console.WriteLine("presione enter para seguir");
                Console.ReadKey();
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
                        MostrarPantallaSolicitarMontoARepartir();
                        break;

                    case 2:
                        MostrarPantallaSolicitarEdadesNiñas();
                        break;

                    case 3:
                        MostrarPantallaCalcularMostrarMontoARepartir();
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