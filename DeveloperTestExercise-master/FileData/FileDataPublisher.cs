using FileDataController;
using System;
using System.Configuration;

namespace FileData
{
    /// <summary>
    /// FileDataPublisher access the FileDataController to get FileData
    /// </summary>
    class FileDataPublisher
    {

        FileDataProcessor oFileDataProcessor = new FileDataProcessor();
        string strInput = "";
        string strResult = "";

        /// <summary>
        /// Generate FileData with FileDataController
        /// </summary>
        internal void GenerateFileData()
        {
            try
            {
                Console.WriteLine("Please provide Inputs: ");
                strInput = Console.ReadLine();
                Console.WriteLine();

                strResult = oFileDataProcessor.ProcessFileData(strInput);
                Console.WriteLine(strResult);

                Console.WriteLine();
                Console.WriteLine("Do you want to Do it again?{Y/N}");
                string strYN = Console.ReadLine();
                Console.WriteLine();

                if (strYN == "Y" || strYN == "y")
                {
                    GenerateFileData();
                }
                else
                {
                    Console.WriteLine("Closing application....");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

            }
            catch (Exception Ex)
            {
                Console.WriteLine(ConfigurationSettings.AppSettings["CustomErrorMsg"]);
                GenerateFileData();
            }
        }

    }
}
