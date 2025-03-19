namespace ChromaAPISync
{
    class Program
    {
        static void Main(string[] args)
        {
            // ascii branch
            const string headerStdafx = @"C:\Public\CChromaEditor_Ascii\CChromaEditorLibrary\stdafx.h";

            bool upgradeToUnicode = false;

            // unicode branch
            //const string headerStdafx = @"C:\Public\CChromaEditor_Unicode\CChromaEditorLibrary\stdafx.h";

            Converter.ConvertExportsToClass(
                headerStdafx, "stdafx.h", upgradeToUnicode,
                "ChromaAnimationAPI.h", "ChromaAnimationAPI.cpp",
                @"Chromatic\ChromaAnimationAPI.h", @"Chromatic\ChromaAnimationAPI.cpp",
                "ChromaAnimationAPI.md",
                @"UE\ChromaAnimationAPI.h", @"UE\ChromaAnimationAPI.cpp",
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

            // ascii branch
            const string headerUE4 = @"C:\Public\Unreal_ChromaSDK_Ascii\Chroma_Sample\Plugins\ChromaSDKPlugin\Source\ChromaSDKPlugin\Public\ChromaSDKPluginBPLibrary.h";

            // unicode branch
            //const string headerUE4 = @"C:\Public\Unreal_ChromaSDK_Unicode\Chroma_Sample\Plugins\ChromaSDKPlugin\Source\ChromaSDKPlugin\Public\ChromaSDKPluginBPLibrary.h";

            Converter.SortHeaderUE4(headerUE4,
                "ChromaSDKPluginBPLibrary.h",
                "ChromaSDKPluginBPLibrary.md");
        }
    }
}
