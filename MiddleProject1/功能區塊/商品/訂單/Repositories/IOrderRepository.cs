using System;
using System.Data;

namespace MiddleProject1.功能區塊.商品.訂單.Repositories
{
    public interface IOrderRepository
    {
        // 取得全部訂單資料（給主畫面）
        DataTable GetAllOrders();

        // 取得單筆訂單資料（給編輯畫面）
        DataTable GetOrderById(long orderId);
        DataTable GetOrderDetails(long orderId);

        // 新增訂單
        bool InsertOrder(
            int memberId,
            int employeeId,
            DateTime orderTime,
            string buyerName,
            string receiverName,
            string receiverPhone,
            string paymentMethod,
            string deliveryMethod,
            string deliveryAddress
        );

        // 編輯訂單
        bool UpdateOrder(
            long orderId,
            int memberId,
            int employeeId,
            DateTime orderTime,
            string buyerName,
            string receiverName,
            string receiverPhone,
            string paymentMethod,
            string deliveryMethod,
            string deliveryAddress
        );

        // 刪除訂單
        bool DeleteOrder(long orderId);
    }
}
