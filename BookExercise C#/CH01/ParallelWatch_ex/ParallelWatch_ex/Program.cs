using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ParallelWatch_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.ForEach(
                Directory.GetFiles(@"C:\Program Files\Internet Explorer", "*.*", SearchOption.AllDirectories),
                path =>
                {
                    ShowFilePaths(path);
                }
                );

        }

        public static void ShowFilePaths(string path)
        {
            Console.WriteLine(path);
        }
    }
}
