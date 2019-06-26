using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject
{
    class Choices
    {

        private int choice;

        public Choices() {
            


        }

        public void View() {
            Console.WriteLine("1. ENTER movie");
            Console.WriteLine("2. READ library");
            Console.WriteLine("3. EXIT");
        }

        public void getChoice(int choice) {
            this.choice = choice;
            Selection();
        }

        public void Selection() {
            if (choice == 1)
            {
                AddFilm a = new AddFilm();
                a.AddMovie();
            }
            else if (choice == 2)
                Console.WriteLine("2 is selected");

            else
                Console.WriteLine("OTHERS");
        }
    }
}
