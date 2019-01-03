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
            if (indexPlugin <= 0)
            {
                methodName = "";
                return false;
            }
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

        private static bool GetArgs(string line, out string args)
        {
            int indexPlugin = line.IndexOf(TOKEN_PLUGIN);
            if (indexPlugin <= 0)
            {
                args = "";
                return false;
            }
            string temp = line.Substring(indexPlugin + TOKEN_PLUGIN.Length);
            int indexParens = temp.IndexOf("(");
            if (indexParens <= 0)
            {
                args = "";
                return false;
            }
            temp = temp.Substring(indexParens+1);

            indexParens = temp.IndexOf(")");
            if (indexParens < 0)
            {
                args = "";
                return false;
            }

            args = temp.Substring(0, indexParens);
            return true;
        }

        private static string GetCamelUnderscore(string original)
        {
            string result = string.Empty;
            foreach (char c in original)
            {
                if (!string.IsNullOrEmpty(result) &&
                    char.IsUpper(c))
                {
                    result += "_";
                }
                result += char.ToUpper(c);
            }
            return result;
        }

        const string TOKEN_EXPORT_API = "EXPORT_API";

        private static bool GetReturnType(string line, out string returnType)
        {
            int indexPlugin = line.IndexOf(TOKEN_PLUGIN);
            if (indexPlugin <= 0)
            {
                returnType = "";
                return false;
            }
            string temp = line.Substring(0, indexPlugin);
            int indexExport = temp.IndexOf(TOKEN_EXPORT_API);
            if (indexExport < 0)
            {
                returnType = "";
                return false;
            }
            returnType = temp.Substring(indexExport + TOKEN_EXPORT_API.Length).Trim();

            return true;
        }

        private static string GetTabs(string returnType)
        {
            if (returnType.Length < 4)
            {
                return "\t\t\t";
            }
            else if (returnType.Length < 8)
            {
                return "\t\t";
            }
            else
            {
                return "\t";
            }
        }

        class MetaMethodInfo
        {
            public string Name = string.Empty;
            public string ReturnType = string.Empty;
            public string Tabs = string.Empty;
            public string Line = string.Empty;
            public string Args = string.Empty;
        }

        static void ProcessHeader(string filename, StreamWriter sw)
        {
            try
            {
                SortedList<string, MetaMethodInfo> methods = new SortedList<string, MetaMethodInfo>();
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
                            if (!line.StartsWith(TOKEN_EXPORT_API))
                            {
                                continue;
                            }
                            if (!line.Contains(TOKEN_PLUGIN))
                            {
                                continue;
                            }
                            //Console.WriteLine("{0}", line);

                            MetaMethodInfo methodInfo = new MetaMethodInfo();

                            if (!GetMethodName(line, out methodInfo.Name))
                            {
                                continue;
                            }
                            //Console.WriteLine("Method: {0}", methodInfo.Name);
                            methodInfo.Line = line;
                            methods[methodInfo.Name] = methodInfo;

                            if (!GetReturnType(line, out methodInfo.ReturnType))
                            {
                                continue;
                            }
                            //Console.WriteLine("Returns: {0}", methodInfo.ReturnType);

                            methodInfo.Tabs = GetTabs(methodInfo.ReturnType);

                            if (!GetArgs(line, out methodInfo.Args))
                            {
                                continue;
                            }
                            //Console.WriteLine("Args: {0}", methodInfo.Args);

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

                foreach (KeyValuePair<string, MetaMethodInfo> method in methods)
                {
                    MetaMethodInfo methodInfo = method.Value;
                    //Console.WriteLine("Returns: {0} Method: {1} Args: {2}", 
                    //    methodInfo.ReturnType, methodInfo.Name, methodInfo.Args);

                    Console.WriteLine("typedef {0}{1}(*PLUGIN_{2})({3});",
                        methodInfo.ReturnType, methodInfo.Tabs, GetCamelUnderscore(methodInfo.Name), methodInfo.Args);

                    sw.WriteLine("typedef {0}{1}(*PLUGIN_{2})({3});",
                        methodInfo.ReturnType, methodInfo.Tabs, GetCamelUnderscore(methodInfo.Name), methodInfo.Args);
                }

                sw.Flush();
                sw.Close();

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
