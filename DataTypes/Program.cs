using System.Text;

namespace DataTypes
{
    internal class Program
    {
        dynamic example2 = 22;
        static void Main(string[] args)
        {
            //Checking C# types
            Type type = typeof(String);
            System.Diagnostics.Debug.WriteLine(type);

            // Pre/post increment operator
            int i = 0;
            i = 5;
            System.Diagnostics.Debug.WriteLine("Post-increment operator " + i++);
            --i;
            System.Diagnostics.Debug.WriteLine("Pre-increment operator " + ++i);

            // PEMDAS
            System.Diagnostics.Debug.WriteLine("PAMDAS Ops " + (10 + 5 * 2 + 3));

            // Floating point numbers
            System.Diagnostics.Debug.WriteLine("Floating point " + (10.5 + 5.1));

            // Floating point precision issue when casting from int to floating point
            System.Diagnostics.Debug.WriteLine("Floating point precision issue " + ((int)10.5));

            // Math functions
            System.Diagnostics.Debug.WriteLine("Math Abs " + (Math.Abs(-1.6f)));
            System.Diagnostics.Debug.WriteLine("Math Round " + (Math.Round(-1.8f)));
            System.Diagnostics.Debug.WriteLine("Math Ceiling " + (Math.Ceiling(1.8f)));
            System.Diagnostics.Debug.WriteLine("Math Floor " + (Math.Floor(1.8f)));
            System.Diagnostics.Debug.WriteLine("Math Truncate " + (Math.Truncate(33.8f)));
            System.Diagnostics.Debug.WriteLine("Math Min " + (Math.Min(33, 22)));
            System.Diagnostics.Debug.WriteLine("Math Max " + (Math.Max(3, 5)));
            System.Diagnostics.Debug.WriteLine("Math Challenge " + MathChallenge(100));

            //C# Strings.
            System.Char[] @char = new System.Char[] { 'a', 'b', 'c' };
            string name = "Charles";
            System.Diagnostics.Debug.WriteLine($"My name is {name}.");
            System.Diagnostics.Debug.WriteLine(name.Contains("C"));
            System.Diagnostics.Debug.WriteLine(name.Substring(2));

            System.Diagnostics.Debug.WriteLine("\a");
            System.Diagnostics.Debug.WriteLine("Hello \t Word");
            var price = 20.50f;

            var price1 = 33.10f;
            int price3 = 310;

            System.Diagnostics.Debug.WriteLine(String.Format("The price of bread is {0:C} ", price));
            System.Diagnostics.Debug.WriteLine(String.Format("The price of bread is {0:C} and the price of milk is {1:C} while the price of butter is {2:C}", price, price1, price3));
            var percent = 32.10f;
            System.Diagnostics.Debug.WriteLine(String.Format("{0:P} completed", percent));

            // Using the string builder class.
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(name);
            for (int i_ = 0; i_ < 5; i_++)
            {
                stringBuilder.Append(name);
            }

            string s = stringBuilder.ToString();
            stringBuilder.Clear();
            System.Diagnostics.Debug.WriteLine(s);

            //Working with strings.
            string x = "abc";
            System.Diagnostics.Debug.WriteLine(x.IndexOf("c"));
            x=x.Insert(3, "d");
            System.Diagnostics.Debug.WriteLine(x);

            //bools
            bool? example_ = null;
            example_ = true;
            System.Diagnostics.Debug.WriteLine($"This is a bool {!example_}");

            //logical operators
            System.Diagnostics.Debug.WriteLine(true & true);
            System.Diagnostics.Debug.WriteLine(true & false);

            System.Diagnostics.Debug.WriteLine(true | true);
            System.Diagnostics.Debug.WriteLine(true | false);
            System.Diagnostics.Debug.WriteLine(false | false);

            System.Diagnostics.Debug.WriteLine(true && true);
            System.Diagnostics.Debug.WriteLine(true && false);

            System.Diagnostics.Debug.WriteLine(true || true);
            System.Diagnostics.Debug.WriteLine(true || false);
            System.Diagnostics.Debug.WriteLine(false || false);

            example_ &= false;
            System.Diagnostics.Debug.WriteLine($"logical and operation {example_}");
            // Value Types
            int valueType = 200;
            System.Diagnostics.Debug.WriteLine(valueType);
            ChangeValue(valueType);
            System.Diagnostics.Debug.WriteLine($"Value {valueType}");

            // Reference Types

        }

        private static void ChangeValue(int valueType)
        {
            valueType = 500;
            System.Diagnostics.Debug.WriteLine(valueType);
        }

        private static void ChangeReferenceType(Person person)
        {            
            person.name = "Test";
        }

        //Convert Fahrenheit to celsius
        public static int MathChallenge(int fahrenheit)
        {
            return (fahrenheit - 32) * (5 / 9);
        }
    }

    public class Person
    {
        public string name = string.Empty;
    }
}