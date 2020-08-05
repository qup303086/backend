namespace backend.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<dealers_area> dealers_area { get; set; }
        public virtual DbSet<dealers_country> dealers_country { get; set; }
        public virtual DbSet<dealers_distributor> dealers_distributor { get; set; }
        public virtual DbSet<news> news { get; set; }
        public virtual DbSet<registered> registered { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<yachts> yachts { get; set; }
        public virtual DbSet<yachts_Album> yachts_Album { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<dealers_area>()
                .HasMany(e => e.dealers_distributor)
                .WithRequired(e => e.dealers_area)
                .HasForeignKey(e => e.areaid);

            modelBuilder.Entity<dealers_country>()
                .HasMany(e => e.dealers_area)
                .WithRequired(e => e.dealers_country)
                .HasForeignKey(e => e.countryid);
        }
    }
}
