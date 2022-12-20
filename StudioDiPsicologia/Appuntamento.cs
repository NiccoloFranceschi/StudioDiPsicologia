namespace StudioDiPsicologia
{
    public class Appuntamento
    {
        Medico _medico;
        Paziente _paziente;
        string _data;
        string _note;
        int _orario;

        public Medico medico { get { return _medico; } set { _medico = value; } }
        public Paziente paziente { get { return _paziente; } set { _paziente = value; } }
        public string data { get { return _data; } set { _data = value; } }
        public string note { get { return _note; } set { _note = value; } }
        public int orario { get { return _orario; } set { _orario = value; } }
        
        public Appuntamento(Medico medico, Paziente paziente, string data, string note, int orario)
        {
            this.medico = medico;
            this.paziente = paziente;
            this.data = data;
            this.note = note;
            this.orario = orario;
        }
        
        public Appuntamento() : this(new Medico(), new Paziente(), "", "", 0) { }
        

    }
}