using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPoc
{
    public class DefaultRatingContext: IRatingContext
    {
        public Logger Logger { get; set; } = new Logger();

        public Rater CreateRaterForPolicy(Policy policy, IRatingContext context)
        {
            return new RaterFactory().Create(policy, context);
        }
    }
}
