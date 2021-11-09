using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
     class NewDay 
     {
        public Items stash = new Items();
        public void theNextDay(int i, int rndm)
        {
            int day = i; //day counter
            int rand = rndm;
         //sdgrg
        
            //aa&&&

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                                       Day {0} ", day);
            
            Console.ResetColor();

            //Events
            if (rand == 1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("It is very unpleasant to constantly hear some kind of rustle. Is there anything hiding from us in  " + "\n" +
                                   "such a small bunker? We checked all the corners and found no one there. Maybe it's some kind of rodent? " + "\n" +
                                   "We need to show him who is at the top of the food chain!");
                Console.ResetColor();
                Console.WriteLine("1) Start searching");
                Console.WriteLine("2) Ignore");

                Console.WriteLine("Enter the number into the console");
                Console.Write("----> ");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 2) 
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("You messed up something. Try again");
                        Console.Write("----> ");
                        choice = Convert.ToInt32(Console.ReadLine());

                    }
                    while (choice < 1 || choice > 2);
                }
                if (choice == 1)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1,3);
                    if (ch1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green; 
                        Console.WriteLine("The search have a completely unexpected result, a padlock was found");
                        Console.ResetColor();
                        if (stash.padlock != 1)
                        {
                            stash.padlock = 1;
                        }
                       
                    }

                    if (ch1 != 1) 
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("We found the nest of spiders and quickly fixed the problem. Nothing else will disturb us tonight.");
                        Console.ResetColor();
                    }
                    Console.WriteLine();
                }

                if (choice == 2)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 3);
                    if (ch1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red; 
                        Console.WriteLine("We decided to ignore this noise. In the morning he disappeared as well as one of our canned food. Food -3");
                        Console.ResetColor();
                        if (stash.food >= 3) 
                        {
                            stash.food -= 3;
                        }
                        if (stash.food < 3)
                        {
                            stash.food = 0;
                        }
                    }

                    if (ch1 != 1) 
                    {
                        Console.ForegroundColor = ConsoleColor.Red; 
                        Console.WriteLine("The rustling continued all night long, and we could not rest. The effect 'Fatigue' was obtained (during the next day, you can not make sorties)");
                        Console.ResetColor();
                        stash.Dad.Condition-=2;
                        stash.Mom.Condition-=2;
                        stash.Son.Condition-=2;
                        stash.Daughter.Condition-=2;

                    }
                    Console.WriteLine();
                }
            }

            if (rand == 2)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("We feel that something is staring at us from the corner. It must be a rat. " + "\n" +
                                   "At least it looks like a rat. So fat ... We have to do something with her, or she wants to do something with us. ");
                Console.ResetColor();
                Console.WriteLine("1) Try to kill");
                Console.WriteLine("2) Ignore");

                Console.WriteLine("Enter the number into the console");
                Console.Write("----> ");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 2)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("You messed up something. Try again");
                        Console.Write("----> ");
                        choice = Convert.ToInt32(Console.ReadLine());

                    }
                    while (choice < 1 || choice > 2);
                }
                if (choice == 1)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 3);
                    if (ch1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("We found mice, they certainly look so-so, but extra food will not hurt us. Food +4");
                        Console.ResetColor();
                        if (stash.food <= 26)
                        {
                            stash.food += 4;
                        }
                        else stash.food = 30;

                    }

                    if (ch1 != 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("We didn't find anything, but the strange sounds for some reason stopped, well, fine");
                        Console.ResetColor();
                    }
                    Console.WriteLine();
                }

                if (choice == 2)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 3);
                    if (ch1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("These **** mutants spilled our water. Water -5");
                        Console.ResetColor();
                        if (stash.water >= 5)
                        {
                            stash.water -= 5;
                        }
                        if (stash.water < 5)
                        {
                            stash.water = 0;
                        }

                    }

                    if (ch1 != 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The strange sounds caused the children to panic. Their performance drops.");
                        Console.ResetColor();
                        stash.Son.Condition += 2;
                        stash.Daughter.Condition += 2;

                    }
                    Console.WriteLine();
                }
            }

            if (rand == 3)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Today we woke up and didn't feel quite comfortable. We have a feeling " + "\n" +
                                  "that someone is watching us! I swear we saw a moving shadow. " + "\n" +
                                  "If besides us there is something else alive here, then it's time for us to show who is the boss here. ");
                Console.ResetColor();

                Console.WriteLine("1) Start searching");
                Console.WriteLine("2) Ignore");

                Console.WriteLine("Enter the number into the console");
                Console.Write("----> ");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 2)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("You messed up something. Try again");
                        Console.Write("----> ");
                        choice = Convert.ToInt32(Console.ReadLine());

                    }
                    while (choice < 1 || choice > 2);
                }
                if (choice == 1)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 3);
                    if (ch1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("We have caught a huge rat, perhaps today we will have meat for dinner. Food +4");
                        Console.ResetColor();
                        if (stash.food <= 26)
                        {
                            stash.food += 4;
                        }
                        else stash.food = 30;

                    }

                    if (ch1 != 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("We were lucky, the rat got scared of our active actions and ran away. ");
                        Console.ResetColor();
                    }
                    Console.WriteLine();
                }

                if (choice == 2)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 3);
                    if (ch1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The rat turned over a bowl of soup. Food - 4");
                        Console.ResetColor();
                        if (stash.food >= 4)
                        {
                            stash.food -= 4;
                        }
                        if (stash.food == 0)
                        {
                            stash.food = 0;
                        }
                    }

                    if (ch1 != 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The rat turned out to be very aggressive and bit Margo. She is ill and needs medicine.");
                        Console.ResetColor();
                        stash.Mom.Sickness += 3;
                    }
                    Console.WriteLine();
                }
            }

            if (rand == 4)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Weird mold has appeared on one wall. Oh, how nice it smells, I think you can try to eat it." + "\n" +
                                  "After all, the prospect of a hunger strike does not seem so attractive. I think it's worth trying it, but what bad can happen?. ");
                Console.ResetColor();

                Console.WriteLine("1) Eat");
                Console.WriteLine("2) Ignore");

                Console.WriteLine("Enter the number into the console");
                Console.Write("----> ");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 2)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("You messed up something. Try again");
                        Console.Write("----> ");
                        choice = Convert.ToInt32(Console.ReadLine());

                    }
                    while (choice < 1 || choice > 2);
                }
                if (choice == 1)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 3);
                    if (ch1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("It was really tasty. Food +4 ");
                        Console.ResetColor();
                        if (stash.food <= 26)
                        {
                            stash.food += 4;
                        }
                        else stash.food = 30;
                    }

                    if (ch1 != 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("It seems not worth it there is Josh poisoned. ");
                        Console.ResetColor();
                        stash.Son.Sickness+=2;
                    }
                    Console.WriteLine();
                }

                if (choice == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("We removed this mold");
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }

            if (rand == 5)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Ha! You know what? We have already started our own garden! strange plants creep from all corners. " + "\n" +
                                  "There are enough of them to cook dinner. So shall we have a feast for ourselves?. ");
                Console.ResetColor();

                Console.WriteLine("1) Eat");
                Console.WriteLine("2) Ignore");

                Console.WriteLine("Enter the number into the console");
                Console.Write("----> ");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 2)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("You messed up something. Try again");
                        Console.Write("----> ");
                        choice = Convert.ToInt32(Console.ReadLine());

                    }
                    while (choice < 1 || choice > 2);
                }
                if (choice == 1)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 3);
                    if (ch1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("And it turned out to be quite tasty. Food +4");
                        Console.ResetColor();
                        if (stash.food <= 26)
                        {
                            stash.food += 4;
                        }
                        else stash.food = 30;

                    }

                    if (ch1 != 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Oh, we ate too much and were very tired, apparently today we can't do it anymore. Food +4");
                        Console.ResetColor();
                        if (stash.food <= 26)
                        {
                            stash.food += 4;
                        }
                        else stash.food = 30;
                        stash.Dad.Condition--;
                        stash.Mom.Condition--;
                        stash.Son.Condition--;
                        stash.Daughter.Condition--;
                        }
                    Console.WriteLine();
                }

                if (choice == 2)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 3);
                    if (ch1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Nice joke, but we better not risk it");
                        Console.ResetColor();
                    }

                    if (ch1 != 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Damn it, the children for some reason tried these mushrooms and clearly got sick.");
                        Console.ResetColor();
                        stash.Son.Sickness+=2; ;
                        stash.Daughter.Sickness+=2;
                    }
                    Console.WriteLine();
                }
            }

            if (rand == 6)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Today began with surprises, someone knocked on our door and we decided to open it. " + "\n" +
                                  "It turned out to be another survivor, he will resist us giving him 5 food in return he offers water. ");
                Console.ResetColor();

                Console.WriteLine("1) Exchange");
                Console.WriteLine("2) Refuse");

                Console.WriteLine("Enter the number into the console");
                Console.Write("----> ");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 2)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("You messed up something. Try again");
                        Console.Write("----> ");
                        choice = Convert.ToInt32(Console.ReadLine());

                    }
                    while (choice < 1 || choice > 2);
                }
                if (choice == 1)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 3);
                    if (ch1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("And he turned out to be pretty cute. we chatted pleasantly and he gave us 5 water");
                        Console.ResetColor();
                        if (stash.water <= 25)
                        {
                            stash.water += 5;
                        }
                        else stash.water = 30;

                    }

                    if (ch1 != 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("And he turned out to be pretty cute. we chatted pleasantly and he gave us 3 water.");
                        Console.ResetColor();
                        if (stash.water <= 27)
                        {
                            stash.water += 3;
                        }
                        else stash.water = 30;

                    }
                    Console.WriteLine();
                }

                if (choice == 2)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 3);
                    if (ch1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("He got very upset but in the end he just left.");
                        Console.ResetColor();
                    }

                    if (ch1 != 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("We refused him, but he took out a gun and began to threaten us, we had to give him water. Water - 4");
                        Console.ResetColor();
                        if (stash.water <= 4)
                        {
                            stash.water = 0;
                        }
                        else
                        {
                            stash.water -= 4;
                        }

                    }
                    Console.WriteLine();
                }
            }
            if (rand == 7)
            {
                if (stash.radio == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Today we learned from radio, that there are military supplies near us. " + "\n" +
                                      "Should we go out and check it? ");
                    Console.ResetColor();

                    Console.WriteLine("1) Check it");
                    Console.WriteLine("2) Ignore");

                    Console.WriteLine("Enter the number into the console");
                    Console.Write("----> ");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice < 1 || choice > 2)
                    {
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine("You messed up something. Try again");
                            Console.Write("----> ");
                            choice = Convert.ToInt32(Console.ReadLine());

                        } while (choice < 1 || choice > 2);
                    }

                    if (choice == 1)
                    {
                        Random _random = new Random();
                        int ch1 = _random.Next(1, 3);
                        if (ch1 == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("We've found rifle, medkit and some food.");

                            Console.ResetColor();
                            if (stash.Food <= 30)
                            {
                                stash.Food += 3;
                            }
                            else stash.Food = 30;

                            if (stash.Medkit <= 4)
                            {
                                stash.Medkit++;
                            }
                            else stash.Medkit = 4;

                            if (stash.rifle != 1)
                            {
                                stash.rifle = 1;
                            }



                        }

                        if (ch1 == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("We've found a rifle and some food.");

                            Console.ResetColor();

                            if (stash.Food <= 30)
                            {
                                stash.Food += 3;
                            }
                            else stash.Food = 30;

                            if (stash.rifle != 1)
                            {
                                stash.rifle = 1;
                            }


                        }

                        if (ch1 == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("We've found a rifle and some food." + "\n" +
                                          "But on our way back we've met raiders and Josh got injured.");

                            Console.ResetColor();

                            if (stash.Food <= 30)
                            {
                                stash.Food += 3;
                            }
                            else stash.Food = 30;

                            if (stash.rifle != 1)
                            {
                                stash.rifle = 1;
                            }

                            stash.Son.Traumas++;


                        }

                        Console.WriteLine();
                    }

                    if (choice == 2)
                    {
                        Random _random = new Random();
                        int ch1 = _random.Next(1, 3);
                        if (ch1 == 1)
                        {
                            Console.WriteLine("We ignored a message.");
                            Console.WriteLine();
                        }
                        else if (ch1 == 2)
                        {
                            Console.WriteLine("We ignored a message, but we got bored.");

                            stash.Dad.Condition++;
                            stash.Son.Condition++;
                            stash.Mom.Condition++;
                            stash.Daughter.Condition++;
                            Console.WriteLine();
                        }

                        Console.WriteLine();
                    }
                }
                else
                {
                    Random rnd = new Random();
                    rand = rnd.Next(1, 31);
                }
            }

            if (rand == 8)
            {
                if (stash.radio == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Today we learned from radio, that there is an airplane crashed near us. " +
                                      "\n" +
                                      "Surely there is something for us there. " + "\n" +
                                      "Should we go out and check?");
                    Console.ResetColor();

                    Console.WriteLine("1) Check it");
                    Console.WriteLine("2) Ignore");

                    Console.WriteLine("Enter the number into the console");
                    Console.Write("----> ");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice < 1 || choice > 2)
                    {
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine("You messed up something. Try again");
                            Console.Write("----> ");
                            choice = Convert.ToInt32(Console.ReadLine());

                        } while (choice < 1 || choice > 2);
                    }

                    if (choice == 1)
                    {

                        Random _random = new Random();
                        int ch1 = _random.Next(1, 4);
                        if (ch1 == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("We've found a Gas Mask, water and some food.");

                            Console.ResetColor();
                            if (stash.Food <= 30)
                            {
                                stash.Food += 3;
                            }
                            else stash.Food = 30;

                            if (stash.Water <= 30)
                            {
                                stash.Water += 3;
                            }
                            else stash.Water = 30;



                            if (stash.mask != 1)
                            {
                                stash.mask = 1;
                            }



                        }

                        if (ch1 == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("We've found some water and food.");

                            Console.ResetColor();

                            if (stash.Food <= 30)
                            {
                                stash.Food += 3;
                            }
                            else stash.Food = 30;

                            if (stash.Water <= 30)
                            {
                                stash.Water += 3;
                            }
                            else stash.Water = 30;


                        }

                        if (ch1 == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("We've found a Gas Mask, water and some food." + "\n" +
                                          "But raiders found us and Josh got injured.");

                            Console.ResetColor();

                            if (stash.Food <= 25)
                            {
                                stash.Food += 3;
                            }
                            else stash.Food = 30;

                            if (stash.Water <= 25)
                            {
                                stash.Water += 2;
                            }
                            else stash.Water = 30;


                            if (stash.mask != 1)
                            {
                                stash.mask = 1;
                            }

                            stash.Son.Traumas++;


                        }

                        Console.WriteLine();
                    }

                    if (choice == 2)
                    {
                        Random _random = new Random();
                        int ch1 = _random.Next(1, 3);
                        if (ch1 == 1)
                        {
                            Console.WriteLine("We ignored a message.");
                            Console.WriteLine();
                        }
                        else if (ch1 == 2)
                        {
                            Console.WriteLine("We ignored a message, but there's an argue in bunker.");

                            stash.Dad.Condition++;
                            stash.Son.Condition++;
                            stash.Mom.Condition++;
                            stash.Daughter.Condition++;
                            Console.WriteLine();
                        }

                        Console.WriteLine();
                    }
                }
                else
                {
                    Random rdm = new Random();
                    rand = rdm.Next();
                }
            }



            if (rand == 9)
            {
                if (stash.radio == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Good news! Government announced that there are supply crates dropped nearby. " +
                                      "\n" +
                                      "We can go to surface and take those crates. " + "\n" +
                                      "We should take a gas mask.");
                    Console.ResetColor();

                    Console.WriteLine("1) Check it with gas mask");
                    Console.WriteLine("2) Ignore");

                    Console.WriteLine("Enter the number into the console");
                    Console.Write("----> ");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice < 1 || choice > 2)
                    {
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine("You messed up something. Try again");
                            Console.Write("----> ");
                            choice = Convert.ToInt32(Console.ReadLine());

                        } while (choice < 1 || choice > 2);
                    }

                    if (choice == 1)
                    {

                        Random _random = new Random();
                        int ch1 = _random.Next(1, 4);
                        if (ch1 == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("We've found water and some food.");
                            if (stash.mask == 1)
                            {
                                Console.WriteLine("Our gas mask didn't break.");
                            }

                            Console.ResetColor();
                            if (stash.Food <= 30)
                            {
                                stash.Food += 3;
                            }
                            else stash.Food = 30;

                            if (stash.Water <= 30)
                            {
                                stash.Water += 2;
                            }
                            else stash.Water = 30;

                        }

                        if (ch1 == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("We've found some water and food.");
                            if (stash.mask == 1)
                            {
                                stash.mask = 0;
                                Console.WriteLine("Our gas mask is broken.");
                            }

                            Console.ResetColor();

                            if (stash.Food <= 30)
                            {
                                stash.Food += 2;
                            }
                            else stash.Food = 30;

                            if (stash.Water <= 30)
                            {
                                stash.Water += 1;
                            }
                            else stash.Water = 30;
                        }

                        if (ch1 == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Not our day, someone had already taken supplies");

                            Console.ResetColor();

                        }

                        Console.WriteLine();
                    }

                    if (choice == 2)
                    {

                        Console.WriteLine("We ignored a message, but there's a bad atmosphere in bunker.");

                        stash.Dad.Condition++;
                        stash.Son.Condition++;
                        stash.Mom.Condition++;
                        stash.Daughter.Condition++;
                        Console.WriteLine();


                        Console.WriteLine();
                    }
                }
                else
                {
                    Random rdm = new Random();
                    rand = rdm.Next();
                }
            }

            if (rand == 10)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("We are not a huge mushroom fans, but there are so much of them on a wall. " +
                                  "\n" +
                                  "Should we eat those mushrooms?");
                Console.ResetColor();

                Console.WriteLine("1) Eat them");
                Console.WriteLine("2) Ignore");

                Console.WriteLine("Enter the number into the console");
                Console.Write("----> ");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 2)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("You messed up something. Try again");
                        Console.Write("----> ");
                        choice = Convert.ToInt32(Console.ReadLine());

                    } while (choice < 1 || choice > 2);
                }

                if (choice == 1)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 4);

                    if (ch1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("They are quite delicious." + "\n" + "Food +3");

                        if (stash.Food <= 25)
                        {
                            stash.Food += 3;
                        }
                        else stash.Food = 30;
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("We eat them, but there are strange feelings after mushrooms." + "\n" +
                                          "We are poisoned and can't work.");
                        stash.Dad.Condition++;
                        stash.Mom.Condition++;
                        stash.Son.Condition++;
                        stash.Daughter.Condition++;
                        Console.ResetColor();
                    }
                }
                else if (choice == 2) 
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("We are hungry, but not so crazy to eat those mushrooms." + "\n"  +
                        "Decision is made unanonimously. Our mood gets better.");
                    stash.Dad.Condition--;
                    stash.Mom.Condition--;
                    stash.Son.Condition--;
                    stash.Daughter.Condition--;
                    Console.ResetColor();
                }

            }
            if(rand == 11)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("We don't know who created this bunker, he definitely was a genius. " +
                                  "\n" +
                                  "But we don't think that a green liquid dripping from tubes should be there" + "\n" + 
                                  "We have to do something with it, until it didn't flood us.");
                Console.ResetColor();

                Console.WriteLine("1) Fix it");
                Console.WriteLine("2) Ignore");

                Console.WriteLine("Enter the number into the console");
                Console.Write("----> ");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 2)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("You messed up something. Try again");
                        Console.Write("----> ");
                        choice = Convert.ToInt32(Console.ReadLine());

                    } while (choice < 1 || choice > 2);
                }

                if (choice == 1)
                {
                    int ch1;
                    if (stash.tape == 1)
                         ch1 = 1;
                    else
                         ch1 = 0;
                    


                    if (ch1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Problem is solved, but we had to waste an insulating tape." + "\n" + "Our mood gets better.");
                        stash.Dad.Condition--;
                        stash.Mom.Condition--;
                        stash.Son.Condition--;
                        stash.Daughter.Condition--;
                        stash.tape = 0;
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Problem is solved, but we got covered by this liquid." + "\n" +
                                          "It's hard to wash it off. Our mood gets worse.");
                        stash.Dad.Condition++;
                        stash.Mom.Condition++;
                        stash.Son.Condition++;
                        stash.Daughter.Condition++;
                        Console.ResetColor();
                    }
                }
                if(choice == 2)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 4);

                    if(ch1 == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Pipe is burst and our bunker is flood." + "\n" + "Our mood gets worse.");
                        stash.Dad.Condition++;
                        stash.Mom.Condition++;
                        stash.Son.Condition++;
                        stash.Daughter.Condition++;
                        Console.ResetColor();
                    }
                    else if(ch1 == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Pipe is leaking more, to fix it we had to use food cans.");
                        stash.Food -= 3;
                        Console.ResetColor();                  
                    }
                    else if(ch1 == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("It's strange, but it stopped by itself." );
                        Console.ResetColor();
                    }
                }
            }
            if(rand == 12)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("How did this green puddle appeared here? " +
                                  "\n" +
                                  "Damn, there is a strange liquid dripping from ceiling. It isn't good!" + "\n" +
                                  "We should do something right now.");
                Console.ResetColor();

                Console.WriteLine("1) Get rid of it");
                Console.WriteLine("2) Ignore");

                Console.WriteLine("Enter the number into the console");
                Console.Write("----> ");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 2)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("You messed up something. Try again");
                        Console.Write("----> ");
                        choice = Convert.ToInt32(Console.ReadLine());

                    } while (choice < 1 || choice > 2);
                }

                if(choice == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("We have cleaned it together. Our mood gets better.");
                    stash.Dad.Condition--;
                    stash.Mom.Condition--;
                    stash.Son.Condition--;
                    stash.Daughter.Condition--;
                    Console.ResetColor();
                }
                else if(choice == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Josh slipped and fell. He is annoyed. Our mood gets worse.");
                    stash.Dad.Condition++;
                    stash.Mom.Condition++;
                    stash.Son.Condition++;
                    stash.Daughter.Condition++;
                    Console.ResetColor();
                }
            }
            if(rand == 13)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Today we woke up from the sound of dripping and noticed that our pipe is cracked. " +
                                  "\n" +
                                  "This gas seems not to be dangerous. Even though it filled our bunker." + "\n" +
                                  "Bit it would be better to fix a pipe.");
                Console.ResetColor();

                Console.WriteLine("1) Fix it");
                Console.WriteLine("2) Ignore");

                Console.WriteLine("Enter the number into the console");
                Console.Write("----> ");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 2)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("You messed up something. Try again");
                        Console.Write("----> ");
                        choice = Convert.ToInt32(Console.ReadLine());

                    } while (choice < 1 || choice > 2);
                }

                if(choice == 1)
                {
                    int ch1 =0;
                    if (stash.tape == 1)
                        ch1 = 1;
                    else if (stash.tools == 1)
                        ch1 = 2;

                    if(ch1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Pipe is fixed, but we had to waste our insulating tape.");
                        stash.tape = 0;
                        Console.ResetColor();
                    }
                    else if(ch1 == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Pipe is fixed, but our tools are broken.");
                        stash.tools = 0;
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("We have fixed a pipe, but dad's hand got dislocated." );
                        stash.Dad.Traumas++;
                        Console.ResetColor();
                    }


                }
                else if(choice == 2)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 10);

                    if (ch1 > 1 && ch1 <= 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sally got poisoned by gas.");
                        Console.ResetColor();
                        
                        stash.Daughter.Sickness++;
                    }
                    else if (ch1 > 5 && ch1 <= 8)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("it's strange, but we are feeling even better.");
                        stash.Dad.Condition--;
                        stash.Mom.Condition--;
                        stash.Son.Condition--;
                        stash.Daughter.Condition--;
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("We...There is something wrong.....What is happening? Seems that we are passing off.");
                        stash.Dad.dead = true;
                        stash.Daughter.dead = true;
                        Console.ResetColor();
                    }
                }
            }
            if(rand == 14)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Mutated rodents are attacking our supplies! " +
                                  "\n" +
                                  "We don't know what are they rats, wild rabbits or hamsters." + "\n" +
                                  "We could try to get rid of them.");
                Console.ResetColor();

                Console.WriteLine("1) Fix it");
                Console.WriteLine("2) Ignore");

                Console.WriteLine("Enter the number into the console");
                Console.Write("----> ");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 2)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("You messed up something. Try again");
                        Console.Write("----> ");
                        choice = Convert.ToInt32(Console.ReadLine());

                    } while (choice < 1 || choice > 2);
                }

                if(choice == 1)
                {
                    int ch1 = 0;
                    if (stash.axe == 1)
                        ch1 = 1;
                    else if (stash.rifle == 1)
                        ch1 = 2;

                    if(ch1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Hell yeah, we killed those rodents, but our axe is broken.");
                        stash.axe = 0;
                        Console.ResetColor();
                    }
                    else if(ch1 == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Goddammit, our rifle exploded, while we were trying to shoot those creatures, but explosion had scared them."+"\n"+ "We think they won't disturbe us anymore.");
                        stash.rifle = 0;
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("We tried to kick them away, but they just bit us, Margo got a fever.");
                        stash.Mom.Sickness++;
                        Console.ResetColor();
                    }
                }
                else if(choice == 2)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 4);

                    if(ch1 == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Those goddamn rodents won. Won and took our food."  + "\n" + "One can more, one less, there's nothing too bad! But we are awared, that they can come back to take everything else.");
                        stash.Food -= 4;
                        Console.ResetColor();
                    }
                    else if(ch1 == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("There are more and more of these rodents. It won't end good. Our mood gets worse.");
                        stash.Dad.Condition++;
                        stash.Mom.Condition++;
                        stash.Son.Condition++;
                        stash.Daughter.Condition++;
                        Console.ResetColor();
                    }
                    else if(ch1 == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Rodents began to devastate our supplies.");
                        stash.Food -= 4;
                        stash.Water -= 2;
                        Console.ResetColor();
                    }
                }
                
            }
            if(rand == 15)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("What is it?! A rat? " +
                                  "\n" +
                                  "Rats usually are smaller than cats. And it's got two tails?!" + "\n" +
                                  "We can't let it to our supplies.");
                Console.ResetColor();

                Console.WriteLine("1) Try to catch");
                Console.WriteLine("2) Ignore");

                Console.WriteLine("Enter the number into the console");
                Console.Write("----> ");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 2)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("You messed up something. Try again");
                        Console.Write("----> ");
                        choice = Convert.ToInt32(Console.ReadLine());

                    } while (choice < 1 || choice > 2);
                }

                if(choice == 1)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 4);

                    if(ch1 == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("We caught it....It's delicious!))");
                        stash.Food += 3;
                        Console.ResetColor();
                    }
                    else if(ch1 == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("It is too fast, we can't catch it, but rat got scared and ran away." + "\n" + "Our mood gets better.");
                        stash.Dad.Condition--;
                        stash.Mom.Condition--;
                        stash.Son.Condition--;
                        Console.ResetColor();
                        stash.Daughter.Condition--;
                    }
                    else if (ch1 == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("We caught it and can it now, but Peter got bitten");
                        stash.Food += 2;
                        stash.Dad.Traumas++;
                        Console.ResetColor();
                    }
                }
                if(choice == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Rat stole some of our supplies.");
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 5);
                    if (ch1 == 2)
                        stash.Food -= 3;
                    else if (ch1 == 3)
                        stash.Water -= 3;
                    else if (ch1 == 4)
                        stash.Food -= 4;
                    else if(ch1 == 5)
                    {
                        stash.Food -= 3;
                        stash.Water -= 5;
                    }
                    Console.ResetColor();

                }
            }
            if(rand == 16)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("We are not alone. " +
                                  "\n" +
                                  "There is a big hairy devil-rabbit. It is hiding near bunker entrance." + "\n" +
                                  "We've seen him looking at as through the window. We can't allow it to stay here.");
                Console.ResetColor();

                Console.WriteLine("1) Go out and try kick away");
                Console.WriteLine("2) Wait until he's gone");

                Console.WriteLine("Enter the number into the console");
                Console.Write("----> ");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 2)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("You messed up something. Try again");
                        Console.Write("----> ");
                        choice = Convert.ToInt32(Console.ReadLine());

                    } while (choice < 1 || choice > 2);
                }

                if(choice == 1)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 3);

                    if (stash.axe == 1)
                        ch1 = 1;
                    else if (stash.rifle == 1)
                        ch1 = 0;

                    if(ch1 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Goddammit, our rifle exploded, while we were trying to shoot those creatures, but explosion had scared it." + "\n" + "We think rabbit won't disturbe us anymore.");
                        stash.rifle = 0;
                        Console.ResetColor();
                    }
                    if(ch1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Hell yeah! We are saved! Poor hairy mutant devil! I think we are still on peak of food chain.");
                        stash.Food += 5;
                        stash.Dad.Condition--;
                        stash.Mom.Condition--;
                        stash.Son.Condition--;
                        stash.Daughter.Condition--;
                        Console.ResetColor();
                    }
                    else if(ch1 == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("We kicked it away, but Josh is wounded.");
                        stash.Son.Traumas++;
                        Console.ResetColor();
                    }
                    else if(ch1 == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("It wash hard, but we got it. Our mood gets better.");
                        stash.Dad.Condition--;
                        stash.Mom.Condition--;
                        stash.Son.Condition--;
                        stash.Daughter.Condition--;
                        Console.ResetColor();
                    }
                }
                else if(choice == 2)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 4);

                    if(ch1 == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("At night it got into the bunker. We had to hide in bathroom, while it was eating our food.");
                        stash.Food -= 5;
                        Console.ResetColor();
                    }
                    if(ch1 == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Obviously it's not gonna leave. Either we can't go out. Our mood gets worse.");
                        stash.Dad.Condition++;
                        stash.Mom.Condition++;
                        stash.Son.Condition++;
                        stash.Daughter.Condition++;
                        Console.ResetColor();
                    }
                    if(ch1 == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("It stirred us to sleep all night, we feel much worse.");
                        stash.Dad.Condition+=2;
                        stash.Mom.Condition+=2;
                        stash.Son.Condition+=2;
                        Console.ResetColor();
                        stash.Daughter.Condition+=2;
                    }
                }
            }
            if(rand == 17)
            {
                if (stash.radio == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Our favourite radio station had stopped working. We tried to catch another signal, but with no success. " +
                                      "\n" +
                                      "Are there no other radio stations? " + "\n" +
                                      "Maybe we should try to increase our radio's signal gain range?");
                    Console.ResetColor();

                    Console.WriteLine("1) Try to improve radio");
                    Console.WriteLine("2) Believe that interference will disappear");

                    Console.WriteLine("Enter the number into the console");
                    Console.Write("----> ");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice < 1 || choice > 2)
                    {
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine("You messed up something. Try again");
                            Console.Write("----> ");
                            choice = Convert.ToInt32(Console.ReadLine());

                        } while (choice < 1 || choice > 2);
                    }

                    if (choice == 1)
                    {

                        Random _random = new Random();
                        int ch1 = _random.Next(1, 4);

                        if (stash.tools == 1)
                            ch1 = 1;

                        if(ch1 == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("We improved our radio, but tools are broken");
                            stash.tools = 0;
                            Console.ResetColor();
                        }
                        else if(ch1 == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("We couldn't do anything, Our mood gets worse.");
                            stash.Dad.Condition++;
                            stash.Mom.Condition++;
                            stash.Son.Condition++;
                            stash.Daughter.Condition++;
                            Console.ResetColor();
                        }
                        else if(ch1 == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Hell yeah, we got it, we hope it'll never break again.");
                            Console.ResetColor();
                        }

                        Console.WriteLine();
                    }

                    if (choice == 2)
                    {
                        Random _random = new Random();
                        int ch1 = _random.Next(1, 4);

                        if(ch1 == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Those are just technical problems. It should be like this. Everything will be alright...");
                            Console.ResetColor();
                        }
                        else if(ch1 == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("What a pity! Our radio stopped working.");
                            Console.ResetColor();
                            stash.radio = 0;
                        }
                        else if(ch1 == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("There were just temporal interferences and now everuthing is alright.");
                            Console.ResetColor();
                        }

                        Console.WriteLine();


                    }
                }
                else
                {
                    Random rdm = new Random();
                    rand = rdm.Next();
                }
            
            }
            if(rand == 18)
            {
                if (stash.radio == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Nothing...literally nothing, besides silence - that's what we hear from radio. No music, no speak, nothing." +
                                      "\n" +
                                      "Can we do anything with radio to make work again? " + "\n" +
                                      "Looking on it definitely will not help.");
                    Console.ResetColor();

                    Console.WriteLine("1) Try to fix radio");
                    Console.WriteLine("2) Ignore");

                    Console.WriteLine("Enter the number into the console");
                    Console.Write("----> ");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice < 1 || choice > 2)
                    {
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine("You messed up something. Try again");
                            Console.Write("----> ");
                            choice = Convert.ToInt32(Console.ReadLine());

                        } while (choice < 1 || choice > 2);
                    }

                    if (choice == 1)
                    {

                        Random _random = new Random();
                        int ch1 = _random.Next(1, 3);

                        if (stash.tools == 1)
                            ch1 = 1;

                        if (ch1 == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("We fixed our radio, but tools are broken");
                            stash.tools = 0;
                            Console.ResetColor();
                        }
                        else if (ch1 == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Unfortunately, punches didn't help radio, we can't do anything");
                            stash.radio = 0;
                            Console.ResetColor();
                        }
                        else if (ch1 == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Yeah, we fixed it, but Peter got electrocuted.");
                            stash.Dad.Traumas++;
                            Console.ResetColor();
                        }

                        Console.WriteLine();
                    }

                    if (choice == 2)
                    {
                        Random _random = new Random();
                        int ch1 = _random.Next(1, 4);

                        if (ch1 == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("There is very boring without music. Our mood gets worse.");
                            stash.Dad.Condition++;
                            stash.Mom.Condition++;
                            stash.Son.Condition++;
                            stash.Daughter.Condition++;
                            Console.ResetColor();
                        }
                        else if (ch1 == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("It's bad to be without radio, but there's nothing we can do.");
                            stash.radio = 0;
                            Console.ResetColor();
                        }
                        else if (ch1 == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("There were just temporal interferences and now everything is alright.");
                            Console.ResetColor();
                        }

                        Console.WriteLine();

                        }
                }
                else
                {
                    Random rdm = new Random();
                    rand = rdm.Next();
                }
            }
            if(rand == 19)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("In morning someone knocked on our door. There is a strange man, asking some water." +
                                  "\n" +
                                  "He offered to change it on food. " + "\n" +
                                  "Can we believe him?");
                Console.ResetColor();

                Console.WriteLine("1) Accept an offer");
                Console.WriteLine("2) Ignore");

                Console.WriteLine("Enter the number into the console");
                Console.Write("----> ");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 2)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("You messed up something. Try again");
                        Console.Write("----> ");
                        choice = Convert.ToInt32(Console.ReadLine());

                    } while (choice < 1 || choice > 2);
                }

                if(choice == 1)
                {
                    

                    Random _random = new Random();
                    int ch1 = _random.Next(1, 10);

                    if(ch1 <= 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("We traded some our water on his food.");
                        stash.Food += 5;
                        Console.ResetColor();
                        stash.Water -= 3;
                    }
                    if (ch1 > 3 && ch1 <= 7)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("We traded some our water on his food.");
                        stash.Food += 4;
                        Console.ResetColor();
                        stash.Water -= 3;
                    }
                    if (ch1 > 7)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Unfortunately, stranger cheated on us. When we gave him water, stranger threatened us with gun and ran away.");
                        stash.Water -= 3;
                        Console.ResetColor();
                    }
                }
                else if(choice == 2)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 10);

                    if (ch1 >4)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Seems that he is mentally ill and when we agreed his offer, he had just laughed and run away.");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("When we opened the door stranger got into the bunker, punched Peter and stole our food.");
                        stash.Food -= 4;
                        stash.Dad.Traumas++;
                        Console.ResetColor();
                    }
                }
            }
            if(rand == 20)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Today old man came to our door." +
                                  "\n" +
                                  "He looked bad and sick. Old man asked for some food. " + "\n" +
                                  "He doesn't inspire confidence, but we've seen bottles with water in his backpack. Maybe he would agree to change?");
                Console.ResetColor();

                Console.WriteLine("1) Accept an offer");
                Console.WriteLine("2) Ignore");

                Console.WriteLine("Enter the number into the console");
                Console.Write("----> ");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 2)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("You messed up something. Try again");
                        Console.Write("----> ");
                        choice = Convert.ToInt32(Console.ReadLine());

                    } while (choice < 1 || choice > 2);
                }

                if(choice == 1)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 10);

                    if (ch1 <= 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("We've fed him, and old man agreed to give us some water instead.");
                        stash.Food += 5;
                        Console.ResetColor();
                        stash.Water -= 3;
                    }
                    if (ch1 > 3 && ch1 <= 7)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("We've fed him, and old man agreed to give us some water instead.");
                        stash.Food += 4;
                        stash.Water -= 3;
                               Console.ResetColor(); ;
                    }
                    if (ch1 > 7)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Unfortunately, old man cheated on us. When we gave him water, old man threatened us with gun and ran away.");
                        stash.Water -= 3;
                        Console.ResetColor();
                    }
                }
            }
            if(rand == 21)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("We've been shocked seeing a man dressed up in bright clothes near our door." +
                                  "\n" +
                                  "We've decided to do out and ask, what he wants. " + "\n" +
                                  "A man said that he is a merchant and he have some offers for us to change our items on something else. ");
                

                if(stash.radio == 0&&stash.padlock == 1)
                {
                    Console.WriteLine("1) Our Padlock on his Radio.");
                }
                if (stash.radio == 0 && stash.ammunition == 1)
                {
                    Console.WriteLine(" 2) Our Ammunition for his Radio.");
                }
                if(stash.map == 0&&stash.rifle == 1)
                {
                    Console.WriteLine(" 3) Our Rifle for his Map.");
                }
                if(stash.book == 0&&stash.cards == 1)
                {
                    Console.WriteLine(" 4) Our Cards for his Boy Scout Handbook.");
                }
                if(stash.rifle == 0&&stash.poison == 1)
                {
                    Console.WriteLine(" 5) Our Poison for his Rifle.");
                }

                Console.WriteLine(" 6) Ignore.");

                Console.WriteLine("Enter the number into the console");
                Console.Write("----> ");
                Console.ResetColor();

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 6)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("You messed up something. Try again");
                        Console.Write("----> ");
                        choice = Convert.ToInt32(Console.ReadLine());

                    } while (choice < 1 || choice > 2);
                }

                if(choice == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("We've traded our Padlock on his Radio.");
                    stash.padlock = 0;
                    stash.radio = 1;
                    Console.ResetColor();
                }
                else if(choice == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("We've traded our Ammunition on his Radio.");
                    stash.ammunition = 0;
                    stash.radio = 1;
                    Console.ResetColor();
                }
                else if(choice == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("We've trade our Rifle on his Map.");
                    stash.rifle = 0;
                    stash.map = 1;
                    Console.ResetColor();
                }
                else if(choice == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("We've traded our Deck of Cards on his Boy Scout Handbook.");
                    stash.cards = 0;
                    stash.book = 1;
                    Console.ResetColor();
                }
                else if(choice == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("We've traded our Poison on his Rifle.");
                    stash.poison = 0;
                    stash.rifle = 1;
                    Console.ResetColor();
                }
                else if(choice == 6)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("We prefer to have no deals with strangers." );
                }
            }
            if(rand == 22)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("There is an unexpected knock on our doors." +
                                  "\n" +
                                  "We understand that there are bandits. And we know what did they come for." + "\n" +
                                  "But what should we do?");
                Console.ResetColor();

                Console.WriteLine("1) Resist");
                Console.WriteLine("2) Ignore");

                Console.WriteLine("Enter the number into the console");
                Console.Write("----> ");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 2)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("You messed up something. Try again");
                        Console.Write("----> ");
                        choice = Convert.ToInt32(Console.ReadLine());

                    } while (choice < 1 || choice > 2);
                }

                if(choice == 1)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(3, 10);

                    if (stash.rifle == 1) { ch1 = 1; }
                    else if(stash.padlock == 1) { ch1 = 2; }
                    else if(stash.axe == 1) { ch1 = 3; }

                    if (ch1 >= 4 && ch1 <= 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Bandits found out that our door is too thick and they can't break it. They ran away. We are celebrating our win. Our mood gets better.");
                        stash.Dad.Condition--;
                        stash.Mom.Condition--;
                        stash.Son.Condition--;
                        stash.Daughter.Condition--;
                        Console.ResetColor();

                    }
                    else if (ch1 > 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Bandits broke in our bunker and stole our food and water. Peter tried to stop them but was shot.");
                        stash.Food -= 5;
                        stash.Water -= 4;
                        stash.Dad.Traumas++;
                        Console.ResetColor();
                    }
                    else if(ch1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("We tried to shoot them with our rifle, but it had exploded. Bandits are scared of explosion and run away." +"\n" + 
                            "Rifle is broken, but we are celebrating our win. Our mood gets better.");
                        stash.rifle = 0;
                        stash.Dad.Condition--;
                        stash.Mom.Condition--;
                        stash.Son.Condition--;
                        stash.Daughter.Condition--;
                        Console.ResetColor();
                    }
                    else if(ch1 == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("We've closed our door on additional padlock. Bandits had no chance against it. They've ran away with nothing." + "\n"+
                            "Our padlock is broken, but we are celebrating our win. Our mood gets better.");
                        stash.padlock = 0;
                        stash.Dad.Condition--;
                        stash.Mom.Condition--;
                        stash.Son.Condition--;
                        stash.Daughter.Condition--;
                        Console.ResetColor();
                    }
                    else if(ch1 == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Peter's decided to show his power. He took an axe, opened the door ahd threw axe in the biggest bandit. But he's missed and axe stuck in wall crack." + "\n"  + 
                            "Two seconds of silence...And from crack in the wall got out an army of rats. Peter managed to close door on time. Rats attacked bandits and they just ran away." + "\n" + 
                            "Our axe is lost, but we are celebrating our win. Our mood gets better.");
                        stash.axe = 0;
                        stash.Dad.Condition--;
                        stash.Mom.Condition--;
                        stash.Son.Condition--;
                        stash.Daughter.Condition--;
                        Console.ResetColor();
                    }

                }
                else if(choice == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bandits broke in our bunker and stole our food and water.");
                    stash.Food -= 5;
                    stash.Water -= 5;
                    Console.ResetColor();

                }
            }
            if(rand == 23)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Oh no, we knew that there is a band wielding near our bunker. And today is the day that we've feared." +
                                  "\n" +
                                  "They've come to us." + "\n" +
                                  "What should we do?");
                Console.ResetColor();

                Console.WriteLine("1) Resist");
                Console.WriteLine("2) Ignore");

                Console.WriteLine("Enter the number into the console");
                Console.Write("----> ");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 2)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("You messed up something. Try again");
                        Console.Write("----> ");
                        choice = Convert.ToInt32(Console.ReadLine());

                    } while (choice < 1 || choice > 2);
                }
                if(choice == 1)
                {

                    Random _random = new Random();
                    int ch1 = _random.Next(3, 10);
                    
                    if (stash.rifle == 1) { ch1 = 1; }
                    else if (stash.padlock == 1) { ch1 = 2; }
                    else if (stash.axe == 1) { ch1 = 3; }

                    if (ch1 >= 4 && ch1 <= 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Bandits found out that our door is too thick and they can't break it. They ran away. We are celebrating our win. Our mood gets better.");
                        stash.Dad.Condition--;
                        stash.Mom.Condition--;
                        stash.Son.Condition--;
                        stash.Daughter.Condition--;
                        Console.ResetColor();

                    }
                    else if (ch1 > 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Bandits broke in our bunker and stole our food and water. Peter tried to stop them but was shot.");
                        stash.Food -= 5;
                        stash.Water -= 4;
                        stash.Dad.Traumas++;
                        Console.ResetColor();
                    }
                    else if (ch1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("We tried to shoot them with our rifle, but it had exploded. Bandits are scared of explosion and run away." + "\n" +
                            "Rifle is broken, but we are celebrating our win. Our mood gets better.");
                        stash.rifle = 0;
                        stash.Dad.Condition--;
                        stash.Mom.Condition--;
                        stash.Son.Condition--;
                        stash.Daughter.Condition--;
                        Console.ResetColor();
                    }
                    else if (ch1 == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("We've closed our door on additional padlock. Bandits had no chance against it. They've ran away with nothing." + "\n" +
                            "Our padlock is broken, but we are celebrating our win. Our mood gets better.");
                        stash.padlock = 0;
                        stash.Dad.Condition--;
                        stash.Mom.Condition--;
                        stash.Son.Condition--;
                        stash.Daughter.Condition--;
                        Console.ResetColor();
                    }
                    else if (ch1 == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Peter's decided to show his power. He took an axe, opened the door ahd threw axe in the biggest bandit. But he's missed and axe stuck in wall crack." + "\n" +
                            "Two seconds of silence...And from crack in the wall got out an army of rats. Peter managed to close door on time. Rats attacked bandits and they just ran away." + "\n" +
                            "Our axe is lost, but we are celebrating our win. Our mood gets better.");
                        stash.axe = 0;
                        stash.Dad.Condition--;
                        stash.Mom.Condition--;
                        stash.Son.Condition--;
                        stash.Daughter.Condition--;
                        Console.ResetColor();
                    }
                }
                else if(choice == 2)
                {
                    int ch1 = 0;
                    if (stash.Son.dead != true)
                    {
                        Random _random = new Random();
                        ch1 = _random.Next(1, 15);
                    }
                    else
                    {
                        Random _random = new Random();
                        ch1 = _random.Next(1, 14);
                    }

                    if(ch1>1&&ch1 <= 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Bandits broke in our bunker and stole our food.");
                        stash.Food -= 13; 
                        Console.ResetColor();
                    }
                    else if (ch1 > 4 && ch1 <= 7)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Bandits broke in our bunker and stole our water.");
                        stash.Water -= 13;
                        Console.ResetColor();
                    }
                    else if (ch1 > 7 && ch1 <= 14)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Bandits broke in our bunker and stole our food and water.");
                        stash.Food -= 7;
                        stash.Water -= 7;
                        Console.ResetColor();
                    }
                    else if(ch1 == 15)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("When bandits broke in our bunker, Josh tried to stop them. But he is a kid and can't do anything." + "\n" +
                            "Leader of bandits appreciated Josh for his bravery and decided to make him a part of their band.");
                        stash.Son.dead = true;
                        Console.ResetColor();
                    }
                }
            }
            if(rand == 24)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("We've noticed that there are strangers walking near our door." +
                                  "\n" +
                                  "They don't look like bandits, so we decided to talk with them. Strangers asked some water." + "\n" +
                                  "But what should we do?");
                Console.ResetColor();

                Console.WriteLine("1) Share some water");
                Console.WriteLine("2) Ignore");

                Console.WriteLine("Enter the number into the console");
                Console.Write("----> ");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 2)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("You messed up something. Try again");
                        Console.Write("----> ");
                        choice = Convert.ToInt32(Console.ReadLine());

                    } while (choice < 1 || choice > 2);
                }

                if(choice == 1)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 10);

                    if (ch1 <= 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("We've shared some water with strangers and they gave us Boy Scout Handbook.");
                        stash.Water -= 5;
                        stash.book = 1;
                        Console.ResetColor();
                    }
                    else if (ch1 > 4 && ch1 <= 7)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("We've shared some water with strangers and they gave us a deck of cards.");
                        stash.Water -= 5;
                        stash.cards = 1;
                        Console.ResetColor();
                    }
                    else if (ch1 > 7)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("We've shared some water with strangers, they thanked us and walked away. Our mood gets better.");
                        stash.Water -= 4;
                        stash.Dad.Condition--;
                        stash.Mom.Condition--;
                        stash.Son.Condition--;
                        stash.Daughter.Condition--;
                        Console.ResetColor();
                    }
                }
                else if(choice == 2)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 10);

                    if (ch1 < 7)
                    {
                        Console.WriteLine("We said them to go away. And strangers sadly went.");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("We said them to go away. But they wounded Peter, broke in our bunker and stole our food and water.");
                        stash.Food -= 5;
                        stash.Water -= 5;
                        stash.Dad.Traumas++;
                        Console.ResetColor();
                    }
                }
            }
            if(rand == 25)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Today Margo is looking more annoyed than usually" +
                                  "\n" +
                                  "We don't know what happened." + "\n" +
                                  "Should we talk to her?");
                Console.ResetColor();

                Console.WriteLine("1) Talk to her");
                Console.WriteLine("2) Ignore");

                Console.WriteLine("Enter the number into the console");
                Console.Write("----> ");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 2)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("You messed up something. Try again");
                        Console.Write("----> ");
                        choice = Convert.ToInt32(Console.ReadLine());

                    } while (choice < 1 || choice > 2);
                }

                if(choice == 1)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 10);

                    if (ch1 < 5) 
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("We told some jokes to Margo and she looks much more cheerful.");
                        stash.Mom.Condition--; 
                        Console.ResetColor();
                    }
                    if (ch1 >= 5 && ch1 < 8)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("We tried to talk with Margo, but her mood just got worse.");
                        stash.Mom.Condition++;
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("We tried to talk with Margo, but she started to argue with Peter and their mood got worse.");
                        stash.Dad.Condition++;
                        stash.Mom.Condition++;
                        Console.ResetColor();
                    }
                }
                else if(choice == 2)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 5);

                    if(ch1<5)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Margo understood taht we are ignoring her and her mood just got worse.");
                        stash.Mom.Condition++;
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Margo just neede some time to think out. Her mood got better.");
                        stash.Mom.Condition--;
                        Console.ResetColor();
                    }
                }
            }
            if(rand == 26)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Children are in a bad mood today." +
                                  "\n" +
                                  "They told that there is very boring in bunker and asked to play games." + "\n" +
                                  "Should we let them play?");
                Console.ResetColor();

                Console.WriteLine("1) Let them play");
                Console.WriteLine("2) Ignore");

                Console.WriteLine("Enter the number into the console");
                Console.Write("----> ");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 2)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("You messed up something. Try again");
                        Console.Write("----> ");
                        choice = Convert.ToInt32(Console.ReadLine());

                    } while (choice < 1 || choice > 2);
                }

                if(choice == 1)
                {
                    int ch1 = 0;
                    if(stash.book == 1)
                        ch1 = 1;
                    if(stash.cards == 1)
                        ch1 = 2;
                    if (stash.checkers == 1)
                        ch1 = 3;
                    if (stash.map == 1)
                        ch1 = 4;

                    if(ch1 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Children tried to read book and play, but tore it. Their mood gets better.");
                        stash.Son.Condition--;
                        stash.Daughter.Condition--;
                        stash.book = 0;
                        Console.ResetColor();
                    }
                    else if(ch1 == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Children tried to play cards, but a lot of cards are lost now. Their mood gets better.");
                        stash.Son.Condition--;
                        stash.Daughter.Condition--;
                        stash.cards = 0;
                        Console.ResetColor();
                    }
                    else if(ch1 == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Children tried to play checkers, but a lot of checkers are lost now. Their mood gets better.");
                        stash.Son.Condition--;
                        stash.Daughter.Condition--;
                        stash.checkers = 0;
                        Console.ResetColor();
                    }
                    else if(ch1 == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Children tried to play with map, but tore it. Their mood gets better.");
                        stash.Son.Condition--;
                        stash.Daughter.Condition--;
                        stash.map = 0;
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Children played some games. Their mood gets better.");
                        stash.Son.Condition--;
                        stash.Daughter.Condition--;
                        Console.ResetColor();

                    }
                }
                else if(choice == 2)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 15);

                    if (ch1 < 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sally is bored.");
                        stash.Daughter.Condition++;
                        Console.ResetColor();
                    }
                    else if (ch1 >= 6 && ch1 < 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Josh is bored.");
                        stash.Son.Condition++;
                        Console.ResetColor();
                    }
                    else if (ch1 >= 10 && ch1 <= 14)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Josh and Sally are both bored.");
                        stash.Son.Condition++;
                        stash.Daughter.Condition++; Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Josh and Sally are bored, but they understand that there's no choice and reconciled.");
                        Console.ResetColor();
                    }
                }
            }
            if(rand == 27)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Today started with bad news. Our 4 candies that we kept and dreamed to taste are lost." +
                                  "\n" +
                                  "After some proceedings we found out that Josh ate them last night." + "\n" +
                                  "What should we do?");
                Console.ResetColor();

                Console.WriteLine("1) Punish him");
                Console.WriteLine("2) Ignore");

                Console.WriteLine("Enter the number into the console");
                Console.Write("----> ");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 2)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("You messed up something. Try again");
                        Console.Write("----> ");
                        choice = Convert.ToInt32(Console.ReadLine());

                    } while (choice < 1 || choice > 2);
                }

                if(choice == 1)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 10);

                    if (ch1 < 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("We've scolded and punished Josh. His mood gets worse.");
                        stash.Son.Condition++;
                        stash.Food -= 4;
                        Console.ResetColor();
                    }
                    else if (ch1 >= 5 && ch1 <= 9) 
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("When we started scolding Josh, he realized that he is guilty. He showed us his hided stash, where we found food.");
                        stash.Food += 2;
                        Console.ResetColor();
                    }
                    else if(ch1 == 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("After we scolded and punished Josh he offended and ran away to wasteland with nothing. WE hope he;s gonna come back.");
                        stash.Son.dead = true;
                        Console.ResetColor();
                    }
                }
                if(choice == 2)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 3);

                    if(ch1 == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Josh is touched by our grace and showe us his hided stash with food.");
                        stash.Food += 4;
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sally is displeased that we didn't punish Josh. Her mood gets worse.");
                        stash.Daughter.Condition++;
                        Console.ResetColor();
                    }
                }
            }
            if(rand == 28)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Wow, what an interesting finding." +
                                  "\n" +
                                  "We wanted to move old crate from corner, but there is a hatchway under it." + "\n" +
                                  "Should we check out this dark and narrow passage?");
                Console.ResetColor();

                Console.WriteLine("1) Check out");
                Console.WriteLine("2) Ignore");

                Console.WriteLine("Enter the number into the console");
                Console.Write("----> ");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 2)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("You messed up something. Try again");
                        Console.Write("----> ");
                        choice = Convert.ToInt32(Console.ReadLine());

                    } while (choice < 1 || choice > 2);
                }

                if(choice == 1)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 15);

                    if (ch1 < 6)
                    {
                        if (stash.axe == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("We've found an axe.");
                            stash.axe = 1;
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("We've found some water.");
                            stash.Water += 4;
                            Console.ResetColor();
                        }
                    }
                    else if (ch1 >= 6 && ch1 < 10)
                    {
                        if(stash.poison == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("We've found a poison.");
                            stash.poison = 1;
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("We've found some water.");
                            stash.Water += 4;
                            Console.ResetColor();
                        }
                    }
                    else if (ch1 >= 10 && ch1 <= 14)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("There was a rat and it bit Margo.");
                        Console.ResetColor();
                        stash.Mom.Traumas++;
                    }
                    else if(ch1 == 15)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("There was an empty dead end.");
                        Console.ResetColor();
                    }
                }
                else if(choice == 2)
                {
                    Random _random = new Random();
                    int ch1 = _random.Next(1, 3);

                    if(ch1 == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("There are rats coming from passage, there is rat's nest. They ate some our food and bit Sally.");
                        stash.Water -= 5;
                        stash.Daughter.Sickness++;
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("There was an empty dead end.");
                        Console.ResetColor();
                    }
                }
            }


            stash.CurrentDay(day);
          
            stash.Menu(); 

        }


     }
}
