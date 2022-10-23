﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class PageRepository : IPageRepository
    {
        MyCmsContext db=new MyCmsContext();
        public IEnumerable<Page> GetAllPage()
        {
            return db.Pages;
        }

        public Page GetPageById(int pageId)
        {
            return db.Pages.Find(pageId);
        }

        public bool InserPage(Page page)
        {
            try
            {
                db.Pages.Add(page);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool UpdatePage(Page page)
        {
            try
            {
                db.Entry(page).State=EntityState.Modified;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool DeletePage(Page page)
        {
            try
            {
                db.Entry(page).State=EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeletePage(int pageId)
        {
            try
            {
                var page = GetPageById(pageId);
                DeletePage(page);
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
