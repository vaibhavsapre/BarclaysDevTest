using System;
using System.Configuration;
using System.Linq;
using ThirdPartyTools;

namespace FileDataController
{
    /// <summary>
    /// FileDataProcessor class to process Input params
    /// </summary>
    public class FileDataProcessor : IFileDataProcessor
    {

        string strReturnData = "";
        /// <summary>
        /// Process Input FileData Param for Version or Size.
        /// </summary>
        /// <param name="strInParam">String</param>
        /// <returns>String</returns>
        public string ProcessFileData(string strInParam)
        {
            try
            {
                string[] strParam = strInParam.Split(' ');
                FileDetails oFileDetails = new FileDetails();
                string strMsgValidInputs = "Please, enter valid Inputs.";

                string[] arrVersion = ConfigurationSettings.AppSettings["VersionCollection"].Split(',');
                string[] arrSize = ConfigurationSettings.AppSettings["SizeCollection"].Split(',');


                if (strInParam.Length <= 2)
                {
                    strReturnData = strMsgValidInputs;
                }
                else if (arrSize.Contains(strParam[0].ToLower()))
                {
                    strReturnData = String.Concat("File Size: ", Convert.ToString(oFileDetails.Size(strParam[1].Trim())));
                }
                else if (arrVersion.Contains(strParam[0].ToLower()))
                {
                    strReturnData = String.Concat("File Version: ", oFileDetails.Version(strParam[1].Trim()));
                }
                else
                {
                    strReturnData = strMsgValidInputs;
                }
            }
            catch (Exception Ex)
            {
                strReturnData = ConfigurationSettings.AppSettings["CustomErrorMsg"];

            }

            return strReturnData;

        }
    }
}
