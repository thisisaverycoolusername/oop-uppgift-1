namespace oop_uppgift_1
{
    internal class Program
    {
        static int radius = 0;
        class Circle
        {
                public int getArea()
                {
                    double pi = 3.14;
                    int answer = Convert.ToInt32(pi * radius * radius);
                    return (answer);

                }
            
        }

        static void Main(string[] args)
        {
            radius = 5;
            Circle Area1 = new Circle(); //creates a new object with radie being 5
            Console.WriteLine(Area1.getArea());
            radius = 6;
            Circle Area2 = new Circle();//creates a new object with radie being 6
            Console.WriteLine(Area2.getArea());

        }

    }
}