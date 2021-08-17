
namespace Contabilità_Franca_Lab
{
    partial class main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.mese_nuovo = new System.Windows.Forms.GroupBox();
            this.nuovo_n_ordini = new System.Windows.Forms.TextBox();
            this.txt_nuovo_2 = new System.Windows.Forms.Label();
            this.nuovo_profitto_tot = new System.Windows.Forms.TextBox();
            this.txt_nuovo_1 = new System.Windows.Forms.Label();
            this.aggiungi = new System.Windows.Forms.Button();
            this.rimuovi = new System.Windows.Forms.Button();
            this.concludi = new System.Windows.Forms.Button();
            this.mese_cronologia = new System.Windows.Forms.GroupBox();
            this.cronologia_selezionato = new System.Windows.Forms.ComboBox();
            this.cronologia_n_ordini = new System.Windows.Forms.TextBox();
            this.txt_cronologia_2 = new System.Windows.Forms.Label();
            this.cronologia_profitto_tot = new System.Windows.Forms.TextBox();
            this.txt_cronologia_1 = new System.Windows.Forms.Label();
            this.gestisci = new System.Windows.Forms.Button();
            this.esporta = new System.Windows.Forms.Button();
            this.crediti = new System.Windows.Forms.LinkLabel();
            this.costi_fissi = new System.Windows.Forms.TextBox();
            this.txt_cronologia_3 = new System.Windows.Forms.Label();
            this.txt_cronologia_4 = new System.Windows.Forms.Label();
            this.mese_nuovo.SuspendLayout();
            this.mese_cronologia.SuspendLayout();
            this.SuspendLayout();
            // 
            // mese_nuovo
            // 
            this.mese_nuovo.Controls.Add(this.nuovo_n_ordini);
            this.mese_nuovo.Controls.Add(this.txt_nuovo_2);
            this.mese_nuovo.Controls.Add(this.nuovo_profitto_tot);
            this.mese_nuovo.Controls.Add(this.txt_nuovo_1);
            this.mese_nuovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.mese_nuovo.Location = new System.Drawing.Point(12, 12);
            this.mese_nuovo.Name = "mese_nuovo";
            this.mese_nuovo.Size = new System.Drawing.Size(480, 201);
            this.mese_nuovo.TabIndex = 0;
            this.mese_nuovo.TabStop = false;
            this.mese_nuovo.Text = "Questo Mese";
            // 
            // nuovo_n_ordini
            // 
            this.nuovo_n_ordini.Enabled = false;
            this.nuovo_n_ordini.Location = new System.Drawing.Point(24, 112);
            this.nuovo_n_ordini.Name = "nuovo_n_ordini";
            this.nuovo_n_ordini.ReadOnly = true;
            this.nuovo_n_ordini.Size = new System.Drawing.Size(150, 53);
            this.nuovo_n_ordini.TabIndex = 4;
            this.nuovo_n_ordini.Text = "0";
            // 
            // txt_nuovo_2
            // 
            this.txt_nuovo_2.AutoSize = true;
            this.txt_nuovo_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_nuovo_2.Location = new System.Drawing.Point(212, 73);
            this.txt_nuovo_2.Name = "txt_nuovo_2";
            this.txt_nuovo_2.Size = new System.Drawing.Size(156, 36);
            this.txt_nuovo_2.TabIndex = 3;
            this.txt_nuovo_2.Text = "profitto tot.";
            // 
            // nuovo_profitto_tot
            // 
            this.nuovo_profitto_tot.Enabled = false;
            this.nuovo_profitto_tot.Location = new System.Drawing.Point(218, 112);
            this.nuovo_profitto_tot.Name = "nuovo_profitto_tot";
            this.nuovo_profitto_tot.ReadOnly = true;
            this.nuovo_profitto_tot.Size = new System.Drawing.Size(150, 53);
            this.nuovo_profitto_tot.TabIndex = 2;
            this.nuovo_profitto_tot.Text = "0,00€";
            // 
            // txt_nuovo_1
            // 
            this.txt_nuovo_1.AutoSize = true;
            this.txt_nuovo_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_nuovo_1.Location = new System.Drawing.Point(18, 73);
            this.txt_nuovo_1.Name = "txt_nuovo_1";
            this.txt_nuovo_1.Size = new System.Drawing.Size(123, 36);
            this.txt_nuovo_1.TabIndex = 1;
            this.txt_nuovo_1.Text = "n. ordini";
            // 
            // aggiungi
            // 
            this.aggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.aggiungi.Location = new System.Drawing.Point(12, 219);
            this.aggiungi.Name = "aggiungi";
            this.aggiungi.Size = new System.Drawing.Size(156, 53);
            this.aggiungi.TabIndex = 1;
            this.aggiungi.Text = "Aggiungi";
            this.aggiungi.UseVisualStyleBackColor = true;
            this.aggiungi.Click += new System.EventHandler(this.aggiungi_Click);
            // 
            // rimuovi
            // 
            this.rimuovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rimuovi.Location = new System.Drawing.Point(174, 219);
            this.rimuovi.Name = "rimuovi";
            this.rimuovi.Size = new System.Drawing.Size(156, 53);
            this.rimuovi.TabIndex = 2;
            this.rimuovi.Text = "Rimuovi";
            this.rimuovi.UseVisualStyleBackColor = true;
            this.rimuovi.Click += new System.EventHandler(this.rimuovi_Click);
            // 
            // concludi
            // 
            this.concludi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.concludi.Location = new System.Drawing.Point(336, 219);
            this.concludi.Name = "concludi";
            this.concludi.Size = new System.Drawing.Size(156, 53);
            this.concludi.TabIndex = 3;
            this.concludi.Text = "Concludi";
            this.concludi.UseVisualStyleBackColor = true;
            this.concludi.Click += new System.EventHandler(this.concludi_Click);
            // 
            // mese_cronologia
            // 
            this.mese_cronologia.Controls.Add(this.cronologia_selezionato);
            this.mese_cronologia.Controls.Add(this.cronologia_n_ordini);
            this.mese_cronologia.Controls.Add(this.txt_cronologia_2);
            this.mese_cronologia.Controls.Add(this.cronologia_profitto_tot);
            this.mese_cronologia.Controls.Add(this.txt_cronologia_1);
            this.mese_cronologia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.mese_cronologia.Location = new System.Drawing.Point(514, 12);
            this.mese_cronologia.Name = "mese_cronologia";
            this.mese_cronologia.Size = new System.Drawing.Size(480, 201);
            this.mese_cronologia.TabIndex = 4;
            this.mese_cronologia.TabStop = false;
            this.mese_cronologia.Text = "Nessun Mese";
            // 
            // cronologia_selezionato
            // 
            this.cronologia_selezionato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cronologia_selezionato.FormattingEnabled = true;
            this.cronologia_selezionato.Location = new System.Drawing.Point(0, 0);
            this.cronologia_selezionato.Name = "cronologia_selezionato";
            this.cronologia_selezionato.Size = new System.Drawing.Size(420, 54);
            this.cronologia_selezionato.TabIndex = 5;
            this.cronologia_selezionato.SelectedIndexChanged += new System.EventHandler(this.cronologia_selezionato_SelectedIndexChanged);
            // 
            // cronologia_n_ordini
            // 
            this.cronologia_n_ordini.Enabled = false;
            this.cronologia_n_ordini.Location = new System.Drawing.Point(24, 112);
            this.cronologia_n_ordini.Name = "cronologia_n_ordini";
            this.cronologia_n_ordini.ReadOnly = true;
            this.cronologia_n_ordini.Size = new System.Drawing.Size(150, 53);
            this.cronologia_n_ordini.TabIndex = 4;
            this.cronologia_n_ordini.Text = "0";
            // 
            // txt_cronologia_2
            // 
            this.txt_cronologia_2.AutoSize = true;
            this.txt_cronologia_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_cronologia_2.Location = new System.Drawing.Point(212, 73);
            this.txt_cronologia_2.Name = "txt_cronologia_2";
            this.txt_cronologia_2.Size = new System.Drawing.Size(156, 36);
            this.txt_cronologia_2.TabIndex = 3;
            this.txt_cronologia_2.Text = "profitto tot.";
            // 
            // cronologia_profitto_tot
            // 
            this.cronologia_profitto_tot.Enabled = false;
            this.cronologia_profitto_tot.Location = new System.Drawing.Point(218, 112);
            this.cronologia_profitto_tot.Name = "cronologia_profitto_tot";
            this.cronologia_profitto_tot.ReadOnly = true;
            this.cronologia_profitto_tot.Size = new System.Drawing.Size(150, 53);
            this.cronologia_profitto_tot.TabIndex = 2;
            this.cronologia_profitto_tot.Text = "0,00€";
            // 
            // txt_cronologia_1
            // 
            this.txt_cronologia_1.AutoSize = true;
            this.txt_cronologia_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_cronologia_1.Location = new System.Drawing.Point(18, 73);
            this.txt_cronologia_1.Name = "txt_cronologia_1";
            this.txt_cronologia_1.Size = new System.Drawing.Size(123, 36);
            this.txt_cronologia_1.TabIndex = 1;
            this.txt_cronologia_1.Text = "n. ordini";
            // 
            // gestisci
            // 
            this.gestisci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.gestisci.Location = new System.Drawing.Point(514, 219);
            this.gestisci.Name = "gestisci";
            this.gestisci.Size = new System.Drawing.Size(237, 53);
            this.gestisci.TabIndex = 5;
            this.gestisci.Text = "Gestisci";
            this.gestisci.UseVisualStyleBackColor = true;
            this.gestisci.Click += new System.EventHandler(this.cronologia_Click);
            // 
            // esporta
            // 
            this.esporta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.esporta.Location = new System.Drawing.Point(757, 219);
            this.esporta.Name = "esporta";
            this.esporta.Size = new System.Drawing.Size(237, 53);
            this.esporta.TabIndex = 6;
            this.esporta.Text = "Esporta";
            this.esporta.UseVisualStyleBackColor = true;
            this.esporta.Click += new System.EventHandler(this.esporta_Click);
            // 
            // crediti
            // 
            this.crediti.AutoSize = true;
            this.crediti.LinkColor = System.Drawing.Color.Blue;
            this.crediti.Location = new System.Drawing.Point(12, 285);
            this.crediti.Name = "crediti";
            this.crediti.Size = new System.Drawing.Size(54, 20);
            this.crediti.TabIndex = 7;
            this.crediti.TabStop = true;
            this.crediti.Text = "Crediti";
            this.crediti.VisitedLinkColor = System.Drawing.Color.Blue;
            this.crediti.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.crediti_LinkClicked);
            // 
            // costi_fissi
            // 
            this.costi_fissi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costi_fissi.Location = new System.Drawing.Point(866, 278);
            this.costi_fissi.Name = "costi_fissi";
            this.costi_fissi.Size = new System.Drawing.Size(99, 30);
            this.costi_fissi.TabIndex = 8;
            this.costi_fissi.Text = "0,00";
            // 
            // txt_cronologia_3
            // 
            this.txt_cronologia_3.AutoSize = true;
            this.txt_cronologia_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cronologia_3.Location = new System.Drawing.Point(752, 281);
            this.txt_cronologia_3.Name = "txt_cronologia_3";
            this.txt_cronologia_3.Size = new System.Drawing.Size(108, 25);
            this.txt_cronologia_3.TabIndex = 9;
            this.txt_cronologia_3.Text = "Costi Fissi:";
            // 
            // txt_cronologia_4
            // 
            this.txt_cronologia_4.AutoSize = true;
            this.txt_cronologia_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cronologia_4.Location = new System.Drawing.Point(971, 281);
            this.txt_cronologia_4.Name = "txt_cronologia_4";
            this.txt_cronologia_4.Size = new System.Drawing.Size(23, 25);
            this.txt_cronologia_4.TabIndex = 10;
            this.txt_cronologia_4.Text = "€";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 324);
            this.Controls.Add(this.txt_cronologia_4);
            this.Controls.Add(this.txt_cronologia_3);
            this.Controls.Add(this.costi_fissi);
            this.Controls.Add(this.crediti);
            this.Controls.Add(this.esporta);
            this.Controls.Add(this.gestisci);
            this.Controls.Add(this.mese_cronologia);
            this.Controls.Add(this.concludi);
            this.Controls.Add(this.rimuovi);
            this.Controls.Add(this.aggiungi);
            this.Controls.Add(this.mese_nuovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main";
            this.Text = "Contabilità Franca\'s Lab";
            this.Load += new System.EventHandler(this.main_Load);
            this.mese_nuovo.ResumeLayout(false);
            this.mese_nuovo.PerformLayout();
            this.mese_cronologia.ResumeLayout(false);
            this.mese_cronologia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mese_nuovo;
        private System.Windows.Forms.Label txt_nuovo_2;
        private System.Windows.Forms.TextBox nuovo_profitto_tot;
        private System.Windows.Forms.Label txt_nuovo_1;
        private System.Windows.Forms.Button aggiungi;
        private System.Windows.Forms.Button rimuovi;
        private System.Windows.Forms.Button concludi;
        private System.Windows.Forms.GroupBox mese_cronologia;
        private System.Windows.Forms.Label txt_cronologia_2;
        private System.Windows.Forms.TextBox cronologia_profitto_tot;
        private System.Windows.Forms.Label txt_cronologia_1;
        private System.Windows.Forms.Button gestisci;
        private System.Windows.Forms.TextBox nuovo_n_ordini;
        private System.Windows.Forms.TextBox cronologia_n_ordini;
        private System.Windows.Forms.ComboBox cronologia_selezionato;
        private System.Windows.Forms.Button esporta;
        private System.Windows.Forms.LinkLabel crediti;
        private System.Windows.Forms.TextBox costi_fissi;
        private System.Windows.Forms.Label txt_cronologia_3;
        private System.Windows.Forms.Label txt_cronologia_4;
    }
}