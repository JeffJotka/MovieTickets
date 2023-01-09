using MovieTickets.Data.Base;
using MovieTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTickets.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
