using LINQApp.Entities;
using System.Collections.Generic;

namespace LINQApp.Helpers
{
    public class MoviesHelper
    {
        public static List<Movie> MyMovies()
        {
            return new List<Movie>()
            {
                new Movie(){ Title = "The Mountain II", Year = 2016, Rating = 8.9f, Duration = 135 },
                new Movie(){ Title = "Seven Samurai", Year = 1954, Rating = 8.6f, Duration = 207 },
                new Movie(){ Title = "Big Hero 6", Year = 2014, Rating = 7.8f, Duration = 102 },
                new Movie(){ Title = "The Man from Nowhere", Year = 2010, Rating = 7.8f, Duration = 119 },
                new Movie(){ Title = "Gladiator", Year = 2000, Rating = 8.5f, Duration = 155 },
                new Movie(){ Title = "Avengers: Endgame", Year = 2009, Rating = 8.4f, Duration = 181 },
                new Movie(){ Title = "Kung Fu Hustle", Year = 2004, Rating = 7.7f, Duration = 99 },
                new Movie(){ Title = "Iron Man", Year = 2008, Rating = 7.9f, Duration = 126 },
                new Movie(){ Title = "Big Hero 6", Year = 2014, Rating = 7.8f, Duration = 102 },
                new Movie(){ Title = "The Dark Knight", Year = 2008, Rating = 9.0f, Duration = 152 },
                new Movie(){ Title = "13 Assassins", Year = 2010, Rating = 7.6f, Duration = 141 },
                new Movie(){ Title = "Grindhouse", Year = 2007, Rating = 7.5f, Duration = 191 },

                new Movie(){ Title = "Ben-Hur", Year = 1959, Rating = 8.1f, Duration = 212 },
                new Movie(){ Title = "Ladyhawke", Year = 1985, Rating = 7.0f, Duration = 121 },
                new Movie(){ Title = "Police Academy", Year = 1984, Rating = 6.7f, Duration = 96 },
                new Movie(){ Title = "Avatar", Year = 2009, Rating = 7.8f, Duration = 162 },
                new Movie(){ Title = "Rocky Balboa", Year = 2006, Rating = 6.7f, Duration = 102 },
                new Movie(){ Title = "Scarface", Year = 2006, Rating = 8.3f, Duration = 98 },
                new Movie(){ Title = "The Godfather", Year = 1976, Rating = 9.2f, Duration = 175 },
                new Movie(){ Title = "Superman", Year = 1978, Rating = 7.3f, Duration = 143 },
                new Movie(){ Title = "Need for Speed", Year = 2014, Rating = 6.5f, Duration = 132 },
                new Movie(){ Title = "Madagascar", Year = 2005, Rating = 6.9f, Duration = 86 },
                new Movie(){ Title = "Last Samurai", Year = 2003, Rating = 7.7f, Duration = 154 }
            };
        }
    }
}