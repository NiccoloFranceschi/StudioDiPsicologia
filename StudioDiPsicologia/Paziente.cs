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
        string nome;
        string cognome;
        int giornoDiNascita;
        int meseDiNascita;
        int annoDiNascita;
        string IBAN;

        // Nome e cognome
        public string _nome { get { return nome; } set { nome = value; } }
        public string _cognome { get { return cognome; } set { cognome = value; } }

        // Data di Nascita
        public int _giornoDiNascita { get { return giornoDiNascita; } set { giornoDiNascita = value; } }
        public int _meseDiNascitaa { get { return meseDiNascita; } set { meseDiNascita = value; } }
        public int _annoDiNascita { get { return annoDiNascita; } set { annoDiNascita = value; } }

        // IBAN
        public string _IBAN { get { return IBAN; } set { IBAN = value; } }


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
            
            bw.Write(nome);
            bw.Write(cognome);
            bw.Write(giornoDiNascita);
            bw.Write(meseDiNascita);
            bw.Write(annoDiNascita);
            bw.Write(IBAN);
            fs.Close();
        }

        // Override del metodo ToString
        public override string ToString()
        {
            return $"{nome}, {cognome}, {giornoDiNascita}, {IBAN}";
        }

    }
}
