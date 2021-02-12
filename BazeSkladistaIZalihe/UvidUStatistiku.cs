using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazeSkladistaIZalihe
{
    public partial class UvidUStatistiku : Form
    {
        public UvidUStatistiku()
        {
            InitializeComponent();
        }

        private void btnIzdavac_Click(object sender, EventArgs e)
        {
            UdioIzdavaca udioIzdavaca = new UdioIzdavaca();
            PomocUNavigaciji.IdiNaFormu(this, udioIzdavaca);
        }

        private void btnZanr_Click(object sender, EventArgs e)
        {
            UdioZanrova udioZanrova = new UdioZanrova();
            PomocUNavigaciji.IdiNaFormu(this, udioZanrova);
        }

        private void btnDostavljac_Click(object sender, EventArgs e)
        {
            UdioDostavljaca udioDostavljaca = new UdioDostavljaca();
            PomocUNavigaciji.IdiNaFormu(this, udioDostavljaca);
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            PomocUNavigaciji.IdiNaFormu(this, form1);
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIgrice_Click(object sender, EventArgs e)
        {
            UdioIgrica udioIgrica = new UdioIgrica();
            PomocUNavigaciji.IdiNaFormu(this, udioIgrica);
        }
    }
}
