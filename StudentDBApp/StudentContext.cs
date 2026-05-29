using System.Data.Entity;

namespace StudentDBApp
{
    internal class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
