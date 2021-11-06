using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{

    class Program
    {

        static void Main(string[] args)
        {
            

           
            NewDay nd = new NewDay();

             
            Console.WindowHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth;

            Console.ForegroundColor = ConsoleColor.Cyan;

            //Starting information 
            Console.WriteLine("You are an ordinary residents of a quiet town, your life is calm and measured, it would seem, everything is already in place and nothing can interfere with your idyll," + "\n" +
                              "except..... atomic apocalypse:)" + "\n" +
                              "On the radio, you heard a military warning, in 3 minutes everything within a radius of 20 kilometers will become lifeless." + "\n" +
                              "You hastily grab your wife and children, as well as a set of things that came to hand. At the last moment you have time to hide in the bunker" + "\n" +
                              "and do not understand what will happen next, but an hour later they announce on the radio that the rescue team will reach your area" + "\n" +
                              "after 30 days. Resolved! It is necessary to hold out until rescue, but how to allocate resources and cope with the harsh living conditions in the bunker?" + "\n" +
                              "Then everything will depend on you! Good luck.");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("If you wanna read the instruction before starting the game write 1, else write 2 and the game will start.");
            Console.ResetColor();
            Console.WriteLine("Enter the number into the console");
            Console.Write("----> ");
            int instr = Convert.ToInt32(Console.ReadLine());

            if (instr > 2 || instr < 1)
            {
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("You messed up something. Try again");
                    Console.Write("----> ");
                    instr = Convert.ToInt32(Console.ReadLine());

                }
                while (instr > 2 || instr < 1);
            }

            if (instr == 1)
            {
                Console.WriteLine("This game is a step-by-step strategy. Every day in the game you will have an event where you will choose what to do." + "\n" +
                                  "Depending on you choose this event will to give a good or bad impact on the game, but you will never know what answer is true." + "\n" +
                                  "Even sometimes the right answer can give bad results because all time something unexpected can be.м You will have two " + "\n" +
                                  "types of intersection with the game: first is the intersection with events(it will happen at the start of each day), " + "\n" +
                                  "the second is a game menu where you can distribute the resources, see the status of all characters and some else." + "\n" +
                                  " " + "\n" +
                                  "Next, you can read the description of all game mechanics." + "\n" +
                                  "The rule of win: You should live all 30 days and have a minimum of one alive person in the end." + "\n" +
                                  "The rule of defeat: All your characters will die before the 30th day." + "\n" +
                                  "Menu:" + "\n" +
                                  "Each day, after the event, a menu will write to the console by the program. The menu tab includes 5 functions: " + "\n" +
                                  "1) Family member information - this function will show you the full information about all characters. " + "\n" +
                                  "   You will see if a person needs water, food or medkit, also there you will find the information about sickness and traumas. " + "\n" +
                                  "   If one of the parameters will show with red color it means that you have 3 days to fix it, else this character will die." + "\n" +
                                  "2)Interaction with characters - you should use this one to give eat, water, or medicine to the characters." + "\n" +
                                  "3)Resource list - choose it to see all your resource (eat, water, medkit, and all your items)" + "\n" +
                                  "4)Send to the wasteland - very specific function.It gives you an opportunity to send somebody to the wasteland." + "\n" +
                                  "   There the character can found some interesting items and other resources, but it's dangerous! " + "\n" +
                                  "   A person can die in the wasteland get a sickness. You can give items to this person(for example padlock or mask), " +
                                  "   but this item will not returned by him, and it will up his chance to come home and find something helpful. " + "\n" +
                                  "5)The next day - this function will finish this day and open the next one.");
            }

                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine("Select starter kit");
                Console.WriteLine("1) Food - 15, Water - 13, Medkit - 2, Radio, Tools, Gas mask, Padlock, Boy Scout Handbook, Ammunition, Suitcase.");
                Console.WriteLine("2) Food - 13, Water - 13, Medkit - 3, Axe, Poison, Map, Radio, Deck of Cards, Suitcase, Rifle.");
                Console.WriteLine("3) Food - 13, Water - 16, Medkit - 1, Radio, Rifle, Flashlight, Padlock, Tools, Insulating tape, Poison.");
                Console.WriteLine("4) Food - 17, Water - 13, Medkit - 2, Axe, Insulating tape, Flashlight, Tools, Suitcase, Ammunition, Deck of Cards.");
                Console.WriteLine("5) Food - 15, Water - 14, Medkit - 1, Radio, Card, Gas mask, Poison, Rifle, Boy Scout Handbook, Suitcase.");
                Console.WriteLine("6) Random set");
                Console.WriteLine("Enter the number into the console");
                Console.Write("----> ");


                // выбор китстарта и защита от дурака
                int kitStart = Convert.ToInt32(Console.ReadLine());

                if (kitStart > 6 || kitStart < 1)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("You messed up something. Try again");
                        Console.Write("----> ");
                        kitStart = Convert.ToInt32(Console.ReadLine());

                    }
                    while (kitStart > 6 || kitStart < 1);
                }

                //это дублированние чтобы присвоить финальный привальный выбор, иначе все лагает и потом ресукрсы не отобрааются 
                int finalKitStart = kitStart;


                if (finalKitStart < 6)
                {
                    nd.stash.KitStart(finalKitStart);
                }
                else
                {
                    nd.stash.KitStart();
                }

                Console.WriteLine();
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Cyan;
                //день 1 и начало игры
                Console.WriteLine("                                       Begin! Day 1");
                Console.WriteLine("This is our first day");
                Console.WriteLine("Will we do something or should we wait until the next day. The choice is not easy. From this time this is you choose.");
                Console.ResetColor();

                // вывод менюшки
                nd.stash.Menu();

                //день два и дальше
                for (int i = 2; i < 31; i++)
                {
                    Random _random = new Random();
                    int rnd;
                    rnd = _random.Next(0,29); // рандмчик для выбора события 

                    if (i % 2 != 0)
                    {
                        nd.stash.Dad.HungerGrade();
                        nd.stash.Son.HungerGrade();
                        nd.stash.Mom.HungerGrade();
                        nd.stash.Daughter.HungerGrade();
                        nd.stash.Dad.ThirstGrade();
                        nd.stash.Son.ThirstGrade();
                        nd.stash.Mom.ThirstGrade();
                        nd.stash.Daughter.ThirstGrade();
                    }

                    if (nd.stash.Dad.dead == true || nd.stash.Mom.dead == true || nd.stash.Son.dead == true || nd.stash.Daughter.dead == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Unfortunately, all characters are dead. This concludes the game, next " + "\n" +
                                          "time try to allocate resources more competently." + "\n" +
                                          "  " + "\n" +
                                          "Thanks for playing our game :) ");
                        Console.WriteLine();

                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Press any button to exit the game.");
                        Console.ResetColor();


                        Console.ReadKey();
                        Environment.Exit(0);

                    }
                    else
                    {
                        nd.theNextDay(i, rnd);
                    }

                }
                //сообщение о победе и красивенький текст о спасении 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("What is it? Strange noise in the street. I think it's worth checking ..." + "\n" +
                                  " " + "\n" +
                                  "* you open the hatch and see what you have dreamed of for the last 30 days - a rescue helicopter that has landed next to your bunker." + "\n" +
                                  " " + "\n" +
                                  "Yes, we did it!! This month turned out to be very difficult, but we survived it and in a few hours it will all be over." + "\n" +
                                  "And we even managed to get used to this place. " + "\n" +

                                  "Well, it was a serious test, but we survived and proved that we are ready for any danger." + "\n" +
                                  " " + "\n" +
                                  "Thank you for playing our game ");
                Console.WriteLine("Press any button to exit the game.");
                Console.ResetColor();


                Console.ReadKey();
            
        }
    }
}
