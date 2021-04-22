using System;
using System.Collections.Generic;
using System.Text;

namespace GRASP.LowCoupling
{
    class RentVideo
    {
        //private Video _video;
        public Video getVideo(String title)
        {
            return getAllVideos().Find(video => video.Title == title);
        }
    }
}
