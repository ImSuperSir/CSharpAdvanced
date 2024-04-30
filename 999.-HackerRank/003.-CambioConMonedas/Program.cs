using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace _003._CambioConMonedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            int[] monedas = { 1,2 };
            int monedaspuntero = monedas.Length;
            int monto = 2;
            int lcounter = 0;

            Stopwatch stopwatch = new Stopwatch();

            //int lResultado = Exercise.CambioConMonedas(monedas, monedaspuntero, monto, "primera", 0);
            var lResulado = Exercise.GenerarCombinaciones(monto,monedas);
            //Console.WriteLine($"Numero de combinaciones:{lResultado}");

            stopwatch.Stop();
            Console.WriteLine($"Recursive algorithm {stopwatch.ElapsedTicks:N0} ticks.");
        }
    }


    public class Exercise 
    {


        /// <summary>
        /// This algorithm aims to determine:
        /// The distinct total combinations of coins to reach the required "x" amount
        /// The input parameters are :
        /// The work of each coin available
        /// The amount to complete with the coins
        /// </summary>
        public static int CambioConMonedas(int[] monedas, int monedasIndice, int monto, string lLabel, int lCounter)
        {

            lCounter++;

            Console.WriteLine($"Array : { string.Join(",", monedas)}" +
                $", MonedasIndice:{monedasIndice}" +
                $", Monto:{monto}" +
                $", Lado: {lLabel}" +
                $", Counter: {lCounter}");

            //Console.ReadLine();

            /*
                monedas indice is a kind of pointer to indicate 
                the current index of the coin to be considered

                We are supposed to iterate through the array, coin by coin, 
                so, we need to keep track of the index of the coin being considerd
             */


            if (monto == 0)
            {
                Console.WriteLine("Estamos regresando 1;");
                return 1;  //we return 1, because the recursive algorithm
            }


            //if there is no coins and mount > 0, there is no a solution
            // or
            //If the amount is negative, there is no a solution
            if ((monedasIndice <= 0 && monto != 0) || (monto < 0))
            {
                Console.WriteLine("Estamos regresando 0;");
                return 0;
            }

            //int lResultado1 = CambioConMonedas(monedas, monedasIndice - 1, monto, "Izquierda", lCounter);
            int lResultado2 = CambioConMonedas(monedas, monedasIndice, monto - monedas[monedasIndice - 1], "derecha", lCounter);


            //Console.WriteLine($"Resultado1:{lResultado1}, Resultado2:{lResultado2}");

            Console.WriteLine($"Resultado2:{lResultado2}");

            return lResultado2;// + lResultado2;
            //Console.WriteLine($"Terminado lado:{lLabel}, couter:{lCounter}.");
        
        }



        public static List<List<int>> GenerarCombinaciones(int cantidad, int[] denominaciones)
        {
            List<List<int>> todasCombinaciones = new List<List<int>>();
            GenerarCombinacionesRecursivo(cantidad, denominaciones, new List<int>(), todasCombinaciones, 0);
            return todasCombinaciones;
        }

        static void GenerarCombinacionesRecursivo(int cantidadRestante, int[] denominaciones, List<int> combinacionActual, List<List<int>> todasCombinaciones, int indiceDenominacion)
        {
            if (cantidadRestante == 0)
            {
                todasCombinaciones.Add(new List<int>(combinacionActual));
                return;
            }

            for (int i = indiceDenominacion; i < denominaciones.Length; i++)
            {
                if (denominaciones[i] <= cantidadRestante)
                {
                    combinacionActual.Add(denominaciones[i]);
                    GenerarCombinacionesRecursivo(cantidadRestante - denominaciones[i], denominaciones, combinacionActual, todasCombinaciones, i);
                    combinacionActual.RemoveAt(combinacionActual.Count - 1);
                }
            }
        }
    }
}
