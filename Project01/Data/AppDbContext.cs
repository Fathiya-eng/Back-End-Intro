using Microsoft.EntityFrameworkCore;
using Project01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01.Data
{
    public class AppDbContext: DbContext
    {
        public DbSet<Student> students {  get; set; }
        public DbSet<Departments> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database= EFCoreDB; Trusted_Connection= True; TrustServerCertificate= True;");
        }
    }
}
