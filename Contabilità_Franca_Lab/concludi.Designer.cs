
namespace Contabilità_Franca_Lab
{
    partial class concludi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(concludi));
            this.txt_1 = new System.Windows.Forms.Label();
            this.anno = new System.Windows.Forms.NumericUpDown();
            this.txt_2 = new System.Windows.Forms.Label();
            this.concludi_fine = new System.Windows.Forms.Button();
            this.mese = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.anno)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_1
            // 
            this.txt_1.AutoSize = true;
            this.txt_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_1.Location = new System.Drawing.Point(41, 31);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(87, 36);
            this.txt_1.TabIndex = 1;
            this.txt_1.Text = "Mese";
            // 
            // anno
            // 
            this.anno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.anno.Location = new System.Drawing.Point(441, 70);
            this.anno.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.anno.Name = "anno";
            this.anno.Size = new System.Drawing.Size(321, 53);
            this.anno.TabIndex = 2;
            // 
            // txt_2
            // 
            this.txt_2.AutoSize = true;
            this.txt_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_2.Location = new System.Drawing.Point(435, 31);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(87, 36);
            this.txt_2.TabIndex = 3;
            this.txt_2.Text = "Anno";
            // 
            // concludi_fine
            // 
            this.concludi_fine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.concludi_fine.Location = new System.Drawing.Point(47, 166);
            this.concludi_fine.Name = "concludi_fine";
            this.concludi_fine.Size = new System.Drawing.Size(715, 74);
            this.concludi_fine.TabIndex = 4;
            this.concludi_fine.Text = "Concludi";
            this.concludi_fine.UseVisualStyleBackColor = true;
            this.concludi_fine.Click += new System.EventHandler(this.concludi_fine_Click);
            // 
            // mese
            // 
            this.mese.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mese.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.mese.FormattingEnabled = true;
            this.mese.Items.AddRange(new object[] {
            "01) Gennaio",
            "02) Febbraio",
            "03) Marzo",
            "04) Aprile",
            "05) Maggio",
            "06) Giugno",
            "07) Luglio",
            "08) Agosto",
            "09) Settembre",
            "10) Ottobre",
            "11) Novembre",
            "12) Dicembre"});
            this.mese.Location = new System.Drawing.Point(47, 69);
            this.mese.Name = "mese";
            this.mese.Size = new System.Drawing.Size(321, 54);
            this.mese.TabIndex = 5;
            // 
            // concludi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 284);
            this.Controls.Add(this.mese);
            this.Controls.Add(this.concludi_fine);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.anno);
            this.Controls.Add(this.txt_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "concludi";
            this.Text = "Concludi";
            this.Load += new System.EventHandler(this.concludi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt_1;
        private System.Windows.Forms.NumericUpDown anno;
        private System.Windows.Forms.Label txt_2;
        private System.Windows.Forms.Button concludi_fine;
        private System.Windows.Forms.ComboBox mese;
    }
}