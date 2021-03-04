using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CountClass
{
    class CountClass
    {
        private string FileName { get; set; }

        public CountClass(string filename)
        {
            FileName = filename;
        }

        public int Count()
        {
            int count = 0;

            if (File.Exists(FileName))
            {
                count = File.ReadLines(FileName, Encoding.UTF8)
                            .Count(s => s.Contains("class"));

                //var lines = File.ReadAllLines(FileName, Encoding.UTF8);
                //foreach (var line in lines)
                //{
                //    if (line.Contains("class"))
                //    {
                //        count++;
                //    }
                //}

                //using (var stream = new StreamReader(FileName, Encoding.UTF8))
                //{
                //    while (!stream.EndOfStream)
                //    {
                //        var line = stream.ReadLine();
                //        if (line.Contains("class"))
                //        {
                //            count++;
                //        }
                //    }
                //}
            }
           
            return count;            
        }
    }
}
