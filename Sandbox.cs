using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Mcvey_Cason
{
    class Sandbox : Game
    {
        // From the Game class and use base because it's a subclass of it
        public Sandbox(string esrbParam, string titleParam) : base(esrbParam, titleParam)
        {
            Title = titleParam;
            Esrb = esrbParam;
        }

        // Returns a string
        public override string Describe()
        {
            return $"{Title} is a sandbox game rated {Esrb}!";
        }
    }
}
