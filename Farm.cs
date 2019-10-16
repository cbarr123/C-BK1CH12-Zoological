using System
namespace zoological
{
    public class farm
    {
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
    }
}