using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DatabaseManager
{
    public partial class ModelAscon : DbContext
    {
        public ModelAscon()
            : base("name=LocalModelAscon")
        {
            
        }

        public void CreateDatabase()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<ModelAscon>());
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Data> Data { get; set; }
        public virtual DbSet<Recepients> Recepients { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>()
                .HasMany(e => e.Data)
                .WithRequired(e => e.Categories)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Recepients>()
                .HasMany(e => e.Data)
                .WithRequired(e => e.Recepients)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Data)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);
        }
    }
}
