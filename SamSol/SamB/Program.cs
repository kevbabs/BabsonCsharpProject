using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamB
{
    public class Program
    {
        static void Main(string[] args)
        {
            Subtract subtractPositive = new Subtract();
            subtractPositive.subNumberone = 10;
            subtractPositive.subNumbertwo = 6;
            subtractPositive.subtractNumber();
            Console.WriteLine();
<<<<<<< HEAD
            Console.WriteLine();
=======
>>>>>>> ac77df22e9b0747e4cb5cef12899f6d866e511ea

            Subtract subtractNegative = new Subtract();
            subtractNegative.subNumberone = 12;
            subtractNegative.subNumbertwo = 15;
            subtractNegative.subtractNumber();
            Console.WriteLine();
      
            //calling addition method
            Additional addUpnumber = new Additional();
            addUpnumber.addNumberone = 120;
            addUpnumber.addNumbertwo = 56;
            addUpnumber.addingNumber();
            Console.WriteLine();

            //calling smartAdd method
            Additional addCal = new Additional();
            addCal.SmartAdd(45, 9);


        Console.ReadKey();

          }

}
}
