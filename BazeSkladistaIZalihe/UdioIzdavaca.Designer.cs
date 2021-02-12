namespace BazeSkladistaIZalihe
{
    partial class UdioIzdavaca
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartUdioIzdavaca = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvIzdavaci = new System.Windows.Forms.DataGridView();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.chartKruzni = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartUdioIzdavaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzdavaci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKruzni)).BeginInit();
            this.SuspendLayout();
            // 
            // chartUdioIzdavaca
            // 
            chartArea3.Name = "ChartArea1";
            this.chartUdioIzdavaca.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartUdioIzdavaca.Legends.Add(legend3);
            this.chartUdioIzdavaca.Location = new System.Drawing.Point(-1, 27);
            this.chartUdioIzdavaca.Name = "chartUdioIzdavaca";
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartUdioIzdavaca.Series.Add(series3);
            this.chartUdioIzdavaca.Size = new System.Drawing.Size(575, 332);
            this.chartUdioIzdavaca.TabIndex = 0;
            this.chartUdioIzdavaca.Text = "Udio izdavača";
            // 
            // dgvIzdavaci
            // 
            this.dgvIzdavaci.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dgvIzdavaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzdavaci.GridColor = System.Drawing.Color.SandyBrown;
            this.dgvIzdavaci.Location = new System.Drawing.Point(555, 255);
            this.dgvIzdavaci.Name = "dgvIzdavaci";
            this.dgvIzdavaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIzdavaci.Size = new System.Drawing.Size(290, 132);
            this.dgvIzdavaci.TabIndex = 1;
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.SandyBrown;
            this.btnNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazad.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(-1, -1);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 23);
            this.btnNazad.TabIndex = 3;
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
            this.btnZatvori.TabIndex = 5;
            this.btnZatvori.Text = "ZATVORI";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // chartKruzni
            // 
            chartArea4.Name = "ChartArea1";
            this.chartKruzni.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartKruzni.Legends.Add(legend4);
            this.chartKruzni.Location = new System.Drawing.Point(566, 1);
            this.chartKruzni.Name = "chartKruzni";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartKruzni.Series.Add(series4);
            this.chartKruzni.Size = new System.Drawing.Size(279, 254);
            this.chartKruzni.TabIndex = 6;
            this.chartKruzni.Text = "chart1";
            // 
            // UdioIzdavaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 386);
            this.Controls.Add(this.chartKruzni);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.dgvIzdavaci);
            this.Controls.Add(this.chartUdioIzdavaca);
            this.Name = "UdioIzdavaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UdioIzdavaca";
            this.Load += new System.EventHandler(this.UdioIzdavaca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartUdioIzdavaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzdavaci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKruzni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartUdioIzdavaca;
        private System.Windows.Forms.DataGridView dgvIzdavaci;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKruzni;
    }
}