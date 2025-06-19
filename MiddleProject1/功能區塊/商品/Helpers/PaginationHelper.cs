using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleProject1.功能區塊.商品.Helpers
{
    public class PaginationHelper
    {
        public int CurrentPage { get; private set; } = 1;
        public int PageSize { get; private set; }
        public int TotalItems { get; private set; }
        public int TotalPages => (int)Math.Ceiling((double)TotalItems / PageSize);

        public PaginationHelper(int totalItems, int pageSize)
        {
            TotalItems = totalItems;
            PageSize = pageSize;
        }

        public void GoToPage(int page)
        {
            if (page < 1) page = 1;
            if (page > TotalPages) page = TotalPages;
            CurrentPage = page;
        }

        public int GetStartIndex()
        {
            return (CurrentPage - 1) * PageSize;
        }

        public int GetPageSize()
        {
            return PageSize;
        }

        public void NextPage() => GoToPage(CurrentPage + 1);
        public void PreviousPage() => GoToPage(CurrentPage - 1);
    }
}
