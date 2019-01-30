using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileDataController;

namespace FileDataControllerTest
{
    [TestClass]
    public class FileDataProcessorTest
    {
        FileDataProcessor oFileDataProcessor = new FileDataProcessor();
        string strOutPut = null;

        [TestMethod]
        public void ProcessFileDataValidVersion()
        {
            strOutPut = oFileDataProcessor.ProcessFileData("-v c:/demo.txt");
            Assert.IsTrue(strOutPut.Contains("File Version"));
        }

        [TestMethod]
        public void ProcessFileDataValidSize()
        {
            strOutPut = oFileDataProcessor.ProcessFileData("-s c:/demo.txt");
            Assert.IsTrue(strOutPut.Contains("File Size"));
        }

        [TestMethod]
        public void ProcessFileDataInValidVersion()
        {
            strOutPut = oFileDataProcessor.ProcessFileData("v c:/demo.txt");
            Assert.IsFalse(strOutPut.Contains("File Version"));
        }

        [TestMethod]
        public void ProcessFileDataInValidSize()
        {
            strOutPut = oFileDataProcessor.ProcessFileData("s c:/demo.txt");
            Assert.IsFalse(strOutPut.Contains("File Size"));
        }

        [TestMethod]
        public void ProcessFileDataCorrectVersion()
        {
            strOutPut = oFileDataProcessor.ProcessFileData("--v c:/demo.txt");
            Assert.IsTrue(strOutPut.Contains("File Version"));
        }

        [TestMethod]
        public void ProcessFileDataCorrectSize()
        {
            strOutPut = oFileDataProcessor.ProcessFileData("--s c:/demo.txt");
            Assert.IsTrue(strOutPut.Contains("File Size"));
        }

        [TestMethod]
        public void ProcessFileDataWrongVersion()
        {
            strOutPut = oFileDataProcessor.ProcessFileData("version ");
            Assert.IsFalse(strOutPut.Contains("File Version"));
        }

        [TestMethod]
        public void ProcessFileDataWrongSize()
        {
            strOutPut = oFileDataProcessor.ProcessFileData("size ");
            Assert.IsFalse(strOutPut.Contains("File Size"));
        }

    }
    
}
