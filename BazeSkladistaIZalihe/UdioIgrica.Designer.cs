namespace BazeSkladistaIZalihe
{
    partial class UdioIgrica
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartUdioIgrica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvIgrice = new System.Windows.Forms.DataGridView();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartUdioIgrica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgrice)).BeginInit();
            this.SuspendLayout();
            // 
            // chartUdioIgrica
            // 
            chartArea3.Name = "ChartArea1";
            this.chartUdioIgrica.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartUdioIgrica.Legends.Add(legend3);
            this.chartUdioIgrica.Location = new System.Drawing.Point(0, 27);
            this.chartUdioIgrica.Name = "chartUdioIgrica";
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartUdioIgrica.Series.Add(series3);
            this.chartUdioIgrica.Size = new System.Drawing.Size(575, 332);
            this.chartUdioIgrica.TabIndex = 0;
            this.chartUdioIgrica.Text = "Udio igrica";
            // 
            // dgvIgrice
            // 
            this.dgvIgrice.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dgvIgrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIgrice.GridColor = System.Drawing.Color.SandyBrown;
            this.dgvIgrice.Location = new System.Drawing.Point(572, 0);
            this.dgvIgrice.Name = "dgvIgrice";
            this.dgvIgrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIgrice.Size = new System.Drawing.Size(279, 390);
            this.dgvIgrice.TabIndex = 1;
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.SandyBrown;
            this.btnNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazad.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(-1, -1);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 23);
            this.btnNazad.TabIndex = 5;
            this.btnNazad.Text = "NAZAD";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.SandyBrown;
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvori.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvori.Location = new System.Drawing.Point(-1, 364);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 7;
            this.btnZatvori.Text = "ZATVORI";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // UdioIgrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 386);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.dgvIgrice);
            this.Controls.Add(this.chartUdioIgrica);
            this.Name = "UdioIgrica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UdioIgrica";
            this.Load += new System.EventHandler(this.UdioIgrica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartUdioIgrica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartUdioIgrica;
        private System.Windows.Forms.DataGridView dgvIgrice;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnZatvori;
    }
}