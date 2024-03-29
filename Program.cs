﻿namespace ChromaAPISync
{
    class Program
    {
        static void Main(string[] args)
        {
            // ascii branch
            const string headerStdafx = @"C:\Public\CChromaEditor_Debug\CChromaEditorLibrary\stdafx.h";

            bool upgradeToUnicode = false;

            // unicode branch
            //const string headerStdafx = @"C:\Public\CChromaEditor_Unicode\CChromaEditorLibrary\stdafx.h";

            Converter.ConvertExportsToClass(
                headerStdafx, "stdafx.h", upgradeToUnicode,
                "ChromaAnimationAPI.h", "ChromaAnimationAPI.cpp",
                "ChromaAnimationAPI.md",
                @"UE4\ChromaAnimationAPI.h", @"UE4\ChromaAnimationAPI.cpp",
                @"CSharp\ChromaAnimationAPI.cs",
                @"CSharp\ChromaAnimationAPI.md",
                @"Unity\ChromaAnimationAPI.cs",
                @"Unity\ChromaAnimationAPI.md",
                @"VB\ChromaAnimationAPI.vb",
                @"VB\ChromaAnimationAPI.md",
                "JChromaLib.java",
                "JChromaSDK.java",
                "Godot.h",
                "Godot.cpp",
                "ClickTeamFusion.h",
                "ClickTeamFusion.cpp");
            const string headerUE4 = @"D:\Public\UE4_XDK_SampleApp\UE4ChromaSDKRT\Plugins\ChromaSDKPlugin\Source\ChromaSDKPlugin\Public\ChromaSDKPluginBPLibrary.h";
            Converter.SortHeaderUE4(headerUE4,
                "ChromaSDKPluginBPLibrary.h",
                "ChromaSDKPluginBPLibrary.md");
        }
    }
}
