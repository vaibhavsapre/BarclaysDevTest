﻿using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            FileDataPublisher oFileDataPublisher = new FileDataPublisher();
            oFileDataPublisher.GenerateFileData();

        }
    }
}
