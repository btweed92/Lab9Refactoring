using System;
using System.Collections.Generic;

namespace Lab9Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, which student are you inquiring about? Please enter a number 1-9 to learn more about each student, or 0 to add a student. ");
            bool go = true;
            
                List<string> student = new List<string>
                {
                "Aaron Aaronson", "Beth Bethonson", "Chad Chadwick", "Donna Donaldson", "Eric Ericson"
                };
                List<string> homeTown = new List<string>
                {
                    "Detroit, Mi", "Memphis, Mi", "Monroe, Mi", "St Joe, Mi", "Traverse City, Mi "
                };
                List<string> favFood = new List<string>
                {
                    "Pizza", "Tacos", "Burgers", "Coney", "Thai"
                };
                List<string> animal = new List<string>
                {
                    "Dog", "Cat", "Snake", "Hedgehog", "Elephant"
                };

                
            while (go)
            {
                int studentCount = 1;
                foreach (string listStudents in student)
                {

                    Console.WriteLine($"{studentCount}. { listStudents}");
                    studentCount++;
                }

                try
                {
                    int input = UserInput();

                    if ((input >= 1) && (input <= student.Count))
                    {
                        DisplayInfo(input - 1, student);
                        Console.WriteLine("Would you like to know about this students favorite: ");
                        Console.WriteLine("1. Food");
                        Console.WriteLine("2. Hometown");
                        Console.WriteLine("3. Animal");
                try
                {
                    int input2 = UserInput2();
                    if (input2 == 1)
                    {
                        DisplayFood(input - 1, favFood);
                    }
                    else if (input2 == 2)
                    {
                        DisplayHome(input - 1, homeTown);
                    }
                    else if (input2 == 3)
                    {
                        DisplayAnimal(input - 1, animal);
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number, 1-3.");
                }
                    }
                    else if (input == 0)
                    {
                        Console.WriteLine("Please enter new student info");
                        string studentName = UserInput3("Student name (First Last): ");
                        string studentHome = UserInput3("Student hometown (City, St): ");
                        string studentFood = UserInput3("Student favorite food: ");
                        string studentAnimal = UserInput3("Student favorite animal: ");

                        student = AddToList(studentName, student);
                        homeTown = AddToList(studentHome, homeTown);
                        favFood = AddToList(studentFood, favFood);
                        animal = AddToList(studentAnimal, animal);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number, 1-6.");
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number, 1-6.");
                }
                Console.WriteLine("Would you like to continue? (y/n)");
                string noGo = Console.ReadLine();
                if(noGo == "n")
                {
                    go = false;
                    Console.WriteLine("Thank you, have a good day");
                }
            } 
        }
        public static int UserInput()
        {
            return int.Parse(Console.ReadLine());
        }
        public static int UserInput2()
        {
            return int.Parse(Console.ReadLine());
        }
        public static string UserInput3(string propmt)
        {
            Console.WriteLine(propmt);
            return Console.ReadLine();
        }
        public static List<string> AddToList(string input, List<string> list) //use this on assessment
        {
            list.Add(input);
            return list;

        }
        public static void DisplayInfo(int input, List<string> students)
        {
            Console.WriteLine("The student you picked: ");
            Console.WriteLine($"{students[input]}");
        }
        public static void DisplayFood(int input, List<string> favFood)
        {
            Console.WriteLine("The student you picked eats: ");
            Console.WriteLine($"{favFood[input]}");
        }
        public static void DisplayHome(int input, List<string> homeTown)
        {
            Console.WriteLine("The student you picked is from: ");
            Console.WriteLine($"{homeTown[input]}");
        }
        public static void DisplayAnimal(int input, List<string> animal)
        {
            Console.WriteLine("The student you picked loves: ");
            Console.WriteLine($"{animal[input]}");
        }
    }
}
