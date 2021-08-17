using System;
using System.IO;
using System.Windows.Forms;

namespace Contabilità_Franca_Lab
{
    public partial class aggiungi : Form
    {
        //Corregge la formattazione di un numero (se necessario).

        string Aggiungi_Zero(string Valore)
        {
            int cont, posizione;

            //Controlla se numero è uguale a "0" o intero.

            if (Valore != "0" && Convert.ToDouble(Valore) % 1 != 0)
            {
                //Conta all'indietro in che posizione si trova la virgola.

                cont = Valore.Length - 1;

                while (Valore[cont] != ',')
                    cont--;

                //Ottiene la posizione della virgola.

                posizione = Valore.Length - cont;

                //Aggiunge "0" (se necessario).

                if (posizione == 2)
                    return Valore += "0";
                else return Valore;
            }
            //Aggiunge ",00" se numero intero.

            else if (Convert.ToDouble(Valore) % 1 == 0)
                return Valore += ",00";
            else return Valore;
        }

        public aggiungi()
        {
            InitializeComponent();
        }

        private void aggiungi_fine_Click(object sender, EventArgs e)
        {
            try
            {
                //Controlla che non vi siano campi vuoti.

                if (nome_cognome.Text != "" && prezzo_gioiello.Text != "" && costo_materiali.Text != "" && costo_pubblicità.Text != "" && costo_spedizione.Text != "" && tasse_vari.Text != "")
                {
                    //Controlla che i numeri decimali siano formattati correttamente.

                    if (prezzo_gioiello.Text.IndexOf('.') == -1 && costo_materiali.Text.IndexOf('.') == -1 && costo_pubblicità.Text.IndexOf('.') == -1 && costo_spedizione.Text.IndexOf('.') == -1 && tasse_vari.Text.IndexOf('.') == -1)
                    {
                        //Conta i file degli ordini.

                        string[] nomi_directory = Directory.GetFiles("franca_lab_files/.nuovo/");

                        int i = 1;

                        foreach (string filename in nomi_directory)
                            i++;

                        //Formatta i numeri e li prepara ad essere salvati.

                        string profitto = Aggiungi_Zero((Convert.ToDouble(prezzo_gioiello.Text) - Convert.ToDouble(costo_materiali.Text) - Convert.ToDouble(costo_pubblicità.Text) - Convert.ToDouble(costo_spedizione.Text) - Convert.ToDouble(tasse_vari.Text)).ToString());
                        prezzo_gioiello.Text = Aggiungi_Zero(prezzo_gioiello.Text);
                        costo_materiali.Text = Aggiungi_Zero(costo_materiali.Text);
                        costo_pubblicità.Text = Aggiungi_Zero(costo_pubblicità.Text);
                        costo_spedizione.Text = Aggiungi_Zero(costo_spedizione.Text);
                        tasse_vari.Text = Aggiungi_Zero(tasse_vari.Text);

                        //Salva i numeri.

                        using (StreamWriter scrittore = File.CreateText("franca_lab_files/.nuovo/" + i + ") " + nome_cognome.Text + " (" + profitto + "€).txt"))
                        {
                            scrittore.WriteLine(nome_cognome.Text);
                            scrittore.WriteLine(prezzo_gioiello.Text);
                            scrittore.WriteLine(costo_materiali.Text);
                            scrittore.WriteLine(costo_pubblicità.Text);
                            scrittore.WriteLine(costo_spedizione.Text);
                            scrittore.WriteLine(tasse_vari.Text);
                            scrittore.WriteLine(profitto);
                        }

                        //Chiude il form ad operazione conclusa.

                        this.Close();
                    }
                    else MessageBox.Show("Usa SOLO le virgole per i numeri decimali.");
                }
                else MessageBox.Show("Compila tutti i campi.");
            }
            //Controlla che non ci siano campi con valori non accettati. Se ve ne sono, ferma l'operazione e manda un avviso.

            catch (FormatException)
            {
                MessageBox.Show("Controlla il formato:" + Environment.NewLine + "Niente lettere nei campi che richiedono numeri.");
            }
        }
    }
}