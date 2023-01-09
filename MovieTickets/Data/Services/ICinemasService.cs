using MovieTickets.Data.Base;
using MovieTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTickets.Data.Services
{
    public interface ICinemasService : IEntityBaseRepository<Cinema>
    {
    }
}
