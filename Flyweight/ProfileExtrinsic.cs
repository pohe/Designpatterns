using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class ProfileExtrinsic
    {
        public ProfileExtrinsic(string userName)
        {
            UserName = userName;
        }

        public string UserName { get; }
    }

}
