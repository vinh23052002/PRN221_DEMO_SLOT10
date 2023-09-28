using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace DEMO45_28_NguyenQuangVinh.Model
{
    public class JSONMovieReader_28_NguyenQuangVinh : IMovieReader_28_NguyenQuangVinh
    {
        static string file = @"Data\MoviesDB_28_NguyenQuangVinh.json";
        static List<Movie_28_NguyenQuangVinh> movies = new List<Movie_28_NguyenQuangVinh>();
        public List<Movie_28_NguyenQuangVinh> ReadMovies()
        {
            var moviesText = File.ReadAllText(file);
            return JsonSerializer.Deserialize<List<Movie_28_NguyenQuangVinh>>(moviesText);

        }
    }
}
