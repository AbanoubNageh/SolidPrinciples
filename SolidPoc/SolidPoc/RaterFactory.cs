using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPoc
{
    public class RaterFactory
    {
        public Rater Create(Policy policy, IRatingContext context)
        {
            try
            {
                return (Rater)Activator.CreateInstance(Type.GetType($"ArdalisRating.{policy.Type}Policy"), context);
            }
            catch
            {

                return new UnknownPolicy(context);
            }
        }
    }
}
