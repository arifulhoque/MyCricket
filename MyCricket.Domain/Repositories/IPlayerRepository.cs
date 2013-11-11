using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCricket.Domain.Repositories
{
    public interface IPlayerRepository
    {
        Player[] GetAllPlayers();
        Player[] GetAllPlayers(Team team);
        Player GetPlayer(int playerId);
        Player Add(Team team, Player player);
        void Remove(Team team, Player player);
        void Save();
    }
}
