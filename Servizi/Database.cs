using Microsoft.EntityFrameworkCore;
using Scacchi.Modello;

namespace Scacchi.Servizi{
    public class Database : DbContext{
         public Database() : base()
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Mossa> Mossa {get;set;}
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
             optionsBuilder.UseSqlite(@"Data Source=..\..\..\Database.db");
         }
         protected override void OnModelCreating(ModelBuilder modelBuilder) {
             modelBuilder.Entity<Mossa>().ToTable("Mossa").HasKey(p => p.IDMossa);
         }
    }
}