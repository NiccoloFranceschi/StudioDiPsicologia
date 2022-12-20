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
        }


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

        // Funzione per controllare se sono state inserite solo lettere
        private bool controllaLettere(string testo)
        {
            if (testo.All(char.IsLetter))
            {
                return true;
            }
            else
            {
                return false;
            }    
        }

        // Funzione per aggiungere il paziente
        public void AggiungiPaziente()
        {
            Paziente = new Paziente();
            int giornoDiNascita = Convert.ToInt32(nudGiornoNascita.Value); // prende il valore del giorno di nascita
            int meseDiNascita = Convert.ToInt32(nudMeseNascita.Value); // prende il valore del mese di nascita
            int annoDiNascita = Convert.ToInt32(nudAnnoNascita.Value); // prende il valore dell'anno di nascita

            if (txtNomePaziente.Text == "" || txtCognomePaziente.Text == "" || txtIbanPaziente.Text == "")
            {
                MessageBox.Show("Non hai inserito tutti i dati", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (controllaLettere(txtNomePaziente.Text) && controllaLettere(txtCognomePaziente.Text))
                {
                    paziente._nome = txtNomePaziente.Text;
                    paziente._cognome = txtCognomePaziente.Text;
                    paziente._giornoNascita = giornoDiNascita;
                    paziente._meseNascita = meseDiNascita;
                    paziente._annoNascita = annoDiNascita;

                    // verifica che l'iban sia di 27 caratteri
                    if (txtIbanPaziente.Text.Length != 27)
                    return false;

                    paziente._IBAN = txtIbanPaziente.Text.ToUpper();

                    return true;
                }
                else
                {
                    MessageBox.Show("Nome e cognome devono essere composti solo da lettere", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }





    }
}
