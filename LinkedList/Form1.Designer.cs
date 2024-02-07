namespace LinkedList
{
    partial class F1LinkedList
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
            this.txtListDisplay = new System.Windows.Forms.TextBox();
            this.lblListe = new System.Windows.Forms.Label();
            this.lblLeggTil = new System.Windows.Forms.Label();
            this.lblLeggTilForklaring = new System.Windows.Forms.Label();
            this.lblSlett = new System.Windows.Forms.Label();
            this.lblSlettForklaring = new System.Windows.Forms.Label();
            this.txtLeggTil = new System.Windows.Forms.TextBox();
            this.txtSkrivText = new System.Windows.Forms.TextBox();
            this.txtSkrivNr = new System.Windows.Forms.TextBox();
            this.TxtSlett = new System.Windows.Forms.TextBox();
            this.btnSlettØverst = new System.Windows.Forms.Button();
            this.btnSlett = new System.Windows.Forms.Button();
            this.btnLeggTilØverst = new System.Windows.Forms.Button();
            this.btnLeggTilForan = new System.Windows.Forms.Button();
            this.btnLeggTilNederst = new System.Windows.Forms.Button();
            this.lblSkrivInnText = new System.Windows.Forms.Label();
            this.lblSkrivInnNr = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.btnSlettNederst = new System.Windows.Forms.Button();
            this.btnAvslutt = new System.Windows.Forms.Button();
            this.lblSlettHeleListen = new System.Windows.Forms.Label();
            this.btnSlettListe = new System.Windows.Forms.Button();
            this.btnLeggTilBak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtListDisplay
            // 
            this.txtListDisplay.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtListDisplay.Location = new System.Drawing.Point(30, 54);
            this.txtListDisplay.Multiline = true;
            this.txtListDisplay.Name = "txtListDisplay";
            this.txtListDisplay.ReadOnly = true;
            this.txtListDisplay.Size = new System.Drawing.Size(178, 360);
            this.txtListDisplay.TabIndex = 0;
            // 
            // lblListe
            // 
            this.lblListe.AutoSize = true;
            this.lblListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListe.Location = new System.Drawing.Point(96, 22);
            this.lblListe.Name = "lblListe";
            this.lblListe.Size = new System.Drawing.Size(48, 20);
            this.lblListe.TabIndex = 1;
            this.lblListe.Text = "Liste";
            // 
            // lblLeggTil
            // 
            this.lblLeggTil.AutoSize = true;
            this.lblLeggTil.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblLeggTil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeggTil.Location = new System.Drawing.Point(292, 74);
            this.lblLeggTil.Name = "lblLeggTil";
            this.lblLeggTil.Size = new System.Drawing.Size(60, 20);
            this.lblLeggTil.TabIndex = 2;
            this.lblLeggTil.Text = "Legg til";
            // 
            // lblLeggTilForklaring
            // 
            this.lblLeggTilForklaring.AutoSize = true;
            this.lblLeggTilForklaring.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblLeggTilForklaring.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeggTilForklaring.Location = new System.Drawing.Point(454, 74);
            this.lblLeggTilForklaring.Name = "lblLeggTilForklaring";
            this.lblLeggTilForklaring.Size = new System.Drawing.Size(332, 20);
            this.lblLeggTilForklaring.TabIndex = 3;
            this.lblLeggTilForklaring.Text = "Skriv inn text og velg hvor i arrayen det legges:";
            // 
            // lblSlett
            // 
            this.lblSlett.AutoSize = true;
            this.lblSlett.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblSlett.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlett.Location = new System.Drawing.Point(310, 264);
            this.lblSlett.Name = "lblSlett";
            this.lblSlett.Size = new System.Drawing.Size(42, 20);
            this.lblSlett.TabIndex = 4;
            this.lblSlett.Text = "Slett";
            // 
            // lblSlettForklaring
            // 
            this.lblSlettForklaring.AutoSize = true;
            this.lblSlettForklaring.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblSlettForklaring.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlettForklaring.Location = new System.Drawing.Point(472, 268);
            this.lblSlettForklaring.Name = "lblSlettForklaring";
            this.lblSlettForklaring.Size = new System.Drawing.Size(302, 20);
            this.lblSlettForklaring.TabIndex = 5;
            this.lblSlettForklaring.Text = "Skriv inn hvilket nr i listen som du vil slette:";
            // 
            // txtLeggTil
            // 
            this.txtLeggTil.Location = new System.Drawing.Point(275, 118);
            this.txtLeggTil.Name = "txtLeggTil";
            this.txtLeggTil.Size = new System.Drawing.Size(100, 20);
            this.txtLeggTil.TabIndex = 6;
            // 
            // txtSkrivText
            // 
            this.txtSkrivText.Location = new System.Drawing.Point(503, 118);
            this.txtSkrivText.Name = "txtSkrivText";
            this.txtSkrivText.Size = new System.Drawing.Size(111, 20);
            this.txtSkrivText.TabIndex = 7;
            // 
            // txtSkrivNr
            // 
            this.txtSkrivNr.Location = new System.Drawing.Point(620, 118);
            this.txtSkrivNr.Name = "txtSkrivNr";
            this.txtSkrivNr.Size = new System.Drawing.Size(113, 20);
            this.txtSkrivNr.TabIndex = 8;
            // 
            // TxtSlett
            // 
            this.TxtSlett.Location = new System.Drawing.Point(563, 308);
            this.TxtSlett.Name = "TxtSlett";
            this.TxtSlett.Size = new System.Drawing.Size(100, 20);
            this.TxtSlett.TabIndex = 9;
            // 
            // btnSlettØverst
            // 
            this.btnSlettØverst.BackColor = System.Drawing.Color.Snow;
            this.btnSlettØverst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSlettØverst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlettØverst.ForeColor = System.Drawing.Color.Black;
            this.btnSlettØverst.Location = new System.Drawing.Point(253, 287);
            this.btnSlettØverst.Name = "btnSlettØverst";
            this.btnSlettØverst.Size = new System.Drawing.Size(75, 23);
            this.btnSlettØverst.TabIndex = 10;
            this.btnSlettØverst.Text = "Øverst";
            this.btnSlettØverst.UseVisualStyleBackColor = false;
            this.btnSlettØverst.Click += new System.EventHandler(this.btnSlettØverst_Click);
            // 
            // btnSlett
            // 
            this.btnSlett.BackColor = System.Drawing.Color.Snow;
            this.btnSlett.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSlett.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlett.ForeColor = System.Drawing.Color.Black;
            this.btnSlett.Location = new System.Drawing.Point(574, 347);
            this.btnSlett.Name = "btnSlett";
            this.btnSlett.Size = new System.Drawing.Size(75, 23);
            this.btnSlett.TabIndex = 11;
            this.btnSlett.Text = "Slett";
            this.btnSlett.UseVisualStyleBackColor = false;
            this.btnSlett.Click += new System.EventHandler(this.btnSlett_Click);
            // 
            // btnLeggTilØverst
            // 
            this.btnLeggTilØverst.BackColor = System.Drawing.Color.Snow;
            this.btnLeggTilØverst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeggTilØverst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeggTilØverst.ForeColor = System.Drawing.Color.Black;
            this.btnLeggTilØverst.Location = new System.Drawing.Point(253, 172);
            this.btnLeggTilØverst.Name = "btnLeggTilØverst";
            this.btnLeggTilØverst.Size = new System.Drawing.Size(75, 23);
            this.btnLeggTilØverst.TabIndex = 12;
            this.btnLeggTilØverst.Text = "Øverst";
            this.btnLeggTilØverst.UseVisualStyleBackColor = false;
            this.btnLeggTilØverst.Click += new System.EventHandler(this.btnLeggTilØverst_Click);
            // 
            // btnLeggTilForan
            // 
            this.btnLeggTilForan.BackColor = System.Drawing.Color.Snow;
            this.btnLeggTilForan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeggTilForan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeggTilForan.ForeColor = System.Drawing.Color.Black;
            this.btnLeggTilForan.Location = new System.Drawing.Point(508, 144);
            this.btnLeggTilForan.Name = "btnLeggTilForan";
            this.btnLeggTilForan.Size = new System.Drawing.Size(98, 27);
            this.btnLeggTilForan.TabIndex = 13;
            this.btnLeggTilForan.Text = "Legg til foran";
            this.btnLeggTilForan.UseVisualStyleBackColor = false;
            this.btnLeggTilForan.Click += new System.EventHandler(this.btnLeggTilForan_Click);
            // 
            // btnLeggTilNederst
            // 
            this.btnLeggTilNederst.BackColor = System.Drawing.Color.Snow;
            this.btnLeggTilNederst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeggTilNederst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeggTilNederst.ForeColor = System.Drawing.Color.Black;
            this.btnLeggTilNederst.Location = new System.Drawing.Point(334, 172);
            this.btnLeggTilNederst.Name = "btnLeggTilNederst";
            this.btnLeggTilNederst.Size = new System.Drawing.Size(75, 23);
            this.btnLeggTilNederst.TabIndex = 14;
            this.btnLeggTilNederst.Text = "Nederst";
            this.btnLeggTilNederst.UseVisualStyleBackColor = false;
            this.btnLeggTilNederst.Click += new System.EventHandler(this.btnLeggTilNederst_Click);
            // 
            // lblSkrivInnText
            // 
            this.lblSkrivInnText.AutoSize = true;
            this.lblSkrivInnText.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblSkrivInnText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkrivInnText.Location = new System.Drawing.Point(518, 102);
            this.lblSkrivInnText.Name = "lblSkrivInnText";
            this.lblSkrivInnText.Size = new System.Drawing.Size(78, 15);
            this.lblSkrivInnText.TabIndex = 15;
            this.lblSkrivInnText.Text = "Skriv inn text:";
            // 
            // lblSkrivInnNr
            // 
            this.lblSkrivInnNr.AutoSize = true;
            this.lblSkrivInnNr.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblSkrivInnNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkrivInnNr.Location = new System.Drawing.Point(622, 102);
            this.lblSkrivInnNr.Name = "lblSkrivInnNr";
            this.lblSkrivInnNr.Size = new System.Drawing.Size(106, 15);
            this.lblSkrivInnNr.TabIndex = 16;
            this.lblSkrivInnNr.Text = "Skriv inn nummer:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LavenderBlush;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.CausesValidation = false;
            this.label4.Location = new System.Drawing.Point(451, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(337, 173);
            this.label4.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LavenderBlush;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.CausesValidation = false;
            this.label6.Location = new System.Drawing.Point(451, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(337, 173);
            this.label6.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LavenderBlush;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.CausesValidation = false;
            this.label7.Location = new System.Drawing.Point(234, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 173);
            this.label7.TabIndex = 22;
            // 
            // lblBack
            // 
            this.lblBack.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBack.CausesValidation = false;
            this.lblBack.Location = new System.Drawing.Point(234, 55);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(197, 173);
            this.lblBack.TabIndex = 21;
            // 
            // btnSlettNederst
            // 
            this.btnSlettNederst.BackColor = System.Drawing.Color.Snow;
            this.btnSlettNederst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSlettNederst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlettNederst.ForeColor = System.Drawing.Color.Black;
            this.btnSlettNederst.Location = new System.Drawing.Point(334, 287);
            this.btnSlettNederst.Name = "btnSlettNederst";
            this.btnSlettNederst.Size = new System.Drawing.Size(75, 23);
            this.btnSlettNederst.TabIndex = 25;
            this.btnSlettNederst.Text = "Nederst";
            this.btnSlettNederst.UseVisualStyleBackColor = false;
            this.btnSlettNederst.Click += new System.EventHandler(this.btnSlettNederst_Click);
            // 
            // btnAvslutt
            // 
            this.btnAvslutt.BackColor = System.Drawing.Color.Snow;
            this.btnAvslutt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAvslutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvslutt.ForeColor = System.Drawing.Color.Black;
            this.btnAvslutt.Location = new System.Drawing.Point(79, 420);
            this.btnAvslutt.Name = "btnAvslutt";
            this.btnAvslutt.Size = new System.Drawing.Size(75, 23);
            this.btnAvslutt.TabIndex = 26;
            this.btnAvslutt.Text = "Avslutt";
            this.btnAvslutt.UseVisualStyleBackColor = false;
            this.btnAvslutt.Click += new System.EventHandler(this.btnAvslutt_Click);
            // 
            // lblSlettHeleListen
            // 
            this.lblSlettHeleListen.AutoSize = true;
            this.lblSlettHeleListen.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblSlettHeleListen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlettHeleListen.Location = new System.Drawing.Point(281, 338);
            this.lblSlettHeleListen.Name = "lblSlettHeleListen";
            this.lblSlettHeleListen.Size = new System.Drawing.Size(117, 20);
            this.lblSlettHeleListen.TabIndex = 27;
            this.lblSlettHeleListen.Text = "Slett hele listen";
            // 
            // btnSlettListe
            // 
            this.btnSlettListe.BackColor = System.Drawing.Color.Snow;
            this.btnSlettListe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSlettListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlettListe.ForeColor = System.Drawing.Color.Black;
            this.btnSlettListe.Location = new System.Drawing.Point(296, 361);
            this.btnSlettListe.Name = "btnSlettListe";
            this.btnSlettListe.Size = new System.Drawing.Size(75, 23);
            this.btnSlettListe.TabIndex = 28;
            this.btnSlettListe.Text = "Slett liste";
            this.btnSlettListe.UseVisualStyleBackColor = false;
            this.btnSlettListe.Click += new System.EventHandler(this.btnSlettListe_Click);
            // 
            // btnLeggTilBak
            // 
            this.btnLeggTilBak.BackColor = System.Drawing.Color.Snow;
            this.btnLeggTilBak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeggTilBak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeggTilBak.ForeColor = System.Drawing.Color.Black;
            this.btnLeggTilBak.Location = new System.Drawing.Point(631, 144);
            this.btnLeggTilBak.Name = "btnLeggTilBak";
            this.btnLeggTilBak.Size = new System.Drawing.Size(89, 27);
            this.btnLeggTilBak.TabIndex = 29;
            this.btnLeggTilBak.Text = "Legg til bak";
            this.btnLeggTilBak.UseVisualStyleBackColor = false;
            this.btnLeggTilBak.Click += new System.EventHandler(this.btnLeggTilBak_Click);
            // 
            // F1LinkedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLeggTilBak);
            this.Controls.Add(this.btnSlettListe);
            this.Controls.Add(this.lblSlettHeleListen);
            this.Controls.Add(this.btnAvslutt);
            this.Controls.Add(this.btnSlettNederst);
            this.Controls.Add(this.lblSkrivInnNr);
            this.Controls.Add(this.lblSkrivInnText);
            this.Controls.Add(this.btnLeggTilNederst);
            this.Controls.Add(this.btnLeggTilForan);
            this.Controls.Add(this.btnLeggTilØverst);
            this.Controls.Add(this.btnSlett);
            this.Controls.Add(this.btnSlettØverst);
            this.Controls.Add(this.TxtSlett);
            this.Controls.Add(this.txtSkrivNr);
            this.Controls.Add(this.txtSkrivText);
            this.Controls.Add(this.txtLeggTil);
            this.Controls.Add(this.lblSlettForklaring);
            this.Controls.Add(this.lblSlett);
            this.Controls.Add(this.lblLeggTilForklaring);
            this.Controls.Add(this.lblLeggTil);
            this.Controls.Add(this.lblListe);
            this.Controls.Add(this.txtListDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblBack);
            this.Name = "F1LinkedList";
            this.Text = "LinkedList";
            this.Load += new System.EventHandler(this.F1LinkedList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtListDisplay;
        private System.Windows.Forms.Label lblListe;
        private System.Windows.Forms.Label lblLeggTil;
        private System.Windows.Forms.Label lblLeggTilForklaring;
        private System.Windows.Forms.Label lblSlett;
        private System.Windows.Forms.Label lblSlettForklaring;
        private System.Windows.Forms.TextBox txtLeggTil;
        private System.Windows.Forms.TextBox txtSkrivText;
        private System.Windows.Forms.TextBox txtSkrivNr;
        private System.Windows.Forms.TextBox TxtSlett;
        private System.Windows.Forms.Button btnSlettØverst;
        private System.Windows.Forms.Button btnSlett;
        private System.Windows.Forms.Button btnLeggTilØverst;
        private System.Windows.Forms.Button btnLeggTilForan;
        private System.Windows.Forms.Button btnLeggTilNederst;
        private System.Windows.Forms.Label lblSkrivInnText;
        private System.Windows.Forms.Label lblSkrivInnNr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Button btnSlettNederst;
        private System.Windows.Forms.Button btnAvslutt;
        private System.Windows.Forms.Label lblSlettHeleListen;
        private System.Windows.Forms.Button btnSlettListe;
        private System.Windows.Forms.Button btnLeggTilBak;
    }
}

