using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ChromaAPISync
{
    class Converter
    {
        public static void ConvertExportsToClass(string input, string header)
        {
            ConvertHeader(input, header);
        }

        private static void ConvertHeader(string input, string outputFile)
        {
            if (File.Exists(outputFile))
            {
                File.Delete(outputFile);
            }
            using (FileStream fs = File.Open(outputFile, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    ProcessHeader(input, sw);
                }
            }
        }

        static bool Replace(ref string line, string search, string replace)
        {
            if (line.Contains(search))
            {
                line = line.Replace(search, replace);
                return true;
            }
            return false;
        }

        static bool SwapStart(ref string line, string search, string replace)
        {
            if (line.StartsWith(search))
            {
                line = replace + line.Substring(search.Length);
                return true;
            }
            return false;
        }

        static bool TrimAfter(ref string line, string search, string replace)
        {
            if (line.Contains(search))
            {
                int index = line.IndexOf(search);
                line = line.Substring(0, index) + replace;
                return true;
            }
            return false;
        }

        static void Indent(string line, int blockLevel, StreamWriter sw)
        {
            for (int i = 0; i < blockLevel; ++i)
            {
                if (line.Contains("}"))
                {
                    if (i + 1 == blockLevel)
                    {
                        break;
                    }
                }
                Console.Write(" ");
                sw.Write(" ");
            }
        }

        const string TOKEN_PLUGIN = "Plugin";

        private static bool GetMethodName(string line, out string methodName)
        {
            int indexPlugin = line.IndexOf(TOKEN_PLUGIN);
            string temp = line.Substring(indexPlugin + TOKEN_PLUGIN.Length);
            int indexParens = temp.IndexOf("(");
            if (indexParens <= 0)
            {
                methodName = "";
                return false;
            }
            methodName = temp.Substring(0, indexParens);

            return true;
        }

        static void ProcessHeader(string filename, StreamWriter sw)
        {
            try
            {
                SortedList<string, string> methods = new SortedList<string, string>();
                using (FileStream fs = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (StreamReader sr = new StreamReader(fs))
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
                            line = line.TrimStart();
                            if (line.Contains("Dialog") ||
                                line.Contains("PluginSetLogDelegate"))
                            {
                                continue;
                            }
                            if (!line.StartsWith("EXPORT_API"))
                            {
                                continue;
                            }
                            if (!line.Contains(TOKEN_PLUGIN))
                            {
                                continue;
                            }
                            //Console.WriteLine("{0}", line);

                            int indexPlugin = line.IndexOf(TOKEN_PLUGIN);
                            string temp = line.Substring(indexPlugin + TOKEN_PLUGIN.Length);
                            int indexParens = temp.IndexOf("(");
                            if (indexParens <= 0)
                            {
                                continue;
                            }
                            string methodName;
                            if (!GetMethodName(line, out methodName))
                            {
                                continue;
                            }
                            //Console.WriteLine("Method: {0}", methodName);
                            methods[methodName] = line;
                            if (true)
                            {
                                continue;
                            }                            

                            Console.WriteLine("{0}", line);
                            sw.WriteLine(line);
                        }
                        while (line != null);
                    }
                }

                foreach (KeyValuePair<string, string> method in methods)
                {
                    Console.WriteLine("Method: {0}", method.Key);
                }

                if (true)
                {

                }
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Failed to process file: {0}", filename);
            }
        }
    }
}
