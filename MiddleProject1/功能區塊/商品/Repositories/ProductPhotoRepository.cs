using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiddleProject1.功能區塊.商品.Repositories
{
    public class ProductPhotoRepository
    {
        private readonly string connectionString = DBHelper.GetConnectionString();

        public bool InsertPhoto(int productId, byte[] thumbPhoto, string thumbName, byte[] largePhoto, string largeName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // 確保資料完整性：先刪除原圖
                    string deleteSql = "DELETE FROM ShopProductPhoto WHERE ProductID = @ProductID";
                    using (SqlCommand deleteCmd = new SqlCommand(deleteSql, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@ProductID", productId);
                        deleteCmd.ExecuteNonQuery();
                    }

                    // 寫入圖片資料（使用 varbinary 格式）
                    string insertSql = @"
                        INSERT INTO ShopProductPhoto 
                        (ProductID, ThumbnailPhoto, ThumbnailPhotoFileName, LargePhoto, LargePhotoFileName, ModifiedDate)
                        VALUES 
                        (@ProductID, @ThumbPhoto, @ThumbName, @LargePhoto, @LargeName, GETDATE())";

                    using (SqlCommand insertCmd = new SqlCommand(insertSql, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@ProductID", productId);
                        insertCmd.Parameters.AddWithValue("@ThumbPhoto", (object)thumbPhoto ?? DBNull.Value);
                        insertCmd.Parameters.AddWithValue("@ThumbName", (object)thumbName ?? DBNull.Value);
                        insertCmd.Parameters.AddWithValue("@LargePhoto", (object)largePhoto ?? DBNull.Value);
                        insertCmd.Parameters.AddWithValue("@LargeName", (object)largeName ?? DBNull.Value);

                        int affectedRows = insertCmd.ExecuteNonQuery();
                        return affectedRows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("圖片儲存失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public byte[] GetPhotoByProductId(int productId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "SELECT LargePhoto FROM ShopProductPhoto WHERE ProductID = @ProductID";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productId);
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        return (result != DBNull.Value && result != null) ? (byte[])result : null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("圖片讀取失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public byte[] GetThumbnailByProductId(int productId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "SELECT ThumbnailPhoto FROM ShopProductPhoto WHERE ProductID = @ProductID";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productId);
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        return (result != DBNull.Value && result != null) ? (byte[])result : null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("縮圖讀取失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
