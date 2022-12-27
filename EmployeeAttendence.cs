using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpoyeeWageProblem1
{
    public class EmployeeAttendance
    {
        public static void CheckAttendacce()
        {
            int IS_FULL_TIME = 1;

            Random random = new Random();
            int empCheak = random.Next(2);
            if (empCheak==IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    
    
    }
}
