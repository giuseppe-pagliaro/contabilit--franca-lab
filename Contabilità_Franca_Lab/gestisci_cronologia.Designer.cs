
namespace Contabilità_Franca_Lab
{
    partial class gestisci_cronologia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestisci_cronologia));
            this.cronologia_lista = new System.Windows.Forms.CheckedListBox();
            this.gestisci_fine = new System.Windows.Forms.Button();
            this.seleziona_tutto = new System.Windows.Forms.LinkLabel();
            this.deseleziona_tutto = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cronologia_lista
            // 
            this.cronologia_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cronologia_lista.FormattingEnabled = true;
            this.cronologia_lista.Location = new System.Drawing.Point(12, 12);
            this.cronologia_lista.Name = "cronologia_lista";
            this.cronologia_lista.Size = new System.Drawing.Size(647, 270);
            this.cronologia_lista.TabIndex = 0;
            // 
            // gestisci_fine
            // 
            this.gestisci_fine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.gestisci_fine.Location = new System.Drawing.Point(12, 288);
            this.gestisci_fine.Name = "gestisci_fine";
            this.gestisci_fine.Size = new System.Drawing.Size(651, 62);
            this.gestisci_fine.TabIndex = 1;
            this.gestisci_fine.Text = "Rimuovi";
            this.gestisci_fine.UseVisualStyleBackColor = true;
            this.gestisci_fine.Click += new System.EventHandler(this.gestisci_fine_Click);
            // 
            // seleziona_tutto
            // 
            this.seleziona_tutto.AutoSize = true;
            this.seleziona_tutto.Location = new System.Drawing.Point(12, 365);
            this.seleziona_tutto.Name = "seleziona_tutto";
            this.seleziona_tutto.Size = new System.Drawing.Size(120, 20);
            this.seleziona_tutto.TabIndex = 2;
            this.seleziona_tutto.TabStop = true;
            this.seleziona_tutto.Text = "Seleziona Tutto";
            this.seleziona_tutto.VisitedLinkColor = System.Drawing.Color.Blue;
            this.seleziona_tutto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.seleziona_tutto_LinkClicked);
            // 
            // deseleziona_tutto
            // 
            this.deseleziona_tutto.AutoSize = true;
            this.deseleziona_tutto.Location = new System.Drawing.Point(138, 365);
            this.deseleziona_tutto.Name = "deseleziona_tutto";
            this.deseleziona_tutto.Size = new System.Drawing.Size(138, 20);
            this.deseleziona_tutto.TabIndex = 3;
            this.deseleziona_tutto.TabStop = true;
            this.deseleziona_tutto.Text = "Deseleziona Tutto";
            this.deseleziona_tutto.VisitedLinkColor = System.Drawing.Color.Blue;
            this.deseleziona_tutto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.deseleziona_tutto_LinkClicked);
            // 
            // gestisci_cronologia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 401);
            this.Controls.Add(this.deseleziona_tutto);
            this.Controls.Add(this.seleziona_tutto);
            this.Controls.Add(this.gestisci_fine);
            this.Controls.Add(this.cronologia_lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "gestisci_cronologia";
            this.Text = "Gestisci";
            this.Load += new System.EventHandler(this.gestisci_cronologia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cronologia_lista;
        private System.Windows.Forms.Button gestisci_fine;
        private System.Windows.Forms.LinkLabel seleziona_tutto;
        private System.Windows.Forms.LinkLabel deseleziona_tutto;
    }
}