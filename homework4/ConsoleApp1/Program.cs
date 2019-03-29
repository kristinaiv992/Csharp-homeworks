using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercise:
               Create a class Song with the following properties: Title, Length and, Genre
               Genre is enum with - Rock, Hip_Hop, Techno and Classical

               Create a class Person with the following properties: Id, FirstName, LastName,
               Age, FavoriteMusicType (Genre enum) and FavoriteSongs.FavoriteSongs is a list of Songs.
               Create a method called GetFavSongs() that will print out all the titles of their
               favorite songs or write a message that this person hates music if there are
               no favorite songs in their list. */

            var ListOfSongs = new List<Song>()
            {
                new Song("NewYork", 2.45, Genre.Rock),
                new Song("I Want It That Way", 1.98, Genre.Classical),
                new Song("Every Breath You Take", 2.15, Genre.Techno),
                new Song("The Final Countdown", 3.07, Genre.Rock),
                new Song("Sweet Child o' Mine", 2.73, Genre.Rock),
                new Song("Enter Sandman", 3.01, Genre.Techno),
                new Song("Rainbow in the Dark", 3.45, Genre.Hip_Hop),
                new Song("Lose Yourself", 2.15, Genre.Classical),
                new Song("Is This Love", 3.17, Genre.Rock),
                new Song("In Your Eyes", 2.87, Genre.Hip_Hop),
                new Song("Can't Get You Out of My Head", 2.65, Genre.Classical),
                new Song("Wake Me Up Before You Go-Go", 3.28, Genre.Hip_Hop),
                new Song("Right Here Waiting", 1.89, Genre.Rock),
                new Song("Mighty to Save", 3, Genre.Techno),
                new Song("Carrie", 2.78, Genre.Rock)
            };

            Person lika = new Person("kika", "kikic", new List<Song>() { new Song("NewYork", 2.45, Genre.Classical) });
            Person mika = new Person("mika", "mikic", new List<Song>() { new Song("The Final Countdown", 1.98, Genre.Rock) });
            Person slika = new Person("lika", "likic", new List<Song>() { new Song ( "Enter Sandman", 4.90, Genre.Rock) });
            Person julka = new Person("luika", "likoc", new List<Song>() { new Song("Enter Nerman", 2.90, Genre.Classical) });

            lika.FavoriteSongs.Add(ListOfSongs[5]);
            lika.GetFavSongs();
        }
    }
}
