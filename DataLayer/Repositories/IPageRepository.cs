using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public interface IPageRepository
    {
        IEnumerable<Page> GetAllPage();
        Page GetPageById(int pageId);
        bool InserPage(Page page);
        bool UpdatePage(Page page);
        bool DeletePage(Page page);
        bool DeletePage(int pageId);
        void Save();
    }
}
