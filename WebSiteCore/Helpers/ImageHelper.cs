using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteCore.Helpers
{
    public static class ImageHelper
    {
        public static Image FromBase64StringToImage(this string base64String)
        {
            byte[] byteBuffer = Convert.FromBase64String(base64String);
            Image imgReturn;
            using (MemoryStream memoryStream = new MemoryStream(byteBuffer))
            {
                memoryStream.Position = 0;
                imgReturn = Image.FromStream(memoryStream);
                byteBuffer = null;
            }
            return imgReturn;

        }
    }
}
