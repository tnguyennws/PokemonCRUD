using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokemonCRUD.Models;

namespace PokemonCRUD.Data
{
    public class PokemonCRUDContext : DbContext
    {
        public PokemonCRUDContext (DbContextOptions<PokemonCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<PokemonCRUD.Models.Pokemon> Pokemon { get; set; }
    }
}
