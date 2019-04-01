using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class ProfileIntrinsic
    {
        public ProfileIntrinsic(int[] imageData)
        {
            ImageData = imageData;
        }

        public int[] ImageData { get; }

        public void Display(ProfileExtrinsic extrinsicState)
        {
            // Uses both extrinsic and intrinsic state data,
            // but extrinsic state is now a parameter!
        }
    }

}
