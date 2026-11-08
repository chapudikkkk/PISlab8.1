using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PISlab8._1
{
    class CoursePresenter
    {
        private readonly ICourseView view;
        private readonly ICourseModel model;

        public CoursePresenter(ICourseView view, ICourseModel model)
        {
            this.view = view;
            this.model = model;
        }

        public void LoadCourse(double rating, double hours)
        {
            double result = model.CalculateEffectiveness(rating, hours);
            view.SetEffectiveness(result);
        }
    }
}
