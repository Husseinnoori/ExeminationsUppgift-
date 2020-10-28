using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ExeminationsUppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in ditt tolvsiffriga personnummer:");
            // reads a string 
            string personnummer = "199607053817"; 
            string month = personnummer.Substring(5, 4);
            string day = personnummer.Substring(6, 8);
            string birthNumber = personnummer.Substring(8,3);
            

            personnummer = Console.ReadLine();
            // applies for the first 4 numbers in the "personnummer" 1996
            string year = personnummer.Substring(0, 3); 
           


            if (personnummer.Length != 12)
            {
                Console.WriteLine("personnummer" + personnummer+"not correct");
            } 
            else if (int.Parse(year)<1753||int.Parse(year)>2020)
            {
                Console.WriteLine("årtalet är inkorrekt");

            } 
            else if ()
            
            
            
                

            

            

            
            
            
            

        }
    }
}
