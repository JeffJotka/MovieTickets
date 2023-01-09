using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using MovieTickets.Data.Roles;
using MovieTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTickets.Data
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Description = "This is the description of the 1 cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Description = "This is the description of the 2 cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Description = "This is the description of the 3 cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Description = "This is the description of the 4 cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Description = "This is the description of the 5 cinema"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FirstName = "Actor",
                            LastName = "1",
                            Bio = "This is the Bio of the first actor",

                        },
                        new Actor()
                        {
                             FirstName = "Actor",
                            LastName = "2",
                            Bio = "This is the Bio of the second actor",
                        },
                        new Actor()
                        {
                            FirstName = "Actor",
                            LastName = "3",
                            Bio = "This is the Bio of the 3 actor",
                        },
                        new Actor()
                        {
                            FirstName = "Actor",
                            LastName = "4",
                            Bio = "This is the Bio of the 4 actor",
                        },
                        new Actor()
                        {
                            FirstName = "Actor",
                            LastName = "5",
                            Bio = "This is the Bio of the 5 actor",
                        },
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FirstName = "Producer",
                            LastName = "1",
                            Bio = "This is the Bio of the first actor",

                        },
                        new Producer()
                        {
                            FirstName = "Producer",
                            LastName = "2",
                            Bio = "This is the Bio of the 2 actor",
                        },
                        new Producer()
                        {
                            FirstName = "Producer",
                            LastName = "3",
                            Bio = "This is the Bio of the 3 actor",
                        },
                         new Producer()
                        {
                            FirstName = "Producer",
                            LastName = "4",
                            Bio = "This is the Bio of the 4 actor",
                        },
                          new Producer()
                        {
                            FirstName = "Producer",
                            LastName = "5",
                            Bio = "This is the Bio of the 5 actor",
                        },
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Movie 1",
                            Description = "This is the Movie 1 description",
                            Price = 39.50,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Movie 2",
                            Description = "This is Movie 2 description",
                            Price = 29.50,
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Movie 3",
                            Description = "This is the Movie 3 description",
                            Price = 39.50,
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Movie 4",
                            Description = "This is the Movie 4 description",
                            Price = 39.50,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Movie 5",
                            Description = "This is the Movie 5 description",
                            Price = 39.50,
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Movie 6",
                            Description = "This is the Move 6 description",
                            Price = 39.50,
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },
                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                    });
                    context.SaveChanges();
                }
            }

        }
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@movieticket.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Haslo1234!");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@moviericket.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Haslo1234!");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
