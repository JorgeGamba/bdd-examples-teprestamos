using BDD.Examples.TePrestamos.Web.Domain.Entities;

namespace BDD.Examples.TePrestamos.Web.Services
{
    public class LoanInterestRateCalculator
    {
        public const double DefaultInterestRate = 20;

        public static double CalculateFor(Customer customer)
        {
            return DefaultInterestRate;
        }
    }
}