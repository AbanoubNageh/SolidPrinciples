using System;

namespace SolidPoc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ardalis Insurance Rating System Starting...");

            var engine = new RatingEngine(new Logger(),new FilePolicy(),new PolicySerializer(),new RatingValidation());


            // engine.RateBeforeSolid();

            engine.RateAfterSolid();

            if (engine.Rating > 0)
            {
                Console.WriteLine($"Rating: {engine.Rating}");
            }
            else
            {
                Console.WriteLine("No rating produced.");
            }

        }
    }
}
