using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Contabilità_Franca_Lab
{
    public partial class main : Form
    {
        double costi_mensili;

        //Carica i valori nei riquadri giusti.

        void Mostra_Valori(string Dir, TextBox nOrdini, TextBox profittoTot)
        {
            string[] nomi_directory = Directory.GetFiles(Dir);

            int count = 0;

            foreach (string filename in nomi_directory)
                count++;

            nOrdini.Text = count.ToString();

            double profitto_tot = 0;
            string[] content = new string[7];

            foreach (string filename in nomi_directory)
            {
                using (StreamReader sr = File.OpenText(filename))
                {
                    for (int u = 0; u < content.Length; u++)
                        content[u] = sr.ReadLine();
                }
                profitto_tot += Convert.ToDouble(content[content.Length - 1]);
            }

            profittoTot.Text = Aggiungi_Zero(profitto_tot.ToString()) + "€";
        }

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

        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            //Crea directory dei file (se necessario).

            if (!Directory.Exists("franca_lab_files/.nuovo"))
                Directory.CreateDirectory("franca_lab_files/.nuovo");

            //Crea e inizializza il file dei costi fissi mensili (se necessario).

            if (!File.Exists("franca_lab_files/.costi_fissi.txt"))
            {
                using (StreamWriter scrittore = File.CreateText("franca_lab_files/.costi_fissi.txt"))
                {
                    scrittore.WriteLine("0,00");
                }
            }

            //Carica il valore dei costi fissi mensili.

            using (StreamReader sr = File.OpenText("franca_lab_files/.costi_fissi.txt"))
            {
                costi_mensili = Convert.ToDouble(sr.ReadLine());
            }

            costi_fissi.Text = Aggiungi_Zero(costi_mensili.ToString());

            string[] mesi_malvati = Directory.GetDirectories("franca_lab_files/");

            //Chiama "Mostra_Valori".

            Mostra_Valori("franca_lab_files/.nuovo", nuovo_n_ordini, nuovo_profitto_tot);

            //Conta i mesi salvati.

            int cont = 0;

            foreach (string filename in mesi_malvati)
                cont++;

            //Se non ci sono mesi passati salvati disattiva tutte le funzioni della cronologia, se ve ne sono invece le attiva.

            if (cont != 1)
            {
                cronologia_selezionato.Visible = true;
                esporta.Enabled = true;
                gestisci.Enabled = true;

                cronologia_selezionato.Items.Clear();

                for (int k = 1; k < cont; k++)
                    cronologia_selezionato.Items.Add(Path.GetFileName(mesi_malvati[k]));

                cronologia_selezionato.SelectedIndex = cronologia_selezionato.Items.Count - 1;

                cronologia_selezionato_SelectedIndexChanged(e, e);
            }
            else
            {
                cronologia_selezionato.Visible = false;
                esporta.Enabled = false;
                gestisci.Enabled = false;

                cronologia_n_ordini.Text = "0";
                cronologia_profitto_tot.Text = "0,00€";
            }
        }

        private void cronologia_selezionato_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Chiama "Mostra_Valori" su un qualsiasi mese passato selezionato.

            Mostra_Valori("franca_lab_files/" + cronologia_selezionato.Text, cronologia_n_ordini, cronologia_profitto_tot);
        }

        //Salva l'Excel del mese selezionato.

        private void esporta_Click(object sender, EventArgs e)
        {
            try
            {
                //Controlla che i campi interessati non siano vuoti.

                if (costi_fissi.Text != "")
                {
                    //Controlla che i numeri decimali siano formattati correttamente.

                    if (costi_fissi.Text.IndexOf('.') == -1)
                    {
                        costi_mensili = Convert.ToDouble(costi_fissi.Text);

                        //Modifica il file dei costi fissi con il valore inserito.

                        using (StreamWriter scrittore = File.CreateText("franca_lab_files/.costi_fissi.txt"))
                        {
                            scrittore.WriteLine(Aggiungi_Zero(costi_mensili.ToString()));
                        }

                        costi_fissi.Text = Aggiungi_Zero(costi_mensili.ToString());

                        //Crea un'instanza di Excel.

                        Excel.Application xlApp = new Excel.Application();

                        //Crea cartella "Franca's Lab" in "Documenti" dell'utente in uso, se non esiste.

                        if (!Directory.Exists("C:/Users/" + Environment.UserName + "/Documenti/Franca's Lab"))
                            Directory.CreateDirectory("C:/Users/" + Environment.UserName + "/Documenti/Franca's Lab");

                        //Controlla se l'instanza di Excel è aperta correttamente.

                        if (xlApp != null)
                        {
                            //Crea il file Excel.

                            Excel.Workbook xlWorkBook = xlApp.Workbooks.Add();

                            //Crea il foglio Excel.

                            Excel.Worksheet xlWorkSheet = xlWorkBook.Worksheets.get_Item(1);

                            //Imposta la larghezza delle colonne.

                            xlWorkSheet.Columns.ColumnWidth = 20;

                            //Assegna i nomi ad ogni colonna.

                            xlWorkSheet.Cells[1, 1] = "Nome e Cognome";
                            xlWorkSheet.Cells[1, 2] = "Prezzo Gioiello (€)";
                            xlWorkSheet.Cells[1, 3] = "Costo Materiali (€)";
                            xlWorkSheet.Cells[1, 4] = "Costo Pubblicità (€)";
                            xlWorkSheet.Cells[1, 5] = "Costo Spedizione (€)";
                            xlWorkSheet.Cells[1, 6] = "Tasse e Vari (€)";
                            xlWorkSheet.Cells[1, 7] = "Profitto (€)";

                            //Seleziona le caselle dell'intestazione da colorare.

                            var selezione_colori = xlWorkSheet.Range[xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[1, 7]];

                            //Colora le caselle selezionate.

                            selezione_colori.Cells.Interior.Color = System.Drawing.Color.Gray;

                            //Crea l'array che raccoglie i nomi dei file nella cartella del mese selezionato. 

                            string[] mese_concluso = Directory.GetFiles("franca_lab_files/" + cronologia_selezionato.Text);

                            //Crea l'array che raccoglie i valori contenuti nei file degli ordini.

                            string[] content = new string[7];

                            int j = 1;
                            double somma_guadagno = 0;

                            foreach (string filename in mese_concluso)
                            {
                                //Legge e popola l'array con il contenuto del file dell'ordine.

                                using (StreamReader sr = File.OpenText(filename))
                                {
                                    for (int u = 0; u < content.Length; u++)
                                    {
                                        content[u] = sr.ReadLine();
                                    }
                                }

                                //Somma il profitto dell'ordine corrente al profitto totale del mese.

                                somma_guadagno += Convert.ToDouble(content[6]);

                                //Inserisce i valori nell'Excel.

                                for (int k = 0; k < content.Length; k++)
                                    xlWorkSheet.Cells[j + 1, k + 1] = content[k];
                                j++;
                            }

                            //Colora la casella dei costi fissi mensili di giallo.

                            xlWorkSheet.Cells[j + 1, 7].Cells.Interior.Color = System.Drawing.Color.Yellow;

                            //Se il profitto è positivo: colora la casella del profitto di verde.

                            if ((somma_guadagno - costi_mensili) > 0)
                                xlWorkSheet.Cells[j + 2, 7].Cells.Interior.Color = System.Drawing.Color.Green;

                            //Se il profitto è negativo o nullo: colora la casella del profitto di rosso.

                            else if ((somma_guadagno - costi_mensili) <= 0)
                                xlWorkSheet.Cells[j + 2, 7].Cells.Interior.Color = System.Drawing.Color.Red;

                            //Inserisce i valori dei costi fissi e del profitto nelle apposite caselle.

                            xlWorkSheet.Cells[j + 1, 7] = "FISSI: " + Aggiungi_Zero("-" + costi_mensili.ToString()) + "€";
                            xlWorkSheet.Cells[j + 2, 7] = "TOTALE: " + Aggiungi_Zero((somma_guadagno - costi_mensili).ToString()) + "€";

                            //Salva il file nella cartella "Documenti/Franca's Lab".

                            xlWorkBook.SaveAs("Franca's Lab/" + cronologia_selezionato.Text + ".xls", Excel.XlFileFormat.xlWorkbookNormal, null, null, null, null, Excel.XlSaveAsAccessMode.xlExclusive, null, null, null, null, null);

                            //Chiude i vari processi e manda messagebox di successo.

                            xlWorkBook.Close(true);
                            xlApp.Quit();
                            Marshal.ReleaseComObject(xlWorkSheet);
                            Marshal.ReleaseComObject(xlWorkBook);
                            Marshal.ReleaseComObject(xlApp);

                            MessageBox.Show("Mese esportato correttamente.");
                        }
                        else MessageBox.Show("Excel non è installato/non trovato!");
                    }
                    else MessageBox.Show("Usa SOLO le virgole per i numeri decimali.");
                }
                else MessageBox.Show("Inserisci il costo fisso.");
            }
            //Controlla che non ci siano campi con valori non accettati. Se ve ne sono, ferma l'operazione e manda un avviso.

            catch (FormatException)
            {
                MessageBox.Show("Controlla il formato:" + Environment.NewLine + "Niente lettere nei campi che richiedono numeri.");
            }
        }

        //Apre il form "rimuovi.cs" se le condizioni sono rispettate.

        private void rimuovi_Click(object sender, EventArgs e)
        {
            //Controlla che non vi siano form incompatibili già aperti.

            if (((Application.OpenForms["rimuovi"] as rimuovi) == null) && ((Application.OpenForms["aggiungi"] as aggiungi) == null) && ((Application.OpenForms["concludi"] as concludi) == null))
            {
                Form rimuovi = new rimuovi();
                rimuovi.ShowDialog();
                main_Load(e, e);
            }
        }

        //Apre il form "aggiungi.cs" se le condizioni sono rispettate.

        private void aggiungi_Click(object sender, EventArgs e)
        {
            //Controlla che non vi siano form incompatibili già aperti.

            if (((Application.OpenForms["aggiungi"] as aggiungi) == null) && ((Application.OpenForms["rimuovi"] as rimuovi) == null) && ((Application.OpenForms["concludi"] as concludi) == null))
            {
                Form aggiungi = new aggiungi();
                aggiungi.ShowDialog();
                main_Load(e, e);
            }
        }

        //Apre il form "cronologia.cs" se le condizioni sono rispettate.

        private void cronologia_Click(object sender, EventArgs e)
        {
            //Controlla che non vi siano form incompatibili già aperti.

            if ((Application.OpenForms["gestisci_cronologia"] as gestisci_cronologia) == null)
            {
                Form gestisci_cronologia = new gestisci_cronologia();
                gestisci_cronologia.ShowDialog();
                main_Load(e, e);
            }
        }

        //Apre il form "concludi.cs" se le condizioni sono rispettate.

        private void concludi_Click(object sender, EventArgs e)
        {
            //Controlla che non vi siano form incompatibili già aperti.

            if (((Application.OpenForms["aggiungi"] as aggiungi) == null) && ((Application.OpenForms["rimuovi"] as rimuovi) == null) && ((Application.OpenForms["concludi"] as concludi) == null))
            {
                Form concludi = new concludi();
                concludi.ShowDialog();
                main_Load(e, e);
            }
        }

        //Apre la finestra dei crediti (la parte più importante).

        private void crediti_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Creato da Giuseppe Pagliaro e Luca Giordano. with <3");
        }
    }
}