using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PISlab8._2
{
    class MainVM : INotifyPropertyChanged

    {
        private double _number1;
        private double _number2;
        private double _number3;
        public double Number1
        {
            get { return _number1; }
            set
            {
                _number1 = value;
                OnPropertyChanged("Number3");
            }
        }
        public double Number2
        {
            get { return _number2; }
            set
            {
                _number2 = value;
                OnPropertyChanged("Number3");

            }

        }
        public double Number3
        {
            get
            {

                if (Number2 <= 0)

                    return 0;

                var course = new Course(Number1, Number2);

                return course.Effectiveness;

            }

        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
