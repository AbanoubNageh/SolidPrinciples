using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPoc
{
    public abstract class Rater
    {
        protected readonly IRatingContext _context;
        protected readonly Logger _logger;

        public Rater(IRatingContext context)
        {
            _context = context;
            _logger = context.Logger;
        }


        public abstract void Rate(Policy policy);
    }
}
