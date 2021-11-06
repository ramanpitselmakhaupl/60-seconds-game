using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class People
    {
        
        int hunger, thirst, condition, sickness, traumas, hungerDeath =0, thirstDeath=0, sicknessDeath=0, traumaDeath=0;
        public string name;
        public bool wasteland = false;
        public bool dead = false;
        
        public int Hunger
        {
            get { return hunger; }
            set
            {
                hunger = value;
                hungerDeath = hunger + 1;
                if(Hunger + Thirst + Sickness > 4)
                {
                    Condition = 2;
                }
            }
        }

        public int Thirst
        {
            get { return thirst; }
            set
            {
                thirst = value;
                thirstDeath = thirst + 1;
                if (Hunger + Thirst + Sickness > 4)
                {
                    Condition = 2;
                }
            }
        }
        public int Condition
        {
            get { return condition; }
            set
            {
                if (value < 1)
                    condition = 1;
                else if (value > 6)
                    condition = 6;
                else
                    condition = value;
            }
        }
        public int Sickness
        {
            get { return sickness; }
            set
            {
                sickness = value;
                if (value == 3)
                {
                    sicknessDeath++;
                    Condition = 2;
                }
                else
                    sicknessDeath = 0;
                if (Hunger + Thirst + Sickness > 4)
                {
                    Condition = 2;
                }
            }
        }

        public int Traumas
        {
            get { return traumas; }
            set
            {
                traumas = value;
                if (value == 3)
                {
                    traumaDeath++;
                    Condition = 2;
                }
                else
                    traumaDeath = 0;
            }
        }


        public void ShowPeople()
        {
            Console.Write(name + ":");
            if (dead == false && wasteland == false) 
            {

                if (Hunger == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green; // set color
                    Console.Write(" No Hunger,");
                    Console.ResetColor(); // reset color
                }
                else if (Hunger == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" Hungry,");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Starving,");
                    Console.ResetColor();

                }

                if (Thirst == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" No Thirst,");
                    Console.ResetColor();
                }
                else if (Thirst == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" Thirsty,");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Dehydrated,");
                    Console.ResetColor();
                }

                if (Condition >= 1 && Condition <= 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" Workable,");
                    Console.ResetColor();
                }
                else if (Condition == 3 || Condition == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" Tired,");
                    Console.ResetColor();
                }
                else if (Condition == 5 || Condition == 6) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" Disabled,");
                    Console.ResetColor();
                }

                if (Sickness == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" Healthy,");
                    Console.ResetColor();
                }
                else if (Sickness == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" Ill,");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" At death,");
                    Console.ResetColor();
                }

                if (Traumas == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" No traumas.");
                    Console.ResetColor();
                }
                else if (Traumas == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" Injuried.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" In agony.");
                    Console.ResetColor();
                }

            }
            else if(dead == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Dead.");
                Console.ResetColor();
            }
            else if(wasteland == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" In wasteland.");
                Console.ResetColor();
            }

            Console.WriteLine();
            
        }

        public void HungerGrade()
        {
            if (Hunger < 3)
            {
                Hunger++;
            }
            hungerDeath++;

            if (hungerDeath == 7)
                dead = true;
        }

        public void ThirstGrade()
        {
            if(Thirst<3)
                Thirst++;

            thirstDeath++;

            if (thirstDeath == 6)
                dead = true;
        }

        


        public People(string n, int h, int t, int c, int s, int t1)
        {
            name = n;
            Hunger = h;
            Thirst = t;
            Condition = c;
            Sickness = s;
            Traumas = t1;
        }
            
        public People()
        {

        }
        

    }
    
}
