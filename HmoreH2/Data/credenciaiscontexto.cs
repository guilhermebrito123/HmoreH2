using HmoreH2.Models;
using Microsoft.EntityFrameworkCore;
namespace HmoreH2.Data
{
    public class credenciaiscontexto : DbContext
    {
        public credenciaiscontexto(DbContextOptions<credenciaiscontexto> options) : base(options)
        {

        }
        public DbSet<Clientes> Cliente { get; set; }
    }
}
