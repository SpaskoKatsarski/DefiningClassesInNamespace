using System;

namespace ClassProjcet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person americanPerson = new Person("John", true);

            americanPerson.AddCar(new Car("BMW", 150));
            americanPerson.AddCar(new Car("Mercedes", 170));

            americanPerson.BuyHouse(new House("Modern", true));

            americanPerson.SayName();

            foreach (Car car in americanPerson.Cars)
            {
                Console.WriteLine($"{car.Model} has {car.HorsePowers} horse powers!");
            }

            Console.WriteLine($"Return whether {americanPerson.Name} has a pet: {americanPerson.HasPet.ToString().ToUpper()}");

            Console.WriteLine($"{americanPerson.Name} has a {americanPerson.Houses[0].HouseModel} house");
            Console.WriteLine($"Is {americanPerson.Name}'s house two story? - {americanPerson.Houses[0].IsTwoStory.ToString().ToLower()}");
        }
    }
}
