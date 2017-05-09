using Microsoft.EntityFrameworkCore;
using Scacchi.Modello;

namespace Scacchi.Servizi{
<<<<<<< HEAD
    public class Database : DbContext{
         public Database() : base()
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Mossa> Mossa {get;set;}
=======
    public class DataBase : DbContext{
        public DataBase() : base()
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Mossa> Mosse {get;set;}
>>>>>>> upstream/master
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
             optionsBuilder.UseSqlite(@"Data Source=..\..\..\Database.db");
         }
         protected override void OnModelCreating(ModelBuilder modelBuilder) {
<<<<<<< HEAD
             modelBuilder.Entity<Mossa>().ToTable("Mossa").HasKey(p => p.IDMossa);
         }
=======
             modelBuilder.Entity<Mossa>().ToTable("Mosse").HasKey(p => p.IdMossa);
         } 
>>>>>>> upstream/master
    }
}