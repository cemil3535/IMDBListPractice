// See https://aka.ms/new-console-template for more information


using IMDBListPractice;

public class Program
{
    public static void Main(string[] args)
    {
        // movie list created
        List<Movie> movies = new List<Movie>();

        // user get input 
        while (true)
        {
        newGate: Movie newMovie = new Movie();
             Console.Write("Film Adi: ");
            newMovie.MovieName = Console.ReadLine();

            Console.Write("Imdb Puani : ");
            newMovie.imdbScore = Convert.ToDouble(Console.ReadLine());

            movies.Add(newMovie);

           begin: Console.WriteLine("Baska bir film eklemek ister misiniz? (evet/hayir)");

            string response = Console.ReadLine().ToLower();

            // Questioning whether the cycle will continue
            if (response == "evet")
            {
                goto newGate;
            }
            else if (response == "hayir")
            {
                // cryle exit and Receiving printouts
                Console.WriteLine("------------BUTUN FILM ISIMLERI-------------------------");
                foreach (Movie movie in movies) 
                {
                    Console.WriteLine(movie);
                }
               
                Console.WriteLine("-------iMDB PUANI 4 ILE 9 ARASIDA OLAN BUTUN FILIMLER--------------");
                foreach (Movie movie in movies)
                {
                    if(movie.imdbScore >=4 && movie.imdbScore <=9)
                    {
                        Console.WriteLine(movie);
                    }
                    
                }
                
                Console.WriteLine("-----------ISMI A ILE BASLAYAN FILIMLER VE IMDB PUANALRI---------------");

                foreach (Movie movie in movies)
                {
                    if (movie.MovieName.StartsWith("A",StringComparison.OrdinalIgnoreCase))
                        Console.WriteLine($"{movie.MovieName} - IMDB puani: {movie.imdbScore}");
                }
                break;
            }
            else // If an invalid entry is made, the loop will be dumped
            { 
                Console.WriteLine("Gecersiz Giris");
                goto begin;
            }

        }
    }
}

