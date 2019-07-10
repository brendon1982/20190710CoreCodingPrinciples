using System;
using System.ComponentModel.Design;
using System.Drawing;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadConfig();
            CacheImages();
        }

        //The below methods are temporally cohesive
        private static void CacheImages()
        {
            //Logic to download an cache images in memory
        }

        private static void ReadConfig()
        {
            //Logic to read config into a central place in memory
        }
    }
}
