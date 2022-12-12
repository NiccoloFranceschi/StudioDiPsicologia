using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioDiPsicologia
{
    internal class Medico
    {
        string nome;
        string cognome;
        string specializzazione;
        int orarioInizio;
        int orarioFine;
        bool inLavoro;

        // Nome e cognome
        public string _nome { get { return nome; } set { nome = value; } }
        public string _cognome { get { return cognome; } set { cognome = value; } }

        // Specializzazione e Lavoro
        public string _specializzazione { get { return specializzazione; } set { specializzazione = value; } }
        public bool _inLavoro { get { return inLavoro; } set { inLavoro = value; } }

        // Orario Lavoro
        public int _orarioInizio { get { return orarioInizio; } set { orarioInizio = value; } }
        public int _orarioFine { get { return orarioFine; } set { orarioFine = value; } }


        // Costruttori
        public Medico(string nome, string cognome, string specializzazione, int orarioInizio, int orarioFine, bool inLavoro)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.specializzazione = specializzazione;
            this.orarioInizio = orarioInizio;
            this.orarioFine = orarioFine;
            this.inLavoro = inLavoro;
        }
        public Medico() : this("Pietro", "Roberto", "Robertare", 0, 0, true) { }



    }
}
