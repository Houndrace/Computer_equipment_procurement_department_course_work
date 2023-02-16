using PurchasingDepartment.Models.DataBase;
using System.Data.Entity;

namespace PurchasingDepartment.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base("DefaultConnection") { }

        public DbSet<User> Users { get; set; }
    }
}
