using Microsoft.EntityFrameworkCore;
using Student_Management_Ststem.Models;

namespace Student_Management_Ststem.Data
{
    public class ApplicationDB:DbContext
    {
        public ApplicationDB(DbContextOptions<ApplicationDB> options) : base(options)
        {
        }
       public DbSet<Student> Students { get; set; }
    }
}
