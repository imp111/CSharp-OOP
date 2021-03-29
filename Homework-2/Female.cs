using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public enum FemaleAverageHeight //centimeters
    {
        Short = 150,
        Average = 170,
        Tall = 190
    }

    public enum FemaleAverageSpeed //seconds
    {
        Slow = 9,
        Average = 8,
        Fast = 7
    }

    internal class Female
    {
        private string Gender;

        public string GenderSet
        {
            get { return Gender; }
            set { Gender = "female"; }
        }

        private string Name;

        public string NameSet
        {
            get { return Name; }
            set { Name = value; }
        }

        private int Age;

        public int AgeSet
        {
            get { return Age; }
            set { Age = value; }
        }

        private int Height;

        public int HeightSet
        {
            get { return Height; }
            set { Height = value; }
        }

        public Female()
        {
            this.Gender = "female";
        }

        public Female(string name, int age, int height)
        {
            this.Name = name;
            this.Age = age;
            this.Height = height;
        }

        public FemaleAverageHeight MeassureHeight(int height)
        {
            if (height >= 160 && height <= 170)
            {
                return FemaleAverageHeight.Average;
            }
            else if (height >= 190)
            {
                return FemaleAverageHeight.Tall;
            }
            else
            {
                return FemaleAverageHeight.Short;
            }
        }

        public int Run()
        {
            int runTime = int.Parse(Console.ReadLine());
            return runTime;
        }

        public FemaleAverageSpeed MeassureSpeed(int runTime)
        {
            if (runTime == 8)
            {
                return FemaleAverageSpeed.Average;
            }
            else if (runTime >= 9)
            {
                return FemaleAverageSpeed.Slow;
            }
            else
            {
                return FemaleAverageSpeed.Fast;
            }
        }
    }
}