namespace BazeSkladistaIZalihe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnUpravljanjeKolicinom = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnNarudzbe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpravljanjeKolicinom
            // 
            this.btnUpravljanjeKolicinom.BackColor = System.Drawing.Color.SandyBrown;
            this.btnUpravljanjeKolicinom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpravljanjeKolicinom.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpravljanjeKolicinom.Location = new System.Drawing.Point(222, 31);
            this.btnUpravljanjeKolicinom.Name = "btnUpravljanjeKolicinom";
            this.btnUpravljanjeKolicinom.Size = new System.Drawing.Size(299, 83);
            this.btnUpravljanjeKolicinom.TabIndex = 0;
            this.btnUpravljanjeKolicinom.Text = "UPRAVLJANJE KOLIČINOM";
            this.btnUpravljanjeKolicinom.UseVisualStyleBackColor = false;
            this.btnUpravljanjeKolicinom.Click += new System.EventHandler(this.btnUpravljanjeKolicinom_Click);
            // 
            // btnStatistika
            // 
            this.btnStatistika.BackColor = System.Drawing.Color.SandyBrown;
            this.btnStatistika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistika.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistika.Location = new System.Drawing.Point(222, 298);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(299, 83);
            this.btnStatistika.TabIndex = 1;
            this.btnStatistika.Text = "UVID U STATISTIKU";
            this.btnStatistika.UseVisualStyleBackColor = false;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // btnDetalji
            // 
            this.btnDetalji.BackColor = System.Drawing.Color.SandyBrown;
            this.btnDetalji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalji.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalji.Location = new System.Drawing.Point(222, 209);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(299, 83);
            this.btnDetalji.TabIndex = 2;
            this.btnDetalji.Text = "UVID U DNEVNIK AKTIVNOSTI";
            this.btnDetalji.UseVisualStyleBackColor = false;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // btnNarudzbe
            // 
            this.btnNarudzbe.BackColor = System.Drawing.Color.SandyBrown;
            this.btnNarudzbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNarudzbe.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNarudzbe.Location = new System.Drawing.Point(222, 120);
            this.btnNarudzbe.Name = "btnNarudzbe";
            this.btnNarudzbe.Size = new System.Drawing.Size(299, 83);
            this.btnNarudzbe.TabIndex = 3;
            this.btnNarudzbe.Text = "UVID U NARUDŽBE";
            this.btnNarudzbe.UseVisualStyleBackColor = false;
            this.btnNarudzbe.Click += new System.EventHandler(this.btnNarudzbe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OldLace;
            this.label1.Location = new System.Drawing.Point(110, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aplikacija za vođenje statistike skladišta i planiranje zaliha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(739, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNarudzbe);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.btnStatistika);
            this.Controls.Add(this.btnUpravljanjeKolicinom);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpravljanjeKolicinom;
        private System.Windows.Forms.Button btnStatistika;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button btnNarudzbe;
        private System.Windows.Forms.Label label1;
    }
}

