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
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyCricket.WebAPI.Repositories.TeamRepository context)
        {
            context.Teams.AddOrUpdate(t => t.Name,
                new Team { Name = "Northside Lightning", TeamBirthDay = new DateTime(2001, 1, 1) },
                new Team { Name = "Workers", TeamBirthDay = new DateTime(1800, 1, 1) }
                );
        }
    }
}
