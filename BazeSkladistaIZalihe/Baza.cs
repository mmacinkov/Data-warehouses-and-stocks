using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace BazeSkladistaIZalihe
{
    public class Baza
    {
        public NpgsqlConnection connection;
        public void Spoji()
        {
            string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password = marin;Database = postgres; ";
            connection = new NpgsqlConnection(connectionString);
            connection.Open();
        }
        public void Odspoji()
        {
            connection.Close();
        }
    }
}
