using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiddleProject1.功能區塊.商品.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly string connectionString = DBHelper.GetConnectionString();

        public DataTable GetAllProducts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                    SELECT 
                        ProductID,
                        ProductName,
                        OriginalPrice,
                        SalePrice,
                        Quantity,
                        Stock,
                        Discontinued,
                        CategoryID,
                        DiscountRate,
                        Summary,
                        Content
                    FROM ShopProducts";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public int InsertProduct(string name, int originalPrice, int salePrice, int quantity, int stock,
    bool discontinued, long? categoryId, decimal? discountRate, string summary, string content)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
            INSERT INTO ShopProducts 
            (ProductName, CreateAt, OriginalPrice, SalePrice, Quantity, Stock, Discontinued, CategoryID, DiscountRate, Summary, Content)
            VALUES 
            (@ProductName, GETDATE(), @OriginalPrice, @SalePrice, @Quantity, @Stock, @Discontinued, @CategoryID, @DiscountRate, @Summary, @Content);
            SELECT CAST(SCOPE_IDENTITY() AS int);";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductName", name);
                    cmd.Parameters.AddWithValue("@OriginalPrice", originalPrice);
                    cmd.Parameters.AddWithValue("@SalePrice", salePrice);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Stock", stock);
                    cmd.Parameters.AddWithValue("@Discontinued", discontinued);
                    cmd.Parameters.AddWithValue("@CategoryID", (object)categoryId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DiscountRate", (object)discountRate ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Summary", (object)summary ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Content", (object)content ?? DBNull.Value);

                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    return (result != null) ? Convert.ToInt32(result) : -1;
                }
            }
        }

        public bool UpdateProduct(int id, string name, int originalPrice, int salePrice, int quantity, int stock,
            bool discontinued, long? categoryId, decimal? discountRate, string summary, string content)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
            UPDATE ShopProducts SET 
                ProductName = @ProductName,
                OriginalPrice = @OriginalPrice,
                SalePrice = @SalePrice,
                Quantity = @Quantity,
                Stock = @Stock,
                Discontinued = @Discontinued,
                CategoryID = @CategoryID,
                DiscountRate = @DiscountRate,
                Summary = @Summary,
                Content = @Content
            WHERE ProductID = @ProductID";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", id);
                    cmd.Parameters.AddWithValue("@ProductName", name);
                    cmd.Parameters.AddWithValue("@OriginalPrice", originalPrice);
                    cmd.Parameters.AddWithValue("@SalePrice", salePrice);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Stock", stock);
                    cmd.Parameters.AddWithValue("@Discontinued", discontinued);
                    cmd.Parameters.AddWithValue("@CategoryID", (object)categoryId ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DiscountRate", (object)discountRate ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Summary", (object)summary ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Content", (object)content ?? DBNull.Value);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }


        public bool DeleteProduct(int productId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string deletePhotosSql = "DELETE FROM ShopProductPhoto WHERE ProductID = @ProductID";
                    SqlCommand cmdDeletePhotos = new SqlCommand(deletePhotosSql, conn, transaction);
                    cmdDeletePhotos.Parameters.AddWithValue("@ProductID", productId);
                    cmdDeletePhotos.ExecuteNonQuery();

                    string deleteProductSql = "DELETE FROM ShopProducts WHERE ProductID = @ProductID";
                    SqlCommand cmdDeleteProduct = new SqlCommand(deleteProductSql, conn, transaction);
                    cmdDeleteProduct.Parameters.AddWithValue("@ProductID", productId);
                    int affected = cmdDeleteProduct.ExecuteNonQuery();

                    transaction.Commit();
                    return affected > 0;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("刪除失敗：" + ex.Message);
                    return false;
                }
            }
        }
    }
}
