using ClassLibrary1;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Speler speler = new Speler();
            speler.Naam = "John";
            speler.Rugnummer = 69;
            speler.TransferWaarde = 2.30;

            Team team1 = new Team();
            team1.Naam = "de winners";
            team1.Spelers.Add(speler);
            team1.Stamnummer = 5;
            team1.TrainerNaam = "Greg";
            team1.Bijnaam = "de bijna-winners";

            Team team2 = new Team();
            team2.Naam = "de naamlozen";
            team2.Stamnummer = 1;
            team2.TrainerNaam = "Frodo";
            team2.Bijnaam = "de gebrekkige inspiratie";

            Transfer transfer = new Transfer();
            transfer.speler = speler;
            transfer.OudTeam = team1;
            transfer.NieuwTeam = team2;
            transfer.Prijs = speler.TransferWaarde;

            TeamManager tm = new TeamManager();
            tm.VoegSpelerToe(speler);
            tm.VoegTeamToe(team1);
            tm.VoegTeamToe(team2);
            tm.VoegTransferToe(transfer);
        }
    }
}
