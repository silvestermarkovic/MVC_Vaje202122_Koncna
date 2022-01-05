using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Vaje202122_Priprava.Models;

namespace MVC_Vaje202122_Priprava.Data
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Kategorija> Kategorije { get; set; }

        //za vsako kategorijo je potrebno ustvariti svoj DbSet

    }
}
