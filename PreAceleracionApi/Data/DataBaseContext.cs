using Microsoft.EntityFrameworkCore;

namespace PreAceleracionApi.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext( DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
    }
}
