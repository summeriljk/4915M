using System.Data;
using MySql.Data.MySqlClient;

namespace DatabaseAccessController
{
    public class dboAfterSalesController : dboDatabaseController
    {
        public dboAfterSalesController(string connectionString) : base(connectionString)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="orderId">Order ID</param>
        /// <param name="type">Request type</param>
        /// <param name="description">Request description</param>
        /// <returns>Number of rows affected</returns>
        public int CreateRequest(int orderId, string type, string description)
        {
            string sqlCmd = @"
                INSERT INTO AfterSales (OrderId, Type, Description, Status, CreatedAt)
                VALUES (@OrderId, @Type, @Description, 'pending', NOW())
            ";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sqlCmd, conn))
                    {
                        cmd.Parameters.AddWithValue("@OrderId", orderId);
                        cmd.Parameters.AddWithValue("@Type", type);
                        cmd.Parameters.AddWithValue("@Description", description);
                        return cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="id">Request ID</param>
        /// <param name="approve">Whether to approve the request</param>
        /// <returns>Number of rows affected</returns>
        public int ResolveRequest(int id, bool approve)
        {
            string status = approve ? "resolved" : "rejected";
            string sqlCmd = @"
                UPDATE AfterSales
                SET Status = @Status
                WHERE Id = @Id
            ";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sqlCmd, conn))
                    {
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@Id", id);
                        return cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}