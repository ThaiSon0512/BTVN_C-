using System;

namespace GeometryExample
{
    class Cylinder
    {
        private double radius;
        private double height;
        private double baseArea;
        private double lateralArea;
        private double totalArea;
        private double volume;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public void Process()
        {
            baseArea = radius * radius * Math.PI;
            lateralArea = 2 * Math.PI * radius * height;
            totalArea = 2 * Math.PI * radius * (height + radius);
            volume = Math.PI * radius * radius * height;
        }

        public string Result()

        {
            string result = "Cylinder Characteristics\n" +
                            "------------------------\n" +
                            "Radius: " + radius.ToString() + "\n" +
                            "Height: " + height.ToString() + "\n" +
                            "Base Area: " + baseArea.ToString() + "\n" +
                            "Lateral Area: " + lateralArea.ToString() + "\n" +
                            "Total Area: " + totalArea.ToString() + "\n" +
                            "Volume: " + volume.ToString() + "\n";
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double radius, height;

            Console.WriteLine("Enter thu dimenstions of the cylinder");
            Console.WriteLine("-----------------------------------");

            Console.Write("Enter radius: ");
            radius = double.Parse(Console.ReadLine());

            Console.Write("Enter height: ");
            height = double.Parse(Console.ReadLine());

            Cylinder cylinder = new Cylinder(radius, height);
            cylinder.Process();

            Console.WriteLine(cylinder.Result());

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}