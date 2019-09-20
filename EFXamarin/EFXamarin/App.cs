using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Xamarin.Forms;

namespace EFXamarin
{
    public class App : Application
    {
        public App(string dbPath)
        {
            List<Blog> itemSource;

            // Create Database & Tables
            using (var db = new DatabaseContext(dbPath))
            {
                // Ensure database is created
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
Profiler.Start("insert");
                // Insert Data
                for (int i = 1; i < 101; i++)
                {
                    db.Add(new Blog() { BlogId = i, Rating = 5, Url = Guid.NewGuid().ToString() });    
                }
                
//                db.Add(new Blog() { BlogId = 2, Rating = 5, Url = "https://xamarinhelp.com" });
//                db.Add(new Blog() { BlogId = 3, Rating = 5, Url = "https://azuremobilehelp.com" });
                db.SaveChanges();
Profiler.Stop("insert");
Profiler.Start("retrieve");
                // Retreive Data
                itemSource = db.Blogs.ToList();
                Profiler.Stop("retrieve");
            }

            // Show Data
            MainPage = new ContentPage()
            {
                Content = new ListView()
                {
                    ItemsSource = itemSource
                }
            };

        }
    }

    public class DatabaseContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        private string _databasePath;

        public DatabaseContext(string databasePath)
        {
            _databasePath = databasePath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_databasePath}");
        }
    }

    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Url { get; set; }
        public int Rating { get; set; }

        public override string ToString()
        {
            return Url;
        }
    }
}
