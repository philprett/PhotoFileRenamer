using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PhotoFileRenamer.Data
{
    internal class PhotoFile
    {
        public FileInfo File { get; set; }

        public DateTime FileTimestamp { get; set; }

        public DateTime? ExifTimestamp { get; set; }

        public DateTime Timestamp { get; set; }

        public PhotoFile(FileInfo file)
        {
            File = file;
            FileTimestamp = File.LastWriteTime;
            ExifTimestamp = GetExifFileTime();
            if (ExifTimestamp.Value == DateTime.MinValue)
            {
                ExifTimestamp = null;
            }

            Timestamp = ExifTimestamp ?? FileTimestamp;
        }
        
        public bool HasAlreadyBeenRenamed()
        {
            return File.Name.StartsWith(Timestamp.ToString("yyyyMMdd_HHmmss"));
        }

        private static readonly Regex Regexer = new Regex(":");

        private DateTime GetExifFileTime()
        {
            try
            {
                using FileStream fs = new FileStream(File.FullName, FileMode.Open, FileAccess.Read);

                using Image myImage = Image.FromStream(fs, false, false);

                PropertyItem propItem = myImage.GetPropertyItem(36867);
                string dateTaken = Regexer.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                return DateTime.Parse(dateTaken);
            }
            catch (Exception ex)
            {
                return DateTime.MinValue;
            }
        }


    }
}
