using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{
    public class ApplicationDbContext : DbContext
    {

        /// <summary>
        /// This method will receive "options" and send it to base DbContext
        /// </summary>
        /// <param name="options"></param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }


        /// <summary>
        /// This will create the table
        /// </summary>
        public DbSet<Category> Categories { get; set; }
    }
}
