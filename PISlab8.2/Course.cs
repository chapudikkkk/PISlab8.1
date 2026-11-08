using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PISlab8._2
{
    class Course
    {
        double rating;
        double hours;

        public Course()
        {
            rating = 90;
            hours = 30;
        }

        public Course(double r, double h)
        {
            rating = r;
            hours = h;
        }

        public double Rating { get; set; }
        public double Hours { get; set; }

        public double Effectiveness
        {
            get { return rating / hours; }
        }
    }
}
