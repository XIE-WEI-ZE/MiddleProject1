using System.Data;

namespace MiddleProject1.功能區塊.商品.類別.Repositories
{
    public interface ICategoryRepository
    {
        DataTable GetAllCategories();
        bool InsertCategory(string name, string description);
        bool UpdateCategory(long id, string name, string description);
        bool DeleteCategory(long id);
    }
}
