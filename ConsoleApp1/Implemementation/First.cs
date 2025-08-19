using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Implementation
{
    public class First : IFirst
    {
        public void DoIt()
        {
            var a = 321 + 2 + 1;
            throw new NotImplementedException();
        }
    }
}
 