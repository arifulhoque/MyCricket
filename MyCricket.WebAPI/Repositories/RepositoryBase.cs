using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MyCricket.Domain.Repositories;

namespace MyCricket.WebAPI.Repositories
{
    public abstract class RepositoryBase : DbContext, IRepository
    {
        protected RepositoryBase()
            : base("DefaultConnection")
        {
            
        }
    }
}