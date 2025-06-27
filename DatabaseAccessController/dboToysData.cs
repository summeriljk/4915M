using System.Data;
using MySql.Data.MySqlClient;

namespace DatabaseAccessController
{
    public class dboToysData : dboDatabaseController
    {
        public dboToysData(string connectionString) : base(connectionString)
        {
        }

        public DataTable GetToysData()
        {
            string sqlCmd = "SELECT toy_id, name, category, brand, inventory FROM toys";
            return GetData(sqlCmd);
        }
    }
}