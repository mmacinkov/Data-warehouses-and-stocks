namespace BazeSkladistaIZalihe
{
    partial class UvidUNarudzbe
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
            this.btnResetiraj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datumZaprimljeno = new System.Windows.Forms.DateTimePicker();
            this.datumNaruceno = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPoDobavljacu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPoNazivu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNarudzbe = new System.Windows.Forms.DataGridView();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResetiraj
            // 
            this.btnResetiraj.BackColor = System.Drawing.Color.SandyBrown;
            this.btnResetiraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetiraj.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetiraj.Location = new System.Drawing.Point(706, 0);
            this.btnResetiraj.Name = "btnResetiraj";
            this.btnResetiraj.Size = new System.Drawing.Size(96, 23);
            this.btnResetiraj.TabIndex = 30;
            this.btnResetiraj.Text = "RESETIRAJ";
            this.btnResetiraj.UseVisualStyleBackColor = false;
            this.btnResetiraj.Click += new System.EventHandler(this.btnResetiraj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Zaprimljeno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Naručeno:";
            // 
            // datumZaprimljeno
            // 
            this.datumZaprimljeno.Location = new System.Drawing.Point(639, 380);
            this.datumZaprimljeno.Margin = new System.Windows.Forms.Padding(2);
            this.datumZaprimljeno.Name = "datumZaprimljeno";
            this.datumZaprimljeno.Size = new System.Drawing.Size(152, 20);
            this.datumZaprimljeno.TabIndex = 27;
            this.datumZaprimljeno.ValueChanged += new System.EventHandler(this.datumZaprimljeno_ValueChanged);
            // 
            // datumNaruceno
            // 
            this.datumNaruceno.Location = new System.Drawing.Point(262, 380);
            this.datumNaruceno.Margin = new System.Windows.Forms.Padding(2);
            this.datumNaruceno.Name = "datumNaruceno";
            this.datumNaruceno.Size = new System.Drawing.Size(152, 20);
            this.datumNaruceno.TabIndex = 26;
            this.datumNaruceno.ValueChanged += new System.EventHandler(this.datumNaruceno_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Pretraživanje po  datumu: ";
            // 
            // txtPoDobavljacu
            // 
            this.txtPoDobavljacu.Location = new System.Drawing.Point(691, 60);
            this.txtPoDobavljacu.Name = "txtPoDobavljacu";
            this.txtPoDobavljacu.Size = new System.Drawing.Size(100, 20);
            this.txtPoDobavljacu.TabIndex = 24;
            this.txtPoDobavljacu.TextChanged += new System.EventHandler(this.txtPoDobavljacu_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(546, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Pretraživanje po dobavljaču:";
            // 
            // txtPoNazivu
            // 
            this.txtPoNazivu.Location = new System.Drawing.Point(168, 60);
            this.txtPoNazivu.Name = "txtPoNazivu";
            this.txtPoNazivu.Size = new System.Drawing.Size(100, 20);
            this.txtPoNazivu.TabIndex = 22;
            this.txtPoNazivu.TextChanged += new System.EventHandler(this.txtPoNazivu_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Pretraživanje po nazivu igrice: ";
            // 
            // dgvNarudzbe
            // 
            this.dgvNarudzbe.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dgvNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbe.GridColor = System.Drawing.Color.SandyBrown;
            this.dgvNarudzbe.Location = new System.Drawing.Point(0, 88);
            this.dgvNarudzbe.Name = "dgvNarudzbe";
            this.dgvNarudzbe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNarudzbe.Size = new System.Drawing.Size(803, 288);
            this.dgvNarudzbe.TabIndex = 20;
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.SandyBrown;
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvori.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvori.Location = new System.Drawing.Point(0, 403);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(96, 23);
            this.btnZatvori.TabIndex = 19;
            this.btnZatvori.Text = "ZATVORI";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.SandyBrown;
            this.btnNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazad.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(0, 0);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(96, 23);
            this.btnNazad.TabIndex = 18;
            this.btnNazad.Text = "NAZAD";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // UvidUNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 427);
            this.Controls.Add(this.btnResetiraj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datumZaprimljeno);
            this.Controls.Add(this.datumNaruceno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPoDobavljacu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPoNazivu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNarudzbe);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnNazad);
            this.Name = "UvidUNarudzbe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UvidUNarudzbe";
            this.Load += new System.EventHandler(this.UvidUNarudzbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResetiraj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datumZaprimljeno;
        private System.Windows.Forms.DateTimePicker datumNaruceno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPoDobavljacu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPoNazivu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNarudzbe;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnNazad;
    }
}