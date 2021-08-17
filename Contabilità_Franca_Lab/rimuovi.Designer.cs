
namespace Contabilità_Franca_Lab
{
    partial class rimuovi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rimuovi));
            this.lista_ordini = new System.Windows.Forms.CheckedListBox();
            this.rimuovi_fine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista_ordini
            // 
            this.lista_ordini.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lista_ordini.FormattingEnabled = true;
            this.lista_ordini.Location = new System.Drawing.Point(12, 12);
            this.lista_ordini.Name = "lista_ordini";
            this.lista_ordini.Size = new System.Drawing.Size(644, 270);
            this.lista_ordini.TabIndex = 0;
            // 
            // rimuovi_fine
            // 
            this.rimuovi_fine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.rimuovi_fine.Location = new System.Drawing.Point(12, 288);
            this.rimuovi_fine.Name = "rimuovi_fine";
            this.rimuovi_fine.Size = new System.Drawing.Size(647, 65);
            this.rimuovi_fine.TabIndex = 2;
            this.rimuovi_fine.Text = "Rimuovi";
            this.rimuovi_fine.UseVisualStyleBackColor = true;
            this.rimuovi_fine.Click += new System.EventHandler(this.rimuovi_fine_Click);
            // 
            // rimuovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 364);
            this.Controls.Add(this.rimuovi_fine);
            this.Controls.Add(this.lista_ordini);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "rimuovi";
            this.Text = "Rimuovi";
            this.Load += new System.EventHandler(this.rimuovi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lista_ordini;
        private System.Windows.Forms.Button rimuovi_fine;
    }
}