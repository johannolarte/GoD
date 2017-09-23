using GoD.WebApi.Core.Models;
using System.Data.Entity;

namespace GoD.WebApi.Persistence
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Player> Players { get; set; }

        public ApplicationContext() : base("ApplicationDbContext")
        {
            SetConfiguration();
        }

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }

        private void SetConfiguration()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Configuration.AutoDetectChangesEnabled = true;
            Configuration.ValidateOnSaveEnabled = false;
        }
    }
}