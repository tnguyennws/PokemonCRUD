using System;
using System.ComponentModel.DataAnnotations;

namespace PokemonCRUD.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public int IdPokedex { get; set; }
        public string Name { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public int Evolution { get; set; }
    }
}