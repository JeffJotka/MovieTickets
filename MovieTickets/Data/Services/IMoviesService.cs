using MovieTickets.Data.Base;
using MovieTickets.Data.ViewModel;
using MovieTickets.Models;
using System.Threading.Tasks;

namespace MovieTickets.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdowns> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovie data);
        Task UpdateMovieAsync(NewMovie data);
    }
}