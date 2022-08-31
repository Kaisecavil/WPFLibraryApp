using Microsoft.EntityFrameworkCore;
using NovikovWPFLibraryApp.Models;
using System.Configuration;

namespace NovikovWPFLibraryApp.Repository
{
    /// <summary>
    /// Class that servse to get Data base context
    /// </summary>
    internal class ApplicationContext : DbContext
    {
        /// <summary>
        /// DbSet (Table) that contains entities of <seealso cref="Book"/> type.
        /// </summary>
        public DbSet<Book> Books => Set<Book>();

        /// <summary>
        /// Constructor that ensures that data base is exist
        /// </summary>
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.AppSettings["connectionString"]);
        }

    }
}
