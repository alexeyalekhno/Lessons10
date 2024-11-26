using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные:");
            double gradusProject = Convert.ToInt32(Console.ReadLine());
            double minProject = Convert.ToInt32(Console.ReadLine());
            double secProject = Convert.ToInt32(Console.ReadLine());
     
            Corner corner = new Corner(gradusProject,minProject,secProject);

            double radians = corner.ToRadians();
            Console.WriteLine(radians);
            Console.ReadKey();
        }
    }
}
