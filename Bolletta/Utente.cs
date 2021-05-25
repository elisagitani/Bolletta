using System;
using System.Collections.Generic;
using System.Text;

namespace Bolletta
{
    public class Utente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public Utente(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }

        public Utente()
        {

        }
    }

    
}
