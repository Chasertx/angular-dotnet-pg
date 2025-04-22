using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Playground.Models;

namespace Playground.Data{
    
    public class AppDbContext : DbContext{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        //table definitions (dbsets)
        public DbSet<Project> Projects {get; set;}
    }
}