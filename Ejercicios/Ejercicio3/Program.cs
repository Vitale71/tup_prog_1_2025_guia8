namespace Ejercicio3
{
    internal class Program
    {
        #region decalracion variables
        static string nombre0;
        static int numeroLibreta0;
        static string nombre1;
        static int numeroLibreta1;
        static string nombre2;
        static int numeroLibreta2;
        static int orden;
        #endregion

        #region metodos de calculos
        static int RegistrarNombreYNumeroLibreta(string nombre, int libreta)
        {
            if (orden == 1)
            {
                nombre0 = nombre;
                numeroLibreta0 = libreta;
            }
            if (orden == 2)
            {
                nombre1 = nombre;
                numeroLibreta1 = libreta;
            }
            if (orden == 3)
            {
                nombre2 = nombre;
                numeroLibreta2 = libreta;
            }
            return libreta;
        }

        #endregion

        #region metodos de pantalla
        static int MostrarPantallaSolicitarOpcionesMenu()
        {
            Console.Clear();
            Console.WriteLine("\t\tEjercicio3\n\n");
            Console.WriteLine("1 - Registrar las notas de los tres alumnos.");
            Console.WriteLine("2 - Mostrar lista ordenada.");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static void MostrarPantallaListaOrdenada()
        {
            Console.Clear();
            Console.WriteLine("\t\t Mostrar lista ordenada.\n\n");
            if (numeroLibreta0 != 0 && numeroLibreta1 != 0 && numeroLibreta2 != 0)
            {
                if (numeroLibreta0 > numeroLibreta1)
                {
                    if (numeroLibreta0 > numeroLibreta2)
                    {
                        if (numeroLibreta2 > numeroLibreta1)
                        {
                            Console.WriteLine("las notas ordenadas quedaria: {0}, {1}, {2} " , numeroLibreta0, numeroLibreta2, numeroLibreta1);
                        }
                        else
                        {
                            Console.WriteLine("las notas ordenadas quedarian: {0}, {1}, {2}" , numeroLibreta0, numeroLibreta1, numeroLibreta2);
                        }
                    }
                    else
                    {
                        Console.WriteLine("las notas ordenadas quedarian: {0}, {1}, {2}" , numeroLibreta2, numeroLibreta0, numeroLibreta1);
                    }
                }
                else
                {
                    if (numeroLibreta1 > numeroLibreta2)
                    {
                        if (numeroLibreta2 > numeroLibreta0)
                        {
                            Console.WriteLine("las notas ordenadas quedarian: {0}, {1}, {2}" , numeroLibreta1, numeroLibreta2, numeroLibreta0);
                        }
                        else
                        {
                            Console.WriteLine("las notas ordenadas quedarian: {0}, {1}, {2}" , numeroLibreta1, numeroLibreta0, numeroLibreta2);
                        }

                    }
                    else
                    {
                        Console.WriteLine("las notas ordenadas quedarian: {0}, {1}, {2}" , numeroLibreta2, numeroLibreta1, numeroLibreta0);
                    }
                }
                Console.WriteLine("\n\n");
                Console.WriteLine("presione enter para seguir");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Faltan las notas que ingresar.\n\n");
                Console.WriteLine("presione enter para seguir");
                Console.ReadKey();
            }
        }

        static void MostrarPantallaSolicitarAlumnos()
        {
            while (orden != 3)
            {
                orden += 1;
                Console.Clear();
                Console.WriteLine("\t\t Registrar las Notas de los tres alumnos.\n\n");
                Console.WriteLine("ingrese el nombre del alumno ", orden);
                string alumno = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\t\t Registrar las Notas de los tres alumnos.\n\n");
                Console.WriteLine("ingrese la nota (1-100) del alumno ", orden);
                int nota = Convert.ToInt32(Console.ReadLine());
                if (nota >= 1 && nota <= 100)
                {
                    RegistrarNombreYNumeroLibreta(alumno, nota);
                }
                else
                {
                    orden -= 1;
                    Console.Clear();
                    Console.WriteLine("\t\t Registrar las Notas de los tres alumnos.\n\n");
                    Console.WriteLine("nota del alumno no valida vuelva a intentarlo. \n\n");
                    Console.WriteLine("presione enter para seguir");
                    Console.ReadKey();
                }
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
                        MostrarPantallaSolicitarAlumnos();
                        break;

                    case 2:
                        MostrarPantallaListaOrdenada();
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
