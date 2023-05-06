using System.Data.Entity;

namespace EFCodeFirst.Entities
{
    internal class SchoolContext : DbContext
    {
        public SchoolContext() : base() { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }    
    }
}
