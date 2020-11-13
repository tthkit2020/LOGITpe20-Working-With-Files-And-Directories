using System;
using System.IO;

namespace DirectoriesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\julia.voronetskaja\samples";

            //get the full path of all the direcories at the rootPath
            string[] allDirectories = Directory.GetDirectories(rootPath);
            //ReadArray(allDirectories);

            //get nested directories
            string[] includeNestedDirectories = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
            // ReadArray(includeNestedDirectories);


            //get directory files
            string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            ReadArray(files);



        }

        public static void ReadArray(string[] array)
        {
            foreach(string line in array)
            {
                Console.WriteLine(line);
            }
        }
    }
}
