using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Corner
    {
        double gradus;
        double min;
        double sec;

        public double Gradus
        {
            get
            { 
            return gradus;
            }
            set
            {
                if (value < 0 || value > 360)
                {
                    Console.WriteLine("Введено неверное значение");
                }
                else
                { 
                gradus = value;
                }
            }

        }

        public double Min
        {
            get
            {
                return min;
            }
            set
            {
                if (value < 0 || value > 60)
                {
                    Console.WriteLine("Введено неверное значение");
                }
                else
                {
                    min = value;
                }
            }
              
              
        }
        public double Sec
        {
            get
            { 
            return sec;
            }
            set
            {
                if (value < 0 || value > 60)
                {
                    Console.WriteLine("Введено неверное значение");
                }
                else
                {
                    sec = value;
                }
            }
        }

        public Corner (double gradus, double min, double sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }

        public double ToRadians()
        {
           return (gradus + (min + sec / 60) / 60)*Math.PI/180;  
        }

    }
}
