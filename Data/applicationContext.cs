using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using demomvc.Models;

    public class applicationContext : DbContext
    {
        public applicationContext (DbContextOptions<applicationContext> options)
            : base(options)
        {
        }

        public DbSet<demomvc.Models.Movie> Movie { get; set; }

        public DbSet<demomvc.Models.Person> Person { get; set; }
    }
