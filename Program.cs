using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace LockFile
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Usage: Lockfile {filename}.");
                return;
            }

            string filename = args[0];

            Console.WriteLine(String.Format("Locking file: {0}...",filename));

            if (!File.Exists(filename))
            {
                Console.WriteLine("!!! File not found !!!");
                return;
            }
            
            FileStream lockfile = File.Open(filename,FileMode.Open,FileAccess.Read,FileShare.None);
            
            Console.WriteLine("File locked. Press Return to unlock.");
            
            Console.ReadLine();
            
            Console.WriteLine("Closing file...");
            lockfile.Close();
            Console.WriteLine("File unlocked.");

        }
    }
}
