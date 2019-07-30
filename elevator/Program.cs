using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator firstEl = new Elevator();

            firstEl.mainMenu();

        }
    }


    class Elevator
    {
        //private
        int floors;


        //public
        public Elevator()
        {
            floors = 1;
        }

        public void mainMenu()
        {
            Console.WriteLine("input: Start or Settings ");

            string startOrSet = Console.ReadLine();
            if (startOrSet == "Start")
            {
                this.start();

            }
            if (startOrSet == "Settings")
            {
                Console.WriteLine("\nPlease choose interface configuration:\n \n1. Standard Theme, Standard Size\n2. Standard Theme, Large Size\n3. Blue Theme, Standard Size\n4. Blue Theme, Large Size\n");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        break;
                    case 3:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        break;
                    case 4:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        break;
                }
                this.mainMenu();
            }

        }

        public void start()
        {
            Console.WriteLine("Please enter the floor you want to go.");
            int floor = Convert.ToInt32(Console.ReadLine());

            while (floor != 0)
            {

                this.elSet(floor);
                this.elevate();


                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("Please enter the floor you want to go.");
                floor = Convert.ToInt32(Console.ReadLine());

            }

            this.mainMenu();
        }

        public void elSet(int a)
        {
            floors = a;
        }


        public void elevate()
        {
            for (int i = 1; i <= floors; i++)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(1000);
            }

            Console.Beep();

            switch (floors)
            {
                case 1:
                    Console.WriteLine($"You are at the {floors}st floor");
                    break;
                case 2:
                    Console.WriteLine($"You are at the {floors}nd floor");
                    break;
                case 3:
                    Console.WriteLine($"You are at the {floors}rd floor");
                    break;
                default:
                    Console.WriteLine($"You are at the {floors}th floor");
                    break;
            }


        }


    }
}
