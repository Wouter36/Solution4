using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Transfer
    {
        public int Id { get; set; }
        public Speler speler { get; set; }
        public Team OudTeam { get; set; }
        public Team NieuwTeam { get; set; }
        public double Prijs { get; set; }
    }
}
