using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._02
{
    public class Student
    {
        public string name;
        public int rost = 165;
        static double ves = 65;
        public string GetName()
        {
            
            return name;
        }
        public double GetEat()
        {
            return ves;
        }
        public double SetEat(double eda,double weight)
        {
            weight += eda - 1.6;
            return weight;
        } 
    }
}
