using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Main
{
    class Items : People
    {
        public People Dad = new People("Peter", 1, 1, 1, 1, 1);
        public People Mom = new People("Margo", 1, 1, 1, 1, 1);
        public People Son = new People("Josh", 1, 1, 1, 1, 1);
        public People Daughter = new People("Sally", 1, 1, 1, 1, 1);


        public int water = 0;
        public int food = 0;
        public int medkit = 0;


        public int ammunition = 0;
        public int axe = 0;
        public int book = 0;
        public int checkers = 0;
        public int cards = 0;
        public int flashlight = 0;
        public int mask = 0;
        public int map = 0;
        public int poison = 0;
        public int radio = 0;
        public int rifle = 0;
        public int padlock = 0;
        public int suitcase = 0;
        public int tools = 0;
        public int tape = 0;
        

        public int Food
        {
            get { return food; }
            set
            {
                if (food <= 30)
                    food = value;
                else
                    food = 30;
            }
        }

        public int Water
        {
            get { return water; }
            set
            {
                if (water <= 30)
                    water = value;
                else
                    water = 30;
            }
        }

        public int Medkit
        {
            get { return medkit; }
            set
            {
                if (medkit <= 4)
                    medkit = value;
                else
                    medkit = 4;
            }
        }



        //Random starter kit
        public void KitStart()
        {
            Random _random = new Random();
            int num;

            Food = _random.Next(10, 16);
            Water = _random.Next(10, 14);
            medkit = _random.Next(1, 3);

            for (int i = 0; i < 7; i++)
            {
                num = _random.Next(0, 14);
                switch (num)
                {
                    case 0:
                        if (ammunition == 0)
                            ammunition = 1;
                        else
                            i--;
                        break;
                    case 1:
                        if (axe == 0)
                            axe = 1;
                        else
                            i--;
                        break;
                    case 2:
                        if (book == 0)
                            book = 1;
                        else
                            i--;
                        break;
                    case 3:
                        if (checkers == 0)
                            checkers = 1;
                        else
                            i--;
                        break;
                    case 4:
                        if (cards == 0)
                            cards = 1;
                        else
                            i--;
                        break;
                    case 5:
                        if (flashlight == 0)
                            flashlight = 1;
                        else
                            i--;
                        break;
                    case 6:
                        if (mask == 0)
                            mask = 1;
                        else
                            i--;
                        break;
                    case 7:
                        if (map == 0)
                            map = 1;
                        else
                            i--;
                        break;
                    case 8:
                        if (tools == 0)
                            tools = 1;
                        else
                            i--;
                        break;
                    case 9:
                        if (poison == 0)
                            poison = 1;
                        else
                            i--;
                        break;
                    case 10:
                        if (radio == 0)
                            radio = 1;
                        else
                            i--;
                        break;
                    case 11:
                        if (rifle == 0)
                            rifle = 1;
                        else
                            i--;
                        break;
                    case 12:
                        if (padlock == 0)
                            padlock = 1;
                        else
                            i--;
                        break;
                    case 13:
                        if (suitcase == 0)
                            suitcase = 1;
                        else
                            i--;
                        break;
                    case 14:
                        if (tape == 0)
                            tape = 1;
                        else
                            i--;
                        break;
                }
            }
        }


        //Template starter kits
        public void KitStart(int type)
        {
            if (type == 1)
            {
                Food = 15;
                Water = 13;
                medkit = 2;
                radio = 1;
                tools = 1;
                mask = 1;
                padlock = 1;
                book = 1;
                ammunition = 1;
                suitcase = 1;
            }
            else if (type == 2)
            {
                Food = 13;
                Water = 13;
                medkit = 3;
                radio = 1;
                axe = 1;
                poison = 1;
                map = 1;
                cards = 1;
                rifle = 1;
                suitcase = 1;
            }
            else if (type == 3)
            {
                Food = 13;
                Water = 16;
                medkit = 1;
                radio = 1;
                flashlight = 1;
                padlock = 1;
                tools = 1;
                tape = 1;
                rifle = 1;
                poison = 1;
            }
            else if (type == 4)
            {
                Food = 17;
                Water = 13;
                medkit = 2;
                tape = 1;
                axe = 1;
                flashlight = 1;
                tools = 1;
                cards = 1;
                ammunition = 1;
                suitcase = 1;
            }
            else if (type == 5)
            {
                Food = 15;
                Water = 14;
                medkit = 1;
                radio = 1;
                mask = 1;
                poison = 1;
                book = 1;
                cards = 1;
                rifle = 1;
                suitcase = 1;
            }
        }

        
        


        //Inventory
        public void ShowInventory()
        {
            Console.WriteLine();
            Console.WriteLine("Your stocks:");
            if (Food <= 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Food: {0}", Food);
                Console.ResetColor();
            }
            else if (Food <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Yellow; 
                Console.WriteLine("Food: {0}", Food);
                Console.ResetColor();
            }
            if (Food > 10) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Food: {0}", Food);
                Console.ResetColor();
            }

            if (water <= 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Water: {0}", water);
                Console.ResetColor();
            }
            else if (water <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Water: {0}", water);
                Console.ResetColor();
            }
            if (water > 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Water: {0}", water);
                Console.ResetColor();
            }

            if (medkit == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Medkit: {0}", medkit);
                Console.ResetColor();
            }
            else if (medkit <= 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Medkit: {0}", medkit);
                Console.ResetColor();
            }
            if (medkit > 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Medkit: {0}", medkit);
                Console.ResetColor();
            }

            int kol = 0;
            if (ammunition == 1)
                kol++;
            if (axe == 1)
                kol++;
            if (book == 1)
                kol++;
            if (checkers == 1)
                kol++;
            if (cards == 1)
                kol++;
            if (flashlight == 1)
                kol++;
            if (mask == 1)
                kol++;
            if (map == 1)
                kol++;
            if (tape == 1)
                kol++;
            if (tools == 1)
                kol++;
            if (poison == 1)
                kol++;
            if (radio == 1)
                kol++;
            if (rifle == 1)
                kol++;
            if (padlock == 1)
                kol++;
            if (suitcase == 1)
                kol++;
            
             Console.ForegroundColor = ConsoleColor.Green;
            int kol2 = 0;
            if (ammunition == 1)
            {
                Console.Write("Ammunition");
                if (kol2 < kol-1) Console.Write(", ");
                else Console.Write(".");
                kol2++;
            }
            if (axe == 1)
            {
                Console.Write("Axe");
                if (kol2 < kol-1) Console.Write(", ");
                else Console.Write(".");
                kol2++;
            }
            if (book == 1)
            {
                Console.Write("Boy Scout Handbook");
                if (kol2 < kol-1) Console.Write(", ");
                else Console.Write(".");
                kol2++;
            }
            if (checkers == 1)
            {
                Console.Write("Checkers");
                if (kol2 < kol-1) Console.Write(", ");
                else Console.Write(".");
                kol2++;
            }
            if (cards == 1)
            {
                Console.Write("Deck of Cards");
                if (kol2 < kol-1) Console.Write(", ");
                else Console.Write(".");
                kol2++;
            }
            if (flashlight == 1)
            {
                Console.Write("Flashlight");
                if (kol2 < kol-1) Console.Write(", ");
                else Console.Write(".");
                kol2++;
            }
            if (mask == 1)
            {
                Console.Write("Gas Mask");
                if (kol2 < kol-1) Console.Write(", ");
                else Console.Write(".");
                kol2++;
            }
            if (map == 1)
            {
                Console.Write("Map");
                if (kol2 < kol-1) Console.Write(", ");
                else Console.Write(".");
                kol2++;
            }
            if (tape == 1)
            {
                Console.Write("Insulating tape");
                if (kol2 < kol-1) Console.Write(", ");
                else Console.Write(".");
                kol2++;
            }
            if (tools == 1)
            {
                Console.Write("Tools");
                if (kol2 < kol-1) Console.Write(", ");
                else Console.Write(".");
                kol2++;
            }
            if (poison == 1)
            {
                Console.Write("Poison");
                if (kol2 < kol-1) Console.Write(", ");
                else Console.Write(".");
                kol2++;
            }
            if (radio == 1)
            {
                Console.Write("Radio");
                if (kol2 < kol-1) Console.Write(", ");
                else Console.Write(".");
                kol2++;
            }
            if (rifle == 1)
            {
                Console.Write("Rifle");
                if (kol2 < kol-1) Console.Write(", ");
                else Console.Write(".");
                kol2++;
            }
            if (padlock == 1)
            {
                Console.Write("Padlock");
                if (kol2 < kol-1) Console.Write(", ");
                else Console.Write(".");
                kol2++;
            }
            if (suitcase == 1)
            {
                Console.Write("Suitcase");
                if (kol2 < kol-1) Console.Write(", ");
                else Console.Write(".");
                kol2++;
            }
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(1500);
            Menu();

        }

        

        public void Feed(People person)
        {
            Food--;
            person.Hunger = 1;
        }

        public void Drink(People person)
        {
            Water--;
            person.Thirst = 1;
        }

        public void Heal(People person)
        {
            medkit--;
            person.Sickness = 1;
        }


        int wastelandOutcome; 
        int numMask = 0;
        int NumPadlock = 0;
        int NumCArds = 0;
        int NumRadio = 0;
        int Numcheckers = 0;
        int NumPoizon = 0;
        int NumElse = 0;


        int counter = 0;

        
        public void sendToWasteland() 
        {
            int flag = 1;
           
            Console.WriteLine();
            Console.WriteLine("Choose a character to send to the wasteland.");
            Console.WriteLine("1) Peter.");
            Console.WriteLine("2) Margo.");
            Console.WriteLine("3) Josh.");
            Console.WriteLine("4) Sally.");
            Console.WriteLine("5) Back to menu.");
            Console.Write("----> ");

            int IChoose = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (IChoose < 1 || IChoose > 5)
            {
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("You messed up something. Try again");
                    Console.Write("----> ");
                    IChoose = Convert.ToInt32(Console.ReadLine());
                }
                while (IChoose < 1 || IChoose > 5);
            }

            if (IChoose == 1)
            {
                counter = 1;
                if (Dad.wasteland == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This character is already in the wasteland");
                    Console.ResetColor();
                    Console.WriteLine();
                    Menu();
                }
                else if (Dad.wasteland == false)
                {
                    Dad.wasteland = true;
                    Console.WriteLine("Choose an item to take in expedition: ");

                    if (mask == 1)
                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Gas Mask");
                        numMask = flag;
                        flag++;
                    }

                    if (padlock == 1)
                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Padlock");
                        NumPadlock = flag;
                        flag++;

                    }
                    if (cards == 1)
                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Deck of Cards");
                        NumCArds = flag;
                        flag++;
                    }

                    if (radio == 1)
                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Radio");
                        NumRadio = flag;
                        flag++;
                    }

                    if (checkers == 1)
                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Checkers");
                        Numcheckers = flag;
                        flag++;
                    }

                    if (poison == 1)
                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Poison");
                        NumPoizon = flag;
                        flag++;
                    }

                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Take nothing.");
                        NumElse = flag;
                        flag++;
                    }
                    Console.Write("----> ");
                    wastelandOutcome = Convert.ToInt32(Console.ReadLine());
                    if (wastelandOutcome < 1 || wastelandOutcome > flag-1)
                    {
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine("You messed up something. Try again");
                            Console.Write("----> ");
                            wastelandOutcome = Convert.ToInt32(Console.ReadLine());
                        }
                        while (wastelandOutcome < 1 || wastelandOutcome > flag-1);
                    }

                   
                    if (numMask == wastelandOutcome) mask = 0;
                    if (NumPadlock == wastelandOutcome) padlock = 0;
                    if (NumCArds == wastelandOutcome) cards = 0;
                    if (NumRadio == wastelandOutcome) radio = 0;
                    if (Numcheckers == wastelandOutcome) checkers = 0;
                    if (NumPoizon == wastelandOutcome) poison = 0;
                   
                    Console.WriteLine();
                    Menu();
                }
            }

            else if (IChoose == 2)
            {
                counter = 2;
                if (Mom.wasteland == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This character is already in the wasteland");
                    Console.ResetColor();
                    Console.WriteLine();
                    Menu();
                }
                else if (Mom.wasteland == false)
                {
                    Mom.wasteland = true;
                    Console.WriteLine("Choose an item to take in expedition: ");

                    if (mask == 1)
                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Gas Mask");
                        numMask = flag;
                        flag++;
                    }

                    if (padlock == 1)
                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Padlock");
                        NumPadlock = flag;
                        flag++;

                    }
                    if (cards == 1)
                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Deck of Cards");
                        NumCArds = flag;
                        flag++;
                    }

                    if (radio == 1)
                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Radio");
                        NumRadio = flag;
                        flag++;
                    }

                    if (checkers == 1)
                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Checkers");
                        Numcheckers = flag;
                        flag++;
                    }

                    if (poison == 1)
                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Poison");
                        NumPoizon = flag;
                        flag++;
                    }

                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Take nothing.");
                        NumElse = flag;
                        flag++;
                    }
                    Console.Write("----> ");
                    wastelandOutcome = Convert.ToInt32(Console.ReadLine());
                    if (wastelandOutcome < 1 || wastelandOutcome > flag - 1)
                    {
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine("You messed up something. Try again");
                            Console.Write("----> ");
                            wastelandOutcome = Convert.ToInt32(Console.ReadLine());
                        }
                        while (wastelandOutcome < 1 || wastelandOutcome > flag - 1);
                    }

                    if (numMask == wastelandOutcome) mask = 0;
                    if (NumPadlock == wastelandOutcome) padlock = 0;
                    if (NumCArds == wastelandOutcome) cards = 0;
                    if (NumRadio == wastelandOutcome) radio = 0;
                    if (Numcheckers == wastelandOutcome) checkers = 0;
                    if (NumPoizon == wastelandOutcome) poison = 0;
                   
                    Console.WriteLine();
                    Menu();
                }
            }

            else if (IChoose == 3)
            {
                counter = 3;
                if (Son.wasteland == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This character is already in the wasteland");
                    Console.ResetColor();
                    Console.WriteLine();
                    Menu();
                }
                else if (Son.wasteland == false)
                {
                    Son.wasteland = true;
                    Console.WriteLine("Choose an item to take in expedition: ");

                    if (mask == 1)
                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Gas Mask");
                        numMask = flag;
                        flag++;
                    }

                    if (padlock == 1)
                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Padlock");
                        NumPadlock = flag;
                        flag++;

                    }
                    if (cards == 1)
                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Deck of Cards");
                        NumCArds = flag;
                        flag++;
                    }

                    if (radio == 1)
                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Radio");
                        NumRadio = flag;
                        flag++;
                    }

                    if (checkers == 1)
                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Checkers");
                        Numcheckers = flag;
                        flag++;
                    }

                    if (poison == 1)
                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Poison");
                        NumPoizon = flag;
                        flag++;
                    }

                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Take nothing.");
                        NumElse = flag;
                        flag++;
                    }
                    Console.Write("----> ");
                    wastelandOutcome = Convert.ToInt32(Console.ReadLine());
                    if (wastelandOutcome < 1 || wastelandOutcome > flag - 1)
                    {
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine("You messed up something. Try again");
                            Console.Write("----> ");
                            wastelandOutcome = Convert.ToInt32(Console.ReadLine());
                        }
                        while (wastelandOutcome < 1 || wastelandOutcome > flag - 1);
                    }

                    
                    if (numMask == wastelandOutcome) mask = 0;
                    if (NumPadlock == wastelandOutcome) padlock = 0;
                    if (NumCArds == wastelandOutcome) cards = 0;
                    if (NumRadio == wastelandOutcome) radio = 0;
                    if (Numcheckers == wastelandOutcome) checkers = 0;
                    if (NumPoizon == wastelandOutcome) poison = 0;
                   
                    Console.WriteLine();
                    Menu();
                }

            }

            else if (IChoose == 4)
            {
                counter = 4;
                if (Daughter.wasteland == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This character is already in the wasteland");
                    Console.ResetColor();
                    Console.WriteLine();
                    Menu();
                }
                else if (Daughter.wasteland == false)
                {
                    Daughter.wasteland = true;
                    Console.WriteLine("Choose an item to take in expedition: ");

                    if (mask == 1)
                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Gas Mask");
                        numMask = flag;
                        flag++;
                    }

                    if (padlock == 1)
                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Padlock");
                        NumPadlock = flag;
                        flag++;

                    }
                    if (cards == 1)
                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Deck of Cards");
                        NumCArds = flag;
                        flag++;
                    }

                    if (radio == 1)
                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Radio");
                        NumRadio = flag;
                        flag++;
                    }

                    if (checkers == 1)
                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Checkers");
                        Numcheckers = flag;
                        flag++;
                    }

                    if (poison == 1)
                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Poison");
                        NumPoizon = flag;
                        flag++;
                    }

                    {
                        Console.Write("{0})", flag);
                        Console.WriteLine("Take nothing.");
                        NumElse = flag;
                        flag++;
                    }

                    Console.Write("----> ");
                    wastelandOutcome = Convert.ToInt32(Console.ReadLine());
                    if (wastelandOutcome < 1 || wastelandOutcome > flag - 1)
                    {
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine("You messed up something. Try again");
                            Console.Write("----> ");
                            wastelandOutcome = Convert.ToInt32(Console.ReadLine());
                        }
                        while (wastelandOutcome < 1 || wastelandOutcome > flag - 1);
                    }
                   
                   
                    if (numMask == wastelandOutcome) mask = 0;
                    if (NumPadlock == wastelandOutcome) padlock = 0;
                    if (NumCArds == wastelandOutcome) cards = 0;
                    if (NumRadio == wastelandOutcome) radio = 0;
                    if (Numcheckers == wastelandOutcome) checkers = 0;
                    if (NumPoizon == wastelandOutcome) poison = 0;
                   
                    Console.WriteLine();
                    Menu();
                }
            }

            else if (IChoose == 5) // выход в меню
            {
                Menu();
                Console.WriteLine();
                Thread.Sleep(1000);
            }
            
        }

        int dayToReturn=99;
        int NowDay;
            
        public void CurrentDay(int day)
        {
            NowDay = day;
        }
        public void backFromWasteland(People person)
        {
            Dad.wasteland = false;
            Mom.wasteland = false;
            Son.wasteland = false;
            Daughter.wasteland = false;

            int wsOutCome1 = 0;

            if (numMask == wastelandOutcome) wsOutCome1 = 1;
            if (NumPadlock == wastelandOutcome) wsOutCome1 = 2;
            if (NumCArds == wastelandOutcome) wsOutCome1 = 3;
            if (NumRadio == wastelandOutcome) wsOutCome1 = 4;
            if (Numcheckers == wastelandOutcome) wsOutCome1 = 5;
            if (NumPoizon == wastelandOutcome) wsOutCome1 = 6;
            if (NumElse == wastelandOutcome) wsOutCome1 = 7;

            Random _random = new Random();
            int temp;

            if (wsOutCome1 == 1)
            {
                temp = _random.Next(0, 11);
                if (temp < 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    person.Sickness++;
                    Console.WriteLine("However, due to poor conditions outside, the character became ill.");
                    Console.WriteLine("No supplies were found");
                    Console.ResetColor();
                }
            
                else if (temp >= 3 && temp <= 7)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Water += 5;
                    Food += 5;
                    Console.WriteLine("During the sortie, it was found: 5food, 5 water.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Water += 5;
                    Food += 5;
                    medkit++;
                    Console.WriteLine("During the sortie, it was found: 5 food, 5 water, 1 medkit.");
                    Console.ResetColor();
                }
            }
                if (wsOutCome1 == 2)
                {
                    temp = _random.Next(0, 11);
                    if (temp <= 3)
                    {
                    person.Sickness++;
                        Water += 6;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("During the sortie, it was found: 6 water.");
                    Console.WriteLine("However, due to poor conditions outside, the character became ill.");
                    Console.ResetColor();
                }
                    else if (temp > 6 && temp <= 8 && book == 0)
                    {
                        book = 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("During the sortie, it was found: Book.");
                    Console.ResetColor();
                }
                    else if (temp > 8 && rifle == 0)
                    {
                        rifle = 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("During the sortie, it was found: Rifle.");
                    Console.ResetColor();
                }
                    else
                    {
                        Water += 6;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("During the sortie, it was found: 6 water.");
                    Console.ResetColor();
                }
                }
                if (wsOutCome1 == 3)
                {
                    temp = _random.Next(0, 11);
                    if (temp > 6 && temp <= 8 && map == 0)
                    {
                        map = 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("During the sortie, it was found: Map.");
                    Console.ResetColor();
                }
                    else if (temp > 8 && book == 0)
                    {
                        book = 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("During the sortie, it was found: Book.");
                    Console.ResetColor();
                }
                    else if (temp < 3)
                    {
                    person.Sickness++;
                        Water += 6;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("During the sortie, it was found: 6 water.");
                    Console.WriteLine("However, due to poor conditions outside, the character became ill.");
                    Console.ResetColor();
                }
                    else
                    {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Water += 6;
                    Console.WriteLine("During the sortie, it was found: 6 water.");
                    Console.ResetColor();
                }
                }
                if (wsOutCome1 == 4)
                {
                    temp = _random.Next(0, 11);
                    if (temp < 3)
                    {
                    person.Sickness++;
                        Water += 8;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("During the sortie, it was found: 8 water.");
                    Console.WriteLine("However, due to poor conditions outside, the character became ill.");
                    Console.ResetColor();
                }
                    else if (temp > 6 && temp <= 8)
                    {
                        medkit+=2;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("During the sortie, it was found: 2 medkit.");
                    Console.ResetColor();
                }
                    else if (temp > 8 && poison == 0)
                    {
                        poison = 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("During the sortie, it was found: Poison.");
                    Console.ResetColor();
                }
                    else
                    {
                        Water += 8;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("During the sortie, it was found: 8 water.");
                    Console.ResetColor();
                }
                }
                if (wsOutCome1 == 5)
                {
                    temp = _random.Next(0, 11);
                    if (temp < 3)
                    {
                    person.Sickness++;
                        Food += 8;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("During the sortie, it was found: 8 food.");
                    Console.WriteLine("However, due to poor conditions outside, the character became ill.");
                    Console.ResetColor();

                }
                    else if (temp > 6 && temp <= 8 && radio == 0)
                    {
                        radio = 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("During the sortie, it was found: Radio.");
                    Console.ResetColor();
                }
                    else if (temp > 8 && ammunition == 0)
                    {
                        ammunition = 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("During the sortie, it was found: Ammunition.");
                    Console.ResetColor();
                }
                    else
                    {
                        Food += 8;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("During the sortie, it was found: 8 food.");
                    Console.ResetColor();
                }
                }
                if (wsOutCome1 == 6)
                {
                    temp = _random.Next(0, 11);
                    if (temp < 3)
                    {
                    person.Sickness++;
                        Food += 6;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("During the sortie, it was found: 6 food.");
                    Console.WriteLine("However, due to poor conditions outside, the character became ill.");
                    Console.ResetColor();
                }
                    else if (temp > 6 && temp <= 8 && radio == 0)
                    {
                        radio = 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("During the sortie, it was found: Radio.");
                    Console.ResetColor();
                }
                    else if (temp > 8 && map == 0)
                    {
                        map = 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("During the sortie, it was found: Map.");
                    Console.ResetColor();
                }
                    else
                    {
                        Food += 6;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("During the sortie, it was found: 6 food.");
                    Console.ResetColor();
                }
                }
                if (wsOutCome1 == 7)
                {
                    temp = _random.Next(0, 11);
                    if (temp <= 6)
                    {
                    person.Sickness++;
                        Food += 6;
                        Water += 8;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("During the sortie, it was found: 6 food, 8 water.");
                    Console.WriteLine("However, due to poor conditions outside, the character became ill.");
                    Console.ResetColor();
                }
                    else
                    {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Food += 6;
                        Water += 8;
                        Console.WriteLine("During the sortie, it was found: 6 food, 8 water.");
                    Console.ResetColor();
                }
                }
            wastelandOutcome = 0;
            numMask = 0;
            NumPadlock = 0;
            NumCArds = 0;
            NumRadio = 0;
            Numcheckers = 0;
            NumPoizon = 0;
            NumElse = 0;
            dayToReturn = 99;
        }

            //менюшка
            public void Menu()
            {
            CurrentDay(NowDay);
            if(dayToReturn+3 == NowDay)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Wasteland Expedition Completed");
                switch (counter)
                {
                    case 1:
                        backFromWasteland(Dad);
                        break;
                    case 2:
                        backFromWasteland(Mom);
                        break;
                    case 3:
                        backFromWasteland(Son);
                        break;
                    case 4:
                        backFromWasteland(Daughter);
                        break;
                }
                Console.ResetColor();
                Console.WriteLine();
            }


                Console.WriteLine("Action menu: ");
                Console.WriteLine("1) Family member information"); // сделать вывод информации о всех членах семьи (нужна ли вода, еда, медикоменты, может ли трудитться) (может что-то еще надо вывести, но я не помню)
                Console.WriteLine("2) Interaction with characters    "); //  сделать возможность поить кормить и лечить 
                Console.WriteLine("3) Resource list");
                Console.WriteLine("4) Send to the wasteland"); // сделать отправку в пустош и выборку снаряжения которое можнодать с тобой (последнее не обязательно)
                Console.WriteLine("5) The next day"); // сделать преключение на следующий день

                Console.WriteLine("Enter the number into the console");
                Console.Write("----> ");

              
                int choose = Convert.ToInt32(Console.ReadLine());

                if (choose < 1 || choose > 5)
                {
                   do
                   {
                       Console.WriteLine();
                       Console.WriteLine("You messed up something. Try again");
                       Console.Write("----> ");
                       choose = Convert.ToInt32(Console.ReadLine());
                   }
                   while (choose < 1 || choose > 5);
                }

                if (choose == 1)
                {
                    Console.WriteLine();
                    Dad.ShowPeople();
                    Mom.ShowPeople();
                    Son.ShowPeople();
                    Daughter.ShowPeople();
                    Thread.Sleep(1500);
                    Menu();
                }

                if (choose == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Interaction menu: ");
                Console.WriteLine("1) Eat.");
                Console.WriteLine("2) Drink.");
                Console.WriteLine("3) Heal.");
                Console.WriteLine("4) Back to menu.");
                Console.Write("----> ");


                int IChoose = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (IChoose < 1 || IChoose > 4)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("You messed up something. Try again");
                        Console.Write("----> ");
                        IChoose = Convert.ToInt32(Console.ReadLine());
                    }
                    while (IChoose < 1 || IChoose > 4);
                }

                if (IChoose == 1) //FEED
                {
                    Console.WriteLine("Choose who should eat: ");
                    Console.WriteLine("1) Peter.");
                    Console.WriteLine("2) Margo.");
                    Console.WriteLine("3) Josh.");
                    Console.WriteLine("4) Sally.");
                    Console.WriteLine("5) Back to menu.");
                    Console.Write("----> ");


                    int _ = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    if (_ < 1 || _ > 5)
                    {
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine("You messed up something. Try again");
                            Console.Write("----> ");
                            _ = Convert.ToInt32(Console.ReadLine());
                        }
                        while (_ < 1 || _ > 5);
                    }

                    if (_ == 1)
                    {
                        Feed(Dad);
                        Menu();
                    }
                    else if (_ == 2)
                    {
                        Feed(Mom);
                        Menu();
                    }
                    else if (_ == 3)
                    {
                        Feed(Son);
                        Menu();
                    }
                    else if (_ == 4)
                    {
                        Feed(Daughter);
                        Menu();
                    }
                    else if (_ == 5)
                    {
                        Menu();
                    }
                }
                else if (IChoose == 2) //Drink
                {
                    Console.WriteLine("Choose who should drink: ");
                    Console.WriteLine("1) Peter.");
                    Console.WriteLine("2) Margo.");
                    Console.WriteLine("3) Josh.");
                    Console.WriteLine("4) Sally.");
                    Console.WriteLine("5) Back to menu.");
                    Console.Write("----> ");


                    int _ = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    if (_ < 1 || _ > 5)
                    {
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine("You messed up something. Try again");
                            Console.Write("----> ");
                            _ = Convert.ToInt32(Console.ReadLine());
                        }
                        while (_ < 1 || _ > 5);
                    }
                    if (_ == 1)
                    {
                        Drink(Dad);
                        Menu();
                    }
                    else if (_ == 2)
                    {
                        Drink(Mom);
                        Menu();
                    }
                    else if (_ == 3)
                    {
                        Drink(Son);
                        Menu();
                    }
                    else if (_ == 4)
                    {
                        Drink(Daughter);
                        Menu();
                    }
                    else if (_ == 5)
                    {
                        Menu();
                    }
                }


                else if (IChoose == 3)  //Healing
                {
                    Console.WriteLine();
                    Console.WriteLine("Choose who should use the medkit: ");
                    Console.WriteLine("1) Peter.");
                    Console.WriteLine("2) Margo.");
                    Console.WriteLine("3) Josh.");
                    Console.WriteLine("4) Sally.");
                    Console.WriteLine("5) Back to menu.");
                    Console.Write("----> ");


                    int _ = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    if (_ < 1 || _ > 5)
                    {
                        do
                        {
                            Console.WriteLine();
                            Console.WriteLine("You messed up something. Try again");
                            Console.Write("----> ");
                            _ = Convert.ToInt32(Console.ReadLine());
                        }
                        while (_ < 1 || _ > 5);
                    }
                    if (_ == 1)
                    {
                        Heal(Dad);
                        Menu();
                    }
                    else if (_ == 2)
                    {
                        Heal(Mom);
                        Menu();
                    }
                    else if (_ == 3)
                    {
                        Heal(Son);
                        Menu();
                    }
                    else if (_ == 4)
                    {
                        Heal(Daughter);
                        Menu();
                    }
                    else if (_ == 5)
                    {
                        Menu();
                    }
                }



                else if (IChoose == 4) //Back to menu
                {
                    Menu();
                    Console.WriteLine();
                    Thread.Sleep(1000);
                }
            }


                if (choose == 3)
                {
                    ShowInventory();
                }

                if (choose == 4)
                {
                    if (Dad.wasteland == false && Mom.wasteland == false && Son.wasteland == false && Daughter.wasteland == false)
                    {
                       sendToWasteland();
                      dayToReturn = NowDay;
                    }
                    else 
                    {
                       Console.ForegroundColor = ConsoleColor.Red;
                       Console.WriteLine();
                       Console.WriteLine("Unfortunately, you cannot send more than one character to the wasteland at a time. Wait for the return.");
                       Console.ResetColor();
                       Console.WriteLine();
                       Menu();
                    }
                               
                }

                if (choose == 5)
                {
                    //Empty
                }
            }

            public Items()
            {

            }
        }
    } 