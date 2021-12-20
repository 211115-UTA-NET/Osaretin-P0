using System;
using System.Data;
using System.Data.SqlClient;
using OsaGadgetStore;
namespace OsaGadgetStore
{
    public class Connection : IConn
    {
        private readonly string connectionString;

        public Connection(string connectionString)
        {
            ///this.connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
            this.connectionString = connectionString;
        }



        public IEnumerable<MyData> GetAllRoundsOfPlayer()
        {
            List<MyData> result = new();

            using SqlConnection connection = new(connectionString);
            connection.Open();

            using SqlCommand cmd = new(
                @"Select *
                from Employee",
                connection);

            // using (SqlDataReader reader = cmd.ExecuteReader())
            // {
            //     while (reader.Read())
            //     {

            //         Console.WriteLine(String.Format("{0}", reader["FirstName"]));

            //      }
            //  }
            using SqlDataAdapter adapter = new(cmd);
            DataSet dataSet = new();
            adapter.Fill(dataSet);

                connection.Close();

            foreach(DataRow row in dataSet.Tables[0].Rows)
            {
                Console.WriteLine($"{row["FirstName"]}: \"{row["LastName"]}");
                Console.WriteLine(row["FirstName"]);
                string lnane =row["LastName"].ToString();
                string Fnane = row["LastName"].ToString();

                result.Add(new(lnane, Fnane));


            }

            return result;
        }

    }
}

