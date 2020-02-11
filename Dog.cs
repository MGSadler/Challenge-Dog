using System;

namespace Dog
{
    public class Dog
    {
        //Declaring properties
        public string name;
        public string owner;
        public int age;

        //Create enumerator that contains Male and Female
        public enum Gender
        {
            Male,
            Female,
        }

        private Gender _gender;

        //Create constructor with arguments for name, owner, age and gender
        public Dog(string nm, string o, int a, Gender gender)
        {
            this.name = nm;
            this.owner = o;
            this.age = a;
            this._gender = gender;
        }

        //Create method that takes an argument for amount of times to bark and output "Woof!" said amount of times.
        public string Bark(int bark)
        {
            while (bark >= 1)
            {
                Console.WriteLine("Woof!");
                bark--;
            }

            return "Woof!";
        }

        //Create variables to use as pronouns and specific term for age length
        string pronoun1 = "His";
        string pronoun2 = "he";
        string ageTerm = "years";

        //Create method that takes constuctor's arguments and passes them to create a string
        public string GetTag()
        {
            //Determine which pronoun to use
            if (this._gender != Gender.Male)
            {
                this.pronoun1 = "Her";
                this.pronoun2 = "she";
            }

            //Determine which age term to use
            if (this.age == 1)
            {
                this.ageTerm = "year";
            }

            //Create string that takes the current passed arguments and returns a coherent statement of the data
            string getTag = $"If lost, call {this.owner}. {this.pronoun1} name is {this.name} and {this.pronoun2} is {this.age} {this.ageTerm} old.";

            return getTag;
        }
    }
}