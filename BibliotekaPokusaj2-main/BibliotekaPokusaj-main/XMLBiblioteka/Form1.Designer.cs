namespace XMLBiblioteka
{
    partial class Form1
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
            this.groupBoxKorisnik = new System.Windows.Forms.GroupBox();
            this.btnPregled = new System.Windows.Forms.Button();
            this.btnUnos = new System.Windows.Forms.Button();
            this.groupBoxKnjiga = new System.Windows.Forms.GroupBox();
            this.btnStanje = new System.Windows.Forms.Button();
            this.btnUnosKnjige = new System.Windows.Forms.Button();
            this.rtbStanjeKnjiga = new System.Windows.Forms.RichTextBox();
            this.rtbKorisnici = new System.Windows.Forms.RichTextBox();
            this.groupBoxKorisnik.SuspendLayout();
            this.groupBoxKnjiga.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxKorisnik
            // 
            this.groupBoxKorisnik.Controls.Add(this.rtbKorisnici);
            this.groupBoxKorisnik.Controls.Add(this.btnPregled);
            this.groupBoxKorisnik.Controls.Add(this.btnUnos);
            this.groupBoxKorisnik.Location = new System.Drawing.Point(12, 12);
            this.groupBoxKorisnik.Name = "groupBoxKorisnik";
            this.groupBoxKorisnik.Size = new System.Drawing.Size(353, 410);
            this.groupBoxKorisnik.TabIndex = 2;
            this.groupBoxKorisnik.TabStop = false;
            this.groupBoxKorisnik.Text = "Korisnik";
            // 
            // btnPregled
            // 
            this.btnPregled.Location = new System.Drawing.Point(27, 143);
            this.btnPregled.Name = "btnPregled";
            this.btnPregled.Size = new System.Drawing.Size(289, 57);
            this.btnPregled.TabIndex = 1;
            this.btnPregled.Text = "Pregled korisnika";
            this.btnPregled.UseVisualStyleBackColor = true;
            this.btnPregled.Click += new System.EventHandler(this.btnPregled_Click);
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(27, 41);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(289, 57);
            this.btnUnos.TabIndex = 0;
            this.btnUnos.Text = "Unos novog korisnika";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // groupBoxKnjiga
            // 
            this.groupBoxKnjiga.Controls.Add(this.rtbStanjeKnjiga);
            this.groupBoxKnjiga.Controls.Add(this.btnStanje);
            this.groupBoxKnjiga.Controls.Add(this.btnUnosKnjige);
            this.groupBoxKnjiga.Location = new System.Drawing.Point(407, 13);
            this.groupBoxKnjiga.Name = "groupBoxKnjiga";
            this.groupBoxKnjiga.Size = new System.Drawing.Size(381, 409);
            this.groupBoxKnjiga.TabIndex = 3;
            this.groupBoxKnjiga.TabStop = false;
            this.groupBoxKnjiga.Text = "Knjiga";
            // 
            // btnStanje
            // 
            this.btnStanje.Location = new System.Drawing.Point(44, 142);
            this.btnStanje.Name = "btnStanje";
            this.btnStanje.Size = new System.Drawing.Size(285, 56);
            this.btnStanje.TabIndex = 1;
            this.btnStanje.Text = "Stanje knjiga";
            this.btnStanje.UseVisualStyleBackColor = true;
            this.btnStanje.Click += new System.EventHandler(this.btnStanje_Click);
            // 
            // btnUnosKnjige
            // 
            this.btnUnosKnjige.Location = new System.Drawing.Point(44, 41);
            this.btnUnosKnjige.Name = "btnUnosKnjige";
            this.btnUnosKnjige.Size = new System.Drawing.Size(285, 56);
            this.btnUnosKnjige.TabIndex = 0;
            this.btnUnosKnjige.Text = "Unos knjige";
            this.btnUnosKnjige.UseVisualStyleBackColor = true;
            this.btnUnosKnjige.Click += new System.EventHandler(this.btnUnosKnjige_Click);
            // 
            // rtbStanjeKnjiga
            // 
            this.rtbStanjeKnjiga.Location = new System.Drawing.Point(24, 216);
            this.rtbStanjeKnjiga.Name = "rtbStanjeKnjiga";
            this.rtbStanjeKnjiga.Size = new System.Drawing.Size(335, 187);
            this.rtbStanjeKnjiga.TabIndex = 2;
            this.rtbStanjeKnjiga.Text = "";
            // 
            // rtbKorisnici
            // 
            this.rtbKorisnici.Location = new System.Drawing.Point(15, 217);
            this.rtbKorisnici.Name = "rtbKorisnici";
            this.rtbKorisnici.Size = new System.Drawing.Size(314, 187);
            this.rtbKorisnici.TabIndex = 2;
            this.rtbKorisnici.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxKnjiga);
            this.Controls.Add(this.groupBoxKorisnik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxKorisnik.ResumeLayout(false);
            this.groupBoxKnjiga.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKorisnik;
        private System.Windows.Forms.Button btnPregled;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.GroupBox groupBoxKnjiga;
        private System.Windows.Forms.Button btnStanje;
        private System.Windows.Forms.Button btnUnosKnjige;
        private System.Windows.Forms.RichTextBox rtbStanjeKnjiga;
        private System.Windows.Forms.RichTextBox rtbKorisnici;
    }
}

