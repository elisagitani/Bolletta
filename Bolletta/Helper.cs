using System;
using System.Collections.Generic;
using System.Text;

namespace Bolletta
{
    public static class Helper
    {
        public static Bolletta CreaBolletta()
        {
            Console.WriteLine("Inserisci il tuo nome:");
            string n = Console.ReadLine();
            Console.WriteLine("Inserisci il tuo cognome:");
            string c = Console.ReadLine();
            double k;
            do
            {
                Console.WriteLine("Inserisci le kwh consumate:");
            }while((!double.TryParse(Console.ReadLine(), out k)));

            Utente user = new Utente(n, c);
            Bolletta bolletta = new Bolletta(k);
            bolletta.Utente = user;
            return bolletta;

        }
    }
}
