using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SolidPoc
{
    public class FilePolicy: IFilePolicy
    {
        public string GetPolicyFromSource()
        {
            return File.ReadAllText("policy.json");
        }
    }
}
