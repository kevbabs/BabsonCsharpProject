using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace switchStatement
{
    public class Triangle
    {
        // triangle variable
        public int triHeigh;
        public int triBase;
        public int areaAnswer;

        // Area method
        public void TriangleArea()
        {
            Console.WriteLine();
            areaAnswer = triHeigh*triBase;
            Console.WriteLine("The area of this triangle is {0}", areaAnswer);

        }

        public int Pentangon()
        {
            Console.WriteLine();
            areaAnswer = (triBase * triHeigh) * 1/2;
            Console.WriteLine("The area of this pentangon is {0}", areaAnswer);
            return areaAnswer;
        }

        // This my third method that take arguement
        public void Octagon(int paramOne, int paramTwo)
        {
            Console.WriteLine();
            triHeigh = paramOne;
            triBase = paramTwo;
            areaAnswer = (paramOne + paramTwo)*2;
            Console.WriteLine("The area of this Octagon is {0}", areaAnswer);
        }
    }
}