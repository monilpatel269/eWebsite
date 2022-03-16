using eWebsite.Data.Base;
using eWebsite.Data.ViewModels;
using eWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eWebsite.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        new Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}
