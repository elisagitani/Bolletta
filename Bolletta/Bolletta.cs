using System;
using System.Collections.Generic;
using System.Text;

namespace Bolletta
{
    public class Bolletta
    {
        public double Kwh { get; set; }

        public Utente Utente { get; set; }

        public decimal Conto { get; set; }

        const decimal quotaFissa= 40;
        public Bolletta()
        {
            Utente = new Utente();
        }

        public Bolletta(double kwh)
        {
            Kwh = kwh;
            
        }

        public string StampaDati()
        {
            return $"Nome: {Utente.Nome} \nCognome: {Utente.Cognome} \nkwh consumate:{Kwh}, \nTotale da pagare: {Conto} euro";
        }

        public decimal CalcoloBolletta()
        {
            Conto= quotaFissa + (decimal)(Kwh * 10);
            return Conto;
        }
       
    }
}
