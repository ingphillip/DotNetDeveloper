using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugger
{
    [DebuggerDisplay("{Name + \" \" + LastName}")]
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
