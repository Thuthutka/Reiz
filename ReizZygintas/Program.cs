using System;
using System.Linq;
using System.Collections.Generic;
namespace ReizZygintas
{
    class Program
    {
        public static Branch root = new Branch("Root");
        static void Main(string[] args)
        {
            //1

            /*
            double hourAngle,minuteAngle,angle;

            Console.WriteLine("Enter hours:");
            int.TryParse(Console.ReadLine(),out var hours);
            Console.WriteLine("Enter minutes:");
            int.TryParse(Console.ReadLine(), out var minutes);

            hourAngle = (hours * 30) + (minutes / 2.0);
            minuteAngle = minutes * 6;
            angle = Math.Abs(hourAngle - minuteAngle);

            if(angle > 180)
            {
                angle = 360 - angle;
            }

            Console.WriteLine($"Angle between hours and minutes is: {angle}");
            */

            //2-3
            Branch branch1 = new Branch("branch1");
            Branch branch11 = new Branch("branch11");
            Branch branch111 = new Branch("branch111");
            Branch branch2 = new Branch("branch2");
            Branch branch21 = new Branch("branch21");
            Branch branch211 = new Branch("branch211");
            Branch branch22 = new Branch("branch22");
            Branch branch221 = new Branch("branch221");
            Branch branch2211 = new Branch("branch2211");
            Branch branch222 = new Branch("branch222");
            Branch branch23 = new Branch("branch23");

            root.branches.Add(branch1);
            root.branches.Add(branch2);
            branch1.branches.Add(branch11);
            branch11.branches.Add(branch111);
            branch2.branches.Add(branch21);
            branch21.branches.Add(branch211);
            branch2.branches.Add(branch22);
            branch22.branches.Add(branch221);
            branch221.branches.Add(branch2211);
            branch22.branches.Add(branch222);
            branch2.branches.Add(branch23);

            Console.WriteLine(root.Depth);
        }
    }
}
