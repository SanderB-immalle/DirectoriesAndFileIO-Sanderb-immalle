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
    public class TestWriteFiles
    {
        string testDir = "";
        string fileA = "";
        string fileAContents = "";
        string fileB = "";
        string[] fileBContents = new string[] {"one", "two" };
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
        public void TestWriteAllText()
        {        
           
            File.WriteAllText(fileA, fileAContents);



            StreamReader reader = new StreamReader(fileA);
            string result = reader.ReadToEnd();
            Assert.AreEqual(result, fileAContents);        
            reader.Close();
        }

        [TestMethod]
        public void TestWriteAllLines()
        {
            File.WriteAllLines(fileB, fileBContents );

            StreamReader reader = new StreamReader(fileB);
            string result = reader.ReadToEnd();
            Assert.AreEqual(result, fileBContents);
            reader.Close();
        }
        
        
    }
}
