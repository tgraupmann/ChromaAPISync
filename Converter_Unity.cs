using System;
using System.Collections.Generic;
using System.IO;

namespace ChromaAPISync
{
    partial class Converter
    {
        static bool WriteUnity(StreamWriter sw)
        {
            try
            {
                string header = HEADER_CSHARP.Replace("__UNITY_INCLUDES__", HEADER_UNITY_INCLUDES);
                header = header.Replace("__UNITY_DLL_NAME__", HEADER_UNITY_DLL_NAME);
                header = header.Replace("__UNITY_KEY_MAPPING__", HEADER_UNITY_KEY_MAPPING);
                header = header.Replace("__UNITY_GET_STREAMING_PATH__", HEADER_UNITY_GET_STREAMING_PATH);
                Output(sw, "{0}", header);

                Output(sw, "");

                Output(sw, "\t\t#region Public API Methods");

                Output(sw, "\t\tpublic static string _sStreamingAssetPath = string.Empty;");

                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    Output(sw, "\t\t{0}", "/// <summary>");

                    if (!string.IsNullOrEmpty(methodInfo.Comments))
                    {
                        Output(sw, "\t\t/// {0}", SplitLongComments(methodInfo.Comments, "\t\t/// "));
                    }

                    Output(sw, "\t\t{0}", "/// </summary>");

                    Output(sw, "\t\tpublic static {0} {1}({2})",
                        ChangeToManagedType(methodInfo, methodInfo.ReturnType),
                        methodInfo.Name,
                        ChangeArgsToManagedTypes(methodInfo));

                    Output(sw, "\t\t{0}", "{");
                    foreach (MetaArgInfo argInfo in methodInfo.DetailArgs)
                    {
                        if (argInfo.StrType == "char*" ||
                            argInfo.StrType == "const char*" ||
                            argInfo.StrType == "const wchar_t*")
                        {
                            string pathArg = string.Format("str_{0}", UppercaseFirstLetter(argInfo.Name));
                            switch (argInfo.Name)
                            {
                                case "shortcode":
                                case "platform":
                                case "title":
                                case "streamId":
                                case "streamKey":
                                case "focus":
                                    Output(sw, "\t\t\tstring {0} = {1};",
                                        pathArg,
                                        argInfo.Name);
                                    break;
                                default:
                                    Output(sw, "\t\t\tstring {0} = GetStreamingPath({1});",
                                        pathArg,
                                        argInfo.Name);
                                    break;
                            }

                            string lpArg = string.Format("lp_{0}", UppercaseFirstLetter(argInfo.Name));
                            if (argInfo.StrType == "char*")
                            {
                                Output(sw, "\t\t\tIntPtr {0} = GetAsciiIntPtr({1});",
                                lpArg,
                                pathArg);
                            }
                            else if (argInfo.StrType == "const char*")
                            {
                                if (argInfo.Name.ToUpper().Contains("PATH") ||
                                    argInfo.Name.ToUpper().Contains("ANIMATION") ||
                                    argInfo.Name.ToUpper().Contains("NAME"))
                                {
                                    Output(sw, "\t\t\tIntPtr {0} = GetPathIntPtr({1});",
                                        lpArg,
                                        pathArg);
                                }
                                else
                                {
                                    Output(sw, "\t\t\tIntPtr {0} = GetAsciiIntPtr({1});",
                                        lpArg,
                                        pathArg);
                                }
                            }
                            else if (argInfo.StrType == "const wchar_t*")
                            {
                                Output(sw, "\t\t\tIntPtr {0} = GetUnicodeIntPtr({1});",
                                    lpArg,
                                    pathArg);
                            }

                        }
                    }
                    if (methodInfo.ReturnType == "void")
                    {
                        Output(sw, "\t\t\tPlugin{0}({1});",
                            methodInfo.Name,
                            RemoveArgTypes(methodInfo));
                    }
                    else
                    {
                        if (methodInfo.ReturnType == "const char*")
                        {
                            Output(sw, "\t\t\t{0} result = Marshal.PtrToStringAnsi(Plugin{1}({2}));",
                                ChangeToManagedType(methodInfo, methodInfo.ReturnType),
                                methodInfo.Name,
                                RemoveArgTypes(methodInfo));
                        }
                        else
                        {
                            Output(sw, "\t\t\t{0} result = Plugin{1}({2});",
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
                                Output(sw, "\t\t\tif ({0} != IntPtr.Zero)", lpArg);
                                Output(sw, "\t\t\t{0}", "{");
                                Output(sw, "\t\t\t\t{0} = Marshal.PtrToStringAnsi({1});", argInfo.Name, lpArg);
                                Output(sw, "\t\t\t{0}", "}");
                            }

                            Output(sw, "\t\t\tFreeIntPtr({0});",
                                lpArg);

                        }
                    }

                    if (methodInfo.ReturnType != "void")
                    {
                        Output(sw, "\t\t\treturn result;");
                    }

                    Output(sw, "\t\t{0}", "}");
                }

                Output(sw, "\t\t#endregion");

                Output(sw, "");

                Output(sw, "\t\t#region Private DLL Hooks");

                foreach (KeyValuePair<string, MetaMethodInfo> method in _sMethods)
                {
                    MetaMethodInfo methodInfo = method.Value;

                    if (methodInfo.Name == "CoreCreateEffect")
                    {
                        if (true)
                        {

                        }
                    }

                    Output(sw, "\t\t{0}", "/// <summary>");

                    if (!string.IsNullOrEmpty(methodInfo.Comments))
                    {
                        Output(sw, "\t\t/// {0}", SplitLongComments(methodInfo.Comments, "\t\t/// "));
                    }

                    Output(sw, "\t\t/// EXPORT_API {0} Plugin{1}({2});",
                        methodInfo.ReturnType,
                        methodInfo.Name,
                        methodInfo.Args);

                    Output(sw, "\t\t{0}", "/// </summary>");

                    Output(sw, "\t\t{0}", "[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl)]");

                    string csReturnType = ChangeToManagedImportType(methodInfo, methodInfo.ReturnType);

                    if (csReturnType == "bool")
                    {
                        Output(sw, "\t\t{0}", "[return: MarshalAs(UnmanagedType.I1)]");
                    }
                    Output(sw, "\t\tprivate static extern {0} Plugin{1}({2});",
                        csReturnType,
                        methodInfo.Name,
                        ChangeArgsToManagedImportTypes(methodInfo, methodInfo.Args));
                }

                Output(sw, "\t\t#endregion");

                Output(sw, "{0}", FOOTER_UNITY);

                sw.Flush();
                sw.Close();

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
