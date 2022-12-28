using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudioDiPsicologia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // Franceschi Niccolò
        // Non sono riuscito a fare bene la grafca perchè mi si rompeva tutta quanta
        
        // Avvio del programma
        private void Form1_Load(object sender, EventArgs e)
        {
            pbOrario.ForeColor = Color.White;
            caricaPazienti(lbxPazienti, cmbPaziente);
            caricaMedici(lbxMedici, cmbMedico);
            caricaAppuntamenti(lbxAppuntamenti);
        }
        
        // --- Liste ---
        List<Medico> Medici = new List<Medico>();
        List<Paziente> Pazienti = new List<Paziente>();
        List<Appuntamento> Appuntamenti = new List<Appuntamento>();
        
        // --- Orario Studio ---
        int orarioApertura = 8;
        int orarioChiusura = 20;
        
        
        //  --- Orologio ---
        // Event tick per l'orologio nella home
        private void Orologio_Tick(object sender, EventArgs e)
        {
            DateTime orologino = DateTime.Now;
            lblData.Text = $"{ orologino.DayOfWeek }, { orologino.Day } { calcolaMese(orologino) }";
            lblOra.Text = $"{ orologino.Hour } : { orologino.Minute}";
            pbOrario.Value = orologino.Hour;
        }

        // Funzione per avere il nome del mese
        private string calcolaMese(DateTime orologio)
        {
            switch (orologio.Month)
            {
                case 1:
                    return "January";
                    break;
                case 2:
                    return "February";
                    break;
                case 3:
                    return "March";
                    break;
                case 4:
                    return "April";
                    break;
                case 5:
                    return "May";
                    break;
                case 6:
                    return "June";
                    break;
                case 7:
                    return "July";
                    break;
                case 8:
                    return "August";
                    break;
                case 9:
                    return "September";
                    break;
                case 10:
                    return "October";
                    break;
                case 11:
                    return "November";
                    break;
                case 12:
                    return "December";
                    break;
                default:
                    break;
            }
            return null;
        }


        // --- Controlli TextBox ---
        // Funzioni per controllare se sono state inserite solo lettere
        private void txtNomePaziente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
        }
        private void txtCognomePaziente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
        }
        private void txtIbanPaziente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
        }
        private void txtNomeMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
        }
        private void txtCognomeMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
        }
        private void txtSpecializzazioneMedico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
        }
        private void txtMedicoID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }


        // --- Paziente ---
        // Funzione per aggiungere il paziente
        public void AggiungiPaziente()
        {
            Paziente pazientino = new Paziente();
            
            // Data di nascita
            DateTime dataNascita = dtpPaziente.Value;
            int giornoDiNascita = dataNascita.Date.Day;
            int meseDiNascita = dataNascita.Date.Month; 
            int annoDiNascita = dataNascita.Date.Year; 

            if (txtNomePaziente.Text == "" || txtCognomePaziente.Text == "" || txtIbanPaziente.Text == "") // Controllo che non ci siano oggetti vuoti
            {
                MessageBox.Show("Non hai inserito tutti i dati", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pazientino.nome = txtNomePaziente.Text;
                pazientino.cognome = txtCognomePaziente.Text;
                pazientino.giornoDiNascita = giornoDiNascita;
                pazientino.meseDiNascita = meseDiNascita;
                pazientino.annoDiNascita = annoDiNascita;

                if (txtIbanPaziente.Text.Length != 27) // Controllo che l'IBAN sia di 27 caratteri
                {
                    MessageBox.Show("L'IBAN non è valido", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pazientino.IBAN = txtIbanPaziente.Text.ToUpper();
                    
                    Pazienti.Add(pazientino);
                    svuotaPaziente(txtNomePaziente, txtCognomePaziente, txtIbanPaziente, dtpPaziente);
                    pazientino.SalvaPaziente();
                    caricaPazienti(lbxPazienti, cmbPaziente);
                }
            }
            
        }
        
        // Funzione per rimuovere il paziente
        public void RimuoviPaziente(ListBox lbx)
        {
            if (lbx.SelectedIndex == -1)
            {
                MessageBox.Show("Non hai selezionato nessun paziente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Pazienti.RemoveAt(lbx.SelectedIndex);
                caricaPazienti(lbxPazienti, cmbPaziente);
            }
        }

        // Pulsante Aggiungi Paziente
        private void btnAggiungiPaziente_Click(object sender, EventArgs e)
        {
            if (!esistePaziente())
            {
                AggiungiPaziente();
            }
            else
            {
                MessageBox.Show("Il paziente è già presente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        // Pulsante Rimuoovi Paziente
        private void btnRimuoviPaziente_Click(object sender, EventArgs e)
        {
            // Controllo se è stato selezionato un paziente
            if (lbxPazienti.SelectedIndex == -1)
            {
                MessageBox.Show("Non hai selezionato nessun paziente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RimuoviPaziente(lbxPazienti);
            }
        }
        
        private bool esistePaziente()
        {
            for (int i = 0; i < Pazienti.Count; i++)
            {
                if (Pazienti[i].IBAN == txtIbanPaziente.Text)
                {
                    return true;
                }
            }
            return false;
        }
        
        // 111111111111111111111111111 - Test IBAN

        // --- Medico ---
        // Funzione per aggiungere il Medico
        public void AggiungiMedico(NumericUpDown nud, NumericUpDown nud1)
        {
            Medico medichetto = new Medico();
            
            if (txtNomeMedico.Text == "" || txtCognomeMedico.Text == "" || txtSpecializzazioneMedico.Text == "" || txtIDMedico.Text == "")
            {
                MessageBox.Show("Non hai inserito tutti i dati", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (esisteID(Convert.ToInt32(txtIDMedico.Text)))
            {
                MessageBox.Show("Il medico è già presente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDMedico.Text = "";
                return;
            }
            else
            {
                if (nud.Value < orarioApertura || nud1.Value > orarioChiusura)
                {
                    MessageBox.Show("Gli orari inseriti non sono validi", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    medichetto.nome = txtNomeMedico.Text;
                    medichetto.cognome = txtCognomeMedico.Text;
                    medichetto.specializzazione = txtSpecializzazioneMedico.Text;
                    medichetto.inLavoro = true;
                    medichetto.medicoID = Convert.ToInt32(txtIDMedico.Text);
                    
                    
                    if (nud1.Value > nud.Value) // Controllo se gli orari sono invertiti e li salvo al contrario
                    {
                        medichetto.orarioInizio = Convert.ToInt32(nud.Value);
                        medichetto.orarioFine = Convert.ToInt32(nud1.Value);
                        
                        Medici.Add(medichetto);
                        svuotaMedico(txtNomeMedico, txtCognomeMedico, txtSpecializzazioneMedico, txtIDMedico, nInizioMedico, nFineMedico);
                        medichetto.salvaMedico();
                        caricaMedici(lbxMedici, cmbMedico);
                    }
                    else
                    {
                        medichetto.orarioInizio = Convert.ToInt32(nud1.Value);
                        medichetto.orarioFine = Convert.ToInt32(nud.Value);
                        
                        Medici.Add(medichetto);
                        svuotaMedico(txtNomeMedico, txtCognomeMedico, txtSpecializzazioneMedico, txtIDMedico, nInizioMedico, nFineMedico);
                        medichetto.salvaMedico();
                        caricaMedici(lbxMedici, cmbMedico);
                    }
                }
            }
        }

        // Pulsante Aggiungi Medico
        private void btnAggiungiMedico_Click(object sender, EventArgs e)
        {
            if (!esisteMedico())
            {
                AggiungiMedico(nInizioMedico, nFineMedico);
            }
            else
            {
                MessageBox.Show("Il medico è già presente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        // Funzione per rimuovere un medico
        public void RimuoviMedico(ListBox lbx)
        {
            bool Lavoro = false;

            if (lbx.SelectedIndex == -1)
            {
                MessageBox.Show("Non hai selezionato nessun paziente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FileStream fs = new FileStream("Medici.bin", FileMode.OpenOrCreate);
                BinaryWriter bw = new BinaryWriter(fs);
                BinaryReader br = new BinaryReader(fs);

                while (fs.Position < fs.Length)
                {
                    fs.Seek(63, SeekOrigin.Current);
                    int ID = br.ReadInt32();
                    fs.Seek(9, SeekOrigin.Current);
                    
                    if (ID == Medici[lbx.SelectedIndex].medicoID)
                    {
                        fs.Seek(-9, SeekOrigin.Current);
                        bw.Write(Lavoro);
                        fs.Close();
                        caricaMedici(lbxMedici, cmbMedico);
                        return;
                    }
                }
                fs.Close();
                return;
            }
        }

        // Pulsante Rimuovi Medico
        private void btnRimuoviMedico_Click(object sender, EventArgs e)
        {
            RimuoviMedico(lbxMedici);
        } 

        private bool esisteMedico()
        {
            for (int i = 0; i < Medici.Count; i++)
            {
                if (Medici[i].nome == txtNomeMedico.Text)
                {
                    if (Medici[i].specializzazione == txtSpecializzazioneMedico.Text)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool esisteID(int ID)
        {
            for (int i = 0; i < Medici.Count; i++)
            {
                if (Medici[i].medicoID == ID)
                {
                    return true;
                }
            }
            return false;
        }


        // --- Appuntamento ---
        // Funzione per aggiungere un appuntamento
        public void AggiungiAppuntamento()
        {
            Appuntamento appuntamentino = new Appuntamento();
            Random rnd = new Random();
            
            if (cmbMedico.SelectedIndex == -1 || cmbPaziente.SelectedIndex == -1 || nudOrario.Value == 0 || txtMotivazione.Text == "")
            {
                MessageBox.Show("Non hai inserito tutti i dati", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (nudOrario.Value < Medici[cmbMedico.SelectedIndex].orarioInizio || nudOrario.Value > Medici[cmbMedico.SelectedIndex].orarioFine)
                {
                    MessageBox.Show("Controlla l'orario inserito", "Errore", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    appuntamentino.paziente = Pazienti[cmbPaziente.SelectedIndex];
                    appuntamentino.medico = Medici[cmbMedico.SelectedIndex];
                    appuntamentino.orario = Convert.ToInt32(nudOrario.Value);
                    appuntamentino.data = dtpAppuntamento.Text;
                    appuntamentino.note = txtMotivazione.Text;
                    appuntamentino.id = Appuntamenti.Count + rnd.Next(1, 3000);
                    appuntamentino.completato = false;

                    Appuntamenti.Add(appuntamentino);
                    appuntamentino.salvaAppuntamento();
                    svuotaAppuntamento(cmbMedico, cmbPaziente, nudOrario, txtMotivazione, dtpAppuntamento);
                    caricaAppuntamenti(lbxAppuntamenti);
                }
            }
        }
        
        // Pulsante Aggiungi Appuntamento
        private void btnAggiungiAppuntamento_Click(object sender, EventArgs e)
        {
            if (!esisteAppuntamento()) // Controllo se esiste già un appuntamento
            {
                AggiungiAppuntamento();
                
            }
            else
            {
                MessageBox.Show("Esiste già un appuntamento, cambiare orario", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Funzione per rimuovere un Appuntamento
        private void rimuoviAppuntamento()
        {
            if (lbxAppuntamenti.SelectedIndex == -1)
            {
                MessageBox.Show("Non hai selezionato nessun appuntamento", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FileStream fs = new FileStream("Appuntamenti.bin", FileMode.OpenOrCreate);
                BinaryWriter bw = new BinaryWriter(fs);
                BinaryReader br = new BinaryReader(fs);

                while (fs.Position < fs.Length)
                {
                    fs.Seek(46, SeekOrigin.Current);
                    int ID = br.ReadInt32();
                    fs.Seek(47, SeekOrigin.Current);
                    
                    if (ID == Appuntamenti[lbxAppuntamenti.SelectedIndex].id)
                    {
                        fs.Seek(-47, SeekOrigin.Current);
                        bw.Write(true);
                        fs.Close();
                        caricaAppuntamenti(lbxAppuntamenti);
                        return;
                    }
                }
                fs.Close();
                return;
            }
        }
        
        // Bottone per rimuovere un appuntamento
        private void btnRimuoviAppuntamento_Click(object sender, EventArgs e)
        {
            rimuoviAppuntamento();
        }   
        
        // Funzione per controllare se un appuntamento esiste già
        private bool esisteAppuntamento()
        {
            int orario = Convert.ToInt32(nudOrario.Value);
            for (int i = 0; i < Appuntamenti.Count; i++)
            {
                if (Appuntamenti[i].data == dtpAppuntamento.Text)
                {
                    if (Appuntamenti[i].orario == orario)
                    {
                        return true;
                    }
                }
            }
                return false;
            }




        
        //  --- Funzioni Grafiche e Caricamenti ---
        public void svuotaAppuntamento(ComboBox cmb, ComboBox cmb1, NumericUpDown nud, TextBox txt, DateTimePicker dtp)
        {
            // Combobox
            cmb.SelectedIndex = -1;
            cmb1.SelectedIndex = -1;
            // NumericUpDown
            nud.Value = 0;
            // TxtBox
            txt.Text = "";
            // DateTimePicker
            dtp.Value = DateTime.Now;
        }
        public void svuotaMedico(TextBox txt, TextBox txt1, TextBox txt2, TextBox txt3, NumericUpDown nn, NumericUpDown nn1)
        {
            // TextBox
            txt.Text = "";
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            
            // NumericUpDown
            nn.Value = 0;
            nn1.Value = 0;
        }
        public void svuotaPaziente(TextBox txt, TextBox txt1, TextBox txt2, DateTimePicker dtp)
        {
            txt.Text = "";
            txt1.Text = "";
            txt2.Text = "";
            dtp.Value = DateTime.Now;
        }
        public void caricaPazienti(ListBox lst, ComboBox cmb)
        {
            // Leggo dal File Binario
            Pazienti.Clear();
            FileStream fs = new FileStream("Pazienti.bin", FileMode.OpenOrCreate);
            BinaryReader br = new BinaryReader(fs);

            while (fs.Position < fs.Length)
            {
                Paziente pazientino = new Paziente();

                pazientino.nome = br.ReadString().Trim(' ');
                pazientino.cognome = br.ReadString().Trim(' ');
                pazientino.IBAN = br.ReadString();
                pazientino.giornoDiNascita = br.ReadInt32();
                pazientino.meseDiNascita = br.ReadInt32();
                pazientino.annoDiNascita = br.ReadInt32();

                Pazienti.Add(pazientino);
            }
            fs.Close();
            
            // Carico i Pazienti in ListBox e ComboBox
            lst.Items.Clear();
            cmb.Items.Clear();
            foreach (Paziente paziente in Pazienti)
            {
                lst.Items.Add(paziente.nome + " " + paziente.cognome);
                cmb.Items.Add(paziente.nome + " " + paziente.cognome);
            }
        }
        public void caricaMedici(ListBox lst, ComboBox cmb)
        {
            // Leggo i Medici dal file binario
            Medici.Clear();
            FileStream fs = new FileStream("Medici.bin", FileMode.OpenOrCreate);
            BinaryReader br = new BinaryReader(fs);

            while (fs.Position < fs.Length)
            {
                Medico medico = new Medico();

                medico.nome = br.ReadString().Trim(' ');
                medico.cognome = br.ReadString().Trim(' ');
                medico.specializzazione = br.ReadString().Trim(' ');
                medico.medicoID = br.ReadInt32();
                medico.inLavoro = br.ReadBoolean();
                medico.orarioInizio = br.ReadInt32();
                medico.orarioFine = br.ReadInt32();

                fs.Seek(0, SeekOrigin.Current);
                Medici.Add(medico);
            }
            fs.Close();
            
            // Carico i Medici in ListBox e ComboBox
            lst.Items.Clear();
            cmb.Items.Clear();

            for (int i = 0; i < Medici.Count; i++)
            {
                if (Medici[i].inLavoro)
                {
                    lst.Items.Add(Medici[i].nome + " " + Medici[i].cognome);
                    cmb.Items.Add(Medici[i].nome + " " + Medici[i].cognome);
                }
            }
        }
        public void caricaAppuntamenti(ListBox lst)
        {
            Appuntamenti.Clear();
            FileStream fs = new FileStream("Appuntamenti.bin", FileMode.OpenOrCreate);
            BinaryReader br = new BinaryReader(fs);

            while (fs.Position < fs.Length)
            {
                Appuntamento appuntamento = new Appuntamento();

                appuntamento.medico.nome = br.ReadString().Trim(' ');
                appuntamento.medico.medicoID = br.ReadInt32();
                appuntamento.paziente.nome = br.ReadString().Trim(' ');
                appuntamento.id = br.ReadInt32();
                appuntamento.completato = br.ReadBoolean();
                appuntamento.data = br.ReadString().Trim(' ');
                appuntamento.note = br.ReadString().Trim(' ');
                appuntamento.orario = br.ReadInt32();

                fs.Seek(0, SeekOrigin.Current);
                Appuntamenti.Add(appuntamento);
            }
            fs.Close();

            lst.Items.Clear();
            foreach (Appuntamento appuntamento in Appuntamenti)
            {
                if (!appuntamento.completato)
                {
                    lst.Items.Add(appuntamento.medico.nome + " " + appuntamento.paziente.nome);
                }
            }
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            PanelPaziente.Visible = false;
            PanelMedico.Visible = false;
            PanelAppuntamento.Visible = false;
            PanelHome.Visible = true;
        }

        private void lblPazienti_Click(object sender, EventArgs e)
        {
            PanelPaziente.Visible = true;
            PanelMedico.Visible = false;
            PanelAppuntamento.Visible = false;
            PanelHome.Visible = false;
        }
        
        private void lblMedici_Click(object sender, EventArgs e)
        {
            PanelPaziente.Visible = false;
            PanelMedico.Visible = true;
            PanelAppuntamento.Visible = false;
            PanelHome.Visible = false;
        }
        

        private void lblAppuntamenti_Click(object sender, EventArgs e)
        {
            PanelPaziente.Visible = false;
            PanelMedico.Visible = false;
            PanelAppuntamento.Visible = true;
            PanelHome.Visible = false;
        }
    }
}
