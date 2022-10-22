using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kutuphane.Data
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        public string Link { get; set; }
        
        public int ReadID { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public virtual Read Read { get; set; }
    }
    public class Category {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books {get;set;}
    }
    
    public class Read
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
    public class BookDBInitializer: CreateDatabaseIfNotExists<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            IList<Category> defaultCategories = new List<Category>
        {
            new Category() { Name = "Roman"},
            new Category() { Name = "Kişisel Gelişim"},
            new Category() { Name = "Bilgisayar"},
            new Category() { Name = "Kültür"},
            new Category() { Name = "Tarih"},
            new Category() { Name = "Felsefe"},
            new Category() { Name = "Bilim"},
            new Category() { Name = "Edebiyat"}
        };
            IList<Read> Readings = new List<Read>
        {
            new Read() { Name = "Okundu"},
            new Read() { Name = "Okunmadı"},
            new Read() { Name = "Okunuyor"},
            new Read() { Name = "Alındı ama okunmadı"}


        };
            context.Reads.AddRange(Readings);
            context.Categories.AddRange(defaultCategories);
            base.Seed(context);
        }


    }
    public class BookContext: DbContext
    {
        public BookContext():base("name=Kutuphane")
        {
            Database.SetInitializer(new BookDBInitializer());
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Read> Reads { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here
            modelBuilder.Entity<Category>()
                .Property(p => p.Name)
                .IsRequired().HasMaxLength(100);

            modelBuilder.Entity<Book>()
            .Property(p => p.Name)
            .IsRequired().HasMaxLength(255);
        }

    }
}