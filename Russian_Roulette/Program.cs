using System;
using System.Reflection;

namespace Russian_Roulette
{
     class Reload
    {
        static void Main(string[] args)
        {
            int milliseconds = 1000;
            var rng = new Random();
            string ReNo;
            string BOT1 = "Jamal";
            string BOT2 = "Abby";
            string BOT3 = "Jaime";
            string BOT4 = "Titania";
            string BOT5 = "Lugh";

            do
            {
                Console.WriteLine("-------------------------------------------------------INFORMATION------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("     1. You can play this with your friends, from 2 to 6 player.");
                Console.WriteLine("     2. If you don't have any friend, BOT would gladly play with you.");
                Console.WriteLine("     3. 1 bullet and 6 turn, 1 Player has only 1 turn, if someone is dead, the game ended.");
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("1. Player");
                Console.WriteLine();
                Console.WriteLine("2. BOT");
                Console.WriteLine();

                Console.Write("Choose 1st number: ");
                int Number = int.Parse(Console.ReadLine());
                if (Number == 0)
                {
                    Console.WriteLine("Not Indentified");
                }
                else if (Number == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("1. 2 Players");
                    Console.WriteLine("2. 3 Players");
                    Console.WriteLine("3. 4 Players");
                    Console.WriteLine("4. 5 Players");
                    Console.WriteLine("5. 6 Players");
                    Console.WriteLine();
                }
                else if (Number == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("1. 2 Players (1 BOT)");
                    Console.WriteLine("2. 3 Players (2 BOT)");
                    Console.WriteLine("3. 4 Players (3 BOT)");
                    Console.WriteLine("4. 5 Players (4 BOT)");
                    Console.WriteLine("5. 6 Players (5 BOT)");
                    Console.WriteLine();
                }
                Console.Write("Choose 2nd Number: ");
                int Number2 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if ((Number2 == 0) && (Number == 1))
                {
                    Console.WriteLine("Not Identified");
                }
                else if ((Number == 1) && (Number2 == 0))
                {
                    Console.WriteLine("Not Identified");
                }
                else if ((Number == 1) && (Number2 >= 6))
                {
                    Console.WriteLine("Not Identified");
                }
                else if ((Number2 == 1) && (Number == 1))
                {
                    Console.WriteLine("2 Players Selected!");
                    Console.WriteLine();
                    Console.Write("Player 1 Name: ");
                    string P1 = Console.ReadLine();
                    Console.Write("Player 2 Name: ");
                    string P2 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Bullet Has Been Loaded");
                    Console.WriteLine();
                    for (int a = 0; a < 100; a++)
                    {
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(P1 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Console.WriteLine(P1 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (P1 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(P1 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P2 + " Won the gamble!");
                            break;
                        }
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(P2 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        Console.WriteLine(P2 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (P2 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(P2 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + " Won the gamble!");
                            break;
                        }
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        continue;
                    }

                }
                //3 Players

                //3 Players

                //3 Players

                //3 Players

                //3 Players

                //3 Players

                //3 Players

                //3 Players
                else if ((Number == 1) && (Number2 == 2))
                {
                    Console.WriteLine("3 Players Selected!");
                    Console.WriteLine();
                    Console.Write("Player 1 Name: ");
                    string P1 = Console.ReadLine();
                    Console.Write("Player 2 Name: ");
                    string P2 = Console.ReadLine();
                    Console.Write("Player 3 Name: ");
                    string P3 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Bullet Has Been Loaded");
                    Console.WriteLine();
                    for (int a = 0; a < 100; a++)
                    {
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(P1 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Console.WriteLine(P1 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (P1 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(P1 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P2 + " and " + P3 + " Won the gamble!");
                            break;
                        }
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(P2 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        Console.WriteLine(P2 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (P2 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(P2 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + " and " + P3 + " Won the gamble!");
                            break;
                        }
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(P3 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        Console.WriteLine(P3 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (P3 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(P3 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + " and " + P2 + " Won the gamble!");
                            break;
                        }
                    }
                }




                //4 Player



                else if ((Number == 1) && (Number2 == 3))
                {
                    Console.WriteLine("4 Players Selected!");
                    Console.WriteLine();
                    Console.Write("Player 1 Name: ");
                    string P1 = Console.ReadLine();
                    Console.Write("Player 2 Name: ");
                    string P2 = Console.ReadLine();
                    Console.Write("Player 3 Name: ");
                    string P3 = Console.ReadLine();
                    Console.Write("Player 4 Name: ");
                    string P4 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Bullet Has Been Loaded");
                    Console.WriteLine();
                    for (int a = 0; a < 100; a++)
                    {


                        //P1


                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(P1 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Console.WriteLine(P1 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (P1 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(P1 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P2 + ", " + P3 + ", " + P4 + " Won the gamble!");
                            break;
                        }

                        //P2

                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(P2 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        Console.WriteLine(P2 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (P2 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(P2 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + ", " + P3 + ", " + P4 + " Won the gamble!");
                            break;
                        }

                        //P3

                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(P3 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        Console.WriteLine(P3 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (P2 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(P3 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + ", " + P2 + ", " + P4 + " Won the gamble!");
                            break;
                        }

                        //P4




                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(P4 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        Console.WriteLine(P4 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (P4 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(P4 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + ", " + P2 + ", " + P3 + " Won the gamble!");
                            break;
                        }
                    }
                }




                //-----------------------------------------------------------------------------------------------------------P5




                else if ((Number == 1) && (Number2 == 4))
                {
                    Console.WriteLine("5 Players Selected!");
                    Console.WriteLine();
                    Console.Write("Player 1 Name: ");
                    string P1 = Console.ReadLine();
                    Console.Write("Player 2 Name: ");
                    string P2 = Console.ReadLine();
                    Console.Write("Player 3 Name: ");
                    string P3 = Console.ReadLine();
                    Console.Write("Player 4 Name: ");
                    string P4 = Console.ReadLine();
                    Console.Write("Player 5 Name: ");
                    string P5 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Bullet Has Been Loaded");
                    Console.WriteLine();
                    for (int a = 0; a < 100; a++)
                    {


                        //P1


                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(P1 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Console.WriteLine(P1 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (P1 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(P1 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P2 + ", " + P3 + ", " + P4 + ", " + P5 + " Won the gamble!");
                            break;
                        }

                        //P2

                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(P2 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        Console.WriteLine(P2 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (P2 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(P2 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + ", " + P3 + ", " + P4 + ", " + P5 + " Won the gamble!");
                            break;
                        }

                        //P3

                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(P3 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        Console.WriteLine(P3 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (P2 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(P3 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + ", " + P2 + ", " + P4 + ", " + P5 + " Won the gamble!");
                            break;
                        }


                        //P4


                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(P4 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        Console.WriteLine(P4 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (P4 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(P4 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + ", " + P2 + ", " + P3 + ", " + P5 + " Won the gamble!");
                            break;
                        }


                        //P5


                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(P5 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        Console.WriteLine(P5 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (P5 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(P5 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + ", " + P2 + ", " + P3 + ", " + P4 + " Won the gamble!");
                            break;
                        }
                    }





                    //-----------------------------------------------------------------------------------------------------------P6






                }
                else if ((Number == 1) && (Number2 == 4))
                {
                    Console.WriteLine("5 Players Selected!");
                    Console.WriteLine();
                    Console.Write("Player 1 Name: ");
                    string P1 = Console.ReadLine();
                    Console.Write("Player 2 Name: ");
                    string P2 = Console.ReadLine();
                    Console.Write("Player 3 Name: ");
                    string P3 = Console.ReadLine();
                    Console.Write("Player 4 Name: ");
                    string P4 = Console.ReadLine();
                    Console.Write("Player 5 Name: ");
                    string P5 = Console.ReadLine();
                    Console.Write("Player 6 Name: ");
                    string P6 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Bullet Has Been Loaded");
                    Console.WriteLine();
                    for (int a = 0; a < 100; a++)
                    {


                        //P1


                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(P1 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Console.WriteLine(P1 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (P1 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(P1 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P2 + ", " + P3 + ", " + P4 + ", " + P5 + ", " + P6 + " Won the gamble!");
                            break;
                        }

                        //P2

                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(P2 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        Console.WriteLine(P2 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (P2 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(P2 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + ", " + P3 + ", " + P4 + ", " + P5 + ", " + P6 + " Won the gamble!");
                            break;
                        }

                        //P3

                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(P3 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        Console.WriteLine(P3 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (P2 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(P3 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + ", " + P2 + ", " + P4 + ", " + P5 + ", " + P6 + " Won the gamble!");
                            break;
                        }


                        //P4


                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(P4 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        Console.WriteLine(P4 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (P4 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(P4 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + ", " + P2 + ", " + P3 + ", " + P5 + ", " + P6 + " Won the gamble!");
                            break;
                        }


                        //P5


                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(P5 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        Console.WriteLine(P5 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (P5 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(P5 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + ", " + P2 + ", " + P3 + ", " + P4 + ", " + P6 + " Won the gamble!");
                            break;
                        }



                        //P6


                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(P6 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        Console.WriteLine(P6 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (P6 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(P6 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + ", " + P2 + ", " + P3 + ", " + P4 + ", " + P5 + " Won the gamble!");
                            break;
                        }
                    }
                }

                else if ((Number2 == 1) && (Number == 2))
                {
                    Console.WriteLine("2 Players (1 BOT) Selected!");
                    Console.WriteLine();
                    Console.Write("Player 1 Name: ");
                    string P1 = Console.ReadLine();
                    Console.WriteLine("Player 2 Name: " + BOT1);
                    Console.WriteLine();
                    Console.WriteLine("Bullet Has Been Loaded");
                    Console.WriteLine();
                    for (int a = 0; a < 100; a++)
                    {
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(P1 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Console.WriteLine(P1 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (P1 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(P1 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(BOT1 + " Won the gamble!");
                            break;
                        }
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(BOT1 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        Console.WriteLine(BOT1 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (BOT1 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(BOT1 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + " Won the gamble!");
                            break;
                        }
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                    }

                }

                //3 Players

                //3 Players

                //3 Players

                //3 Players

                //3 Players

                //3 Players

                //3 Players

                //3 Players
                else if ((Number == 2) && (Number2 == 2))
                {
                    Console.WriteLine("3 Players (2 BOT) Selected!");
                    Console.WriteLine();
                    Console.Write("Player 1 Name: ");
                    string P1 = Console.ReadLine();
                    Console.WriteLine("Player 2 Name: " + BOT1);
                    Console.Write("Player 3 Name: " + BOT2);
                    Console.WriteLine();
                    Console.WriteLine("Bullet Has Been Loaded");
                    Console.WriteLine();
                    for (int a = 0; a < 100; a++)
                    {
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(P1 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Console.WriteLine(P1 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (P1 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(P1 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(BOT1 + " and " + BOT2 + " Won the gamble!");
                            break;
                        }
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(BOT1 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        Console.WriteLine(BOT1 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (BOT1 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(BOT1 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + " and " + BOT2 + " Won the gamble!");
                            break;
                        }
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(BOT2 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        Console.WriteLine(BOT2 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (BOT2 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(BOT2 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + " and " + BOT1 + " Won the gamble!");
                            break;
                        }
                    }
                }





                //4 Player



                else if ((Number == 2) && (Number2 == 3))
                {
                    Console.WriteLine("4 Players (3 BOT) Selected!");
                    Console.WriteLine();
                    Console.Write("Player 1 Name: ");
                    string P1 = Console.ReadLine();
                    Console.WriteLine("Player 2 Name: " + BOT1);
                    Console.WriteLine("Player 3 Name: " + BOT2);
                    Console.WriteLine("Player 4 Name: " + BOT3);
                    Console.WriteLine();
                    Console.WriteLine("Bullet Has Been Loaded");
                    Console.WriteLine();
                    for (int a = 0; a < 100; a++)
                    {


                        //P1


                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(P1 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Console.WriteLine(P1 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (P1 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(P1 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(BOT1 + ", " + BOT2 + ", " + BOT3 + " Won the gamble!");
                            break;
                        }

                        //P2

                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(BOT2 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        Console.WriteLine(BOT2 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (BOT2 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(BOT2 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + ", " + BOT2 + ", " + BOT3 + " Won the gamble!");
                            break;
                        }

                        //P3

                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(BOT2 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        Console.WriteLine(BOT2 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (BOT2 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(BOT2 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + ", " + BOT1 + ", " + BOT3 + " Won the gamble!");
                            break;
                        }

                        //P4




                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(BOT3 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        Console.WriteLine(BOT3 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (BOT3 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(BOT3 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + ", " + BOT1 + ", " + BOT1 + " Won the gamble!");
                            break;
                        }
                    }

                }

                else if ((Number == 2) && (Number2 == 4))
                {
                    Console.WriteLine("5 Players (4 BOT) Selected!");
                    Console.WriteLine();
                    Console.Write("Player 1 Name: ");
                    string P1 = Console.ReadLine();
                    Console.WriteLine("Player 2 Name: " + BOT1);
                    Console.WriteLine("Player 3 Name: " + BOT2);
                    Console.WriteLine("Player 4 Name: " + BOT3);
                    Console.WriteLine("Player 5 Name: " + BOT4);
                    Console.WriteLine();
                    Console.WriteLine("Bullet Has Been Loaded");
                    Console.WriteLine();
                    for (int a = 0; a < 100; a++)
                    {


                        //P1


                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(P1 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Console.WriteLine(P1 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (P1 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(P1 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(BOT1 + ", " + BOT2 + ", " + BOT3 + ", " + BOT4 + " Won the gamble!");
                            break;
                        }


                        //P2


                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(BOT1 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Console.WriteLine(BOT1 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (BOT1 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(BOT1 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + ", " + BOT2 + ", " + BOT3 + ", " + BOT4 + " Won the gamble!");
                            break;
                        }


                        //P3


                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(BOT2 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Console.WriteLine(BOT2 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (BOT2 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(BOT2 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + ", " + BOT1 + ", " + BOT3 + ", " + BOT4 + " Won the gamble!");
                            break;
                        }


                        //P4


                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(BOT3 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Console.WriteLine(BOT3 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (BOT3 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(BOT3 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + ", " + BOT1 + ", " + BOT2 + ", " + BOT4 + " Won the gamble!");
                            break;
                        }


                        //P5


                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(BOT4 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Console.WriteLine(BOT4 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (BOT4 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(BOT4 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + ", " + BOT1 + ", " + BOT2 + ", " + BOT3 + " Won the gamble!");
                            break;
                        }
                    }

                }
                else if ((Number == 2) && (Number2 == 5))
                {
                    Console.WriteLine("6 Players (5 BOT) Selected!");
                    Console.WriteLine();
                    Console.Write("Player 1 Name: ");
                    string P1 = Console.ReadLine();
                    Console.WriteLine("Player 2 Name: " + BOT1);
                    Console.WriteLine("Player 3 Name: " + BOT3);
                    Console.WriteLine("Player 4 Name: " + BOT3);
                    Console.WriteLine("Player 5 Name: " + BOT4);
                    Console.WriteLine("Player 6 Name: " + BOT5);
                    Console.WriteLine();
                    Console.WriteLine("Bullet Has Been Loaded");
                    Console.WriteLine();
                    for (int a = 0; a < 100; a++)
                    {


                        //P1


                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(P1 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Console.WriteLine(P1 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (P1 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(P1 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(BOT1 + ", " + BOT2 + ", " + BOT3 + ", " + BOT4 + ", " + BOT5 + " Won the gamble!");
                            break;
                        }


                        //P2


                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(BOT1 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Console.WriteLine(BOT1 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (BOT1 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(BOT1 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + ", " + BOT2 + ", " + BOT3 + ", " + BOT4 + ", " + BOT5 + " Won the gamble!");
                            break;
                        }

                        //P3


                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(BOT2 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Console.WriteLine(BOT2 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (BOT2 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(BOT2 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + ", " + BOT1 + ", " + BOT3 + ", " + BOT4 + ", " + BOT5 + " Won the gamble!");
                            break;
                        }

                        //P4


                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(BOT3 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Console.WriteLine(BOT3 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (BOT3 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(BOT3 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + ", " + BOT1 + ", " + BOT2 + ", " + BOT4 + ", " + BOT5 + " Won the gamble!");
                            break;
                        }

                        //P5


                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(BOT4 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Console.WriteLine(BOT4 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (BOT4 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(BOT4 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + ", " + BOT1 + ", " + BOT2 + ", " + BOT3 + ", " + BOT5 + " Won the gamble!");
                            break;
                        }

                        //P6


                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(BOT5 + "'s Turn");
                        Console.WriteLine();
                        Console.WriteLine("3");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("2");
                        Thread.Sleep(milliseconds);
                        Console.WriteLine("1");
                        Console.WriteLine();
                        Console.WriteLine(BOT5 + " Pulled The Trigger");
                        Console.WriteLine();
                        Thread.Sleep(milliseconds);
                        if ((rng.Next(1, 4) == 3) && (BOT5 != "~"))
                        {
                            Console.WriteLine("--------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine(BOT5 + " is dead!");
                            Console.WriteLine();
                            Console.WriteLine(P1 + ", " + BOT1 + ", " + BOT2 + ", " + BOT3 + ", " + BOT4 + " Won the gamble!");
                            break;
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Once More?");
                Console.WriteLine();
                Console.Write("Y to Retry and N to Stop: ");
                ReNo = Console.ReadLine();
            } while ((ReNo == "y" ) || (ReNo == "Y" ));
            if ((ReNo == "N") || (ReNo == "n"))
            {
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Rest In Peace");
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine();

            }

            
        }
    }
}