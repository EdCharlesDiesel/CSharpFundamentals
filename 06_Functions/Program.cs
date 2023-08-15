#define Condition1
using System.Diagnostics;

namespace _06_Functions
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Excample2 Excample2 = new Excample2("test", 'c');
            Excample2 Excample = new Excample2("test", 2);

            System.Diagnostics.Debug.WriteLine(Excample2.ToString());
            System.Diagnostics.Debug.WriteLine(Excample.ToString());

            oldMethod();
            Func<int, int, int> multiply = (x, y) => { return x * y; };
            System.Diagnostics.Debug.WriteLine(multiply(3, 3));
        }


        private int localVariable;

        public int _localVariable
        {
            get { return localVariable; }
            set { localVariable = value; }
        }

        [Obsolete("Please use the new method in your code base named NewMethod")]
        static void oldMethod() { }

        [Conditional("Condition1")]
        static void newMethod() { }       

    }

    /// <summary>
    /// Class with a constructor and a finalizer.
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public class Excample1: Attribute
    {
        string  testc = string.Empty;
        public Excample1(string test)
        {
                testc = test;
        }

        ~Excample1()
        {
            Console.WriteLine("Finalizer being called");   
        }
    }

    public class Excample2
    {
        string test = string.Empty;
        string test2 = string.Empty;
        int variable = 0;
        public Excample2(string test, int variable)
        {
            this.test = test;
            this.variable = variable;

        }

        public Excample2(string test, char variable)
        {
            this.test2 = test;
            this.variable = variable;
        }
    }
}