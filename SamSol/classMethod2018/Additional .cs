﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMethod2018
{
    public class Additional
    {
        //the variable needed to perform adding number together
        public int addNumberone;
        public int addNumbertwo;
        public int addAnswer;


        public int addingNumber()
        {
            addAnswer = addNumberone + addNumbertwo;
            Console.WriteLine("The sum of these two numbers is {0}", +addAnswer);
            return addAnswer;

        }

        public int SmartAdd(int argumentOne, int argumentTwo)
        {
            addNumberone = argumentOne;
            addNumbertwo = argumentTwo;
            addAnswer = (argumentOne + argumentTwo)*2;
            Console.WriteLine("The sum of these two numbers is {0} is doube", + addAnswer);
            return addAnswer;
        }
    }
}
