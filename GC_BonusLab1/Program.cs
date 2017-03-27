using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_BonusLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopRuns = true;
            Console.WriteLine("Welcome to the Letter Grade Converter!");
            while (loopRuns)
            {                
                Console.WriteLine("Enter a numerical grade: ");
                string inputNumber = Console.ReadLine();
                int numberGrade = Convert.ToInt32(inputNumber);
                if (numberGrade > 87)
                {
                    if (numberGrade > 98)
                    {
                        Console.WriteLine("Letter Grade: A+");
                    }
                    else if (numberGrade > 90)
                    {
                        Console.WriteLine("Letter Grade: A");
                    }
                    else
                    {
                        Console.WriteLine("Letter Grade: A-");
                    }
                }
                else if (numberGrade > 79)
                {
                    if (numberGrade > 85)
                    {
                        Console.WriteLine("Letter Grade: B+");
                    }
                    else if (numberGrade > 82)
                    {
                        Console.WriteLine("Letter Grade: B");
                    }
                    else
                    {
                        Console.WriteLine("Letter Grade: B-");
                    }
                }
                else if (numberGrade > 66)
                {
                    if (numberGrade > 76)
                    {
                        Console.WriteLine("Letter Grade: C+");
                    }
                    else if (numberGrade > 71)
                    {
                        Console.WriteLine("Letter Grade: C");
                    }
                    else
                    {
                        Console.WriteLine("Letter Grade: C-");
                    }
                }
                else if (numberGrade > 59)
                {
                    if (numberGrade > 64)
                    {
                        Console.WriteLine("Letter Grade: D+");
                    }
                    else if (numberGrade > 62)
                    {
                        Console.WriteLine("Letter Grade: D");
                    }
                    else
                    {
                        Console.WriteLine("Letter Grade: D-");
                    }
                }
                else
                {
                    Console.WriteLine("Letter Grade: F");
                }
                Console.Write("Continue? (y/n): ");
                string cont = Console.ReadLine();
                if (cont.ToLower() != "y")
                {
                    Console.WriteLine("Goodbye!");
                    loopRuns = false;
                    Console.ReadLine();
                }              
            }
        }
    }
}
