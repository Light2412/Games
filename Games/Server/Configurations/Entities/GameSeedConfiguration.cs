using Games.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Games.Server.Configurations.Entities
{
    public class GameSeedConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasData(
                new Game
                {
                    Id = 1,
                    Title = "League Of Legends",
                    Genre = "Strategy",
                    AgeGroup = "Teenagers",
                    Description = "5v5 team-based multiplayer strategy game where two teams battle out to destroy the other enemy's base.",
                    Price = 50,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Game
                {
                    Id = 2,
                    Title = "Assassin's Creed",
                    Genre = "Adventure",
                    AgeGroup = "Adults",
                    Description = "Action-adventure, open-world and stealth game. The gameplay revolves around combat, stealth and exploration, including the use of parkour to navigate the environment.",
                    Price = 85,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                );
                    
        }
    }
}
