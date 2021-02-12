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
    public partial class UpravljanjeKolicinom : Form
    {
        Baza baza = new Baza();
        private int odabrano;
        public UpravljanjeKolicinom()
        {
            InitializeComponent();
        }

        private void Osvjezi(NpgsqlConnection connection)
        {
            string upit = "SELECT \"Skladiste\".\"ID_igrica\", \"Igrica\".\"Naziv\", \"Skladiste\".\"Kolicina\"," +
                " \"Skladiste\".\"Vrijeme_promjene\"" +
                " FROM \"Skladiste\", \"Igrica\"" +
                " WHERE \"Skladiste\".\"ID_igrica\" = \"Igrica\".\"ID\"" +
                " ORDER BY 1";

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(upit, connection);
            DataSet igriceDs = new DataSet();
            dataAdapter.Fill(igriceDs);
            dgvIgrice.DataSource = igriceDs.Tables[0];
            dgvIgrice.Columns[0].HeaderText = "ID";
            dgvIgrice.Columns[0].Width = 70;
            dgvIgrice.Columns[1].HeaderText = "Naziv";
            dgvIgrice.Columns[1].Width = 120;
            dgvIgrice.Columns[2].HeaderText = "Količina";
            dgvIgrice.Columns[2].Width = 67;
            dgvIgrice.Columns[3].HeaderText = "Izmjena";
            dgvIgrice.Columns[3].Width = 100;
        }

        private void UpravljanjeKolicinom_Load(object sender, EventArgs e)
        {
            baza.Spoji();
            Osvjezi(baza.connection);
            baza.Odspoji();
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


        private void dgvIgrice_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                odabrano = int.Parse(dgvIgrice.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                odabrano = 0;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (odabrano != 0)
            {
                if (txtDodaj.Text == "")
                {
                    MessageBox.Show("Niste unjeli količinu!", "UPOZORENJE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int broj;
                    int.TryParse(txtDodaj.Text, out broj);
                    if (broj > 0)
                    {
                        baza.Spoji();
                        string upit = "UPDATE \"Skladiste\" SET \"Kolicina\"=\"Kolicina\"+" + broj + " WHERE \"ID_igrica\"=" + odabrano + ";";
                        NpgsqlCommand command = new NpgsqlCommand(upit, baza.connection);
                        command.ExecuteNonQuery();
                        Osvjezi(baza.connection);
                        baza.Odspoji();
                        txtDodaj.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Količina mora biti pozitivan broj!", "UPOZORENJE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDodaj.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Morate odabrati igricu!", "UPOZORENJE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOduzmi_Click(object sender, EventArgs e)
        {
            if (odabrano != 0)
            {
                if (txtOduzmi.Text == "")
                {
                    MessageBox.Show("Niste unjeli količinu!", "UPOZORENJE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int broj;
                    int.TryParse(txtOduzmi.Text, out broj);
                    if (broj > 0)
                    {
                        baza.Spoji();
                        string upit = "UPDATE \"Skladiste\" SET \"Kolicina\"=\"Kolicina\"-" + broj + " WHERE \"ID_igrica\"=" + odabrano + ";";
                        NpgsqlCommand command = new NpgsqlCommand(upit, baza.connection);
                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (NpgsqlException ex)
                        {
                            MessageBox.Show(ex.Message, "UPOZORENJE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        Osvjezi(baza.connection);
                        baza.Odspoji();
                        txtOduzmi.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Količina mora biti pozitivan broj!", "UPOZORENJE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtOduzmi.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Niste unjeli količinu!", "UPOZORENJE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
