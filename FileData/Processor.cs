using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
    public class Processor
    {
        private readonly IEnumerable<string> allowedVersionArgsList = new List<string> { "-v", "--v", "/v", "--version" };
        private readonly IEnumerable<string> allowedSizeArgsList = new List<string> { "-s", "--s", "/s", "--size" };

        private FileDetails fileDetails = new FileDetails();

        public  void TaskTwo(string[] args)
        {            
            if (args.Length == 2)
            {
                string path = args[1];
                if (allowedVersionArgsList.Contains(args[0]))
                {
                    string version = GetVersion(path);
                    Console.WriteLine(version);
                }
                else if (allowedSizeArgsList.Contains(args[0]))
                {
                    int size = GetSize(path);
                    Console.WriteLine(size);
                }
            }
            else
            {
                Console.WriteLine("Two arguments are expected to main!!!");
            }
            Console.WriteLine("Press enter key to exit !!");
            Console.ReadLine();
        }

        public string GetVersion(string path)
        {
            return fileDetails.Version(path);
        }

        public int GetSize(string path)
        {
            return fileDetails.Size(path);
        }
    }
}
