using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType  { get; set; }
        public List<Song>FavoriteSongs { get; set; }

        public Person(string name, string surname, List<Song> favSongs)
        {
            FirstName = name;
            LastName = surname;
            FavoriteSongs = favSongs;

        }

        public void GetFavSongs()
        {
            if (FavoriteSongs.Count != 0)
            {
                Console.WriteLine($"{FirstName}{LastName} favorite songs are:");
                foreach (var item in FavoriteSongs)
                {
                    Console.WriteLine("Song: " + item.Title);
                }
            }
            else
            {
                Console.WriteLine($"{FirstName}{LastName} hates music");
            }
        Console.ReadLine();
        }
    }
}
