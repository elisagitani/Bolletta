using System;

namespace Bolletta
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int scelta = 0;
           
            Bolletta b = new Bolletta();
            do
            {
                do
                {
                    Console.WriteLine("Menù");
                    Console.WriteLine("Premi 1 per inserire dati: Nome, Cognome, kWh");
                    Console.WriteLine("Premi 2 per richiedere il calcolo della bolletta");
                    Console.WriteLine("Premi 3 per stampare tutti i dati");
                    Console.WriteLine("Premi 0 per uscire");
                    
                } while (!(int.TryParse(Console.ReadLine(), out scelta)) && scelta >= 0 && scelta <= 3);


                switch (scelta)
                {
                    case 1:
                        b = Helper.CreaBolletta();
                        Console.WriteLine("\n");
                        break;

                    case 2:
                        b.CalcoloBolletta();
                        Console.WriteLine("Importo bolletta calcolato!");
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        Console.WriteLine(b.StampaDati());
                        Console.WriteLine("\n");
                        break;
                    case 0:
                        return;

                }
            } while (true);
        }




        private static void CalcoloBolletta(double kwh, decimal quotaFissa, out decimal bolletta)
        {

            bolletta = quotaFissa + (decimal)(kwh * 10);

        }


        private static void InserisciDati(out string nome, out string cognome, out double kwh)
        {
            Console.WriteLine("Inserisci nome");
            nome = Console.ReadLine();
            Console.WriteLine("Inserisci cognome");
            cognome = Console.ReadLine();
            do
            {
                Console.WriteLine("Inserisci kwh");

            } while (!(double.TryParse(Console.ReadLine(), out kwh)));
        }



        private static void StampaDati(string nome, string cognome, decimal bolletta)
        {
            Console.WriteLine($"Cliente: {nome} {cognome} Importo bolletta: {bolletta} euro");
        }

    }
}

