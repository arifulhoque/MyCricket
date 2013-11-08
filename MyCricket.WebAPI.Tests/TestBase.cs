using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using MyCricket.Domain.Repositories;

namespace MyCricket.WebAPI.Tests
{
    public abstract class TestBase
    {
        public Mock<ITeamRepository> mockedTeamRepository;

        public TestBase()
        {
            mockedTeamRepository = new Mock<ITeamRepository>();
        }
    }
}
