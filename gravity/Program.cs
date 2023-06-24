using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gravity
{
    class Gravity
    {
        private int t;
        double g = 9.8;
        public int T
        {
            get { return t; }
            set
            {
                if (value > 0)
                {
                    t = value;
                }
            }
        }
        public Gravity() { }
        public Gravity(int T)
        {
            t = T;
        }
        public double result()
        {
            return 0.5 * g * t;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
            Gravity g = new Gravity(T);
            Console.WriteLine(" fasle = "+g.result());
            Console.ReadKey();
        }
    }
}
