using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{

    class UC6
    {
        public void emp()
        {
            int empwageperhrs = 20;
            int emphrs = 0;
            int workingdays = 0;

            int maxworkinghrs = 100;
            int maxworkingdays = 20;

            Random CheckempAttandance = new Random();
            int ispresent = CheckempAttandance.Next(0, 4);
            Console.WriteLine(ispresent);

            if (ispresent == 1)
            {
                Console.WriteLine("Employee is present!");
                Console.WriteLine("Employee is Full Time");

            }
            else if (ispresent == 2)
            {
                Console.WriteLine("Employee is Present!");
                Console.WriteLine("Employee is Part Time");

            }

            else
            {
                Console.WriteLine("Employee is Absent!");

            }

            while ((emphrs < maxworkinghrs) && (workingdays < maxworkingdays))
            {

                switch (ispresent)
                {
                    case 1:
                        emphrs = 8;
                        break;
                    case 2:
                        emphrs = 4;
                        break;
                    case 0:
                        emphrs = 0;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;

                }
                workingdays++;
            }
            Console.WriteLine("Total Working Hours : " + emphrs);
            Console.WriteLine("Total Working Days Per Month : " + workingdays);
            int Salary = emphrs * empwageperhrs;
            Console.WriteLine("Employee Salary = " + Salary);

        }
    }
}