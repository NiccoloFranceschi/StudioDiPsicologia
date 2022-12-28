using System.IO;
using System.Windows.Forms;

namespace StudioDiPsicologia
{
    public class Appuntamento
    {
        Medico _medico;
        Paziente _paziente;
        string _data;
        string _note;
        int _orario;
        bool _completato;
        int _id;

        public Medico medico { get { return _medico; } set { _medico = value; } }
        public Paziente paziente { get { return _paziente; } set { _paziente = value; } }
        public string data { get { return _data; } set { _data = value; } }
        public string note { get { return _note; } set { _note = value; } }
        public int orario { get { return _orario; } set { _orario = value; } }
        public bool completato { get { return _completato; } set { _completato = value; } }
        public int id { get { return _id; } set { _id = value; } }
        
        
        public Appuntamento(Medico medico, Paziente paziente, string data, string note, int orario, bool completato, int id)
        {
            this.medico = medico;
            this.paziente = paziente;
            this.data = data;
            this.note = note;
            this.orario = orario;
            this.completato = completato;
            this.id = id;
        }
        
        public Appuntamento() : this(new Medico(), new Paziente(), "", "", 0, false, -1) { }

        public void salvaAppuntamento()
        {
            FileStream fs = new FileStream("Appuntamenti.bin", FileMode.OpenOrCreate);
            BinaryWriter bw = new BinaryWriter(fs);

            fs.Seek(0, SeekOrigin.End);
            
            bw.Write(formattaStringa(medico.nome));     // 20 + 1 byte
            bw.Write(medico.medicoID);                  // 4 byte
            bw.Write(formattaStringa(paziente.nome));   // 20 + 1 byte
            bw.Write(id);                               // 4 byte
            bw.Write(completato);                       // 1 byte
            bw.Write(data);                             // 20 + 1 byte
            bw.Write(formattaStringa(note));            // 20 + 1 byte
            bw.Write(orario);                           // 4 byte
            fs.Close();                                 // byte totali: 109
        }
        
        private string formattaStringa(string stringa)
        {
            if (stringa.Length > 20)
                stringa  = stringa.Substring(0, 20);
            else if (stringa.Length < 20)
                stringa = stringa.PadRight(20);
            return stringa;
        }
    }
}