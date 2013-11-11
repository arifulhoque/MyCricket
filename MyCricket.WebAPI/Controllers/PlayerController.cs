using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyCricket.Domain;
using MyCricket.Domain.Repositories;

namespace MyCricket.WebAPI.Controllers
{
    public class PlayerController : ApiController
    {
        protected readonly IPlayerRepository PlayerRepository;
        protected readonly ITeamRepository TeamRepository;

        public PlayerController(IPlayerRepository playerRepository, ITeamRepository teamRepository)
        {
            PlayerRepository = playerRepository;
            TeamRepository = teamRepository;
        }

        // GET api/player
        public IEnumerable<Player> GetAllPlayers()
        {
            return PlayerRepository.GetAllPlayers();
        }

        public IEnumerable<Player> GetPlayersForATeam(int teamId)
        {
            Team team = TeamRepository.GetTeam(teamId);
            if (team == null)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));

            return team.Players;
        }

        // GET api/player/5
        public Player Get(int id)
        {
            return PlayerRepository.GetPlayer(id);
        }

        // POST api/player
        public HttpResponseMessage Post([FromBody]int teamId, Player player)
        {
            Team team = TeamRepository.GetTeam(teamId);
            if (team == null)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            player = PlayerRepository.Add(team, player);
            PlayerRepository.Save();

            HttpResponseMessage response = Request.CreateResponse<Player>(HttpStatusCode.Created, player);
            string uri = Url.Link("DefaultApi", new {id = player.Id});
            response.Headers.Location = new Uri(uri);

            return response;
        }

        // PUT api/player/5
        public void Put(int id, [FromBody]Player player)
        {
            Player playerDomainModel = PlayerRepository.GetPlayer(id);
            if (playerDomainModel == null)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));

            playerDomainModel.Name = player.Name;
            playerDomainModel.JoinedDate = player.JoinedDate;
            playerDomainModel.Gender = player.Gender;

            PlayerRepository.Save();
        }

        // DELETE api/player/5
        public void Delete(int id, int teamId)
        {
            Team team = TeamRepository.GetTeam(teamId);
            if (team == null)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            Player player = PlayerRepository.GetPlayer(id);
            if (player == null)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            team.Players.Remove(player);
            TeamRepository.Save();
        }
    }
}
