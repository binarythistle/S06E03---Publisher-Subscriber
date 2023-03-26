using MessageBroker.Models;
using Microsoft.EntityFrameworkCore;

namespace MessageBroker.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Topic> Topics => Set<Topic>();
        public DbSet<Subscription> Subscriptions => Set<Subscription>();
        public DbSet<Message> Messages => Set<Message>();
    }
}