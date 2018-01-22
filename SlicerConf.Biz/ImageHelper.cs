using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlicerConf.Biz
{
    
    public static class ImageHelper
    {
        public static byte[] ConvertFileToByteArray(string sPath)
        {
            byte[] data = null;
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            data = br.ReadBytes((int)numBytes);
            return data;
        }

        public static Image ConvertByteToImage(byte[] imageData)
        {
            Image newImage;
            using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
            {
                ms.Write(imageData, 0, imageData.Length);
                newImage = Image.FromStream(ms, true);
            }
            return newImage;

        }
    }
}
