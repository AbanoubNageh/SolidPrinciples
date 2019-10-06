using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPoc
{
    public class UnknownPolicy:Rater
    {
        public UnknownPolicy(IRatingContext context)
            : base(context)
        {
        }


        public override void Rate(Policy policy)
        {
            _logger.Log("Unknown policy type");
        }
    }
}
