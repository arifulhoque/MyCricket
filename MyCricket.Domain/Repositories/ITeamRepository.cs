using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCricket.Domain.Repositories
{
    public interface ITeamRepository
    {
        Team[] GetAllTeams();
        Team[] GetAllCurrentTeams();
        Team GetTeam(int teamId);
        Team Add(Team team);
        void Remove(Team team);
        void Save();
    }
}
