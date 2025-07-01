using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DatabaseAccessController
{
    public class dboShippingController : dboDatabaseController
    {
        public dboShippingController(string connectionString) : base(connectionString) { }

        public DataTable GetPendingOrders()
        {
            string sqlCmd = @"
                SELECT o.order_id, o.customerID, o.toy_id, o.quantity, o.order_date
                FROM orders o
                LEFT JOIN shipping s ON o.order_id = s.order_id
                WHERE s.order_id IS NULL OR s.status != 'Shipped'";
            return GetData(sqlCmd);
        }

        public int AddShippingInfo(int orderId, string trackingNumber, string courier, string status)
        {
            string sqlCmd = @"
                INSERT INTO shipping (order_id, tracking_number, courier, status)
                VALUES (@orderId, @trackingNumber, @courier, @status)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sqlCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    cmd.Parameters.AddWithValue("@trackingNumber", trackingNumber);
                    cmd.Parameters.AddWithValue("@courier", courier);
                    cmd.Parameters.AddWithValue("@status", status);
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}