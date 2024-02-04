using System;

namespace MyFirstProgram
{
    class Program
    {

        // interface - Practice
        static void Main(string[] args)
        {
            Lebron lebron = new Lebron();
            Ronaldo ronaldo = new Ronaldo();
            Jun jun = new Jun();

            // lebron.Shoot();
            // ronaldo.Goal();
            jun.Shoot();
            jun.Goal();

            Console.ReadKey();
        }
    }

    interface IBasketball
    {
        void Shoot();
    }

    interface IFootball
    {
        void Goal();
    }
    
    class Lebron : IBasketball
    {
        string name = "Lebron";

        public void Shoot()
        {
            Console.WriteLine($"{name} shoots the ball");
        }
    }

    class Ronaldo
    {
        string name = "Ronaldo";
        public void Goal()
        {
            Console.WriteLine($"{name} kicks the boal towards the goal");
        }
    }

    class Jun : IBasketball, IFootball
    {
        string name = "Jun";
        public void Shoot()
        {
            Console.WriteLine($"{name} shoots the ball");
        }
        
        public void Goal()
        {
            Console.WriteLine($"{name} kicks the ball");
        }
    }
}