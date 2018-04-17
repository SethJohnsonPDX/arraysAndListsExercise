using System;
using System.Collections.Generic;

namespace arraysAndListsExercise
{
    class Program
    {
        static void Main()
        {
            //string welcomeMessage = "Welcome! Please enter a number 1 - 4 to see what it contains!";

            //string[] newStringArray = { "yo!", "sup!", "hiya!", "hello" };

            //Console.WriteLine(welcomeMessage);
            //int input = Convert.ToInt32(Console.ReadLine());
            //int guess = input - 1;
            //Console.WriteLine(newStringArray[guess]);
            //Console.ReadLine();


            //string welcomeMessage = "Welcome! Please enter a number 1 - 4 to see what it contains!";

            //int[] newIntArray = { 5, 250, 1000, 35000 };

            //Console.WriteLine(welcomeMessage);
            //int input = Convert.ToInt32(Console.ReadLine());
            //int guess = input - 1;
            //Console.WriteLine(newIntArray[guess]);
            //Console.ReadLine();

            //string welcomeMessage = "Welcome! Please enter a number 1 - 4 to see what it contains!";
            //Console.WriteLine(welcomeMessage);

            //int[] newIntArray = { 5, 250, 1000, 35000 };
   
            //int input = Convert.ToInt32(Console.ReadLine());
            //int guess = input - 1;
            //bool isGuessed = false;

            //do
            //{
            //    switch (input)
            //    {
            //        case 1:
            //            Console.WriteLine(newIntArray[guess]);
            //            isGuessed = true;
            //            break;
            //        case 2:
            //            Console.WriteLine(newIntArray[guess]);
            //            isGuessed = true;
            //            break;
            //        case 3:
            //            Console.WriteLine(newIntArray[guess]);
            //            isGuessed = true;
            //            break;
            //        case 4:
            //            Console.WriteLine(newIntArray[guess]);
            //            isGuessed = true;
            //            break;
            //        default:
            //            Console.WriteLine("Incorrect. Try again.");
            //            Console.WriteLine("Enter a number 1 - 4");
            //            input = Convert.ToInt32(Console.ReadLine());
            //            guess = input - 1;
            //            break;
            //    }
            //}
            //while (!isGuessed);
            //Console.Read();

            string welcomeMessage = "Welcome! Please enter a number 1 - 4 to see what it contains!";
            Console.WriteLine(welcomeMessage);

            List<string> animalList = new List<string>();
            animalList.Add("dog");
            animalList.Add("cat");
            animalList.Add("rabbit");
            animalList.Add("goat");

            string[] animalArray = animalList.ToArray();
            int input = Convert.ToInt32(Console.ReadLine());
            int guess = input - 1;
            Console.WriteLine(animalArray[guess]);
            Console.ReadLine();

        }
    }
}
