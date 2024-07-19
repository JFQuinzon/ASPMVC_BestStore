using BestStoreMVCwithSQLSERVER.Models;
using Microsoft.EntityFrameworkCore;

namespace BestStoreMVCwithSQLSERVER.Services
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
