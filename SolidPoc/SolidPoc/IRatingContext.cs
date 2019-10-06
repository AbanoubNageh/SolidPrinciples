using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPoc
{
    public interface IRatingContext
    {
        Rater CreateRaterForPolicy(Policy policy, IRatingContext context);
        Logger Logger { get; set; }
    }
}
