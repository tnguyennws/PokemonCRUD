using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace PokemonCRUD.Models
{
    public class PokemonType1ViewModel
    {
        public List<Pokemon> Pokemons { get; set; }
        public SelectList Type1 { get; set; }
        public string PokemonType1 { get; set; }
        public string SearchString { get; set; }
    }
}