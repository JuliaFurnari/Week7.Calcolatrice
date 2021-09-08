using System;
using Week7.Calcolatrice.Core;


namespace Week7.Calcolatrice
{
    class Program
    {
        private static CalcolatriceClass calcolatrice = new CalcolatriceClass();
        static void Main(string[] args)
        {
           
            bool continua = true;
            while (continua)
            {
                int scelta = SchermoMenu();
                continua = AnalizzaScelta(scelta);
            }
        }

        private static int SchermoMenu()
        {
            Console.WriteLine("******************Menu****************");
            Console.WriteLine("\nFunzionalità Calcolatrice");
            Console.WriteLine("1. Somma.");
            Console.WriteLine("2. Sottrazione.");
            Console.WriteLine("3. Moltiplicazione."); 
            Console.WriteLine("4. Divisione.");
            Console.WriteLine("5. Maggiore tra due numeri.");


            //Exit
            Console.WriteLine("\n0. Exit");
            Console.WriteLine("********************************************");
            int scelta;
            Console.Write("Inserisci scelta: ");
            while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 0 || scelta > 5)
            {
                Console.Write("\nScelta errata. Inserisci scelta corretta: ");
            }
            return scelta;

        }
        private static bool AnalizzaScelta(int scelta)
        {
            switch (scelta)
            {
                case 1:
                    Somma();
                    break;
                case 2:
                    Sottrazione();
                    break;
                case 3:
                    Moltiplicazione();
                    break;
                case 4:
                    Divisione();
                    break;
                case 5:
                    MaggioreDueNumeri();
                    break;
                case 0:
                    return false;
            }
            return true;
        }

        private static void MaggioreDueNumeri()
        {
            double a = InserisciNumero();
            double b = InserisciNumero();
            if (calcolatrice.VerificaSeAMaggioreDiB(a, b))
            {
                Console.WriteLine($"Il maggiore tra {a} e {b} è: {a}");
            }
            else Console.WriteLine($"Il maggiore tra {a} e {b} è: {b}");
        }

        private static void Divisione()
        {
            double a = InserisciNumero();
            double b = InserisciNumero();
            if (calcolatrice.RisolviDivisione(a, b) != null)
            {
                Console.WriteLine($"Il risultato dell'operazione di somma tra {a} e {b} è: {calcolatrice.RisolviDivisione(a, b)}");
            }
            else Console.WriteLine("Impossibile dividere per 0.");
            
        }

        private static void Moltiplicazione()
        {
            double a = InserisciNumero();
            double b = InserisciNumero();
            Console.WriteLine($"Il risultato dell'operazione di moltiplicazione tra {a} e {b} è: {calcolatrice.RisolviMoltiplicazione(a, b)}");
        }

        private static void Sottrazione()
        {
            double a = InserisciNumero();
            double b = InserisciNumero();
            Console.WriteLine($"Il risultato dell'operazione di sottrazione tra {a} e {b} è: {calcolatrice.RisolviSottrazione(a, b)}");
        }
        
        internal static void Somma()
        {
            double a =InserisciNumero();
            double b = InserisciNumero();
            Console.WriteLine($"Il risultato dell'operazione di somma tra {a} e {b} è: {calcolatrice.RisolviSomma(a,b)}");
        }

        private static double InserisciNumero()
        {
            Console.WriteLine("Inserisci un numero:");
            double a;
            while(!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Errore. Inserisci un numero reale.");
            }
            return a;
        }
    }
}
