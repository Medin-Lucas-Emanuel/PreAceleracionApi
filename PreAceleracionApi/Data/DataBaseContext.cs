using Microsoft.EntityFrameworkCore;
using PreAceleracionApi.Entidades;

namespace PreAceleracionApi.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext( DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        //Entidades 

        public DbSet<Users> User { get; set; }
        public DbSet<Posts> Post { get; set; }
        public DbSet<Comments> Comment { get; set; }
    }
}
