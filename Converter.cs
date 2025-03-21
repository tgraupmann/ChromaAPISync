﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace ChromaAPISync
{
    partial class Converter
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

        public static void ConvertExportsToClass(
            string input, string outputCppSortInput, bool upgradeToUnicode,
            string outputCppHeader, string outputCppImplementation,
            string outputChromaticCppHeader, string outputChromaticCppImplementation,
            string outputCppDocs,
            string outputUe4Header, string outputUe4Implementation,
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
            OpenClassFiles(
                input, outputCppSortInput, upgradeToUnicode,
                outputCppHeader, outputCppImplementation,
                outputChromaticCppHeader, outputChromaticCppImplementation,
                outputCppDocs,
                outputUe4Header, outputUe4Implementation,
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

        private static void OpenClassFiles(
            string input, string fileCppSortInput, bool upgradeToUnicode,
            string fileCppHeader, string fileCppImplementation,
            string fileChromaticCppHeader, string fileChromaticCppImplementation,
            string fileCppDocs,
            string fileUe4Header, string fileUe4Implementation,
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
                if (!ProcessStdafx(input, upgradeToUnicode))
                {
                    return;
                }
            }

            #region First, C++

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

            #region Chromatic, C++

            if (!Directory.Exists("Chromatic"))
            {
                Directory.CreateDirectory("Chromatic");
            }

            if (File.Exists(fileChromaticCppHeader))
            {
                File.Delete(fileChromaticCppHeader);
            }
            using (FileStream fsCppHeader = File.Open(fileChromaticCppHeader, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter swHeader = new StreamWriter(fsCppHeader))
                {
                    if (!WriteChromaticHeader(swHeader))
                    {
                        return;
                    }
                }
            }

            if (File.Exists(fileChromaticCppImplementation))
            {
                File.Delete(fileChromaticCppImplementation);
            }
            using (FileStream fsImplementation = File.Open(fileChromaticCppImplementation, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                using (StreamWriter swImplementation = new StreamWriter(fsImplementation))
                {
                    if (!WriteChromaticImplementation(swImplementation))
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

            #region UE4

            if (!Directory.Exists("UE"))
            {
                Directory.CreateDirectory("UE");
            }

            if (File.Exists(fileUe4Header))
            {
                File.Delete(fileUe4Header);
            }
            using (FileStream fsCppHeader = File.Open(fileCppHeader, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader srHeader = new StreamReader(fsCppHeader))
                {
                    using (FileStream fsUe4Header = File.Open(fileUe4Header, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
                    {
                        using (StreamWriter swHeader = new StreamWriter(fsUe4Header))
                        {
                            if (!WriteUe4ChromaAPIHeader(srHeader, swHeader))
                            {
                                return;
                            }
                        }
                    }
                }
            }

            if (File.Exists(fileUe4Implementation))
            {
                File.Delete(fileUe4Implementation);
            }
            using (FileStream fsImplementation = File.Open(fileCppImplementation, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader srImplementation = new StreamReader(fsImplementation))
                {
                    using (FileStream fsUe4Implementation = File.Open(fileUe4Implementation, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
                    {
                        using (StreamWriter swImplementation = new StreamWriter(fsUe4Implementation))
                        {
                            if (!WriteUe4ChromaAPIImplementation(srImplementation, swImplementation))
                            {
                                return;
                            }
                        }
                    }
                }
            }

            #endregion UE4

            // return; // DEBUG SKIP OTHERS

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
                    if (!WriteVBDocs(swVBDocs, "ChromaAnimationAPI"))
                    {
                        return;
                    }
                }
            }

            #endregion VB

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
                    if (!WriteCSharpDocs(swUnityDocs, "ChromaAnimationAPI"))
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

        static bool ReplaceEnd(ref string line, string search, string replace)
        {
            if (line.EndsWith(search))
            {
                line = line.Substring(0, line.Length - search.Length) + replace;
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
            ReplaceEnd(ref result, "_1D_", "_1D");
            ReplaceEnd(ref result, "_2D_", "_2D");
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

        private static string LowercaseFirstLetterArgTypes(MetaMethodInfo methodInfo)
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

                    string nextPart = argInfo.StrType + " " + LowercaseFirstLetter(name);
                    if (i > 0)
                    {
                        nextPart = " " + nextPart;
                    }
                    parts[i] = nextPart;
                }
            }
            return string.Join(",", parts);
        }

        private static string RemoveArgTypesCppUnicodeToAscii(MetaMethodInfo methodInfo)
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
                    switch (argInfo.Name)
                    {
                        case "streamId":
                        case "streamKey":
                        case "shortcode":
                        case "focus":
                            break;
                        default:
                            if (argInfo.StrType == "const char*")
                            {
                                string wstrArg = string.Format("wstr_{0}.c_str()", UppercaseFirstLetter(name));
                                name = wstrArg;
                            }
                            break;
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
                    else if (argInfo.StrType == "float*")
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
            else if (result == "const BYTE*")
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
            else if (result == "const BYTE*")
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
            else if (result == "float*")
            {
                result = "out float";
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

        static bool ProcessStdafx(string fileInput, bool upgradeToUnicode)
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
                                comments += (line + " ").Replace("  ", " ");
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

                            if (upgradeToUnicode && !line.Contains("Stream"))
                            {
                                Replace(ref line, "const char*", "const wchar_t*");
                            }

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

#include ""ChromaSDKPluginTypes.h""

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
		static bool _sInvalidSignature;
		static HMODULE _sLibrary;

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
		static int UninitAPI();
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
@"#include ""ChromaAnimationAPI.h""
#include ""ChromaLogger.h""
#include ""VerifyLibrarySignature.h""
#include <iostream>
#include <tchar.h>


#ifdef _WIN64
#define CHROMA_EDITOR_DLL	L""CChromaEditorLibrary64.dll""
#else
#define CHROMA_EDITOR_DLL	L""CChromaEditorLibrary.dll""
#endif


using namespace ChromaSDK;
using namespace std;

HMODULE ChromaAnimationAPI::_sLibrary = nullptr;
bool ChromaAnimationAPI::_sInvalidSignature = false;
bool ChromaAnimationAPI::_sIsInitializedAPI = false;

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
	cerr << ""Failed to find method: "" << (""Plugin"" #FieldName) << endl; \
    return -1; \
}

int ChromaAnimationAPI::InitAPI()
{
	// abort load if an invalid signature was detected
	if (_sInvalidSignature)
	{
		return RZRESULT_DLL_INVALID_SIGNATURE;
	}

	if (_sIsInitializedAPI)
	{
		return 0;
	}

	wchar_t filename[MAX_PATH]; //this is a char buffer
	GetModuleFileNameW(NULL, filename, sizeof(filename));

	std::wstring path;
	const size_t last_slash_idx = std::wstring(filename).rfind('\\');
	if (std::string::npos != last_slash_idx)
	{
		path = std::wstring(filename).substr(0, last_slash_idx);
	}

	path += L""\\"";
	path += CHROMA_EDITOR_DLL;

	// check the library file version
	if (!VerifyLibrarySignature::IsFileVersionSameOrNewer(path.c_str(), 1, 0, 0, 7))
	{
		ChromaLogger::fprintf(stderr, ""Detected old version of Chroma Editor Library!\r\n"");
		return RZRESULT_DLL_NOT_FOUND;
	}

#ifdef CHECK_CHROMA_LIBRARY_SIGNATURE
	_sInvalidSignature = !VerifyLibrarySignature::VerifyModule(path);
#endif

	if (_sInvalidSignature)
	{
		ChromaLogger::fprintf(stderr, ""Chroma Editor Library has an invalid signature!\r\n"");
		return RZRESULT_DLL_INVALID_SIGNATURE;
	}

	HMODULE library = LoadLibrary(path.c_str());
	if (library == NULL)
	{ 
		ChromaLogger::fprintf(stderr, ""Failed to load Chroma Editor Library!\r\n"");
        return RZRESULT_DLL_NOT_FOUND;
	}

	_sLibrary = library;
	
	//ChromaLogger::fprintf(stderr, ""Loaded Chroma Editor DLL!\r\n"");
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

                string cpp_footer_start =
@"
	//ChromaLogger::printf(stdout, ""Validated all DLL methods [success]\r\n"");
	_sIsInitializedAPI = true;
	return 0;
}

bool ChromaAnimationAPI::GetIsInitializedAPI()
{
	return _sIsInitializedAPI;
}

#undef CHROMASDK_DECLARE_METHOD_CLEAR
#define CHROMASDK_DECLARE_METHOD_CLEAR(FieldName) ChromaAnimationAPI::FieldName = nullptr;

int ChromaAnimationAPI::UninitAPI()
{
	if (nullptr != UnloadLibrarySDK)
	{
		UnloadLibrarySDK();
	}

	if (nullptr != UnloadLibraryStreamingPlugin)
	{
		UnloadLibraryStreamingPlugin();
	}

	if (nullptr != _sLibrary)
	{
		FreeLibrary(_sLibrary);
		_sLibrary = nullptr;
	}

#pragma region Free API Methods
";
                Output(swImplementation, "{0}", cpp_footer_start);

                string cpp_footer_end =
                @"
#pragma endregion

	_sIsInitializedAPI = false;
	
	return 0;
}";

                // loop through methods to free
                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(swImplementation, "\tCHROMASDK_DECLARE_METHOD_CLEAR({0});",
                        methodInfo.Name);
                }

                Output(swImplementation, "{0}", cpp_footer_end);

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

        static bool WriteChromaticHeader(StreamWriter swHeader)
        {
            try
            {
                string header =
@"#pragma once

#include ""ChromaSDKPluginTypes.h""

namespace ChromaSDK
{
	/* Setup log mechanism */
	typedef void (*DebugLogPtr)(const char *);
	void LogDebug(const char *text, ...);
	void LogError(const char *text, ...);
	/* End of setup log mechanism */

	class ChromaAnimationAPI
	{
	public:

                ";
                Output(swHeader, "{0}", header);
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

                    Output(swHeader, "\t\tstatic {0} {1}({2});",
                        methodInfo.ReturnType, methodInfo.Name, methodInfo.Args);
                }
                Output(swHeader, "#pragma endregion");

                Output(swHeader, "");

                string footer =
@"
		static int InitAPI();
		static int UninitAPI();
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

        static bool WriteChromaticImplementation(StreamWriter swImplementation)
        {
            try
            {
                Console.WriteLine();

                string header =
@"#include ""ChromaAnimationAPI.h""
#include ""UnicodeChromaAnimationAPI.h""
#include ""ChromaLogger.h""
#include ""VerifyLibrarySignature.h""
#include <iostream>
#include <tchar.h>


using namespace std;

namespace ChromaSDK {

	int ChromaAnimationAPI::InitAPI()
	{
		return UnicodeChromaAnimationAPI::InitAPI();
	}

	bool ChromaAnimationAPI::GetIsInitializedAPI()
	{
		return UnicodeChromaAnimationAPI::GetIsInitializedAPI();
	}

	int ChromaAnimationAPI::UninitAPI()
	{
		return UnicodeChromaAnimationAPI::UninitAPI();
	}
";
                Output(swImplementation, "{0}", header);

                Output(swImplementation, "#pragma region API declare prototypes");
                Output(swImplementation, "");
                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(swImplementation, "\t/*");

                    if (!string.IsNullOrEmpty(methodInfo.Comments))
                    {
                        Output(swImplementation, "\t\t{0}", SplitLongComments(methodInfo.Comments, "\t\t"));
                    }

                    Output(swImplementation, "\t*/");

                    Output(swImplementation, "\t{0} ChromaAnimationAPI::{1}({2})",
                        methodInfo.ReturnType, methodInfo.Name, LowercaseFirstLetterArgTypes(methodInfo));
                    
                    Output(swImplementation, "\t{0}", "{");

                    // convert const char* to wchar_t*

                    foreach (MetaArgInfo argInfo in methodInfo.DetailArgs)
                    {
                        if (argInfo.StrType == "const char*")
                        {
                            switch(argInfo.Name)
                            {
                                case "streamId":
                                case "streamKey":
                                case "shortcode":
                                case "focus":
                                    break;
                                default:
                                    string pathStr = string.Format("str_{0}", UppercaseFirstLetter(argInfo.Name));
                                    string pathWStr = string.Format("wstr_{0}", UppercaseFirstLetter(argInfo.Name));
                                    Output(swImplementation, "\t\tstring {0} = {1};",
                                                pathStr,
                                                argInfo.Name);
                                    Output(swImplementation, "\t\twstring {0}({1}.begin(), {1}.end());",
                                                pathWStr,
                                                pathStr);
                                    break;
                            }
                        }
                    }

                    if (methodInfo.ReturnType == "void")
                    {
                        Output(swImplementation, "\t\tUnicodeChromaAnimationAPI::{0}({1});",
                            methodInfo.Name,
                            RemoveArgTypesCppUnicodeToAscii(methodInfo));
                    }
                    else
                    {
                        Output(swImplementation, "\t\treturn UnicodeChromaAnimationAPI::{0}({1});",
                            methodInfo.Name,
                            RemoveArgTypesCppUnicodeToAscii(methodInfo));
                    }

                    Output(swImplementation, "\t{0}", "}");
                }
                Output(swImplementation, "#pragma endregion");

                Output(swImplementation, "");

                Output(swImplementation, "{0}", "}");

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
    #elif UNITY_64 || UNITY_EDITOR
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
        // DEVICE_KEYBOARD = 1
        // DEVICE_MOUSE = 2
		// DEVICE_HEADSET = 3
		// DEVICE_MOUSEPAD = 4
		// DEVICE_KEYPAD = 5
		// DEVICE_SYSTEM = 6
		// DEVICE_SPEAKERS = 7
		// DEVICE_CHROMALINK = 8
		// DEVICE_ALL = 255,
        public int DeviceType;
        public uint Connected;
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

#if ENABLE_IL2CPP

		[DllImport(""version.dll"", CharSet = CharSet.Unicode)]
		private static extern int GetFileVersionInfoSize(string lptstrFilename, out uint lpdwHandle);
		[DllImport(""version.dll"", CharSet = CharSet.Unicode)]
		private static extern bool GetFileVersionInfo(string lptstrFilename, uint dwHandle, uint dwLen, IntPtr lpData);
		[DllImport(""version.dll"", CharSet = CharSet.Unicode)]
		private static extern bool VerQueryValue(IntPtr pBlock, string lpSubBlock, out IntPtr lplpBuffer, out uint puLen);
		public static string GetProductVersion(string filePath)
		{
			string fileVersion = null;
			uint handle;
			int size = GetFileVersionInfoSize(filePath, out handle);
			if (size > 0)
			{
				IntPtr buffer = Marshal.AllocHGlobal(size);
				if (GetFileVersionInfo(filePath, handle, (uint)size, buffer))
				{
					IntPtr pValue;
					uint len;
					if (VerQueryValue(buffer, ""\\StringFileInfo\\040904b0\\FileVersion"", out pValue, out len))
					{
						fileVersion = Marshal.PtrToStringUni(pValue);
						//Debug.Log(""File Version: "" + fileVersion);
					}
				}
				Marshal.FreeHGlobal(buffer);
			}
			return fileVersion;
		}

#endif

        /// <summary>
        /// Check if the ChromaSDK DLL exists before calling API Methods
        /// </summary>
        /// <returns></returns>
        public static bool IsChromaSDKAvailable()
        {
#if PLATFORM_XBOXONE
			return true;
#endif
            try
            {
                String fileName;
#if UNITY_64
                fileName = @""C:\Program Files\Razer Chroma SDK\bin\RzChromatic64.dll"";
#else
                fileName = @""C:\Program Files (x86)\Razer Chroma SDK\bin\RzChromatic.dll"";
#endif
                FileInfo fi = new FileInfo(fileName);
                if (!fi.Exists)
                {
                    return false;
                }

#if ENABLE_IL2CPP
				String fileVersion = GetProductVersion(fileName);
#else
                System.Diagnostics.FileVersionInfo versionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(fileName);


                String fileVersion = versionInfo.FileVersion;
#endif
                //Debug.Log(string.Format(""ChromaSDK Version={0} File={1}"", fileVersion, fileName));
                String[] versionParts = fileVersion.Split(""."".ToCharArray());
                if (versionParts.Length < 4)
                {
                    return false;
                }

                int major;
                if (!int.TryParse(versionParts[0], out major))
                {
                    return false;
                }

                int minor;
                if (!int.TryParse(versionParts[1], out minor))
                {
                    return false;
                }

                int build;
                if (!int.TryParse(versionParts[2], out build))
                {
                    return false;
                }

                int revision;
                if (!int.TryParse(versionParts[3], out revision))
                {
                    return false;
                }

                // Anything less than the min version returns false

                // major, minor, build, revision ref: https://learn.microsoft.com/en-us/dotnet/api/system.reflection.assemblyversionattribute.-ctor?source=recommendations&view=net-7.0
                const int minMajor = 1;
                const int minMinor = 0;
                const int minBuild = 0;
                const int minRevision = 6;

                if (major < minMajor) // Less than minMajor
                {
                    return false;
                }

                if (major == minMajor && minor < minMinor) // Less than minMinor
                {
                    return false;
                }

                if (major == minMajor && minor == minMinor && build < minBuild) // Less than minBuild
                {
                    return false;
                }

                if (major == minMajor && minor == minMinor && build == minBuild && revision < minRevision) // Less than minRevision
                {
                    return false;
                }

                return true; // production version or better
            }
            catch (Exception ex)
            {
                Debug.LogError(string.Format(""The ChromaSDK is not available! Exception={0}"", ex));
            }
            return false;
        }

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
            KeyboardExtended = 6,
            MAX = 7,
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
            KeyboardExtended = 3,
            MAX = 4,
        }

		public class FChromaSDKDeviceFrameIndex
		{
			// Index corresponds to EChromaSDKDeviceEnum;
			public int[] _mFrameIndex = new int[(int)Device.MAX];

			public FChromaSDKDeviceFrameIndex()
			{
				_mFrameIndex[(int)Device.ChromaLink] = 0;
				_mFrameIndex[(int)Device.Headset] = 0;
				_mFrameIndex[(int)Device.Keyboard] = 0;
				_mFrameIndex[(int)Device.Keypad] = 0;
				_mFrameIndex[(int)Device.Mouse] = 0;
				_mFrameIndex[(int)Device.Mousepad] = 0;
				_mFrameIndex[(int)Device.KeyboardExtended] = 0;
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
            public bool GetState(int effect)
            {
                if (effect >= 0 && effect < _mEffects.Count)
                {
                    return _mEffects[effect]._mState;
                }
                else
                {
                    return false;
                }
            }
            public void ToggleState(int effect)
            {
                if (effect >= 0 && effect < _mEffects.Count)
                {
                    _mEffects[effect]._mState = !_mEffects[effect]._mState;
                }
            }
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

    public static int UninitAPI()
    {
        UnloadLibrarySDK();
        UnloadLibraryStreamingPlugin();

        return 0;
    }

__UNITY_GET_STREAMING_PATH__
#endregion
";

        private const string FOOTER_UNITY =
@"  }
}";

        static bool WriteCSharpDocs(StreamWriter swUnityDocs, string apiClass)
        {
            try
            {
                string header = @"<a name=""full-api""></a>
## Full API
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

    Public Class Keyboard
    
        REM //! Definitions of keys.
        Public Enum RZKEY
            RZKEY_ESC = &H1                 REM /*!< Esc (VK_ESCAPE) */
            RZKEY_F1 = &H3                  REM /*!< F1 (VK_F1) */
            RZKEY_F2 = &H4                  REM /*!< F2 (VK_F2) */
            RZKEY_F3 = &H5                  REM /*!< F3 (VK_F3) */
            RZKEY_F4 = &H6                  REM /*!< F4 (VK_F4) */
            RZKEY_F5 = &H7                  REM /*!< F5 (VK_F5) */
            RZKEY_F6 = &H8                  REM /*!< F6 (VK_F6) */
            RZKEY_F7 = &H9                  REM /*!< F7 (VK_F7) */
            RZKEY_F8 = &HA                  REM /*!< F8 (VK_F8) */
            RZKEY_F9 = &HB                  REM /*!< F9 (VK_F9) */
            RZKEY_F10 = &HC                 REM /*!< F10 (VK_F10) */
            RZKEY_F11 = &HD                 REM /*!< F11 (VK_F11) */
            RZKEY_F12 = &HE                 REM /*!< F12 (VK_F12) */
            RZKEY_1 = &H102                   REM /*!< 1 (VK_1) */
            RZKEY_2 = &H103                   REM /*!< 2 (VK_2) */
            RZKEY_3 = &H104                   REM /*!< 3 (VK_3) */
            RZKEY_4 = &H105                   REM /*!< 4 (VK_4) */
            RZKEY_5 = &H106                   REM /*!< 5 (VK_5) */
            RZKEY_6 = &H107                   REM /*!< 6 (VK_6) */
            RZKEY_7 = &H108                   REM /*!< 7 (VK_7) */
            RZKEY_8 = &H109                   REM /*!< 8 (VK_8) */
            RZKEY_9 = &H10A                   REM /*!< 9 (VK_9) */
            RZKEY_0 = &H10B                   REM /*!< 0 (VK_0) */
            RZKEY_A = &H302                   REM /*!< A (VK_A) */
            RZKEY_B = &H407                   REM /*!< B (VK_B) */
            RZKEY_C = &H405                   REM /*!< C (VK_C) */
            RZKEY_D = &H304                   REM /*!< D (VK_D) */
            RZKEY_E = &H204                   REM /*!< E (VK_E) */
            RZKEY_F = &H305                   REM /*!< F (VK_F) */
            RZKEY_G = &H306                   REM /*!< G (VK_G) */
            RZKEY_H = &H307                   REM /*!< H (VK_H) */
            RZKEY_I = &H209                   REM /*!< I (VK_I) */
            RZKEY_J = &H308                   REM /*!< J (VK_J) */
            RZKEY_K = &H309                   REM /*!< K (VK_K) */
            RZKEY_L = &H30A                   REM /*!< L (VK_L) */
            RZKEY_M = &H409                   REM /*!< M (VK_M) */
            RZKEY_N = &H408                   REM /*!< N (VK_N) */
            RZKEY_O = &H20A                   REM /*!< O (VK_O) */
            RZKEY_P = &H20B                   REM /*!< P (VK_P) */
            RZKEY_Q = &H202                   REM /*!< Q (VK_Q) */
            RZKEY_R = &H205                   REM /*!< R (VK_R) */
            RZKEY_S = &H303                   REM /*!< S (VK_S) */
            RZKEY_T = &H206                   REM /*!< T (VK_T) */
            RZKEY_U = &H208                   REM /*!< U (VK_U) */
            RZKEY_V = &H406                   REM /*!< V (VK_V) */
            RZKEY_W = &H203                   REM /*!< W (VK_W) */
            RZKEY_X = &H404                   REM /*!< X (VK_X) */
            RZKEY_Y = &H207                   REM /*!< Y (VK_Y) */
            RZKEY_Z = &H403                   REM /*!< Z (VK_Z) */
            RZKEY_NUMLOCK = &H112             REM /*!< Numlock (VK_NUMLOCK) */
            RZKEY_NUMPAD0 = &H513             REM /*!< Numpad 0 (VK_NUMPAD0) */
            RZKEY_NUMPAD1 = &H412             REM /*!< Numpad 1 (VK_NUMPAD1) */
            RZKEY_NUMPAD2 = &H413             REM /*!< Numpad 2 (VK_NUMPAD2) */
            RZKEY_NUMPAD3 = &H414             REM /*!< Numpad 3 (VK_NUMPAD3) */
            RZKEY_NUMPAD4 = &H312             REM /*!< Numpad 4 (VK_NUMPAD4) */
            RZKEY_NUMPAD5 = &H313             REM /*!< Numpad 5 (VK_NUMPAD5) */
            RZKEY_NUMPAD6 = &H314             REM /*!< Numpad 6 (VK_NUMPAD6) */
            RZKEY_NUMPAD7 = &H212             REM /*!< Numpad 7 (VK_NUMPAD7) */
            RZKEY_NUMPAD8 = &H213             REM /*!< Numpad 8 (VK_NUMPAD8) */
            RZKEY_NUMPAD9 = &H214             REM /*!< Numpad 9 (VK_ NUMPAD9*/
            RZKEY_NUMPAD_DIVIDE = &H113       REM /*!< Divide (VK_DIVIDE) */
            RZKEY_NUMPAD_MULTIPLY = &H114     REM /*!< Multiply (VK_MULTIPLY) */
            RZKEY_NUMPAD_SUBTRACT = &H115     REM /*!< Subtract (VK_SUBTRACT) */
            RZKEY_NUMPAD_ADD = &H215          REM /*!< Add (VK_ADD) */
            RZKEY_NUMPAD_ENTER = &H415        REM /*!< Enter (VK_RETURN - Extended) */
            RZKEY_NUMPAD_DECIMAL = &H514      REM /*!< Decimal (VK_DECIMAL) */
            RZKEY_PRINTSCREEN = &HF         REM /*!< Print Screen (VK_PRINT) */
            RZKEY_SCROLL = &H10              REM /*!< Scroll Lock (VK_SCROLL) */
            RZKEY_PAUSE = &H11               REM /*!< Pause (VK_PAUSE) */
            RZKEY_INSERT = &H10F              REM /*!< Insert (VK_INSERT) */
            RZKEY_HOME = &H110                REM /*!< Home (VK_HOME) */
            RZKEY_PAGEUP = &H111              REM /*!< Page Up (VK_PRIOR) */
            RZKEY_DELETE = &H20F              REM /*!< Delete (VK_DELETE) */
            RZKEY_END = &H210                 REM /*!< End (VK_END) */
            RZKEY_PAGEDOWN = &H211            REM /*!< Page Down (VK_NEXT) */
            RZKEY_UP = &H410                  REM /*!< Up (VK_UP) */
            RZKEY_LEFT = &H50F                REM /*!< Left (VK_LEFT) */
            RZKEY_DOWN = &H510                REM /*!< Down (VK_DOWN) */
            RZKEY_RIGHT = &H511               REM /*!< Right (VK_RIGHT) */
            RZKEY_TAB = &H201                 REM /*!< Tab (VK_TAB) */
            RZKEY_CAPSLOCK = &H301            REM /*!< Caps Lock(VK_CAPITAL) */
            RZKEY_BACKSPACE = &H10E           REM /*!< Backspace (VK_BACK) */
            RZKEY_ENTER = &H30E               REM /*!< Enter (VK_RETURN) */
            RZKEY_LCTRL = &H501               REM /*!< Left Control(VK_LCONTROL) */
            RZKEY_LWIN = &H502                REM /*!< Left Window (VK_LWIN) */
            RZKEY_LALT = &H503                REM /*!< Left Alt (VK_LMENU) */
            RZKEY_SPACE = &H507               REM /*!< Spacebar (VK_SPACE) */
            RZKEY_RALT = &H50B                REM /*!< Right Alt (VK_RMENU) */
            RZKEY_FN = &H50C                  REM /*!< Function key. */
            RZKEY_RMENU = &H50D               REM /*!< Right Menu (VK_APPS) */
            RZKEY_RCTRL = &H50E               REM /*!< Right Control (VK_RCONTROL) */
            RZKEY_LSHIFT = &H401              REM /*!< Left Shift (VK_LSHIFT) */
            RZKEY_RSHIFT = &H40E              REM /*!< Right Shift (VK_RSHIFT) */
            RZKEY_MACRO1 = &H100              REM /*!< Macro Key 1 */
            RZKEY_MACRO2 = &H200              REM /*!< Macro Key 2 */
            RZKEY_MACRO3 = &H300              REM /*!< Macro Key 3 */
            RZKEY_MACRO4 = &H400              REM /*!< Macro Key 4 */
            RZKEY_MACRO5 = &H500              REM /*!< Macro Key 5 */
            RZKEY_OEM_1 = &H101               REM /*!< ~ (tilde/半角/全角) (VK_OEM_3) */
            RZKEY_OEM_2 = &H10C               REM /*!< -- (minus) (VK_OEM_MINUS) */
            RZKEY_OEM_3 = &H10D               REM /*!< = (equal) (VK_OEM_PLUS) */
            RZKEY_OEM_4 = &H20C               REM /*!< [ (left sqaure bracket) (VK_OEM_4) */
            RZKEY_OEM_5 = &H20D               REM /*!< ] (right square bracket) (VK_OEM_6) */
            RZKEY_OEM_6 = &H20E               REM /*!< \ (backslash) (VK_OEM_5) */
            RZKEY_OEM_7 = &H30B               REM /*!< ; (semi-colon) (VK_OEM_1) */
            RZKEY_OEM_8 = &H30C               REM /*!< ' (apostrophe) (VK_OEM_7) */
            RZKEY_OEM_9 = &H40A               REM /*!< , (comma) (VK_OEM_COMMA) */
            RZKEY_OEM_10 = &H40B              REM /*!< . (period) (VK_OEM_PERIOD) */
            RZKEY_OEM_11 = &H40C              REM /*!< / (forward slash) (VK_OEM_2) */
            RZKEY_EUR_1 = &H30D               REM /*!< ""#"" (VK_OEM_5) */
            RZKEY_EUR_2 = &H402               REM /*!< \ (VK_OEM_102) */
            RZKEY_JPN_1 = &H15                REM /*!< ¥ (&HFF) */
            RZKEY_JPN_2 = &H40D               REM /*!< \ (&HC1) */
            RZKEY_JPN_3 = &H504               REM /*!< 無変換 (VK_OEM_PA1) */
            RZKEY_JPN_4 = &H509               REM /*!< 変換 (&HFF) */
            RZKEY_JPN_5 = &H50A               REM /*!< ひらがな/カタカナ (&HFF) */
            RZKEY_KOR_1 = &H15                REM /*!< | (&HFF) */
            RZKEY_KOR_2 = &H30D               REM /*!< (VK_OEM_5) */
            RZKEY_KOR_3 = &H402               REM /*!< (VK_OEM_102) */
            RZKEY_KOR_4 = &H40D               REM /*!< (&HC1) */
            RZKEY_KOR_5 = &H504               REM /*!< (VK_OEM_PA1) */
            RZKEY_KOR_6 = &H509               REM /*!< 한/영 (&HFF) */
            RZKEY_KOR_7 = &H50A               REM /*!< (&HFF) */
            RZKEY_INVALID = &HFFFF            REM /*!< Invalid keys. */
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
        Public DeviceType As Integer
        Public Connected As UInteger
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
        Dim array As Byte() = ASCIIEncoding.ASCII.GetBytes(fi.FullName + ControlChars.NullChar)
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
        Dim array As Byte() = ASCIIEncoding.ASCII.GetBytes(str + ControlChars.NullChar)
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
        Dim array As Byte() = UnicodeEncoding.Unicode.GetBytes(str + ControlChars.NullChar)
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

    Public Function UninitAPI() As Integer
        UnloadLibrarySDK()
        UnloadLibraryStreamingPlugin()
        Return 0
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
                case "string":
                    result = "String";
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
            else if (result == "const BYTE*")
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

        static bool WriteVBDocs(StreamWriter swVBDocs, string apiClass)
        {
            try
            {
                string header = @"<a name=""api""></a>
## API
";
                Output(swVBDocs, header);

                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;
                    Output(swVBDocs, "* [{0}](#{0})", methodInfo.Name);
                }

                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(swVBDocs, "---");
                    Output(swVBDocs, string.Empty);

                    Output(swVBDocs, @"<a name=""{0}""></a>", methodInfo.Name);
                    Output(swVBDocs, @"**{0}**", methodInfo.Name);
                    Output(swVBDocs, string.Empty);

                    if (!string.IsNullOrEmpty(methodInfo.Comments))
                    {
                        Output(swVBDocs, "{0}", SplitLongComments(methodInfo.Comments, ""));
                        Output(swVBDocs, string.Empty);
                    }

                    Output(swVBDocs, "{0}", "```vb");
                    if (methodInfo.ReturnType == "void")
                    {
                        Output(swVBDocs, "{0}.{1}({2})",
                            apiClass, 
                            methodInfo.Name,
                            ChangeArgsToVBTypes(methodInfo));
                    }
                    else
                    {
                        Output(swVBDocs, "Dim result As {0} = {1}.{2}({3})",
                                ChangeToVBType(ChangeToManagedType(methodInfo, methodInfo.ReturnType)),
                                apiClass,
                                methodInfo.Name,
                                ChangeArgsToVBTypes(methodInfo));
                    }
                    Output(swVBDocs, "{0}", "```");
                    Output(swVBDocs, string.Empty);
                }

                swVBDocs.Flush();
                swVBDocs.Close();

                return true;
            }
            catch (Exception)
            {
                Console.Error.WriteLine("Failed to write vb docs!");
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
                            string unrealMethodName = string.Format("Core" + unrealMethodInfo.Name);
                            if (methodInfo.Name != unrealMethodName)
                            {
                                continue;
                            }
                        }

                        Output(swDoc, "* [{0}](#{0})", unrealMethodInfo.Name);
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
                            string unrealMethodName = string.Format("Core" + unrealMethodInfo.Name);
                            if (methodInfo.Name != unrealMethodName)
                            {
                                continue;
                            }
                        }

                        Output(swDoc, "<a name=\"{0}\"></a>", unrealMethodInfo.Name);
                        Output(swDoc, "**{0}**", unrealMethodInfo.Name);
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
                case "const BYTE*":
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

        static string GetCppArgsWithoutType(string input)
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
