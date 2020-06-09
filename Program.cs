namespace ChromaAPISync
{
    class Program
    {
        static void Main(string[] args)
        {
            const string headerStdafx = @"C:\Razer\CChromaEditor\CChromaEditorLibrary\stdafx.h";
            Converter.ConvertExportsToClass(headerStdafx,
                "ChromaAnimationAPI.h", "ChromaAnimationAPI.cpp",
                "ChromaAnimationAPI.md",
                "ChromaAnimationAPI.cs",
                @"Unity\ChromaAnimationAPI.cs",
                @"Unity\ChromaAnimationAPI.md",
                "stdafx.h",
                "JChromaLib.java",
                "JChromaSDK.java",
                "Godot.h",
                "Godot.cpp");
            const string headerUE4 = @"C:\Razer\UE4_XDK_SampleApp\UE4ChromaSDKRT\Plugins\ChromaSDKPlugin\Source\ChromaSDKPlugin\Public\ChromaSDKPluginBPLibrary.h";
            Converter.SortHeaderUE4(headerUE4,
                "ChromaSDKPluginBPLibrary.h",
                "ChromaSDKPluginBPLibrary.md");
        }
    }
}
