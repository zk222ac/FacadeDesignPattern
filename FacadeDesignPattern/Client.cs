using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            // Facade 
            CollegeLoan grantingLoan = new CollegeLoan();

            Student student = new Student("john" , 1000);

            // Conditions for loan
            bool eligible = grantingLoan.IsEligible(student, 8000);

            Console.WriteLine( "\n" + student.Name + " has been" + (eligible  ? " Approved" : " Rejected"));

            Console.ReadKey();

        }
    }
}
