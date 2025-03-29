using System;

namespace proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("Bienvenido al menu de opciones para calcular tus matrices, escoge una de las siguientes opciones:");


            var lista = new string[10] {
                "Verificar si dos matrices son iguales o no",
                "Sumar 2 matrices",
                "Generar una matriz 0 de n * m",
                "Obtener el inverso aditivo de una matriz de n * m",
                "Restar 2 matrices",
                "Multiplicar un escalar por una matriz de n * m",
                "Multiplicar 2 matrices compatibles",
                "Obtener una matriz identidad de tamaño n",
                "Obtener la inversa de una matriz de tamaño n",
                "Obtener el determinante de una matriz de tamaño n"
            };

            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine($"  {i + 1}. {lista[i]}");
            }

            int opcion;
            int intentos = 3;

            for (int i = 0; i < intentos; i++)
            {
                Console.Write("\n Seleccione una opción del 1 al 10: \n ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion < 1 || opcion > 10)
                {
                    Console.WriteLine("Debe seleccionar una opción del 1 al 10 \n");
                    Console.WriteLine($"Intentos restantes: {intentos - (i + 1)} \n");
                }
                else
                {
                    Console.WriteLine($"Has seleccionado la opción {opcion}: {lista[opcion - 1]}");


                    switch (opcion)
                    {
                        case 1:
                            Primercaso();
                            break;
                        case 2:
                            Segundocaso();
                            break;
                        case 3:
                            Tercercaso();
                            break;
                        case 4:
                            Cuartocaso();
                            break;
                        case 5:
                            Quintocaso();
                            break;
                        case 6:
                            Sextocaso();
                            break;
                        case 7:
                            Septimocaso();
                            break;
                        case 8:
                            Octavocaso();
                            break;
                        case 9:
                            Novenocaso();
                            break;
                        case 10:
                            Decimocaso();
                            break;
                        default:
                            break;
                    }
                }

                if (i == intentos - 1)
                {
                    Console.WriteLine("Número de intentos agotados, el programa se cerrará. \n");
                    return;
                }
            }
        }
        static void Volver()
        {
            Console.WriteLine("¿Deseas volver al menú? (si/no) \n");
            string opcion = Console.ReadLine().ToLower();

            switch (opcion)
            {
                case "si":
                    Menu();
                    break;

                case "no":
                    Console.WriteLine("El programa se cerrará.");
                    Environment.Exit(0);
                    break;

                default:
                    int intentos = 3;

                    for (int i = 0; i < intentos; i++)
                    {
                        Console.WriteLine("Opción inválida, intenta de nuevo \n");
                        Console.WriteLine($"Intentos restantes: {intentos - (i + 1)}");
                        string op = Console.ReadLine().ToLower();

                        if (op == "si")
                        {
                            Menu();
                            return;
                        }
                        else if (op == "no")
                        {
                            Console.WriteLine("El programa se cerrará.");
                            Environment.Exit(0);
                        }

                        if (i == intentos - 1)
                        {
                            Console.WriteLine("Se acabaron los intentos. El programa se cerrará.");
                            Environment.Exit(0);
                        }
                    }
                    break;
            }

        }


        static void Primercaso()
        {
            Console.WriteLine("Vamos a determinar si las 2 matrices son iguales. \n");


            Console.WriteLine("Ingrese el número de filas de la matriz \n");
            int f = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas de la matriz \n");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"Su matriz va a ser de {f}*{c} \n");


            var matrizA = new int[f, c];

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posición ({i + 1},{j + 1}): ");
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("La matriz A es: ");


            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(matrizA[i, j] + "\t");
                }
                Console.WriteLine();
            }

            var matrizB = new int[f, c];
            Console.WriteLine("Valores para la segunda matriz \n");


            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posición ({i + 1},{j + 1}): \n");
                    matrizB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("La matriz B es: \n");


            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(matrizB[i, j] + "\t");
                }
                Console.WriteLine();
            }

            bool matricesIguales = true;

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (matrizA[i, j] != matrizB[i, j])
                    {
                        matricesIguales = false;
                    }
                }
            }

            if (matricesIguales)
            {
                Console.WriteLine("Sus 2 matrices son iguales. \n");

            }
            else
            {
                Console.WriteLine("Los valores de ambas matrices no coinciden, por lo tanto no son iguales.\n");
            }

            Volver();


        }

        static void Segundocaso()
        {
            Console.WriteLine("vamos a sumar 2 matrices");


            Console.WriteLine("Ingrese el número de filas de la matriz \n");
            int f = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas de la matriz \n");
            int c = int.Parse(Console.ReadLine());


            Console.WriteLine($"Su matriz va a ser de {f}*{c}");

            var matrizA = new int[f, c];

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posición ({i + 1},{j + 1}):");
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("La matriz A es: \n");


            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(matrizA[i, j] + "\t");
                }
                Console.WriteLine();
            }

            var matrizB = new int[f, c];
            Console.WriteLine("Valores para la segunda matriz: \n");


            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posición ({i + 1},{j + 1}): \n");
                    matrizB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("La matriz B es: \n");


            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(matrizB[i, j] + "\t");
                }
                Console.WriteLine();
            }
            var matrizC = new int[f, c];

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }

            Console.WriteLine("La suma de las matrices es: \n");

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(matrizC[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Volver();
        }

        static void Tercercaso()
        {
            Console.WriteLine("Vamos a generar una matriz 0 de n * m \n");


            Console.WriteLine("Ingrese el número de filas de la matriz \n");
            int f = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas de la matriz \n");
            int c = int.Parse(Console.ReadLine());


            Console.WriteLine($"Su matriz va a ser de {f}*{c} \n");


            var matrizA = new int[f, c];

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matrizA[i, j] = matrizA[i, j] * 0;
                }
            }

            Console.WriteLine("Su matriz de n x m generada con 0 es:");

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(matrizA[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Volver();
        }

        static void Cuartocaso()
        {
            Console.WriteLine("Vamos a obtener el inverso aditivo de una matriz de n * m");


            Console.WriteLine("Ingrese el número de filas de la matriz");
            int f = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas de la matriz");
            int c = int.Parse(Console.ReadLine());


            Console.WriteLine($"Su matriz va a ser de {f}*{c}");

            var matrizA = new int[f, c];

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posición ({i + 1},{j + 1}):");
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("La matriz A es: \n \n");


            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(matrizA[i, j] + "\t");
                }
                Console.WriteLine();
            }


            var matrizB = new int[f, c];

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matrizB[i, j] = matrizA[i, j] * -1;
                }
            }

            Console.WriteLine("El inverso aditivo de la matriz de n x m es: \n");

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(matrizB[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Volver();
        }
        static void Quintocaso()
        {
            Console.WriteLine("vamos a restar 2 matrices \n");


            Console.WriteLine("Ingrese el número de filas de la matriz");
            int f = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas de la matriz");
            int c = int.Parse(Console.ReadLine());


            Console.WriteLine($"Su matriz va a ser de {f}*{c}");

            var matrizA = new int[f, c];

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posición ({i + 1},{j + 1}):");
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("La matriz A es:");


            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(matrizA[i, j] + "\t");
                }
                Console.WriteLine();
            }

            var matrizB = new int[f, c];
            Console.WriteLine("Valores para la segunda matriz");


            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posición ({i + 1},{j + 1}): \n");
                    matrizB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("La matriz B es: \n");


            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(matrizB[i, j] + "\t");
                }
                Console.WriteLine();
            }
            var matrizC = new int[f, c];

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matrizC[i, j] = matrizA[i, j] - matrizB[i, j];
                }
            }

            Console.WriteLine("La resta de las matrices es: \n");

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(matrizC[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Volver();
        }

        static void Sextocaso()
        {
            Console.WriteLine("Vamos a multiplicar un escalar por la matriz de n * m");


            Console.WriteLine("Ingrese el numero del escalar");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de filas de la matriz \n");
            int f = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas de la matriz \n");
            int c = int.Parse(Console.ReadLine());


            Console.WriteLine($"Su matriz va a ser de {f}*{c}");

            var matrizA = new int[f, c];

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posición ({i + 1},{j + 1}): \n");
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("La matriz A es: \n");

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(matrizA[i, j] + "\t");
                }
                Console.WriteLine();
            }


            var matrizB = new int[f, c];

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matrizB[i, j] = matrizA[i, j] * e;
                }
            }

            Console.WriteLine("La multiplicacion de un escalar por la matriz de n x m es: \n");

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(matrizB[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Volver();
        }

        static void Septimocaso()
        {
            Console.WriteLine("Vamos a multiplicar 2 matrices compatibles \n");


            Console.WriteLine("Ingrese el número de filas de la matriz A \n");
            int fa = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas de la matriz A \n");
            int ca = int.Parse(Console.ReadLine());

            Console.WriteLine($"Su matriz va a ser de {fa}*{ca}");

            Console.WriteLine("Ingrese el número de filas de la matriz B \n");
            int fb = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas de la matriz B \n");
            int cb = int.Parse(Console.ReadLine());

            Console.WriteLine($"Su matriz va a ser de {fb} * {cb} \n");

            if (ca == fb)
            {
                Console.WriteLine("Las matrices son compatibles ya que la matriz A tiene el mismo numero de columnas que la matriz B tiene de filas \n");


                var matrizA = new int[fa, ca];

                for (int i = 0; i < fa; i++)
                {
                    for (int j = 0; j < ca; j++)
                    {
                        Console.WriteLine($"Ingrese el valor para la posición ({i + 1},{j + 1}):");
                        matrizA[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("La matriz A es: \n");

                for (int i = 0; i < fa; i++)
                {
                    for (int j = 0; j < ca; j++)
                    {
                        Console.Write(matrizA[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                var matrizB = new int[fb, cb];
                Console.WriteLine("Valores para la segunda matriz \n");

                for (int i = 0; i < fb; i++)
                {
                    for (int j = 0; j < cb; j++)
                    {
                        Console.WriteLine($"Ingrese el valor para la posición ({i + 1},{j + 1}): \n");
                        matrizB[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("La matriz B es: \n");

                for (int i = 0; i < fb; i++)
                {
                    for (int j = 0; j < cb; j++)
                    {
                        Console.Write(matrizB[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                var matrizC = new int[fa, cb];

                for (int i = 0; i < fa; i++)
                {
                    for (int j = 0; j < cb; j++)
                    {
                        for (int k = 0; k < ca; k++)
                        {
                            matrizC[i, j] += matrizA[i, k] * matrizB[k, j];
                        }
                    }
                }


                Console.WriteLine("La matriz C es: \n");


                for (int i = 0; i < fa; i++)
                {
                    for (int j = 0; j < cb; j++)
                    {
                        Console.Write(matrizC[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                Volver();

            }
            else
            {
                Console.WriteLine("No son compatibles ya que el numero de columnas de la matriz A no es el mismo que el numero de filas de la matriz B \n");
                Volver();
            }
        }

        static void Octavocaso()
        {
            Console.WriteLine("Ingrese el tamaño de la matriz identidad (número de filas y columnas): \n");
            int n = int.Parse(Console.ReadLine());


            var matrizIdentidad = new int[n, n];


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        matrizIdentidad[i, j] = 1;
                    }
                    else
                    {
                        matrizIdentidad[i, j] = 0;
                    }
                }
            }

            Console.WriteLine("La matriz identidad es:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrizIdentidad[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Volver();

        }


        static void Novenocaso()
        {
            Console.WriteLine("Vamos a obtener la inversa de una matriz \n");
            Console.WriteLine("Ingrese el número de filas de la matriz \n");
            int f = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas de la matriz \n");
            int c = int.Parse(Console.ReadLine());

            if (f != c)
            {
                Console.WriteLine("La matriz debe ser cuadrada para calcular la inversa, es decir deben tener la misma cantidad de lados y columnas. \n");
                Volver();
            }

            Console.WriteLine($"Su matriz va a ser de {f}*{c} \n");
            var matrizA = new double[f, c];

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posición ({i + 1},{j + 1}):");
                    matrizA[i, j] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("La matriz es: \n");
            Impmatriz(matrizA, f, c);

            double[,] inversa = Calinversa(matrizA, f);
            if (inversa.GetLength(0) == 0)
            {
                Console.WriteLine("\nLa matriz no tiene inversa (determinante es 0).");
            }
            else
            {
                Console.WriteLine("\nLa matriz inversa es:");
                Impmatriz(inversa, f, f);
            }

            Volver();
        }

        static double[,] Calinversa(double[,] matriz, int n)
        {
            double[,] matrizex = new double[n, 2 * n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrizex[i, j] = matriz[i, j];

                    if (i == j)
                    {
                        matrizex[i, j + n] = 1;
                    }
                    else
                    {
                        matrizex[i, j + n] = 0;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                double pivote = matrizex[i, i];
                if (pivote == 0) return new double[0, 0];

                for (int j = 0; j < 2 * n; j++)
                {
                    matrizex[i, j] /= pivote;
                }

                for (int k = 0; k < n; k++)
                {
                    if (k != i)
                    {
                        double factor = matrizex[k, i];
                        for (int j = 0; j < 2 * n; j++)
                        {
                            matrizex[k, j] -= factor * matrizex[i, j];
                        }
                    }
                }
            }

            double[,] inversa = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    inversa[i, j] = matrizex[i, j + n];
                }
            }

            return inversa;
        }

        static void Impmatriz(double[,] matriz, int f, int c)
        {
            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(matriz[i, j].ToString("0.##") + "\t"); //el ToString("0.##") lo ocupe para que solo retorne 2 decimal en caso de que sea necesario, si no, solo retorna un valor entero 
                }
                Console.WriteLine();
            }
        }


        static void Decimocaso()
        {
            Console.WriteLine("Vamos a obtener el determinante de una matriz de tamaño n \n");
            Console.WriteLine("Ingrese el número de filas de la matriz");
            int f = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas de la matriz \n");
            int c = int.Parse(Console.ReadLine());

            if (f != c)
            {
                Console.WriteLine("La matriz debe ser cuadrada para calcular el determinante \n");
                Volver();
            }

            Console.WriteLine($"Su matriz va a ser de {f}x{c} \n");
            var matrizA = new int[f, c];

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posición ({i + 1},{j + 1}):");
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("La matriz es: \n");

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(matrizA[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int determinante = CalcularDeterminante(matrizA, f);
            Console.WriteLine($"\nEl determinante de la matriz es: {determinante} \n");

            Volver();
        }

        static int CalcularDeterminante(int[,] matriz, int n)
        {
            if (n == 1)
            {
                return matriz[0, 0];
            }

            if (n == 2)
            {
                return matriz[0, 0] * matriz[1, 1] - matriz[0, 1] * matriz[1, 0];
            }

            int determinante = 0;
            int[,] subMatriz = new int[n - 1, n - 1];

            for (int x = 0; x < n; x++)
            {
                int subMatrizFil = 0;
                for (int i = 1; i < n; i++)
                {
                    int subMatrizCol = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (j == x)
                            continue;
                        subMatriz[subMatrizFil, subMatrizCol] = matriz[i, j];
                        subMatrizCol++;
                    }
                    subMatrizFil++;
                }

                determinante += (int)Math.Pow(-1, x) * matriz[0, x] * CalcularDeterminante(subMatriz, n - 1);
            }

            return determinante;
        }

    }
}