using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPoc
{
    public class LandPolicy: Rater
    {
        private readonly RatingEngine _ratingEngine;
        private readonly IRatingValidation _ratingValidation;

        public LandPolicy(IRatingContext context, IRatingValidation ratingValidation)
            : base(context)
        {
            _ratingValidation = ratingValidation;
        }

        public override void Rate(Policy policy)
        {
            _logger.Log("Rating LIFE policy...");
            _logger.Log("Validating policy.");
            _ratingValidation.LifePolicyMustIncludeDOB(policy.DateOfBirth);
            _ratingValidation.CentenariansNotEligibleForCoverage(policy.DateOfBirth);
            _ratingValidation.LifePolicyMustIncludeAmount(policy.Amount);
            int age = DateTime.Today.Year - policy.DateOfBirth.Year;
            if (policy.DateOfBirth.Month == DateTime.Today.Month &&
                DateTime.Today.Day < policy.DateOfBirth.Day ||
                DateTime.Today.Month < policy.DateOfBirth.Month)
            {
                age--;
            }
            decimal baseRate = policy.Amount * age / 200;
            if (policy.IsSmoker)
            {
                _ratingEngine.Rating = baseRate * 2;
            }
            _ratingEngine.Rating = baseRate;
        }
    }
}
