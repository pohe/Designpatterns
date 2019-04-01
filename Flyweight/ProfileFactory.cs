using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class ProfileFactory
    {
        private Dictionary<int, ProfileIntrinsic> _intrinsicStateData;

        public ProfileFactory()
        {
            _intrinsicStateData = new Dictionary<int, ProfileIntrinsic>();
        }

        public Profile Create(string userName, int imageId)
        {
            ProfileExtrinsic pe = new ProfileExtrinsic(userName);
            ProfileIntrinsic pi = null;

            if (_intrinsicStateData.ContainsKey(imageId))
            {
                pi = _intrinsicStateData[imageId];
            }
            else
            {
                pi = new ProfileIntrinsic(ImageDB.Read(imageId));
                _intrinsicStateData[imageId] = pi;
            }

            return new Profile(pe, pi);
        }
    }

    public static class ImageDB
    {
        internal static int[] Read(int imageId)
        {
            throw new NotImplementedException();
        }
    }
}
