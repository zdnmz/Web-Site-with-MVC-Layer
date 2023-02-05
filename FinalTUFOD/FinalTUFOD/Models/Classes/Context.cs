using System.Data.Entity;

namespace FinalTUFOD.Models.Classes
{
    public class Context : DbContext
    {
        public DbSet<AdminPage> Admins { get; set; }
        public DbSet<HomePage> HomePages { get; set; }
        public DbSet<Icons> icons { get; set; }
    }
}