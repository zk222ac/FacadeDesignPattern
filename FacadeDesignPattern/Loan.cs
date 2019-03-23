using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
   public class Loan
    {
        public bool HasNoBadLoan(Student stu)
        {
            Console.WriteLine("Verify Loan for :" + stu.Name);
            return true;
        }
    }
}
