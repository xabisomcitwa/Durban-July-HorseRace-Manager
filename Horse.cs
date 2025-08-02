using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCTXAB001_W1
{
    internal class Horse
    {
        string Name;
        int Age;
        int Height;
        double[] Times = new double[3];

        public Horse(string Name, int Age, int Height, double[] Times)
        {
            this.Name = Name;
            this.Age = Age;
            this.Height = Height;
            this.Times = Times;
        }

        public double AverageTime()
        {
            double sumTime = 0;

            for (int i = 0; i < 3; i++)
            {
                sumTime += Times[i];
            }

            return sumTime/3;
        }

        public string HorseDetails()
        {
            return "Name: " + Name + "\tAge: " + Age + " years" + "\tHeight: " + Height + " hands" + "\tAverage run: " + AverageTime() + " seconds";
        }

    }
}
