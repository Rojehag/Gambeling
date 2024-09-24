namespace Gambeling
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            
                Console.WriteLine("Welcome to the gamblers den.");

                string Playagian = "Yes";
                while (Playagian.ToLower().Trim() == "yes")
                {
                    Random rand = new();
                    int Dice = rand.Next(1, 7);
                    int playersum = 0;
                    int DealerSum = 0;


                    Console.WriteLine("Do you want to throw? Yes or No");
                    string thro = Console.ReadLine();


                    while (thro.ToLower().Trim() != "no" || DealerSum < 19)
                    {
                        if (DealerSum > 21 || playersum > 21)
                        {
                            break;
                        }

                        if (DealerSum < 19)
                        {
                            Dice = rand.Next(1, 7);

                            Console.WriteLine("\n" + "The dealer got: " + Dice);
                            DealerSum += Dice;
                            Console.WriteLine("The dealers total is: " + DealerSum + "\n");
                        }
                        else if (DealerSum >= 19)
                        {
                            Console.WriteLine("Dealer is out." + "\n");

                        }

                        if (thro.ToLower().Trim() == "yes")
                        {
                            Dice = rand.Next(1, 7);

                            Console.WriteLine("Your throw is: " + Dice);
                            playersum += Dice;
                            Console.WriteLine("Your total is: " + playersum);

                            Console.WriteLine("Do you want to throw again? Yes Or No?");
                            thro = Console.ReadLine();
                        }



                    }

                    if (thro.ToLower().Trim() == "no" && DealerSum >= 19)
                    {
                        Console.WriteLine("Your total is: " + playersum);
                        Console.WriteLine("The dealers total is: " + DealerSum);

                    }
                    if (playersum > 21 && DealerSum > 21)
                    {
                        Console.WriteLine("You both has gone over 21!");
                    }
                    else if (playersum > 21 && DealerSum <= 21)
                    {
                        Console.WriteLine("Dealer won because you went over!");
                    }
                    else if (playersum <= 21 && DealerSum > 21)
                    {
                        Console.WriteLine("You won because dealer went over!");
                    }
                    else if (playersum == DealerSum)
                    {
                        Console.WriteLine("Dealer won because its the rules!");
                    }
                    else if (playersum > DealerSum)
                    {
                        Console.WriteLine("Player win because he got closer to 21!");
                    }
                    else if (playersum < DealerSum)
                    {
                        Console.WriteLine("Dealer won because he got closer to 21!");

                    }
                    Console.WriteLine("Do you want to play agian? Yes or No.");
                    Playagian = Console.ReadLine();

                }

                Console.WriteLine("Thank you for playing.");
           
        }
    }

}
