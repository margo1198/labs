using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers
{
    class JuniorDeveloper :Developer
    {
        public JuniorDeveloper(string n) : base(n)
    { }

        public override Project Create()
        {
            return new JuniorProject();
        }
    }
}
