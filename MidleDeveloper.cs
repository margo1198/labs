using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers
{
    class MidleDeveloper: Developer
    {
        public MidleDeveloper(string n) : base(n)
    { }

        public override Project Create()
        {
            return new MidleProject();
        }
    }
}
