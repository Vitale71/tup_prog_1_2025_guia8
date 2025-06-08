namespace Ejercicio5
{
    internal class Program
    {
        static int DeterminarLosDiasDelMes(int nroMes, int año)
        {
            if (nroMes == 1) 
            {
                Console.WriteLine( "el mes es enero con 31 dias\n\n");
                Console.WriteLine("presione enter para salir");
                Console.ReadKey();
            }
            if (nroMes == 2) {
                if (DeterminarSiEsBisiesto(año))
                {
                    Console.WriteLine("el mes de enero tiene 29 dias\n\n");
                    Console.WriteLine("presione enter para salir");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("el mes de enero tiene 28 dias\n\n");
                    Console.WriteLine("presione enter para salir");
                    Console.ReadKey();
                }
            }
            if (nroMes == 3)
            {
                Console.WriteLine("el mes es marzo con 31 dias\n\n");
                Console.WriteLine("presione enter para salir");
                Console.ReadKey();
            }
            if (nroMes == 4)
            {
                Console.WriteLine("el mes es abril con 30 dias\n\n");
                Console.WriteLine("presione enter para salir");
                Console.ReadKey();
            }
            if (nroMes == 5) 
            {
               Console.WriteLine("el mes es mayo con 31 dias\n\n");
                Console.WriteLine("presione enter para salir");
                Console.ReadKey();
            }
            if (nroMes == 6)
            {
                Console.WriteLine ("el mes es junio con 30 dias\n\n");
                Console.WriteLine("presione enter para salir");
                Console.ReadKey();
            }
            if (nroMes == 7)
            {
                Console.WriteLine("el mes es julio con 31 dias\n\n");
                Console.WriteLine("presione enter para salir");
                Console.ReadKey();
            }
            if (nroMes == 8)
            {
                Console.WriteLine("el mes es agosto con 31 dias\n\n");
                Console.WriteLine("presione enter para salir");
                Console.ReadKey();
            }
            if (nroMes == 9)
            {
                Console.WriteLine("el mes es septiembre con 30 dias\n\n");
                Console.WriteLine("presione enter para salir");
                Console.ReadKey();
            }
            if (nroMes == 10)
            {
                Console.WriteLine ("el mes es octubre con 31 dias\n\n");
                Console.WriteLine("presione enter para salir");
                Console.ReadKey();
            }
            if (nroMes == 11)
            {
                Console.WriteLine("el mes es noviembre con 30 dias\n\n");
                Console.WriteLine("presione enter para salir");
                Console.ReadKey();
            }
            if (nroMes == 12)
            {
                Console.WriteLine("el mes es diciembre con 31 dias\n\n");
                Console.WriteLine("presione enter para salir");
                Console.ReadKey();
            }
            if (nroMes >= 13) {
            Console.WriteLine("el numero que ingreso no es un mes\n\n");
                Console.WriteLine("presione enter para salir");
                Console.ReadKey();
            }
            return nroMes;
        }

        static bool DeterminarSiEsBisiesto(int año)
        {
            if (año % 4 == 0)
            {
                if (año % 100 == 0)
                {
                    if (año % 400 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("\t\t Ejercicio3 \n\n");
            Console.WriteLine("1- Determinar cantidad de dias del mes.");
            Console.WriteLine("2- Verificar si es año bisiesto.");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        static void MostrarPantallaSolicitarMesAñoYDeterminarDias()
        {
            Console.Clear();
            Console.WriteLine("\t\t Determinar cantidad de dias del mes\n\n");
            Console.WriteLine("ingrese año y luego numero del mes");
            int Año = Convert.ToInt32(Console.ReadLine());
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("\t\t Determinar cantidad de dias del mes\n\n");
            DeterminarLosDiasDelMes(mes, Año);
        }
        static void MostrarPantallaVerificarSiElAñoEsBisiesto()
        {
            Console.Clear();
            Console.WriteLine("\t\t Verificar si es año bisiesto\n\n");
            Console.WriteLine("ingrese el año");
            int Año = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("\t\t Determinar cantidad de dias del mes\n\n");
            if (DeterminarSiEsBisiesto(Año))
            {
                Console.WriteLine("el año es bisiesto\n\n");
                Console.WriteLine("presione enter para salir");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("el año no es bisiesto\n\n");
                Console.WriteLine("presione enter para salir");
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            int op = MostrarPantallaSolicitarOpcionMenu();
            while (op != -1)
            {
                switch (op)
                {
                    case 1: 
                        MostrarPantallaSolicitarMesAñoYDeterminarDias();
                        break;

                    case 2:

                        break;

                    default:
                        op = -1;
                        break;
                }
                if (op != -1)
                {
                    op = MostrarPantallaSolicitarOpcionMenu();
                }
            }
        }
    }
}
