using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DataLayer
{
    public class PageGroupRepository : IPageGroupRepository
    {
        MyCmsContext db = new MyCmsContext();

        public IEnumerable<PageGroup> GetAllGroups()
        {
            return db.PageGroups;
        }

        public PageGroup GetGroupById(int groupId)
        {
            return db.PageGroups.Find(groupId);
        }

        public bool InserGroup(PageGroup pageGroup)
        {
            try
            {
                db.PageGroups.Add(pageGroup);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool UpdateGroup(PageGroup pageGroup)
        {
            try
            {
                db.Entry(pageGroup).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool DeleteGroup(PageGroup pageGroup)
        {
            try
            {
                db.Entry(pageGroup).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteGroup(int groupId)
        {
            try
            {
                var group = GetGroupById(groupId);
                DeleteGroup(group);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }


    }
}
