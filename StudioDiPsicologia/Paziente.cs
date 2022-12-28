using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudioDiPsicologia
{
    public class Paziente
    {
        string _nome;
        string _cognome;
        int _giornoDiNascita;
        int _meseDiNascita;
        int _annoDiNascita;
        string _IBAN;

        // Nome e cognome
        public string nome { get { return _nome; } set { _nome = value; } }
        public string cognome { get { return _cognome; } set { _cognome = value; } }

        // Data di Nascita
        public int giornoDiNascita { get { return _giornoDiNascita; } set { _giornoDiNascita = value; } }
        public int meseDiNascita { get { return _meseDiNascita; } set { _meseDiNascita = value; } }
        public int annoDiNascita { get { return _annoDiNascita; } set { _annoDiNascita = value; } }

        // IBAN
        public string IBAN { get { return _IBAN; } set { _IBAN = value; } }


        // Costruttori
        public Paziente(string nome, string cognome, int giornoDiNascita, int meseDiNascita, int annoDiNascita, string IBAN)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.giornoDiNascita = giornoDiNascita;
            this.meseDiNascita = meseDiNascita;
            this.annoDiNascita = annoDiNascita;
            this.IBAN = IBAN;
        }
        public Paziente():this("Roberto", "Paziente", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year, "0X020202") { }

        // Salvo i pazienti in un file binario
        public void SalvaPaziente()
        {
            FileStream fs = new FileStream("Pazienti.bin", FileMode.OpenOrCreate);
            BinaryWriter bw = new BinaryWriter(fs);
            
            fs.Seek(0, SeekOrigin.End);
            
            bw.Write(formattaStringa(nome));        // 20 + 1
            bw.Write(formattaStringa(cognome));     // 20 + 1
            bw.Write(IBAN);                         // 27 + 1
            bw.Write(giornoDiNascita);              // 4
            bw.Write(meseDiNascita);                // 4
            bw.Write(annoDiNascita);                // 4
            fs.Close();
        }

        // Override del metodo ToString
        public override string ToString()
        {
            return $"{nome}, {cognome}, {giornoDiNascita}, {IBAN}";
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
