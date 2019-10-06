using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPoc
{
    public class RatingValidation: IRatingValidation
    {
        Logger logger { get; set; } = new Logger();
        public void ValidateMakeRequired(string make)
        {
            if (String.IsNullOrEmpty(make))
            {
                logger.Log("Auto policy must specify Make");
                return;
            }
        }

        public void ValidateBondAmountAndValuationRequired(decimal bondAmount, decimal valuation)
        {
            if (bondAmount == 0 || valuation == 0)
            {
                logger.Log("Land policy must specify Bond Amount and Valuation.");
                return;
            }
        }

        public void ValidateInsufficientBondAmount(decimal bondAmount, decimal valuation)
        {
            if (bondAmount < 0.8m * valuation)
            {
                logger.Log("Insufficient bond amount.");
                return;
            }
        }

        public void LifePolicyMustIncludeDOB(DateTime dateOfBirth)
        {
            if (dateOfBirth == DateTime.MinValue)
            {
                logger.Log("Life policy must include Date of Birth.");
                return;
            }
        }

        public void CentenariansNotEligibleForCoverage(DateTime dateOfBirth)
        {
            if (dateOfBirth < DateTime.Today.AddYears(-100))
            {
                logger.Log("Centenarians are not eligible for coverage.");
                return;
            }
        }

        public void LifePolicyMustIncludeAmount(decimal amount)
        {
            if (amount == 0)
            {
                logger.Log("Life policy must include an Amount.");
                return;
            }
        }
       
    }
}
