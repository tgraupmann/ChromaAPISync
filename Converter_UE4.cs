using System;
using System.Collections.Generic;
using System.IO;

namespace ChromaAPISync
{
    partial class Converter
    {
        static bool WriteUe4ChromaAPIHeader(StreamReader sr, StreamWriter sw)
        {
            string line;
            try
            {
                do
                {
                    line = sr.ReadLine();
                    if (line == null ||
                        line == "\0")
                    {
                        break;
                    }

                    Replace(ref line, "#pragma once", @"#pragma once

#include ""Logging/LogMacros.h""
DECLARE_LOG_CATEGORY_EXTERN(LogChromaAnimationAPI, Log, All);");

                    Replace(ref line, "ChromaSDK::FChromaSDKGuid", "FChromaSDKGuid");

                    Output(sw, "{0}", line);
                }
                while (line != null);

                sw.Flush();
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Failed to write UE4 header exception: {0}", ex);

            }
            return true;
        }

        static bool WriteUe4ChromaAPIImplementation(StreamReader sr, StreamWriter sw)
        {
            string line;
            try
            {
                do
                {
                    line = sr.ReadLine();
                    if (line == null ||
                        line == "\0")
                    {
                        break;
                    }

                    Replace(ref line, "#include \"VerifyLibrarySignature.h\"", @"#if !PLATFORM_XBOXONE
#include ""VerifyLibrarySignature.h""
#endif");

                    Replace(ref line, "#ifdef _WIN64", @"DEFINE_LOG_CATEGORY(LogChromaAnimationAPI);


#if PLATFORM_XBOXONE
#define CHROMA_EDITOR_DLL	L""CChromaEditorLibrary64.dll""
#else

#ifdef _WIN64");

                    Replace(ref line, "using namespace ChromaSDK;", @"#endif


using namespace ChromaSDK;");

                    Replace(ref line, @"#define CHROMASDK_VALIDATE_METHOD(Signature, FieldName) FieldName = (Signature) GetProcAddress(library, ""Plugin"" #FieldName); \",
                        @"#define CHROMASDK_VALIDATE_METHOD(Signature, FieldName) FieldName = reinterpret_cast<Signature>(reinterpret_cast<void*>(GetProcAddress(library, ""Plugin"" #FieldName))); \");

                    if (line.Trim() == "std::wstring path;")
                    {
                        continue;
                    }

                    Replace(ref line, @"wchar_t filename[MAX_PATH]; //this is a char buffer", @"	std::wstring path;

#if PLATFORM_XBOXONE
	path = CHROMA_EDITOR_DLL;
#else

	
#if PLATFORM_WINDOWS && WITH_EDITOR
	FString projectDir = FPaths::ProjectDir();
	projectDir = projectDir.Replace(TEXT(""/""), TEXT(""\\""));
	path = TCHAR_TO_WCHAR(*projectDir);
	path += L""Binaries\\Win64"";
#else
	wchar_t filename[MAX_PATH]; //this is a char buffer");

                    Replace(ref line, @"path += L""\\"";", @"#endif

	path += L""\\"";");

                    Replace(ref line, "HMODULE library = LoadLibrary(path.c_str());", @"#endif

#if PLATFORM_XBOXONE
	//UE_LOG(LogChromaAnimationAPI, Log, TEXT(""Load CChromaEditorLibrary64 at: %s""), *FString(path.c_str()));
#endif

	HMODULE library = LoadLibrary(path.c_str());");

                    Replace(ref line, @"ChromaLogger::fprintf(stderr, ""Failed to load Chroma Editor Library!\r\n"");", @"UE_LOG(LogChromaAnimationAPI, Error, TEXT(""Failed to load Chroma Editor Library!""));
		ChromaLogger::fprintf(stderr, ""Failed to load Chroma Editor Library!\r\n"");");

                    Replace(ref line, @"//ChromaLogger::fprintf(stderr, ""Loaded Chroma Editor DLL!\r\n"");", @"//ChromaLogger::fprintf(stderr, ""Loaded Chroma Editor DLL!\r\n"");
	//UE_LOG(LogChromaAnimationAPI, Log, TEXT(""Loaded Chroma Editor DLL!""));	");

                    Replace(ref line, @"//ChromaLogger::printf(stdout, ""Validated all DLL methods [success]\r\n"");", @"//ChromaLogger::printf(stdout, ""Validated all DLL methods [success]\r\n"");
	//UE_LOG(LogChromaAnimationAPI, Log, TEXT(""Validated all DLL methods [success]""));");

                    Output(sw, "{0}", line);
                }
                while (line != null);

                sw.Flush();
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Failed to write UE4 implementaiton exception: {0}", ex);
            }
            return true;
        }
    }
}
