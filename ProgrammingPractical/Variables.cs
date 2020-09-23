using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPractical
{
    class Variables
    {
        char option = 'A';
        bool consent = true;
        enum Days {monday, tuesday, wednesday, thursday,friday, saturday, sunday};

        byte total = 4;
        short figure = 74;
        int amount = 80;
        long value = 895;
        float combined =10.09f;
        double aggregate = 76.8;
        decimal overall = 74.8766m;


        //    list
        //    Class
        //    Interface 
        //    Delegates


        static void Main(string[] args)
        {

            //    array
            int[] arraytype=new int[3];
            arraytype[2] = 7;

            int[,] arraydimension = new int[3, 2] { {3,4},{3,8 },{ 6,6} };
           
            

            //object declaration 
            Variables useChar = new Variables();
            Console.WriteLine("option selected is" +" "+ useChar.option);
            Console.WriteLine("Above declaration is " + " " + useChar.consent);

            Variables usetype = new Variables();
            Console.WriteLine("Total amount is" + " " + usetype.total);
            Console.WriteLine("Total amount is" + " " + usetype.figure);
            Console.WriteLine("Total amount is" + " " + usetype.value);
            Console.WriteLine("Total amount is" + " " + usetype.amount);
            Console.WriteLine("Total amount is" + " " + usetype.combined);
            Console.WriteLine("Total amount is" + " " + usetype.aggregate);
            Console.WriteLine("Total amount is" + " " + usetype.overall);
            
            Console.ReadKey();



        }
    }
}
