using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Text;

namespace ClassLibrary1
{
    public class Team
    {
        public ICollection<Speler> Spelers = new List<Speler>();
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Stamnummer { get; set; }
        public string TrainerNaam { get; set; }
        public string Naam { get; set; }
        public string Bijnaam { get; set; }
    }
}
