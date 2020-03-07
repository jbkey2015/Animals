using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Reptiles
{
    class Alligator
    {

        public bool IsAquatic { get; set; }
        private int _stepGoal;
        private int _stepCount;

        public Alligator(int stepGoal)
        {
            IsAquatic = true;
            _stepGoal = stepGoal;
        }
        public void Grunt()
        {
            if (IsAquatic)
            {
                Console.WriteLine("Bubble Bubble");
            }
            else
            {
                Console.WriteLine("GRRRRRRRRRR!");
            }
        }

        public void Run(int steps)
        {
            _stepCount += steps;

            Console.WriteLine($"You ran {steps} steps.");

            if (_stepCount >= _stepGoal)
            {
                Console.WriteLine("Congrats");
            }

        }
    }
}
