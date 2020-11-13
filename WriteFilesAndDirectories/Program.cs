using System;
using System.IO;

namespace WriteFilesAndDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteFilePaths();
        }

        public static void WriteFilePaths()
        {
            string filePath = @"C:\Users\julia.voronetskaja\samples\files.txt";
            string directoryPath = @"C:\Users\julia.voronetskaja\samples";

            string[] files = Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories);

            //save to file
            File.WriteAllLines(filePath, files);
        }
    }
}
