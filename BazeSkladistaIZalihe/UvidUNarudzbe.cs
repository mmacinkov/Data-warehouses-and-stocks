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
    public partial class UvidUNarudzbe : Form
    {
        Baza baza = new Baza();
        public UvidUNarudzbe()
        {
            InitializeComponent();
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

        private void Osvjezi(NpgsqlConnection connection)
        {
            string upit = "SELECT \"Narudzba\".\"ID\", \"Igrica\".\"Naziv\", \"Dostavljac\".\"Naziv\", \"Narudzba\"" +
                ".\"Kolicina\", \"Narudzba\".\"Datum_narucivanja\", \"Narudzba\".\"Datum_primitka\" " +
                "FROM \"Igrica\" " +
                "JOIN \"Narudzba\" ON \"Igrica\".\"ID\" = \"Narudzba\".\"vk_igrica\" " +
                "JOIN \"Dostavljac\" ON \"Narudzba\".\"vk_dostavljac\" = \"Dostavljac\".\"ID\" " +
                "ORDER BY 1 DESC";

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(upit, connection);
            DataSet igriceDs = new DataSet();

            dataAdapter.Fill(igriceDs);
            dgvNarudzbe.DataSource = igriceDs.Tables[0];
            dgvNarudzbe.Columns[0].HeaderText = "ID";
            dgvNarudzbe.Columns[0].Width = 67;
            dgvNarudzbe.Columns[1].HeaderText = "Naziv igrice";
            dgvNarudzbe.Columns[1].Width = 102;
            dgvNarudzbe.Columns[2].HeaderText = "Naziv dostavljača";
            dgvNarudzbe.Columns[2].Width = 150;
            dgvNarudzbe.Columns[3].HeaderText = "Količina";
            dgvNarudzbe.Columns[3].Width = 100;
            dgvNarudzbe.Columns[4].HeaderText = "Naručeno";
            dgvNarudzbe.Columns[4].Width = 170;
            dgvNarudzbe.Columns[5].HeaderText = "Zaprimljeno";
            dgvNarudzbe.Columns[5].Width = 170;
        }

        private void btnResetiraj_Click(object sender, EventArgs e)
        {
            txtPoNazivu.Clear();
            txtPoDobavljacu.Clear();
            datumNaruceno.Value = DateTime.Now;
            datumZaprimljeno.Value = DateTime.Now;

            baza.Spoji();
            Osvjezi(baza.connection);
            baza.Odspoji();
        }

        private void UvidUNarudzbe_Load(object sender, EventArgs e)
        {
            baza.Spoji();
            Osvjezi(baza.connection);
            baza.Odspoji();
        }

        private void txtPoDobavljacu_TextChanged(object sender, EventArgs e)
        {
            string upit = "SELECT \"Narudzba\".\"ID\", \"Igrica\".\"Naziv\", \"Dostavljac\".\"Naziv\", \"Narudzba\"" +
                ".\"Kolicina\", \"Narudzba\".\"Datum_narucivanja\", \"Narudzba\".\"Datum_primitka\" " +
                "FROM \"Igrica\" " +
                "JOIN \"Narudzba\" ON \"Igrica\".\"ID\" = \"Narudzba\".\"vk_igrica\" " +
                "JOIN \"Dostavljac\" ON \"Narudzba\".\"vk_dostavljac\" = \"Dostavljac\".\"ID\" " +
                "WHERE \"Dostavljac\".\"Naziv\" LIKE '" + txtPoDobavljacu.Text + "%' " +
                "ORDER BY 1 DESC";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(upit, baza.connection);
            DataSet igriceDs = new DataSet();

            dataAdapter.Fill(igriceDs);
            dgvNarudzbe.DataSource = igriceDs.Tables[0];
            dgvNarudzbe.Columns[0].HeaderText = "ID";
            dgvNarudzbe.Columns[0].Width = 67;
            dgvNarudzbe.Columns[1].HeaderText = "Naziv igrice";
            dgvNarudzbe.Columns[1].Width = 102;
            dgvNarudzbe.Columns[2].HeaderText = "Naziv dostavljača";
            dgvNarudzbe.Columns[2].Width = 150;
            dgvNarudzbe.Columns[3].HeaderText = "Količina";
            dgvNarudzbe.Columns[3].Width = 100;
            dgvNarudzbe.Columns[4].HeaderText = "Naručeno";
            dgvNarudzbe.Columns[4].Width = 170;
            dgvNarudzbe.Columns[5].HeaderText = "Zaprimljeno";
            dgvNarudzbe.Columns[5].Width = 170;
        }

        private void txtPoNazivu_TextChanged_1(object sender, EventArgs e)
        {
            string upit = "SELECT \"Narudzba\".\"ID\", \"Igrica\".\"Naziv\", \"Dostavljac\".\"Naziv\", \"Narudzba\"" +
                ".\"Kolicina\", \"Narudzba\".\"Datum_narucivanja\", \"Narudzba\".\"Datum_primitka\"" +
                "FROM \"Igrica\" " +
                "JOIN \"Narudzba\" ON \"Igrica\".\"ID\" = \"Narudzba\".\"vk_igrica\" " +
                "JOIN \"Dostavljac\" ON \"Narudzba\".\"vk_dostavljac\" = \"Dostavljac\".\"ID\" " +
                "WHERE \"Igrica\".\"Naziv\" LIKE '" + txtPoNazivu.Text + "%' " +
                "ORDER BY 1 DESC";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(upit, baza.connection);
            DataSet igriceDs = new DataSet();

            dataAdapter.Fill(igriceDs);
            dgvNarudzbe.DataSource = igriceDs.Tables[0];
            dgvNarudzbe.Columns[0].HeaderText = "ID";
            dgvNarudzbe.Columns[0].Width = 67;
            dgvNarudzbe.Columns[1].HeaderText = "Naziv igrice";
            dgvNarudzbe.Columns[1].Width = 102;
            dgvNarudzbe.Columns[2].HeaderText = "Naziv dostavljača";
            dgvNarudzbe.Columns[2].Width = 150;
            dgvNarudzbe.Columns[3].HeaderText = "Količina";
            dgvNarudzbe.Columns[3].Width = 100;
            dgvNarudzbe.Columns[4].HeaderText = "Naručeno";
            dgvNarudzbe.Columns[4].Width = 170;
            dgvNarudzbe.Columns[5].HeaderText = "Zaprimljeno";
            dgvNarudzbe.Columns[5].Width = 170;
        }

        private void datumNaruceno_ValueChanged(object sender, EventArgs e)
        {
            string upit = "SELECT \"Narudzba\".\"ID\", \"Igrica\".\"Naziv\", \"Dostavljac\".\"Naziv\", \"Narudzba\"" +
                ".\"Kolicina\", \"Narudzba\".\"Datum_narucivanja\", \"Narudzba\".\"Datum_primitka\" " +
                "FROM \"Igrica\" " +
                "JOIN \"Narudzba\" ON \"Igrica\".\"ID\" = \"Narudzba\".\"vk_igrica\" " +
                "JOIN \"Dostavljac\" ON \"Narudzba\".\"vk_dostavljac\" = \"Dostavljac\".\"ID\" " +
                "WHERE \"Narudzba\".\"Datum_narucivanja\" >= '" + datumNaruceno.Value.Date + "' AND " +
                "\"Narudzba\".\"Datum_narucivanja\" < '" + datumNaruceno.Value.Date.AddDays(1) + "'" +
                "ORDER BY 1 DESC";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(upit, baza.connection);
            DataSet igriceDs = new DataSet();

            dataAdapter.Fill(igriceDs);
            dgvNarudzbe.DataSource = igriceDs.Tables[0];
            dgvNarudzbe.Columns[0].HeaderText = "ID";
            dgvNarudzbe.Columns[0].Width = 67;
            dgvNarudzbe.Columns[1].HeaderText = "Naziv igrice";
            dgvNarudzbe.Columns[1].Width = 102;
            dgvNarudzbe.Columns[2].HeaderText = "Naziv dostavljača";
            dgvNarudzbe.Columns[2].Width = 150;
            dgvNarudzbe.Columns[3].HeaderText = "Količina";
            dgvNarudzbe.Columns[3].Width = 100;
            dgvNarudzbe.Columns[4].HeaderText = "Naručeno";
            dgvNarudzbe.Columns[4].Width = 170;
            dgvNarudzbe.Columns[5].HeaderText = "Zaprimljeno";
            dgvNarudzbe.Columns[5].Width = 170;
        }

        private void datumZaprimljeno_ValueChanged(object sender, EventArgs e)
        {
            string upit = "SELECT \"Narudzba\".\"ID\", \"Igrica\".\"Naziv\", \"Dostavljac\".\"Naziv\", \"Narudzba\"" +
                ".\"Kolicina\", \"Narudzba\".\"Datum_narucivanja\", \"Narudzba\".\"Datum_primitka\" " +
                "FROM \"Igrica\" " +
                "JOIN \"Narudzba\" ON \"Igrica\".\"ID\" = \"Narudzba\".\"vk_igrica\" " +
                "JOIN \"Dostavljac\" ON \"Narudzba\".\"vk_dostavljac\" = \"Dostavljac\".\"ID\" " +
                "WHERE \"Narudzba\".\"Datum_primitka\" >= '" + datumZaprimljeno.Value.Date + "' AND " +
                "\"Narudzba\".\"Datum_primitka\" < '" + datumZaprimljeno.Value.Date.AddDays(1) + "'" +
                "ORDER BY 1 DESC";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(upit, baza.connection);
            DataSet igriceDs = new DataSet();

            dataAdapter.Fill(igriceDs);
            dgvNarudzbe.DataSource = igriceDs.Tables[0];
            dgvNarudzbe.Columns[0].HeaderText = "ID";
            dgvNarudzbe.Columns[0].Width = 67;
            dgvNarudzbe.Columns[1].HeaderText = "Naziv igrice";
            dgvNarudzbe.Columns[1].Width = 102;
            dgvNarudzbe.Columns[2].HeaderText = "Naziv dostavljača";
            dgvNarudzbe.Columns[2].Width = 150;
            dgvNarudzbe.Columns[3].HeaderText = "Količina";
            dgvNarudzbe.Columns[3].Width = 100;
            dgvNarudzbe.Columns[4].HeaderText = "Naručeno";
            dgvNarudzbe.Columns[4].Width = 170;
            dgvNarudzbe.Columns[5].HeaderText = "Zaprimljeno";
            dgvNarudzbe.Columns[5].Width = 170;
        }

       
    }
}
