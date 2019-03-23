using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    // The Facade Class
   public class CollegeLoan
    {
        private Bank _bank = new Bank();
        private Credit _credit = new Credit();
        private Loan _loan = new Loan();

        public bool IsEligible(Student student , int loanAmount)
        {
            Console.WriteLine($"{student.Name} applies for {loanAmount} loan");
            var eligible = true;

                // verify credit worthiness of applicant 
            if (!_bank.HasSufficientSavings(student , loanAmount))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(student))
            {
                eligible = false;
            }
            else if (!_loan.HasNoBadLoan(student))
            {
                eligible = false;
            }

            return eligible;
        }

    }
}
