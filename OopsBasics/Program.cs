using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OopsBasics
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        static void Program1()
        {
            //no of test cases
            int t = int.Parse(Console.ReadLine());

            for (int test = 0; test < t; test++)
            {
                // No of Drones
                int n = int.Parse(Console.ReadLine());

                // Drones current Orientation 
                var dronesCurrentOrientation = Console.ReadLine();

                if (dronesCurrentOrientation.Length <= n)
                {
                    Console.WriteLine("Please enter only " + n + " drones");
                }

                // No of Operations
                int o = int.Parse(Console.ReadLine());

                ArrayList arrayList = new ArrayList();
                for (int i = 0; i < o; i++)
                {
                    arrayList.Add(Console.ReadLine());
                }

                foreach (var item in arrayList)
                {
                    for (int i = int.Parse(item.ToString().Split(" ")[0]); i <= int.Parse(item.ToString().Split(" ")[1]); i++)
                    {
                        string currentDroneUpdatedOrientation = dronesCurrentOrientation.Substring(i, 1);

                        if (currentDroneUpdatedOrientation == "<")
                            currentDroneUpdatedOrientation = ">";
                        else
                            currentDroneUpdatedOrientation = "<";

                        dronesCurrentOrientation = dronesCurrentOrientation.Substring(0, i) + currentDroneUpdatedOrientation + dronesCurrentOrientation.Substring(i + 1);
                    }
                }

                Console.WriteLine(dronesCurrentOrientation);
            }
        }

        static void Program2()
        {
            //no of test cases
            int t = int.Parse(Console.ReadLine());

            for (int test = 0; test < t; test++)
            {
                //combined number of top lines and sale lines
                int c = int.Parse(Console.ReadLine());
            }
        }
    }
}
