using Microsoft.EntityFrameworkCore;
using projetiot.Models;

namespace projetiot.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        { 
        }

        public virtual  DbSet<IOTdata> IOTdatas { get; set; }


    }
}
