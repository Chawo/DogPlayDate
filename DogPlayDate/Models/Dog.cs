using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DogPlayDate.Models
{
    public class Dog
    {
        public int DogId { get; set; }
        [Required]
        public ApplicationUser DogOwner { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime DateBirth { get; set; }
        public string Description { get; set; }
        public bool Castrated { get; set; }
        public Gender Gender { get; set; }

        [Required]
        public Breed BreedName { get; set; }

    }

    public enum Gender
    {
        Male = 1,
        Female = 2
    }
}