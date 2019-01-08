using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ChromaAPISync
{
    class Converter
    {
        public static void ConvertExportsToClass(string input, string outputHeader, string outputImplementation, string outputDocs,
            string outputSortInput)
        {
            OpenClassFiles(input, outputHeader, outputImplementation, outputDocs, outputSortInput);
        }

        private static void OpenClassFiles(string input, string fileHeader, string fileImplementation, string fileDocs,
            string fileSortInput)
        {
            if (File.Exists(input))
            {
                if (!ProcessStdafx(input))
                {
                    return;
                }
            }

            if (File.Exists(fileHeader))
            {
                File.Delete(fileHeader);
            }
            using (FileStream fsHeader = File.Open(fileHeader, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter swHeader = new StreamWriter(fsHeader))
                {
                    if (!WriteHeader(swHeader))
                    {
                        return;
                    }
                }
            }

            if (File.Exists(fileImplementation))
            {
                File.Delete(fileImplementation);
            }
            using (FileStream fsImplementation = File.Open(fileImplementation, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter swImplementation = new StreamWriter(fsImplementation))
                {
                    if (!WriteHeader(swImplementation))
                    {
                        return;
                    }
                }
            }

            if (File.Exists(fileDocs))
            {
                File.Delete(fileDocs);
            }
            using (FileStream fsDocs = File.Open(fileDocs, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter swDocs = new StreamWriter(fsDocs))
                {
                    if (!WriteDocs(swDocs))
                    {
                        return;
                    }
                }
            }

            if (File.Exists(fileSortInput))
            {
                File.Delete(fileSortInput);
            }
            using (FileStream fsSortInput = File.Open(fileSortInput, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter swSortInput = new StreamWriter(fsSortInput))
                {
                    if (!WriteSortInput(swSortInput))
                    {
                        return;
                    }
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

        const string TOKEN_NAME = "NAME";
        const string TOKEN_NAME_D = "NAME_D";

        private static bool ReplaceUnderscoreSuffix(ref string name, string token)
        {
            if (name.EndsWith(token))
            {
                int indexName = name.LastIndexOf(token);
                if (indexName > 1)
                {
                    if (name[indexName - 1] != '_')
                    {
                        name = name.Substring(0, indexName) + "_" + token;
                    }
                }
            }
            return false;
        }

        private static string GetCamelUnderscore(string original)
        {
            string result = string.Empty;
            bool hadUpper = false;
            bool hadDigit = false;
            foreach (char c in original)
            {
                if (!string.IsNullOrEmpty(result) &&
                    (!hadUpper && !hadDigit) &&
                    char.IsUpper(c))
                {
                    result += "_";
                }
                result += char.ToUpper(c);
                hadUpper = char.IsUpper(c);
                hadDigit = char.IsDigit(c);
            }
            Replace(ref result, "RGBNAME", "RGB_NAME");
            Replace(ref result, "RGBCOLORS", "RGB_COLORS");
            Replace(ref result, "1D", "_1D_");
            Replace(ref result, "2D", "_2D_");
            Replace(ref result, "UN_INIT", "UNINIT");
            return result;
        }

        const string TOKEN_EXPORT_API = "EXPORT_API";
        const string TOKEN_COMMENT_START = "/*";
        const string TOKEN_COMMENT_STOP = "*/";

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

        private static string SplitLongLines(string line)
        {
            string returnStr = "";
            int j = 0;
            bool ignoreWhiteSpace = false;
            for (int i = 0; i < line.Length; ++i)
            {
                char c = line[i];
                if (ignoreWhiteSpace &&
                    char.IsWhiteSpace(c))
                {

                }
                else
                {
                    returnStr += c;
                    ignoreWhiteSpace = false;
                }
                if (c == ',' &&
                    j > 70)
                {
                    returnStr += "\r\n\t"; //insert line
                    j = 0;
                    ignoreWhiteSpace = true;
                }
                ++j;
            }
            return returnStr;
        }

        private static string SplitLongComments(string comment)
        {
            string returnStr = "";
            int j = 0;
            for (int i = 0; i < comment.Length; ++i)
            {
                char c = comment[i];
                returnStr += c;
                if (char.IsWhiteSpace(c) &&
                    j > 70)
                {
                    returnStr += "\r\n\t\t"; //insert line
                    j = 0;
                }
                ++j;
            }
            return returnStr;
        }

        class MetaMethodInfo
        {
            public string Name = string.Empty;
            public string ReturnType = string.Empty;
            public string Tabs = string.Empty;
            public string Line = string.Empty;
            public string Args = string.Empty;
            public string Comments = string.Empty;
        }

        static SortedList<string, MetaMethodInfo> _sMethods = new SortedList<string, MetaMethodInfo>();

        static bool ProcessStdafx(string fileInput)
        {
            try
            {
                _sMethods.Clear();

                using (FileStream fs = File.Open(fileInput, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line;
                        bool readComments = false;
                        string comments = string.Empty;
                        do
                        {
                            line = sr.ReadLine();
                            if (line == null ||
                                line == "\0")
                            {
                                break;
                            }
                            line = line.TrimStart();
                            bool detectedCommentBlock = false;
                            if (line.StartsWith(TOKEN_COMMENT_START))
                            {
                                readComments = true;
                                detectedCommentBlock = true;
                                comments = string.Empty;
                            }
                            if (line.Contains(TOKEN_COMMENT_STOP))
                            {
                                readComments = false;
                                detectedCommentBlock = true;
                            }
                            if (detectedCommentBlock)
                            {
                                continue;
                            }
                            if (readComments)
                            {
                                comments += line + " ";
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

                            methodInfo.Comments = comments;
                            comments = string.Empty;

                            if (!GetMethodName(line, out methodInfo.Name))
                            {
                                continue;
                            }
                            //Console.WriteLine("Method: {0}", methodInfo.Name);
                            methodInfo.Line = line;
                            _sMethods[methodInfo.Name] = methodInfo;

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
                        }
                        while (line != null);
                    }
                }

                return true;
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Failed to process file: {0}", fileInput);
                return false;
            }
        }

        static bool WriteHeader(StreamWriter swHeader)
        {
            try
            {
                swHeader.WriteLine("#pragma region API typedefs");
                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;
                    //Console.WriteLine("Returns: {0} Method: {1} Args: {2}", 
                    //    methodInfo.ReturnType, methodInfo.Name, methodInfo.Args);

                    Console.WriteLine("typedef {0}{1}(*PLUGIN_{2})({3});",
                        methodInfo.ReturnType, methodInfo.Tabs, GetCamelUnderscore(methodInfo.Name), methodInfo.Args);

                    swHeader.WriteLine("typedef {0}{1}(*PLUGIN_{2})({3});",
                        methodInfo.ReturnType, methodInfo.Tabs, GetCamelUnderscore(methodInfo.Name), methodInfo.Args);
                }
                swHeader.WriteLine("#pragma endregion");

                Console.WriteLine();
                swHeader.WriteLine();

                swHeader.WriteLine("#pragma region API declare prototypes");
                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Console.WriteLine("CHROMASDK_DECLARE_METHOD(PLUGIN_{0}, {1});",
                        GetCamelUnderscore(methodInfo.Name), methodInfo.Name);

                    swHeader.WriteLine("CHROMASDK_DECLARE_METHOD(PLUGIN_{0}, {1});",
                        GetCamelUnderscore(methodInfo.Name), methodInfo.Name);
                }
                swHeader.WriteLine("#pragma endregion");

                swHeader.Flush();
                swHeader.Close();

                return true;
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Failed to write header!");
                return false;
            }
        }

        static bool WriteImplementation(StreamWriter swImplementation)
        {
            try
            {
                Console.WriteLine();

                swImplementation.WriteLine("#pragma region API declare assignments");
                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Console.WriteLine("CHROMASDK_DECLARE_METHOD_IMPL(PLUGIN_{0}, {1});",
                        GetCamelUnderscore(methodInfo.Name), methodInfo.Name);

                    swImplementation.WriteLine("CHROMASDK_DECLARE_METHOD_IMPL(PLUGIN_{0}, {1});",
                        GetCamelUnderscore(methodInfo.Name), methodInfo.Name);
                }
                swImplementation.WriteLine("#pragma endregion");

                Console.WriteLine();
                swImplementation.WriteLine();

                swImplementation.WriteLine("#pragma region API validation");
                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Console.WriteLine("CHROMASDK_VALIDATE_METHOD(PLUGIN_{0}, {1});",
                        GetCamelUnderscore(methodInfo.Name), methodInfo.Name);

                    swImplementation.WriteLine("CHROMASDK_VALIDATE_METHOD(PLUGIN_{0}, {1});",
                        GetCamelUnderscore(methodInfo.Name), methodInfo.Name);
                }
                swImplementation.WriteLine("#pragma endregion");

                swImplementation.Flush();
                swImplementation.Close();

                return true;
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Failed to write implementation!");
                return false;
            }
        }

        static bool WriteDocs(StreamWriter swDocs)
        {
            try
            {
                Console.WriteLine();

                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Console.WriteLine("* [Plugin{0}](#Plugin{0})", methodInfo.Name);
                    swDocs.WriteLine("* [Plugin{0}](#Plugin{0})", methodInfo.Name);
                }

                Console.WriteLine();
                swDocs.WriteLine();

                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Console.WriteLine(@"<a name=""Plugin{0}""></a>", methodInfo.Name);
                    swDocs.WriteLine(@"<a name=""Plugin{0}""></a>", methodInfo.Name);

                    Console.WriteLine("**Plugin{0}**", methodInfo.Name);
                    swDocs.WriteLine("**Plugin{0}**", methodInfo.Name);

                    Console.WriteLine();
                    swDocs.WriteLine();

                    Console.WriteLine("```C++", methodInfo.Name);
                    swDocs.WriteLine("```C++", methodInfo.Name);

                    if (methodInfo.Args.Length < 20)
                    {
                        Console.WriteLine("EXPORT_API {0} Plugin{1}({2});",
                            methodInfo.ReturnType,
                            methodInfo.Name,
                            methodInfo.Args);
                        swDocs.WriteLine("EXPORT_API {0} Plugin{1}({2});",
                            methodInfo.ReturnType,
                            methodInfo.Name,
                            methodInfo.Args);
                    }
                    else
                    {
                        Console.WriteLine("EXPORT_API {0} Plugin{1}(\r\n\t{2});",
                            methodInfo.ReturnType,
                            methodInfo.Name,
                            SplitLongLines(methodInfo.Args));
                        swDocs.WriteLine("EXPORT_API {0} Plugin{1}(\r\n\t{2});",
                            methodInfo.ReturnType,
                            methodInfo.Name,
                            SplitLongLines(methodInfo.Args));
                    }

                    Console.WriteLine("```", methodInfo.Name);
                    swDocs.WriteLine("```", methodInfo.Name);

                    Console.WriteLine();
                    swDocs.WriteLine();
                }

                return true;
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Failed to write docs!");
                return false;
            }
        }

        static bool WriteSortInput(StreamWriter swSortInput)
        {
            try
            {
                Console.WriteLine();

                Console.WriteLine("#pragma region Source of autogenerated APIs and documentation");
                swSortInput.WriteLine("#pragma region Source of autogenerated APIs and documentation");

                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Console.WriteLine("\t/*");
                    swSortInput.WriteLine("\t/*");

                    if (!string.IsNullOrEmpty(methodInfo.Comments))
                    {
                        Console.WriteLine("\t\t{0}", SplitLongComments(methodInfo.Comments));
                        swSortInput.WriteLine("\t\t{0}", SplitLongComments(methodInfo.Comments));
                    }

                    Console.WriteLine("\t*/");
                    swSortInput.WriteLine("\t*/");

                    Console.WriteLine("\tEXPORT_API {0} Plugin{1}({2});",
                        methodInfo.ReturnType,
                        methodInfo.Name,
                        methodInfo.Args);
                    swSortInput.WriteLine("\tEXPORT_API {0} Plugin{1}({2});",
                        methodInfo.ReturnType,
                        methodInfo.Name,
                        methodInfo.Args);
                }

                Console.WriteLine("#pragma endregion");
                swSortInput.WriteLine("#pragma endregion");

                return true;
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Failed to write docs!");
                return false;
            }
        }
    }
}
