using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPoc
{
    public class LifePolicy: Rater
    {
        private readonly RatingEngine _ratingEngine;
        private readonly IRatingValidation _ratingValidation;
        public LifePolicy(IRatingContext context, IRatingValidation ratingValidation)
            : base(context)
        {
            _ratingValidation = ratingValidation;
        }

        public override void Rate(Policy policy)
        {
            _logger.Log("Rating LAND policy...");
            _logger.Log("Validating policy.");
            _ratingValidation.ValidateBondAmountAndValuationRequired(policy.BondAmount, policy.Valuation);
            _ratingValidation.ValidateInsufficientBondAmount(policy.BondAmount, policy.Valuation);
            _ratingEngine.Rating = policy.BondAmount * 0.05m;
        }
    }
}
