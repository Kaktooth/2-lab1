using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    class TTriangle
    {
        protected static int ASide;
        protected static int BSide;
        protected static int CSide;


        public int GetASide()
        {
            return ASide;
        }
        public void SetASide(int value)
        {
            ASide = value;
        }
        public int GetBSide()
        {
            return BSide;
        }
        public void SetBSide(int value)
        {
            BSide = value;
        }
        public int GetCSide()
        {
            return CSide;
        }
        public void SetCSide(int value)
        {
            CSide = value;
        }
        public TTriangle(int ASideValue, int BSideValue, int CSideValue)
        {
            ASide = ASideValue;
            BSide = BSideValue;
            CSide = CSideValue;
            if (ASide + BSide > CSide && ASide + CSide > BSide && BSide + CSide > ASide)
            {
                Console.WriteLine("Трикутник Існує");
                // a + b > c, a + c > b, b + c > a
            }
            else
            {
                Console.WriteLine("Трикутника не існує, тому значення сторін буде скинуто");
                ASide = 0;
                BSide = 0;
                CSide = 0;
            }
        }
        public static int PSum()
        {
            return ASide + BSide + CSide;
        }
        public static double MathArea()
        {
            int s = PSum() / 2;
            return Math.Sqrt(s * (s - ASide) * (s - BSide) * (s - CSide));
        }
    
    }
    public class Program
    {
        static void Main(string[] args)
        {

           
            TTriangle triangle = new TTriangle(23, 10, 23);
            triangle.SetASide(11);
            Console.WriteLine(triangle.GetASide() + " " + triangle.GetCSide() + " " + TTriangle.PSum() + " " + TTriangle.MathArea());
            Console.ReadLine();

        }
    }
}