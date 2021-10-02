using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataBaseFirstApproach.Models
{
    public class LibraryContext :DbContext
    {
        public DbSet<Library>library { get; set; }
    }
}