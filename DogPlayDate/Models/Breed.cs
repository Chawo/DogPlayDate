using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DogPlayDate.Models
{
    public class Breed
    {
        public int BreedId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}