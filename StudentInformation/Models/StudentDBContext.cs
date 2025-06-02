using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace StudentInformation.Models
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
