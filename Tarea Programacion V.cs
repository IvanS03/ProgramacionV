using System;

namespace ConsoleApp1
{
    class Program
    {

		public static class GlobalMembers
		{
			public static double funcion1(double a)
			{

				double resul = 3.14 * (a * a);
				return resul;
			}

			public static double funcion2(double a, double b)
			{

				double resul = a * b;
				return resul;
			}

			public static double funcion3(double a, double b)
			{

				double resul = (a * b) / 2;
				return resul;
			}

			internal static void Main()
			{

				while (true)
				{
					int a = 0;

					while (a < 51)
					{
						Console.Write("*");
						a++;
					}

					Console.Write("PROGRAMA PARA GEOMETRIA");

					int b = 0;
					while (b < 51)
					{
						Console.Write("*");
						b++;
					}

					string opcion;

					Console.Write("\n�Que area desea Calcular? \n(c) Circulo \n(r) Rectangulo \n(t) triangulo \n(s) Salir");
					opcion = Console.ReadLine();

					string c;


					if (opcion == "s")
					{
						break;
					}

					if (opcion == "c")
					{

						double vradio;
						Console.Write("Ingrese Radio");
						vradio = double.Parse(Console.ReadLine());
						double resultado = funcion1(vradio);
						Console.Write("\nEl resultado es:");
						Console.Write(resultado);
					}

					else if (opcion == "r")
					{

						double vbase;
						double valtura;

						Console.Write("Ingrese La Base");
						vbase = double.Parse(Console.ReadLine());

						Console.Write("Ingrese La Altura");
						valtura = double.Parse(Console.ReadLine());

						double resultado = funcion2(vbase, valtura);
						Console.Write("\nEl resultado es:");
						Console.Write(resultado);
					}

					else
					{

						double vbase;
						double valtura;

						Console.Write("Ingrese La Base");
						vbase = double.Parse(Console.ReadLine());

						Console.Write("Ingrese La Altura");
						valtura = double.Parse(Console.ReadLine());

						double resultado = funcion3(vbase, valtura);
						Console.Write("\nEl resultado es:");
						Console.Write(resultado);
					}



				}

				Console.Write("\nGracias por usar el programa de calculo geometrico\n");

			}

		}

	}
}
