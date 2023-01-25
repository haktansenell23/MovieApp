using Microsoft.EntityFrameworkCore;
using MovieApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Repository
{
    public class MovieAppDbContext : DbContext

    {
        public MovieAppDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Category> categories { get; set; }
        DbSet<Film> films { get; set; }
        DbSet<User> users { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


        }



    }
}
