using FileData;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileDemo.Test
{ 
    [TestFixture]
    public class ProcessorTest
    {
        private readonly string path = "c:/test.txt";
        [Test]
        public void CheckVersion()
        {
            Processor processor = new Processor();
           
            string version = processor.GetVersion(path);
            Assert.IsNotNull(version);
            Assert.IsNotEmpty(version);
        }

        [Test]
        public void CheckSize()
        {
            Processor processor = new Processor();
            int size =  processor.GetSize(path);
            Assert.IsNotNull(size);           
        }

    }
}
