using System.Data.Entity;
using System.Linq;
using MyCricket.Domain;
using MyCricket.Domain.Repositories;

namespace MyCricket.WebAPI.Repositories
{
    public class TeamRepository : RepositoryBase, ITeamRepository
    {
        public DbSet<Team> Teams { get; set; }
 
        public Team[] GetAllTeams()
        {
            return Teams.ToArray();
        }

        public Team[] GetAllCurrentTeams()
        {
            return Teams.Where(x => x.CurrentRecord).ToArray();
        }

        public Team GetTeam(int teamId)
        {
            return Teams.Single(x => x.Id == teamId);
        }

        public Team Add(Team team)
        {
            return Teams.Add(team);
        }

        public void Save()
        {
            SaveChanges();
        }

        public void Remove(Team team)
        {
            Teams.Remove(team);
        }
    }
}