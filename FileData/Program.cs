using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // TaskOne(args);
            Processor processor = new Processor();
            processor.TaskTwo(args);
        }

        private static void TaskOne(string[] args)
        {
            FileDetails fileDetails = new FileDetails();
            if (args.Length ==2)
            {
                if (args[0] == "-v" && !string.IsNullOrEmpty(args[1]))
                {
                    string path = args[1];
                    string version = fileDetails.Version(path);
                    Console.WriteLine(version);
                    Console.ReadLine();
                }
            }
        }
        
      
    }
}
