using DEMO45_28_NguyenQuangVinh.Model;

namespace DEMO45_28_NguyenQuangVinh
{
    public class  ReaderFactory
    {
        public IMovieReader_28_NguyenQuangVinh _IMovieReader { get; set; }
        public ReaderFactory(string fileType)
        {
            switch (fileType)
            {
                case "XML":
                    _IMovieReader = new XMLMovieReader_28_NguyenQuangVinh();
                    break;
                case "JSON":
                    _IMovieReader = new JSONMovieReader_28_NguyenQuangVinh();
                    break;
                default: break;

            }
        }
    }
    class Program
    {
        static IMovieReader_28_NguyenQuangVinh _IMovieReader;
        static void Main(string[] args)
        {
            Console.Title = "IoC Pattern";
            Console.WriteLine("Please, select the file tye to read (1)XML, (2) JSON: ");
            var ans=Console.ReadLine();
            var fileType = (ans == "1") ? "XML" : "JSON";
            _IMovieReader = new ReaderFactory(fileType)._IMovieReader;
            var typeSelected = _IMovieReader.GetType().Name;    
            var movieCollection = _IMovieReader.ReadMovies();
            Console.WriteLine($"Moview Titles ({typeSelected})");
            Console.WriteLine("------------------------------");
            foreach (var movie in movieCollection)
            {
                Console.WriteLine($"{movie.ID}, {movie.Title}, {movie.OscarNominations}, {movie.OscarWins}");
            }
            Console.ReadLine();
        }
    }
}