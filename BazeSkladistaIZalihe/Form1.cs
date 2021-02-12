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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpravljanjeKolicinom_Click(object sender, EventArgs e)
        {
            UpravljanjeKolicinom upravljanjeKolicinom = new UpravljanjeKolicinom();
            PomocUNavigaciji.IdiNaFormu(this, upravljanjeKolicinom);
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            UvidUStatistiku uvidUStatistiku = new UvidUStatistiku();
            PomocUNavigaciji.IdiNaFormu(this, uvidUStatistiku);
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            UvidUDetalje uvidUDetalje = new UvidUDetalje();
            PomocUNavigaciji.IdiNaFormu(this, uvidUDetalje);
        }

        private void btnNarudzbe_Click(object sender, EventArgs e)
        {
            UvidUNarudzbe uvidUNarudzbe = new UvidUNarudzbe();
            PomocUNavigaciji.IdiNaFormu(this, uvidUNarudzbe);
        }
    }
}
