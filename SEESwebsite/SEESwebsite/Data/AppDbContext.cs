using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SEESwebsite.Models;

namespace SEESwebsite.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<IncidentReport> IncidentReports { get; set; }
    }
}
