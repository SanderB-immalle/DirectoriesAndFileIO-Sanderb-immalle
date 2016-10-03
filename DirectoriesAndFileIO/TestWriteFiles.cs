using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
namespace DirectoriesAndFileIO
{
    [TestClass]
    class TestWriteFiles
    {
        string testDir = "";
        string fileA = "";
        string fileAContents = "";
        string fileB = "";
        string fileBContents = "";
        string subDir = "";
        string subDirFile = "";
        string subDirFileContents = "";

        [TestInitialize]
        public void Initialize()
        {
            // Create a test-directory with known files and directories
            testDir = "testDir";
            fileA = Path.Combine(testDir, "a.txt");
            fileB = Path.Combine(testDir, "b.txt");
            subDir = Path.Combine(testDir, "subDir");
            subDirFile = Path.Combine(subDir, subDirFile);
            fileAContents = "This is a.txt.";
            fileBContents = "This is b.txt. \n b contains a newline \n b is innovative \n be like b!";
            subDirFileContents = "This is a file in a sub-directory.";
            
            Directory.CreateDirectory(testDir);
            Directory.CreateDirectory(subDir);
        }

        [TestCleanup]
        public void CleanUp()
        {
            if (Directory.Exists(testDir))
            {
                Directory.Delete(testDir, true);
            }
        }

        [TestMethod]
        public void WriteAllText()
        {
            
            StreamReader read = new StreamReader(fileA);

            File.WriteAllText(fileA, fileAContents);
            
            string result = read.ReadToEnd();
            Assert.AreEqual(result, fileAContents);

            read.Close();
        }
        
    }
}
