using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleProject1.功能區塊.商品.Repositories
{
    public interface IProductRepository
    {
        DataTable GetAllProducts();

        int InsertProduct(string name, int originalPrice, int salePrice,
            int quantity, int stock, bool discontinued, long? categoryId,
            decimal? discountRate, string summary, string content);

        bool UpdateProduct(int id, string name, int originalPrice, int salePrice,
            int quantity, int stock, bool discontinued, long? categoryId,
            decimal? discountRate, string summary, string content);

        bool DeleteProduct(int productId);
    }

}


