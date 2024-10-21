using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AS2425._3GF.INF.Prof.CalcoloTasse
{
    /// <summary>
    /// REDDITO IMPONIBILE (per scaglioni)	ALIQUOTA (per scaglioni)
    ///     1. fino a euro 15.000,00				23%
    ///     2. da 15.001,00 fino a 28.000,00 euro	25%
    ///     3. da 28.001 fino a 50.000 euro			35%
    ///     4. oltre 50.000 euro					43%
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prof;3F;21/10/24;Calcolo delle tasse");

            double redditoImponibile;
            int aliquota = 0;

            Console.WriteLine("Digita il tuo reddito imponibile");

            if (double.TryParse(Console.ReadLine(), out redditoImponibile) == false)
            { 
                Console.WriteLine("Il valore inserito deve essere strettamente numerico senza € lettere o altro");
                return;
            }

            if (redditoImponibile > 50000)
            {
                aliquota = 43;
            }
            else if (redditoImponibile > 28000)
            {
                aliquota = 35;
            }
            else if (redditoImponibile > 15000)
            {
                aliquota = 25;
            }
            else
            {
                // sotto 15K
                aliquota = 23;
            }

            double tasse = redditoImponibile*(double)aliquota/100.0;
            Console.WriteLine($"Le tasse da pagare sono {tasse}");

            Console.WriteLine($"Il reddito imponibile netto è {redditoImponibile - tasse}");
        }
    }
}
