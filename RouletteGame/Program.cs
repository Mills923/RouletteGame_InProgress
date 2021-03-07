using System;

namespace RouletteGame
{
    class Program
    {
        public static string OddEven(int input)
        {

            bool even = input % 2 == 0;
            if (even == true)
            {
                return "Evens";

            }
            else
            {
                return "Odds";
            }
        }

        public static string LowHigh(int input)
        {
            if (input >= 1 && input <= 18)
            {
                return "Low";
            }

            if (input >= 19 && input <= 36)
            {
                return "High";
            }
            else
            {
                return "Null";
            }

        }

        public static string Dozens(int input)
        {
            if (input >=1 && input <=12)
            {
                return "1st 12";
            }
            if (input >= 13 && input <= 24)
            {
                return "2nd 12";
            }
            if (input >=25 && input <=36)
            {
                return "3rd 12";
            }
            else
            {
                return "Null";
            }
        }

        public static string Street(int input)
        {
            //int[] Row1 = { 1, 2, 3 };
            //int[] Row2 = { 4, 5, 6 };
            //int[] Row3 = { 7, 8, 9 };
            //int[] Row4 = { 10, 11, 12 };
            //int[] Row5 = { 13, 14, 15 };
            //int[] Row6 = { 16, 17, 18 };
            //int[] Row7 = { 19, 20, 21 };
            //int[] Row8 = { 22, 23, 24 };
            //int[] Row9 = { 25, 26, 27 };
            //int[] Row10 = { 28, 29, 30 };
            //int[] Row11 = { 31, 32, 33 };
            //int[] Row12 = { 34, 35, 36 };
            //
            //var row = Array.Find(element => element == input);

            if (input == 1 || input == 2 || input == 3)
            {
                return "Row 1: 1/2/3";
            }
            if (input == 4 || input == 5 || input == 6)
            {
                return "Row 2: 4/5/6";
            }
            if (input == 7 || input == 8 || input == 9)
            {
                return "Row 3: 7/8/9";
            }
            if (input == 10 || input == 11 || input == 12)
            {
                return "Row 4: 10/11/12";
            }
            if (input == 13 || input == 14 || input == 15)
            {
                return "Row 5: 13/14/15";
            }
            if (input == 16 || input == 17 || input == 18)
            {
                return "Row 6: 16/17/18";
            }
            if (input == 19 || input == 20 || input == 21)
            {
                return "Row 7: 19/20/21";
            }
            if (input == 22 || input == 23 || input == 24)
            {
                return "Row 8: 22/23/24";
            }
            if (input == 25 || input == 26 || input == 27)
            {
                return "Row 9: 25/26/27";
            }
            if (input == 28 || input == 29 || input == 30)
            {
                return "Row 10: 28/29/30";
            }
            if (input == 31 || input == 32 || input == 33)
            {
                return "Row 11: 31/32/33";
            }
            if (input == 34 || input == 35 || input == 36)
            {
                return "Row 12: 34/35/36";
            }
            else
            {
                return "Null";
            }
        }

        public static string Columns(int input)
        {
            //string temp = input.ToString(); 
            int[] Column1 = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            int[] Column2 = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] Column3 = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };  
            int num1 = Array.Find(Column1, element => element == input);
            int num2 = Array.Find(Column2, element => element == input);
            int num3 = Array.Find(Column3, element => element == input);

            if (num1> num2 && num1> num3)
            {
                return "Column 1";
            }
            if (num2>num1 && num2 > num3)
            {
                return "Column 2";
            }
            else
            {
                return "Column 3";
            }


        }

        public static int Numbers6(int input)
        {
            int[] first6 = { 1, 2, 3, 4, 5, 6 };
            int[] second6 = { 7, 8, 9, 10, 11, 12 };
            int[] third6 = { 13, 14, 15, 16, 17, 18 };
            int[] fourth6 = { 19, 20, 21, 22, 23, 24 };
            int[] fifth6 = { 25, 26, 27, 28, 29, 30 };
            int[] sixth6 = { 30, 31, 32, 33, 34, 35, 36 };

            int num1 = Array.Find(first6, element => element == input);
            int num2 = Array.Find(second6, element => element == input);
            int num3 = Array.Find(third6, element => element == input);
            int num4 = Array.Find(fourth6, element => element == input);
            int num5 = Array.Find(fifth6, element => element == input);
            int num6 = Array.Find(sixth6, element => element == input);
            int answer = 0;


            if (num1>num2 && num1> num3 && num1> num4 && num1 >num5 && num1>num6)
            {
                //int answer;
                foreach (var item in first6)
                {
                    //int answer;

                    Console.Write(item + ",");

                }
                 //.ToString();
                ///return answer;
            }
            if (num2 > num1 && num2 > num3 && num2 > num4 && num2 > num5 && num2 > num6)
            {
                foreach (var item in second6)
                {
                    Console.Write(item + ",");
                }
                //return second6;//.ToString();
                //return answer;
            }
            if (num3 > num2 && num3 > num1 && num3 > num4 && num3 > num5 && num3 > num6)
            {
                foreach (var item in third6)
                {
                    Console.Write(item + ",");
                }
                //return third6;//.ToString();
                //return answer;
            }
            if (num4 > num2 && num4 > num3 && num4 > num1 && num4 > num5 && num4 > num6)
            {
                foreach (var item in fourth6)
                {
                    Console.Write(item + ",");
                }
                //return fourth6;//.ToString();
                //return answer;
            }
            if (num5 > num2 && num5 > num3 && num5 > num4 && num5 > num1 && num5 > num6)
            {
                foreach (var item in fifth6)
                {
                    Console.Write(item + ",");
                }
                //return fifth6;//.ToString();
                //return answer;
            }
            if (num6 > num2 && num6 > num3 && num6 > num4 && num6 > num5 && num6 > num1)
            {
                foreach (var item in sixth6)
                {
                    Console.Write(item + ",");
                }
                //return sixth6;//.ToString();
                //r/eturn answer;
            }
            else
            {
                return 0000;
            }
            return answer;

        }

         static void Main(string[] args)
        {
             int[] board = { 0, 00, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
             string[] color = { "Red", "Black" };
             Random random = new Random();
             var r = new Random();
             int ball = board[r.Next(board.Length)];
             string randomColor = color[r.Next(color.Length)];



            Console.WriteLine($"Ball Landed on:{ball}");
            Console.WriteLine("\nThe 10 winning bets are as followed");
            Console.WriteLine($"\n1.Number:{ball}");
            Console.WriteLine($"\n2.Evens/Odds:{OddEven(ball)} ");
            Console.WriteLine($"\n3.Reds/Blacks:{randomColor}");
            Console.WriteLine($"\n4.Lows/Highs:{LowHigh(ball)} ");
            Console.WriteLine($"\n5.Dozens:{Dozens(ball)}");
            Console.WriteLine($"\n6.Columns:{Columns(ball)}");
            Console.WriteLine($"\n7.Street:{Street(ball)}");
            Console.WriteLine($"\n8.6 Numbers:{Numbers6(ball)}");
            Console.WriteLine($"\n9.Split: ");
            Console.WriteLine($"\n10.Corner");

        }
    }
}
