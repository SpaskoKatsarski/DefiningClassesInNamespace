using System;
using System.Collections.Generic;

namespace ClassProjcet
{
    public class Person
    {
        public Person(string name, bool hasPet)
        {
            this.Name = name;
            this.HasPet = hasPet;
            this.Houses = new List<House>();
            this.Cars = new List<Car>();
        }

        public string Name { get; set; }

        public bool HasPet { get; set; }

        public List<Car> Cars { get; set; }

        public void AddCar(Car car)
        {
            this.Cars.Add(car);
        }

        public void SayName()
        {
            Console.WriteLine(this.Name);
        }

        public List<House> Houses { get; set; }

        public void BuyHouse(House house)
        {
            this.Houses.Add(house);
        }
    }
}
