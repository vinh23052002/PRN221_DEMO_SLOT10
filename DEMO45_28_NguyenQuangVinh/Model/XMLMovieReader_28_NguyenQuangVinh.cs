using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DEMO45_28_NguyenQuangVinh.Model
{
    public class XMLMovieReader_28_NguyenQuangVinh : IMovieReader_28_NguyenQuangVinh
    {
        static string url = @"Data\";
        static XDocument films = XDocument.Load(url + "MoviesDB_28_NguyenQuangVinh.xml");
        static List<Movie_28_NguyenQuangVinh> movies = new List<Movie_28_NguyenQuangVinh>();
        public List<Movie_28_NguyenQuangVinh> ReadMovies()
        {
            var movies = from movie in films.Descendants("Movie")
                         select new Movie_28_NguyenQuangVinh
                         {
                             ID = movie.Element("ID").Value,
                             Title = movie.Element("Title").Value,
                             OscarNominations = movie.Element("OscarNominations").Value,
                             OscarWins = movie.Element("OscarWins").Value
                         };
            return movies.ToList();
        }
    }
}
