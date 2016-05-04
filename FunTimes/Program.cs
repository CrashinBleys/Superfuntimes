using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunTimes
{
    class Program
    {
        private static bool _shouldContinue = true;

        static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"hello, {name}");

            AskSex();
            StartJourney();

            while (_shouldContinue)
            {
                StartJourney();    
            }

            // the end...
            Console.WriteLine("press any key to exit.");
            Console.ReadKey();
        }

        private static void StartJourney()
        {
            Console.WriteLine("You are on a dirt road going East and West. You have no idea how you got here. Which way do you go?");

            var direction = Console.ReadLine();

            if (direction.ToLower() == "east")
            {
                GoEast();
            }

            else if (direction.ToLower() == "west")
            {
                GoWest();
            }
        }

        private static void GoEast()
        {
            Console.WriteLine("You begin walking East and a bandit jumps out in front");

            Console.WriteLine("Gimme yer shit! The bandit yells.");

            Console.WriteLine("you make a quick decision, attack or run.  which do you do?");

            var action = Console.ReadLine();

            if (action == "attack")
            {
                Console.WriteLine("You lung at the bandit and punch him before he reacts.");

                Console.WriteLine("the bandit crumples to the ground with a bloody nose.");

                Console.WriteLine("you broke my perfect nose! the bandit says through sobs");
            }
            else if (action == "run")
            {
                Console.WriteLine("you turn to run and feel a dagger stab you in the back.");

                Console.WriteLine("nice job dipshit now your dead.");

                _shouldContinue = false;
            }
            
        }

        private static void GoWest()
        {
            Console.WriteLine("You begin walking west and come to a fork in the road.");

            Console.WriteLine("you can go left or right");

            var direction = Console.ReadLine();

            if (direction == "left")
            {
                Console.WriteLine("you start walking down the left path and come to a small village. The place is busy considering how small it seems.");

                Console.WriteLine("You stroll down road smiling and waving at any villager who glances your way. Travelers must be common around here.");

                Console.WriteLine("As you approach the village square you see three men in chainmail armor with halberds in there hands.");

                Console.WriteLine("The soldiers see you and immediatley approach you. HALT the leader says. We have reports of bandits in the area");
            }
            
            else if (direction == "right")
            {
                Console.WriteLine(
                    "You walk for a long time and realize the the road loops back around to where you started.");

                Console.WriteLine(
                    "As you come around a curve in the road you see a bandit hiding behind a tree waiting to ambush.");

                Console.WriteLine(
                    "The bandit is looking opposite direction, you have the drop on him. Do you attack, run, or talk?");

                var action = Console.ReadLine();

                if (action == "attack")
                {
                    Console.WriteLine("You sneak up and grab the bandit from behind and throw him to the ground");

                    Console.WriteLine("The bandit stairs up at you bug eyed and afraid.");

                    Console.WriteLine("Please dont hurt me!  i have a wife and three kids!");

                    Console.WriteLine("You doubt that this man has a family and hes only trying to get away");

                    Console.WriteLine("The way you see it you have two options, kill or spare him. which one do you choose?");
                    {
                        var attack = Console.ReadLine();

                        if (attack == "kill")
                        {
                            Console.WriteLine("before the bandit can do anything you wrap your hands around his throat and squeeze.");

                            Console.WriteLine("The bandit stuggles to pry your hands off but hes weak and pathetic.");

                            Console.WriteLine("You dont stop choking the bandit until he gurgles his last words.");

                            Console.WriteLine("More are coming for you...");
                        }

                        else if (attack == "spare him")
                        {
                            Console.WriteLine("get up scum!  The bandit stands up, brushes the dust and dirt of his clothes.");
                        }
                    }
                }

                else if (action == "run")
                {
                    Console.WriteLine("you turn around and run away like a coward.  some adventurer you are.");

                    Console.WriteLine("you run all the way back to the fork in the road and the bandit is there waiting");

                    Console.WriteLine("this road is one big loop idiot, what did you think would happen running away from a bandit like that");
                }

                else if (action == "talk")
                {
                    Console.WriteLine("whatcha doin hiding behind that tree? you ask the bandit");

                    Console.WriteLine("the bandit twirls around with his dagger pointed at you.");

                    Console.WriteLine("waiting for an idiot like yourself to come by.  The bandit says to you.");
                }
            }
        }

        private static void AskSex()
        {
            Console.WriteLine("Are you male or female?");

            var sex = Console.ReadLine();

            if (sex == "male")
            {
                Console.WriteLine("Welcome to the kingdom my lord.");
            }
            else if (sex == "female")
            {
                Console.WriteLine("How fairs thee my lady?");
            }
            else
            {
                Console.WriteLine("what are you, a coconut?");
            }
        }
    }
}
