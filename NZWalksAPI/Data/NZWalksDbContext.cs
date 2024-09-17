using Microsoft.EntityFrameworkCore;
using NZWalksAPI.Models.Domain;

namespace NZWalksAPI.Data
{
    public class NZWalksDbContext : DbContext 
    {
        public NZWalksDbContext(DbContextOptions dbContextOption) : base(dbContextOption)
            
        {
            
        }
        
        // Here we create our Table for each entity.

        public DbSet<Difficulty> Difficulties {  get; set; }

        public DbSet<Region> Region { get; set; }

        public DbSet<Walks> Walks { get; set; }

        // Here we do the Db migration..
        // checking the github is working properly or not.
    }
}
