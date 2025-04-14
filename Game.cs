using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Mcvey_Cason
{
    abstract class Game
    {
        // Automatic Property
        public string Esrb {  get; set; }

        // Automatic Property
        public string Title {  get; set; }

        // To assign them into a string
        public Game(string esrbParam, string titleParam)
        {
            Esrb = esrbParam;
            Title = titleParam;
        }

        /// <summary>
        /// Prints the title and says it is starting
        /// </summary>
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is Starting!");
        }

        // For the Sandbox class
        public abstract string Describe();

    }
}
