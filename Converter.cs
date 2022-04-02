using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ChromaAPISync
{
    class Converter
    {
        // Collect information from stdafx.h
        private static SortedList<string, MetaMethodInfo> _sMethods = new SortedList<string, MetaMethodInfo>();

        private static readonly MetaOverride[] _sUnityOverrides =
        {
            new MetaOverride() { MethodName="GetMaxLeds", ArgName="device", OverrideType="Device1D", CastType="int"},
            new MetaOverride() { MethodName="GetMaxRow", ArgName="device", OverrideType="Device2D", CastType="int"},
            new MetaOverride() { MethodName="GetMaxColumn", ArgName="device", OverrideType="Device2D", CastType="int"},
            new MetaOverride() { MethodName="CoreCreateEffect", ArgName="Effect", OverrideType="EFFECT_TYPE", CastType="int"},
            new MetaOverride() { MethodName="CoreCreateEffect", ArgName="pEffectId", UseOut=true},
            new MetaOverride() { MethodName="CoreCreateChromaLinkEffect", ArgName="pEffectId", UseOut=true},
            new MetaOverride() { MethodName="CoreCreateHeadsetEffect", ArgName="pEffectId", UseOut=true},
            new MetaOverride() { MethodName="CoreCreateKeyboardEffect", ArgName="pEffectId", UseOut=true},
            new MetaOverride() { MethodName="CoreCreateKeypadEffect", ArgName="pEffectId", UseOut=true},
            new MetaOverride() { MethodName="CoreCreateMouseEffect", ArgName="pEffectId", UseOut=true},
            new MetaOverride() { MethodName="CoreCreateMousepadEffect", ArgName="pEffectId", UseOut=true},
            new MetaOverride() { MethodName="CoreQueryDevice", ArgName="DeviceInfo", OverrideType="out DEVICE_INFO_TYPE", UseOut=true},
            new MetaOverride() { MethodName="CreateEffect", ArgName="effect", OverrideType="EFFECT_TYPE", CastType="int"},
            new MetaOverride() { MethodName="CreateEffect", ArgName="effectId", OverrideType="out FChromaSDKGuid", UseOut=true},
            new MetaOverride() { MethodName="GetFrame", ArgName="duration", OverrideType="out float", UseOut=true},
            new MetaOverride() { MethodName="CoreInitSDK", ArgName="AppInfo", OverrideType="ref ChromaSDK.APPINFOTYPE", UseRef=true},
            new MetaOverride() { MethodName="InitSDK", ArgName="AppInfo", OverrideType="ref ChromaSDK.APPINFOTYPE", UseRef=true},
        };

        #region Data

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

        public class MetaOverride
        {
            public string MethodName = string.Empty;
            public string ArgName = string.Empty;
            public string OverrideType = string.Empty;
            public string CastType = string.Empty;
            public bool UseRef = false;
            public bool UseOut = false;
        }

        class MetaArgInfo
        {
            public MetaMethodInfo MethodInfo;
            public MetaOverride OverrideInfo = null;
            public string Name = string.Empty;
            public string StrType = string.Empty;
        }

        #endregion

        public static void ConvertExportsToClass(string input,
            string outputCppHeader, string outputCppImplementation,
            string outputCppSortInput,
            string outputCppDocs,
            string outputCSharp,
            string outputCSharpDocs,
            string outputUnity,
            string outputUnityDocs,
            string outputVB,
            string outputVBDocs,
            string outputJavaInterface,
            string outputJavaSDK,
            string outputGodotHeader,
            string outputGodotImplementation,
            string outputCTFHeader,
            string outputCTFImplementation)
        {
            OpenClassFiles(input,
                outputCppSortInput,
                outputCppHeader, outputCppImplementation,
                outputCppDocs,
                outputCSharp,
                outputCSharpDocs,
                outputUnity,
                outputUnityDocs,
                outputVB,
                outputVBDocs,
                outputJavaInterface,
                outputJavaSDK,
                outputGodotHeader,
                outputGodotImplementation,
                outputCTFHeader,
                outputCTFImplementation);
        }

        private static void Output(StreamWriter sw, string msg, params object[] args)
        {
            Console.WriteLine(msg, args);
            sw.WriteLine(msg, args);
        }

        private static void OpenClassFiles(string input,
            string fileCppSortInput,
            string fileCppHeader, string fileCppImplementation,
            string fileCppDocs,
            string fileCSharp,
            string fileCSharpDocs,
            string fileUnity,
            string fileUnityDocs,
            string fileVB,
            string fileVBDocs,
            string fileJavaInterface, string fileJavaSDK,
            string fileGodotHeader, string fileGodotImplementation,
            string fileCTFHeader, string fileCTFImplementation)
        {
            if (File.Exists(input))
            {
                if (!ProcessStdafx(input))
                {
                    return;
                }
            }

            #region First

            if (File.Exists(fileCppHeader))
            {
                File.Delete(fileCppHeader);
            }
            using (FileStream fsCppHeader = File.Open(fileCppHeader, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter swHeader = new StreamWriter(fsCppHeader))
                {
                    if (!WriteHeader(swHeader))
                    {
                        return;
                    }
                }
            }

            if (File.Exists(fileCppImplementation))
            {
                File.Delete(fileCppImplementation);
            }
            using (FileStream fsImplementation = File.Open(fileCppImplementation, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter swImplementation = new StreamWriter(fsImplementation))
                {
                    if (!WriteImplementation(swImplementation))
                    {
                        return;
                    }
                }
            }

            if (File.Exists(fileCppDocs))
            {
                File.Delete(fileCppDocs);
            }
            using (FileStream fsCppDocs = File.Open(fileCppDocs, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter swDocs = new StreamWriter(fsCppDocs))
                {
                    if (!WriteDocs(swDocs))
                    {
                        return;
                    }
                }
            }

            #endregion

            #region Sort C++ Input

            if (File.Exists(fileCppSortInput))
            {
                File.Delete(fileCppSortInput);
            }
            using (FileStream fsSortInput = File.Open(fileCppSortInput, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter swSortInput = new StreamWriter(fsSortInput))
                {
                    if (!WriteSortInput(swSortInput))
                    {
                        return;
                    }
                }
            }

            #endregion Sort C++ Input

            #region VB

            if (!Directory.Exists(Path.GetDirectoryName(fileVB)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(fileVB));
            }
            if (File.Exists(fileVB))
            {
                File.Delete(fileVB);
            }
            using (FileStream fsVB = File.Open(fileVB, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter swVB = new StreamWriter(fsVB))
                {
                    if (!WriteVB(swVB))
                    {
                        return;
                    }
                }
            }

            if (File.Exists(fileVBDocs))
            {
                File.Delete(fileVBDocs);
            }
            using (FileStream fsVBDocs = File.Open(fileVBDocs, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter swVBDocs = new StreamWriter(fsVBDocs))
                {
                    if (!WriteCSharpDocs(swVBDocs, "ChromaAnimationAPI"))
                    {
                        return;
                    }
                }
            }

            #endregion VB

            //return; // DEBUG SKIP OTHERS

            #region C# and Unity

            if (!Directory.Exists(Path.GetDirectoryName(fileCSharp)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(fileCSharp));
            }
            if (File.Exists(fileCSharp))
            {
                File.Delete(fileCSharp);
            }
            using (FileStream fsCSharp = File.Open(fileCSharp, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter swCSharp = new StreamWriter(fsCSharp))
                {
                    if (!WriteCSharp(swCSharp))
                    {
                        return;
                    }
                }
            }

            if (File.Exists(fileCSharpDocs))
            {
                File.Delete(fileCSharpDocs);
            }
            using (FileStream fsCSharpDocs = File.Open(fileCSharpDocs, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter swCSharpDocs = new StreamWriter(fsCSharpDocs))
                {
                    if (!WriteCSharpDocs(swCSharpDocs, "ChromaAnimationAPI"))
                    {
                        return;
                    }
                }
            }

            if (!Directory.Exists(Path.GetDirectoryName(fileUnity)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(fileUnity));
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

            if (File.Exists(fileUnityDocs))
            {
                File.Delete(fileUnityDocs);
            }
            using (FileStream fsUnityDocs = File.Open(fileUnityDocs, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter swUnityDocs = new StreamWriter(fsUnityDocs))
                {
                    if (!WriteCSharpDocs(swUnityDocs, "UnityNativeChromaSDK"))
                    {
                        return;
                    }
                }
            }

            #endregion C# and Unity

            #region ClickTeamFusion

            if (File.Exists(fileCTFHeader))
            {
                File.Delete(fileCTFHeader);
            }
            using (FileStream fsCTFHeader = File.Open(fileCTFHeader, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter swCTFHeader = new StreamWriter(fsCTFHeader))
                {
                    if (!WriteCTFHeader(swCTFHeader))
                    {
                        return;
                    }
                }
            }

            if (File.Exists(fileCTFImplementation))
            {
                File.Delete(fileCTFImplementation);
            }
            using (FileStream fsCTFImplementation = File.Open(fileCTFImplementation, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter swCTFImplementation = new StreamWriter(fsCTFImplementation))
                {
                    if (!WriteCTFImplementation(swCTFImplementation))
                    {
                        return;
                    }
                }
            }

            #endregion ClickTeamFusion

            #region GoDot

            if (File.Exists(fileGodotHeader))
            {
                File.Delete(fileGodotHeader);
            }
            using (FileStream fsGodotHeader = File.Open(fileGodotHeader, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter swGodotHeader = new StreamWriter(fsGodotHeader))
                {
                    if (!WriteGodotHeader(swGodotHeader))
                    {
                        return;
                    }
                }
            }

            if (File.Exists(fileGodotImplementation))
            {
                File.Delete(fileGodotImplementation);
            }
            using (FileStream fsGodotImplementation = File.Open(fileGodotImplementation, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter swGodotImplementation = new StreamWriter(fsGodotImplementation))
                {
                    if (!WriteGodotImplementation(swGodotImplementation))
                    {
                        return;
                    }
                }
            }

            #endregion GoDot

            #region Java

            if (File.Exists(fileJavaInterface))
            {
                File.Delete(fileJavaInterface);
            }
            using (FileStream fsJava = File.Open(fileJavaInterface, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter swJava = new StreamWriter(fsJava))
                {
                    if (!WriteJavaInterface(swJava))
                    {
                        return;
                    }
                }
            }

            if (File.Exists(fileJavaSDK))
            {
                File.Delete(fileJavaSDK);
            }
            using (FileStream fsJava = File.Open(fileJavaSDK, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter swJava = new StreamWriter(fsJava))
                {
                    if (!WriteJavaSDK(swJava))
                    {
                        return;
                    }
                }
            }

            #endregion Java

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
                            info.OverrideInfo = metaOverride;
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
                    if (argInfo.StrType == "char*" ||
                        argInfo.StrType == "const char*" ||
                        argInfo.StrType == "const wchar_t*")
                    {
                        string lpArg = string.Format("lp_{0}", UppercaseFirstLetter(name));
                        name = lpArg;
                    }
                    else if (argInfo.StrType == "unsigned char*")
                    {
                        name = string.Format("out {0}", name);
                    }
                    if (null != argInfo.OverrideInfo)
                    {
                        if (argInfo.OverrideInfo.UseRef)
                        {
                            name = "ref " + LowercaseFirstLetter(name);
                        }
                        else if (argInfo.OverrideInfo.UseOut)
                        {
                            name = "out " + LowercaseFirstLetter(name);
                        }
                        else if (!string.IsNullOrEmpty(argInfo.OverrideInfo.OverrideType))
                        {
                            name = LowercaseFirstLetter(string.Format("{0}{1}{2}{3}",
                                string.IsNullOrEmpty(argInfo.OverrideInfo.CastType) ? "" : "(",
                                argInfo.OverrideInfo.CastType,
                                string.IsNullOrEmpty(argInfo.OverrideInfo.CastType) ? "" : ")",
                                LowercaseFirstLetter(name)));
                        }
                    }
                    if (i > 0)
                    {
                        name = " " + LowercaseFirstLetter(name);
                    }
                    parts[i] = LowercaseFirstLetter(name);
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

        private static string ChangeToManagedImportType(MetaMethodInfo methodInfo, string strType)
        {
            // this is for private methods
            string result = TrimArgType(strType);
            if (result == "const int")
            {
                result = "int";
            }
            else if (result == "int*")
            {
                result = "int[]";
            }
            else if (result == "const byte*")
            {
                result = "byte[]";
            }
            else if (result == "const int*")
            {
                result = "int[]";
            }
            else if (result == "const char*")
            {
                result = "IntPtr";
            }
            else if (result == "const wchar_t*")
            {
                result = "IntPtr";
            }
            else if (result == "char*")
            {
                result = "IntPtr";
            }
            else if (result == "unsigned char*")
            {
                result = "out byte";
            }
            else if (result == "float*")
            {
                result = "out float";
            }
            else if (result == "unsigned long long")
            {
                result = "ulong";
            }
            else if (result == "RZRESULT")
            {
                result = "int";
            }
            else if (result == "ChromaSDK::EFFECT_TYPE")
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
                result = "out DEVICE_INFO_TYPE";
            }
            else if (result == "const ChromaSDK::FChromaSDKGuid&")
            {
                result = "Guid";
            }
            else if (result == "ChromaSDK::FChromaSDKGuid*")
            {
                result = "out FChromaSDKGuid";
            }
            else if (result == "RZDEVICEID")
            {
                result = "Guid";
            }
            else if (result == "RZEFFECTID")
            {
                result = "Guid";
            }
            else if (result == "RZEFFECTID*")
            {
                result = "out Guid";
            }
            else if (result == "PRZPARAM")
            {
                result = "IntPtr";
            }
            else if (result == "DebugLogPtr")
            {
                result = "IntPtr";
            }
            else if (result == "ChromaSDK::APPINFOTYPE*")
            {
                result = "ref ChromaSDK.APPINFOTYPE";
            }
            else if (result == "ChromaSDK::Stream::StreamStatusType")
            {
                result = "ChromaSDK.Stream.StreamStatusType";
            }
            return result;
        }

        private static string ChangeToGodotVariantType(MetaMethodInfo methodInfo, string strType)
        {
            // this is for private methods
            string result = TrimArgType(strType);
            if (result == "const char*")
            {
                result = "String";
            }
            else if (result == "const int*")
            {
                result = "Array";
            }
            return result;
        }

        private static string ChangeToManagedType(MetaMethodInfo methodInfo, string strType)
        {
            // this is for public methods
            string result = TrimArgType(strType);
            if (result == "const int")
            {
                result = "int";
            }
            else if (result == "int*")
            {
                result = "int[]";
            }
            else if (result == "const byte*")
            {
                result = "byte[]";
            }
            else if (result == "const int*")
            {
                result = "int[]";
            }
            else if (result == "const char*")
            {
                result = "string";
            }
            else if (result == "char*")
            {
                result = "ref string";
            }
            else if (result == "unsigned char*")
            {
                result = "out byte";
            }
            else if (result == "const wchar_t*")
            {
                result = "string";
            }
            else if (result == "unsigned long long")
            {
                result = "ulong";
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
            else if (result == "const ChromaSDK::FChromaSDKGuid&")
            {
                result = "Guid";
            }
            else if (result == "RZDEVICEID")
            {
                result = "Guid";
            }
            else if (result == "RZEFFECTID")
            {
                result = "Guid";
            }
            else if (result == "RZEFFECTID*")
            {
                result = "out Guid";
            }
            else if (result == "PRZPARAM")
            {
                result = "IntPtr";
            }
            else if (result == "DebugLogPtr")
            {
                result = "IntPtr";
            }
            else if (result == "ChromaSDK::APPINFOTYPE*")
            {
                result = "ref ChromaSDK.APPINFOTYPE";
            }
            else if (result == "ChromaSDK::Stream::StreamStatusType")
            {
                return "ChromaSDK.Stream.StreamStatusType";
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
                    strType = ChangeToManagedType(methodInfo, strType);
                    string name = part.Substring(indexName + 1).Trim();
                    MetaArgInfo argInfo = methodInfo.DetailArgs[i];
                    if (null != argInfo.OverrideInfo &&
                        !string.IsNullOrEmpty(argInfo.OverrideInfo.OverrideType))
                    {
                        strType = argInfo.OverrideInfo.OverrideType;
                    }

                    if (i == 0)
                    {
                        parts[i] = strType + " " + LowercaseFirstLetter(name);
                    }
                    else
                    {
                        parts[i] = " " + strType + " " + LowercaseFirstLetter(name);

                    }
                }
            }
            return string.Join(",", parts);
        }

        private static string ChangeArgsToManagedImportTypes(MetaMethodInfo methodInfo, string args)
        {
            string[] parts = args.Split(",".ToCharArray());
            for (int i = 0; i < parts.Length; ++i)
            {
                string part = parts[i].Trim();
                int indexName = GetIndexArgumentBeforeName(part);
                if (indexName > 0)
                {
                    string strType = ChangeToManagedImportType(methodInfo, part.Substring(0, indexName+1).Trim());
                    string name = part.Substring(indexName + 1).Trim();

                    if (i == 0)
                    {
                        parts[i] = strType + " " + LowercaseFirstLetter(name);
                    }
                    else
                    {
                        parts[i] = " " + strType + " " + LowercaseFirstLetter(name);

                    }
                }
            }
            return string.Join(",", parts);
        }

        private static string ChangeArgsToGodotVariantTypes(MetaMethodInfo methodInfo, string args)
        {
            string[] parts = args.Split(",".ToCharArray());
            for (int i = 0; i < parts.Length; ++i)
            {
                string part = parts[i].Trim();
                int indexName = GetIndexArgumentBeforeName(part);
                if (indexName > 0)
                {
                    string strType = ChangeToGodotVariantType(methodInfo, part.Substring(0, indexName + 1).Trim());
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
                string header =
@"#pragma once

#include ""..\CChromaEditorLibrary\ChromaSDKPluginTypes.h""

# ifdef _WIN64
#define CHROMA_EDITOR_DLL	_T(""CChromaEditorLibrary64.dll"")
#else
#define CHROMA_EDITOR_DLL	_T(""CChromaEditorLibrary.dll"")
#endif

/* Setup log mechanism */
typedef void(*DebugLogPtr)(const char*);
void LogDebug(const char* text, ...);
void LogError(const char* text, ...);
/* End of setup log mechanism */
                ";
                Output(swHeader, "{0}", header);
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

                string strNamespace =
@"#define CHROMASDK_DECLARE_METHOD(Signature, FieldName) static Signature FieldName;

namespace ChromaSDK
{
	class ChromaAnimationAPI
	{
	private:
		static bool _sIsInitializedAPI;

	public:
";
                Output(swHeader, "{0}", strNamespace);

                Output(swHeader, "#pragma region API declare prototypes");
                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(swHeader, "\t\t/*");

                    if (!string.IsNullOrEmpty(methodInfo.Comments))
                    {
                        Output(swHeader, "\t\t\t{0}", SplitLongComments(methodInfo.Comments, "\t\t\t"));
                    }

                    Output(swHeader, "\t\t*/");

                    Output(swHeader, "\t\tCHROMASDK_DECLARE_METHOD(PLUGIN_{0}, {1});",
                        GetCamelUnderscore(methodInfo.Name), methodInfo.Name);
                }
                Output(swHeader, "#pragma endregion");

                string footer =
@"
		static int InitAPI();
		static bool GetIsInitializedAPI();
	};
}";
                Output(swHeader, "{0}", footer);

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

                string header =
@"#include ""stdafx.h""
#include ""ChromaAnimationAPI.h""
#if false
#include ""..\CChromaEditorLibrary\VerifyLibrarySignature.h""
#endif

using namespace ChromaSDK;

#define CHROMASDK_DECLARE_METHOD_IMPL(Signature, FieldName) Signature ChromaAnimationAPI::FieldName = nullptr;
";
                Output(swImplementation, "{0}", header);

                Output(swImplementation, "#pragma region API declare assignments");
                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(swImplementation, "CHROMASDK_DECLARE_METHOD_IMPL(PLUGIN_{0}, {1});",
                        GetCamelUnderscore(methodInfo.Name), methodInfo.Name);
                }
                Output(swImplementation, "#pragma endregion");

                Output(swImplementation, "");

                string definition =
@"#define CHROMASDK_VALIDATE_METHOD(Signature, FieldName) FieldName = (Signature) GetProcAddress(library, ""Plugin"" #FieldName); \
if (FieldName == nullptr) \
{ \
	fprintf(stderr, ""Failed to find method: %s!\r\n"", ""Plugin"" #FieldName); \
	return -1; \
}

bool ChromaAnimationAPI::_sIsInitializedAPI = false;

int ChromaAnimationAPI::InitAPI()
{
	HMODULE library = LoadLibrary(CHROMA_EDITOR_DLL);
	if (library == NULL)
	{
		fprintf(stderr, ""Failed to load Chroma Editor Library!\r\n"");
		return -1;
	}

#if false
	// when editor DLL is digitally signed
	if (!VerifyLibrarySignature::VerifyModule(library))
	{
		fprintf(stderr, ""Failed to load Chroma Editor Library reason: invalid signature!\r\n"");

		// unload the library
		FreeLibrary(library);
		library = NULL;

		return -1;
	}
#endif

	//fprintf(stderr, ""Loaded Chroma Editor DLL!\r\n"");
";

                Output(swImplementation, "{0}", definition);

                Output(swImplementation, "#pragma region API validation");
                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(swImplementation, "CHROMASDK_VALIDATE_METHOD(PLUGIN_{0}, {1});",
                        GetCamelUnderscore(methodInfo.Name), methodInfo.Name);
                }
                Output(swImplementation, "#pragma endregion");

                string footer =
@"
	//fprintf(stdout, ""Validated all DLL methods [success]\r\n"");
	_sIsInitializedAPI = true;
	return 0;
}

bool ChromaAnimationAPI::GetIsInitializedAPI()
{
	return _sIsInitializedAPI;
}";
                Output(swImplementation, "{0}", footer);

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

        #region Godot

        static bool WriteGodotHeader(StreamWriter swHeader)
        {
            try
            {
                Output(swHeader, "#pragma region autogenerated");
                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(swHeader, "/*");

                    if (!string.IsNullOrEmpty(methodInfo.Comments))
                    {
                        Output(swHeader, "\t{0}", SplitLongComments(methodInfo.Comments, "\t"));
                    }

                    Output(swHeader, "*/");

                    if (methodInfo.Args.Length < 20)
                    {
                        Output(swHeader, "{0} {1}({2});",
                            methodInfo.ReturnType,
                            methodInfo.Name,
                            ChangeArgsToGodotVariantTypes(methodInfo, methodInfo.Args));
                    }
                    else
                    {
                        Output(swHeader, "{0} {1}(\r\n\t{2});",
                            methodInfo.ReturnType,
                            methodInfo.Name,
                            ChangeArgsToGodotVariantTypes(methodInfo, methodInfo.Args));
                    }

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

        static bool IsGodotSupported(MetaMethodInfo methodInfo)
        {
            if (methodInfo.Name == "SetLogDelegate")
            {
                return false;
            }
            string[] parts = methodInfo.Args.Split(",".ToCharArray());
            for (int i = 0; i < parts.Length; ++i)
            {
                string part = parts[i].Trim();
                int indexName = GetIndexArgumentBeforeName(part);
                if (indexName > 0)
                {
                    string strType = ChangeToGodotVariantType(methodInfo, part.Substring(0, indexName + 1).Trim());
                    if (strType.Contains("*") ||
                        strType.Contains("FChromaSDKGuid") ||
                        strType.Contains("DEVICE_INFO_TYPE") ||
                        strType.Contains("RZEFFECTID"))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void WriteTabs(StreamWriter sw, int tabs)
        {
            for (int tab = 0; tab < tabs; ++tab)
            {
                sw.Write("\t");
            }
        }

        static bool WriteGodotImplementation(StreamWriter swImplementation)
        {
            try
            {
                Console.WriteLine();

                string header = @"void NodeChromaSDK::_register_methods() {
	register_method((char*)""IsApiIninitialized"", &NodeChromaSDK::IsApiIninitialized);";

                Output(swImplementation, "{0}", header);

                Output(swImplementation, "\t#pragma region autogenerated");
                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    if (!IsGodotSupported(methodInfo))
                    {
                        Output(swImplementation, "\t//register_method((char*)\"{0}\", &NodeChromaSDK::{0});",
                            methodInfo.Name);
                    }
                    else
                    {
                        Output(swImplementation, "\tregister_method((char*)\"{0}\", &NodeChromaSDK::{0});",
                            methodInfo.Name);
                    }

                }
                Output(swImplementation, "\t#pragma endregion");
                Output(swImplementation, "{0}", "}");
                
                Output(swImplementation, "");

                Output(swImplementation, "#pragma region autogenerated");
                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(swImplementation, "/*");

                    if (!string.IsNullOrEmpty(methodInfo.Comments))
                    {
                        Output(swImplementation, "\t{0}", SplitLongComments(methodInfo.Comments, "\t"));
                    }

                    Output(swImplementation, "*/");

                    string godotParameters = ChangeArgsToGodotVariantTypes(methodInfo, methodInfo.Args);
                    //godotParameters = "int animationId, int frameId, Array rzkeys, int keyCount, int color";
                    Output(swImplementation, "{0} godot::NodeChromaSDK::{1}({2})",
                            methodInfo.ReturnType,
                            methodInfo.Name,
                            godotParameters);

                    Output(swImplementation, "{0}", "{");

                    if (methodInfo.ReturnType == "void")
                    {
                        string godotArgs = GetGodotArgsWithoutType(methodInfo.Args);
                        //godotArgs = "animationId, frameId, rzkeys, keyCount, color";
                        if (HasGodotArrayArgs(godotParameters))
                        {
                            List<GodotArrayConversion> conversions = new List<GodotArrayConversion>();
                            
                            string convertGodotArgs = ConvertGodotArrayArgs(godotParameters, godotArgs, conversions);
                            int tabs = 0;
                            for (int i = 0; i < conversions.Count; ++i)
                            {
                                GodotArrayConversion conversion = conversions[i];
                                
                                WriteTabs(swImplementation, tabs);
                                Output(swImplementation, "\tif ({0}.size())", conversion.OldField);

                                WriteTabs(swImplementation, tabs);
                                Output(swImplementation, "\t{0}", "{");
                                ++tabs;

                                WriteTabs(swImplementation, tabs);
                                Output(swImplementation, "\tint* {0} = new int[{1}.size()];",
                                    conversion.NewField,
                                    conversion.OldField);

                                WriteTabs(swImplementation, tabs);
                                Output(swImplementation, "\tfor (int i{0} = 0; i{0} < {1}.size(); ++i{0})",
                                    (i == 0) ? "" : i.ToString(),
                                    conversion.OldField);

                                WriteTabs(swImplementation, tabs);
                                Output(swImplementation, "\t{0}", "{");
                                ++tabs;

                                WriteTabs(swImplementation, tabs);
                                Output(swImplementation, "\t{0}[i{1}] = (int){2}[i{1}];",
                                    conversion.NewField,
                                    (i == 0) ? "" : i.ToString(),
                                    conversion.OldField);

                                --tabs;
                                WriteTabs(swImplementation, tabs);
                                Output(swImplementation, "\t{0}", "}");
                            }

                            WriteTabs(swImplementation, tabs);
                            Output(swImplementation, "\tChromaAnimationAPI::{1}({2});",
                                methodInfo.ReturnType,
                                methodInfo.Name,
                                convertGodotArgs);

                            for (int i = conversions.Count - 1; i >= 0; --i)
                            {
                                GodotArrayConversion conversion = conversions[i];

                                WriteTabs(swImplementation, tabs);
                                Output(swImplementation, "\tdelete[] {0};", conversion.NewField);
                                --tabs;

                                WriteTabs(swImplementation, tabs);
                                Output(swImplementation, "\t{0}", "}");
                            }
                        }
                        else
                        {
                            Output(swImplementation, "\tChromaAnimationAPI::{1}({2});",
                                methodInfo.ReturnType,
                                methodInfo.Name,
                                godotArgs);
                        }
                    }
                    else
                    {
                        Output(swImplementation, "\treturn ChromaAnimationAPI::{1}({2});",
                            methodInfo.ReturnType,
                            methodInfo.Name,
                            GetGodotArgsWithoutType(methodInfo.Args));
                    }
                    Output(swImplementation, "{0}", "}");

                    Output(swImplementation, "");

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

        #endregion

        #region CTF

        static bool WriteCTFHeader(StreamWriter swHeader)
        {
            try
            {
                Output(swHeader, "#pragma region Autogenerated lua C functions");
                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(swHeader, "\t/*");

                    if (!string.IsNullOrEmpty(methodInfo.Comments))
                    {
                        Output(swHeader, "\t{0}", SplitLongComments(methodInfo.Comments, "\t\t"));
                    }

                    Output(swHeader, "\t*/");

                    Output(swHeader, "\tstatic int Lua{0}(lua::lua_State* state);", methodInfo.Name);

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

        struct MetaArgsCTF
        {
            public string FieldType;
            public string FieldName;
        }

        static MetaArgsCTF[] GetCTFArgs(string input)
        {
            List<MetaArgsCTF> results = new List<MetaArgsCTF>();
            string[] parts = input.Split(",".ToCharArray());
            foreach (string part in parts)
            {
                string trimPart = part.Trim();
                int indexSpace = trimPart.LastIndexOf(" ");
                if (indexSpace > 0)
                {
                    MetaArgsCTF arg = new MetaArgsCTF();
                    arg.FieldType = trimPart.Substring(0, indexSpace).Trim();
                    arg.FieldName = trimPart.Substring(indexSpace).Trim();
                    results.Add(arg);
                }
            }
            return results.ToArray();
        }

        static bool HasCTFSupportedTypes(MetaArgsCTF[] args)
        {
            foreach (MetaArgsCTF arg in args)
            {
                switch (arg.FieldType)
                {
                    case "bool":
                    case "const char*":
                    case "int":
                    case "const int*":
                    case "float":
                    case "double":
                        break;
                    default:
                        return false;
                }
            }
            return true;
        }

        static string GetCTFArgsForAPI(MetaArgsCTF[] args)
        {
            List<string> results = new List<string>();
            foreach (MetaArgsCTF arg in args)
            {
                switch (arg.FieldType)
                {
                    case "const char*":
                        results.Add(string.Format("{0}.c_str()", arg.FieldName));
                        break;
                    default:
                        results.Add(arg.FieldName);
                        break;
                }
            }
            return string.Join(", ", results.ToArray());
        }

        static bool WriteCTFImplementation(StreamWriter swImplementation)
        {
            try
            {
                Console.WriteLine();

                Output(swImplementation, "#pragma region Autogenerated Keyboard Enums");
                Output(swImplementation, string.Empty);

                string strEnums = @"
RZKEY_ESC = 0x0001,                 /*!< Esc (VK_ESCAPE) */
RZKEY_F1 = 0x0003,                  /*!< F1 (VK_F1) */
RZKEY_F2 = 0x0004,                  /*!< F2 (VK_F2) */
RZKEY_F3 = 0x0005,                  /*!< F3 (VK_F3) */
RZKEY_F4 = 0x0006,                  /*!< F4 (VK_F4) */
RZKEY_F5 = 0x0007,                  /*!< F5 (VK_F5) */
RZKEY_F6 = 0x0008,                  /*!< F6 (VK_F6) */
RZKEY_F7 = 0x0009,                  /*!< F7 (VK_F7) */
RZKEY_F8 = 0x000A,                  /*!< F8 (VK_F8) */
RZKEY_F9 = 0x000B,                  /*!< F9 (VK_F9) */
RZKEY_F10 = 0x000C,                 /*!< F10 (VK_F10) */
RZKEY_F11 = 0x000D,                 /*!< F11 (VK_F11) */
RZKEY_F12 = 0x000E,                 /*!< F12 (VK_F12) */
RZKEY_1 = 0x0102,                   /*!< 1 (VK_1) */
RZKEY_2 = 0x0103,                   /*!< 2 (VK_2) */
RZKEY_3 = 0x0104,                   /*!< 3 (VK_3) */
RZKEY_4 = 0x0105,                   /*!< 4 (VK_4) */
RZKEY_5 = 0x0106,                   /*!< 5 (VK_5) */
RZKEY_6 = 0x0107,                   /*!< 6 (VK_6) */
RZKEY_7 = 0x0108,                   /*!< 7 (VK_7) */
RZKEY_8 = 0x0109,                   /*!< 8 (VK_8) */
RZKEY_9 = 0x010A,                   /*!< 9 (VK_9) */
RZKEY_0 = 0x010B,                   /*!< 0 (VK_0) */
RZKEY_A = 0x0302,                   /*!< A (VK_A) */
RZKEY_B = 0x0407,                   /*!< B (VK_B) */
RZKEY_C = 0x0405,                   /*!< C (VK_C) */
RZKEY_D = 0x0304,                   /*!< D (VK_D) */
RZKEY_E = 0x0204,                   /*!< E (VK_E) */
RZKEY_F = 0x0305,                   /*!< F (VK_F) */
RZKEY_G = 0x0306,                   /*!< G (VK_G) */
RZKEY_H = 0x0307,                   /*!< H (VK_H) */
RZKEY_I = 0x0209,                   /*!< I (VK_I) */
RZKEY_J = 0x0308,                   /*!< J (VK_J) */
RZKEY_K = 0x0309,                   /*!< K (VK_K) */
RZKEY_L = 0x030A,                   /*!< L (VK_L) */
RZKEY_M = 0x0409,                   /*!< M (VK_M) */
RZKEY_N = 0x0408,                   /*!< N (VK_N) */
RZKEY_O = 0x020A,                   /*!< O (VK_O) */
RZKEY_P = 0x020B,                   /*!< P (VK_P) */
RZKEY_Q = 0x0202,                   /*!< Q (VK_Q) */
RZKEY_R = 0x0205,                   /*!< R (VK_R) */
RZKEY_S = 0x0303,                   /*!< S (VK_S) */
RZKEY_T = 0x0206,                   /*!< T (VK_T) */
RZKEY_U = 0x0208,                   /*!< U (VK_U) */
RZKEY_V = 0x0406,                   /*!< V (VK_V) */
RZKEY_W = 0x0203,                   /*!< W (VK_W) */
RZKEY_X = 0x0404,                   /*!< X (VK_X) */
RZKEY_Y = 0x0207,                   /*!< Y (VK_Y) */
RZKEY_Z = 0x0403,                   /*!< Z (VK_Z) */
RZKEY_NUMLOCK = 0x0112,             /*!< Numlock (VK_NUMLOCK) */
RZKEY_NUMPAD0 = 0x0513,             /*!< Numpad 0 (VK_NUMPAD0) */
RZKEY_NUMPAD1 = 0x0412,             /*!< Numpad 1 (VK_NUMPAD1) */
RZKEY_NUMPAD2 = 0x0413,             /*!< Numpad 2 (VK_NUMPAD2) */
RZKEY_NUMPAD3 = 0x0414,             /*!< Numpad 3 (VK_NUMPAD3) */
RZKEY_NUMPAD4 = 0x0312,             /*!< Numpad 4 (VK_NUMPAD4) */
RZKEY_NUMPAD5 = 0x0313,             /*!< Numpad 5 (VK_NUMPAD5) */
RZKEY_NUMPAD6 = 0x0314,             /*!< Numpad 6 (VK_NUMPAD6) */
RZKEY_NUMPAD7 = 0x0212,             /*!< Numpad 7 (VK_NUMPAD7) */
RZKEY_NUMPAD8 = 0x0213,             /*!< Numpad 8 (VK_NUMPAD8) */
RZKEY_NUMPAD9 = 0x0214,             /*!< Numpad 9 (VK_ NUMPAD9*/
RZKEY_NUMPAD_DIVIDE = 0x0113,       /*!< Divide (VK_DIVIDE) */
RZKEY_NUMPAD_MULTIPLY = 0x0114,     /*!< Multiply (VK_MULTIPLY) */
RZKEY_NUMPAD_SUBTRACT = 0x0115,     /*!< Subtract (VK_SUBTRACT) */
RZKEY_NUMPAD_ADD = 0x0215,          /*!< Add (VK_ADD) */
RZKEY_NUMPAD_ENTER = 0x0415,        /*!< Enter (VK_RETURN - Extended) */
RZKEY_NUMPAD_DECIMAL = 0x0514,      /*!< Decimal (VK_DECIMAL) */
RZKEY_PRINTSCREEN = 0x000F,         /*!< Print Screen (VK_PRINT) */
RZKEY_SCROLL = 0x0010,              /*!< Scroll Lock (VK_SCROLL) */
RZKEY_PAUSE = 0x0011,               /*!< Pause (VK_PAUSE) */
RZKEY_INSERT = 0x010F,              /*!< Insert (VK_INSERT) */
RZKEY_HOME = 0x0110,                /*!< Home (VK_HOME) */
RZKEY_PAGEUP = 0x0111,              /*!< Page Up (VK_PRIOR) */
RZKEY_DELETE = 0x020f,              /*!< Delete (VK_DELETE) */
RZKEY_END = 0x0210,                 /*!< End (VK_END) */
RZKEY_PAGEDOWN = 0x0211,            /*!< Page Down (VK_NEXT) */
RZKEY_UP = 0x0410,                  /*!< Up (VK_UP) */
RZKEY_LEFT = 0x050F,                /*!< Left (VK_LEFT) */
RZKEY_DOWN = 0x0510,                /*!< Down (VK_DOWN) */
RZKEY_RIGHT = 0x0511,               /*!< Right (VK_RIGHT) */
RZKEY_TAB = 0x0201,                 /*!< Tab (VK_TAB) */
RZKEY_CAPSLOCK = 0x0301,            /*!< Caps Lock(VK_CAPITAL) */
RZKEY_BACKSPACE = 0x010E,           /*!< Backspace (VK_BACK) */
RZKEY_ENTER = 0x030E,               /*!< Enter (VK_RETURN) */
RZKEY_LCTRL = 0x0501,               /*!< Left Control(VK_LCONTROL) */
RZKEY_LWIN = 0x0502,                /*!< Left Window (VK_LWIN) */
RZKEY_LALT = 0x0503,                /*!< Left Alt (VK_LMENU) */
RZKEY_SPACE = 0x0507,               /*!< Spacebar (VK_SPACE) */
RZKEY_RALT = 0x050B,                /*!< Right Alt (VK_RMENU) */
RZKEY_FN = 0x050C,                  /*!< Function key. */
RZKEY_RMENU = 0x050D,               /*!< Right Menu (VK_APPS) */
RZKEY_RCTRL = 0x050E,               /*!< Right Control (VK_RCONTROL) */
RZKEY_LSHIFT = 0x0401,              /*!< Left Shift (VK_LSHIFT) */
RZKEY_RSHIFT = 0x040E,              /*!< Right Shift (VK_RSHIFT) */
RZKEY_MACRO1 = 0x0100,              /*!< Macro Key 1 */
RZKEY_MACRO2 = 0x0200,              /*!< Macro Key 2 */
RZKEY_MACRO3 = 0x0300,              /*!< Macro Key 3 */
RZKEY_MACRO4 = 0x0400,              /*!< Macro Key 4 */
RZKEY_MACRO5 = 0x0500,              /*!< Macro Key 5 */
RZKEY_OEM_1 = 0x0101,               /*!< ~ (tilde/半角/全角) (VK_OEM_3) */
RZKEY_OEM_2 = 0x010C,               /*!< -- (minus) (VK_OEM_MINUS) */
RZKEY_OEM_3 = 0x010D,               /*!< = (equal) (VK_OEM_PLUS) */
RZKEY_OEM_4 = 0x020C,               /*!< [ (left sqaure bracket) (VK_OEM_4) */
RZKEY_OEM_5 = 0x020D,               /*!< ] (right square bracket) (VK_OEM_6) */
RZKEY_OEM_6 = 0x020E,               /*!< \ (backslash) (VK_OEM_5) */
RZKEY_OEM_7 = 0x030B,               /*!< ; (semi-colon) (VK_OEM_1) */
RZKEY_OEM_8 = 0x030C,               /*!< ' (apostrophe) (VK_OEM_7) */
RZKEY_OEM_9 = 0x040A,               /*!< , (comma) (VK_OEM_COMMA) */
RZKEY_OEM_10 = 0x040B,              /*!< . (period) (VK_OEM_PERIOD) */
RZKEY_OEM_11 = 0x040C,              /*!< / (forward slash) (VK_OEM_2) */
RZKEY_EUR_1 = 0x030D,               /*!< ""#"" (VK_OEM_5) */
RZKEY_EUR_2 = 0x0402,               /*!< \ (VK_OEM_102) */
RZKEY_JPN_1 = 0x0015,               /*!< ¥ (0xFF) */
RZKEY_JPN_2 = 0x040D,               /*!< \ (0xC1) */
RZKEY_JPN_3 = 0x0504,               /*!< 無変換 (VK_OEM_PA1) */
RZKEY_JPN_4 = 0x0509,               /*!< 変換 (0xFF) */
RZKEY_JPN_5 = 0x050A,               /*!< ひらがな/カタカナ (0xFF) */
RZKEY_KOR_1 = 0x0015,               /*!< | (0xFF) */
RZKEY_KOR_2 = 0x030D,               /*!< (VK_OEM_5) */
RZKEY_KOR_3 = 0x0402,               /*!< (VK_OEM_102) */
RZKEY_KOR_4 = 0x040D,               /*!< (0xC1) */
RZKEY_KOR_5 = 0x0504,               /*!< (VK_OEM_PA1) */
RZKEY_KOR_6 = 0x0509,               /*!< 한/영 (0xFF) */
RZKEY_KOR_7 = 0x050A,               /*!< (0xFF) */
RZKEY_INVALID = 0xFFFF,             /*!< Invalid keys. */
";
                foreach (string strE in strEnums.Split("\n".ToCharArray()))
                {
                    string line = strE.Trim();
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    string[] parts = line.Split(",".ToCharArray());
                    if (parts.Length > 1)
                    {
                        string[] parts2 = parts[0].Split("=".ToCharArray());
                        string part3 = string.Empty;
                        for (int i = 1; i < parts.Length; ++i)
                        {
                            part3 += parts[i].Trim();
                        }
                        Output(swImplementation, "int ExpGet_{0}(); {1}", parts2[0].Trim(), part3);
                    }
                }

                Output(swImplementation, "#pragma endregion");
                Output(swImplementation, string.Empty);

                Output(swImplementation, "#pragma region Autogenerated Keyboard Enum Expression Bindings");
                Output(swImplementation, string.Empty);

                int startExpressionIndex = 7;

                foreach (string strE in strEnums.Split("\n".ToCharArray()))
                {
                    string line = strE.Trim();
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    string[] parts = line.Split(",".ToCharArray());
                    if (parts.Length > 1)
                    {
                        string[] parts2 = parts[0].Split("=".ToCharArray());
                        Output(swImplementation, "LinkExpression({0}, ExpGet_{1});", 
                            startExpressionIndex++, parts2[0].Trim());
                    }
                }

                Output(swImplementation, string.Empty);

                Output(swImplementation, "#pragma endregion");

                Output(swImplementation, string.Empty);

                Output(swImplementation, "#pragma region Autogenerated keyboard enum implementation");

                Output(swImplementation, string.Empty);

                foreach (string strE in strEnums.Split("\n".ToCharArray()))
                {
                    string line = strE.Trim();
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    string[] parts = line.Split(",".ToCharArray());
                    if (parts.Length > 1)
                    {
                        string[] parts2 = parts[0].Split("=".ToCharArray());
                        string part3 = string.Empty;
                        for (int i = 1; i < parts.Length; ++i)
                        {
                            part3 += parts[i].Trim();
                        }
                        Output(swImplementation, "int Extension::ExpGet_{0}() {1}", parts2[0].Trim(), part3);
                        Output(swImplementation, "{0}", "{");
                        Output(swImplementation, "\treturn ExpGetColorIndex(Keyboard::RZKEY::{0});", parts2[0].Trim());
                        Output(swImplementation, "{0}", "}");
                    }
                }

                Output(swImplementation, "#pragma endregion");

                Output(swImplementation, string.Empty);

                Output(swImplementation, "#pragma region DarkExt.json ExpressionMenu");

                Output(swImplementation, "/*");

                startExpressionIndex = 7;
                foreach (string strE in strEnums.Split("\n".ToCharArray()))
                {
                    string line = strE.Trim();
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    string[] parts = line.Split(",".ToCharArray());
                    if (parts.Length > 1)
                    {
                        string[] parts2 = parts[0].Split("=".ToCharArray());
                        Output(swImplementation, "\t\t\t[ {0}, \"Keyboard_{1}(\" ],",
                            startExpressionIndex++,
                            parts2[0].Trim());
                    }
                }

                Output(swImplementation, "*/");

                Output(swImplementation, string.Empty);

                Output(swImplementation, "#pragma endregion");

                Output(swImplementation, string.Empty);

                Output(swImplementation, "#pragma region DarkExt.json Expressions");

                Output(swImplementation, "/*");

                startExpressionIndex = 7;
                foreach (string strE in strEnums.Split("\n".ToCharArray()))
                {
                    string line = strE.Trim();
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    string[] parts = line.Split(",".ToCharArray());
                    if (parts.Length > 1)
                    {
                        string[] parts2 = parts[0].Split("=".ToCharArray());
                        Output(swImplementation, "\t\t\t{0}", "{");
                        Output(swImplementation, "\t\t\t\t\"Title\": \"Keyboard_{0}(\",",
                            parts2[0].Trim());
                        Output(swImplementation, "\t\t\t\t\"Returns\": \"Integer\"",
                            parts2[0].Trim());
                        Output(swImplementation, "\t\t\t{0},", "}");
                    }
                }

                Output(swImplementation, "*/");

                Output(swImplementation, string.Empty);

                Output(swImplementation, "#pragma endregion");

                Output(swImplementation, string.Empty);

                Output(swImplementation, "#pragma region Autogenerated bindings");
                Output(swImplementation, string.Empty);

                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(swImplementation, "\t\t\t// {0}", methodInfo.Name);
                    Output(swImplementation, "\t\t\tlua::lua_pushcfunction(lState, Extension::Lua{0});",
                            methodInfo.Name);
                    Output(swImplementation, "\t\t\tlua::lua_setglobal(lState, \"{0}\");",
                        methodInfo.Name);
                    Output(swImplementation, "\t\t\tWrapperXLuaState::LoadString(xState, \"ChromaAnimationAPI.{0} = {0}\");",
                        methodInfo.Name);

                    Output(swImplementation, string.Empty);

                }
                Output(swImplementation, "\t#pragma endregion");

                Output(swImplementation, "");

                Output(swImplementation, "#pragma region Autogenerated lua C functions");
                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(swImplementation, "/*");

                    if (!string.IsNullOrEmpty(methodInfo.Comments))
                    {
                        Output(swImplementation, "\t{0}", SplitLongComments(methodInfo.Comments, "\t"));
                    }

                    Output(swImplementation, "*/");

                    Output(swImplementation, "int Extension::Lua{0}(lua::lua_State* state)",
                            methodInfo.Name);

                    Output(swImplementation, "{0}", "{");

                    Output(swImplementation, "{0}", "\tif (state)");
                    Output(swImplementation, "{0}", "\t{");

                    // loop through each parameter

                    MetaArgsCTF[] args = GetCTFArgs(methodInfo.Args);
                    bool hasCTFSupportedTypes = HasCTFSupportedTypes(args);
                    if (hasCTFSupportedTypes)
                    {
                        int indexArg = 1;
                        foreach (MetaArgsCTF arg in args)
                        {
                            switch (arg.FieldType)
                            {
                                case "bool":
                                    Output(swImplementation, "\t\tif (!WrapperXLua::lua_isbooleanW(state, {0}))", indexArg);
                                    break;
                                case "const char*":
                                    Output(swImplementation, "\t\tif (!WrapperXLua::lua_isstringW(state, {0}))", indexArg);
                                    break;
                                case "int":
                                case "float":
                                case "double":
                                    Output(swImplementation, "\t\tif (!WrapperXLua::lua_isnumberW(state, {0}))", indexArg);
                                    break;
                                case "const int*":
                                    Output(swImplementation, "\t\tif (!WrapperXLua::lua_istableW(state, {0}))", indexArg);
                                    break;
                            }
                            Output(swImplementation, "{0}", "\t\t{");
                            Output(swImplementation, "\t\t\treturn -1;");
                            Output(swImplementation, "{0}", "\t\t}");
                            switch (arg.FieldType)
                            {
                                case "bool":
                                    Output(swImplementation, "\t\tbool {0} = WrapperXLua::lua_tobooleanW(state, {1}) == 1;",
                                        arg.FieldName,
                                        indexArg);
                                    break;
                                case "const char*":
                                    Output(swImplementation, "\t\tstring {0} = WrapperXLua::lua_tostringW(state, {1});",
                                        arg.FieldName,
                                        indexArg);
                                    break;
                                case "int":
                                    Output(swImplementation, "\t\tint {0} = WrapperXLua::lua_tointegerW(state, {1});",
                                        arg.FieldName,
                                        indexArg);
                                    break;
                                case "float":
                                    Output(swImplementation, "\t\tfloat {0} = (float)WrapperXLua::lua_tonumberW(state, {1});",
                                        arg.FieldName,
                                        indexArg);
                                    break;
                                case "double":
                                    Output(swImplementation, "\t\tdouble {0} = WrapperXLua::lua_tonumberW(state, {1});",
                                        arg.FieldName,
                                        indexArg);
                                    break;

                            }
                            ++indexArg;
                        }

                        indexArg = 1;
                        foreach (MetaArgsCTF arg in args)
                        {
                            switch (arg.FieldType)
                            {
                                case "const int*":
                                    Output(swImplementation, "\t\tint* {0} = new int[{1}];",
                                        arg.FieldName,
                                        args[indexArg].FieldName); //index is 1 based, assume next parameter is the size
                                    Output(swImplementation, "\t\tfor (int i = 0; i < {0}; ++i)",
                                        args[indexArg].FieldName); //index is 1 based, assume next parameter is the size
                                    Output(swImplementation, "\t\t{0}", "{");
                                    Output(swImplementation, "\t\t\t// copy integers from lua type");
                                    Output(swImplementation, "\t\t\tWrapperXLua::lua_rawgetiW(state, {0}, i + 1);",
                                        indexArg);
                                    Output(swImplementation, "\t\t\t{0}[i] = WrapperXLua::lua_tointegerW(state, -1);",
                                        arg.FieldName);
                                    Output(swImplementation, "\t\t{0}", "}");
                                    break;
                            }
                            ++indexArg;
                        }

                        switch (methodInfo.ReturnType)
                        {
                            case "bool":
                            case "const char*":
                            case "int":
                            case "float":
                            case "double":
                                Output(swImplementation, "\t\t{0} result = ChromaAnimationAPI::{1}({2});",
                                    methodInfo.ReturnType,
                                    methodInfo.Name,
                                    GetCTFArgsForAPI(args));
                                break;
                            default:
                                Output(swImplementation, "\t\tChromaAnimationAPI::{0}({1});",
                                    methodInfo.Name,
                                    GetCTFArgsForAPI(args));
                                break;
                        }

                        indexArg = 1;
                        foreach (MetaArgsCTF arg in args)
                        {
                            switch (arg.FieldType)
                            {
                                case "const int*":
                                    Output(swImplementation, "\t\tdelete[] {0};",
                                        arg.FieldName);
                                    break;
                            }
                            ++indexArg;
                        }
                    }
                    else
                    {
                        foreach (MetaArgsCTF arg in args)
                        {
                            Output(swImplementation, "\t\t// FieldType: {0}",
                                arg.FieldType);
                            Output(swImplementation, "\t\t// FieldName: {0}",
                                arg.FieldName);
                        }
                    }

                    if (hasCTFSupportedTypes)
                    {
                        switch (methodInfo.ReturnType)
                        {
                            case "bool":
                                Output(swImplementation, "\t\tlua::lua_pushboolean(state, result);");
                                break;
                            case "const char*":
                                Output(swImplementation, "\t\tlua::lua_pushlstring(state, result, strlen(result));");
                                break;
                            case "int":
                                Output(swImplementation, "\t\tlua::lua_pushinteger(state, result);");
                                break;
                            case "float":
                                Output(swImplementation, "\t\tlua::lua_pushnumber(state, result);");
                                break;
                            case "double":
                                Output(swImplementation, "\t\tlua::lua_pushnumber(state, result);");
                                break;
                        }
                    }

                    if (hasCTFSupportedTypes)
                    {
                        switch (methodInfo.ReturnType)
                        {
                            case "bool":
                            case "const char*":
                            case "int":
                            case "float":
                            case "double":
                                Output(swImplementation, "\t\treturn 1;"); //number of results
                                break;
                            default:
                                Output(swImplementation, "\t\treturn 0;");
                                break;
                        }
                    }
                    else
                    {
                        Output(swImplementation, "#pragma message(\"TODO - add support for {0}\")", methodInfo.Name);
                        Output(swImplementation, "\t\treturn 0;");
                    }

                    Output(swImplementation, "{0}", "\t}");
                    Output(swImplementation, "\telse");
                    Output(swImplementation, "{0}", "\t{");
                    Output(swImplementation, "\t\treturn -1;");
                    Output(swImplementation, "{0}", "\t}");

                    Output(swImplementation, "{0}", "}");

                    Output(swImplementation, string.Empty);
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

        #endregion

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

        private const string HEADER_UNITY_INCLUDES = @"
using System.Collections.Generic;
using UnityEngine;";

        private const string HEADER_UNITY_DLL_NAME = @"
#if PLATFORM_XBOXONE
    #if UNITY_EDITOR
        const string DLL_NAME = ""CChromaEditorLibrary"";
    #else
        const string DLL_NAME = ""XDKChromaEditorLibrary"";
    #endif
#else
    #if UNITY_3 || UNITY_3_0 || UNITY_3_1 || UNITY_3_2 || UNITY_3_3 || UNITY_3_4 || UNITY_3_5
        const string DLL_NAME = ""CChromaEditorLibrary3"";
    #elif UNITY_64
        const string DLL_NAME = ""CChromaEditorLibrary64"";
    #else
        const string DLL_NAME = ""CChromaEditorLibrary"";
    #endif
#endif";

        private const string HEADER_CSHARP_DLL_NAME = @"
#if X64
        const string DLL_NAME = ""CChromaEditorLibrary64"";
#else
        const string DLL_NAME = ""CChromaEditorLibrary"";
#endif
";

        private const string HEADER_UNITY_KEY_MAPPING = @"
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
";

        private const string HEADER_UNITY_GET_STREAMING_PATH =
@"
        /// <summary>
        /// Get the streaming path for the animation given the relative path from Assets/StreamingAssets
        /// </summary>
        /// <param name=""animation""></param>
        /// <returns></returns>
        public static string GetStreamingPath(string animation)
        {
            return string.Format(""{0}/{1}"", _sStreamingAssetPath, animation);
        }";

        private const string HEADER_CSHARP =
@"using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
__UNITY_INCLUDES__

namespace ChromaSDK
{
    public class Keyboard
    {
        //! Definitions of keys.
        public enum RZKEY
        {
            RZKEY_ESC = 0x0001,                 /*!< Esc (VK_ESCAPE) */
            RZKEY_F1 = 0x0003,                  /*!< F1 (VK_F1) */
            RZKEY_F2 = 0x0004,                  /*!< F2 (VK_F2) */
            RZKEY_F3 = 0x0005,                  /*!< F3 (VK_F3) */
            RZKEY_F4 = 0x0006,                  /*!< F4 (VK_F4) */
            RZKEY_F5 = 0x0007,                  /*!< F5 (VK_F5) */
            RZKEY_F6 = 0x0008,                  /*!< F6 (VK_F6) */
            RZKEY_F7 = 0x0009,                  /*!< F7 (VK_F7) */
            RZKEY_F8 = 0x000A,                  /*!< F8 (VK_F8) */
            RZKEY_F9 = 0x000B,                  /*!< F9 (VK_F9) */
            RZKEY_F10 = 0x000C,                 /*!< F10 (VK_F10) */
            RZKEY_F11 = 0x000D,                 /*!< F11 (VK_F11) */
            RZKEY_F12 = 0x000E,                 /*!< F12 (VK_F12) */
            RZKEY_1 = 0x0102,                   /*!< 1 (VK_1) */
            RZKEY_2 = 0x0103,                   /*!< 2 (VK_2) */
            RZKEY_3 = 0x0104,                   /*!< 3 (VK_3) */
            RZKEY_4 = 0x0105,                   /*!< 4 (VK_4) */
            RZKEY_5 = 0x0106,                   /*!< 5 (VK_5) */
            RZKEY_6 = 0x0107,                   /*!< 6 (VK_6) */
            RZKEY_7 = 0x0108,                   /*!< 7 (VK_7) */
            RZKEY_8 = 0x0109,                   /*!< 8 (VK_8) */
            RZKEY_9 = 0x010A,                   /*!< 9 (VK_9) */
            RZKEY_0 = 0x010B,                   /*!< 0 (VK_0) */
            RZKEY_A = 0x0302,                   /*!< A (VK_A) */
            RZKEY_B = 0x0407,                   /*!< B (VK_B) */
            RZKEY_C = 0x0405,                   /*!< C (VK_C) */
            RZKEY_D = 0x0304,                   /*!< D (VK_D) */
            RZKEY_E = 0x0204,                   /*!< E (VK_E) */
            RZKEY_F = 0x0305,                   /*!< F (VK_F) */
            RZKEY_G = 0x0306,                   /*!< G (VK_G) */
            RZKEY_H = 0x0307,                   /*!< H (VK_H) */
            RZKEY_I = 0x0209,                   /*!< I (VK_I) */
            RZKEY_J = 0x0308,                   /*!< J (VK_J) */
            RZKEY_K = 0x0309,                   /*!< K (VK_K) */
            RZKEY_L = 0x030A,                   /*!< L (VK_L) */
            RZKEY_M = 0x0409,                   /*!< M (VK_M) */
            RZKEY_N = 0x0408,                   /*!< N (VK_N) */
            RZKEY_O = 0x020A,                   /*!< O (VK_O) */
            RZKEY_P = 0x020B,                   /*!< P (VK_P) */
            RZKEY_Q = 0x0202,                   /*!< Q (VK_Q) */
            RZKEY_R = 0x0205,                   /*!< R (VK_R) */
            RZKEY_S = 0x0303,                   /*!< S (VK_S) */
            RZKEY_T = 0x0206,                   /*!< T (VK_T) */
            RZKEY_U = 0x0208,                   /*!< U (VK_U) */
            RZKEY_V = 0x0406,                   /*!< V (VK_V) */
            RZKEY_W = 0x0203,                   /*!< W (VK_W) */
            RZKEY_X = 0x0404,                   /*!< X (VK_X) */
            RZKEY_Y = 0x0207,                   /*!< Y (VK_Y) */
            RZKEY_Z = 0x0403,                   /*!< Z (VK_Z) */
            RZKEY_NUMLOCK = 0x0112,             /*!< Numlock (VK_NUMLOCK) */
            RZKEY_NUMPAD0 = 0x0513,             /*!< Numpad 0 (VK_NUMPAD0) */
            RZKEY_NUMPAD1 = 0x0412,             /*!< Numpad 1 (VK_NUMPAD1) */
            RZKEY_NUMPAD2 = 0x0413,             /*!< Numpad 2 (VK_NUMPAD2) */
            RZKEY_NUMPAD3 = 0x0414,             /*!< Numpad 3 (VK_NUMPAD3) */
            RZKEY_NUMPAD4 = 0x0312,             /*!< Numpad 4 (VK_NUMPAD4) */
            RZKEY_NUMPAD5 = 0x0313,             /*!< Numpad 5 (VK_NUMPAD5) */
            RZKEY_NUMPAD6 = 0x0314,             /*!< Numpad 6 (VK_NUMPAD6) */
            RZKEY_NUMPAD7 = 0x0212,             /*!< Numpad 7 (VK_NUMPAD7) */
            RZKEY_NUMPAD8 = 0x0213,             /*!< Numpad 8 (VK_NUMPAD8) */
            RZKEY_NUMPAD9 = 0x0214,             /*!< Numpad 9 (VK_ NUMPAD9*/
            RZKEY_NUMPAD_DIVIDE = 0x0113,       /*!< Divide (VK_DIVIDE) */
            RZKEY_NUMPAD_MULTIPLY = 0x0114,     /*!< Multiply (VK_MULTIPLY) */
            RZKEY_NUMPAD_SUBTRACT = 0x0115,     /*!< Subtract (VK_SUBTRACT) */
            RZKEY_NUMPAD_ADD = 0x0215,          /*!< Add (VK_ADD) */
            RZKEY_NUMPAD_ENTER = 0x0415,        /*!< Enter (VK_RETURN - Extended) */
            RZKEY_NUMPAD_DECIMAL = 0x0514,      /*!< Decimal (VK_DECIMAL) */
            RZKEY_PRINTSCREEN = 0x000F,         /*!< Print Screen (VK_PRINT) */
            RZKEY_SCROLL = 0x0010,              /*!< Scroll Lock (VK_SCROLL) */
            RZKEY_PAUSE = 0x0011,               /*!< Pause (VK_PAUSE) */
            RZKEY_INSERT = 0x010F,              /*!< Insert (VK_INSERT) */
            RZKEY_HOME = 0x0110,                /*!< Home (VK_HOME) */
            RZKEY_PAGEUP = 0x0111,              /*!< Page Up (VK_PRIOR) */
            RZKEY_DELETE = 0x020f,              /*!< Delete (VK_DELETE) */
            RZKEY_END = 0x0210,                 /*!< End (VK_END) */
            RZKEY_PAGEDOWN = 0x0211,            /*!< Page Down (VK_NEXT) */
            RZKEY_UP = 0x0410,                  /*!< Up (VK_UP) */
            RZKEY_LEFT = 0x050F,                /*!< Left (VK_LEFT) */
            RZKEY_DOWN = 0x0510,                /*!< Down (VK_DOWN) */
            RZKEY_RIGHT = 0x0511,               /*!< Right (VK_RIGHT) */
            RZKEY_TAB = 0x0201,                 /*!< Tab (VK_TAB) */
            RZKEY_CAPSLOCK = 0x0301,            /*!< Caps Lock(VK_CAPITAL) */
            RZKEY_BACKSPACE = 0x010E,           /*!< Backspace (VK_BACK) */
            RZKEY_ENTER = 0x030E,               /*!< Enter (VK_RETURN) */
            RZKEY_LCTRL = 0x0501,               /*!< Left Control(VK_LCONTROL) */
            RZKEY_LWIN = 0x0502,                /*!< Left Window (VK_LWIN) */
            RZKEY_LALT = 0x0503,                /*!< Left Alt (VK_LMENU) */
            RZKEY_SPACE = 0x0507,               /*!< Spacebar (VK_SPACE) */
            RZKEY_RALT = 0x050B,                /*!< Right Alt (VK_RMENU) */
            RZKEY_FN = 0x050C,                  /*!< Function key. */
            RZKEY_RMENU = 0x050D,               /*!< Right Menu (VK_APPS) */
            RZKEY_RCTRL = 0x050E,               /*!< Right Control (VK_RCONTROL) */
            RZKEY_LSHIFT = 0x0401,              /*!< Left Shift (VK_LSHIFT) */
            RZKEY_RSHIFT = 0x040E,              /*!< Right Shift (VK_RSHIFT) */
            RZKEY_MACRO1 = 0x0100,              /*!< Macro Key 1 */
            RZKEY_MACRO2 = 0x0200,              /*!< Macro Key 2 */
            RZKEY_MACRO3 = 0x0300,              /*!< Macro Key 3 */
            RZKEY_MACRO4 = 0x0400,              /*!< Macro Key 4 */
            RZKEY_MACRO5 = 0x0500,              /*!< Macro Key 5 */
            RZKEY_OEM_1 = 0x0101,               /*!< ~ (tilde/半角/全角) (VK_OEM_3) */
            RZKEY_OEM_2 = 0x010C,               /*!< -- (minus) (VK_OEM_MINUS) */
            RZKEY_OEM_3 = 0x010D,               /*!< = (equal) (VK_OEM_PLUS) */
            RZKEY_OEM_4 = 0x020C,               /*!< [ (left sqaure bracket) (VK_OEM_4) */
            RZKEY_OEM_5 = 0x020D,               /*!< ] (right square bracket) (VK_OEM_6) */
            RZKEY_OEM_6 = 0x020E,               /*!< \ (backslash) (VK_OEM_5) */
            RZKEY_OEM_7 = 0x030B,               /*!< ; (semi-colon) (VK_OEM_1) */
            RZKEY_OEM_8 = 0x030C,               /*!< ' (apostrophe) (VK_OEM_7) */
            RZKEY_OEM_9 = 0x040A,               /*!< , (comma) (VK_OEM_COMMA) */
            RZKEY_OEM_10 = 0x040B,              /*!< . (period) (VK_OEM_PERIOD) */
            RZKEY_OEM_11 = 0x040C,              /*!< / (forward slash) (VK_OEM_2) */
            RZKEY_EUR_1 = 0x030D,               /*!< ""#"" (VK_OEM_5) */
            RZKEY_EUR_2 = 0x0402,               /*!< \ (VK_OEM_102) */
            RZKEY_JPN_1 = 0x0015,               /*!< ¥ (0xFF) */
            RZKEY_JPN_2 = 0x040D,               /*!< \ (0xC1) */
            RZKEY_JPN_3 = 0x0504,               /*!< 無変換 (VK_OEM_PA1) */
            RZKEY_JPN_4 = 0x0509,               /*!< 変換 (0xFF) */
            RZKEY_JPN_5 = 0x050A,               /*!< ひらがな/カタカナ (0xFF) */
            RZKEY_KOR_1 = 0x0015,               /*!< | (0xFF) */
            RZKEY_KOR_2 = 0x030D,               /*!< (VK_OEM_5) */
            RZKEY_KOR_3 = 0x0402,               /*!< (VK_OEM_102) */
            RZKEY_KOR_4 = 0x040D,               /*!< (0xC1) */
            RZKEY_KOR_5 = 0x0504,               /*!< (VK_OEM_PA1) */
            RZKEY_KOR_6 = 0x0509,               /*!< 한/영 (0xFF) */
            RZKEY_KOR_7 = 0x050A,               /*!< (0xFF) */
            RZKEY_INVALID = 0xFFFF              /*!< Invalid keys. */
        }

        //! Definition of LEDs.
        public enum RZLED
        {
            RZLED_LOGO = 0x0014                 /*!< Razer logo */
        };
    }

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct APPINFOTYPE
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string Title; //TCHAR Title[256];

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
		public string Description; //TCHAR Description[1024];

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string Author_Name; //TCHAR Name[256];

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string Author_Contact; //TCHAR Contact[256];

		public UInt32 SupportedDevice; //DWORD SupportedDevice;

		public UInt32 Category; //DWORD Category;
	}

    [StructLayout(LayoutKind.Sequential)]
    public struct FChromaSDKGuid
    {
        Guid Data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DEVICE_INFO_TYPE
    {
        int DeviceType;
        uint Connected;
    }

    public enum EFFECT_TYPE
    {
        CHROMA_NONE = 0,            //!< No effect.
        CHROMA_WAVE,                //!< Wave effect (This effect type has deprecated and should not be used).
        CHROMA_SPECTRUMCYCLING,     //!< Spectrum cycling effect (This effect type has deprecated and should not be used).
        CHROMA_BREATHING,           //!< Breathing effect (This effect type has deprecated and should not be used).
        CHROMA_BLINKING,            //!< Blinking effect (This effect type has deprecated and should not be used).
        CHROMA_REACTIVE,            //!< Reactive effect (This effect type has deprecated and should not be used).
        CHROMA_STATIC,              //!< Static effect.
        CHROMA_CUSTOM,              //!< Custom effect. For mice, please see Mouse::CHROMA_CUSTOM2.
        CHROMA_RESERVED,            //!< Reserved
        CHROMA_INVALID              //!< Invalid effect.
    }

    namespace Stream
    {
        public enum StreamStatusType
        {
            READY = 0, // ready for commands
            AUTHORIZING = 1, // the session is being authorized
            BROADCASTING = 2, // the session is being broadcast
            WATCHING = 3, // A stream is being watched
            NOT_AUTHORIZED = 4, // The session is not authorized
            BROADCAST_DUPLICATE = 5, // The session has duplicate broadcasters
            SERVICE_OFFLINE = 6, // The service is offline
        }

        public class Default
        {
            const uint LENGTH_SHORTCODE = 6;
            const uint LENGTH_STREAM_ID = 48;
            const uint LENGTH_STREAM_KEY = 48;
            const uint LENGTH_STREAM_FOCUS = 48;

            static string GetDefaultString(uint length)
            {
                string result = string.Empty;
                for (uint i = 0; i < length; ++i)
                {
                    result += "" "";
                }
                return result;
            }

            public readonly static string Shortcode = GetDefaultString(LENGTH_SHORTCODE);
            public readonly static string StreamId = GetDefaultString(LENGTH_STREAM_ID);
            public readonly static string StreamKey = GetDefaultString(LENGTH_STREAM_KEY);
            public readonly static string StreamFocus = GetDefaultString(LENGTH_STREAM_FOCUS);
        }
    }

    public class ChromaAnimationAPI
    {
__UNITY_DLL_NAME__

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

		public class FChromaSDKDeviceFrameIndex
		{
			// Index corresponds to EChromaSDKDeviceEnum;
			public int[] _mFrameIndex = new int[6];

			public FChromaSDKDeviceFrameIndex()
			{
				_mFrameIndex[(int)Device.ChromaLink] = 0;
				_mFrameIndex[(int)Device.Headset] = 0;
				_mFrameIndex[(int)Device.Keyboard] = 0;
				_mFrameIndex[(int)Device.Keypad] = 0;
				_mFrameIndex[(int)Device.Mouse] = 0;
				_mFrameIndex[(int)Device.Mousepad] = 0;
			}
		}

		public enum EChromaSDKSceneBlend
		{
			SB_None,
			SB_Invert,
			SB_Threshold,
			SB_Lerp,
		};

		public enum EChromaSDKSceneMode
		{
			SM_Replace,
			SM_Max,
			SM_Min,
			SM_Average,
			SM_Multiply,
			SM_Add,
			SM_Subtract,
		};

		public class FChromaSDKSceneEffect
		{
			public string _mAnimation = """";
			public bool _mState = false;
			public int _mPrimaryColor = 0;
			public int _mSecondaryColor = 0;
			public int _mSpeed = 1;
			public EChromaSDKSceneBlend _mBlend = EChromaSDKSceneBlend.SB_None;
			public EChromaSDKSceneMode _mMode = EChromaSDKSceneMode.SM_Replace;

			public FChromaSDKDeviceFrameIndex _mFrameIndex = new FChromaSDKDeviceFrameIndex();
		}


		public class FChromaSDKScene
		{
			public List<FChromaSDKSceneEffect> _mEffects = new List<FChromaSDKSceneEffect>();
		}

__UNITY_KEY_MAPPING__

#endregion

#region Helpers (handle path conversions)

    /// <summary>
    /// Helper to convert path string to IntPtr
    /// </summary>
    /// <param name=""path""></param>
    /// <returns></returns>
    private static IntPtr GetPathIntPtr(string path)
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
    /// Helper to Ascii path string to IntPtr
    /// </summary>
    /// <param name=""str""></param>
    /// <returns></returns>
    private static IntPtr GetAsciiIntPtr(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return IntPtr.Zero;
        }
        byte[] array = ASCIIEncoding.ASCII.GetBytes(str + ""\0"");
        IntPtr lpData = Marshal.AllocHGlobal(array.Length);
        Marshal.Copy(array, 0, lpData, array.Length);
        return lpData;
    }

    /// <summary>
    /// Helper to Unicode path string to IntPtr
    /// </summary>
    /// <param name=""str""></param>
    /// <returns></returns>
    private static IntPtr GetUnicodeIntPtr(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return IntPtr.Zero;
        }
        byte[] array = UnicodeEncoding.Unicode.GetBytes(str + ""\0"");
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
__UNITY_GET_STREAMING_PATH__
#endregion";

        private const string FOOTER_UNITY =
@"  }
}";

        static bool WriteCSharp(StreamWriter swCSharp)
        {
            try
            {
                string headerCSharp = HEADER_CSHARP.Replace("__UNITY_INCLUDES__\r\n", string.Empty);
                headerCSharp = headerCSharp.Replace("__UNITY_DLL_NAME__\r\n", HEADER_CSHARP_DLL_NAME);
                headerCSharp = headerCSharp.Replace("__UNITY_KEY_MAPPING__\r\n", string.Empty);
                headerCSharp = headerCSharp.Replace("__UNITY_GET_STREAMING_PATH__\r\n", string.Empty);
                Output(swCSharp, "{0}", headerCSharp);

                Output(swCSharp, "");

                Output(swCSharp, "\t\t#region Public API Methods");

                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    if (methodInfo.Name == "CoreCreateEffect")
                    {
                        if (true)
                        {

                        }
                    }

                    Output(swCSharp, "\t\t{0}", "/// <summary>");

                    if (!string.IsNullOrEmpty(methodInfo.Comments))
                    {
                        Output(swCSharp, "\t\t/// {0}", SplitLongComments(methodInfo.Comments, "\t\t/// "));
                    }

                    Output(swCSharp, "\t\t{0}", "/// </summary>");

                    Output(swCSharp, "\t\tpublic static {0} {1}({2})",
                        ChangeToManagedType(methodInfo, methodInfo.ReturnType),
                        methodInfo.Name,
                        ChangeArgsToManagedTypes(methodInfo));

                    Output(swCSharp, "\t\t{0}", "{");
                    foreach (MetaArgInfo argInfo in methodInfo.DetailArgs)
                    {
                        if (argInfo.StrType == "char*" ||
                            argInfo.StrType == "const char*" ||
                            argInfo.StrType == "const wchar_t*")
                        {
                            string pathArg = string.Format("str_{0}", UppercaseFirstLetter(argInfo.Name));
                            Output(swCSharp, "\t\t\tstring {0} = {1};",
                                pathArg,
                                argInfo.Name);

                            string lpArg = string.Format("lp_{0}", UppercaseFirstLetter(argInfo.Name));
                            if (argInfo.StrType == "char*")
                            {
                                Output(swCSharp, "\t\t\tIntPtr {0} = GetAsciiIntPtr({1});",
                                    lpArg,
                                    pathArg);
                            }
                            else if (argInfo.StrType == "const char*")
                            {
                                if (argInfo.Name.ToUpper().Contains("PATH") ||
                                    argInfo.Name.ToUpper().Contains("ANIMATION") ||
                                    argInfo.Name.ToUpper().Contains("NAME"))
                                {
                                    Output(swCSharp, "\t\t\tIntPtr {0} = GetPathIntPtr({1});",
                                        lpArg,
                                        pathArg);
                                }
                                else
                                {
                                    Output(swCSharp, "\t\t\tIntPtr {0} = GetAsciiIntPtr({1});",
                                        lpArg,
                                        pathArg);
                                }
                            }
                            else if (argInfo.StrType == "const wchar_t*")
                            {
                                Output(swCSharp, "\t\t\tIntPtr {0} = GetUnicodeIntPtr({1});",
                                    lpArg,
                                    pathArg);
                            }

                        }
                    }
                    if (methodInfo.ReturnType == "void")
                    {
                        Output(swCSharp, "\t\t\tPlugin{0}({1});",
                            methodInfo.Name,
                            RemoveArgTypes(methodInfo));
                    }
                    else
                    {
                        if (methodInfo.ReturnType == "const char*")
                        {
                            Output(swCSharp, "\t\t\t{0} result = Marshal.PtrToStringAnsi(Plugin{1}({2}));",
                                ChangeToManagedType(methodInfo, methodInfo.ReturnType),
                                methodInfo.Name,
                                RemoveArgTypes(methodInfo));
                        }
                        else
                        {
                            Output(swCSharp, "\t\t\t{0} result = Plugin{1}({2});",
                                ChangeToManagedType(methodInfo, methodInfo.ReturnType),
                                methodInfo.Name,
                                RemoveArgTypes(methodInfo));
                        }
                    }

                    foreach (MetaArgInfo argInfo in methodInfo.DetailArgs)
                    {
                        if (argInfo.StrType == "char*" || 
                            argInfo.StrType == "const char*" ||
                            argInfo.StrType == "const wchar_t*")
                        {
                            string lpArg = string.Format("lp_{0}", UppercaseFirstLetter(argInfo.Name));

                            if (argInfo.StrType == "char*")
                            {
                                Output(swCSharp, "\t\t\tif ({0} != IntPtr.Zero)", lpArg);
                                Output(swCSharp, "\t\t\t{0}", "{");
                                Output(swCSharp, "\t\t\t\t{0} = Marshal.PtrToStringAnsi({1});", argInfo.Name, lpArg);
                                Output(swCSharp, "\t\t\t{0}", "}");
                            }

                            Output(swCSharp, "\t\t\tFreeIntPtr({0});",
                                lpArg);

                        }
                    }

                    if (methodInfo.ReturnType != "void")
                    {
                        Output(swCSharp, "\t\t\treturn result;");
                    }

                    Output(swCSharp, "\t\t{0}", "}");
                }

                Output(swCSharp, "\t\t#endregion");

                Output(swCSharp, "");

                Output(swCSharp, "\t\t#region Private DLL Hooks");

                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    if (methodInfo.Name == "CoreCreateEffect")
                    {
                        if (true)
                        {

                        }
                    }

                    Output(swCSharp, "\t\t{0}", "/// <summary>");

                    if (!string.IsNullOrEmpty(methodInfo.Comments))
                    {
                        Output(swCSharp, "\t\t/// {0}", SplitLongComments(methodInfo.Comments, "\t\t/// "));
                    }

                    Output(swCSharp, "\t\t/// EXPORT_API {0} Plugin{1}({2});",
                        methodInfo.ReturnType,
                        methodInfo.Name,
                        methodInfo.Args);

                    Output(swCSharp, "\t\t{0}", "/// </summary>");

                    Output(swCSharp, "\t\t{0}", "[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]");

                    Output(swCSharp, "\t\tprivate static extern {0} Plugin{1}({2});",
                        ChangeToManagedImportType(methodInfo, methodInfo.ReturnType),
                        methodInfo.Name,
                        ChangeArgsToManagedImportTypes(methodInfo, methodInfo.Args));
                }

                Output(swCSharp, "\t\t#endregion");

                Output(swCSharp, "{0}", FOOTER_UNITY);

                swCSharp.Flush();
                swCSharp.Close();

                return true;
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Failed to write unity!");
                return false;
            }
        }

        static bool WriteUnity(StreamWriter swUnity)
        {
            try
            {
                string headerUnity = HEADER_CSHARP.Replace("__UNITY_INCLUDES__", HEADER_UNITY_INCLUDES);
                headerUnity = headerUnity.Replace("__UNITY_DLL_NAME__", HEADER_UNITY_DLL_NAME);
                headerUnity = headerUnity.Replace("__UNITY_KEY_MAPPING__", HEADER_UNITY_KEY_MAPPING);
                headerUnity = headerUnity.Replace("__UNITY_GET_STREAMING_PATH__", HEADER_UNITY_GET_STREAMING_PATH);
                Output(swUnity, "{0}", headerUnity);

                Output(swUnity, "");

                Output(swUnity, "\t\t#region Public API Methods");

                Output(swUnity, "\t\tpublic static string _sStreamingAssetPath = string.Empty;");

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
                        ChangeToManagedType(methodInfo, methodInfo.ReturnType),
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
                        if (methodInfo.ReturnType == "const char*")
                        {
                            Output(swUnity, "\t\t\t{0} result = Marshal.PtrToStringAnsi(Plugin{1}({2}));",
                                ChangeToManagedType(methodInfo, methodInfo.ReturnType),
                                methodInfo.Name,
                                RemoveArgTypes(methodInfo));
                        }
                        else
                        {
                            Output(swUnity, "\t\t\t{0} result = Plugin{1}({2});",
                                ChangeToManagedType(methodInfo, methodInfo.ReturnType),
                                methodInfo.Name,
                                RemoveArgTypes(methodInfo));
                        }
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

                    if (methodInfo.Name == "CoreCreateEffect")
                    {
                        if (true)
                        {

                        }
                    }

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
                        ChangeToManagedImportType(methodInfo, methodInfo.ReturnType),
                        methodInfo.Name,
                        ChangeArgsToManagedImportTypes(methodInfo, methodInfo.Args));
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

        static bool WriteCSharpDocs(StreamWriter swUnityDocs, string apiClass)
        {
            try
            {
                string header = @"<a name=""api""></a>
## API
";
                Output(swUnityDocs, header);

                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;
                    Output(swUnityDocs, "* [{0}](#{0})", methodInfo.Name);
                }

                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(swUnityDocs, "---");
                    Output(swUnityDocs, string.Empty);

                    Output(swUnityDocs, @"<a name=""{0}""></a>", methodInfo.Name);
                    Output(swUnityDocs, @"**{0}**", methodInfo.Name);
                    Output(swUnityDocs, string.Empty);

                    if (!string.IsNullOrEmpty(methodInfo.Comments))
                    {
                        Output(swUnityDocs, "{0}", SplitLongComments(methodInfo.Comments, ""));
                        Output(swUnityDocs, string.Empty);
                    }

                    Output(swUnityDocs, "{0}", "```charp");
                    if (methodInfo.ReturnType == "void")
                    {
                        Output(swUnityDocs, "{0}.{1}({2});", apiClass, methodInfo.Name, ChangeArgsToManagedTypes(methodInfo));
                    }
                    else
                    {
                        Output(swUnityDocs, "{0} result = {1}.{2}({3});",
                                ChangeToManagedType(methodInfo, methodInfo.ReturnType),
                                apiClass,
                                methodInfo.Name,
                                ChangeArgsToManagedTypes(methodInfo));
                    }
                    Output(swUnityDocs, "{0}", "```");
                    Output(swUnityDocs, string.Empty);
                }

                swUnityDocs.Flush();
                swUnityDocs.Close();

                return true;
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Failed to write unity!");
                return false;
            }
        }

        #region VB

        private const string HEADER_VB =
@"Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text

Namespace ChromaSDK

    Public class Keyboard
    
        REM //! Definitions of keys.
        Public Enum RZKEY
            RZKEY_ESC = &H0001                 REM /*!< Esc (VK_ESCAPE) */
            RZKEY_F1 = &H0003                  REM /*!< F1 (VK_F1) */
            RZKEY_F2 = &H0004                  REM /*!< F2 (VK_F2) */
            RZKEY_F3 = &H0005                  REM /*!< F3 (VK_F3) */
            RZKEY_F4 = &H0006                  REM /*!< F4 (VK_F4) */
            RZKEY_F5 = &H0007                  REM /*!< F5 (VK_F5) */
            RZKEY_F6 = &H0008                  REM /*!< F6 (VK_F6) */
            RZKEY_F7 = &H0009                  REM /*!< F7 (VK_F7) */
            RZKEY_F8 = &H000A                  REM /*!< F8 (VK_F8) */
            RZKEY_F9 = &H000B                  REM /*!< F9 (VK_F9) */
            RZKEY_F10 = &H000C                 REM /*!< F10 (VK_F10) */
            RZKEY_F11 = &H000D                 REM /*!< F11 (VK_F11) */
            RZKEY_F12 = &H000E                 REM /*!< F12 (VK_F12) */
            RZKEY_1 = &H0102                   REM /*!< 1 (VK_1) */
            RZKEY_2 = &H0103                   REM /*!< 2 (VK_2) */
            RZKEY_3 = &H0104                   REM /*!< 3 (VK_3) */
            RZKEY_4 = &H0105                   REM /*!< 4 (VK_4) */
            RZKEY_5 = &H0106                   REM /*!< 5 (VK_5) */
            RZKEY_6 = &H0107                   REM /*!< 6 (VK_6) */
            RZKEY_7 = &H0108                   REM /*!< 7 (VK_7) */
            RZKEY_8 = &H0109                   REM /*!< 8 (VK_8) */
            RZKEY_9 = &H010A                   REM /*!< 9 (VK_9) */
            RZKEY_0 = &H010B                   REM /*!< 0 (VK_0) */
            RZKEY_A = &H0302                   REM /*!< A (VK_A) */
            RZKEY_B = &H0407                   REM /*!< B (VK_B) */
            RZKEY_C = &H0405                   REM /*!< C (VK_C) */
            RZKEY_D = &H0304                   REM /*!< D (VK_D) */
            RZKEY_E = &H0204                   REM /*!< E (VK_E) */
            RZKEY_F = &H0305                   REM /*!< F (VK_F) */
            RZKEY_G = &H0306                   REM /*!< G (VK_G) */
            RZKEY_H = &H0307                   REM /*!< H (VK_H) */
            RZKEY_I = &H0209                   REM /*!< I (VK_I) */
            RZKEY_J = &H0308                   REM /*!< J (VK_J) */
            RZKEY_K = &H0309                   REM /*!< K (VK_K) */
            RZKEY_L = &H030A                   REM /*!< L (VK_L) */
            RZKEY_M = &H0409                   REM /*!< M (VK_M) */
            RZKEY_N = &H0408                   REM /*!< N (VK_N) */
            RZKEY_O = &H020A                   REM /*!< O (VK_O) */
            RZKEY_P = &H020B                   REM /*!< P (VK_P) */
            RZKEY_Q = &H0202                   REM /*!< Q (VK_Q) */
            RZKEY_R = &H0205                   REM /*!< R (VK_R) */
            RZKEY_S = &H0303                   REM /*!< S (VK_S) */
            RZKEY_T = &H0206                   REM /*!< T (VK_T) */
            RZKEY_U = &H0208                   REM /*!< U (VK_U) */
            RZKEY_V = &H0406                   REM /*!< V (VK_V) */
            RZKEY_W = &H0203                   REM /*!< W (VK_W) */
            RZKEY_X = &H0404                   REM /*!< X (VK_X) */
            RZKEY_Y = &H0207                   REM /*!< Y (VK_Y) */
            RZKEY_Z = &H0403                   REM /*!< Z (VK_Z) */
            RZKEY_NUMLOCK = &H0112             REM /*!< Numlock (VK_NUMLOCK) */
            RZKEY_NUMPAD0 = &H0513             REM /*!< Numpad 0 (VK_NUMPAD0) */
            RZKEY_NUMPAD1 = &H0412             REM /*!< Numpad 1 (VK_NUMPAD1) */
            RZKEY_NUMPAD2 = &H0413             REM /*!< Numpad 2 (VK_NUMPAD2) */
            RZKEY_NUMPAD3 = &H0414             REM /*!< Numpad 3 (VK_NUMPAD3) */
            RZKEY_NUMPAD4 = &H0312             REM /*!< Numpad 4 (VK_NUMPAD4) */
            RZKEY_NUMPAD5 = &H0313             REM /*!< Numpad 5 (VK_NUMPAD5) */
            RZKEY_NUMPAD6 = &H0314             REM /*!< Numpad 6 (VK_NUMPAD6) */
            RZKEY_NUMPAD7 = &H0212             REM /*!< Numpad 7 (VK_NUMPAD7) */
            RZKEY_NUMPAD8 = &H0213             REM /*!< Numpad 8 (VK_NUMPAD8) */
            RZKEY_NUMPAD9 = &H0214             REM /*!< Numpad 9 (VK_ NUMPAD9*/
            RZKEY_NUMPAD_DIVIDE = &H0113       REM /*!< Divide (VK_DIVIDE) */
            RZKEY_NUMPAD_MULTIPLY = &H0114     REM /*!< Multiply (VK_MULTIPLY) */
            RZKEY_NUMPAD_SUBTRACT = &H0115     REM /*!< Subtract (VK_SUBTRACT) */
            RZKEY_NUMPAD_ADD = &H0215          REM /*!< Add (VK_ADD) */
            RZKEY_NUMPAD_ENTER = &H0415        REM /*!< Enter (VK_RETURN - Extended) */
            RZKEY_NUMPAD_DECIMAL = &H0514      REM /*!< Decimal (VK_DECIMAL) */
            RZKEY_PRINTSCREEN = &H000F         REM /*!< Print Screen (VK_PRINT) */
            RZKEY_SCROLL = &H0010              REM /*!< Scroll Lock (VK_SCROLL) */
            RZKEY_PAUSE = &H0011               REM /*!< Pause (VK_PAUSE) */
            RZKEY_INSERT = &H010F              REM /*!< Insert (VK_INSERT) */
            RZKEY_HOME = &H0110                REM /*!< Home (VK_HOME) */
            RZKEY_PAGEUP = &H0111              REM /*!< Page Up (VK_PRIOR) */
            RZKEY_DELETE = &H020f              REM /*!< Delete (VK_DELETE) */
            RZKEY_END = &H0210                 REM /*!< End (VK_END) */
            RZKEY_PAGEDOWN = &H0211            REM /*!< Page Down (VK_NEXT) */
            RZKEY_UP = &H0410                  REM /*!< Up (VK_UP) */
            RZKEY_LEFT = &H050F                REM /*!< Left (VK_LEFT) */
            RZKEY_DOWN = &H0510                REM /*!< Down (VK_DOWN) */
            RZKEY_RIGHT = &H0511               REM /*!< Right (VK_RIGHT) */
            RZKEY_TAB = &H0201                 REM /*!< Tab (VK_TAB) */
            RZKEY_CAPSLOCK = &H0301            REM /*!< Caps Lock(VK_CAPITAL) */
            RZKEY_BACKSPACE = &H010E           REM /*!< Backspace (VK_BACK) */
            RZKEY_ENTER = &H030E               REM /*!< Enter (VK_RETURN) */
            RZKEY_LCTRL = &H0501               REM /*!< Left Control(VK_LCONTROL) */
            RZKEY_LWIN = &H0502                REM /*!< Left Window (VK_LWIN) */
            RZKEY_LALT = &H0503                REM /*!< Left Alt (VK_LMENU) */
            RZKEY_SPACE = &H0507               REM /*!< Spacebar (VK_SPACE) */
            RZKEY_RALT = &H050B                REM /*!< Right Alt (VK_RMENU) */
            RZKEY_FN = &H050C                  REM /*!< Function key. */
            RZKEY_RMENU = &H050D               REM /*!< Right Menu (VK_APPS) */
            RZKEY_RCTRL = &H050E               REM /*!< Right Control (VK_RCONTROL) */
            RZKEY_LSHIFT = &H0401              REM /*!< Left Shift (VK_LSHIFT) */
            RZKEY_RSHIFT = &H040E              REM /*!< Right Shift (VK_RSHIFT) */
            RZKEY_MACRO1 = &H0100              REM /*!< Macro Key 1 */
            RZKEY_MACRO2 = &H0200              REM /*!< Macro Key 2 */
            RZKEY_MACRO3 = &H0300              REM /*!< Macro Key 3 */
            RZKEY_MACRO4 = &H0400              REM /*!< Macro Key 4 */
            RZKEY_MACRO5 = &H0500              REM /*!< Macro Key 5 */
            RZKEY_OEM_1 = &H0101               REM /*!< ~ (tilde/半角/全角) (VK_OEM_3) */
            RZKEY_OEM_2 = &H010C               REM /*!< -- (minus) (VK_OEM_MINUS) */
            RZKEY_OEM_3 = &H010D               REM /*!< = (equal) (VK_OEM_PLUS) */
            RZKEY_OEM_4 = &H020C               REM /*!< [ (left sqaure bracket) (VK_OEM_4) */
            RZKEY_OEM_5 = &H020D               REM /*!< ] (right square bracket) (VK_OEM_6) */
            RZKEY_OEM_6 = &H020E               REM /*!< \ (backslash) (VK_OEM_5) */
            RZKEY_OEM_7 = &H030B               REM /*!< ; (semi-colon) (VK_OEM_1) */
            RZKEY_OEM_8 = &H030C               REM /*!< ' (apostrophe) (VK_OEM_7) */
            RZKEY_OEM_9 = &H040A               REM /*!< , (comma) (VK_OEM_COMMA) */
            RZKEY_OEM_10 = &H040B              REM /*!< . (period) (VK_OEM_PERIOD) */
            RZKEY_OEM_11 = &H040C              REM /*!< / (forward slash) (VK_OEM_2) */
            RZKEY_EUR_1 = &H030D               REM /*!< ""#"" (VK_OEM_5) */
            RZKEY_EUR_2 = &H0402               REM /*!< \ (VK_OEM_102) */
            RZKEY_JPN_1 = &H0015               REM /*!< ¥ (&HFF) */
            RZKEY_JPN_2 = &H040D               REM /*!< \ (&HC1) */
            RZKEY_JPN_3 = &H0504               REM /*!< 無変換 (VK_OEM_PA1) */
            RZKEY_JPN_4 = &H0509               REM /*!< 変換 (&HFF) */
            RZKEY_JPN_5 = &H050A               REM /*!< ひらがな/カタカナ (&HFF) */
            RZKEY_KOR_1 = &H0015               REM /*!< | (&HFF) */
            RZKEY_KOR_2 = &H030D               REM /*!< (VK_OEM_5) */
            RZKEY_KOR_3 = &H0402               REM /*!< (VK_OEM_102) */
            RZKEY_KOR_4 = &H040D               REM /*!< (&HC1) */
            RZKEY_KOR_5 = &H0504               REM /*!< (VK_OEM_PA1) */
            RZKEY_KOR_6 = &H0509               REM /*!< 한/영 (&HFF) */
            RZKEY_KOR_7 = &H050A               REM /*!< (&HFF) */
            RZKEY_INVALID = &HFFFF              REM /*!< Invalid keys. */
        End Enum

        REM //! Definition of LEDs.
        Public Enum RZLED
            RZLED_LOGO = &HE0014                 REM /*!< Razer logo */
        End Enum
    End Class

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
	Public Structure APPINFOTYPE
		<MarshalAs(UnmanagedType.ByValTStr, SizeConst := 256)>
		Public Title As String REM //TCHAR Title[256];

		<MarshalAs(UnmanagedType.ByValTStr, SizeConst := 1024)>
		Public Description As String REM //TCHAR Description[1024];

		<MarshalAs(UnmanagedType.ByValTStr, SizeConst := 256)>
		Public Author_Name As String REM //TCHAR Name[256];

		<MarshalAs(UnmanagedType.ByValTStr, SizeConst := 256)>
		Public Author_Contact As String REM //TCHAR Contact[256];

		Public SupportedDevice As UInt32 REM //DWORD SupportedDevice;

		Public Category As UInt32 REM //DWORD Category;
	End Structure

    <StructLayout(LayoutKind.Sequential)>
    Public Structure FChromaSDKGuid
        Public Data As Guid
    End Structure

    <StructLayout(LayoutKind.Sequential)>
    Public Structure DEVICE_INFO_TYPE
        Public DeviceType as Integer
        Public Connected as UInteger
    End Structure

    Public Enum EFFECT_TYPE
        CHROMA_NONE = 0            REM //!< No effect.
        CHROMA_WAVE                REM //!< Wave effect (This effect type has deprecated and should not be used).
        CHROMA_SPECTRUMCYCLING     REM //!< Spectrum cycling effect (This effect type has deprecated and should not be used).
        CHROMA_BREATHING           REM //!< Breathing effect (This effect type has deprecated and should not be used).
        CHROMA_BLINKING            REM //!< Blinking effect (This effect type has deprecated and should not be used).
        CHROMA_REACTIVE            REM //!< Reactive effect (This effect type has deprecated and should not be used).
        CHROMA_STATIC              REM //!< Static effect.
        CHROMA_CUSTOM              REM //!< Custom effect. For mice, please see Mouse::CHROMA_CUSTOM2.
        CHROMA_RESERVED            REM //!< Reserved
        CHROMA_INVALID             REM //!< Invalid effect.
    End Enum

    Namespace Stream

        Public Enum StreamStatusType
            READY = 0                  REM // ready for commands
            AUTHORIZING = 1            REM // the session is being authorized
            BROADCASTING = 2           REM // the session is being broadcast
            WATCHING = 3               REM // A stream is being watched
            NOT_AUTHORIZED = 4         REM // The session is not authorized
            BROADCAST_DUPLICATE = 5    REM // The session has duplicate broadcasters
            SERVICE_OFFLINE = 6        REM // The service is offline
        End Enum

        Public Class _Default
            Const LENGTH_SHORTCODE As UInteger = 6
            Const LENGTH_STREAM_ID As UInteger = 48
            Const LENGTH_STREAM_KEY As UInteger = 48
            Const LENGTH_STREAM_FOCUS As UInteger = 48

            Public Shared Function GetDefaultString(length As UInteger) As String
                Dim result As String = String.Empty
                For i As UInteger = 0 To length Step 1
                    result += "" ""
                Next
                Return result
            End Function

            Public Shared ReadOnly Shortcode As String = GetDefaultString(LENGTH_SHORTCODE)
            Public Shared ReadOnly StreamId As String = GetDefaultString(LENGTH_STREAM_ID)
            Public Shared ReadOnly StreamKey As String = GetDefaultString(LENGTH_STREAM_KEY)
            Public Shared ReadOnly StreamFocus As String = GetDefaultString(LENGTH_STREAM_FOCUS)
        End Class
    End Namespace

    Module ChromaAnimationAPI

#If X64 Then
        Const DLL_NAME As String = ""CChromaEditorLibrary64""
#Else
        Const DLL_NAME As String = ""CChromaEditorLibrary""
#End If

#Region ""Data Structures""

        Public Enum DeviceType
            Invalid = -1
            DE_1D = 0
            DE_2D = 1
            MAX = 2
        End Enum

        Public Enum Device
            Invalid = -1
            ChromaLink = 0
            Headset = 1
            Keyboard = 2
            Keypad = 3
            Mouse = 4
            Mousepad = 5
            MAX = 6
        End Enum

        Public Enum Device1D
            Invalid = -1
            ChromaLink = 0
            Headset = 1
            Mousepad = 2
            MAX = 3
        End Enum

        Public Enum Device2D
            Invalid = -1
            Keyboard = 0
            Keypad = 1
            Mouse = 2
            MAX = 3
        End Enum

        Public Class FChromaSDKDeviceFrameIndex
            REM // Index corresponds to EChromaSDKDeviceEnum
            Public _mFrameIndex() As Integer = New Integer() {0, 0, 0, 0, 0, 0}

            Public Function FChromaSDKDeviceFrameIndex()
                _mFrameIndex(Device.ChromaLink) = 0
                _mFrameIndex(Device.Headset) = 0
                _mFrameIndex(Device.Keyboard) = 0
                _mFrameIndex(Device.Keypad) = 0
                _mFrameIndex(Device.Mouse) = 0
                _mFrameIndex(Device.Mousepad) = 0
                Return Nothing
            End Function
        End Class

		Public Enum EChromaSDKSceneBlend
			SB_None
			SB_Invert
			SB_Threshold
			SB_Lerp
		End Enum

		Public Enum EChromaSDKSceneMode
			SM_Replace
			SM_Max
			SM_Min
			SM_Average
			SM_Multiply
			SM_Add
			SM_Subtract
		End Enum

        Public Class FChromaSDKSceneEffect
            Public _mAnimation As String = """"
            Public _mState As Boolean = False
            Public _mPrimaryColor As Integer = 0
            Public _mSecondaryColor As Integer = 0
            Public _mSpeed As Integer = 1
            Public _mBlend As EChromaSDKSceneBlend = EChromaSDKSceneBlend.SB_None
            Public _mMode As EChromaSDKSceneMode = EChromaSDKSceneMode.SM_Replace

            Public _mFrameIndex As FChromaSDKDeviceFrameIndex = New FChromaSDKDeviceFrameIndex()
        End Class

		Public Class FChromaSDKScene
			Public _mEffects As List(Of FChromaSDKSceneEffect) = New List(Of FChromaSDKSceneEffect)
		End Class

#End Region

#Region ""Helpers (handle path conversions)""

    REM /// <summary>
    REM /// Helper to convert path string to IntPtr
    REM /// </summary>
    REM /// <param name=""path""></param>
    REM /// <returns></returns>
    Private Function GetPathIntPtr(path As String) As IntPtr
        If (String.IsNullOrEmpty(path)) Then
            Return IntPtr.Zero
        End If
        Dim fi As FileInfo = New FileInfo(path)
        Dim array As Byte() = ASCIIEncoding.ASCII.GetBytes(fi.FullName + ""\0"")
        Dim lpData As IntPtr = Marshal.AllocHGlobal(array.Length)
        Marshal.Copy(array, 0, lpData, array.Length)
        Return lpData
    End Function

    REM /// <summary>
    REM /// Helper to Ascii path string to IntPtr
    REM /// </summary>
    REM /// <param name=""str""></param>
    REM /// <returns></returns>
    Private Function GetAsciiIntPtr(str As String) As IntPtr
        If (String.IsNullOrEmpty(str)) Then
            Return IntPtr.Zero
        End If
        Dim array As Byte() = ASCIIEncoding.ASCII.GetBytes(str + ""\0"")
        Dim lpData As IntPtr = Marshal.AllocHGlobal(array.Length)
        Marshal.Copy(array, 0, lpData, array.Length)
        Return lpData
    End Function

    REM /// <summary>
    REM /// Helper to Unicode path string to IntPtr
    REM /// </summary>
    REM /// <param name=""str""></param>
    REM /// <returns></returns>
    Private Function GetUnicodeIntPtr(str As String) As IntPtr
        If (String.IsNullOrEmpty(str)) Then
            Return IntPtr.Zero
        End If
        Dim array As Byte() = UnicodeEncoding.Unicode.GetBytes(str + ""\0"")
        Dim lpData As IntPtr = Marshal.AllocHGlobal(array.Length)
        Marshal.Copy(array, 0, lpData, array.Length)
        Return lpData
    End Function

    REM /// <summary>
    REM /// Helper to recycle the IntPtr
    REM /// </summary>
    REM /// <param name=""lpData""></param>
    Private Function FreeIntPtr(lpData As IntPtr)
        If (lpData <> IntPtr.Zero) Then
            Marshal.FreeHGlobal(lpData)
        End If
        Return Nothing
    End Function

#End Region";

        private const string FOOTER_VB =
@"  End Module
End Namespace
";

        static string ChangeToVBType(string input)
        {
            string pre = string.Empty;
            string result = input;

            const string TOKEN_OUT = "out ";
            const string TOKEN_REF = "ref ";
            if (input.StartsWith(TOKEN_OUT) ||
                input.StartsWith(TOKEN_REF))
            {
                pre = input.Substring(0, TOKEN_OUT.Length);
                result = input.Substring(TOKEN_OUT.Length);
            }
            
            switch (result)
            {
                case "bool":
                    result = "Boolean";
                    break;
                case "int":
                    result = "Integer";
                    break;
                case "uint":
                    result = "UInteger";
                    break;
                case "int[]":
                    result = "Integer()";
                    break;
                case "uint[]":
                    result = "UInteger()";
                    break;
                case "float":
                    result = "Single";
                    break;
                case "double":
                    result = "Double";
                    break;
                case "byte[]":
                    result = "Byte()";
                    break;
            }
            return pre + result;
        }

        private static string TrimArgTypeVB(string argType)
        {
            string result = "";
            bool hadWhitespace = false;
            foreach (char c in argType)
            {
                if (c == '&' ||
                    c == '*' ||
                    c == ':' ||
                    c == '_' ||
                    c == '[' ||
                    c == ']')
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

        private static string ChangeToVBImportType(MetaMethodInfo methodInfo, string strType)
        {
            // this is for private methods
            if (strType == "int[]")
            {
                return "Integer()";
            }
            else if (strType == "byte[]")
            {
                return "Byte()";
            }
            else if (strType == "ChromaSDK.Stream.StreamStatusType")
            {
                return strType;
            }
            else if (strType == "ref ChromaSDK.APPINFOTYPE")
            {
                return strType;
            }
            string result = TrimArgTypeVB(strType);
            if (result == "const int")
            {
                result = "int";
            }
            else if (result == "int*")
            {
                result = "int[]";
            }
            else if (result == "const byte*")
            {
                result = "byte[]";
            }
            else if (result == "const int*")
            {
                result = "int[]";
            }
            else if (result == "const char*")
            {
                result = "IntPtr";
            }
            else if (result == "const wchar_t*")
            {
                result = "IntPtr";
            }
            else if (result == "char*")
            {
                result = "IntPtr";
            }
            else if (result == "unsigned char*")
            {
                result = "out byte";
            }
            else if (result == "float*")
            {
                result = "out float";
            }
            else if (result == "unsigned long long")
            {
                result = "ulong";
            }
            else if (result == "RZRESULT")
            {
                result = "int";
            }
            else if (result == "ChromaSDK::EFFECT_TYPE")
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
                result = "out DEVICE_INFO_TYPE";
            }
            else if (result == "const ChromaSDK::FChromaSDKGuid&")
            {
                result = "Guid";
            }
            else if (result == "ChromaSDK::FChromaSDKGuid*")
            {
                result = "out FChromaSDKGuid";
            }
            else if (result == "RZDEVICEID")
            {
                result = "Guid";
            }
            else if (result == "RZEFFECTID")
            {
                result = "Guid";
            }
            else if (result == "RZEFFECTID*")
            {
                result = "out Guid";
            }
            else if (result == "PRZPARAM")
            {
                result = "IntPtr";
            }
            else if (result == "DebugLogPtr")
            {
                result = "IntPtr";
            }
            else if (result == "ChromaSDK::APPINFOTYPE*")
            {
                result = "ref ChromaSDK.APPINFOTYPE";
            }
            else if (result == "ChromaSDK::Stream::StreamStatusType")
            {
                result = "ChromaSDK.Stream.StreamStatusType";
            }

            if (result == "bool")
            {
                return "Boolean";
            }
            else if (result == "int")
            {
                return "Integer";
            }
            else if (result == "float")
            {
                return "Single";
            }
            else if (result == "double")
            {
                return "Double";
            }

            return result;
        }

        static string ChangeArgsToVBTypes(MetaMethodInfo methodInfo)
        {
            string[] parts = methodInfo.Args.Split(",".ToCharArray());
            for (int i = 0; i < parts.Length; ++i)
            {
                string part = parts[i].Trim();
                int indexName = GetIndexArgumentBeforeName(part);
                if (indexName > 0)
                {
                    string strType = part.Substring(0, indexName + 1).Trim();
                    strType = ChangeToManagedType(methodInfo, strType);
                    string name = part.Substring(indexName + 1).Trim();
                    if (name == "end") // reserved
                    {
                        name = "renamed_end";
                    }
                    else if (name == "to") // reserved
                    {
                        name = "renamed_to";
                    }
                    else if (name == "loop") // reserved
                    {
                        name = "renamed_loop";
                    }

                    MetaArgInfo argInfo = methodInfo.DetailArgs[i];
                    if (null != argInfo.OverrideInfo &&
                        !string.IsNullOrEmpty(argInfo.OverrideInfo.OverrideType))
                    {
                        strType = argInfo.OverrideInfo.OverrideType;
                    }

                    string vbType = ChangeToVBType(strType);
                    const string TOKEN_OUT = "out ";
                    const string TOKEN_REF = "ref ";
                    if (vbType.StartsWith(TOKEN_OUT) ||
                        vbType.StartsWith(TOKEN_REF))
                    {
                        vbType = vbType.Substring(TOKEN_OUT.Length);
                        if (i == 0)
                        {
                            parts[i] = "ByRef " + LowercaseFirstLetter(name) + " As " + vbType;
                        }
                        else
                        {
                            parts[i] = " ByRef " + LowercaseFirstLetter(name) + " As " + vbType;
                        }
                    }
                    else
                    {
                        if (i == 0)
                        {
                            parts[i] = LowercaseFirstLetter(name) + " As " + vbType;
                        }
                        else
                        {
                            parts[i] = " " + LowercaseFirstLetter(name) + " As " + vbType;
                        }
                    }
                }
            }
            return string.Join(",", parts);
        }

        private static string ChangeArgsToVBImportTypes(MetaMethodInfo methodInfo, string args)
        {
            string[] parts = args.Split(",".ToCharArray());
            for (int i = 0; i < parts.Length; ++i)
            {
                string part = parts[i].Trim();
                int indexName = GetIndexArgumentBeforeName(part);
                if (indexName > 0)
                {
                    string strType = ChangeToVBImportType(methodInfo, ChangeToManagedImportType(methodInfo, part.Substring(0, indexName + 1).Trim()));
                    string name = part.Substring(indexName + 1).Trim();
                    if (name == "end") // reserved
                    {
                        name = "renamed_end";
                    }
                    else if (name == "to") // reserved
                    {
                        name = "renamed_to";
                    }
                    else if (name == "loop") // reserved
                    {
                        name = "renamed_loop";
                    }

                    string vbType = ChangeToVBType(strType);
                    const string TOKEN_OUT = "out ";
                    const string TOKEN_REF = "ref ";
                    if (vbType.StartsWith(TOKEN_OUT) ||
                        vbType.StartsWith(TOKEN_REF))
                    {
                        vbType = vbType.Substring(TOKEN_OUT.Length);
                        if (i == 0)
                        {
                            parts[i] = "ByRef " + LowercaseFirstLetter(name) + " As " + vbType;
                        }
                        else
                        {
                            parts[i] = " ByRef " + LowercaseFirstLetter(name) + " As " + vbType;

                        }
                    }
                    else
                    {
                        if (i == 0)
                        {
                            parts[i] = LowercaseFirstLetter(name) + " As " + vbType;
                        }
                        else
                        {
                            parts[i] = " " + LowercaseFirstLetter(name) + " As " + vbType;

                        }
                    }
                }
            }
            return string.Join(",", parts);
        }

        static string RemoveVBArgTypes(MetaMethodInfo methodInfo)
        {
            string[] parts = methodInfo.Args.Split(",".ToCharArray());
            for (int i = 0; i < parts.Length; ++i)
            {
                string part = parts[i].TrimEnd();
                int indexName = GetIndexArgumentBeforeName(part);
                if (indexName > 0)
                {
                    string name = part.Substring(indexName + 1);
                    if (name == "end") // reserved
                    {
                        name = "renamed_end";
                    }
                    else if (name == "to") // reserved
                    {
                        name = "renamed_to";
                    }
                    else if (name == "loop") // reserved
                    {
                        name = "renamed_loop";
                    }
                    MetaArgInfo argInfo = methodInfo.DetailArgs[i];
                    if (argInfo.StrType == "char*" ||
                        argInfo.StrType == "const char*" ||
                        argInfo.StrType == "const wchar_t*")
                    {
                        string lpArg = string.Format("lp_{0}", UppercaseFirstLetter(name));
                        name = lpArg;
                    }
                    else if (argInfo.StrType == "unsigned char*")
                    {
                        name = string.Format("{0}", name);
                    }
                    if (null != argInfo.OverrideInfo)
                    {
                        if (argInfo.OverrideInfo.UseRef)
                        {
                            name = LowercaseFirstLetter(name);
                        }
                        else if (argInfo.OverrideInfo.UseOut)
                        {
                            name = LowercaseFirstLetter(name);
                        }
                        /*
                        else if (!string.IsNullOrEmpty(argInfo.OverrideInfo.OverrideType))
                        {
                            name = LowercaseFirstLetter(string.Format("{0}{1}{2}{3}",
                                string.IsNullOrEmpty(argInfo.OverrideInfo.CastType) ? "" : "(",
                                argInfo.OverrideInfo.CastType,
                                string.IsNullOrEmpty(argInfo.OverrideInfo.CastType) ? "" : ")",
                                LowercaseFirstLetter(name)));
                        }
                        */
                    }
                    if (i > 0)
                    {
                        name = " " + LowercaseFirstLetter(name);
                    }
                    parts[i] = LowercaseFirstLetter(name);
                }
            }
            return string.Join(",", parts);
        }

        static bool WriteVB(StreamWriter swVB)
        {
            try
            {
                string headerVB = HEADER_VB;
                Output(swVB, "{0}", headerVB);

                Output(swVB, "");

                Output(swVB, "\t\t#Region \"Public API Methods\"");

                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(swVB, "\t\tREM {0}", "/// <summary>");

                    if (!string.IsNullOrEmpty(methodInfo.Comments))
                    {
                        Output(swVB, "\t\tREM /// {0}", SplitLongComments(methodInfo.Comments, "\t\tREM /// "));
                    }

                    Output(swVB, "\t\tREM {0}", "/// </summary>");

                    if (ChangeToManagedType(methodInfo, methodInfo.ReturnType) == "void")
                    {
                        Output(swVB, "\t\tPublic Function {0}({1})",
                            methodInfo.Name,
                            ChangeArgsToVBTypes(methodInfo));
                    }
                    else
                    {
                        Output(swVB, "\t\tPublic Function {0}({1}) As {2}",
                            methodInfo.Name,
                            ChangeArgsToVBTypes(methodInfo),
                            ChangeToVBType(ChangeToManagedType(methodInfo, methodInfo.ReturnType)));
                    }

                    foreach (MetaArgInfo argInfo in methodInfo.DetailArgs)
                    {
                        if (argInfo.StrType == "char*" ||
                            argInfo.StrType == "const char*" ||
                            argInfo.StrType == "const wchar_t*")
                        {
                            string pathArg = string.Format("str_{0}", UppercaseFirstLetter(argInfo.Name));
                            Output(swVB, "\t\t\tDim {0} As String = {1}",
                                pathArg,
                                argInfo.Name);

                            string lpArg = string.Format("lp_{0}", UppercaseFirstLetter(argInfo.Name));
                            if (argInfo.StrType == "char*")
                            {
                                Output(swVB, "\t\t\tDim {0} as IntPtr = GetAsciiIntPtr({1})",
                                    lpArg,
                                    pathArg);
                            }
                            else if (argInfo.StrType == "const char*")
                            {
                                if (argInfo.Name.ToUpper().Contains("PATH") ||
                                    argInfo.Name.ToUpper().Contains("ANIMATION") ||
                                    argInfo.Name.ToUpper().Contains("NAME"))
                                {
                                    Output(swVB, "\t\t\tDim {0} As IntPtr = GetPathIntPtr({1})",
                                        lpArg,
                                        pathArg);
                                }
                                else
                                {
                                    Output(swVB, "\t\t\tDim {0} As IntPtr = GetAsciiIntPtr({1})",
                                        lpArg,
                                        pathArg);
                                }
                            }
                            else if (argInfo.StrType == "const wchar_t*")
                            {
                                Output(swVB, "\t\t\tDim {0} As IntPtr = GetUnicodeIntPtr({1})",
                                    lpArg,
                                    pathArg);
                            }

                        }
                    }
                    if (methodInfo.ReturnType == "void")
                    {
                        Output(swVB, "\t\t\tPlugin{0}({1})",
                            methodInfo.Name,
                            RemoveVBArgTypes(methodInfo));
                    }
                    else
                    {
                        if (methodInfo.ReturnType == "const char*")
                        {
                            Output(swVB, "\t\t\tDim result As {0} = Marshal.PtrToStringAnsi(Plugin{1}({2}))",
                                ChangeToVBType(ChangeToManagedType(methodInfo, methodInfo.ReturnType)),
                                methodInfo.Name,
                                RemoveVBArgTypes(methodInfo));
                        }
                        else
                        {
                            Output(swVB, "\t\t\tDim result As {0} = Plugin{1}({2})",
                                ChangeToVBType(ChangeToManagedType(methodInfo, methodInfo.ReturnType)),
                                methodInfo.Name,
                                RemoveVBArgTypes(methodInfo));
                        }
                    }

                    foreach (MetaArgInfo argInfo in methodInfo.DetailArgs)
                    {
                        if (argInfo.StrType == "char*" ||
                            argInfo.StrType == "const char*" ||
                            argInfo.StrType == "const wchar_t*")
                        {
                            string lpArg = string.Format("lp_{0}", UppercaseFirstLetter(argInfo.Name));

                            if (argInfo.StrType == "char*")
                            {
                                Output(swVB, "\t\t\tIf ({0} <> IntPtr.Zero)", lpArg);
                                Output(swVB, "\t\t\t\t{0} = Marshal.PtrToStringAnsi({1})", argInfo.Name, lpArg);
                                Output(swVB, "\t\t\t{0}", "End If");
                            }

                            Output(swVB, "\t\t\tFreeIntPtr({0})",
                                lpArg);

                        }
                    }

                    if (methodInfo.ReturnType == "void")
                    {
                        Output(swVB, "\t\t\tReturn Nothing");
                    }
                    else
                    {
                        Output(swVB, "\t\t\tReturn result");
                    }

                    Output(swVB, "\t\t{0}", "End Function");
                    Output(swVB, "");
                }

                Output(swVB, "\t\t#End Region");

                Output(swVB, "");

                Output(swVB, "\t\t#Region \"Private DLL Hooks\"");

                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(swVB, "\t\t{0}", "REM /// <summary>");

                    if (!string.IsNullOrEmpty(methodInfo.Comments))
                    {
                        Output(swVB, "\t\tREM /// {0}", SplitLongComments(methodInfo.Comments, "\t\tREM /// "));
                    }

                    Output(swVB, "\t\tREM /// EXPORT_API {0} Plugin{1}({2});",
                        methodInfo.ReturnType,
                        methodInfo.Name,
                        methodInfo.Args);

                    Output(swVB, "\t\t{0}", "REM /// </summary>");

                    Output(swVB, "\t\t{0}", "<DllImport(DLL_NAME, CallingConvention:=CallingConvention.Cdecl)>");

                    // for debugging
                    if (methodInfo.Name == "CoreInitSDK")
                    {
                        if (true)
                        {
                        }
                    }

                    if (methodInfo.ReturnType == "void")
                    {
                        Output(swVB, "\t\tPrivate Function Plugin{0}({1})",
                            methodInfo.Name,
                            ChangeArgsToVBImportTypes(methodInfo, methodInfo.Args));
                    }
                    else
                    {
                        Output(swVB, "\t\tPrivate Function Plugin{0}({1}) As {2}",
                            methodInfo.Name,
                            ChangeArgsToVBImportTypes(methodInfo, methodInfo.Args),
                            ChangeToVBImportType(methodInfo, methodInfo.ReturnType));
                    }
                    Output(swVB, "\t\tEnd Function");
                    Output(swVB, "");
                }

                Output(swVB, "\t\t#End Region");

                Output(swVB, "{0}", FOOTER_VB);

                swVB.Flush();
                swVB.Close();

                return true;
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Failed to write unity!");
                return false;
            }
        }

        #endregion VB

        #region Sort UE4 Header

        public static void SortHeaderUE4(string input,
            string outputHeader,
            string outputReadme)
        {
            if (File.Exists(input))
            {
                if (!ProcessSortHeaderUE4(input))
                {
                    return;
                }
            }

            if (File.Exists(outputHeader))
            {
                File.Delete(outputHeader);
            }
            using (FileStream fsHeader = File.Open(outputHeader, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter swHeader = new StreamWriter(fsHeader))
                {
                    if (!WriteSortHeaderUE4(swHeader))
                    {
                        return;
                    }
                }
            }

            if (File.Exists(outputReadme))
            {
                File.Delete(outputReadme);
            }
            using (FileStream fsDoc = File.Open(outputReadme, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter swDoc = new StreamWriter(fsDoc))
                {
                    if (!WriteReadmeUE4(swDoc))
                    {
                        return;
                    }
                }
            }

        }

        private static string GetNextWord(string line)
        {
            string result = "";
            for (int i = 0; i < line.Length; ++i)
            {
                char c = line[i];
                if (i == 0 && char.IsDigit(c))
                {
                    return "";
                }
                else if (char.IsLetterOrDigit(c) ||
                    c == '<' || c == '>' ||
                    c == '_' ||
                    c == ':')
                {
                    result += c;
                }
                else
                {
                    return result;
                }
            }
            return result;
        }

        private static bool GetUE4MethodName(string line, out string methodName)
        {
            const string TOKEN_STATIC = "static";
            string temp;
            if (line.StartsWith(TOKEN_STATIC))
            {
                temp = line.Substring(TOKEN_STATIC.Length).Trim();
            }
            else
            {
                temp = line;
            }

            string returnType = GetNextWord(temp);
            if (string.IsNullOrEmpty(returnType))
            {
                methodName = string.Empty;
                return false;
            }
            temp = temp.Substring(returnType.Length).Trim();
            methodName = GetNextWord(temp);

            return true;
        }

        class UnrealMetaMethodInfo
        {
            public string Name = string.Empty;
            public string Definition = string.Empty;
            public string Line = string.Empty;
        }

        private static SortedList<string, UnrealMetaMethodInfo> _sUnrealMethods = null;

        private static bool ProcessSortHeaderUE4(string fileInput)
        {
            try
            {
                const string TOKEN_UFUNCTION = @"UFUNCTION(";
                _sUnrealMethods = new SortedList<string, UnrealMetaMethodInfo>();
                string definition = string.Empty;
                using (FileStream fs = File.Open(fileInput, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line;
                        bool readMethod = false;
                        do
                        {
                            line = sr.ReadLine();
                            if (line == null ||
                                line == "\0")
                            {
                                break;
                            }
                            line = line.TrimStart();
                            if (line.StartsWith(TOKEN_UFUNCTION))
                            {
                                definition = line;
                                readMethod = true;
                            }
                            else if (readMethod)
                            {
                                readMethod = false;
                                UnrealMetaMethodInfo methodInfo = new UnrealMetaMethodInfo();
                                methodInfo.Definition = definition;

                                if (!GetUE4MethodName(line, out methodInfo.Name))
                                {
                                    continue;
                                }
                                if (string.IsNullOrEmpty(methodInfo.Name))
                                {
                                    continue;
                                }
                                Console.WriteLine("Method: {0}", methodInfo.Name);
                                methodInfo.Line = line;
                                methodInfo.Definition = definition;
                                _sUnrealMethods[methodInfo.Name] = methodInfo;
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

        static bool WriteSortHeaderUE4(StreamWriter swHeader)
        {
            try
            {
                Output(swHeader, "#pragma region Auto sort blueprint methods");
                Output(swHeader, string.Empty);

                foreach (KeyValuePair<string, UnrealMetaMethodInfo> unrealMethod in _sUnrealMethods)
                {
                    UnrealMetaMethodInfo unrealMethodInfo = unrealMethod.Value;

                    foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                    {

                        MetaMethodInfo methodInfo = method.Value;
                        if (methodInfo.Name != unrealMethodInfo.Name)
                        {
                            continue;
                        }

                        Output(swHeader, "\t/*");

                        if (!string.IsNullOrEmpty(methodInfo.Comments))
                        {
                            Output(swHeader, "\t{0}", SplitLongComments(methodInfo.Comments, "\t"));
                        }

                        Output(swHeader, "\t*/");
                    }

                    Output(swHeader, "\t{0}", unrealMethodInfo.Definition);
                    Output(swHeader, "\t{0}", unrealMethodInfo.Line);
                    Output(swHeader, string.Empty);
                }
                Output(swHeader, string.Empty);
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

        static string AddClassToMethodSignature(string methodSignature, string className, string separator)
        {
            string result = string.Empty;
            bool foundWhiteSpace = false;
            bool added = false;
            foreach (char c in methodSignature)
            {
                if (char.IsWhiteSpace(c))
                {
                    foundWhiteSpace = true;
                }
                else if (foundWhiteSpace && !added)
                {
                    result += className + separator;
                    added = true;
                }
                result += c;
            }
            return result;
        }

        static bool WriteReadmeUE4(StreamWriter swDoc)
        {
            try
            {
                foreach (KeyValuePair<string, UnrealMetaMethodInfo> unrealMethod in _sUnrealMethods)
                {
                    UnrealMetaMethodInfo unrealMethodInfo = unrealMethod.Value;

                    foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                    {

                        MetaMethodInfo methodInfo = method.Value;
                        if (methodInfo.Name != unrealMethodInfo.Name)
                        {
                            continue;
                        }

                        Output(swDoc, "* [{0}](#{0})", method.Value.Name);
                    }
                }

                Output(swDoc, string.Empty);

                Output(swDoc, "---");

                foreach (KeyValuePair<string, UnrealMetaMethodInfo> unrealMethod in _sUnrealMethods)
                {
                    UnrealMetaMethodInfo unrealMethodInfo = unrealMethod.Value;

                    foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                    {

                        MetaMethodInfo methodInfo = method.Value;
                        if (methodInfo.Name != unrealMethodInfo.Name)
                        {
                            continue;
                        }

                        Output(swDoc, "<a name=\"{0}\"></a>", method.Value.Name);
                        Output(swDoc, "**{0}**", method.Value.Name);
                        Output(swDoc, string.Empty);

                        if (!string.IsNullOrEmpty(methodInfo.Comments))
                        {
                            Output(swDoc, "{0}", SplitLongComments(methodInfo.Comments, string.Empty));
                        }
                        Output(swDoc, "```c++");
                        const string TOKEN_STATIC = "static ";
                        string methodSignature = unrealMethodInfo.Line;
                        if (methodSignature.StartsWith(TOKEN_STATIC))
                        {
                            methodSignature = methodSignature.Substring(TOKEN_STATIC.Length);
                        }
                        methodSignature = AddClassToMethodSignature(methodSignature, "UChromaSDKPluginBPLibrary", "::");
                        Output(swDoc, "{0}", SplitLongComments(methodSignature, "\t"));
                        Output(swDoc, "```");
                        Output(swDoc, string.Empty);

                        Output(swDoc, "---");
                    }
                }

                swDoc.Flush();
                swDoc.Close();

                return true;
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Failed to write header!");
                return false;
            }
        }

        #endregion

        static string GetJavaReturnType(string input)
        {
            switch (input.Trim())
            {
                case "const char*":
                    return "String";
                case "bool":
                    return "boolean";
                case "ChromaSDK::EFFECT_TYPE":
                case "ChromaSDK::ChromaLink::EFFECT_TYPE":
                case "ChromaSDK::Headset::EFFECT_TYPE":
                case "ChromaSDK::Keyboard::EFFECT_TYPE":
                case "ChromaSDK::Keypad::EFFECT_TYPE":
                case "ChromaSDK::Mouse::EFFECT_TYPE":
                case "ChromaSDK::Mousepad::EFFECT_TYPE":
                case "RZRESULT":
                    return "int";
                case "const byte*":
                case "int*":
                case "const int*":
                case "float*":
                case "PRZPARAM":
                case "RZEFFECTID*":
                case "DebugLogPtr":
                    return "Pointer";
                case "const ChromaSDK::FChromaSDKGuid&":
                case "ChromaSDK::FChromaSDKGuid*":
                case "RZDEVICEID":
                case "RZEFFECTID":
                    return "GUIDStruct";
                case "ChromaSDK::DEVICE_INFO_TYPE&":
                    return "DeviceInfos.DeviceInfosStruct";
            }
            return input;
        }

        static string GetJavaArgs(string input)
        {
            string[] parts = input.Split(",".ToCharArray());
            List<string> newParts = new List<string>();
            foreach (string part in parts)
            {
                string trimPart = part.Trim();
                int indexSpace = trimPart.LastIndexOf(" ");
                if (indexSpace > 0)
                {
                    string type = trimPart.Substring(0, indexSpace);
                    string name = trimPart.Substring(indexSpace);
                    string newType = GetJavaReturnType(type);
                    newParts.Add(string.Format("{0}{1}", newType, name));
                }
                else
                {
                    newParts.Add(trimPart); //unexpected format
                }
            }
            return string.Join(", ", newParts.ToArray());
        }

        static string GetJavaArgsWithoutType(string input)
        {
            string[] parts = input.Split(",".ToCharArray());
            List<string> newParts = new List<string>();
            foreach (string part in parts)
            {
                string trimPart = part.Trim();
                int indexSpace = trimPart.LastIndexOf(" ");
                if (indexSpace > 0)
                {
                    string name = trimPart.Substring(indexSpace);
                    newParts.Add(string.Format("{0}", name.Trim()));
                }
                else
                {
                    newParts.Add(trimPart); //unexpected format
                }
            }
            return string.Join(", ", newParts.ToArray());
        }

        static string GetGodotArgsWithoutType(string input)
        {
            string[] parts = input.Split(",".ToCharArray());
            List<string> newParts = new List<string>();
            foreach (string part in parts)
            {
                string trimPart = part.Trim();
                int indexSpace = trimPart.LastIndexOf(" ");
                if (indexSpace > 0)
                {
                    string name = trimPart.Substring(indexSpace);
                    string fieldName = name.Trim();
                    string fieldType = trimPart.Substring(0, indexSpace);
                    if (fieldType == "const char*")
                    {
                        fieldName += ".utf8().get_data()";
                    }
                    newParts.Add(string.Format("{0}", fieldName));
                }
                else
                {
                    newParts.Add(trimPart); //unexpected format
                }
            }
            return string.Join(", ", newParts.ToArray());
        }

        static bool HasGodotArrayArgs(string input)
        {
            string[] parts = input.Split(",".ToCharArray());
            foreach (string part in parts)
            {
                string trimPart = part.Trim();
                int indexSpace = trimPart.IndexOf(" ");
                if (indexSpace > 0)
                {
                    string fieldType = trimPart.Substring(0, indexSpace).Trim();
                    if (fieldType == "Array")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        struct GodotArrayConversion
        {
            public string OldField;
            public string NewField;
        }

        static string ConvertGodotArrayArgs(string parameters, string args, List<GodotArrayConversion> conversions)
        {
            string[] paramParts = parameters.Split(",".ToCharArray());
            string[] argsParts = args.Split(",".ToCharArray());
            if (paramParts.Length != argsParts.Length)
            {
                return args;
            }
            List<string> newParts = new List<string>();
            for (int i = 0; i < paramParts.Length; ++i)
            {
                string paramPart = paramParts[i].Trim();
                string fieldName = argsParts[i].Trim();
                int paramIndexSpace = paramPart.IndexOf(" ");
                if (paramIndexSpace > 0)
                {
                    string fieldType = paramPart.Substring(0, paramIndexSpace).Trim();
                    if (fieldType == "Array")
                    {
                        GodotArrayConversion conversion;
                        conversion.OldField = fieldName;
                        conversion.NewField = "ptr" + UppercaseFirstLetter(fieldName);
                        conversions.Add(conversion);

                        fieldName = conversion.NewField;
                    }
                    newParts.Add(fieldName);
                }
            }
            return string.Join(", ", newParts.ToArray());
        }

        static string LowercaseFirstLetter(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }
            else if (input.Length > 1)
            {
                return string.Format("{0}{1}", input.Substring(0, 1).ToLower(), input.Substring(1));
            }
            else
            {
                return input.ToLower();
            }
        }

        static bool WriteJavaInterface(StreamWriter swJava)
        {
            try
            {
                string header =
@"package com.razer.java;

import com.sun.jna.Library;
import com.sun.jna.Pointer;
import org.jglr.jchroma.devices.DeviceInfos;
import org.jglr.jchroma.devices.GUIDStruct;

/**
 * Wrapper used by JNA to load Razer Chroma SDK libraries.
 */
interface JChromaLib extends Library {
                ";
                Output(swJava, "{0}", header);
                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(swJava, "\t/*");

                    if (!string.IsNullOrEmpty(methodInfo.Comments))
                    {
                        Output(swJava, "\t{0}", SplitLongComments(methodInfo.Comments, "\t"));
                    }

                    Output(swJava, "\t*/");

                    Output(swJava, "\t/// EXPORT_API {0} Plugin{1}({2});",
                        methodInfo.ReturnType,
                        methodInfo.Name,
                        methodInfo.Args);

                    Output(swJava, "\t{0} Plugin{1}({2});",
                        GetJavaReturnType(methodInfo.ReturnType),
                        methodInfo.Name,
                        GetJavaArgs(methodInfo.Args));
                }

                Output(swJava, "");
                Output(swJava, "{0}", "}");

                swJava.Flush();
                swJava.Close();

                return true;
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Failed to write java!");
                return false;
            }
        }

        static bool WriteJavaSDK(StreamWriter swJava)
        {
            try
            {
                string header =
@"package com.razer.java;

import com.sun.jna.Native;
import com.sun.jna.Pointer;

import org.jglr.jchroma.devices.DeviceInfos;
import org.jglr.jchroma.devices.GUIDStruct;

/**
 * Entry point of the API, allows to create effects for the device and query Razer devices
 */
public class JChromaSDK {

    private static JChromaSDK instance;
    private final JChromaLib wrapper;

    private JChromaSDK() {
        String libName = ""CChromaEditorLibrary"";
        if (System.getProperty(""os.arch"").contains(""64""))
                {
                    libName += ""64"";
                }
                String path = System.getProperty(""user.dir"") + ""\\src\\main\\resources\\"";
                String fullPath = path + ""\\"" + libName;
                //System.out.println(""fullPath: ""+fullPath);
                wrapper = (JChromaLib)Native.loadLibrary(fullPath, JChromaLib.class);
    }

    /**
     * Returns the <code>JChroma</code> singleton. One must be warned that this method performs
     * lazy initialisation and that loading the native files is done at initialisation
     * @return
     *          The JChroma singleton
     */
    public static JChromaSDK getInstance()
    {
        if (instance == null)
            instance = new JChromaSDK();
        return instance;
    }
                ";
                Output(swJava, "{0}", header);
                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(swJava, "\t/*");

                    if (!string.IsNullOrEmpty(methodInfo.Comments))
                    {
                        Output(swJava, "\t{0}", SplitLongComments(methodInfo.Comments, "\t"));
                    }

                    Output(swJava, "\t*/");

                    Output(swJava, "\t/// EXPORT_API {0} Plugin{1}({2});",
                        methodInfo.ReturnType,
                        methodInfo.Name,
                        methodInfo.Args);

                    Output(swJava, "\tpublic {0} {1}({2})",
                        GetJavaReturnType(methodInfo.ReturnType),
                        LowercaseFirstLetter(methodInfo.Name),
                        GetJavaArgs(methodInfo.Args));

                    Output(swJava, "\t{0}", "{");
                    if (GetJavaReturnType(methodInfo.ReturnType).Trim() == "void")
                    {
                        Output(swJava, "\t\twrapper.Plugin{1}({2});",
                        GetJavaReturnType(methodInfo.ReturnType),
                        methodInfo.Name,
                        GetJavaArgsWithoutType(methodInfo.Args));
                    }
                    else
                    {
                        Output(swJava, "\t\treturn wrapper.Plugin{1}({2});",
                        GetJavaReturnType(methodInfo.ReturnType),
                        methodInfo.Name,
                        GetJavaArgsWithoutType(methodInfo.Args));
                    }
                    Output(swJava, "\t{0}", "}");
                }

                Output(swJava, "");
                Output(swJava, "{0}", "}");

                swJava.Flush();
                swJava.Close();

                return true;
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Failed to write java!");
                return false;
            }
        }
    }
}
