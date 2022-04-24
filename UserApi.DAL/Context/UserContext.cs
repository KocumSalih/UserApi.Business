using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UserApi.DAL.Context
{
    using UserApi.DAL.Context.Configuration;
    using UserApi.Entities;
    public class UserContext :DbContext
    {
        public UserContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
