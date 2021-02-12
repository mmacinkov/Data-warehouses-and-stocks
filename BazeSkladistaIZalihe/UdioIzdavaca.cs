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
    public partial class UdioIzdavaca : Form
    {
        Baza baza = new Baza();
        public UdioIzdavaca()
        {
            InitializeComponent();
        }

        private void Osvjezi(NpgsqlConnection connection)
        {
           string upit =
                "SELECT \"Izdavac\".\"Naziv\", COUNT(*) AS broj_igrica " +
                " FROM \"Izdavac\"" +
                " JOIN \"Igrica\" ON \"Izdavac\".\"ID\" = \"Igrica\".\"vk_izdavac\"" +
                " JOIN \"Skladiste\" ON \"Igrica\".\"ID\"=\"Skladiste\".\"ID_igrica\"" +
                " GROUP BY 1" +
                " ORDER BY 2 DESC";

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(upit, connection);
            DataSet statDs = new DataSet();

            dataAdapter.Fill(statDs);
            chartUdioIzdavaca.DataSource = statDs.Tables[0];
            chartUdioIzdavaca.Series[0].XValueMember = "Naziv";
            chartUdioIzdavaca.Series[0].YValueMembers = "broj_igrica";
            chartUdioIzdavaca.DataBind();
            chartKruzni.DataSource = statDs.Tables[0];
            chartKruzni.Series[0].XValueMember = "Naziv";
            chartKruzni.Series[0].YValueMembers = "broj_igrica";
            chartKruzni.DataBind();

            dgvIzdavaci.DataSource = statDs.Tables[0];
            dgvIzdavaci.Columns[0].HeaderText = "Izdavač";
            dgvIzdavaci.Columns[0].Width = 132;
            dgvIzdavaci.Columns[1].HeaderText = "Broj igrica";
            dgvIzdavaci.Columns[1].Width = 98;
        }

        private void UdioIzdavaca_Load(object sender, EventArgs e)
        {
            baza.Spoji();
            Osvjezi(baza.connection);
            baza.Odspoji();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            UvidUStatistiku uvidUStatistiku = new UvidUStatistiku();
            PomocUNavigaciji.IdiNaFormu(this, uvidUStatistiku);
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
