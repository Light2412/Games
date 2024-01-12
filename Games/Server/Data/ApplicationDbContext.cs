using Duende.IdentityServer.EntityFramework.Options;
using Games.Server.Models;
using Games.Shared.Domain;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Games.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Staff> Staff { get; set;}
        public DbSet<Order> Orders { get; set; }
    }
}