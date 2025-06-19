using System;
using System.Data;
using System.Data.SqlClient;

namespace MiddleProject1.功能區塊.商品.訂單.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly string connectionString = DBHelper.GetConnectionString();

        public DataTable GetAllOrders()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                    SELECT OrderID, MemberID, EmployeeID, OrderTime, BuyerName,
                           ReceiverName, ReceiverPhone, PaymentMethod, DeliveryMethod, DeliveryAddress
                    FROM ShopOrders
                    ORDER BY OrderID DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetOrderById(long orderId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                SELECT OrderID, MemberID, EmployeeID, OrderTime, BuyerName,
                       ReceiverName, ReceiverPhone, PaymentMethod, DeliveryMethod, DeliveryAddress
                FROM ShopOrders
                WHERE OrderID = @OrderID";


                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@OrderID", orderId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetOrderDetails(long orderId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
            SELECT 
                ProductName,
                Quantity,
                UnitPrice,
                (Quantity * UnitPrice) AS SubTotal
            FROM ShopOrderDetails
            WHERE OrderID = @OrderID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@OrderID", orderId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }



        public bool InsertOrder(
            int memberId,
            int employeeId,
            DateTime orderTime,
            string buyerName,
            string receiverName,
            string receiverPhone,
            string paymentMethod,
            string deliveryMethod,
            string deliveryAddress)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                    INSERT INTO ShopOrders
                        (MemberID, EmployeeID, OrderTime, BuyerName,
                         ReceiverName, ReceiverPhone, PaymentMethod, DeliveryMethod, DeliveryAddress)
                    VALUES
                        (@MemberID, @EmployeeID, @OrderTime, @BuyerName,
                         @ReceiverName, @ReceiverPhone, @PaymentMethod, @DeliveryMethod, @DeliveryAddress)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MemberID", memberId);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                cmd.Parameters.AddWithValue("@OrderTime", orderTime);
                cmd.Parameters.AddWithValue("@BuyerName", buyerName);
                cmd.Parameters.AddWithValue("@ReceiverName", receiverName);
                cmd.Parameters.AddWithValue("@ReceiverPhone", receiverPhone);
                cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                cmd.Parameters.AddWithValue("@DeliveryMethod", deliveryMethod);
                cmd.Parameters.AddWithValue("@DeliveryAddress", deliveryAddress);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateOrder(
            long orderId,
            int memberId,
            int employeeId,
            DateTime orderTime,
            string buyerName,
            string receiverName,
            string receiverPhone,
            string paymentMethod,
            string deliveryMethod,
            string deliveryAddress)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                    UPDATE ShopOrders
                    SET MemberID = @MemberID,
                        EmployeeID = @EmployeeID,
                        OrderTime = @OrderTime,
                        BuyerName = @BuyerName,
                        ReceiverName = @ReceiverName,
                        ReceiverPhone = @ReceiverPhone,
                        PaymentMethod = @PaymentMethod,
                        DeliveryMethod = @DeliveryMethod,
                        DeliveryAddress = @DeliveryAddress
                    WHERE OrderID = @OrderID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@OrderID", orderId);
                cmd.Parameters.AddWithValue("@MemberID", memberId);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                cmd.Parameters.AddWithValue("@OrderTime", orderTime);
                cmd.Parameters.AddWithValue("@BuyerName", buyerName);
                cmd.Parameters.AddWithValue("@ReceiverName", receiverName);
                cmd.Parameters.AddWithValue("@ReceiverPhone", receiverPhone);
                cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                cmd.Parameters.AddWithValue("@DeliveryMethod", deliveryMethod);
                cmd.Parameters.AddWithValue("@DeliveryAddress", deliveryAddress);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteOrder(long orderId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Step 1：先刪除訂單明細
                    string deleteDetailsSql = "DELETE FROM ShopOrderDetails WHERE OrderID = @OrderID";
                    SqlCommand deleteDetailsCmd = new SqlCommand(deleteDetailsSql, conn, transaction);
                    deleteDetailsCmd.Parameters.AddWithValue("@OrderID", orderId);
                    deleteDetailsCmd.ExecuteNonQuery();

                    // Step 2：再刪除主訂單
                    string deleteOrderSql = "DELETE FROM ShopOrders WHERE OrderID = @OrderID";
                    SqlCommand deleteOrderCmd = new SqlCommand(deleteOrderSql, conn, transaction);
                    deleteOrderCmd.Parameters.AddWithValue("@OrderID", orderId);
                    int affectedRows = deleteOrderCmd.ExecuteNonQuery();

                    // Step 3：提交交易
                    transaction.Commit();

                    return affectedRows > 0;
                }
                catch (Exception)
                {
                    // 發生錯誤則回滾
                    transaction.Rollback();
                    throw; // 丟出讓上層 UI 顯示錯誤訊息
                }
            }
        }

    }
}
