﻿namespace ConsoleApp1
{
    /// <summary>
    /// 
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
           
            // Using the is keyword to see if a type is compatible
            bool b = "abs" is string;
            System.Diagnostics.Debug.WriteLine(b);

            // Using the as keyword to Cast from one type to another
            string s1 = "abc";
            object o1 = s1;
            string s2 = o1 as string;

            // Using the ternary operator we can shorten the cod below.
            int x =0;
            int value = 2;
            bool isGreater;

            if (x> value)
            {
                isGreater = true;
            }
            else
            {
                isGreater = false;
            }
            // It does not execute
            bool isLess = x > value ? true : false;

            // Null-Coalescing Operator.
            object obj1 = null;
            object obj2 = obj1 ?? new object();

            // sizeof. 
            System.Diagnostics.Debug.WriteLine(sizeof(Int64));
            // typeof.
            System.Diagnostics.Debug.WriteLine(typeof(Int32));

            // Checking C# types
            Type type = typeof(String);
            System.Diagnostics.Debug.WriteLine(type);

            // Pre/post increment operator
            int i = 0;
            i = 5;
            System.Diagnostics.Debug.WriteLine("Post-increment operator "+ i++);
            --i;
            System.Diagnostics.Debug.WriteLine("Pre-increment operator " + ++i);

            // PEMDAS
            System.Diagnostics.Debug.WriteLine("PAMDAS Ops " +( 10 + 5 * 2 + 3));

            // Floating point numbers
            System.Diagnostics.Debug.WriteLine("Floating point " + (10.5 + 5.1));

            // Floating point precision issue when casting from int to floating point
            System.Diagnostics.Debug.WriteLine("Floating point precision issue " + ((int)10.5));

        }

        class Box
        {
            private int x;
            private int y;
            private int z;
            public Box(int x,int y, int z)
            {
                this.x = x; 
                this.y = y;
                this.z = z;
            }
            public int GetLength()
            {
                return x;
            }
            public int GetWidth()
            {
                return y;
            }
            public int GetHeight()
            {
                return z;
            }

            public static Box operator +(Box box1, Box box2)
            {
                return new Box(box1.GetLength(), box1.GetLength(), box2.GetLength());
            }
        }
    }
}