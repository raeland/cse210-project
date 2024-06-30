using System;
using System.Reflection;
namespace EternalQuest
{
    class Program
    {
        static List<Goals> _goals = new List<Goals>();
        static int totalScore = 0;
        static void Main(string[] args)
        {
            //LoadGoals();
            ShowMenu();
        }
        static void ShowMenu()
        {
            bool program = false;

            while (!program)
            {
                Console.WriteLine("\nEternal Quest Goal Program");
                Console.WriteLine("\nPlease select ONE of the options below:");
                Console.WriteLine("1. Set A Goal");
                Console.WriteLine("2. Record Goal Event");
                Console.WriteLine("3. Show Your Goals");
                Console.WriteLine("4. Show Your Earned Points");
                Console.WriteLine("5. Save Your Accomplishments");
                Console.WriteLine("6. Quit");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        NewGoal();
                        break;
                    case "2":
                        RecordGoalEvent();
                        break;
                    case "3":
                        ShowGoal();
                        break;
                    case "4":
                        ShowPoints();
                        break;
                    case "5":
                        SaveGoals();
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Bye Felicia!");
                        return;
                    default:
                        Console.WriteLine("Try again");
                        return;
                }
                static void NewGoal()
                {
                    Console.WriteLine("Choose Goal Type:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("Choose an option: ");
                    string choice = Console.ReadLine();

                    Console.Write("Enter goal name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter points: ");
                    int points = int.Parse(Console.ReadLine());

                    // switch (choice)
                    // {
                    //     case "1":
                    //         _goals.Add(new SimpleG(name, points));
                    //         break;
                    //     case "2":
                    //         _goals.Add(new EternalG(name, points));
                    //         break;
                    //     case "3":
                    //         Console.Write("Enter target count: ");
                    //         int targetCount = int.Parse(Console.ReadLine());
                    //         Console.Write("Enter bonus points: ");
                    //         int bonusPoints = int.Parse(Console.ReadLine());
                    //         _goals.Add(new CheckListG(name, points, targetCount, bonusPoints));
                    //         break;
                    //     default:
                    //         Console.WriteLine("Invalid - Goal not created.");
                    //         break;
                    // }
                }

                static void RecordGoalEvent()
                {
                    Console.WriteLine("Choose a goal to record an event:");
                    for (int i = 0; i < _goals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {_goals[i]._name}");
                    }

                    int choice = int.Parse(Console.ReadLine()) - 1;
                    if (choice >= 0 && choice < _goals.Count)
                    {
                        _goals[choice].RecordEvent();
                        totalScore += _goals[choice]._points;

                        if (_goals[choice] is CheckListG checklistG && checklistG.IsComplete())
                        {
                            totalScore += checklistG._bonusPoints;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid - Event not recorded.");
                    }
                }

                static void ShowGoal()
                {
                    Console.WriteLine("\nGoals:");
                    foreach (Goals goal in _goals)
                    {
                        Console.WriteLine(goal.GetStatus());
                    }
                }

                static void ShowPoints()
                {
                    Console.WriteLine($"\nTotal Score: {totalScore}");
                }

                static void SaveGoals()
                {
                    using (StreamWriter writer = new StreamWriter("goals.txt"))
                    {
                        writer.WriteLine(totalScore);
                        foreach (Goals goal in _goals)
                        {
                            string goalType = goal.GetType().Name;
                            string goalStatus = goal.GetStatus();
                            
                            if (goal is CheckListG checkListG)
                            {
                            writer.WriteLine($"{goal.GetType().Name}|{goal._name}|{goal._points}|{goal.GetStatus()}");
                            }
                            else
                            {
                                writer.WriteLine($"{goalType}|{goal._name}|{goal._points}|{goalStatus}");
                            }
                        }
                    }
                }

                // static string LoadGoals()
                // {
                //     if (File.Exists(filename))
                //     {
                //         using (StreamReader reader = new StreamReader(filename))
                //         {
                //             totalScore = int.Parse(reader.ReadLine());
                //             string line;
                //             while ((line = reader.ReadLine()) != null)
                //             {
                //                 string[] parts = line.Split(" | ");
                //                 string type = parts[0];
                //                 string name = parts[1];
                //                 int points = int.Parse(parts[2]);

                //                 if (type == nameof(SimpleG))
                //                 {
                //                     _goals.Add(new SimpleG(name, points));
                //                 }
                //                 else if (type == nameof(EternalG))
                //                 {
                //                     _goals.Add(new EternalG(name, points));
                //                 }
                //                 else if (type == nameof(CheckListG))
                //                 {
                //                     string[] statusParts = parts[3].Split('/');
                //                     int currentCount = int.Parse(statusParts[0].Trim('[', ']'));
                //                     int targetCount = int.Parse(statusParts[1].Split(' ')[0]);
                //                     int bonusPoints = int.Parse(parts[4]);
                //                     string _goals = new CheckListG(name, points, targetCount, bonusPoints)
                //                     {
                //                         CurrentCount = currentCount
                //                     };
                //                     return _goals.Add(LoadGoals);
                                }
                            }
                        }
                    }

//                 }
//             }
//         }
//     }
// }