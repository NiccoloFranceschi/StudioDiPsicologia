using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioDiPsicologia
{
    public class Medico
    {
        string _nome;
        string _cognome;
        string _specializzazione;
        bool _inLavoro;
        int _orarioInizio;
        int _orarioFine;
        int _medicoID;

        // Nome e cognome
        public string nome { get { return _nome; } set { _nome = value; } }
        public string cognome { get { return _cognome; } set { _cognome = value; } }

        // Specializzazione e Lavoro
        public string specializzazione { get { return _specializzazione; } set { _specializzazione = value; } }
        public bool inLavoro { get { return _inLavoro; } set { _inLavoro = value; } }
        
        // ID del medico
        public int medicoID { get { return _medicoID; } set { _medicoID = value; } } 

        // Orario Lavoro
        public int orarioInizio { get { return _orarioInizio; } set { _orarioInizio = value; } }
        public int orarioFine { get { return _orarioFine; } set { _orarioFine = value; } }


        // Costruttori
        public Medico(string nome, string cognome, string specializzazione, bool inLavoro, int medicoID, int orarioInizio, int orarioFine )
        {
            this.nome = nome;
            this.cognome = cognome;
            this.specializzazione = specializzazione;
            this.medicoID = medicoID;
            this.inLavoro = inLavoro;
            this.orarioInizio = orarioInizio;
            this.orarioFine = orarioFine;
        }
        public Medico() : this("Pietro", "Roberto", "Robertare", true, -1, 8, 9) { }

        // Salvo il medico in un file binario
        public void salvaMedico()
        {
            FileStream fs = new FileStream("Medici.bin", FileMode.OpenOrCreate);
            BinaryWriter bw = new BinaryWriter(fs);
        
            fs.Seek(0, SeekOrigin.End);
            
            bw.Write(formattaStringa(nome));                // 20 + 1
            bw.Write(formattaStringa(cognome));             // 20 + 1
            bw.Write(formattaStringa(specializzazione));    // 20 + 1
            bw.Write(medicoID);                             // 4
            bw.Write(inLavoro);                             // 1 
            bw.Write(orarioInizio);                         // 4
            bw.Write(orarioFine);                           // 4
            bw.Close();                                     // 76 byte per ogni medico
        }
        
        // Override del metodo ToString
        public override string ToString()
        {
            return $"{medicoID}";
        }
        
        private string formattaStringa(string stringa)
        {
            if (stringa.Length > 20)
                stringa  = stringa.Substring(0, 20);
            else if (stringa.Length < 20)
                stringa = stringa.PadRight(20);
            return stringa;
        }
        
        private string formattaNumero(int numero)
        {
            if (numero < 10)
                return $"{0}{numero}";
            return numero.ToString();
        }
        
    }
}
