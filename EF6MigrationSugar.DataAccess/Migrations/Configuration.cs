namespace EF6MigrationSugar.DataAccess.Migrations
{
    using Ef6MigrationSugar.Models;

    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EF6MigrationSugar.DataAccess.MovieContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EF6MigrationSugar.DataAccess.MovieContext context)
        {
            if (context.Movies.Any())
            {
                return;   // DB has already been seeded
            }

            context.Movies.AddRange(
                new List<Movie>()
                {
                     new Movie
                     {
                         Title = "When Harry Met Sally",
                         ReleaseDate = DateTime.Parse("1989-1-11"),
                         Genre = GenreType.RomanticComedy
                     },

                     new Movie
                     {
                         Title = "Ghostbusters ",
                         ReleaseDate = DateTime.Parse("1984-3-13"),
                         Genre = GenreType.Comedy
                     },

                     new Movie
                     {
                         Title = "Ghostbusters 2",
                         ReleaseDate = DateTime.Parse("1986-2-23"),
                         Genre = GenreType.Comedy
                     },

                   new Movie
                   {
                       Title = "Rio Bravo",
                       ReleaseDate = DateTime.Parse("1959-4-15"),
                       Genre = GenreType.Western
                   }
               }
            );

            context.SaveChanges();
        }
    }
}
