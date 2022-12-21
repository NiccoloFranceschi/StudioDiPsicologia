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
        int _orarioInizio;
        int _orarioFine;
        bool _inLavoro;

        // Nome e cognome
        public string nome { get { return _nome; } set { _nome = value; } }
        public string cognome { get { return _cognome; } set { _cognome = value; } }

        // Specializzazione e Lavoro
        public string specializzazione { get { return _specializzazione; } set { _specializzazione = value; } }
        public bool inLavoro { get { return _inLavoro; } set { _inLavoro = value; } }

        // Orario Lavoro
        public int orarioInizio { get { return _orarioInizio; } set { _orarioInizio = value; } }
        public int orarioFine { get { return _orarioFine; } set { _orarioFine = value; } }


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

        // Salvo il medico in un file binario
        public void salvaMedico()
        {
            FileStream fs = new FileStream("Medici.bin", FileMode.OpenOrCreate);
            BinaryWriter bw = new BinaryWriter(fs);
        
            fs.Seek(0, SeekOrigin.End);
            
            bw.Write(nome);
            bw.Write(cognome);
            bw.Write(specializzazione);
            bw.Write(orarioInizio);
            bw.Write(orarioFine);
            bw.Write(inLavoro);
            bw.Close();
            
        }
        
        // Override del metodo ToString
        public override string ToString()
        {
            return $"{nome}, {cognome}, {specializzazione}, {orarioInizio}, {orarioFine}";
        }
        
        public int getLunghezza()
        {
            return 72;
        }
        
    }
}
