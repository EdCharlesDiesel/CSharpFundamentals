namespace _04_Control_Flow_Statements_and_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if else,else if

            //if (3>5)
            //{
            //    System.Diagnostics.Debug.WriteLine("3 is less than 5");
            //}

            //else if (2 > 3)
            //{
            //    System.Diagnostics.Debug.WriteLine("2 is less than 3");
            //}
            //else
            //{
            //    System.Diagnostics.Debug.WriteLine("Else statement was hi");
            //}

            //// Switch
            //int value = 5; 
            //switch (value)
            //{
            //    case 0:
            //        System.Diagnostics.Debug.WriteLine(0);
            //        break;
            //    case 1:
            //        System.Diagnostics.Debug.WriteLine(1);
            //        break;
            //    case 2:
            //        System.Diagnostics.Debug.WriteLine(2);
            //        break;
            //    case 3:
            //        System.Diagnostics.Debug.WriteLine(3);
            //        break;
            //    case 4:
            //        System.Diagnostics.Debug.WriteLine(4);
            //        break;
            //    case 5:
            //        System.Diagnostics.Debug.WriteLine(5);
            //        break;
            //    default: System.Diagnostics.Debug.WriteLine("Other");
            //        break;
            //}

            //// For loop
            //for (int i = 0; i < 5; i++)
            //{
            //    System.Diagnostics.Debug.WriteLine("The name is ed");
            //}
            //var example = "abc";
            //for (int i = 0; i < example.Length; i++)
            //{
            //    System.Diagnostics.Debug.WriteLine($"Result Set {example[i]}");
            //}

            //// Reverse is the beginning of the array - 1.
            //for (int i = example.Length -1 ;  i >= 0; i--)
            //{
            //    System.Diagnostics.Debug.WriteLine($"Result Set in reverse {example[i]}");
            //}

            //// Using the for loop inside of the parenthesis.
            //int x = 0;
            //for (; ; )
            //{
            //    if ( x < 4)
            //    {
            //        System.Diagnostics.Debug.WriteLine(x.ToString());
            //        x++;
            //    }
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        System.Diagnostics.Debug.WriteLine($"i = {i} and j = {j}");
            //    }
            //}

            //foreach (var @char in "abc")
            //{
            //    System.Diagnostics.Debug.WriteLine($"i = {@char}");
            //}

            //int variable =0;
            //while (variable < 3)
            //{
            //    System.Diagnostics.Debug.WriteLine($"i = {variable}");
            //    variable++;
            //}

            //int variable_ = 0;
            //do
            //{
            //    System.Diagnostics.Debug.WriteLine($"i = {variable_}");
            //    variable_++;
            //} while (variable_ < 5);

            //for (int i = 0; i < 3; i++)
            //{
            //    System.Diagnostics.Debug.WriteLine($"i = {i}");
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if (j == 2)
            //            break;
            //        System.Diagnostics.Debug.WriteLine($"j = {j}");
            //    }
            //}

            for (int i = 0; i < 4; i++)
            {
                if (i==2)
                {
                    continue;
                }

                System.Diagnostics.Debug.WriteLine($"i = {i}");
            }
        }
    }
}