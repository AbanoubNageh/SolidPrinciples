using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPoc
{
    public interface IRatingValidation
    {
        void ValidateMakeRequired(string make);
        void ValidateBondAmountAndValuationRequired(decimal bondAmount, decimal valuation);
        void ValidateInsufficientBondAmount(decimal bondAmount, decimal valuation);
        void LifePolicyMustIncludeDOB(DateTime dateOfBirth);
        void CentenariansNotEligibleForCoverage(DateTime dateOfBirth);
        void LifePolicyMustIncludeAmount(decimal amount);
    }
}
