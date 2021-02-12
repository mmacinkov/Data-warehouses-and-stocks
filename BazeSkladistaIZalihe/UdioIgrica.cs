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
    public partial class UdioIgrica : Form
    {
        Baza baza = new Baza();
        public UdioIgrica()
        {
            InitializeComponent();
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

        private void Osvjezi(NpgsqlConnection connection)
        {
            string upit =
                "SELECT \"Igrica\".\"Naziv\", \"Skladiste\".\"Kolicina\" " +
                " FROM \"Igrica\", \"Skladiste\"" +
                " WHERE \"Igrica\".\"ID\" = \"Skladiste\".\"ID_igrica\"" +
                " ORDER BY 2";

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(upit, connection);
            DataSet statDs = new DataSet();

            dataAdapter.Fill(statDs);
            chartUdioIgrica.DataSource = statDs.Tables[0];
            chartUdioIgrica.Series[0].XValueMember = "Naziv";
            chartUdioIgrica.Series[0].YValueMembers = "Kolicina";
            chartUdioIgrica.DataBind();

            dgvIgrice.DataSource = statDs.Tables[0];
            dgvIgrice.Columns[0].HeaderText = "Naziv";
            dgvIgrice.Columns[0].Width = 132;
            dgvIgrice.Columns[1].HeaderText = "Količina";
            dgvIgrice.Columns[1].Width = 98;
        }

        private void UdioIgrica_Load(object sender, EventArgs e)
        {
            baza.Spoji();
            Osvjezi(baza.connection);
            baza.Odspoji();
        }
    }
}
