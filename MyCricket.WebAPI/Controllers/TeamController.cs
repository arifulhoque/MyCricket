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
    public class TeamController : ApiController
    {
        protected readonly ITeamRepository TeamRepository;

        public TeamController(ITeamRepository teamRepository)
        {
            this.TeamRepository = teamRepository;
        }

        // GET api/team
        public IEnumerable<Team> Get()
        {
            return TeamRepository.GetAllTeams().ToList();
        }

        // GET api/team/5
        public Team Get(int id)
        {
            Team team = TeamRepository.GetTeam(id);
            if (team == null)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));

            return team;
        }

        // POST api/team
        public HttpResponseMessage Post([FromBody]Team team)
        {
            team = TeamRepository.Add(team);
            HttpResponseMessage response = Request.CreateResponse<Team>(HttpStatusCode.Created, team);

            string uri = Url.Link("DefaultApi", new { id = team.Id });
            response.Headers.Location = new Uri(uri);

            return response;
        }

        // PUT api/team/5
        public void Put(int id, [FromBody]Team team)
        {
            Team teamDomainModel = TeamRepository.GetTeam(id);
            if (teamDomainModel == null)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            teamDomainModel.Name = team.Name;
            teamDomainModel.Players = team.Players;
            teamDomainModel.TeamBirthDay = team.TeamBirthDay;

            TeamRepository.Save();
        }

        // DELETE api/team/5
        public void Delete(int id)
        {
            Team team = TeamRepository.GetTeam(id);
            if (team == null)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            TeamRepository.Remove(team);
            TeamRepository.Save();
        }
    }
}
