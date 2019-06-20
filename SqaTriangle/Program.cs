using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqaTriangle
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                Console.WriteLine("1. Enter triangle dimensions");
                Console.WriteLine("2. Exit");
                Console.WriteLine("Enter your choice: ");

                String choice = Console.ReadLine();
                int[] values= new int[3];
                if (choice.Equals("1"))
                {
                    for(int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Enter side{0}", i);
                        string value = Console.ReadLine();
                        values[i] = int.Parse(value);
                    }
                    Console.WriteLine(TriangleSolver.Analyze(values[0], values[1], values[2]));
                }
                else if (choice.Equals("2"))
                    break;
                else 
                    continue;
            }
        }
    }
}
