using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-tutorial-for-beginners/learn/lecture/2910726#content
/*
1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

If no one likes your post, it doesn't display anything.
If only one person likes your post, it displays: [Friend's Name] likes your post.
If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.

*/
namespace ArraysAndListsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            var names = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter name: ");
                string enteredName = Console.ReadLine();
                names.Add(enteredName);
                if (enteredName == "")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            //i++;
            //Console.WriteLine(names.Count);
            int amountOfNames = names.Count - 1;

            if (amountOfNames == 0)
            {
                Console.WriteLine(" - ");
            }
            else if (amountOfNames == 1)
            {
                Console.WriteLine($"{names[0]} liked your post!");
            }
            else if (amountOfNames == 2)
            {
                Console.WriteLine($"{names[0]} and {names[1]} liked your post!");
            }
            else if (amountOfNames >= 3)
            {
                Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 3} liked your post!");
                //Console.WriteLine(names[0], names[1], $"and {names.Count-3}");
            }



            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}
        }

    }
}