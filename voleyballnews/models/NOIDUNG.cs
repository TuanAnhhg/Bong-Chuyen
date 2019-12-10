using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace voleyballnews.models
{
    public class NOIDUNG : DbContext
    {
        public  NOIDUNG() : base("voleyballnews")
        { }
        public DbSet<TACGIA> Categories { get; set; }
        public DbSet<tintuc> tintuc { get; set; }
    }
}