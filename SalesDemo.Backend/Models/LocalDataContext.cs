using SalesDemo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesDemo.Backend.Models
{
    public class LocalDataContext: DataContext
    {
        public System.Data.Entity.DbSet<SalesDemo.Common.Models.Product> Products { get; set; }
    }
}