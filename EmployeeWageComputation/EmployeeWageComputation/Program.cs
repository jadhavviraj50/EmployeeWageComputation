namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            UC2 wage = new UC2();
            wage.salary();
            UC3 part = new UC3();
            part.partTime();
            UC4 swich = new UC4();
            swich.switchCase();
            UC5 mont = new UC5();
            mont.month();

        }
    }
}