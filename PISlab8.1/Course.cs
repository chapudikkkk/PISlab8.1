using PISlab8._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PISlab8._1
{
    interface ICourseModel
    {
        double CalculateEffectiveness(double rating, double hours);
    }
}
class Course : ICourseModel
{
    double rating;
    double hours;

    public Course(double r, double h)
    {
        rating = r;
        hours = h;
    }

    public Course()
    {
        rating = 90;
        hours = 30;
    }

    public double CalculateEffectiveness(double rating, double hours)
    {
        return rating / hours;
    }
}
