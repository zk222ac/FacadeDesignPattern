using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    // The sub system ClassB 
   public class Credit
    {
        public bool HasGoodCredit(Student stu)
        {
            Console.WriteLine("Verify credit for :" + stu.Name);
            return true;
        }
    }
}
