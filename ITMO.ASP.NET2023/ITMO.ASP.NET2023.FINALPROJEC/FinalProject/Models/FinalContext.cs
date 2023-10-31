using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace FinalProject.Models
{
    public class FinalContext : DbContext
    {

        public FinalContext(DbContextOptions<FinalContext> options)
        : base(options)
        { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}