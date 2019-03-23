using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    // The 'subsystem classA' class
   public class Bank
    {
        public bool HasSufficientSavings(Student stu , int amount)
        {
            
            if (!(stu.Salary >= amount))
            {
                Console.WriteLine("Verify bank for " + stu.Name);
                Console.WriteLine($"{stu.Name} has enough salary : {stu.Salary} to pay back loan on time");
                return true;
            }
            else
            {
                Console.WriteLine("UnVerify bank for " + stu.Name + "Amount: " + stu.Salary + "  is not sufficient for release loan:");
                return false;
            }
        }
    }
}
