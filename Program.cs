#region Ex. 1, Answer Confirmer. Stan's First Steps.
/*internal class Program
{
    private static void Main(string[] args)
    {
        //Define the lil cutie- I MEAN! Define the answer strings.
        string grassQuestion;
        string confirmQuestion;


        Console.WriteLine("Do you like to play a game of Cutting Grass?");
        Console.WriteLine("Please type YES or NO.");

        grassQuestion = Console.ReadLine();

        Console.WriteLine("Your answer is {0}", grassQuestion);
        Console.WriteLine("Is that correct? Please say YES or NO.");

        confirmQuestion = Console.ReadLine();

        Console.WriteLine("So be it. Your answer is: " + confirmQuestion );
    }
}
*/
#endregion
#region Ex. 2, Giving the Correct Answer
/* internal class program
{
    private static void Main(string[] args)
    {
        string Truth = "My works are hidden within these halls. 94568857 is a number dearest to you.";
        string confirm;

        Console.WriteLine("Do you wish to know more about this place... this hideous place?");
        Console.Write("Then we shall begin soon. State the ID.");
        //Starting

        confirm = Console.ReadLine();
        
        if (confirm == "I'm Ready")
        {
            Console.WriteLine("Very well.");
            Console.Write(Truth);
        }
        else
        {
            Console.WriteLine("Foolish.");
        }
    }
}
#endregion
*/
#endregion
#region Ex. 3, Agechecker

//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        // Declaring vars
//        int minAge;
//        int maxAge;
//        int givenAge;

//        //giving them a value
//        minAge = 18;
//        maxAge = 96;

//        Console.WriteLine("Hi, can I haz ur age pls????");
//        Console.WriteLine("Plish just put it in already :(");

//        //Input
//        Int32.TryParse(Console.ReadLine(), out givenAge);

//        //Using the swag
//        AgeChecker();

//        //define the swag
//        void AgeChecker()
//        {

//            if (givenAge <= minAge || givenAge >= maxAge) //If out of agerange
//            {
//                Console.WriteLine("NO!");
//            }
//            else //If IN range
//            {
//                Console.WriteLine("Oh my goodness gracious");
//            }
//        }
//    }
//}
#endregion
#region Ex. 4, Void Numberchecker()
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        int num;
//        string Nicething;


//        void NumberChecker()
//        {
//            Console.WriteLine("Boob lol");
//            num = int.Parse(Console.ReadLine());
//            //goods

//            Nicething = "Ф Р Е Д О М";
//        }
//    }
//}
#endregion
#region Ex. 5, Roll 5 times
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        //creating fortnite
//        Random rnd = new Random();

//        //Playing 5 rounds of fortnite
//        void roll()
//        {
//            int roll = rnd.Next(1, 7);
//            Console.WriteLine(roll);
//        }
//        //Number Rolling!!!
//        roll();
//        roll();
//        roll();
//        roll();
//        roll();
//    }
//}
#endregion
#region Ex. 6, Random Number Generator

//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        //Creating rnd
//        Random rnd = new Random();

//        //who asked?
//        int minValue;
//        int maxValue;
//        int timesRolled;

//        //Getting min
//        Console.WriteLine("STATE MINIMUM VALUE");
//        Int32.TryParse(Console.ReadLine(), out minValue);

//        //Getting max
//        Console.WriteLine("STATE MAXIMUM VALUE");
//        Int32.TryParse(Console.ReadLine(), out maxValue);
//        maxValue = maxValue + 1;

//        //Getting amount of times rolled
//        Console.WriteLine("STATE AMOUNT OF TIMES ROLLED");
//        Int32.TryParse(Console.ReadLine(), out timesRolled);

//        Console.WriteLine("OKAY");

//        void roll()
//        {
//            int t;
//            t = 0;
//            while (t < timesRolled)
//            {
//                int result = rnd.Next(minValue, maxValue);
//                Console.WriteLine(result);
//                t = t + 1;
//            }
//        }
//        roll();
//        Console.WriteLine(" ROLLED " + timesRolled + " TIMES OF A VALUE BETWEEN " + minValue + " AND " + (maxValue - 1));



//    }
//}
#endregion
#region Ex. 7, Dice Value Checker
//internal class program 
//{
//    private static void Main(string[] args)
//    {
//      //Creating rnd
//        Random rnd = new Random();

//        //who asked?
//        int minValue;
//        int maxValue;
//        int timesRolled;

//        //DiceVar
//        int d1 = 0;
//        int d2 = 0;
//        int d3 = 0;

//        minValue = 1;
//        maxValue = 21;
//        timesRolled = 3;

//        void roll()
//        {
//            int t;
//            t = 1;

//            while (t <= timesRolled)
//            {
//                if (t == 1)
//                {
//                    d1 = rnd.Next(minValue, maxValue);
//                    Console.WriteLine("Roll 1: " + d1);
//                    t++;
//                }
//                if (t == 2)
//                {
//                    d2 = rnd.Next(minValue, maxValue);
//                    Console.WriteLine("Roll 2: " + d2);
//                    t++;
//                }
//                if (t == 3)
//                {
//                    d3 = rnd.Next(minValue, maxValue);
//                    Console.WriteLine("Roll 3: " + d3);
//                    t++;
//                }
//            }
//            while (d1 == d2 || d1 == d3 || d2 == d3)
//                {
//                if (d1 == d2 || d1 == d3)
//                {
//                    Console.WriteLine ("R1 not correct! Rerolling...");
//                    d1 = rnd.Next(minValue, maxValue);
//                    Console.WriteLine("Roll 1: " + d1);
//                }
//                else if (d2 == d3)
//                {
//                    Console.WriteLine ("R2 not correct! Rerolling...");
//                    d2 = rnd.Next(minValue, maxValue);
//                    Console.WriteLine("Roll 1: " + d1);
//                }
//            }
//            if (d1 > d2 && d1 > d3)
//            {
//                Console.WriteLine("Roll 1 Is Highest!");
//            }
//            if (d2 > d3 && d2 > d1)
//            {
//                Console.WriteLine("Roll 2 Is Highest!");
//            }
//            if (d3 > d2 && d3 > d1)
//            {
//                Console.WriteLine("Roll 3 Is Highest!");
//            }
//        }
//        roll();
//    }
//}
#endregion
#region Ex. 8-A Number Guessing Game
//internal class program
//{
//    private static void Main(string[] args)
//    {
//        //Definition
//        int guess = 0;
//        int turns = 1;
//        Random chosennumber = new Random();

//        //Start game
//        Console.WriteLine("Starting game! Choosing a number between 1 and 100...");
//        int random = chosennumber.Next(1, 101);
//        Console.WriteLine("Chosen!");

//        //gameplay loop
//        do
//        {
//            Console.WriteLine("It's turn " + turns + "...");
//            Console.WriteLine("Give it a shot!");
//            Int32.TryParse(Console.ReadLine(), out guess);

//            if (guess < random)
//            {
//                Console.WriteLine("Too small! Try again!");
//                turns++;
//            }
//            else if (guess > random)
//            {
//                Console.WriteLine("Too big! Try again!");
//                turns++;
//            }

//        } while (guess != random);
//        {
//            Console.WriteLine("Aw man! You beat me!");
//            Console.WriteLine("It took you " + turns + " tries!");
//        }
//    }
//}
#endregion
#region Ex. 8-B, Number Guesser, Random Method
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        //Ingredients
//        Random guess = new Random();
//        Random chosen = new Random();
//        int turns = 1;
//        int nGuess;
//        int nChosen;

//        //Initial D
//        nChosen = chosen.Next(1, 1000000);
//        Console.WriteLine("IT HAS BEGUN");
//        //Start balling
//        do
//        {
//            nGuess = guess.Next(1, 1000001);
//            Console.WriteLine("My choice is: " + nGuess);
//            if (nGuess < nChosen)
//            {
//                Console.WriteLine("IT IS LESS");
//                turns++;
//            }
//            else if (nGuess > nChosen)
//            {
//                Console.WriteLine("IT IS MORE");
//                turns++;
//            }
//        } while (nGuess != nChosen);
//        {
//            Console.WriteLine("By means of random guessing I found the number " + nChosen + " in " + turns + " turns!");
//            Console.WriteLine("GG");
//        }
//    }
//}
#endregion
#region Ex. 8-C, Efficient Number Guesser
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        {
//            //Ingredients
//            Random guess = new Random();
//            Random chosen = new Random();
//            int turns = 1;
//            int nGuess = guess.Next(1,100001);
//            int nChosen;
//            int maxVal = 100001;
//            int minVal = 1;

//            Console.WriteLine("Go ahead and put your number between 1-10000.");
//            Int32.TryParse(Console.ReadLine(), out nChosen);

//            do
//            {
//                nGuess = guess.Next(minVal, maxVal);
//                maxVal--;
//                Console.WriteLine("Generated " + nGuess + " within the parameters of " + minVal + " minimum, and " + maxVal + " maximum. This is my " + turns + "th turn.");
//                maxVal++;
//                if (nGuess < nChosen)
//                {
//                    Console.WriteLine("Guess I was too low");
//                    turns++;
//                    minVal = nGuess;
//                } else if (nGuess > nChosen)
//                {
//                    Console.WriteLine("Guess I was too high");
//                    turns++;
//                    maxVal = nGuess;
//                }
//            } while (nGuess != nChosen);
//            {
//                Console.WriteLine("Wow! Apparently I knew it in " + turns + " turns!");
//                Console.WriteLine("GG!");
//            }
//        }
//    }
//}
#endregion
#region Ex. 9, Thirteen Counted
//internal class Program
//{
//    private static void Main(String[] args)
//    {
//        for (int i = 1; i < 50; i++)
//        {
//            //Write down all numbers as usual
//            //Just, as they come
//            //BUT!
//            //Write out the number 13 as "Thirteen" in text!
//            if (i != 13)
//            {
//                Console.WriteLine(i + ".");
//            }
//            else if (i == 13)
//            {
//                Console.WriteLine("Thirteen.");
//            }
//        }
//    }
//}
#endregion
#region Ex. 10, Written Thirteen
//using System;
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        bool result;
//        int number;
//        string myString = "Omg I'm a string";
//        string myString2 = "13";

//        result = int.TryParse(myString2, out number);
//        Console.WriteLine(result);
//        Console.WriteLine(number);
//    }
//}
//#endregion
//#region Ex. 11
//internal class Program
//{
//    private static void Main(string[] args)
//    {

//    }
//}
#endregion
#region Ex. 11, TryParse and the Selection Screen
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        bool chosen;
//        string userI;
//        int userL;
//        do
//        {
//            Console.WriteLine("Welcome to the selection interface!");
//            Console.WriteLine("Type '1' for option 1");
//            Console.WriteLine("Type '2' for option 2");
//            Console.WriteLine("Type '3' for option 3");
//            Console.WriteLine("Please type your selected option!");

//            userI = Console.ReadLine();
//            chosen = int.TryParse(userI, out userL);


//        } while (!chosen || userL < 1 || userL > 3);

//    }

//}
#endregion
#region Ex. 12, Modulo
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        int max = 100;
//        for (int i = 1; i <= 100; i++)
//        {
//            if (i%2 == 0 && i%7 == 0)
//            {
//                Console.WriteLine("Bliep");
//            } else if (i%2 == 0)
//            {
//                Console.WriteLine("Blap");
//            } else if (i%7 == 0)
//            {
//                Console.WriteLine("Bloep");
//            } else
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}
#endregion
#region Ex. 13, Nested Loops 1
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        int turn = 1;
//        int turn2 = 1;
//        int maxed1 = 0;
//        int maxed2 = 0;
//        int add;
//        Random random = new Random();
//        Random random2 = new Random();
//        Random random3 = new Random();

//        for (int i = 1; turn < random2.Next(1,10000000);)
//        {
//            for (int v = 1; turn2 < random3.Next(1, 10000000);)
//            {
//                add = random.Next(1, 1001);
//                Console.WriteLine(v);
//                Console.WriteLine(i);
//                i = i + add;
//                v = v + add;
//                turn++;
//                turn2++;

//                if (i >= 100000)
//                {
//                    i = 0;
//                    maxed1++;
//                } else if (v >= 100000)
//                {
//                    v = 0;
//                    maxed2++;
//                }
//            }
//        }

//        Console.WriteLine("Exited with " + maxed1 + "and " + maxed2);
//    }
//}
#endregion
#region Ex. 14, Nested Loops 2
//using System.ComponentModel.DataAnnotations;

//namespace throwable
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string string1 = "*x*x*x*x*";
//            string string2 = "x*x*x*x*x";
//            Random random = new Random();
//            int length = random.Next(100, 501);
//            for (int i = 0; i < length; i++) //outer
//            {
//                for (int j = 0; j < length; j++)
//                {
//                    if (j%2 == 0)
//                    {
//                        Console.Write(string1);
//                    } else if (j%2 == 1)
//                    {
//                        Console.Write(string2);
//                    }
//                }
//            }
//        }
//    }
//}
#endregion
#region Ex. 15, Arrays
//namespace arrays
//{
//    internal class program
//    {
//        private static void Main(string[] args)
//        {
//            int[] dice = { 10, 8, 3 };
//            string[] words = { "Hello", "World" };
//            dice[0] = 23;
//            dice[1] = 12;
//            dice[2] = 5;
//            foreach (int i in dice)
//            {
//                Console.WriteLine(i);
//            }
//            Console.WriteLine("Longitude: " + dice.Length);
//        }
//    }
//}
#endregion
#region Ex. 16, Arrays and Dicegames
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        //setup
//        int[] dicelist = new int[6];
//        Random random = new Random();
//        int roll = 0;
//        int p1bal = 0;
//        int p2bal = 0;
//        int rounds = 0;

//        //intro
//        Console.WriteLine("Please set the amount of rounds to generate.");
//        Int32.TryParse(Console.ReadLine(), out rounds);
//        Console.WriteLine("You are playing " + rounds + " rounds.");
//        Console.ReadKey();

//        //Gamplay loop
//        for (int v = 0; v < dicelist.Length; v++)
//        {
//            dicelist[v] = random.Next(1,7);
//        }
//        Console.WriteLine("The results are: ");
//        for (int i = 0; i < dicelist.Length; i++)
//        {
//            Console.WriteLine(dicelist[i]);
//        }
//    }
//}
#endregion
#region Ex. 17, Request index
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        string ReqString = "blah";
//        int ReqNum = 0;
//        int[] numArray;
//        numArray = new int[4];
//        numArray[0] = 10;
//        numArray[1] = 20;
//        numArray[2] = 30;
//        numArray[3] = 40;

//        Console.WriteLine("Welcome, type in your item from the list (1-4)");
//        do
//        {
//            ReqString = Console.ReadLine();
//            Int32.TryParse(ReqString, out ReqNum);
//        }
//        while (ReqNum < 1 || ReqNum > 4);
//        //Converting down to index
//        ReqNum--;

//        Console.WriteLine("Your request is: " + numArray[ReqNum]);
//    }
//}
#endregion
#region Ex. 18, Player name input
//internal class program
//{
//    private static void Main(String[] args)
//    {
//        string playerinput = "no";
//        string[] Players;
//        Players = new string[4];

//        for (int i = 0; i < Players.Length; i++)
//        {
//            Console.WriteLine("Please put in the name of the players. " + "Current player: " + (i + 1));
//            Players[i] = Console.ReadLine();

//        }
//        Console.WriteLine("");
//        bool questionnaire = true;
//        do
//        {
//            Console.Write("The players are: ");
//            for (int i = 0; i < Players.Length; i++)
//            {
//                if (i != 3)
//                {
//                    Console.Write(Players[i] + ", ");
//                }
//                else if (i == 3)
//                {
//                    Console.Write(Players[i] + ".");
//                }
//            }
//            Console.WriteLine(" Is this correct?");

//            playerinput = Console.ReadLine();

//            if (playerinput == "Yes")
//            {
//                Console.WriteLine("Alright, thanks you for confirming.");
//                questionnaire = false;
//            } else if (playerinput == "No")
//            {
//                Console.WriteLine("Please restart the program and enter the right names.");
//                questionnaire = false;
//            }
//        } while (questionnaire == true);
//        System.Environment.Exit(0);
//    }
//}
#endregion
#region Ex. 19, Russian Roulette or smth
//using System.Security.Cryptography.X509Certificates;

//internal class program
//{
//    private static void Main(string[] args)
//    {
//        bool dead = false;
//        bool[] chamber;
//        chamber = new bool[6];
//        Random bullet = new Random();
//        int difmod = 0; //bulletless by default
//        int countbullet = 0;

//        Console.WriteLine("Choose your diffeculty.");
//        do
//        {
//            Console.WriteLine("Type \"easy\", \"medium\", or \"hard\"");
//            Console.WriteLine(" ");
//            string answer = Console.ReadLine();
//            if (answer == "easy")
//            {
//                Console.WriteLine("You've selected \"easy\"");
//                difmod = 1;
//            }
//            else if (answer == "medium")
//            {
//                Console.WriteLine("You've selected \"medium\"");
//                difmod = 2;
//            }
//            else if (answer == "hard")
//            {
//                Console.WriteLine("You've selected \"hard\"");
//                difmod = 3;
//            }
//        } while (difmod == 0);
//        do
//        {
//            for (int i = 0; i < 6; i++)
//            {
//                bullet.Next(1, 3);
//                if (bullet.Next(1, 3) == 1)
//                {
//                    chamber[i] = true;
//                }
//                else if (bullet.Next(1, 3) == 2)
//                {
//                    chamber[i] = false;
//                }
//                if (chamber[i] == true)
//                {
//                    if (countbullet < difmod)
//                    {
//                        countbullet++;
//                        Console.WriteLine("Bullet added!");
//                        Console.WriteLine("Current bullets: " + countbullet + " bullets.");
//                    }
//                    else if (countbullet >= difmod && chamber[i] == false)
//                    {
//                        Console.WriteLine("No bullets avaiable!");
//                    }
//                }

//            }
//        } while (countbullet != difmod);

//        void Shoot(int bullets)
//        {
//            int start = bullet.Next(0, 6);
//            for (int v = 0; v < bullets; v++)
//            {
//                start = v;
//                if (chamber[v] == true && !dead)
//                {
//                    Console.WriteLine("BANG!");
//                    Console.WriteLine("You died!");
//                    dead = true;
//                }
//                else if (chamber[v] == false)
//                {
//                    Console.WriteLine("*Click*");
//                    if (dead)
//                    {
//                        System.Environment.Exit(0);
//                    }
//                    else if (v != 5)
//                    {
//                        v++;
//                    }
//                    else if (v == 5)
//                    {
//                        v = 0;
//                    }
//                }
//                Console.WriteLine("Shot " + bullets + " times.");
//            }
//        }

//        int round = 1;
//        do
//        {
//            Console.WriteLine("How much times do you want to shoot? Min 1. Max 5.");
//            string choiceS = Console.ReadLine(); //1 by default
//            int choice;
//            Int32.TryParse(choiceS, out choice);

//            Shoot(choice);
//            round++;
//        } while (round <= difmod);

//        Console.WriteLine("Congrats, you survived. Good job.");
//    }
//}
#endregion
#region Ex. 20, Simulating roulette
//internal class program
//{
//    private static void Main(string[] args)
//    {
//        bool deadSim = false;
//        int DeadSims = 0;
//        int AliveSims = 0;
//        int BulletsFired = 0;
//        int RoundsPlayed = 0;
//        int times = 0;
//        string choice = "1000"; //1000 by default

//        void Simulate(int times)
//        {
//            for (int i = 0; i <= times; i++)
//            {
//                deadSim = false;
//                bool[] chamber;
//                chamber = new bool[6];
//                Random bullet = new Random();
//                Random SimMod = new Random();
//                int difmod = 0; //bulletless by default
//                int countbullet = 0;

//                difmod = SimMod.Next(1, 4);
//                do
//                {
//                    for (int g = 0; g < 6; g++)
//                    {
//                        bullet.Next(1, 3);
//                        if (bullet.Next(1, 3) == 1)
//                        {
//                            chamber[g] = true;
//                        }
//                        else if (bullet.Next(1, 3) == 2)
//                        {
//                            chamber[g] = false;
//                        }
//                        if (chamber[g] == true)
//                        {
//                            if (countbullet < difmod)
//                            {
//                                countbullet++;
//                            }
//                        }

//                    }
//                } while (countbullet != difmod);

//                void Shoot(int bullets)
//                {
//                    int start = bullet.Next(0, 6);
//                    for (int v = 0; v < bullets; v++)
//                    {
//                        start = v;
//                        if (chamber[v] == true && !deadSim)
//                        {
//                            deadSim = true;
//                        }
//                        if (chamber[v] == false)
//                        {
//                            BulletsFired++;
//                            if (v != 5)
//                            {
//                                v++;
//                            }
//                            if (v == 5)
//                            {
//                                v = 0;
//                            }
//                        }
//                    }
//                }

//                int round = 1;
//                do
//                {
//                    Shoot(difmod);
//                    round++;
//                    RoundsPlayed++;
//                } while (round <= difmod);

//                Console.WriteLine("Round " + i + " , physical round " + RoundsPlayed);
//                if (deadSim)
//                {
//                    DeadSims++;
//                    Console.WriteLine("Lost, " + countbullet + "  bullets fired, " + difmod + " rounds");
//                }
//                else if (!deadSim)
//                {
//                    AliveSims++;
//                    Console.WriteLine("Won, " + countbullet + "  bullets fired, " + difmod + " rounds");
//                }
//            }

//        }

//        Console.WriteLine("How much rounds to simulate?");
//        Int32.TryParse(Console.ReadLine(), out times);

//        Simulate(times);
//        Console.WriteLine("Simulated " + times + " rounds, of which " + DeadSims + " were lost and " + AliveSims + " were won. There were " + RoundsPlayed + "  rounds played, and " + BulletsFired + " bullets fired.");
//    }
//}
#endregion
#region Ex. 21, For(each)
//using Microsoft.VisualBasic;

//internal class program
//{
//    private static void Main(string[] args)
//    {
//        int[] numArray;
//        numArray = new int[5];
//        for (int i = 0; i  < 5; i++)
//        {
//            numArray[i] = i + 1;
//            Console.WriteLine(numArray[i]); 
//        }
//        foreach (int n in numArray)
//        {
//            Console.WriteLine(n);
//        }
//    }
//}
#endregion
#region Ex. 22, Player Arrays
//internal class program
//{
//    private static void Main(string[] args)
//    {
//        string[] players = new string[5];
//        int[] results = new int[5];
//        Random random = new Random();
//        for(int i = 0; i < players.Length; i++)
//        {
//            /*
//            * 1. Console.WriteLine for player names
//            * 
//            * 2. Console.ReadLine() to fill players[i]
//            * 
//            * 3. Let everyone throw a die
//            * ======================================
//            */
//            //Registration
//            Console.WriteLine("Please write the name of Player " + (players[i] +1));
//            players[i] = Console.ReadLine();
//        }
//        //Confirmation
//        Console.WriteLine("The players are: ");
//        for(int v = 0; v < players.Length; v++) 
//        {
//            if (v != 4)
//            { 
//                Console.Write(players[v] + ", ");
//            }
//            else if (v == 4)
//            {
//                Console.WriteLine(players[v] + ".");
//            }
//        }

//        //Rolling dice
//        void Roll()
//        {
//            for(int x = 0; x < players.Length; x++)
//            {
//                results[x] = random.Next(1,7);
//                Console.WriteLine(players[x] + " has rolled " + results[x] + ".");
//            }
//        }

//        Roll();

//    }
//}
#endregion
#region Ex.23, Friends List
//internal class program
//{
//    private static void Main(string[] args)
//    {
//        List<String> FriendsList = new List<String>();
//        FriendsList.Add("Binah");
//        FriendsList.Add("Malkuth");
//        FriendsList.Add("Argalia");
//        FriendsList.Add("Roland");

//        //foreach(String s in FriendsList)
//        //{
//        //    Console.WriteLine(s + " is my imaginary friend!");
//        //}

//        List<int> rNumbers = new List<int>();
//        Random r = new Random();
//        for (int i = 0; i < 1000000; i++)
//        { 
//            rNumbers.Add(r.Next(1, 1000));
//        }
//        for (int v = 0; v < 10000; v++)
//        {
//            rNumbers.Insert(0, 2);
//        }
//        rNumbers.Sort();
//        rNumbers.Reverse();
//        foreach (int i in rNumbers)
//        {
//            if (i % 2 == 0)
//            {
//                Console.Write("1");
//            }
//            else if (i % 2 == 1)
//            {
//                Console.Write("0");
//            }
//        }
//        List<string> rStrings = new List<string>();
//        Random rr= new Random();
//        for(int x = 0; x < 1000000; x++)
//        {
//            int rrr = rr.Next(1, 6);
//            if (rrr == 1) 
//            {
//                rStrings.Add("A");
//            }
//            else if (rrr == 2)
//            {
//                rStrings.Add("E");
//            }
//            else if (rrr == 3)
//            {
//                rStrings.Add("I");
//            }
//            else if (rrr == 4)
//            {
//                rStrings.Add("O");
//            }
//            else if (rrr == 5)
//            {
//                rStrings.Add("U");
//            }
//        }
//        rStrings.RemoveRange(4, 3);
//        rStrings.Sort();
//        rStrings.Reverse();
//        foreach(string c in rStrings)
//        {
//            Console.Write(c);
//        }
//    }
//}
#endregion
#region Ex. 24, Groceries!
//using System.Runtime.InteropServices;

//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        List<string> Names = new List<string>();
//        Names.Add("Roland");
//        Names.Add("Bon");
//        Names.Add("Stof");
//        Names.Add("Chris");
//        Names.Add("Ugnius");
//        Names.Add("Levi");
//        Names.Add("Siebe");
//        Names.Add("Finn");
//        Names.Add("Vonnie");

//        Random rnd = new Random();
//        Names.RemoveAt(rnd.Next(1, 6));
//        Names.Remove("Roland");
//        Names.Insert(2, "Stan");

//        foreach(string name in Names)
//        {
//            Console.WriteLine(name);
//        }

//        List<string> GroceriesList = new List<string>();
//        GroceriesList.Add("C18H27NO3 for the pepperspray");
//        GroceriesList.Add("CHCl3 for certain gassy experiments");
//        GroceriesList.Add("K2[TaF7]. Period.");
//        GroceriesList.Add("A few monkeys from preschool.");
//        GroceriesList.Add("A sufficient grade generator. Wish I had one of those.");
//        GroceriesList.Add("And to top it off, [(Fe, Mn)Ta2O6]. For redacted purpose.");

//        List<string> OtherGroceries = new List<string>();
//        {
//            OtherGroceries.Add("Boring Industry");
//            OtherGroceries.Add("Oil");
//            OtherGroceries.Add("Potassium");
//            OtherGroceries.Add("Translucent Fluid");
//            OtherGroceries.Add("The blood of your enemies");
//            OtherGroceries.Add("Crisps");
//        }

//        List<string> MergedList = new List<string>();
//        MergedList.AddRange(GroceriesList);
//        MergedList.AddRange(OtherGroceries);
//        MergedList.Sort();
//        MergedList.Reverse();

//        foreach (string name in MergedList)
//        {
//            Console.WriteLine(name);
//        }

//        MergedList.RemoveRange(3, 6);

//        foreach (string name in MergedList)
//        {
//            Console.WriteLine(name);
//        }

//        MergedList.Clear();
//    }
//}
#endregion
#region Ex. O-1, Dicejack (work in progress)
//using System.Net.Security;

//internal class program
//{
//    private static void Main(string[] args)
//    {
//        //Prequisities
//        Random rnd = new Random();
//        int minVal = 0;
//        int maxVal = 7;
//        int winScore = 5;
//        int maxBal = 21;
//        int P1Bal = 0;
//        int P2Bal = 0;
//        int P1Score = 0;
//        int P2Score = 0;
//        int TurnMod = 1;
//        bool P1Fold = false;
//        bool P2Fold = false;

//        //Greetings
//        Console.WriteLine("Welcome!");
//        Console.WriteLine("Type 'START' to start!");
//        string answer = Console.ReadLine();

//        if (answer == "START")
//        {
//            do
//            {
//                do
//                {
//                    do
//                    {
//                        Console.WriteLine("Player 1, Hit or Fold?");
//                        string P1AskedAnswer = Console.ReadLine();
//                        if (P1AskedAnswer == "Hit" && P1Fold == false)
//                        {
//                            P1Bal = P1Bal + rnd.Next(minVal, maxVal);
//                            TurnMod = 2;
//                        }
//                        else if (P1AskedAnswer == "Fold" && P1Fold == false)
//                        {
//                            Console.WriteLine("Ended!");
//                            P1Fold = true;
//                            TurnMod = 2;

//                        }
//                        else if (P1Fold == true)
//                        {
//                            TurnMod = 2;
//                        }
//                    } while (TurnMod == 1 && P1Fold == false);
//                    do
//                    {
//                        Console.WriteLine("Player 2, Hit or Fold?");
//                        string P1AskedAnswer = Console.ReadLine();
//                        if (P1AskedAnswer == "Hit" && P2Fold == false)
//                        {
//                            P2Bal = P2Bal + rnd.Next(minVal, maxVal);
//                            TurnMod = 1;
//                        }
//                        else if (P1AskedAnswer == "Fold" && P2Fold == false)
//                        {
//                            Console.WriteLine("Ended!");
//                            TurnMod = 1;
//                            P2Fold = true;

//                        }
//                    } while (TurnMod == 2 && P2Fold == false);

//                    do
//                    {

//                        Console.WriteLine("Showdown!");
//                        Console.WriteLine("Player 1: " + P1Bal);
//                        Console.WriteLine("Player 2: " + P2Bal);
//                        if (P1Bal <= maxBal && P1Bal > P2Bal && P1Bal! > maxBal)
//                        {
//                            Console.WriteLine("Player 1 wins this round!");
//                            P1Score = P1Score + 1;
//                        }
//                        else if (P2Bal <= maxBal && P2Bal > P1Bal && P1Bal! > maxBal)
//                        {
//                            Console.WriteLine("Player 2 wins this round!");
//                            P2Score = P2Score + 1;
//                        }
//                        else if (P1Bal > maxBal && P2Bal < maxBal)
//                        {
//                            Console.WriteLine("Player 1 Busted! Player 2 Wins!");
//                            P2Score = P2Score + 1;
//                        }
//                        else if (P2Bal > maxBal && P1Bal < maxBal)
//                        {
//                            Console.WriteLine("Player 2 Busted! Player 1 Wins!");
//                            P1Score = P1Score + 1;
//                        }
//                        else if (P2Bal > maxBal && P1Bal > maxBal)
//                        {
//                            Console.WriteLine("Tie! Nobody wins!");
//                        }
//                        Console.WriteLine("Moving on...");
//                        P1Bal = 0;
//                        P2Bal = 0;
//                        P1Fold = false;
//                        P2Fold = false;
//                        if (P1Score > P2Score)
//                        {
//                            TurnMod = 2;
//                        }
//                        else if (P2Score > P1Score || P1Score == P2Score)
//                        {
//                            TurnMod = 1;
//                        }
//                    } while (P1Fold == true && P2Fold == true);
//                } while (P1Fold == false || P2Fold == false);
//            } while (P1Score < 5 || P2Score < 5);
//            if (P1Score >= winScore)
//            {
//                Console.WriteLine("Player 1 Wins!");
//            }
//            else if (P2Score >= winScore)
//            {
//                Console.WriteLine("Player 2 Wins!");
//            }
//        }
//        else if (answer != "START")
//        {
//            Console.WriteLine("That is not a valid answer! You only have ONE CHOICE. Please restart the program to try again.");
//        }
//    }
//}
#endregion
#region Ex. O-2, Reactor Game (work in progress)
using System;
using System.Collections.Generic;
using System.Drawing;

internal class program
{
    private static void Main(string[] args)
    {
        //Setting up pre-inlog functions and core mechanics
        bool corestarted = false;
        bool fail = false;
        bool exit = false;
        bool CorrectLog = false;
        int coolant = 10000;
        int coretemp = 0;
        int menumode = 1;

        Random CTD = new Random();
        int CTDC = CTD.Next(1000, 10000);
        string agreeWord;

        string menC;

        int guesscode = 0;
        int basecode = 69653;
        string baC;

        //list 1 for database
        List<string> staff = new List<string>(5);
        staff.Add("Quint");
        staff.Add("Dementrius");
        staff.Add("Binah");
        staff.Add("Martin");

        //list 2 for database
        List<int> codes = new List<int>(5);
        codes.Add(2253); //Quint
        codes.Add(3367); //Deme
        codes.Add(1413); //binah
        codes.Add(6421); //martin

        //the complicated part
        //Initializing the logins is actually easy, I just have to make basic vars for the strings and ints, right?
        int id1 = 2253;
        int id2 = 3367;
        int id3 = 1413;
        int id4 = 8913;

        string nm1 = "Quint";
        string nm2 = "Dementrius";
        string nm3 = "Binah";
        string nm4 = "Martin";
        //login
        Console.WriteLine("PLEASE INSERT CREDENTIALS");
        string crd = Console.ReadLine();
        do
        {

            if (staff.Contains(crd))
            {
                Console.WriteLine("WELCOME " + crd + "." + " BOOTING SYSTEM...");
                Console.WriteLine("==================================");
                CorrectLog = true;
            }
            else if (!staff.Contains(crd))
            {
                Console.WriteLine("WRONG CREDENTIALS ENTERED. EXITING...");
                Environment.Exit(0);
            }
        } while (CorrectLog == false);
        Console.WriteLine("SECOND LAYER OF SECURITY DETECTED");
        Console.WriteLine("PLEASE INSERT THE ACCESSCODE CORRELATED TO YOUR ACCOUNT");
        Console.WriteLine("==================================");

        //Writing prequisities in order for the system to load ONLY the given variables, not just any
        int req1 = id1;
        int req2 = id2;
        int req3 = id3;
        int req4 = id4;
        int crd1; //Code
        int crd2; //Identifier
        int logID; //IDENTITY
        bool logstate = false;

        /*
        crd1 will become the user input via tryparse

        crd 2 will check the following:
        -if crd2 = logid
        -if the LogID matches the crd
        -if the assigned code is entered in crd1

        if assigned code is entered in crd1 and is the same as req(), which also should change depending on person logging in
        */

        do
        {
            if (crd == "Quint")
            {
                logID = 1;
                crd2 = 1;
                Console.WriteLine("PLEASE INSERT YOUR ACCESSCODE");
                Int32.TryParse(Console.ReadLine(), out crd1);

                if (logID == crd2 && crd1 == req1)
                {
                    Console.WriteLine("CONFIRMED IDENTITY, LOADING...");
                    logstate = true;
                }
                else
                {
                    Console.WriteLine("INCORRECT. QUITTING PROGRAM...");
                    Environment.Exit(0);
                }
            }
            else if (crd == "Dementrius")
            {
                logID = 2;
                crd2 = 2;
                Console.WriteLine("PLEASE INSERT YOUR ACCESSCODE");
                Int32.TryParse(Console.ReadLine(), out crd1);

                if (logID == crd2 && crd1 == req2)
                {
                    Console.WriteLine("CONFIRMED IDENTITY, LOADING...");
                    logstate = true;
                }
                else
                {
                    Console.WriteLine("INCORRECT. QUITTING PROGRAM...");
                    Environment.Exit(0);
                }
            }
            else if (crd == "Binah")
            {
                logID = 3;
                crd2 = 3;
                Console.WriteLine("PLEASE INSERT YOUR ACCESSCODE");
                Int32.TryParse(Console.ReadLine(), out crd1);

                if (logID == crd2 && crd1 == req3)
                {
                    Console.WriteLine("CONFIRMED IDENTITY, LOADING...");
                    logstate = true;
                }
                else
                {
                    Console.WriteLine("INCORRECT. QUITTING PROGRAM...");
                    Environment.Exit(0);
                }
            }
            else if (crd == "Martin")
            {
                logID = 4;
                crd2 = 4;
                Console.WriteLine("PLEASE INSERT YOUR ACCESSCODE");
                Int32.TryParse(Console.ReadLine(), out crd1);

                if (logID == crd2 && crd1 == req4)
                {
                    Console.WriteLine("CONFIRMED IDENTITY, LOADING...");
                    Console.WriteLine("==================================");
                    logstate = true;
                }
                else
                {
                    Console.WriteLine("INCORRECT. QUITTING PROGRAM...");
                    Environment.Exit(0);
                }
            }
        } while (logstate == false);
        {
            Console.Write("WELCOME TO CORE INTERFACE. ");
            menumode = 1; //Setup phase
            do
            {
                Console.WriteLine("Base 69653, Riccardo Enterprises. Co");
                Console.WriteLine(" ");
                Console.Write("TYPE \"HELP\" FOR A LIST OF COMMANDS.");
                Console.WriteLine("");
                Console.WriteLine("==================================");
                menC = Console.ReadLine();
                if (menC == "HELP") //Displays all commands
                {
                    Console.WriteLine("START - Initiate's Core Launching protocol");
                    Console.WriteLine("HELP - Opens this menu");
                    Console.WriteLine("BASE - Opens database");
                    Console.WriteLine("CTD - Shows today's booting code");
                    Console.WriteLine("LOGOUT - Shuts down the terminal");
                    Console.WriteLine("==================================");
                }
                if (menC == "START") //!!!CORE SETUP!!!
                {
                    Console.WriteLine("!!!DISCLAIMER!!!");
                    Console.WriteLine("BY STARTING UP THE CORE,");
                    Console.WriteLine("YOU AGREE THAT YOU ARE RESPONSIBLE FOR KEEPING IT ON, UNTIL IT TURNS OFF.");
                    Console.WriteLine("IF YOU DO AGREE, ENTER THE LAUNCHODE NOW.");
                    Console.WriteLine("==================================");
                    do
                    {
                        Console.WriteLine("PLEASE ENTER THE BOOT CODE NOW, IF YOU DO AGREE. ELSE, SAY \"EXIT\"");
                        Console.WriteLine("");
                        agreeWord = Console.ReadLine();

                        int agreecode = 0;
                        Int32.TryParse(agreeWord, out agreecode);
                        if (agreecode == CTDC)
                        {
                            Console.WriteLine("STARTING UP THE CORE...");
                            Console.WriteLine("ENJOY YOUR SHIFT, " + crd);
                            Console.WriteLine("CORE SUCCESSFULLY LOADED (RICCARDONET V3.5)");
                            corestarted = true; //ESSENTIAL PIECE OF CODE
                        }
                        else if (agreeWord == "EXIT")
                        {
                            Console.WriteLine("SETUP CANCELLED.");
                            System.Environment.Exit(0);
                        }
                    } while (agreeWord != "EXIT" && !corestarted);
                }
                if (menC == "BASE") //Database
                {
                    Console.WriteLine("PLEASE INSERT THE BASECODE TO CONTINUE.");
                    Int32.TryParse(Console.ReadLine(), out guesscode);
                    if (guesscode == basecode)
                    {
                        do
                        {
                            Console.WriteLine("PLEASE INSERT OPTION (EMPLOYEES, CODES, EXIT)");
                            baC = Console.ReadLine();

                            if (baC == "EMPLOYEES")
                            {
                                Console.WriteLine("CURRENT EMPLOYEES:");
                                staff.ForEach(i => Console.WriteLine("{0}", i));
                                Console.WriteLine("");
                            }
                            if (baC == "CODES")
                            {
                                Console.WriteLine("EMPLOYEE CODES:");
                                codes.ForEach(i => Console.WriteLine("{0}", i));
                                Console.WriteLine("FIRST TO LAST, REMEMBER ORDER.");
                            }
                        }
                        while (baC != "EXIT");
                        Console.WriteLine("==================================");
                    }
                }
                if (menC == "CTD") //Startup code CTDC
                {
                    Console.WriteLine("PLEASE INSERT THE CURRENT BASECODE");
                    Int32.TryParse(Console.ReadLine(), out guesscode);
                    if (guesscode == basecode)
                    {
                        Console.WriteLine("THE CURRENT BOOT CODE IS " + CTDC);
                        Console.WriteLine("==================================");
                    }
                }
                if (menC == "LOGOUT")
                {
                    Console.WriteLine("SUCCESSFULLY LOGGED OUT.");
                    Console.WriteLine("==================================");
                    System.Environment.Exit(0);
                }
            } while (!corestarted);
            //================= NEXT PART OF THE GAME =====================
            /*
             Now, the task of the next game is a gameplay loop.

            1. Player will spawn in menu interface, player will be presented with a menu console just like last one.
            Format:

            TYPE "HELP" FOR COMMANDS (Writeline)
            ======================== (Writeline)
            "" (Writeline)
            (ReadLine)

            (Conversion)

            (Automatic core Update)
            (Specific Compartiments of the core)
            (Automatic Warning Sytem)
            (Gameplay gate)
            (Ending Picker)

            2.1


            2.2 Different Menues will be picked according to given input
            -Status
            a. coolant status -Checks how you can keep it cool
            b. temprature status -Checks if your core isn't freezing or combusting
            c. instabillity status -Checks how close the core is to fucking dying
            d. shitpost status /j -Mhm
            e. other statusses -Things I'll add in later
            */

            /*
             * Do while
             * if check
             * menu specific
             * menu mechanics
             * if check
             * update
             * end dowhile
             * 
             * gameplay gate
             * ending trigger
             * close program
             */



        }
    }
}
#endregion