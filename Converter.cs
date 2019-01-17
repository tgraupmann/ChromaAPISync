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

        public class MetaOverride
        {
            public string MethodName = string.Empty;
            public string ArgName = string.Empty;
            public string OverrideType = string.Empty;
            public string CastType = string.Empty;
        }

        private static readonly MetaOverride[] _sUnityOverrides =
        {
            new MetaOverride() { MethodName="GetMaxLeds", ArgName="device", OverrideType="Device1D", CastType="int"},
            new MetaOverride() { MethodName="GetMaxRow", ArgName="device", OverrideType="Device2D", CastType="int"},
            new MetaOverride() { MethodName="GetMaxColumn", ArgName="device", OverrideType="Device2D", CastType="int"},
        };

        private static bool GetArgsTypes(MetaMethodInfo methodInfo)
        {
            string[] parts = methodInfo.Args.Split(",".ToCharArray());
            for (int i = 0; i < parts.Length; ++i)
            {
                string part = parts[i].Trim();
                int indexName = GetIndexArgumentBeforeName(part);
                if (indexName > 0)
                {
                    string strType = part.Substring(0, indexName).Trim();
                    string name = part.Substring(indexName + 1).Trim();

                    MetaArgInfo info = new MetaArgInfo();
                    info.MethodInfo = methodInfo;
                    info.StrType = strType;
                    info.Name = name;
                    foreach (MetaOverride metaOverride in _sUnityOverrides)
                    {
                        if (info.MethodInfo.Name == metaOverride.MethodName &&
                        info.Name == metaOverride.ArgName)
                        {
                            info.OverrideType = metaOverride.OverrideType;
                            info.CastType = metaOverride.CastType;
                        }
                    }
                    methodInfo.DetailArgs.Add(info);
                }
            }
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

        private static string RemoveArgTypes(MetaMethodInfo methodInfo)
        {
            string[] parts = methodInfo.Args.Split(",".ToCharArray());
            for (int i = 0; i < parts.Length; ++i)
            {
                string part = parts[i].TrimEnd();
                int indexName = GetIndexArgumentBeforeName(part);
                if (indexName > 0)
                {
                    string name = part.Substring(indexName + 1);
                    MetaArgInfo argInfo = methodInfo.DetailArgs[i];
                    if (argInfo.StrType == "const char*" ||
                        argInfo.StrType == "char*")
                    {
                        string lpArg = string.Format("lp{0}", UppercaseFirstLetter(name));
                        name = lpArg;
                    }
                    if (!string.IsNullOrEmpty(argInfo.OverrideType))
                    {
                        name = string.Format("({0}){1}", argInfo.CastType, name);
                    }
                    if (i > 0)
                    {
                        name = " " + name;
                    }
                    parts[i] = name;
                }
            }
            return string.Join(",", parts);
        }

        private static int GetIndexArgumentBeforeName(string str)
        {
            int index = -1;
            int j = 0;
            foreach (char c in str)
            {
                if (c == '&' ||
                    c == '*' ||
                    char.IsWhiteSpace(c))
                {
                    index = j;
                }
                ++j;
            }
            return index;
        }

        private static string ChangeToManagedImportType(string strType)
        {
            string result = TrimArgType(strType);
            if (result == "int*")
            {
                result = "int[]";
            }
            else if (result == "const int*")
            {
                result = "int[]";
            }
            else if (result == "const char*")
            {
                result = "IntPtr";
            }
            else if (result == "RZRESULT")
            {
                result = "int";
            }
            else if (result == "ChromaSDK::ChromaLink::EFFECT_TYPE")
            {
                result = "int";
            }
            else if (result == "ChromaSDK::Headset::EFFECT_TYPE")
            {
                result = "int";
            }
            else if (result == "ChromaSDK::Keyboard::EFFECT_TYPE")
            {
                result = "int";
            }
            else if (result == "ChromaSDK::Keypad::EFFECT_TYPE")
            {
                result = "int";
            }
            else if (result == "ChromaSDK::Mouse::EFFECT_TYPE")
            {
                result = "int";
            }
            else if (result == "ChromaSDK::Mousepad::EFFECT_TYPE")
            {
                result = "int";
            }
            else if (result == "ChromaSDK::DEVICE_INFO_TYPE&")
            {
            }
            else if (result == "const ChromaSDK::FChromaSDKGuid&")
            {
                result = "System.Guid";
            }
            return result;
        }

        private static string ChangeToManagedType(string strType)
        {
            string result = TrimArgType(strType);
            if (result == "int*")
            {
                result = "int[]";
            }
            else if (result == "const int*")
            {
                result = "int[]";
            }
            else if (result == "const char*")
            {
                result = "string";
            }
            else if (result == "RZRESULT")
            {
                result = "int";
            }
            else if (result == "ChromaSDK::ChromaLink::EFFECT_TYPE")
            {
                result = "int";
            }
            else if (result == "ChromaSDK::Headset::EFFECT_TYPE")
            {
                result = "int";
            }
            else if (result == "ChromaSDK::Keyboard::EFFECT_TYPE")
            {
                result = "int";
            }
            else if (result == "ChromaSDK::Keypad::EFFECT_TYPE")
            {
                result = "int";
            }
            else if (result == "ChromaSDK::Mouse::EFFECT_TYPE")
            {
                result = "int";
            }
            else if (result == "ChromaSDK::Mousepad::EFFECT_TYPE")
            {
                result = "int";
            }
            else if (result == "ChromaSDK::DEVICE_INFO_TYPE&")
            {
            }
            else if (result == "const ChromaSDK::FChromaSDKGuid&")
            {
                result = "System.Guid";
            }
            return result;
        }

        private static string TrimArgType(string argType)
        {
            string result = "";
            bool hadWhitespace = false;
            foreach (char c in argType)
            {
                if (c == '&' ||
                    c == '*' ||
                    c == ':' ||
                    c == '_')
                {
                    result += c;
                }
                else if (char.IsLetterOrDigit(c))
                {
                    if (hadWhitespace)
                    {
                        hadWhitespace = false;
                        result += " ";
                    }
                    result += c;
                }
                else if (char.IsWhiteSpace(c))
                {
                    hadWhitespace = true;
                }
            }
            return result;
        }

        private static string ChangeArgsToManagedTypes(MetaMethodInfo methodInfo)
        {
            string[] parts = methodInfo.Args.Split(",".ToCharArray());
            for (int i = 0; i < parts.Length; ++i)
            {
                string part = parts[i].Trim();
                int indexName = GetIndexArgumentBeforeName(part);
                if (indexName > 0)
                {
                    string strType = part.Substring(0, indexName + 1).Trim();
                    strType = ChangeToManagedType(strType);
                    string name = part.Substring(indexName + 1).Trim();
                    MetaArgInfo argInfo = methodInfo.DetailArgs[i];
                    if (!string.IsNullOrEmpty(argInfo.OverrideType))
                    {
                        strType = argInfo.OverrideType;
                    }

                    if (i == 0)
                    {
                        parts[i] = strType + " " + name;
                    }
                    else
                    {
                        parts[i] = " " + strType + " " + name;

                    }
                }
            }
            return string.Join(",", parts);
        }

        private static string ChangeArgsToManagedImportTypes(string args)
        {
            string[] parts = args.Split(",".ToCharArray());
            for (int i = 0; i < parts.Length; ++i)
            {
                string part = parts[i].Trim();
                int indexName = GetIndexArgumentBeforeName(part);
                if (indexName > 0)
                {
                    string strType = ChangeToManagedImportType(part.Substring(0, indexName).Trim());
                    string name = part.Substring(indexName + 1).Trim();

                    if (i == 0)
                    {
                        parts[i] = strType + " " + name;
                    }
                    else
                    {
                        parts[i] = " " + strType + " " + name;

                    }
                }
            }
            return string.Join(",", parts);
        }
        
        class MetaArgInfo
        {
            public MetaMethodInfo MethodInfo;
            public string Name = string.Empty;
            public string StrType = string.Empty;
            public string CastType = string.Empty;
            public string OverrideType = string.Empty;
        }

        class MetaMethodInfo
        {
            public string Name = string.Empty;
            public string ReturnType = string.Empty;
            public string Tabs = string.Empty;
            public string Line = string.Empty;
            public string Args = string.Empty;
            public string Comments = string.Empty;
            public List<MetaArgInfo> DetailArgs = new List<MetaArgInfo>();
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

                            if (!GetArgsTypes(methodInfo))
                            {
                                continue;
                            }
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

        private static string UppercaseFirstLetter(string name)
        {
            if (name.Length < 2)
            {
                return name.ToUpper();
            }
            else
            {
                return string.Format("{0}{1}",
                    name.Substring(0, 1).ToUpper(),
                    name.Substring(1));
            }
        }

        private const string HEADER_UNITY =
@"using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;

namespace ChromaSDK
{
    public class ChromaAnimationAPI
    {
#if UNITY_3 || UNITY_3_0 || UNITY_3_1 || UNITY_3_2 || UNITY_3_3 || UNITY_3_4 || UNITY_3_5
        const string DLL_NAME = ""UnityNativeChromaSDK3"";

#else
        const string DLL_NAME = ""UnityNativeChromaSDK"";
#endif

        #region Data Structures

        public enum DeviceType
        {
            Invalid = -1,
            DE_1D = 0,
            DE_2D = 1,
            MAX = 2,
        }

        public enum Device
        {
            Invalid = -1,
            ChromaLink = 0,
            Headset = 1,
            Keyboard = 2,
            Keypad = 3,
            Mouse = 4,
            Mousepad = 5,
            MAX = 6,
        }

        public enum Device1D
        {
            Invalid = -1,
            ChromaLink = 0,
            Headset = 1,
            Mousepad = 2,
            MAX = 3,
        }

        public enum Device2D
        {
            Invalid = -1,
            Keyboard = 0,
            Keypad = 1,
            Mouse = 2,
            MAX = 3,
        }

        private static Dictionary<KeyCode, int> _sKeyMapping = null;

        public static int GetKeyboardRazerKey(KeyCode keyCode)
        {
            if (_sKeyMapping == null)
            {
                _sKeyMapping = new Dictionary<KeyCode, int>();
                _sKeyMapping[KeyCode.Backspace] = (int)Keyboard.RZKEY.RZKEY_BACKSPACE;
                _sKeyMapping[KeyCode.Tab] = (int)Keyboard.RZKEY.RZKEY_TAB;
                _sKeyMapping[KeyCode.Return] = (int)Keyboard.RZKEY.RZKEY_ENTER;
                _sKeyMapping[KeyCode.Pause] = (int)Keyboard.RZKEY.RZKEY_PAUSE;
                _sKeyMapping[KeyCode.Escape] = (int)Keyboard.RZKEY.RZKEY_ESC;
                _sKeyMapping[KeyCode.Space] = (int)Keyboard.RZKEY.RZKEY_SPACE;
                _sKeyMapping[KeyCode.Exclaim] = (int)Keyboard.RZKEY.RZKEY_1;
                _sKeyMapping[KeyCode.DoubleQuote] = (int)Keyboard.RZKEY.RZKEY_OEM_8;
                _sKeyMapping[KeyCode.Hash] = (int)Keyboard.RZKEY.RZKEY_3;
                _sKeyMapping[KeyCode.Dollar] = (int)Keyboard.RZKEY.RZKEY_4;
                _sKeyMapping[KeyCode.Ampersand] = (int)Keyboard.RZKEY.RZKEY_7;
                _sKeyMapping[KeyCode.Quote] = (int)Keyboard.RZKEY.RZKEY_OEM_8;
                _sKeyMapping[KeyCode.LeftParen] = (int)Keyboard.RZKEY.RZKEY_9;
                _sKeyMapping[KeyCode.RightParen] = (int)Keyboard.RZKEY.RZKEY_0;
                _sKeyMapping[KeyCode.Asterisk] = (int)Keyboard.RZKEY.RZKEY_8;
                _sKeyMapping[KeyCode.Plus] = (int)Keyboard.RZKEY.RZKEY_OEM_3;
                _sKeyMapping[KeyCode.Comma] = (int)Keyboard.RZKEY.RZKEY_OEM_9;
                _sKeyMapping[KeyCode.Minus] = (int)Keyboard.RZKEY.RZKEY_OEM_2;
                _sKeyMapping[KeyCode.Period] = (int)Keyboard.RZKEY.RZKEY_OEM_10;
                _sKeyMapping[KeyCode.Slash] = (int)Keyboard.RZKEY.RZKEY_OEM_11;
                _sKeyMapping[KeyCode.Alpha0] = (int)Keyboard.RZKEY.RZKEY_0;
                _sKeyMapping[KeyCode.Alpha1] = (int)Keyboard.RZKEY.RZKEY_1;
                _sKeyMapping[KeyCode.Alpha2] = (int)Keyboard.RZKEY.RZKEY_2;
                _sKeyMapping[KeyCode.Alpha3] = (int)Keyboard.RZKEY.RZKEY_3;
                _sKeyMapping[KeyCode.Alpha4] = (int)Keyboard.RZKEY.RZKEY_4;
                _sKeyMapping[KeyCode.Alpha5] = (int)Keyboard.RZKEY.RZKEY_5;
                _sKeyMapping[KeyCode.Alpha6] = (int)Keyboard.RZKEY.RZKEY_6;
                _sKeyMapping[KeyCode.Alpha7] = (int)Keyboard.RZKEY.RZKEY_7;
                _sKeyMapping[KeyCode.Alpha8] = (int)Keyboard.RZKEY.RZKEY_8;
                _sKeyMapping[KeyCode.Alpha9] = (int)Keyboard.RZKEY.RZKEY_9;
                _sKeyMapping[KeyCode.Colon] = (int)Keyboard.RZKEY.RZKEY_OEM_7;
                _sKeyMapping[KeyCode.Semicolon] = (int)Keyboard.RZKEY.RZKEY_OEM_7;
                _sKeyMapping[KeyCode.Less] = (int)Keyboard.RZKEY.RZKEY_OEM_9;
                _sKeyMapping[KeyCode.Equals] = (int)Keyboard.RZKEY.RZKEY_OEM_3;
                _sKeyMapping[KeyCode.Greater] = (int)Keyboard.RZKEY.RZKEY_OEM_10;
                _sKeyMapping[KeyCode.Question] = (int)Keyboard.RZKEY.RZKEY_OEM_11;
                _sKeyMapping[KeyCode.At] = (int)Keyboard.RZKEY.RZKEY_2;
                _sKeyMapping[KeyCode.LeftBracket] = (int)Keyboard.RZKEY.RZKEY_OEM_4;
                _sKeyMapping[KeyCode.Backslash] = (int)Keyboard.RZKEY.RZKEY_OEM_6;
                _sKeyMapping[KeyCode.RightBracket] = (int)Keyboard.RZKEY.RZKEY_OEM_5;
                _sKeyMapping[KeyCode.Caret] = (int)Keyboard.RZKEY.RZKEY_6;
                _sKeyMapping[KeyCode.Underscore] = (int)Keyboard.RZKEY.RZKEY_OEM_2;
                _sKeyMapping[KeyCode.BackQuote] = (int)Keyboard.RZKEY.RZKEY_OEM_1;
                _sKeyMapping[KeyCode.A] = (int)Keyboard.RZKEY.RZKEY_A;
                _sKeyMapping[KeyCode.B] = (int)Keyboard.RZKEY.RZKEY_B;
                _sKeyMapping[KeyCode.C] = (int)Keyboard.RZKEY.RZKEY_C;
                _sKeyMapping[KeyCode.D] = (int)Keyboard.RZKEY.RZKEY_D;
                _sKeyMapping[KeyCode.E] = (int)Keyboard.RZKEY.RZKEY_E;
                _sKeyMapping[KeyCode.F] = (int)Keyboard.RZKEY.RZKEY_F;
                _sKeyMapping[KeyCode.G] = (int)Keyboard.RZKEY.RZKEY_G;
                _sKeyMapping[KeyCode.H] = (int)Keyboard.RZKEY.RZKEY_H;
                _sKeyMapping[KeyCode.I] = (int)Keyboard.RZKEY.RZKEY_I;
                _sKeyMapping[KeyCode.J] = (int)Keyboard.RZKEY.RZKEY_J;
                _sKeyMapping[KeyCode.K] = (int)Keyboard.RZKEY.RZKEY_K;
                _sKeyMapping[KeyCode.L] = (int)Keyboard.RZKEY.RZKEY_L;
                _sKeyMapping[KeyCode.M] = (int)Keyboard.RZKEY.RZKEY_M;
                _sKeyMapping[KeyCode.N] = (int)Keyboard.RZKEY.RZKEY_N;
                _sKeyMapping[KeyCode.O] = (int)Keyboard.RZKEY.RZKEY_O;
                _sKeyMapping[KeyCode.P] = (int)Keyboard.RZKEY.RZKEY_P;
                _sKeyMapping[KeyCode.Q] = (int)Keyboard.RZKEY.RZKEY_Q;
                _sKeyMapping[KeyCode.R] = (int)Keyboard.RZKEY.RZKEY_R;
                _sKeyMapping[KeyCode.S] = (int)Keyboard.RZKEY.RZKEY_S;
                _sKeyMapping[KeyCode.T] = (int)Keyboard.RZKEY.RZKEY_T;
                _sKeyMapping[KeyCode.U] = (int)Keyboard.RZKEY.RZKEY_U;
                _sKeyMapping[KeyCode.V] = (int)Keyboard.RZKEY.RZKEY_V;
                _sKeyMapping[KeyCode.W] = (int)Keyboard.RZKEY.RZKEY_W;
                _sKeyMapping[KeyCode.X] = (int)Keyboard.RZKEY.RZKEY_X;
                _sKeyMapping[KeyCode.Y] = (int)Keyboard.RZKEY.RZKEY_Y;
                _sKeyMapping[KeyCode.Z] = (int)Keyboard.RZKEY.RZKEY_Z;
                _sKeyMapping[KeyCode.Delete] = (int)Keyboard.RZKEY.RZKEY_DELETE;
                _sKeyMapping[KeyCode.Keypad0] = (int)Keyboard.RZKEY.RZKEY_NUMPAD0;
                _sKeyMapping[KeyCode.Keypad1] = (int)Keyboard.RZKEY.RZKEY_NUMPAD1;
                _sKeyMapping[KeyCode.Keypad2] = (int)Keyboard.RZKEY.RZKEY_NUMPAD2;
                _sKeyMapping[KeyCode.Keypad3] = (int)Keyboard.RZKEY.RZKEY_NUMPAD3;
                _sKeyMapping[KeyCode.Keypad4] = (int)Keyboard.RZKEY.RZKEY_NUMPAD4;
                _sKeyMapping[KeyCode.Keypad5] = (int)Keyboard.RZKEY.RZKEY_NUMPAD5;
                _sKeyMapping[KeyCode.Keypad6] = (int)Keyboard.RZKEY.RZKEY_NUMPAD6;
                _sKeyMapping[KeyCode.Keypad7] = (int)Keyboard.RZKEY.RZKEY_NUMPAD7;
                _sKeyMapping[KeyCode.Keypad8] = (int)Keyboard.RZKEY.RZKEY_NUMPAD8;
                _sKeyMapping[KeyCode.Keypad9] = (int)Keyboard.RZKEY.RZKEY_NUMPAD9;
                _sKeyMapping[KeyCode.KeypadPeriod] = (int)Keyboard.RZKEY.RZKEY_NUMPAD_DECIMAL;
                _sKeyMapping[KeyCode.KeypadDivide] = (int)Keyboard.RZKEY.RZKEY_NUMPAD_DIVIDE;
                _sKeyMapping[KeyCode.KeypadMultiply] = (int)Keyboard.RZKEY.RZKEY_NUMPAD_MULTIPLY;
                _sKeyMapping[KeyCode.KeypadMinus] = (int)Keyboard.RZKEY.RZKEY_NUMPAD_SUBTRACT;
                _sKeyMapping[KeyCode.KeypadPlus] = (int)Keyboard.RZKEY.RZKEY_NUMPAD_ADD;
                _sKeyMapping[KeyCode.KeypadEnter] = (int)Keyboard.RZKEY.RZKEY_NUMPAD_ENTER;
                _sKeyMapping[KeyCode.UpArrow] = (int)Keyboard.RZKEY.RZKEY_UP;
                _sKeyMapping[KeyCode.DownArrow] = (int)Keyboard.RZKEY.RZKEY_DOWN;
                _sKeyMapping[KeyCode.RightArrow] = (int)Keyboard.RZKEY.RZKEY_RIGHT;
                _sKeyMapping[KeyCode.LeftArrow] = (int)Keyboard.RZKEY.RZKEY_LEFT;
                _sKeyMapping[KeyCode.Insert] = (int)Keyboard.RZKEY.RZKEY_INSERT;
                _sKeyMapping[KeyCode.Home] = (int)Keyboard.RZKEY.RZKEY_HOME;
                _sKeyMapping[KeyCode.End] = (int)Keyboard.RZKEY.RZKEY_END;
                _sKeyMapping[KeyCode.PageUp] = (int)Keyboard.RZKEY.RZKEY_PAGEUP;
                _sKeyMapping[KeyCode.PageDown] = (int)Keyboard.RZKEY.RZKEY_PAGEDOWN;
                _sKeyMapping[KeyCode.F1] = (int)Keyboard.RZKEY.RZKEY_F1;
                _sKeyMapping[KeyCode.F2] = (int)Keyboard.RZKEY.RZKEY_F2;
                _sKeyMapping[KeyCode.F3] = (int)Keyboard.RZKEY.RZKEY_F3;
                _sKeyMapping[KeyCode.F4] = (int)Keyboard.RZKEY.RZKEY_F4;
                _sKeyMapping[KeyCode.F5] = (int)Keyboard.RZKEY.RZKEY_F5;
                _sKeyMapping[KeyCode.F6] = (int)Keyboard.RZKEY.RZKEY_F6;
                _sKeyMapping[KeyCode.F7] = (int)Keyboard.RZKEY.RZKEY_F7;
                _sKeyMapping[KeyCode.F8] = (int)Keyboard.RZKEY.RZKEY_F8;
                _sKeyMapping[KeyCode.F9] = (int)Keyboard.RZKEY.RZKEY_F9;
                _sKeyMapping[KeyCode.F10] = (int)Keyboard.RZKEY.RZKEY_F10;
                _sKeyMapping[KeyCode.F11] = (int)Keyboard.RZKEY.RZKEY_F11;
                _sKeyMapping[KeyCode.F12] = (int)Keyboard.RZKEY.RZKEY_F12;
                _sKeyMapping[KeyCode.Numlock] = (int)Keyboard.RZKEY.RZKEY_NUMLOCK;
                _sKeyMapping[KeyCode.CapsLock] = (int)Keyboard.RZKEY.RZKEY_CAPSLOCK;
                _sKeyMapping[KeyCode.ScrollLock] = (int)Keyboard.RZKEY.RZKEY_SCROLL;
                _sKeyMapping[KeyCode.RightShift] = (int)Keyboard.RZKEY.RZKEY_RSHIFT;
                _sKeyMapping[KeyCode.LeftShift] = (int)Keyboard.RZKEY.RZKEY_LSHIFT;
                _sKeyMapping[KeyCode.RightControl] = (int)Keyboard.RZKEY.RZKEY_RCTRL;
                _sKeyMapping[KeyCode.LeftControl] = (int)Keyboard.RZKEY.RZKEY_LCTRL;
                _sKeyMapping[KeyCode.RightAlt] = (int)Keyboard.RZKEY.RZKEY_RALT;
                _sKeyMapping[KeyCode.LeftAlt] = (int)Keyboard.RZKEY.RZKEY_LALT;
                _sKeyMapping[KeyCode.LeftWindows] = (int)Keyboard.RZKEY.RZKEY_LWIN;
                _sKeyMapping[KeyCode.Print] = (int)Keyboard.RZKEY.RZKEY_PRINTSCREEN;
                _sKeyMapping[KeyCode.SysReq] = (int)Keyboard.RZKEY.RZKEY_PRINTSCREEN;
                _sKeyMapping[KeyCode.Break] = (int)Keyboard.RZKEY.RZKEY_PAUSE;
                _sKeyMapping[KeyCode.Menu] = (int)Keyboard.RZKEY.RZKEY_RMENU;
            }
            if (_sKeyMapping.ContainsKey(keyCode))
            {
                return _sKeyMapping[keyCode];
            }
            else
            {
                return (int)Keyboard.RZKEY.RZKEY_INVALID;
            }
        }

        #endregion

        #region Helpers (handle path conversions)

        /// <summary>
        /// Helper to convert string to IntPtr
        /// </summary>
        /// <param name=""path""></param>
        /// <returns></returns>
        private static IntPtr GetIntPtr(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return IntPtr.Zero;
            }
            FileInfo fi = new FileInfo(path);
            byte[] array = ASCIIEncoding.ASCII.GetBytes(fi.FullName + ""\0"");
            IntPtr lpData = Marshal.AllocHGlobal(array.Length);
            Marshal.Copy(array, 0, lpData, array.Length);
            return lpData;
        }

        /// <summary>
        /// Helper to recycle the IntPtr
        /// </summary>
        /// <param name=""lpData""></param>
        private static void FreeIntPtr(IntPtr lpData)
        {
            if (lpData != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(lpData);
            }
        }

        /// <summary>
        /// Get the streaming path for the animation given the relative path from Assets/StreamingAssets
        /// </summary>
        /// <param name=""animation""></param>
        /// <returns></returns>
        public static string GetStreamingPath(string animation)
        {
            return string.Format(""{0}/{1}"", Application.streamingAssetsPath, animation);
        }
#endregion";

        private const string FOOTER_UNITY =
@"  }
}
";

        static bool WriteUnity(StreamWriter swUnity)
        {
            try
            {
                Output(swUnity, "{0}", HEADER_UNITY);

                Output(swUnity, "");

                Output(swUnity, "\t\t#region Public API Methods");

                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(swUnity, "\t\t{0}", "/// <summary>");

                    if (!string.IsNullOrEmpty(methodInfo.Comments))
                    {
                        Output(swUnity, "\t\t/// {0}", SplitLongComments(methodInfo.Comments, "\t\t/// "));
                    }

                    Output(swUnity, "\t\t{0}", "/// </summary>");

                    Output(swUnity, "\t\tpublic static {0} {1}({2})",
                        ChangeToManagedType(methodInfo.ReturnType),
                        methodInfo.Name,
                        ChangeArgsToManagedTypes(methodInfo));

                    Output(swUnity, "\t\t{0}", "{");
                    foreach (MetaArgInfo argInfo in methodInfo.DetailArgs)
                    {
                        if (argInfo.StrType == "const char*" ||
                            argInfo.StrType == "char*")
                        {
                            string pathArg = string.Format("path{0}", UppercaseFirstLetter(argInfo.Name));
                            Output(swUnity, "\t\t\tstring {0} = GetStreamingPath({1});",
                                pathArg,
                                argInfo.Name);
  
                            string lpArg = string.Format("lp{0}", UppercaseFirstLetter(argInfo.Name));
                            Output(swUnity, "\t\t\tIntPtr {0} = GetIntPtr({1});",
                                lpArg,
                                pathArg);

                        }
                    }
                    if (methodInfo.ReturnType == "void")
                    {
                        Output(swUnity, "\t\t\tPlugin{0}({1});",
                            methodInfo.Name,
                            RemoveArgTypes(methodInfo));
                    }
                    else
                    {
                        Output(swUnity, "\t\t\t{0} result = Plugin{1}({2});",
                            ChangeToManagedType(methodInfo.ReturnType),
                            methodInfo.Name,
                            RemoveArgTypes(methodInfo));
                    }

                    foreach (MetaArgInfo argInfo in methodInfo.DetailArgs)
                    {
                        if (argInfo.StrType == "const char*" ||
                            argInfo.StrType == "char*")
                        {
                            string lpArg = string.Format("lp{0}", UppercaseFirstLetter(argInfo.Name));
                            Output(swUnity, "\t\t\tFreeIntPtr({0});",
                                lpArg);

                        }
                    }

                    if (methodInfo.ReturnType != "void")
                    {
                        Output(swUnity, "\t\t\treturn result;");
                    }

                    Output(swUnity, "\t\t{0}", "}");
                }

                Output(swUnity, "\t\t#endregion");

                Output(swUnity, "");

                Output(swUnity, "\t\t#region Private DLL Hooks");

                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(swUnity, "\t\t{0}", "/// <summary>");

                    if (!string.IsNullOrEmpty(methodInfo.Comments))
                    {
                        Output(swUnity, "\t\t/// {0}", SplitLongComments(methodInfo.Comments, "\t\t/// "));
                    }

                    Output(swUnity, "\t\t/// EXPORT_API {0} Plugin{1}({2});",
                        methodInfo.ReturnType,
                        methodInfo.Name,
                        methodInfo.Args);

                    Output(swUnity, "\t\t{0}", "/// </summary>");

                    Output(swUnity, "\t\t{0}", "[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]");

                    Output(swUnity, "\t\tprivate static extern {0} Plugin{1}({2});",
                        ChangeToManagedImportType(methodInfo.ReturnType),
                        methodInfo.Name,
                        ChangeArgsToManagedImportTypes(methodInfo.Args));
                }

                Output(swUnity, "\t\t#endregion");

                Output(swUnity, "{0}", FOOTER_UNITY);

                swUnity.Flush();
                swUnity.Close();

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
