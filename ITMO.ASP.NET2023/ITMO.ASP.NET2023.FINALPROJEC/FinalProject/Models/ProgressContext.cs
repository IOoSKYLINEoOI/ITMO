using Microsoft.EntityFrameworkCore;
using FinalProject.Models;
using Microsoft.AspNetCore.Components.Forms;
using System.Security.Cryptography;

namespace FinalProject.Models
{
    public class ProgressContext : DbContext
    {
        public ProgressContext(DbContextOptions<ProgressContext> options) : base(options) { }

        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }
    }

}
