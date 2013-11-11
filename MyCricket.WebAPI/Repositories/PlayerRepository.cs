using System;
using System.Data.Entity;
using System.Linq;
using MyCricket.Domain;
using MyCricket.Domain.Repositories;

namespace MyCricket.WebAPI.Repositories
{
    public class PlayerRepository : RepositoryBase, IPlayerRepository
    {
        public DbSet<Player> Players { get; set; }

        public Player[] GetAllPlayers()
        {
            return Players.ToArray();
        }

        public Player GetPlayer(int playerId)
        {
            return Players.Single(p => p.Id == playerId);
        }

        public void Remove(Team team, Player player)
        {
            team.Players.Remove(player);
        }

        public void Save()
        {
            SaveChanges();
        }

        public Player[] GetAllPlayers(Team team)
        {
            return team.Players.ToArray();
        }

        public Player Add(Team team, Player player)
        {
            team.Players.Add(player);
            return player;
        }
    }
}