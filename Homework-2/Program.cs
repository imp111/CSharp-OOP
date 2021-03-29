using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Homework2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter gender: ");
            string input = Console.ReadLine().ToLower();

            List<Female> femaleList = new List<Female>();
            List<Male> maleList = new List<Male>();

            while (input != "end")
            {
                if (input == "male")
                {
                    Male objMale = new Male();
                    string[] characteristics = Console.ReadLine().Split(' ').ToArray();

                    string name = characteristics[0];
                    int age = int.Parse(characteristics[1]);
                    int height = int.Parse(characteristics[2]);

                    Male charSet = new Male(name, age, height);

                    maleList.Add(objMale);
                }
                else if (input == "female")
                {
                    Female objFemale = new Female(); //sets gender value of Female class
                    string[] characteristics = Console.ReadLine().Split(' ').ToArray(); //enter characteristics (name, age, height)

                    string name = characteristics[0];
                    int age = int.Parse(characteristics[1]);
                    int height = int.Parse(characteristics[2]);

                    Female charSet = new Female(name, age, height);

                    femaleList.Add(objFemale);
                }
                else
                {
                    Console.WriteLine("wrong gender, try again!");
                }

                Console.Write("Enter gender (end - to end): ");
                input = Console.ReadLine().ToLower();
            }
        }
    }
}