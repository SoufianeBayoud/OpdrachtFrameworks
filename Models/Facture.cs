using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OpdrachtFrameworks.Models
{
    public class Facture
    {
        public int id { get; set; }
        [Display(Name = "Name")]
        public string naam { get; set; }
        public int prijs { get; set; }
        public bool diseappear { get; set; } = false;

        [ForeignKey("id")]
        public Klant? klant { get; set; }
        [ForeignKey("id")]
        public Immo? immo { get; set; }

    }
}
