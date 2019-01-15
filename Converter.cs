using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ChromaAPISync
{
    class Converter
    {
        public static void ConvertExportsToClass(string input,
            string outputHeader, string outputImplementation,
            string outputDocs,
            string outputUnity,
            string outputSortInput)
        {
            OpenClassFiles(input,
                outputHeader, outputImplementation,
                outputDocs,
                outputUnity,
                outputSortInput);
        }

        private static void Output(StreamWriter sw, string msg, params object[] args)
        {
            Console.WriteLine(msg, args);
            sw.WriteLine(msg, args);
        }

        private static void OpenClassFiles(string input,
            string fileHeader, string fileImplementation,
            string fileDocs,
            string fileUnity,
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

            if (File.Exists(fileUnity))
            {
                File.Delete(fileUnity);
            }
            using (FileStream fsUnity = File.Open(fileUnity, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter swUnity = new StreamWriter(fsUnity))
                {
                    if (!WriteUnity(swUnity))
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

        private static string SplitLongComments(string comment, string indent)
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
                    returnStr += "\r\n" + indent; //insert line
                    j = 0;
                }
                ++j;
            }
            return returnStr.TrimEnd();
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
                Output(swHeader, "#pragma region API typedefs");
                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(swHeader, "/*");

                    if (!string.IsNullOrEmpty(methodInfo.Comments))
                    {
                        Output(swHeader, "\t{0}", SplitLongComments(methodInfo.Comments, "\t"));
                    }

                    Output(swHeader, "*/");

                    Output(swHeader, "typedef {0}{1}(*PLUGIN_{2})({3});",
                        methodInfo.ReturnType, methodInfo.Tabs, GetCamelUnderscore(methodInfo.Name), methodInfo.Args);
                }
                Output(swHeader, "#pragma endregion");

                Output(swHeader, "");

                Output(swHeader, "#pragma region API declare prototypes");
                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(swHeader, "/*");

                    if (!string.IsNullOrEmpty(methodInfo.Comments))
                    {
                        Output(swHeader, "\t{0}", SplitLongComments(methodInfo.Comments, "\t"));
                    }

                    Output(swHeader, "*/");

                    Output(swHeader, "CHROMASDK_DECLARE_METHOD(PLUGIN_{0}, {1});",
                        GetCamelUnderscore(methodInfo.Name), methodInfo.Name);
                }
                Output(swHeader, "#pragma endregion");

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

                Output(swImplementation, "#pragma region API declare assignments");
                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(swImplementation, "CHROMASDK_DECLARE_METHOD_IMPL(PLUGIN_{0}, {1});",
                        GetCamelUnderscore(methodInfo.Name), methodInfo.Name);
                }
                Output(swImplementation, "#pragma endregion");

                Output(swImplementation, "");

                Output(swImplementation, "#pragma region API validation");
                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(swImplementation, "CHROMASDK_VALIDATE_METHOD(PLUGIN_{0}, {1});",
                        GetCamelUnderscore(methodInfo.Name), methodInfo.Name);
                }
                Output(swImplementation, "#pragma endregion");

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

                    Output(swDocs, "* [Plugin{0}](#Plugin{0})", methodInfo.Name);
                }

                Output(swDocs, "");

                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(swDocs, "---");

                    Output(swDocs, @"<a name=""Plugin{0}""></a>", methodInfo.Name);

                    Output(swDocs, "**Plugin{0}**", methodInfo.Name);

                    Output(swDocs, "");

                    if (!string.IsNullOrEmpty(methodInfo.Comments))
                    {
                        Output(swDocs, "{0}", SplitLongComments(methodInfo.Comments, ""));

                        Output(swDocs, "");
                    }

                    Output(swDocs, "```C++", methodInfo.Name);

                    Output(swDocs, "// DLL Interface", methodInfo.Name);

                    if (methodInfo.Args.Length < 20)
                    {
                        Output(swDocs, "EXPORT_API {0} Plugin{1}({2});",
                            methodInfo.ReturnType,
                            methodInfo.Name,
                            methodInfo.Args);
                    }
                    else
                    {
                        Output(swDocs, "EXPORT_API {0} Plugin{1}(\r\n\t{2});",
                            methodInfo.ReturnType,
                            methodInfo.Name,
                            SplitLongLines(methodInfo.Args));
                    }

                    Output(swDocs, "");

                    Output(swDocs, "// Class Plugin", methodInfo.Name);

                    if (methodInfo.ReturnType == "void")
                    {
                        if (methodInfo.Args.Length < 20)
                        {
                            Output(swDocs, "ChromaAnimationAPI::{0}({1});",
                                methodInfo.Name,
                                methodInfo.Args);
                        }
                        else
                        {
                            Output(swDocs, "ChromaAnimationAPI::{0}(\r\n\t{1});",
                                methodInfo.Name,
                                SplitLongLines(methodInfo.Args));
                        }
                    }
                    else
                    {
                        if (methodInfo.Args.Length < 20)
                        {
                            Output(swDocs, "{0} result = ChromaAnimationAPI::{1}({2});",
                                methodInfo.ReturnType,
                                methodInfo.Name,
                                methodInfo.Args);
                        }
                        else
                        {
                            Output(swDocs, "{0} result = ChromaAnimationAPI::{1}(\r\n\t{2});",
                                methodInfo.ReturnType,
                                methodInfo.Name,
                                SplitLongLines(methodInfo.Args));
                        }
                    }

                    Output(swDocs, "```", methodInfo.Name);

                    Output(swDocs, "");
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

                Output(swSortInput, "#pragma region Source of autogenerated APIs and documentation");

                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(swSortInput, "\t/*");

                    if (!string.IsNullOrEmpty(methodInfo.Comments))
                    {
                        Output(swSortInput, "\t\t{0}", SplitLongComments(methodInfo.Comments, "\t\t"));
                    }

                    Output(swSortInput, "\t*/");

                    Output(swSortInput, "\tEXPORT_API {0} Plugin{1}({2});",
                        methodInfo.ReturnType,
                        methodInfo.Name,
                        methodInfo.Args);
                }

                Output(swSortInput, "#pragma endregion");

                return true;
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Failed to write sorted file!");
                return false;
            }
        }

        static bool WriteUnity(StreamWriter swUnity)
        {
            try
            {
                Console.WriteLine();

                Output(swUnity, "#region Public API Methods");

                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(swUnity, "\t/*");

                    if (!string.IsNullOrEmpty(methodInfo.Comments))
                    {
                        Output(swUnity, "\t\t{0}", SplitLongComments(methodInfo.Comments, "\t\t"));
                    }

                    Output(swUnity, "\t*/");

                    Output(swUnity, "\tpublic static {0} {1}({2})",
                        methodInfo.ReturnType,
                        methodInfo.Name,
                        methodInfo.Args);

                    Output(swUnity, "\t{0}", "{");
                    if (methodInfo.ReturnType == "void")
                    {
                        Output(swUnity, "\t\tPlugin{0}({1});",
                            methodInfo.Name,
                            methodInfo.Args);
                    }
                    else
                    {
                        Output(swUnity, "\t\treturn Plugin{0}({1});",
                            methodInfo.Name,
                            methodInfo.Args);
                    }
                    Output(swUnity, "\t{0}", "}");
                }

                Output(swUnity, "#endregion");

                Output(swUnity, "");

                Output(swUnity, "#region Private DLL Hooks");

                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(swUnity, "\t/*");

                    if (!string.IsNullOrEmpty(methodInfo.Comments))
                    {
                        Output(swUnity, "\t\t{0}", SplitLongComments(methodInfo.Comments, "\t\t"));
                    }

                    Output(swUnity, "\t*/");

                    Output(swUnity, "\t{0}", "[DllImport(DLL_NAME)]");

                    Output(swUnity, "\tprivate static extern {0} Plugin{1}({2});",
                        methodInfo.ReturnType,
                        methodInfo.Name,
                        methodInfo.Args);
                }

                Output(swUnity, "#endregion");

                return true;
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Failed to write unity!");
                return false;
            }
        }
    }
}
