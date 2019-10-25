using Microsoft.EntityFrameworkCore;

namespace TallerASPNET.Models
{
    public class TallerContext : DbContext 
    {
        public TallerContext (DbContextOptions<TallerContext> options) : base(options){}

        public DbSet<Participante> Participante { get; set; }
    }
}