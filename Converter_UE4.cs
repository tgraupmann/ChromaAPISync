using System;
using System.Collections.Generic;
using System.IO;

namespace ChromaAPISync
{
    partial class Converter
    {
        static bool WriteUe4ChromaAPIHeader(StreamReader sr, StreamWriter sw)
        {
            try
            {
                string line;
                do
                {
                    line = sr.ReadLine();
                    if (line == null ||
                        line == "\0")
                    {
                        break;
                    }
                    Output(sw, line);
                }
                while (line != null);
            }
            catch
            {

            }
            return true;
        }

        static bool WriteUe4ChromaAPIImplementation(StreamReader sr, StreamWriter sw)
        {
            try
            {
                string line;
                do
                {
                    line = sr.ReadLine();
                    if (line == null ||
                        line == "\0")
                    {
                        break;
                    }
                    Output(sw, line);
                }
                while (line != null);
            }
            catch
            {

            }
            return true;
        }
    }
}
