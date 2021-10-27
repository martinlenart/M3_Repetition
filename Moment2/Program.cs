using System;

namespace Moment2
{
    public enum DogBreeds { GoldenRetriever, Schitzu, Labrador, Rottweiler}
    class Dog
    {
        public DogBreeds Breed { get; init; }
        public string Name { get; set; }
        public DateTime BirthDay{ get; init; }

        public int YearsOfAge
        {
            get
            {
                var age = DateTime.Now - BirthDay;
                return age.Days/365;
            }
        }

        public override string ToString()
        {
            return $"{Name} is a {Breed}. He is {YearsOfAge} years old";
        }

    }
    class Program
    {
        static int MaxNrOfDogs = 4;
        static void Main(string[] args)
        {
            Dog[] Kennel = new Dog[MaxNrOfDogs];

            Kennel[0] = new Dog { Breed = DogBreeds.GoldenRetriever, Name = "Luna", BirthDay = DateTime.Parse("2020-01-15")  };
            Kennel[1] = new Dog { Breed = DogBreeds.Schitzu, Name = "Ralf", BirthDay = DateTime.Parse("2020-04-25") };
            Kennel[2] = new Dog { Breed = DogBreeds.Labrador, Name = "Pontus", BirthDay = DateTime.Parse("2005-01-15") };
            Kennel[3] = new Dog { Breed = DogBreeds.Rottweiler, Name = "Ralf", BirthDay = DateTime.Parse("2010-01-15") };
            for (int i = 0; i < Kennel.Length; i++)
            {
                Console.WriteLine(Kennel[i]);
            }

            //Change Ralf to Marcus
            string FindName = "Ralf";
            string NewName = "Marcus";
            for (int j = 0; j < Kennel.Length; j++)
            {
                if (Kennel[j].Name == FindName && Kennel[j].Breed == DogBreeds.Schitzu ||
                    Kennel[j].Name == FindName && Kennel[j].Breed == DogBreeds.Rottweiler)
                {
                    Kennel[j].Name = NewName;
                }
            }

            Console.WriteLine();
            for (int i = 0; i < Kennel.Length; i++)
            {
                Console.WriteLine(Kennel[i]);
            }

        }
    }
}
