using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OpdrachtFrameworks.Models;

namespace OpdrachtFrameworks.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<OpdrachtFrameworks.Models.Immo> Immo { get; set; }
        public DbSet<OpdrachtFrameworks.Models.Klant> Klant { get; set; }
        public DbSet<OpdrachtFrameworks.Models.Facture> Facture { get; set; }
    }
}