﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCinema.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using eCinema.Data.Enums;

namespace eCinema.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                    });
                    context.SaveChanges();
                }
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.producers.Any())
                {
                    context.producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            starData = DateTime.Now.AddDays(-10),
                            EndData = DateTime.Now.AddDays(10),
                            Id = 3,
                            ProducerId = 3,
                            MoviCategory = MoviCategory.documentry
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            starData = DateTime.Now,
                            EndData = DateTime.Now.AddDays(3),
                            Id = 1,
                            ProducerId = 1,
                            MoviCategory = MoviCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            starData = DateTime.Now,
                            EndData = DateTime.Now.AddDays(7),
                            Id = 4,
                            ProducerId = 4,
                            MoviCategory = MoviCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            starData = DateTime.Now.AddDays(-10),
                            EndData = DateTime.Now.AddDays(-5),
                            Id = 1,
                            ProducerId = 2,
                            MoviCategory = MoviCategory.documentry
                        },
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            starData = DateTime.Now.AddDays(-10),
                            EndData = DateTime.Now.AddDays(-2),
                            Id = 1,
                            ProducerId = 3,
                            MoviCategory = MoviCategory.cartoon
                        },
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            starData = DateTime.Now.AddDays(3),
                            EndData = DateTime.Now.AddDays(20),
                            Id = 1,
                            ProducerId = 5,
                            MoviCategory = MoviCategory.drama
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.movie_Actors.Any())
                {
                    context.movie_Actors.AddRange(new List<Movie_Actor>()
                    {
                        new  Movie_Actor()
                        {
                            Id = 1,
                            MovieId = 1
                        },
                        new  Movie_Actor()
                        {
                            Id = 3,
                            MovieId = 1
                        },

                         new  Movie_Actor()
                        {
                            Id = 1,
                            MovieId = 2
                        },
                         new  Movie_Actor()
                        {
                            Id = 4,
                            MovieId = 2
                        },

                        new  Movie_Actor()
                        {
                            Id = 1,
                            MovieId = 3
                        },
                        new  Movie_Actor()
                        {
                            Id = 2,
                            MovieId = 3
                        },
                        new  Movie_Actor()
                        {
                            Id = 5,
                            MovieId = 3
                        },


                        new  Movie_Actor()
                        {
                            Id = 2,
                            MovieId = 4
                        },
                        new  Movie_Actor()
                        {
                            Id = 3,
                            MovieId = 4
                        },
                        new  Movie_Actor()
                        {
                            Id = 4,
                            MovieId = 4
                        },


                        new  Movie_Actor()
                        {
                            Id = 2,
                            MovieId = 5
                        },
                        new  Movie_Actor()
                        {
                            Id = 3,
                            MovieId = 5
                        },
                        new  Movie_Actor()
                        {
                            Id = 4,
                            MovieId = 5
                        },
                        new  Movie_Actor()
                        {
                            Id = 5,
                            MovieId = 5
                        },


                        new  Movie_Actor()
                        {
                            Id = 3,
                            MovieId = 6
                        },
                        new  Movie_Actor()
                        {
                            Id = 4,
                            MovieId = 6
                        },
                        new  Movie_Actor()
                        {
                            Id = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
