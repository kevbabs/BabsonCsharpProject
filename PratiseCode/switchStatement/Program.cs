using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using switchStatement.FamilyTree;
using switchStatement.Parent;

namespace switchStatement
{
    public class Program 
    {
        static void Main(string[] args)
        {
            GarndParent grandParent = new GarndParent();
            grandParent.CallChiefTitle();

            PrivateMeth privateMeth = new PrivateMeth();
            privateMeth.ChildrenEnroll(12, "Ola");
            privateMeth.ChildrenDetails();

            Console.WriteLine();
            Console.WriteLine("Change title to Otunba");
            grandParent.ChiefTitle = "Otunba";
            grandParent.CallChiefTitle();

            Console.WriteLine();
            DadMum dadmum = new DadMum();
            dadmum.CallParent();
            



            Console.ReadKey();
        }
        
     }
}


