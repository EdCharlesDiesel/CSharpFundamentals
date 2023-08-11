using System.Text;

namespace _05_User_Input_and_Files
{
    internal class Program
    {
        static char[] spaces = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choices;
        static int flag;
        static void DrawBoard()
        {
            Console.WriteLine("         |        |        ");
            Console.WriteLine("   {0}  |   {1}  |   {2}  ", spaces[0], spaces[1], spaces[2]);
            Console.WriteLine("_________|________|_________");
            Console.WriteLine("         |        |        ");
            Console.WriteLine("   {0}  |   {1}  |   {2}  ", spaces[3], spaces[4], spaces[5]);
            Console.WriteLine("_________|________|_________");
            Console.WriteLine("         |        |        ");
            Console.WriteLine("   {0}  |   {1}  |   {2}  ", spaces[6], spaces[7], spaces[8]);
        }

        static int CheckWin()
        {
            if (spaces[0] == spaces[1] &&
                spaces[1] == spaces[2] ||
                spaces[3] == spaces[4] &&
                spaces[4] == spaces[5] ||
                spaces[6] == spaces[7] &&
                spaces[7] == spaces[8] ||
                spaces[0] == spaces[3] &&
                spaces[3] == spaces[6] ||
                spaces[0] == spaces[4] &&
                spaces[1] == spaces[7] ||
                spaces[2] == spaces[5] &&
                spaces[5] == spaces[8] ||
                spaces[0] == spaces[4] &&
                spaces[4] == spaces[8] ||
                spaces[2] == spaces[4] &&
                spaces[4] == spaces[6])
            {
                return 1;
            }
            else if (spaces[0] != '1' &&
                        spaces[1] != '2' &&
                        spaces[2] != '3' &&
                        spaces[3] != '4' &&
                        spaces[4] != '5' &&
                        spaces[5] != '6' &&
                        spaces[6] != '7' &&
                        spaces[7] != '8' &&
                        spaces[8] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        static void DrawX(int pos)
        {
            spaces[pos] = 'X';
        }
        static void DrawO(int pos)
        {
            spaces[pos] = 'O';
        }
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Player 1 : X and Player 2: 0");
                if (player % 2 ==0)
                {
                    Console.WriteLine("Player 2's turn");
                }
                else
                {
                    Console.WriteLine("Player 1's turn");
                }

                Console.WriteLine("\n");
                DrawBoard();
                choices = int.Parse(Console.ReadLine());

                if (spaces[choices]!= 'X' && spaces[choices] != 'O')
                {
                    if (player % 2 ==0)
                    {
                        DrawO(choices);
                    }
                    else
                    {
                        DrawX(choices);
                    }
                     player++;
                }
                else
                {
                    Console.WriteLine(  );
                    Thread.Sleep(1000);
                }

                flag = CheckWin();
             
            } while (flag != 1 && flag != -1);
            Console.Clear();
            DrawBoard();

            if (flag ==1)
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Tie Game");
            }
            //Console.WriteLine("Please write your name: ");
            //string userInput = Console.ReadLine();  
            //System.Diagnostics.Debug.WriteLine($"Your name is: {userInput}");

            //Console.WriteLine("Please a char: ");
            //int userInput = Console.Read();
            //System.Diagnostics.Debug.WriteLine($"Your name is: {Convert.ToChar(userInput)}");

            //Console.WriteLine("g = green, r = red, b = blue, w = white");
            //int x = Console.Read();
            //char userInput = Convert.ToChar(x);

            //while (userInput != 'z')
            //{
            //    switch (userInput)
            //    {
            //        case 'g':
            //            Console.BackgroundColor = ConsoleColor.Green;
            //            break;
            //        case 'r':
            //            Console.BackgroundColor = ConsoleColor.Red;
            //            break;
            //        case 'b':
            //            Console.BackgroundColor = ConsoleColor.Blue;
            //            break;
            //        case 'w':
            //            Console.BackgroundColor = ConsoleColor.White;
            //            break;
            //        default:
            //            break;
            //    }

            //    Console.Clear();
            //    Console.WriteLine("g = green, r = red, b = blue, w = white");
            //    x= Console.Read();
            //    userInput = Convert.ToChar(x);
            //}

            //// ReadKey
            //ConsoleKeyInfo keyInfo;
            //Console.TreatControlCAsInput = true;
            //do
            //{
            //    keyInfo = Console.ReadKey();
            //    if ((keyInfo.Modifiers & ConsoleModifiers.Alt) !=0)
            //    {
            //        Console.Write("ALT");
            //    }

            //    if ((keyInfo.Modifiers & ConsoleModifiers.Alt) != 0)
            //    {
            //        Console.Write("SHIFT");
            //    }

            //    if ((keyInfo.Modifiers & ConsoleModifiers.Alt) != 0)
            //    {
            //        Console.Write("CTL");
            //    }

            //} while (keyInfo.Key != ConsoleKey.Escape);

            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Example.txt";
            //if (!File.Exists(path))
            //{
            //    File.Create(path);
            //}

            //FileStream fileStream = File.Open(path, FileMode.Append);
            //byte[] buffer = new UTF8Encoding(true).GetBytes("Hello Minga");
            //fileStream.Write(buffer, 0, buffer.Length);
            //fileStream.Close();

            //StreamReader sr = new StreamReader(path);
            //string line = sr.ReadToEnd();
            //System.Diagnostics.Debug.WriteLine($"Your name is: {line}");

        }
    }
}