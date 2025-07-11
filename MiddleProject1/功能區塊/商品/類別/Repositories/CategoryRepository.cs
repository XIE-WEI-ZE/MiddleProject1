﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using MiddleProject1.功能區塊.商品.類別.Repositories;

namespace MiddleProject1.功能區塊.商品.類別.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly string connectionString = DBHelper.GetConnectionString();

        public DataTable GetAllCategories()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                    SELECT 
                        CategoryID, 
                        CategoryName, 
                        Description 
                    FROM ShopCategories";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public bool InsertCategory(string name, string description)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                    INSERT INTO ShopCategories (CategoryName, Description) 
                    VALUES (@Name, @Description)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Description", (object)description ?? DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateCategory(long id, string name, string description)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                    UPDATE ShopCategories 
                    SET CategoryName = @Name, 
                        Description = @Description 
                    WHERE CategoryID = @ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Description", (object)description ?? DBNull.Value);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteCategory(long id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM ShopCategories WHERE CategoryID = @ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", id);

                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // 外鍵限制錯誤
                    {
                        //throw new Exception("無法刪除該分類，因為仍有商品屬於此分類。請先移除或修改這些商品。");
                        MessageBox.Show("無法刪除該分類，因為仍有商品屬於此分類。請先移除或修改這些商品。");
                    }

                    throw new Exception("刪除類別時發生錯誤：" + ex.Message);
                    //MessageBox.Show("刪除類別時發生錯誤：" + ex.Message);
                }
            }
        }
    }
}
