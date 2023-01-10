using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileandFileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:somefile.jpg";
            File.Copy(@"C:\temp\myfile.jpg", @"c:\destiny\myfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }
            

        }
    }
}
