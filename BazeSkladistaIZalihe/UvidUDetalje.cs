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
    public partial class UvidUDetalje : Form
    {
        Baza baza = new Baza();
        public UvidUDetalje()
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
            string upit = "SELECT \"Dnevnik\".\"ID\", \"Tip\".\"Naziv\", \"Dnevnik\".\"vk_igrica\", \"Dnevnik\"" +
                ".\"Opis\", \"Dnevnik\".\"Datum\" " +
                "FROM \"Dnevnik\", \"Tip\" " +
                "WHERE \"Dnevnik\".\"vk_tip\" = \"Tip\".\"ID\" " +
                "ORDER BY 1 DESC";

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(upit, connection);
            DataSet igriceDs = new DataSet();
            dataAdapter.Fill(igriceDs);
            dgvDnevnik.DataSource = igriceDs.Tables[0];
            dgvDnevnik.Columns[0].HeaderText = "ID";
            dgvDnevnik.Columns[0].Width = 67;
            dgvDnevnik.Columns[1].HeaderText = "Tip";
            dgvDnevnik.Columns[1].Width = 135;
            dgvDnevnik.Columns[2].HeaderText = "ID igrice";
            dgvDnevnik.Columns[2].Width = 77;
            dgvDnevnik.Columns[3].HeaderText = "Događaj";
            dgvDnevnik.Columns[3].Width = 265;
            dgvDnevnik.Columns[4].HeaderText = "Datum";
            dgvDnevnik.Columns[4].Width = 215;
        }

        private void UvidUDetalje_Load(object sender, EventArgs e)
        {
            baza.Spoji();
            Osvjezi(baza.connection);
            baza.Odspoji();
        }

        private void txtPoID_TextChanged(object sender, EventArgs e)
        {
            if (txtPoID.Text.Length >= 0)
            {
                int id;
                int.TryParse(txtPoID.Text, out id);
                string upit = "SELECT \"Dnevnik\".\"ID\", \"Tip\".\"Naziv\", \"Dnevnik\".\"vk_igrica\", \"Dnevnik\"" +
                ".\"Opis\", \"Dnevnik\".\"Datum\" " +
                "FROM \"Dnevnik\", \"Tip\" " +
                "WHERE \"Dnevnik\".\"vk_tip\" = \"Tip\".\"ID\" " +
                "AND \"Dnevnik\".\"vk_igrica\" = " + id + " " +
                "ORDER BY 1 DESC";

                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(upit, baza.connection);
                DataSet igriceDs = new DataSet();
                dataAdapter.Fill(igriceDs);
                dgvDnevnik.DataSource = igriceDs.Tables[0];
                dgvDnevnik.Columns[0].HeaderText = "ID";
                dgvDnevnik.Columns[0].Width = 67;
                dgvDnevnik.Columns[1].HeaderText = "Tip";
                dgvDnevnik.Columns[1].Width = 135;
                dgvDnevnik.Columns[2].HeaderText = "ID igrice";
                dgvDnevnik.Columns[2].Width = 77;
                dgvDnevnik.Columns[3].HeaderText = "Događaj";
                dgvDnevnik.Columns[3].Width = 265;
                dgvDnevnik.Columns[4].HeaderText = "Datum";
                dgvDnevnik.Columns[4].Width = 215;
            }
        }

        private void txtPoTipu_TextChanged(object sender, EventArgs e)
        {
            string upit = "SELECT \"Dnevnik\".\"ID\", \"Tip\".\"Naziv\", \"Dnevnik\".\"vk_igrica\", \"Dnevnik\"" +
                ".\"Opis\", \"Dnevnik\".\"Datum\" " +
                "FROM \"Dnevnik\", \"Tip\" " +
                "WHERE \"Dnevnik\".\"vk_tip\" = \"Tip\".\"ID\" " +
                "AND \"Tip\".\"Naziv\" LIKE '" + txtPoTipu.Text + "%' " +
                "ORDER BY 1 DESC";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(upit, baza.connection);
            DataSet igriceDs = new DataSet();
            dataAdapter.Fill(igriceDs);
            dgvDnevnik.DataSource = igriceDs.Tables[0];
            dgvDnevnik.Columns[0].HeaderText = "ID";
            dgvDnevnik.Columns[0].Width = 67;
            dgvDnevnik.Columns[1].HeaderText = "Tip";
            dgvDnevnik.Columns[1].Width = 135;
            dgvDnevnik.Columns[2].HeaderText = "ID igrice";
            dgvDnevnik.Columns[2].Width = 77;
            dgvDnevnik.Columns[3].HeaderText = "Događaj";
            dgvDnevnik.Columns[3].Width = 265;
            dgvDnevnik.Columns[4].HeaderText = "Datum";
            dgvDnevnik.Columns[4].Width = 215;
        }

        private void datumOd_ValueChanged(object sender, EventArgs e)
        {
            if (datumOd.Text.Length > 0 && datumDo.Text.Length > 0)
            {
                string upit = "SELECT \"Dnevnik\".\"ID\", \"Tip\".\"Naziv\", \"Dnevnik\".\"vk_igrica\", \"Dnevnik\"" +
                ".\"Opis\", \"Dnevnik\".\"Datum\" " +
                "FROM \"Dnevnik\", \"Tip\" " +
                "WHERE \"Dnevnik\".\"vk_tip\" = \"Tip\".\"ID\" " +
                "AND \"Dnevnik\".\"Datum\" BETWEEN '" + datumOd.Value.Date + "'::timestamp AND '" + datumDo.Value + "'::timestamp " +
                "ORDER BY 1 DESC";
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(upit, baza.connection);
                DataSet igriceDs = new DataSet();
                dataAdapter.Fill(igriceDs);
                dgvDnevnik.DataSource = igriceDs.Tables[0];
                dgvDnevnik.Columns[0].HeaderText = "ID";
                dgvDnevnik.Columns[0].Width = 67;
                dgvDnevnik.Columns[1].HeaderText = "Tip";
                dgvDnevnik.Columns[1].Width = 135;
                dgvDnevnik.Columns[2].HeaderText = "ID igrice";
                dgvDnevnik.Columns[2].Width = 77;
                dgvDnevnik.Columns[3].HeaderText = "Događaj";
                dgvDnevnik.Columns[3].Width = 265;
                dgvDnevnik.Columns[4].HeaderText = "Datum";
                dgvDnevnik.Columns[4].Width = 215;
            }
        }

        private void datumDo_ValueChanged(object sender, EventArgs e)
        {
            if (datumOd.Text.Length > 0 && datumDo.Text.Length > 0)
            {
                string upit = "SELECT \"Dnevnik\".\"ID\", \"Tip\".\"Naziv\", \"Dnevnik\".\"vk_igrica\", \"Dnevnik\"" +
                ".\"Opis\", \"Dnevnik\".\"Datum\" " +
                "FROM \"Dnevnik\", \"Tip\" " +
                "WHERE \"Dnevnik\".\"vk_tip\" = \"Tip\".\"ID\" " +
                "AND \"Dnevnik\".\"Datum\" BETWEEN '" + datumOd.Value.Date + "'::timestamp AND '" + datumDo.Value + "'::timestamp " +
                "ORDER BY 1 DESC";
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(upit, baza.connection);
                DataSet igriceDs = new DataSet();
                dataAdapter.Fill(igriceDs);
                dgvDnevnik.DataSource = igriceDs.Tables[0];
                dgvDnevnik.Columns[0].HeaderText = "ID";
                dgvDnevnik.Columns[0].Width = 67;
                dgvDnevnik.Columns[1].HeaderText = "Tip";
                dgvDnevnik.Columns[1].Width = 135;
                dgvDnevnik.Columns[2].HeaderText = "ID igrice";
                dgvDnevnik.Columns[2].Width = 77;
                dgvDnevnik.Columns[3].HeaderText = "Događaj";
                dgvDnevnik.Columns[3].Width = 265;
                dgvDnevnik.Columns[4].HeaderText = "Datum";
                dgvDnevnik.Columns[4].Width = 215;
            }
        }

        private void btnResetiraj_Click(object sender, EventArgs e)
        {
            txtPoID.Clear();
            txtPoTipu.Clear();
            datumOd.Value = DateTime.Now;
            datumDo.Value = DateTime.Now;

            baza.Spoji();
            Osvjezi(baza.connection);
            baza.Odspoji();
        }
    }
}
