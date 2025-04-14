using System;

namespace Inheritance_Mcvey_Cason
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gives a title and a rating for Terraria
            Sandbox mySandbox = new Sandbox("T", "Terraria");

            // Prints PlayGame and Describe for Terraria
            Console.WriteLine(mySandbox.Describe());
            mySandbox.PlayGame();

            // Gives a title and a rating for Minecraft
            Sandbox minecraft = new Sandbox("E", "Minecraft");

            // Prints PlayGame and Describe for Minecraft
            Console.WriteLine(minecraft.Describe());
            minecraft.PlayGame();
        }
    }
}