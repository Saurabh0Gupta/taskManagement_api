using Microsoft.EntityFrameworkCore;
namespace taskManagement_api.DataModel
{
    public class taskDbContext : DbContext
    {
        //setup db context
        public taskDbContext(DbContextOptions<taskDbContext> options) : base(options)
        {
        }

    }
}
