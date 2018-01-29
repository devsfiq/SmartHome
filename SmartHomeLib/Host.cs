using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeLib
{
    public class Host
    {
        public string Name { get; set; }

        public string IP { get; set; }
        public string MAC { get; set; }
    }

    internal class HostComparer : IEqualityComparer<Host>
    {
        public bool Equals(Host x, Host y)
        {
            return x.MAC == y.MAC;
        }

        public int GetHashCode(Host obj)
        {
            return obj.MAC.GetHashCode();
        }
    }
}
