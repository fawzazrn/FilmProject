using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("******WELCOME******");
            Choices c = new Choices();
            c.View();
            Console.WriteLine("INPUT choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            c.getChoice(choice);
            

        }
    }
}
