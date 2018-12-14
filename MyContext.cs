using Microsoft.EntityFrameworkCore;
using EntityFrameworkCore.Models;

namespace EntityFrameworkCore
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        public DbSet<UserModel> Users { get; set; }
    }
}