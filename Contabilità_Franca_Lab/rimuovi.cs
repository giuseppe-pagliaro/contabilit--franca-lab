using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Windows.Forms;

namespace Contabilità_Franca_Lab
{
    public partial class rimuovi : Form
    {
        string[] nomi_directory;

        public rimuovi()
        {
            InitializeComponent();
        }

        //Carica tutti gli ordini nella lista.

        private void rimuovi_Load(object sender, EventArgs e)
        {
            nomi_directory = Directory.GetFiles("franca_lab_files/.nuovo/");

            foreach (string filename in nomi_directory)
                lista_ordini.Items.Add(Path.GetFileName(filename.Remove(filename.Length - 4)));
        }

        private void rimuovi_fine_Click(object sender, EventArgs e)
        {
            //Controlla che vi sia almeno un ordine selezionato.

            if (lista_ordini.SelectedIndex != -1)
            {
                //Elimina tutti gli ordini selezionati.

                foreach (string filename in lista_ordini.CheckedItems)
                {
                    File.Delete("franca_lab_files/.nuovo/" + filename + ".txt");
                }

                //Salva i nomi degli ordini rimasti.

                nomi_directory = Directory.GetFiles("franca_lab_files/.nuovo/");

                int i = 1;
                string tmp;

                //Riordina gli ordini rimasti.

                foreach (string filename in nomi_directory)
                {
                    tmp = i.ToString();
                    FileSystem.Rename(filename, filename.Replace(filename[24], tmp[0]));
                    i++;
                }
                //Chiude il form ad operazione conclusa. 

                this.Close();
            }
            else MessageBox.Show("Seleziona almeno un ordine.");
        }
    }
}