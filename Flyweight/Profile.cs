using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Profile
    {
        public Profile(
            ProfileExtrinsic extrinsicState,
            ProfileIntrinsic intrinsicState)
        {
            ExtrinsicState = extrinsicState;
            IntrinsicState = intrinsicState;
        }

        public ProfileExtrinsic ExtrinsicState { get; }
        public ProfileIntrinsic IntrinsicState { get; }

        public void Display()
        {
            IntrinsicState.Display(ExtrinsicState);
        }
    }


}
