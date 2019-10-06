using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPoc
{
    public class AutoPolicy: Rater
    {
        private readonly RatingEngine _ratingEngine;
        private readonly IRatingValidation _ratingValidation;
        public AutoPolicy(IRatingContext context, IRatingValidation ratingValidation)
            : base(context)
        {
            _ratingValidation = ratingValidation;
        }

        public override void Rate(Policy policy)
        {
            _logger.Log("Rating AUTO policy...");
            _logger.Log("Validating policy.");
            _ratingValidation.ValidateMakeRequired(policy.Make);
            if (policy.Make == "BMW")
            {
                if (policy.Deductible < 500)
                {
                    _ratingEngine.Rating = 1000m;
                }
                _ratingEngine.Rating = 900m;
            }
        }
    }
}
