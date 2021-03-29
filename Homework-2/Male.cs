using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public enum MaleAverageHeight //centimeters
    {
        Short = 170,
        Average = 180,
        Tall = 190
    }

    public enum MaleAverageSpeed //seconds
    {
        Slow = 8,
        Average = 7,
        Fast = 6
    }

    public class Male
    {
        private string Gender;

        public string GenderSet
        {
            get { return Gender; }
            set { Gender = "male"; }
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

        public Male()
        {
            this.Gender = "male";
        }

        public Male(string name, int age, int height)
        {
            this.Name = name;
            this.Age = age;
            this.Height = height;
        }

        public MaleAverageHeight MeassureHeight(int height)
        {
            if (height >= 160 && height <= 170)
            {
                return MaleAverageHeight.Average;
            }
            else if (height >= 190)
            {
                return MaleAverageHeight.Tall;
            }
            else
            {
                return MaleAverageHeight.Short;
            }
        }

        public int Run()
        {
            int runTime = int.Parse(Console.ReadLine());
            return runTime;
        }

        public MaleAverageSpeed MeassureSpeed(int runTime)
        {
            if (runTime == 8)
            {
                return MaleAverageSpeed.Average;
            }
            else if (runTime >= 9)
            {
                return MaleAverageSpeed.Slow;
            }
            else
            {
                return MaleAverageSpeed.Fast;
            }
        }
    }
}