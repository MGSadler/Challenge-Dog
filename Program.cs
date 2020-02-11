using System;

namespace Dog
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new Dog class objects and pass info for its parameters
            Dog puppy = new Dog("Orion", "Shawn", 1, Dog.Gender.Male);
            Dog myDog = new Dog("Lileu", "Dale", 4, Dog.Gender.Female);

            //Call the Bark Method and pass number of times to bark and 
            //output puppy Dog class object data through GetTag method in Dog class
            puppy.Bark(3);
            Console.WriteLine(puppy.GetTag());

            //Call the Bark Method and pass number of times to bark and 
            //output myDog Dog class object data through GetTag method in Dog class
            myDog.Bark(1);
            Console.WriteLine(myDog.GetTag());
        }
    }
}
