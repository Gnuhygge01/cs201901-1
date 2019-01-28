namespace EFDemo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PersonModel : DbContext
    {
        public PersonModel()
            : base("name=PersonModel")
        {
            Database.Log = Console.WriteLine;
        }

        public virtual DbSet<Person> Personer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Property(e => e.Navn)
                .IsUnicode(false);
        }
    }
}
