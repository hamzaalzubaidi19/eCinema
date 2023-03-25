using eCinema.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCinema.Data.Base;

namespace eCinema.Data.Services
{
    public class ActorService : EntityBaseRepository<Actor>,IActorsService
    {
        public ActorService(ApplicationDbContext context): base(context) { }
       
       
    }
}
