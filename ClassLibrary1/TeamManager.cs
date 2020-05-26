using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class TeamManager
    {
        TeamsContext ctx = new TeamsContext();
        public void VoegTeamToe(Team team)
        {
            ctx.Teams.Add(team);
            ctx.SaveChanges();
        }

        public void VoegSpelerToe(Speler speler)
        {
            ctx.Spelers.Add(speler);
            ctx.SaveChanges();
        }

        public void VoegTransferToe(Transfer transfer)
        {
            Team t1 = ctx.Teams.Find(transfer.OudTeam.Stamnummer);
            t1.Spelers.Remove(transfer.speler);
            Team t2 = ctx.Teams.Find(transfer.NieuwTeam.Stamnummer);
            t2.Spelers.Add(transfer.speler);
            ctx.Transfers.Add(transfer);
            ctx.SaveChanges();
        }

        public void UpdateTeam(Team team)
        {
            Team t = ctx.Teams.Find(team.Stamnummer);
            t.Spelers = team.Spelers;
            t.Naam = team.Naam;
            t.TrainerNaam = team.TrainerNaam;
            t.Bijnaam = team.Bijnaam;
            ctx.SaveChanges();
        }

        public void UpdateSpeler(Speler speler)
        {
            Speler s = ctx.Spelers.Find(speler.Id);
            s.Naam = speler.Naam;
            s.Rugnummer = speler.Rugnummer;
            s.TransferWaarde = speler.TransferWaarde;
            ctx.SaveChanges();
        }

        public Speler SelecteerSpeler(int spelerId)
        {
            return ctx.Spelers.Find(spelerId);
        }

        public Team SelecteerTeam(int stamNummer)
        {
            return ctx.Teams.Find(stamNummer);
        }

        public Transfer SelecteerTransfer(int transferId)
        {
            return ctx.Transfers.Find(transferId);
        }
    }
}
