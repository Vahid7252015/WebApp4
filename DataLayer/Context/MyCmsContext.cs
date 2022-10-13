using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class MyCmsContext:DbContext
    {
        public MyCmsContext(DbContextOptions<MyCmsContext> option) : base(option)
        {

        }
        public DbSet<PageGroup> PageGroups { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<PageComment> PageComments { get; set; }
    }
}
