using System;
using System.Collections.Generic;
using System.IO;

namespace ChromaAPISync
{
    partial class Converter
    {
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
                                Output(swVB, "\t\t\tIf ({0} <> IntPtr.Zero) Then", lpArg);
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
                        Output(swVB, "\t\tPrivate Function Plugin{0}({1}) As Boolean", // void return type needs a dummy return type
                            methodInfo.Name,
                            ChangeArgsToVBImportTypes(methodInfo, methodInfo.Args));
                    }
                    else
                    {
                        string vbReturnType = ChangeToVBImportType(methodInfo, methodInfo.ReturnType);
                        if (vbReturnType == "Boolean")
                        {
                            Output(swVB, "\t\tPrivate Function Plugin{0}({1}) As <MarshalAs(UnmanagedType.I1)> {2}",
                                methodInfo.Name,
                                ChangeArgsToVBImportTypes(methodInfo, methodInfo.Args),
                                vbReturnType);
                        }
                        else
                        {
                            Output(swVB, "\t\tPrivate Function Plugin{0}({1}) As {2}",
                                methodInfo.Name,
                                ChangeArgsToVBImportTypes(methodInfo, methodInfo.Args),
                                vbReturnType);
                        }
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
    }
}
