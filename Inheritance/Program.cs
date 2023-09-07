using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes - done!

            // Create a class Animal - done!
            // give this class 4 members that all Animals have in common - done!


            // Create a class Bird - done!
            // give this class 4 members that are specific to Bird - done!
            // Set this class to inherit from your Animal Class - done!

            // Create a class Reptile - done!
            // give this class 4 members that are specific to Reptile - done!
            // Set this class to inherit from your Animal Class - done!




            //Create an object of your Bird class - done!

            Bird bird = new Bird();

            //Give values to your members using the object (aka instance) of your Bird class - done!

            //Properties Inherited from Animal class
            bird.Species = "hawk";
            bird.NumberOfYoung = 5;
            bird.LikesToEat = "rodents";
            bird.EatsAndSleeps = true;
            //Properties from only the Reptile Class
            bird.CanFly = true;
            bird.HasFeathers = true;
            bird.NumOfWings = 2;
            bird.TypeOfChirpSound ="squawk";

            //Creatively display the class member values - done!
            Console.WriteLine($"The {bird.Species} typically has {bird.NumberOfYoung} young and likes to eat {bird.LikesToEat}." +
                $" It's {bird.EatsAndSleeps} that it eats and sleeps, " +
                $"it's {bird.CanFly} that it can fly, it's {bird.HasFeathers} that it has feathers with its {bird.NumOfWings}" +
                $" wings and makes the sound of {bird.TypeOfChirpSound}!");
            Console.WriteLine();



            //Create an object of your Reptile class - done!

            Reptile reptile = new Reptile();

            //Give values to your members using the object (aka instance) of your Reptile class - done!
            
            //Properties Inherited from Animal class
            reptile.Species = "gecko";
            reptile.NumberOfYoung = 2;
            reptile.LikesToEat = "insects";
            reptile.EatsAndSleeps = true;
            //Properties from only the Reptile Class
            reptile.IsColdblooded = true;
            reptile.HasScales = true;   
            reptile.NumOfArmsAndLegs = 4;
            reptile.ColorOfSkin = "green";

            //Creatively display the class member values - done!
            Console.WriteLine($"The {reptile.Species} typically has {reptile.NumberOfYoung} young " +
                $"and likes to eat {reptile.LikesToEat}. It's {reptile.EatsAndSleeps} that it eats and sleeps, " +
                $"it's {reptile.IsColdblooded} that it is coldblooded, " +
                $"it's {reptile.HasScales} that it has scales with {reptile.ColorOfSkin} skin " +
                $"and climbs with {reptile.NumOfArmsAndLegs} legs!");

        }
    }
}
