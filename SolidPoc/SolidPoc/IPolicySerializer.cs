using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPoc
{
    public interface IPolicySerializer
    {
        Policy GetPolicyFromJsonString(string jsonString);
    }
}
