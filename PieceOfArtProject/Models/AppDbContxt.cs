using Microsoft.EntityFrameworkCore;

namespace PieceOfArtProject.Models
{
    public class AppDbContxt : DbContext
    {
        public AppDbContxt(DbContextOptions <AppDbContxt> options) : base(options)
        {


        }

        public DbSet<Cutomer> cutomers { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<LoyaltyCard> loyaltyCards { get; set; }

        public DbSet<ArtPiece> artPieces { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cutomer>().HasData(
                new Cutomer { 
                Id = 1,
                Email="Mohamed@gmail.com",
                Name="mohamed",
                Phone ="01202320516"
                },
                new Cutomer { 
                Id=2,
                Email="omar@Gmail.com",
                Name ="Omar",
                Phone="01125774400"
                
                
                }

                
                //modather
                );
            modelBuilder.Entity<ArtPiece>().HasData(new ArtPiece {
            
            
            });

            modelBuilder.Entity<Cutomer>()
                .HasOne(o => o.LoyaltyCard)
                .WithOne(a => a.Customer)
                .HasForeignKey<LoyaltyCard>(a => a.CustomerId);
            modelBuilder.Entity<Category>().HasMany(v => v.ArtPiece).WithMany(g => g.Categories);

            modelBuilder.Entity<Cutomer>().HasMany(v => v.ArtPieces).WithOne(n => n.Customer).HasForeignKey(r => r.CustomerId);


        }
        
        




    }
}
