using eCinema.Data.Base;
using eCinema.Data.ViewModel;
using eCinema.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCinema.Data.Services
{
    public class MoviesService: EntityBaseRepository<Movie>, IMoviesService
    {
        private readonly ApplicationDbContext _context;
        public MoviesService(ApplicationDbContext context):base(context)
        {
            _context = context;
        }
        public async Task AddNewMovieAsync(NewMovieVM data)
        {
            var newMovie = new Movie()
            {
                Name = data.Name,
                Description = data.Description,
                Price = data.Price,
                ImageUrl = data.ImageURL,
                Id = data.CinemaId,
                starData = data.StartDate,
                EndData = data.EndDate,
                MoviCategory = data.MovieCategory,
                ProducerId = data.ProducerId
            };
            await _context.Movies.AddAsync(newMovie);
            await _context.SaveChangesAsync();


            foreach (var actorId in data.ActorIds)
            {
                var newActorMovie = new Movie_Actor()
                {
                    MovieId = newMovie.Id,
                    Id = actorId
                };
                await _context.movie_Actors.AddAsync(newActorMovie);
            }
            await _context.SaveChangesAsync();
        }
        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            var movieDetails = await _context.Movies
                .Include(c => c.Cinema)
                .Include(p => p.Producer)
                .Include(am => am.Movie_Actors).ThenInclude(a => a.Actor)
                .FirstOrDefaultAsync(n => n.Id == id);

            return movieDetails;
        }
        public async Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues()
        {
            var response = new NewMovieDropdownsVM()
            {
                Actors = await _context.Actors.OrderBy(n => n.FullName).ToListAsync(),
                Cinemas = await _context.Cinemas.OrderBy(n => n.Name).ToListAsync(),
                Producers = await _context.producers.OrderBy(n => n.FullName).ToListAsync()
            };

            return response;
        }
        public async Task UpdateMovieAsync(NewMovieVM data)
        {
            var dbMovie = await _context.Movies.FirstOrDefaultAsync(n => n.Id == data.Id);

            if (dbMovie != null)
            {
                dbMovie.Name = data.Name;
                dbMovie.Description = data.Description;
                dbMovie.Price = data.Price;
                dbMovie.ImageUrl = data.ImageURL;
                dbMovie.Id = data.Id;
                dbMovie.starData = data.StartDate;
                dbMovie.EndData = data.EndDate;
                dbMovie.MoviCategory = data.MovieCategory;
                dbMovie.ProducerId = data.ProducerId;
                await _context.SaveChangesAsync();
            }

            //Remove existing actors
            var existingActorsDb = _context.movie_Actors.Where(n => n.MovieId == data.Id).ToList();
            _context.movie_Actors.RemoveRange(existingActorsDb);
            await _context.SaveChangesAsync();

            //Add Movie Actors
            foreach (var actorId in data.ActorIds)
            {
                var newActorMovie = new Movie_Actor()
                {
                    MovieId = data.Id,
                    Id = actorId
                };
                await _context.movie_Actors.AddAsync(newActorMovie);
            }
            await _context.SaveChangesAsync();
        }
    }

    
}
