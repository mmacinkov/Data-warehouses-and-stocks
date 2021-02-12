namespace BazeSkladistaIZalihe
{
    partial class UvidUDetalje
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
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.dgvDnevnik = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPoID = new System.Windows.Forms.TextBox();
            this.txtPoTipu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datumDo = new System.Windows.Forms.DateTimePicker();
            this.datumOd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnResetiraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDnevnik)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.SandyBrown;
            this.btnNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazad.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(1, 0);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 23);
            this.btnNazad.TabIndex = 2;
            this.btnNazad.Text = "NAZAD";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.SandyBrown;
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvori.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvori.Location = new System.Drawing.Point(0, 404);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 3;
            this.btnZatvori.Text = "ZATVORI";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // dgvDnevnik
            // 
            this.dgvDnevnik.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dgvDnevnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDnevnik.GridColor = System.Drawing.Color.SandyBrown;
            this.dgvDnevnik.Location = new System.Drawing.Point(-1, 88);
            this.dgvDnevnik.Name = "dgvDnevnik";
            this.dgvDnevnik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDnevnik.Size = new System.Drawing.Size(803, 288);
            this.dgvDnevnik.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pretraživanje po ID-u igrice: ";
            // 
            // txtPoID
            // 
            this.txtPoID.Location = new System.Drawing.Point(158, 60);
            this.txtPoID.Name = "txtPoID";
            this.txtPoID.Size = new System.Drawing.Size(100, 20);
            this.txtPoID.TabIndex = 6;
            this.txtPoID.TextChanged += new System.EventHandler(this.txtPoID_TextChanged);
            // 
            // txtPoTipu
            // 
            this.txtPoTipu.Location = new System.Drawing.Point(690, 60);
            this.txtPoTipu.Name = "txtPoTipu";
            this.txtPoTipu.Size = new System.Drawing.Size(100, 20);
            this.txtPoTipu.TabIndex = 8;
            this.txtPoTipu.TextChanged += new System.EventHandler(this.txtPoTipu_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pretraživanje po tipu: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pretraživanje po  datumu: ";
            // 
            // datumDo
            // 
            this.datumDo.Location = new System.Drawing.Point(638, 380);
            this.datumDo.Margin = new System.Windows.Forms.Padding(2);
            this.datumDo.Name = "datumDo";
            this.datumDo.Size = new System.Drawing.Size(152, 20);
            this.datumDo.TabIndex = 14;
            this.datumDo.ValueChanged += new System.EventHandler(this.datumDo_ValueChanged);
            // 
            // datumOd
            // 
            this.datumOd.Location = new System.Drawing.Point(261, 380);
            this.datumOd.Margin = new System.Windows.Forms.Padding(2);
            this.datumOd.Name = "datumOd";
            this.datumOd.Size = new System.Drawing.Size(152, 20);
            this.datumOd.TabIndex = 12;
            this.datumOd.ValueChanged += new System.EventHandler(this.datumOd_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Od:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(609, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Do:";
            // 
            // btnResetiraj
            // 
            this.btnResetiraj.BackColor = System.Drawing.Color.SandyBrown;
            this.btnResetiraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetiraj.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetiraj.Location = new System.Drawing.Point(704, 0);
            this.btnResetiraj.Name = "btnResetiraj";
            this.btnResetiraj.Size = new System.Drawing.Size(97, 23);
            this.btnResetiraj.TabIndex = 17;
            this.btnResetiraj.Text = "RESETIRAJ";
            this.btnResetiraj.UseVisualStyleBackColor = false;
            this.btnResetiraj.Click += new System.EventHandler(this.btnResetiraj_Click);
            // 
            // UvidUDetalje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 427);
            this.Controls.Add(this.btnResetiraj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datumDo);
            this.Controls.Add(this.datumOd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPoTipu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPoID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDnevnik);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnNazad);
            this.Name = "UvidUDetalje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UvidUDetalje";
            this.Load += new System.EventHandler(this.UvidUDetalje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDnevnik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.DataGridView dgvDnevnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPoID;
        private System.Windows.Forms.TextBox txtPoTipu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datumDo;
        private System.Windows.Forms.DateTimePicker datumOd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnResetiraj;
    }
}