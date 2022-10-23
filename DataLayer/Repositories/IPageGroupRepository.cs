using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public interface IPageGroupRepository
    {
        IEnumerable<PageGroup> GetAllGroups();
        PageGroup GetGroupById(int groupId);
        bool InserGroup(PageGroup pageGroup);
        bool UpdateGroup(PageGroup pageGroup);
        bool DeleteGroup(PageGroup pageGroup);
        bool DeleteGroup(int groupId);
        void Save();
    }
}
