using LINQApp.Entities;
using LINQApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQApp
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Movie> movies = MoviesHelper.MyMovies();



                // ****** Find all movies that their titles starts with "L"

                var startingWith_T = movies
                                    .Where(movie => movie.Title.StartsWith('L'))
                                    .ToList();


                //startingWith_T.ForEach(movie => Console.WriteLine(movie.Title));

                // ***** Find the NUMBER of movies that have rating higher than 7.5

                var moviesRatingHigher75 = movies
                                          .Where(movie => movie.Rating > 7.5f)
                                          .ToList();

                //moviesRatingHigher75.ForEach(movie => Console.WriteLine(movie.Title));

                // ****** Find all movies TITLES with year of production before 2005

                var movieBefore2005 = movies
                                     .Where(movie => movie.Year < 2005)
                                     .ToList();

                // movieBefore2005.ForEach(movie => Console.WriteLine(movie.Title));
                

                // ***** Find all movies TITLES and RATING that have rating higher then 8.0

                var moviesRatingHigher80 = movies
                                          .Where(movie => movie.Rating > 8.0f)
                                          .ToList();

                //moviesRatingHigher80.ForEach(movie => Console.WriteLine(movie.Title));
            

                // ***** Find first 5 movies that have duration time longer then 2 hours

                var first5MoviesLongerthen120 = movies
                                               .Where(movie => movie.Duration > 120)
                                               .Take(5)
                                               .ToList();
                //first5MoviesLongerthen120.ForEach(movie => Console.WriteLine(movie.Title));
            


                // ****** Find last 3 movies TITLES and DURATION that have duration less then 2 hours

                var last3Moviesless120 = movies
                                        .Where(movie => movie.Duration < 120)
                                        .TakeLast(3)
                                        .ToList();
                //last3Moviesless120.ForEach(movie => Console.WriteLine(movie));


                // ***** Find all movies TITLES and RATING and order them by DURATION(DESC) -no condition needed

                var allTitlesRatingDesc = movies
                                         .OrderByDescending(movie => movie.Duration)
                                         .Select(movie => new { movie.Title, movie.Rating })
                                         .ToList();
                //allTitlesRatingDesc.ForEach(movie => Console.WriteLine(movie));

                // ****** Find all movies with TITLES that don't start with A and TITLES include more than 7 characters

                var titlesDontStartAmore7 = movies
                                           .Where(movie => !movie.Title.StartsWith('A'))
                                           .Where(movie => movie.Title.Count() > 7)
                                           .ToList();
                //titlesDontStartAmore7.ForEach(movie => Console.WriteLine(movie.Title));
               

                // ****** Find all movies RATINGS that have RATINGS higher than 7.2, DURATIONS less then 1hour and 50min

                var allRatings72Durationsless110 = movies
                                                  .Where(movie => movie.Rating > 7.2f)
                                                  .Where(movie => movie.Duration < 110)
                                                  .ToList();
                //allRatings72Durationsless110.ForEach(movie => Console.WriteLine(movie.Title));


                // ****** Find all movies TITLES and RATINGS that have TITLES with less than 10 characters, DURATION
                //        longer than 2 hours, RATING higher then 6.7 and order them by TITLE(ASC)
           
                var charactersDuranionRatingTitle = movies
                                                   .Where(movie => movie.Title.Count() < 10)
                                                   .Where(movie => movie.Duration > 120)
                                                   .Where(movie => movie.Rating > 6.7f)
                                                   .OrderBy(movie => movie.Title)
                                                   .ToList();
                //charactersDuranionRatingTitle.ForEach(movie => Console.WriteLine(movie.Title));




                Console.ReadLine();
            
        }
    }
}