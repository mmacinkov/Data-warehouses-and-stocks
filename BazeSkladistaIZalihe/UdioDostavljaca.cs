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
    public partial class UdioDostavljaca : Form
    {
        Baza baza = new Baza();
        public UdioDostavljaca()
        {
            InitializeComponent();
        }

        private void Osvjezi(NpgsqlConnection connection)
        {
            string upit =
                "SELECT \"Dostavljac\".\"Naziv\", SUM(\"Kolicina\") AS broj_igrica " +
                " FROM \"Dostavljac\"" +
                " JOIN \"Narudzba\" ON \"Dostavljac\".\"ID\" = \"Narudzba\".\"vk_dostavljac\"" +
                " GROUP BY 1" +
                " ORDER BY 2 DESC";

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(upit, connection);
            DataSet statDs = new DataSet();

            dataAdapter.Fill(statDs);
            chartUdioDostavljaca.DataSource = statDs.Tables[0];
            chartUdioDostavljaca.Series[0].XValueMember = "Naziv";
            chartUdioDostavljaca.Series[0].YValueMembers = "broj_igrica";
            chartUdioDostavljaca.DataBind();
            chartKruzni.DataSource = statDs.Tables[0];
            chartKruzni.Series[0].XValueMember = "Naziv";
            chartKruzni.Series[0].YValueMembers = "broj_igrica";
            chartKruzni.DataBind();


            dgvDostavljaci.DataSource = statDs.Tables[0];
            dgvDostavljaci.Columns[0].HeaderText = "Dostavljač";
            dgvDostavljaci.Columns[0].Width = 132;
            dgvDostavljaci.Columns[1].HeaderText = "Broj igrica";
            dgvDostavljaci.Columns[1].Width = 98;
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

        private void UdioDostavljaca_Load(object sender, EventArgs e)
        {
            baza.Spoji();
            Osvjezi(baza.connection);
            baza.Odspoji();
        }
    }
}
