using MyLib;
using System;


namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Console.WriteLine(p1.ToString());


            Point p2 = new Point(10, 20);
            Console.WriteLine(p2.ToString());

            Point p4 = p2;
            
            Point p3 = new Point(p2);
            Console.WriteLine(p3.ToString());

            p3.x = 30;
            p4.x = 20;
            p2.y = 50;
            var compare13 = p3.Equals(p1);
            var compare23 = p3.Equals(p2);
            var compare24 = p2.Equals(p4);
            Console.WriteLine($"Compare p1vsp3 = {compare13} and compare p2p3 = {compare23}");
            Console.ReadLine();
        }
    }
}
