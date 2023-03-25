using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCinema.Data.Base;
using eCinema.Models;

namespace eCinema.Data.Services
{
    public class ProducersService:EntityBaseRepository<Producer>,IProducersService
    {
        public ProducersService(ApplicationDbContext context) : base(context) { }
        
    }
}
