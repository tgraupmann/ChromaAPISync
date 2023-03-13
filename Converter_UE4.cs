using System;
using System.Collections.Generic;
using System.IO;

namespace ChromaAPISync
{
    partial class Converter
    {
        static bool WriteUe4ChromaAPIHeader(StreamReader sr, StreamWriter sw)
        {
            string line;
            try
            {
                do
                {
                    line = sr.ReadLine();
                    if (line == null ||
                        line == "\0")
                    {
                        break;
                    }

                    Replace(ref line, "#pragma once", @"#pragma once

#include ""Logging/LogMacros.h""
DECLARE_LOG_CATEGORY_EXTERN(LogChromaAnimationAPI, Log, All);");

                    Replace(ref line, "ChromaSDK::FChromaSDKGuid", "FChromaSDKGuid");

                    Output(sw, "{0}", line);
                }
                while (line != null);

                sw.Flush();
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Failed to write UE4 header exception: {0}", ex);

            }
            return true;
        }

        static bool WriteUe4ChromaAPIImplementation(StreamReader sr, StreamWriter sw)
        {
            string line;
            try
            {
                do
                {
                    line = sr.ReadLine();
                    if (line == null ||
                        line == "\0")
                    {
                        break;
                    }
                    Output(sw, "{0}", line);
                }
                while (line != null);

                sw.Flush();
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Failed to write UE4 implementaiton exception: {0}", ex);
            }
            return true;
        }
    }
}
