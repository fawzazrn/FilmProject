using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject
{
    class AddFilm
    {

        private string title;
        private int rates;
        private Dictionary<string, int> film = new Dictionary<string, int>();

        public AddFilm() {
            
        }

        public void Initialization() {
            //initialize directories here
        }

        public void AddRatings() {
            Console.WriteLine("ENTER your score: ");
            rates = Convert.ToInt32(Console.ReadLine());
            Map();
            //Debug();
            
        }

        public void AddMovie() {
            Console.WriteLine("ADD film title");
            title = Console.ReadLine();
            AddRatings();
        }

        public void Debug() {
            //Console.WriteLine(rates + 4);
            foreach (KeyValuePair<string, int> pair in film)
            {
                Console.WriteLine("Movie: {0}, Rating: {1}", pair.Key, pair.Value);
                Console.ReadKey();
            }

        }

        public void Map() {
            film.Add(title, rates);
            Debug();
        }

    }
}
