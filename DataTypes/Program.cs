namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Checking C# types
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
        }
    }
}