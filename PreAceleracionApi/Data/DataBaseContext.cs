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

        public DbSet<Users> Users { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Comments> Comments { get; set; }
    }
}
