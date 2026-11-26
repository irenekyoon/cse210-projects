using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Console.WriteLine("Select a choice from the menu:");

            string choiceString = Console.ReadLine();
            choice = int.Parse(choiceString);
            if (choice == 1)
            {
                BreathingActivity breathe = new BreathingActivity("Breathing", "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathe.GuideBreathing();
            }

            else if (choice == 2)
            {
                ReflectingActivity reflect = new ReflectingActivity("Reflecting", "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power ou have and how you can use it in other aspects of your life.");
                reflect.GuideReflecting();
            }

            else if (choice == 3)
            {
                ListingActivity list = new ListingActivity("Listing", "reflect on the good things in your life by having you list as many things as you can in a certain area.");
                list.GuideListing();
            }

            else
            {
                break;
            }
        }


        // BreathingActivity breathe = new BreathingActivity("Breathing", "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        // breathe.GuideBreathing();

        // ReflectingActivity reflect = new ReflectingActivity("Reflecting", "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power ou have and how you can use it in other aspects of your life.");
        // reflect.GuideReflecting();

        // ListingActivity list = new ListingActivity("Listing", "reflect on the good things in your life by having you list as many things as you can in a certain area.");
        // list.GuideListing();






    }
}