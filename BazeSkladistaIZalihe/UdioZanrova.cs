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
    public partial class UdioZanrova : Form
    {
        Baza baza = new Baza();
        public UdioZanrova()
        {
            InitializeComponent();
        }

        private void UdioZanrova_Load(object sender, EventArgs e)
        {
            baza.Spoji();
            Osvjezi(baza.connection
                );
            baza.Odspoji();
        }

        private void Osvjezi(NpgsqlConnection connection)
        {
            string upit =
                "SELECT \"Zanr\".\"Naziv\", COUNT(*) AS broj_igrica " +
                " FROM \"Zanr\"" +
                " JOIN \"Igrica\" ON \"Zanr\".\"ID\" = \"Igrica\".\"vk_zanr\"" +
                " JOIN \"Skladiste\" ON \"Igrica\".\"ID\"=\"Skladiste\".\"ID_igrica\"" +
                " GROUP BY 1" +
                " ORDER BY 2 DESC";

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(upit, connection);
            DataSet statDs = new DataSet();

            dataAdapter.Fill(statDs);
            chartUdioZanrova.DataSource = statDs.Tables[0];
            chartUdioZanrova.Series[0].XValueMember = "Naziv";
            chartUdioZanrova.Series[0].YValueMembers = "broj_igrica";
            chartUdioZanrova.DataBind();
            chartKruzni.DataSource = statDs.Tables[0];
            chartKruzni.Series[0].XValueMember = "Naziv";
            chartKruzni.Series[0].YValueMembers = "broj_igrica";
            chartKruzni.DataBind();

            dgvZanrovi.DataSource = statDs.Tables[0];
            dgvZanrovi.Columns[0].HeaderText = "Žanr";
            dgvZanrovi.Columns[0].Width = 132;
            dgvZanrovi.Columns[1].HeaderText = "Broj igrica";
            dgvZanrovi.Columns[1].Width = 98;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            UvidUStatistiku uvidUStatistiku = new UvidUStatistiku();
            PomocUNavigaciji.IdiNaFormu(this, uvidUStatistiku);
        }
    }
}
