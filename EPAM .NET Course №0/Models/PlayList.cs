using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_.NET_Course__0
{
    class PlayList
    {
        public string Name { get; set; }

        public ICollection<MediaFile> FileList;
    }
}
