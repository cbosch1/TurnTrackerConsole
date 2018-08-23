using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnTrackerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO CONSOLE D&D COUNTER");
            Console.WriteLine("Add, Remove, NextTurn, Help, End");
            Console.WriteLine("Type 'Help' to see the commands again");

            List<ICounter> displayCounters = new List<ICounter>(); //Running list of counter objects
            bool close = false; //Controls program termination

            do
            {
                switch (Console.ReadLine()?.ToLower())
                {
                    //Am thinking of moving the "add" logic into the CounterFactory... Would that help or hinder readability?
                    case "add":  //Creates a counter object based on user input, adds object to the list.
                        bool fail = true;
                        bool type = true;
                        string name;
                        ICounter currentCounter = null;

                        do
                        {
                            Console.WriteLine("Intial counter type?");
                            var counterTypeString = Console.ReadLine()?.ToLower();
                            switch (counterTypeString)
                            {
                                case "time":
                                    type = false;
                                    fail = false;
                                    break;

                                case "turn":
                                    type = true;
                                    fail = false;
                                    break;

                                default:
                                    Console.WriteLine("Please type 'Time' or 'Turn'");
                                    break;
                            }
                        } while (fail);

                        do
                        {
                            fail = true;
                            Console.WriteLine("Initial counter name?");
                            name = Console.ReadLine();

                            if (name != null)
                            {
                                fail = false;
                            }
                            else
                            {
                                Console.WriteLine("Please type in a name");
                            }

                        } while (fail);

                        do
                        {
                            fail = true;
                            Console.WriteLine("Initial count for " + name + "?");
                            if (Int32.TryParse(Console.ReadLine(), out var count))
                            {
                                if (count > 0)
                                {
                                    currentCounter = CounterFactory.Counter(type, count, name);
                                    fail = false;
                                }
                                else
                                {
                                    Console.WriteLine("Please start with at least a value of 1");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please type in a number");
                            }

                        } while (fail);

                        if (currentCounter != null)
                        {
                            Console.WriteLine("Created counter");
                            displayCounters.Add(currentCounter);
                        }
                        else
                        {
                            Console.WriteLine("Error in creating counter, Please try again");
                        }
                        Display.Counters(displayCounters); //Displays current list of counters
                        break;

                    case "remove": //Removes a counter object from the list based on User Input.
                        fail = true;
                        name = "";
                        int displayCount = displayCounters.Count; 

                        Console.WriteLine("Which counter would you like to remove?");
                        name = Console.ReadLine();
                        
                        foreach (ICounter counter in displayCounters)
                        {
                            if (counter.Name != name)
                            {
                                continue;
                            }

                            do
                            {
                                Console.WriteLine("Would you like to remove " + counter.Name);
                                Console.WriteLine("Yes or No?");
                                var response = Console.ReadLine()?.ToLower();
                                switch (response)
                                {
                                    case "yes":
                                        displayCounters.Remove(counter);
                                        Console.WriteLine("Counter removed successfully");
                                        fail = false;
                                        break;

                                    case "no":
                                        Console.WriteLine("Counter not removed");
                                        fail = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please type yes or no");
                                        break;
                                }
                            } while (fail);

                            break;
                        }

                        //This is the best way I could think of to determine if a counter was removed or not.
                        if (displayCounters.Count == displayCount) 
                        {
                            Console.WriteLine("No matching counters found");
                        }

                        Display.Counters(displayCounters);
                        break;

                    case "nextturn": //Decreases the count values of all counters in the list.
                        CounterController.NextTurn(displayCounters);
                        Console.WriteLine("Next turn completed");
                        Display.Counters(displayCounters);
                        break;

                    case "help":
                        Console.WriteLine("Commands are: Add, Remove, NextTurn, Help, End");
                        break;

                    case "end": //Ends the program by exiting the main do loop.
                        close = true;
                        break;
                }
            } while (close != true);
        }
    }
}
