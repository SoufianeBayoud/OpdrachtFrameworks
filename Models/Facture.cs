using System;
using System.ComponentModel.DataAnnotations;

namespace OpdrachtFrameworks.Models
{
    public class Facture
    {
        public int id { get; set; }
        [Display(Name = "Name")]
        public string naam { get; set; }
        public int prijs { get; set; }
        public bool diseappear { get; set; }

    }
}
