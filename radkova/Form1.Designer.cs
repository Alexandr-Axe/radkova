namespace radkova
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.RTB_Radkova = new System.Windows.Forms.RichTextBox();
            this.RTB_Posunka = new System.Windows.Forms.RichTextBox();
            this.labelRadkovka = new System.Windows.Forms.Label();
            this.copyRadkovka = new System.Windows.Forms.Button();
            this.copyPosunka = new System.Windows.Forms.Button();
            this.labelPosunka = new System.Windows.Forms.Label();
            this.kodTB = new System.Windows.Forms.TextBox();
            this.radkovkaKombinaceTextu = new System.Windows.Forms.Label();
            this.numberofchars = new System.Windows.Forms.Label();
            this.leftRB = new System.Windows.Forms.RadioButton();
            this.rightRB = new System.Windows.Forms.RadioButton();
            this.posunutiNUD = new System.Windows.Forms.NumericUpDown();
            this.RTB_Ctverec = new System.Windows.Forms.RichTextBox();
            this.RTB_logickaCisla = new System.Windows.Forms.RichTextBox();
            this.copyLogickaCisla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.posunutiNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // RTB_Radkova
            // 
            this.RTB_Radkova.Location = new System.Drawing.Point(12, 12);
            this.RTB_Radkova.Name = "RTB_Radkova";
            this.RTB_Radkova.Size = new System.Drawing.Size(144, 112);
            this.RTB_Radkova.TabIndex = 0;
            this.RTB_Radkova.Text = "";
            this.RTB_Radkova.TextChanged += new System.EventHandler(this.RTB_Radkova_TextChanged);
            // 
            // RTB_Posunka
            // 
            this.RTB_Posunka.Location = new System.Drawing.Point(162, 12);
            this.RTB_Posunka.Name = "RTB_Posunka";
            this.RTB_Posunka.Size = new System.Drawing.Size(144, 112);
            this.RTB_Posunka.TabIndex = 1;
            this.RTB_Posunka.Text = "";
            // 
            // labelRadkovka
            // 
            this.labelRadkovka.AutoSize = true;
            this.labelRadkovka.Location = new System.Drawing.Point(31, 127);
            this.labelRadkovka.Name = "labelRadkovka";
            this.labelRadkovka.Size = new System.Drawing.Size(98, 13);
            this.labelRadkovka.TabIndex = 2;
            this.labelRadkovka.Text = "Text na zašifrování";
            // 
            // copyRadkovka
            // 
            this.copyRadkovka.Location = new System.Drawing.Point(34, 182);
            this.copyRadkovka.Name = "copyRadkovka";
            this.copyRadkovka.Size = new System.Drawing.Size(95, 50);
            this.copyRadkovka.TabIndex = 3;
            this.copyRadkovka.Text = "Po stisknutí se šifra zkopíruje";
            this.copyRadkovka.UseVisualStyleBackColor = true;
            this.copyRadkovka.Click += new System.EventHandler(this.copyRadkovka_Click);
            // 
            // copyPosunka
            // 
            this.copyPosunka.Location = new System.Drawing.Point(184, 215);
            this.copyPosunka.Name = "copyPosunka";
            this.copyPosunka.Size = new System.Drawing.Size(95, 50);
            this.copyPosunka.TabIndex = 5;
            this.copyPosunka.Text = "Po stisknutí se šifra zkopíruje";
            this.copyPosunka.UseVisualStyleBackColor = true;
            this.copyPosunka.Click += new System.EventHandler(this.copyPosunka_Click);
            // 
            // labelPosunka
            // 
            this.labelPosunka.AutoSize = true;
            this.labelPosunka.Location = new System.Drawing.Point(181, 127);
            this.labelPosunka.Name = "labelPosunka";
            this.labelPosunka.Size = new System.Drawing.Size(98, 13);
            this.labelPosunka.TabIndex = 4;
            this.labelPosunka.Text = "Text na zašifrování";
            // 
            // kodTB
            // 
            this.kodTB.Location = new System.Drawing.Point(34, 143);
            this.kodTB.Name = "kodTB";
            this.kodTB.Size = new System.Drawing.Size(95, 20);
            this.kodTB.TabIndex = 6;
            // 
            // radkovkaKombinaceTextu
            // 
            this.radkovkaKombinaceTextu.Location = new System.Drawing.Point(34, 166);
            this.radkovkaKombinaceTextu.Name = "radkovkaKombinaceTextu";
            this.radkovkaKombinaceTextu.Size = new System.Drawing.Size(95, 13);
            this.radkovkaKombinaceTextu.TabIndex = 7;
            this.radkovkaKombinaceTextu.Text = "Kombinace textu";
            this.radkovkaKombinaceTextu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberofchars
            // 
            this.numberofchars.Location = new System.Drawing.Point(34, 252);
            this.numberofchars.Name = "numberofchars";
            this.numberofchars.Size = new System.Drawing.Size(95, 13);
            this.numberofchars.TabIndex = 8;
            this.numberofchars.Text = "xxx";
            this.numberofchars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftRB
            // 
            this.leftRB.AutoSize = true;
            this.leftRB.Location = new System.Drawing.Point(200, 146);
            this.leftRB.Name = "leftRB";
            this.leftRB.Size = new System.Drawing.Size(59, 17);
            this.leftRB.TabIndex = 9;
            this.leftRB.TabStop = true;
            this.leftRB.Text = "Doleva";
            this.leftRB.UseVisualStyleBackColor = true;
            // 
            // rightRB
            // 
            this.rightRB.AutoSize = true;
            this.rightRB.Location = new System.Drawing.Point(200, 169);
            this.rightRB.Name = "rightRB";
            this.rightRB.Size = new System.Drawing.Size(66, 17);
            this.rightRB.TabIndex = 10;
            this.rightRB.TabStop = true;
            this.rightRB.Text = "Doprava";
            this.rightRB.UseVisualStyleBackColor = true;
            // 
            // posunutiNUD
            // 
            this.posunutiNUD.Location = new System.Drawing.Point(213, 192);
            this.posunutiNUD.Name = "posunutiNUD";
            this.posunutiNUD.Size = new System.Drawing.Size(38, 20);
            this.posunutiNUD.TabIndex = 11;
            // 
            // RTB_Ctverec
            // 
            this.RTB_Ctverec.Location = new System.Drawing.Point(312, 12);
            this.RTB_Ctverec.Name = "RTB_Ctverec";
            this.RTB_Ctverec.Size = new System.Drawing.Size(144, 112);
            this.RTB_Ctverec.TabIndex = 12;
            this.RTB_Ctverec.Text = "";
            // 
            // RTB_logickaCisla
            // 
            this.RTB_logickaCisla.Location = new System.Drawing.Point(462, 12);
            this.RTB_logickaCisla.Name = "RTB_logickaCisla";
            this.RTB_logickaCisla.Size = new System.Drawing.Size(144, 112);
            this.RTB_logickaCisla.TabIndex = 13;
            this.RTB_logickaCisla.Text = "";
            // 
            // copyLogickaCisla
            // 
            this.copyLogickaCisla.Location = new System.Drawing.Point(486, 127);
            this.copyLogickaCisla.Name = "copyLogickaCisla";
            this.copyLogickaCisla.Size = new System.Drawing.Size(95, 50);
            this.copyLogickaCisla.TabIndex = 14;
            this.copyLogickaCisla.Text = "Po stisknutí se šifra zkopíruje";
            this.copyLogickaCisla.UseVisualStyleBackColor = true;
            this.copyLogickaCisla.Click += new System.EventHandler(this.copyLogickaCisla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.copyLogickaCisla);
            this.Controls.Add(this.RTB_logickaCisla);
            this.Controls.Add(this.RTB_Ctverec);
            this.Controls.Add(this.posunutiNUD);
            this.Controls.Add(this.rightRB);
            this.Controls.Add(this.leftRB);
            this.Controls.Add(this.numberofchars);
            this.Controls.Add(this.radkovkaKombinaceTextu);
            this.Controls.Add(this.kodTB);
            this.Controls.Add(this.copyPosunka);
            this.Controls.Add(this.labelPosunka);
            this.Controls.Add(this.copyRadkovka);
            this.Controls.Add(this.labelRadkovka);
            this.Controls.Add(this.RTB_Posunka);
            this.Controls.Add(this.RTB_Radkova);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.posunutiNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTB_Radkova;
        private System.Windows.Forms.RichTextBox RTB_Posunka;
        private System.Windows.Forms.Label labelRadkovka;
        private System.Windows.Forms.Button copyRadkovka;
        private System.Windows.Forms.Button copyPosunka;
        private System.Windows.Forms.Label labelPosunka;
        private System.Windows.Forms.TextBox kodTB;
        private System.Windows.Forms.Label radkovkaKombinaceTextu;
        private System.Windows.Forms.Label numberofchars;
        private System.Windows.Forms.RadioButton leftRB;
        private System.Windows.Forms.RadioButton rightRB;
        private System.Windows.Forms.NumericUpDown posunutiNUD;
        private System.Windows.Forms.RichTextBox RTB_Ctverec;
        private System.Windows.Forms.RichTextBox RTB_logickaCisla;
        private System.Windows.Forms.Button copyLogickaCisla;
    }
}

