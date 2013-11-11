using System.Collections.Generic;
using MyCricket.Domain;

namespace MyCricket.WebAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyCricket.WebAPI.Repositories.TeamRepository>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MyCricket.WebAPI.Repositories.TeamRepository context)
        {
            context.Teams.AddOrUpdate(t => t.Name,
                new Team
                {
                    Name = "Northside Lightning", TeamBirthDay = new DateTime(2001, 1, 1),
                    Players = new List<Player>
                    {
                        new Player {Name = "Andrew Gooch", Gender = GenderEnum.M, JoinedDate = new DateTime(2001, 1, 1)},
                        new Player {Name = "Nathan Sutton", Gender = GenderEnum.M, JoinedDate = new DateTime(2013, 1, 1)},
                        new Player {Name = "Nick Detar", Gender = GenderEnum.M, JoinedDate = new DateTime(2011, 1, 1)},
                        new Player {Name = "Nino Devito", Gender = GenderEnum.M, JoinedDate = new DateTime(2010, 1, 1)},
                        new Player {Name = "Kamal Hasan", Gender = GenderEnum.M, JoinedDate = new DateTime(1999, 1, 1)},
                        new Player {Name = "Ari Hoque", Gender = GenderEnum.M, JoinedDate = new DateTime(2008, 1, 1)},
                        new Player {Name = "Dean O'niel", Gender = GenderEnum.M, JoinedDate = new DateTime(2010, 1, 1)},
                        new Player {Name = "Kyle Killer", Gender = GenderEnum.M, JoinedDate = new DateTime(2013, 1, 1)},
                        new Player {Name = "Adam Greenman", Gender = GenderEnum.M, JoinedDate = new DateTime(2011, 1, 1)},
                        new Player {Name = "Jaspal Singh", Gender = GenderEnum.M, JoinedDate = new DateTime(2009, 1, 1)},
                        new Player {Name = "John Ongly", Gender = GenderEnum.M, JoinedDate = new DateTime(2010, 1, 1)},
                        new Player {Name = "Ryan Koldy", Gender = GenderEnum.M, JoinedDate = new DateTime(2013, 1, 1)},
                        new Player {Name = "Ryan Prosper", Gender = GenderEnum.M, JoinedDate = new DateTime(2013, 1, 1)}
                    }
                },
                new Team
                {
                    Name = "Workers", TeamBirthDay = new DateTime(1800, 1, 1),
                    Players = new List<Player>
                    {
                        new Player {Name = "Don Kelly", Gender = GenderEnum.M, JoinedDate = new DateTime(1990, 1, 1)},
                        new Player {Name = "Josh Kelly", Gender = GenderEnum.M, JoinedDate = new DateTime(2010, 1, 1)}
                    }
                }
                );
        }
    }
}
