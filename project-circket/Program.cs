using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project_circket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER A ENTER KEY AND START GAME");
            Console.WriteLine("HOW TO PLAY PRESS ONLY USE");
            Console.WriteLine("ENTER KEY and number key use");
            int y = 15;
            for (int i = 0; y > 0; i++)
            {

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("------------------------");
                Console.WriteLine("|	| | |		|      ");
                Console.WriteLine("|			|          ");
                Console.WriteLine("|			|          ");
                Console.WriteLine("|			|          ");
                Console.WriteLine("|			|          ");
                Console.WriteLine("|			|          ");
                Console.WriteLine("|			|          ");
                Console.WriteLine("|			|          ");
                Console.WriteLine("|			|          ");
                Console.WriteLine("|			|          ");
                Console.WriteLine("|			|          ");
                Console.WriteLine("------------------------");

                Console.ForegroundColor = ConsoleColor.White;
                string yn = "( )" + "\n\r" + " | " + "\n\r" + "/ \\";
                Console.SetCursorPosition(0, y);

                Console.WriteLine(yn);
                Console.ReadLine();
                Console.SetCursorPosition(0, 0);
                Console.Clear();
                if (y > 10)
                {
                    y--;
                }
                else
                {
                    y = 15;

                    int run = 0;

                    Console.Clear();
                    Console.WriteLine("Enter a number a ball");
                    int num = Convert.ToInt32(Console.ReadLine());
                    for (int j = 1; j <= num; j++)
                    {



                        Console.WriteLine("guess  the ball \n");
                        //Console.WriteLine("\n 1:googly \n 2:off spin \n 3:leg spin \n 4:right swing \n 5:left swing");
                        Console.WriteLine("\n 1:googly \n 2:off spin \n 3:leg spin \n 4:right swing \n 5:left swing \n 6:fast \n 7:medium fast \n 8:leg break \n 9:bouncer \n 10:youker ");


                        Random s = new Random();
                        int temp = s.Next(1, 10);

                        Console.WriteLine();
                        Console.WriteLine("Enter your ball number ");
                        int ball = Convert.ToInt32(Console.ReadLine());
                        int result;
                        result = ball - temp;


                        if (result == 2)
                        {

                            Console.WriteLine("FOUR RUN");
                            run += 4;
                            //Console.WriteLine(run);
                        }
                        else if (result == 0)
                        {
                            run += 6;
                            Console.WriteLine("SIX RUN");
                            //Console.WriteLine(run);
                        }
                        else if (result == 3)
                        {
                            run += 2;
                            Console.WriteLine("TWO RUN");
                            //Console.WriteLine(run);
                        }
                        else if (result == 1)
                        {
                            run += 0;
                            Console.WriteLine("OUT");
                            //Console.WriteLine(run);
                        }
                        else if (result== 5)
                        {
                            Console.WriteLine("WHITE BALL");
                            run++;

                        }
                        int score = run;

                        Console.WriteLine("run: " + score);
                    }
                }

            }





































        }
    }
}
