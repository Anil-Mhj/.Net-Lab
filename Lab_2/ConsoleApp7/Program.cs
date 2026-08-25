// Create a program that uses the Stack<T> collection to simulate the Undo feature of a text editor.
// Allow the user to enter multiple actions, undo the most recent action, display the current top
// action, and show all remaining actions in the stack.

using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            Stack<string> actions = new Stack<string>();
            
            while (true)
            {
                Console.WriteLine("\n===== Text Editor Undo Simulation =====");
                Console.WriteLine("1. Add Action");
                Console.WriteLine("2. Undo Last Action");
                Console.WriteLine("3. Show Current Action");
                Console.WriteLine("4. Show All Actions");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                
                int choice = Convert.ToInt32(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter action: ");
                        string action = Console.ReadLine();
                        actions.Push(action);
                        Console.WriteLine("Action added.");
                        break;
                        
                    case 2:
                        if (actions.Count > 0)
                        {
                            string undone = actions.Pop();
                            Console.WriteLine($"Undid: {undone}");
                        }
                        else
                        {
                            Console.WriteLine("No actions to undo.");
                        }
                        break;
                        
                    case 3:
                        if (actions.Count > 0)
                        {
                            Console.WriteLine($"Current Action: {actions.Peek()}");
                        }
                        else
                        {
                            Console.WriteLine("No actions available.");
                        }
                        break;
                        
                    case 4:
                        if (actions.Count > 0)
                        {
                            Console.WriteLine("All Actions (from newest to oldest):");
                            foreach (string act in actions)
                            {
                                Console.WriteLine($"- {act}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No actions available.");
                        }
                        break;
                        
                    case 5:
                        return;
                        
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
