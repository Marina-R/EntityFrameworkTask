using System.Data.Entity;
using EFTask.Models;

namespace EFTask.DAL
{
    public class UserContext : DbContext
    {
        public UserContext() : base("UserContext")
        {
        }
        public DbSet<User> Users { get; set; }
    }
}