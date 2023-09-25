using Microsoft.EntityFrameworkCore;

namespace datakodTask_v2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
