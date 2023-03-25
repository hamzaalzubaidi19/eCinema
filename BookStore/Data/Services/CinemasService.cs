using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCinema.Data.Base;
using eCinema.Models;
namespace eCinema.Data.Services
{
    public class CinemasService:EntityBaseRepository<Cinema>,ICinemasService
    {
        public CinemasService(ApplicationDbContext context):base(context) { }
        
                
        
    }
}
