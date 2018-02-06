using Microsoft.EntityFrameworkCore;
using SSDepartmentCore.Data.EntityModels;

namespace SSDepartmentCore.Data
{
    // creating the first relationship with the database using EF
    // where DbContext serves as the database while Dbsets represents tables in the database.
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<Visitor> Visitors { get; set; }
    }
}
