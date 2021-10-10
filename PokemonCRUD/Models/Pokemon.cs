using System;
using System.ComponentModel.DataAnnotations;

namespace PokemonCRUD.Models
{
    public class Pokemon
    {
        public int Id { get; set; }

        [Range(1, 1000)]
        [DataType(DataType.Currency)]
        [Required]
        public int IdPokedex { get; set; }

        [StringLength(30, MinimumLength = 2)]
        [Required]
        public string Name { get; set; }

        [StringLength(12, MinimumLength = 3)]
        [Required]
        public string Type1 { get; set; }

        [StringLength(12, MinimumLength = 3)]
        [Required]
        public string Type2 { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Required]
        public int Evolution { get; set; }
    }
}