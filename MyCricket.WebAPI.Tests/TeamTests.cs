using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MyCricket.Domain;

namespace MyCricket.WebAPI.Tests
{
    [TestClass]
    public class TeamTests : TestBase
    {
        private Mock<Team> mockedTeam;

        [TestInitialize]
        public void Initialize()
        {
            mockedTeam = new Mock<Team>();
        }

    }
}
