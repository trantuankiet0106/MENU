using MENU.Model;
using Microsoft.EntityFrameworkCore;


namespace MENU
{
    public class MenuDbContext : DbContext
    {

        public MenuDbContext(DbContextOptions options) : base(options)
        { 
        }
        public DbSet<MenuItems> MenuItems { get; set; }
    }
}


