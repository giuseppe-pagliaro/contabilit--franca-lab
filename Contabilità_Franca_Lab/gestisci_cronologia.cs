using System;
using System.IO;
using System.Windows.Forms;

namespace Contabilità_Franca_Lab
{
    public partial class gestisci_cronologia : Form
    {
        int cont;

        public gestisci_cronologia()
        {
            InitializeComponent();
        }

        private void gestisci_cronologia_Load(object sender, EventArgs e)
        {
            //Salva i nomi di tutti i mesi.

            string[] mesi_salvati = Directory.GetDirectories("franca_lab_files/");

            cont = 0;

            //Conta i mesi.

            foreach (string filename in mesi_salvati)
                cont++;

            //Pulisci la lista.

            cronologia_lista.Items.Clear();

            //Carica i file in lista.

            for (int k = 1; k < cont; k++)
                cronologia_lista.Items.Add(Path.GetFileName(mesi_salvati[k]));
        }

        private void seleziona_tutto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Controlla che la lista non sia vuota.

            if (cronologia_lista.Items.Count != 0)
            {
                cronologia_lista.SelectedIndex = 0;

                //Seleziona tutti i file.

                for (int k = 0; k < cont - 1; k++)
                    cronologia_lista.SetItemChecked(k, true);
            }
            else MessageBox.Show("Nulla da selezionare.");
        }

        private void deseleziona_tutto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Controlla che la lista non sia vuota.

            if (cronologia_lista.Items.Count != 0)
            {
                cronologia_lista.SelectedIndex = 0;

                //Deseleziona tutti i file.

                for (int k = 0; k < cont - 1; k++)
                    cronologia_lista.SetItemChecked(k, false);
            }
            else MessageBox.Show("Nulla da deselezionare.");
        }

        private void gestisci_fine_Click(object sender, EventArgs e)
        {
            //Controlla che ci sia almeno un mese selezionato.

            if (cronologia_lista.SelectedIndex != -1)
            {
                //Elimina tutti i mesi selezionati.

                foreach (string filename in cronologia_lista.CheckedItems)
                {
                    Directory.Delete("franca_lab_files/" + filename, true);
                }

                //Chiude il form ad operazione conclusa.

                this.Close();
            }
            else MessageBox.Show("Seleziona almeno un mese.");
        }
    }
}