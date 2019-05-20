using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Samples
{
    public static class ReadOnlySample
    {

        public static void Run()
        {
            Point point = new Point();
            point.X = 1.5;
            point.Y = 9.4;

            Console.WriteLine($"Point to distance is : { point.ToString() }");
        }
    }

    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public readonly double Distance => Math.Sqrt(X * X + Y * Y);

        /*
         * 
         * Like most structs, the ToString() method does not modify state. 
         * You could indicate that by adding the readonly modifier to the declaration of ToString(): 
         */
        public readonly override string ToString() =>
            $"({X}, {Y}) is {Distance} from the origin";
    }
}
