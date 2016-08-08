using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Summary description for BudayaContext
/// </summary>

namespace DataBudaya.Models
{
    public class BudayaContext : DbContext
    {
        public BudayaContext() : base("name=PES17Entities")
        {
        }

        public DbSet<Budaya> budayas { get; set; }
    }
}