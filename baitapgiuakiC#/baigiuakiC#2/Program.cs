using System;

namespace InheritanceAndPolymorphismExample
{
    class Animal
    {
        protected double weight;
        protected string name;

        public Animal()
        {
            weight = 0;
            name = "";
        }

        public Animal(double weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

        public void SetMe(double weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("Animal: {0}, Weight: {1} kg", name, weight);
        }
    }

    class Lion : Animal
    {
        public Lion(double weight, string name) : base(weight, name)
        {
            Console.WriteLine("Lion constructor called.");
        }

        public override void Show()
        {
            Console.WriteLine("Lion: {0}, Weight: {1} kg", name, weight);
        }
    }

    class Tiger : Animal
    {
        public Tiger(double weight, string name) : base(weight, name)
        {
            Console.WriteLine("Tiger constructor called.");
        }

        public override void Show()
        {
            Console.WriteLine("Tiger: {0}, Weight: {1} kg", name, weight);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal(0, "");
            Lion lion = new Lion(190, "Simba");
            Tiger tiger = new Tiger(150, "Shere Khan");

         

            animal.Show();
            lion.Show();
            tiger.Show();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}