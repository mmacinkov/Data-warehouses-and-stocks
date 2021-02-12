namespace BazeSkladistaIZalihe
{
    partial class UpravljanjeKolicinom
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
            this.dgvIgrice = new System.Windows.Forms.DataGridView();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDodaj = new System.Windows.Forms.TextBox();
            this.txtOduzmi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOduzmi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIgrice
            // 
            this.dgvIgrice.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dgvIgrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIgrice.GridColor = System.Drawing.Color.SandyBrown;
            this.dgvIgrice.Location = new System.Drawing.Point(398, 39);
            this.dgvIgrice.Name = "dgvIgrice";
            this.dgvIgrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIgrice.Size = new System.Drawing.Size(400, 370);
            this.dgvIgrice.TabIndex = 0;
            this.dgvIgrice.SelectionChanged += new System.EventHandler(this.dgvIgrice_SelectionChanged);
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.SandyBrown;
            this.btnNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazad.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(0, 0);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 23);
            this.btnNazad.TabIndex = 1;
            this.btnNazad.Text = "NAZAD";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.SandyBrown;
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvori.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvori.Location = new System.Drawing.Point(0, 398);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 2;
            this.btnZatvori.Text = "ZATVORI";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stanje igrica na skladištu:";
            // 
            // txtDodaj
            // 
            this.txtDodaj.Location = new System.Drawing.Point(75, 112);
            this.txtDodaj.Name = "txtDodaj";
            this.txtDodaj.Size = new System.Drawing.Size(100, 20);
            this.txtDodaj.TabIndex = 4;
            // 
            // txtOduzmi
            // 
            this.txtOduzmi.Location = new System.Drawing.Point(75, 279);
            this.txtOduzmi.Name = "txtOduzmi";
            this.txtOduzmi.Size = new System.Drawing.Size(100, 20);
            this.txtOduzmi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dodavanje količine:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.SandyBrown;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(195, 112);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "DODAJ";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOduzmi
            // 
            this.btnOduzmi.BackColor = System.Drawing.Color.SandyBrown;
            this.btnOduzmi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOduzmi.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOduzmi.Location = new System.Drawing.Point(195, 279);
            this.btnOduzmi.Name = "btnOduzmi";
            this.btnOduzmi.Size = new System.Drawing.Size(75, 23);
            this.btnOduzmi.TabIndex = 8;
            this.btnOduzmi.Text = "ODUZMI";
            this.btnOduzmi.UseVisualStyleBackColor = false;
            this.btnOduzmi.Click += new System.EventHandler(this.btnOduzmi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Oduzimanje količine:";
            // 
            // UpravljanjeKolicinom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOduzmi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOduzmi);
            this.Controls.Add(this.txtDodaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.dgvIgrice);
            this.Name = "UpravljanjeKolicinom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpravljanjeKolicinom";
            this.Load += new System.EventHandler(this.UpravljanjeKolicinom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIgrice;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDodaj;
        private System.Windows.Forms.TextBox txtOduzmi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOduzmi;
        private System.Windows.Forms.Label label3;
    }
}