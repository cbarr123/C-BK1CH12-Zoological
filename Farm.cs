using System;

namespace zoological
{
    public class farm
    {
        public string _Name{get; set;}
        public string _animalType{get; set;}
        public farm(string name, string animalType)
        {
            name = _Name;
            animalType = _animalType;

        }
        public class PaintedDog : IWalking
            {
                public void Run()
                {
                    Console.WriteLine("The dog is now running"); 
                }
                public void Walk()
                {
                    Console.WriteLine("The dog is now walking");
                }
            }
        public class Seaturtle : IWalking, ISwimming
            {
                public void Run()
                {
                    Console.WriteLine("The sea turtle is now runing");
                }
                public void Walk()
                {
                    Console.WriteLine("The turtle is now walking");
                }
                public void Swim()
                {
                    Console.WriteLine("The turtle is now swimming");
                }
                public int MaximumDepth{get;} = 100;
                
            }
    }
}