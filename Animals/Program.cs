using System;
using Animals.Reptiles;


namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            var americanAlligator = new Alligator(100);
            americanAlligator.IsAquatic = true;

            var africanAlligator = new Alligator(2);
            africanAlligator.IsAquatic = false;

            africanAlligator.Grunt();
            africanAlligator.Run(4);

            americanAlligator.Grunt();
            americanAlligator.Run(75);
            americanAlligator.Run(40);
        }
    }
}
