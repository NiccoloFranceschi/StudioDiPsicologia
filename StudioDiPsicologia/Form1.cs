using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            pbOrario.ForeColor = Color.White;
            caricaPazienti(lbxPazienti, cmbPaziente);
            caricaMedici(lbxMedici, cmbMedico);
            caricaListBoxAppuntamenti(lbxAppuntamenti);
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


        // --- Paziente ---
        // Funzione per aggiungere il paziente
        public void AggiungiPaziente()
        {
            Paziente pazientino = new Paziente();
            int giornoDiNascita = 12; // prende il valore del giorno di nascita
            int meseDiNascita = 3; // prende il valore del mese di nascita
            int annoDiNascita = 2; // prende il valore dell'anno di nascita

            if (txtNomePaziente.Text == "" || txtCognomePaziente.Text == "" || txtIbanPaziente.Text == "")
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

                // verifica che l'iban sia di 27 caratteri
                if (txtIbanPaziente.Text.Length != 27)
                {
                    MessageBox.Show("L'IBAN non è valido", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pazientino.IBAN = txtIbanPaziente.Text.ToUpper();
                    
                    Pazienti.Add(pazientino);
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
            AggiungiPaziente();
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
        
        // 111111111111111111111111111 - Test IBAN

        // --- Medico ---
        // Funzione per aggiungere il Medico
        public void AggiungiMedico()
        {
            Medico medichetto = new Medico();

            if (txtNomeMedico.Text == "" || txtCognomeMedico.Text == "" || txtSpecializzazioneMedico.Text == "")
            {
                MessageBox.Show("Non hai inserito tutti i dati", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                medichetto.nome = txtNomeMedico.Text;
                medichetto.cognome = txtCognomeMedico.Text;
                medichetto.specializzazione = txtSpecializzazioneMedico.Text;
                medichetto.orarioInizio = Convert.ToInt32(nInizioMedico.Value);
                medichetto.orarioFine = Convert.ToInt32(nFineMedico.Value);
                
                Medici.Add(medichetto);
                caricaMedici(lbxMedici, cmbMedico);
            }
        }

        // Pulsante Aggiungi Medico
        private void btnAggiungiMedico_Click(object sender, EventArgs e)
        {
            AggiungiMedico();
        }
        
        // Funzione per rimuovere un medico
        public void RimuoviMedico(ListBox lbx)
        {
            if (lbx.SelectedIndex == -1)
            {
                MessageBox.Show("Non hai selezionato nessun paziente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Medici.RemoveAt(lbx.SelectedIndex);
                caricaMedici(lbxMedici, cmbMedico);
            }
        }

        // Pulsante Rimuovi Medico
        private void btnRimuoviMedico_Click(object sender, EventArgs e)
        {
            RimuoviMedico(lbxMedici);
        } 

        
        // --- Appuntamento ---
        // Funzione per aggiungere un appuntamento
        public void AggiungiAppuntamento()
        {
            // devo aggiungere un appuntamento controllando paziente e medico selezionati
            Appuntamento appuntamentino = new Appuntamento();
            
            appuntamentino.paziente = Pazienti[cmbPaziente.SelectedIndex];
            appuntamentino.medico = Medici[cmbMedico.SelectedIndex];
            
            Appuntamenti.Add(appuntamentino);
            svuotaAppuntamento(cmbMedico, cmbPaziente, nudOrario, txtMotivazione, dtpAppuntamento);
            caricaListBoxAppuntamenti(lbxAppuntamenti);
        }
        
        
        // Pulsante Aggiungi Appuntamento
        private void btnAggiungiAppuntamento_Click(object sender, EventArgs e)
        {
            AggiungiAppuntamento();
        }


        
        
        
        
        
        
        public void svuotaAppuntamento(ComboBox cmb, ComboBox cmb1, NumericUpDown nn, TextBox txt, DateTimePicker dtp)
        {
            cmb.SelectedIndex = -1;
            cmb1.SelectedIndex = -1;
            nn.Value = 0;
            txt.Text = "";
            dtp.Value = DateTime.Now;
        }
        public void svuotaMedico(ComboBox cmb, ComboBox cmb1, NumericUpDown nn, NumericUpDown nn1, TextBox txt)
        {
            // Combobox
            cmb.SelectedIndex = -1;
            cmb1.SelectedIndex = -1;
            
            // NumericUpDown
            nn.Value = 0;
            nn1.Value = 0;
            
            // TextBox
            txt.Text = "";
        }

        public void caricaPazienti(ListBox lst, ComboBox cmb)
        {
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
            lst.Items.Clear();
            cmb.Items.Clear();
            foreach (Medico medico in Medici)
            {
                lst.Items.Add(medico.nome + " " + medico.cognome);
                cmb.Items.Add(medico.nome + " " + medico.cognome);
            }
        }
        
        public void caricaListBoxAppuntamenti(ListBox lst)
        {
            lst.Items.Clear();
            foreach (Appuntamento appuntamento in Appuntamenti)
            {
                lst.Items.Add(appuntamento.medico.nome + " " + appuntamento.paziente.nome);
            }
        }

    }
}
