using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class Connect
    {
        public static ExamsEntities c;
        public static ExamsEntities Context
        {
            get
            {
                if(c== null)
                    c = new ExamsEntities();
                return c;
            }
        }
    }
}
