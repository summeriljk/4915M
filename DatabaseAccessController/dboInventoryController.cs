using System.Data;
using MySql.Data.MySqlClient;

namespace DatabaseAccessController
{
    public class dboInventoryController : dboDatabaseController
    {
        public dboInventoryController(string connectionString) : base(connectionString)
        {
        }

        /// <summary>
        /// </summary>
        /// <returns>DataTable containing low stock products</returns>
        public DataTable GetLowStockProducts()
        {
            string sqlCmd = @"
                SELECT p.Id, p.Name, p.Stock, p.MinimumStockLevel
                FROM Products p
                WHERE p.Stock < p.MinimumStockLevel
            ";

            return GetData(sqlCmd);
        }

        /// <summary>
        /// </summary>
        /// <param name="productId">Product ID</param>
        /// <param name="adjustAmount">Adjustment amount (positive to add, negative to subtract)</param>
        /// <param name="reason">Reason for adjustment</param>
        /// <param name="adminId">Admin ID who made the change</param>
        /// <returns>Number of affected rows</returns>
        public int AdjustInventory(int productId, int adjustAmount, string reason, int adminId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string updateProductSql = @"
                                UPDATE Products
                                SET Stock = Stock + @AdjustAmount
                                WHERE Id = @ProductId
                            ";

                            using (MySqlCommand updateProductCmd = new MySqlCommand(updateProductSql, conn, transaction))
                            {
                                updateProductCmd.Parameters.AddWithValue("@AdjustAmount", adjustAmount);
                                updateProductCmd.Parameters.AddWithValue("@ProductId", productId);
                                updateProductCmd.ExecuteNonQuery();
                            }

                            string insertLogSql = @"
                                INSERT INTO InventoryLogs (ProductId, ChangeAmount, Reason, AdminId, CreatedAt)
                                VALUES (@ProductId, @ChangeAmount, @Reason, @AdminId, NOW())
                            ";

                            using (MySqlCommand insertLogCmd = new MySqlCommand(insertLogSql, conn, transaction))
                            {
                                insertLogCmd.Parameters.AddWithValue("@ProductId", productId);
                                insertLogCmd.Parameters.AddWithValue("@ChangeAmount", adjustAmount);
                                insertLogCmd.Parameters.AddWithValue("@Reason", reason);
                                insertLogCmd.Parameters.AddWithValue("@AdminId", adminId);
                                insertLogCmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            return 1;
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
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