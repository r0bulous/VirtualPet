using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            // User Interface
            VirtualPet cat = new VirtualPet(6, 4, 4);
            Console.WriteLine("Welcome to your VirtualPet! Please type Start to begin.");
            Console.Write("> ");
            string userResponse = Console.ReadLine().ToLower();
            while (userResponse.Equals("start"))
            {
                Console.WriteLine();
                Console.WriteLine("CURRENT PET STATUS");
                Console.WriteLine("Sleep level: {0}", cat.Sleep);
                Console.WriteLine("Hunger level: {0}", cat.Hunger);
                Console.WriteLine("Boredom level: {0}", cat.Boredom);
                Console.WriteLine();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1: Let your pet take a nap.");
                Console.WriteLine("2: Feed your pet.");
                Console.WriteLine("3: Play with your pet.");
                Console.WriteLine("4: Leave your pet at home over a long weekend.");
                Console.WriteLine("5: Don't do anything.");
                Console.WriteLine();

                if (cat.EnoughSleep) // Checks for sleep
                {
                    Console.WriteLine("WARNING! Your pet is getting drowsy. Enter 1 to let your pet take a nap.");
                }
                if (cat.EnoughFood) // Checks for hunger
                {
                    Console.WriteLine("WARNING! Your pet needs to eat! Enter 2 to feed your pet.");
                }
                if (cat.EnoughPlay) // Checks for boredom
                {
                    Console.WriteLine("WARNING! Your pet is getting antsy and needs to play! Enter 3 to play with your pet.");
                }

                Console.Write("Enter 1, 2, 3, 4 or 5: > "); // Menu prompt

                // Menu functionality (Accept userChoice and call appropriate method with selection of 1, 2 or 3)
                int userChoice = int.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        cat.Nap();
                        Console.WriteLine("Your pet took a nap.");
                        break;
                
                    case 2:
                        cat.Eat();
                        Console.WriteLine("You fed your pet.");
                        break;

                    case 3:
                        cat.Play();
                        Console.WriteLine("You played with your pet.");
                        break;

                    case 4:
                        cat.Vacation();
                        Console.WriteLine("You left your pet alone over a long weekend.");
                        break;

                    case 5:
                        break;
                }

                cat.Tick(); // Call Tick() method with every display of menu
  
            }
        }
    }
}
