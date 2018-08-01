using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceClasses
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
            areaAnswer = triHeigh*triBase;
            Console.WriteLine("The area of this triangle is {0}", areaAnswer);
        }

    }
}
