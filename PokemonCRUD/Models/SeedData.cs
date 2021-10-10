using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PokemonCRUD.Data;
using System;
using System.Linq;

namespace PokemonCRUD.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PokemonCRUDContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PokemonCRUDContext>>()))
            {
                // Look for any movies.
                if (context.Pokemon.Any())
                {
                    return;   // DB has been seeded
                }

                context.Pokemon.AddRange(
                    new Pokemon
                    {
                        IdPokedex = 1,
                        Name = "Bulbizarre",
                        Type1 = "Plante",
                        Type2 = "Poison",
                        Evolution = 16
                    },

                    new Pokemon
                    {
                        IdPokedex = 2,
                        Name = "Herbizarre",
                        Type1 = "Plante",
                        Type2 = "Poison",
                        Evolution = 32
                    },

                    new Pokemon
                    {
                        IdPokedex = 3,
                        Name = "Florizarre",
                        Type1 = "Plante",
                        Type2 = "Poison",
                        Evolution = 0
                    },

                    new Pokemon
                    {
                        IdPokedex = 4,
                        Name = "Salamèche",
                        Type1 = "Feu",
                        Type2 = "Aucun",
                        Evolution = 16
                    },

                    new Pokemon
                    {
                        IdPokedex = 5,
                        Name = "Reptincel",
                        Type1 = "Feu",
                        Type2 = "Aucun",
                        Evolution = 36
                    },

                    new Pokemon
                    {
                        IdPokedex = 6,
                        Name = "Dracaufeu",
                        Type1 = "Feu",
                        Type2 = "Vol",
                        Evolution = 0
                    }
                );
                context.SaveChanges();
            }
        }
    }
}