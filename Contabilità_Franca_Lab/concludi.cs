using System;
using System.IO;
using System.Windows.Forms;

namespace Contabilità_Franca_Lab
{
    public partial class concludi : Form
    {
        public concludi()
        {
            InitializeComponent();
        }

        private void concludi_Load(object sender, EventArgs e)
        {
            //Carica l'anno corrente nel giusto label.

            anno.Value = DateTime.Now.Year;
        }

        private void concludi_fine_Click(object sender, EventArgs e)
        {
            //Controlla che vi sia un mese selezionato.

            if (mese.Text != "")
            {
                //Controlla che il mese non sia già salvato.

                if (!Directory.Exists("franca_lab_files/" + mese.Text + " (" + anno.Value + ")"))
                {
                    //Salva i nomi di tutti i file degli ordini.

                    string[] nomi_directory = Directory.GetFiles("franca_lab_files/.nuovo/");

                    //Controlla che non vi sia nessun ordine.

                    if (nomi_directory.Length != 0)
                    {
                        //Crea la directory del mese selezionato.

                        Directory.CreateDirectory("franca_lab_files/" + mese.Text + " (" + anno.Value + ")");

                        //Sposta gli ordini nella cartella appena creata.

                        foreach (string filenames in nomi_directory)
                        {
                            File.Move(filenames, "franca_lab_files/" + mese.Text + " (" + anno.Value + ")" + "/" + Path.GetFileName(filenames));
                        }

                        //Avvisa che l'operazione è conclusa.

                        MessageBox.Show("Mese concluso!");

                        //Chiude il form ad operazione conclusa.

                        this.Close();
                    }
                    else MessageBox.Show("Nessun ordine da concludere.");
                }
                else MessageBox.Show("Mese già concluso.");
            }
            else MessageBox.Show("Seleziona un mese.");
        }
    }
}